Imports System.Data.SqlClient

Public Class payment


    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbBanks.Items.Clear()
        cmbBanks.Items.AddRange(New Object() {"Maybank2u", "CIMB Clicks", "Public Bank", "RHB Now", "Bank Islam"})
        cmbBanks.SelectedIndex = 0

        cmbEwalletType.Items.Clear()
        cmbEwalletType.Items.AddRange(New Object() {"Touch 'n Go eWallet", "GrabPay", "Boost", "ShopeePay"})
        cmbEwalletType.SelectedIndex = 0
        ShowPaymentPanel(pnlCreditCard)
        HighlightActiveButton(btnCreditCard)
    End Sub


    Private Sub ShowPaymentPanel(panelToShow As Panel)

        pnlCreditCard.Visible = False
        pnlOnlineBanking.Visible = False
        pnlEWallet.Visible = False
        panelToShow.Visible = True
        panelToShow.BringToFront()
    End Sub

    Private Sub HighlightActiveButton(activeButton As Button)
        Dim navigationButtons() As Button = {btnCreditCard, btnOnlineBanking, btnEWallet}
        For Each btn As Button In navigationButtons
            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
        Next
        activeButton.BackColor = Color.LightGray
        activeButton.ForeColor = Color.Black
    End Sub


    Private Sub btnCreditCard_Click(sender As Object, e As EventArgs) Handles btnCreditCard.Click
        ShowPaymentPanel(pnlCreditCard)
        HighlightActiveButton(btnCreditCard)
    End Sub

    Private Sub btnOnlineBanking_Click(sender As Object, e As EventArgs) Handles btnOnlineBanking.Click
        ShowPaymentPanel(pnlOnlineBanking)
        HighlightActiveButton(btnOnlineBanking)
    End Sub

    Private Sub btnEWallet_Click(sender As Object, e As EventArgs) Handles btnEWallet.Click
        ShowPaymentPanel(pnlEWallet)
        HighlightActiveButton(btnEWallet)

        UpdateQRCodeImage()
    End Sub

    Private Function GetOrAssignGate(conn As SqlConnection, flightID As Integer) As String
        Dim checkGateQuery As String = "SELECT Gate FROM Flights WHERE FlightID = @FlightID"
        Using cmdCheckGate As New SqlCommand(checkGateQuery, conn)
            cmdCheckGate.Parameters.AddWithValue("@FlightID", flightID)
            Dim existingGate As Object = cmdCheckGate.ExecuteScalar()

            If existingGate Is Nothing OrElse existingGate Is DBNull.Value Then
                Dim newGate As String = "G" & New Random().Next(1, 26).ToString()
                Dim updateGateQuery As String = "UPDATE Flights SET Gate = @Gate WHERE FlightID = @FlightID"
                Using cmdUpdateGate As New SqlCommand(updateGateQuery, conn)
                    cmdUpdateGate.Parameters.AddWithValue("@Gate", newGate)
                    cmdUpdateGate.Parameters.AddWithValue("@FlightID", flightID)
                    cmdUpdateGate.ExecuteNonQuery()
                End Using
                Return newGate
            Else

                Return existingGate.ToString()
            End If
        End Using
    End Function


    Private Sub btnPayCreditCard_Click(sender As Object, e As EventArgs) Handles btnPayCreditCard.Click
        If String.IsNullOrWhiteSpace(txtCardNumber.Text) OrElse String.IsNullOrWhiteSpace(txtCVV.Text) Then
            MessageBox.Show("Please complete all required fields within the Credit/Debit card form.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim pnrCode As String = "PNR" & New Random().Next(1000, 9999).ToString()
        Dim newBookingID As Integer = 0

        Dim grandTotal As Decimal = BookingSession.SelectedPrice
        Dim assignedSeats As New List(Of String)
        Dim assignedGate As String = ""

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Try
                conn.Open()
                Dim bookQuery As String = "INSERT INTO Bookings (PNR, UserID, FlightID, TripType, ReturnDate, TotalPrice, BookingStatus) OUTPUT INSERTED.BookingID VALUES (@PNR, @UserID, @FlightID, @TripType, @ReturnDate, @Total, 'Confirmed')"
                Using cmdBook As New SqlCommand(bookQuery, conn)
                    cmdBook.Parameters.AddWithValue("@PNR", pnrCode)
                    cmdBook.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                    cmdBook.Parameters.AddWithValue("@FlightID", BookingSession.SelectedFlightID)
                    cmdBook.Parameters.AddWithValue("@TripType", BookingSession.TripType)

                    If BookingSession.TripType = "Round-Trip" Then
                        cmdBook.Parameters.AddWithValue("@ReturnDate", Convert.ToDateTime(BookingSession.ReturnDate))
                    Else
                        cmdBook.Parameters.AddWithValue("@ReturnDate", DBNull.Value)
                    End If

                    cmdBook.Parameters.AddWithValue("@Total", grandTotal)
                    newBookingID = Convert.ToInt32(cmdBook.ExecuteScalar())
                End Using
                assignedGate = GetOrAssignGate(conn, BookingSession.SelectedFlightID)

                Dim seatArray() As String = BookingSession.SelectedSeat.Split(","c)

                For i As Integer = 0 To BookingSession.PassengerNames.Count - 1
                    Dim passQuery As String = "INSERT INTO Passengers (BookingID, FirstName, LastName, SeatNumber, FrequentFlyerProgram) VALUES (@BID, @FName, @LName, @Seat, @Prog)"
                    Using cmdPass As New SqlCommand(passQuery, conn)
                        cmdPass.Parameters.AddWithValue("@BID", newBookingID)

                        Dim names() As String = BookingSession.PassengerNames(i).Trim().Split(" "c)
                        cmdPass.Parameters.AddWithValue("@FName", names(0))
                        cmdPass.Parameters.AddWithValue("@LName", If(names.Length > 1, names(names.Length - 1), ""))
                        Dim thisSeat As String = If(i < seatArray.Length, seatArray(i).Trim(), "LAP")
                        cmdPass.Parameters.AddWithValue("@Seat", thisSeat)
                        assignedSeats.Add(thisSeat)

                        cmdPass.Parameters.AddWithValue("@Prog", BookingSession.FrequentFlyerProgram)
                        cmdPass.ExecuteNonQuery()
                    End Using
                Next

            Catch ex As Exception
                MessageBox.Show("Error saving ticket to Database: " & ex.Message)
                Exit Sub
            End Try
        End Using

        MessageBox.Show($"Payment Successful! Total charged: RM {grandTotal:N2}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Dim ticketScreen As New frmDisplayTicket()

        For i As Integer = 0 To BookingSession.PassengerNames.Count - 1
            Dim t As New frmDisplayTicket.TicketData()
            t.Departure = BookingSession.SelectedDeparture
            t.Destination = BookingSession.SelectedDestination
            t.PassengerName = BookingSession.PassengerNames(i)
            t.ProgramName = BookingSession.FrequentFlyerProgram
            t.FlightDate = BookingSession.SelectedDate
            t.FlightTime = BookingSession.SelectedTime
            t.FlightName = BookingSession.SelectedFlight
            t.Gate = assignedGate
            t.Seat = assignedSeats(i)
            t.TicketPrice = "RM " & (grandTotal / BookingSession.TotalPassengers).ToString("N2")
            ticketScreen.Tickets.Add(t)
        Next

        Me.Hide()
        ticketScreen.Show()
    End Sub


    Private Sub btnPayOnlineBanking_Click(sender As Object, e As EventArgs) Handles btnPayOnlineBanking.Click
        Dim selectedBank As String = cmbBanks.SelectedItem.ToString()

        Dim pnrCode As String = "PNR" & New Random().Next(1000, 9999).ToString()
        Dim newBookingID As Integer = 0

        Dim grandTotal As Decimal = BookingSession.SelectedPrice
        Dim assignedSeats As New List(Of String)
        Dim assignedGate As String = ""

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Try
                conn.Open()

                Dim bookQuery As String = "INSERT INTO Bookings (PNR, UserID, FlightID, TripType, ReturnDate, TotalPrice, BookingStatus) OUTPUT INSERTED.BookingID VALUES (@PNR, @UserID, @FlightID, @TripType, @ReturnDate, @Total, 'Confirmed')"
                Using cmdBook As New SqlCommand(bookQuery, conn)
                    cmdBook.Parameters.AddWithValue("@PNR", pnrCode)
                    cmdBook.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                    cmdBook.Parameters.AddWithValue("@FlightID", BookingSession.SelectedFlightID)
                    cmdBook.Parameters.AddWithValue("@TripType", BookingSession.TripType)

                    If BookingSession.TripType = "Round-Trip" Then
                        cmdBook.Parameters.AddWithValue("@ReturnDate", Convert.ToDateTime(BookingSession.ReturnDate))
                    Else
                        cmdBook.Parameters.AddWithValue("@ReturnDate", DBNull.Value)
                    End If

                    cmdBook.Parameters.AddWithValue("@Total", grandTotal)
                    newBookingID = Convert.ToInt32(cmdBook.ExecuteScalar())
                End Using

                assignedGate = GetOrAssignGate(conn, BookingSession.SelectedFlightID)

                Dim seatArray() As String = BookingSession.SelectedSeat.Split(","c)

                For i As Integer = 0 To BookingSession.PassengerNames.Count - 1
                    Dim passQuery As String = "INSERT INTO Passengers (BookingID, FirstName, LastName, SeatNumber, FrequentFlyerProgram) VALUES (@BID, @FName, @LName, @Seat, @Prog)"
                    Using cmdPass As New SqlCommand(passQuery, conn)
                        cmdPass.Parameters.AddWithValue("@BID", newBookingID)

                        Dim names() As String = BookingSession.PassengerNames(i).Trim().Split(" "c)
                        cmdPass.Parameters.AddWithValue("@FName", names(0))
                        cmdPass.Parameters.AddWithValue("@LName", If(names.Length > 1, names(names.Length - 1), ""))

                        Dim thisSeat As String = If(i < seatArray.Length, seatArray(i).Trim(), "LAP")
                        cmdPass.Parameters.AddWithValue("@Seat", thisSeat)
                        assignedSeats.Add(thisSeat)

                        cmdPass.Parameters.AddWithValue("@Prog", BookingSession.FrequentFlyerProgram)
                        cmdPass.ExecuteNonQuery()
                    End Using
                Next

            Catch ex As Exception
                MessageBox.Show("Error saving ticket to Database: " & ex.Message)
                Exit Sub
            End Try
        End Using

        MessageBox.Show($"Payment Successful! Total charged: RM {grandTotal:N2}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim ticketScreen As New frmDisplayTicket()

        For i As Integer = 0 To BookingSession.PassengerNames.Count - 1
            Dim t As New frmDisplayTicket.TicketData()
            t.Departure = BookingSession.SelectedDeparture
            t.Destination = BookingSession.SelectedDestination
            t.PassengerName = BookingSession.PassengerNames(i)
            t.ProgramName = BookingSession.FrequentFlyerProgram
            t.FlightDate = BookingSession.SelectedDate
            t.FlightTime = BookingSession.SelectedTime
            t.FlightName = BookingSession.SelectedFlight
            t.Gate = assignedGate
            t.Seat = assignedSeats(i)
            t.TicketPrice = "RM " & (grandTotal / BookingSession.TotalPassengers).ToString("N2")
            ticketScreen.Tickets.Add(t)
        Next

        Me.Hide()
        ticketScreen.Show()
    End Sub


    Private Sub cmbEWalletType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEwalletType.SelectedIndexChanged
        UpdateQRCodeImage()
    End Sub

    Private Sub UpdateQRCodeImage()
        If cmbEwalletType.SelectedItem Is Nothing Then Exit Sub

        Dim selectedWallet As String = cmbEwalletType.SelectedItem.ToString()

        picQRCode.SizeMode = PictureBoxSizeMode.Zoom
        Select Case selectedWallet
            Case "Touch 'n Go eWallet"
                ' picQRCode.Image = My.Resources.tng_qr_file
            Case "GrabPay"
                ' picQRCode.Image = My.Resources.grab_qr_file
            Case "Boost"
                ' picQRCode.Image = My.Resources.boost_qr_file
            Case "ShopeePay"
                ' picQRCode.Image = My.Resources.shopee_qr_file
        End Select
    End Sub

    Private Sub btnPayEWallet_Click(sender As Object, e As EventArgs) Handles btnPayEWallet.Click
        If String.IsNullOrWhiteSpace(txtWalletPhone.Text) Then
            MessageBox.Show("Please type your verified mobile phone number assigned to this digital account.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedWallet As String = cmbEwalletType.SelectedItem.ToString()

        Dim pnrCode As String = "PNR" & New Random().Next(1000, 9999).ToString()
        Dim newBookingID As Integer = 0

        Dim grandTotal As Decimal = BookingSession.SelectedPrice
        Dim assignedSeats As New List(Of String)
        Dim assignedGate As String = ""

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Try
                conn.Open()
                Dim bookQuery As String = "INSERT INTO Bookings (PNR, UserID, FlightID, TripType, ReturnDate, TotalPrice, BookingStatus) OUTPUT INSERTED.BookingID VALUES (@PNR, @UserID, @FlightID, @TripType, @ReturnDate, @Total, 'Confirmed')"
                Using cmdBook As New SqlCommand(bookQuery, conn)
                    cmdBook.Parameters.AddWithValue("@PNR", pnrCode)
                    cmdBook.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                    cmdBook.Parameters.AddWithValue("@FlightID", BookingSession.SelectedFlightID)
                    cmdBook.Parameters.AddWithValue("@TripType", BookingSession.TripType)

                    If BookingSession.TripType = "Round-Trip" Then
                        cmdBook.Parameters.AddWithValue("@ReturnDate", Convert.ToDateTime(BookingSession.ReturnDate))
                    Else
                        cmdBook.Parameters.AddWithValue("@ReturnDate", DBNull.Value)
                    End If

                    cmdBook.Parameters.AddWithValue("@Total", grandTotal)
                    newBookingID = Convert.ToInt32(cmdBook.ExecuteScalar())
                End Using

                assignedGate = GetOrAssignGate(conn, BookingSession.SelectedFlightID)


                Dim seatArray() As String = BookingSession.SelectedSeat.Split(","c)

                For i As Integer = 0 To BookingSession.PassengerNames.Count - 1
                    Dim passQuery As String = "INSERT INTO Passengers (BookingID, FirstName, LastName, SeatNumber, FrequentFlyerProgram) VALUES (@BID, @FName, @LName, @Seat, @Prog)"
                    Using cmdPass As New SqlCommand(passQuery, conn)
                        cmdPass.Parameters.AddWithValue("@BID", newBookingID)

                        Dim names() As String = BookingSession.PassengerNames(i).Trim().Split(" "c)
                        cmdPass.Parameters.AddWithValue("@FName", names(0))
                        cmdPass.Parameters.AddWithValue("@LName", If(names.Length > 1, names(names.Length - 1), ""))
                        Dim thisSeat As String = If(i < seatArray.Length, seatArray(i).Trim(), "LAP")
                        cmdPass.Parameters.AddWithValue("@Seat", thisSeat)
                        assignedSeats.Add(thisSeat)

                        cmdPass.Parameters.AddWithValue("@Prog", BookingSession.FrequentFlyerProgram)
                        cmdPass.ExecuteNonQuery()
                    End Using
                Next

            Catch ex As Exception
                MessageBox.Show("Error saving ticket to Database: " & ex.Message)
                Exit Sub
            End Try
        End Using

        MessageBox.Show($"Payment Successful! Total charged: RM {grandTotal:N2}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim ticketScreen As New frmDisplayTicket()

        For i As Integer = 0 To BookingSession.PassengerNames.Count - 1
            Dim t As New frmDisplayTicket.TicketData()
            t.Departure = BookingSession.SelectedDeparture
            t.Destination = BookingSession.SelectedDestination
            t.PassengerName = BookingSession.PassengerNames(i)
            t.ProgramName = BookingSession.FrequentFlyerProgram
            t.FlightDate = BookingSession.SelectedDate
            t.FlightTime = BookingSession.SelectedTime
            t.FlightName = BookingSession.SelectedFlight
            t.Gate = assignedGate
            t.Seat = assignedSeats(i)
            t.TicketPrice = "RM " & (grandTotal / BookingSession.TotalPassengers).ToString("N2")
            ticketScreen.Tickets.Add(t)
        Next

        Me.Hide()
        ticketScreen.Show()
    End Sub

End Class