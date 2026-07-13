Imports System.Data.SqlClient

Public Class payment

    ' ========================================================
    ' FORM INITIALIZATION & LOAD EVENT
    ' ========================================================
    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Populate Online Banking Dropdown items
        cmbBanks.Items.Clear()
        cmbBanks.Items.AddRange(New Object() {"Maybank2u", "CIMB Clicks", "Public Bank", "RHB Now", "Bank Islam"})
        cmbBanks.SelectedIndex = 0 ' Default to first bank

        ' 2. Populate E-Wallet Dropdown items
        cmbEwalletType.Items.Clear()
        cmbEwalletType.Items.AddRange(New Object() {"Touch 'n Go eWallet", "GrabPay", "Boost", "ShopeePay"})
        cmbEwalletType.SelectedIndex = 0 ' Default to first e-wallet

        ' 3. Establish initial UI state (Show Credit Card frame first)
        ShowPaymentPanel(pnlCreditCard)
        HighlightActiveButton(btnCreditCard)
    End Sub

    ' ========================================================
    ' INTERFACE MANAGEMENT (PANELS & TABS)
    ' ========================================================
    Private Sub ShowPaymentPanel(panelToShow As Panel)
        ' Hide all panels to prevent overlap conflicts
        pnlCreditCard.Visible = False
        pnlOnlineBanking.Visible = False
        pnlEWallet.Visible = False

        ' Display the requested active panel container
        panelToShow.Visible = True
        panelToShow.BringToFront()
    End Sub

    Private Sub HighlightActiveButton(activeButton As Button)
        Dim navigationButtons() As Button = {btnCreditCard, btnOnlineBanking, btnEWallet}

        ' Reset all side-bar buttons back to white background
        For Each btn As Button In navigationButtons
            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
        Next

        ' Style the clicked/active method
        activeButton.BackColor = Color.LightGray
        activeButton.ForeColor = Color.Black
    End Sub

    ' ========================================================
    ' LEFT PANEL NAVIGATION CONTROLS
    ' ========================================================
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
        ' Run update rule to ensure a QR displays instantly when panel mounts
        UpdateQRCodeImage()
    End Sub

    ' ========================================================
    ' SHARED HELPER: Assigns (or reuses) a Gate for a given flight and persists it
    ' NEW: Centralizes the gate logic so all three payment methods behave identically
    ' and so a bug fix only ever needs to happen in one place going forward.
    ' ========================================================
    Private Function GetOrAssignGate(conn As SqlConnection, flightID As Integer) As String
        Dim checkGateQuery As String = "SELECT Gate FROM Flights WHERE FlightID = @FlightID"
        Using cmdCheckGate As New SqlCommand(checkGateQuery, conn)
            cmdCheckGate.Parameters.AddWithValue("@FlightID", flightID)
            Dim existingGate As Object = cmdCheckGate.ExecuteScalar()

            If existingGate Is Nothing OrElse existingGate Is DBNull.Value Then
                ' No gate yet — generate one and save it
                Dim newGate As String = "G" & New Random().Next(1, 26).ToString()
                Dim updateGateQuery As String = "UPDATE Flights SET Gate = @Gate WHERE FlightID = @FlightID"
                Using cmdUpdateGate As New SqlCommand(updateGateQuery, conn)
                    cmdUpdateGate.Parameters.AddWithValue("@Gate", newGate)
                    cmdUpdateGate.Parameters.AddWithValue("@FlightID", flightID)
                    cmdUpdateGate.ExecuteNonQuery()
                End Using
                Return newGate
            Else
                ' Gate already assigned for this flight — reuse it so every passenger on
                ' the same flight sees the same value
                Return existingGate.ToString()
            End If
        End Using
    End Function

    ' ========================================================
    ' 1. CREDIT/DEBIT CARD LOGIC
    ' ========================================================
    Private Sub btnPayCreditCard_Click(sender As Object, e As EventArgs) Handles btnPayCreditCard.Click
        ' Enforce mandatory card formatting rules
        If String.IsNullOrWhiteSpace(txtCardNumber.Text) OrElse String.IsNullOrWhiteSpace(txtCVV.Text) Then
            MessageBox.Show("Please complete all required fields within the Credit/Debit card form.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' --- DATABASE SYNC: SAVE MULTIPLE PASSENGERS ---
        Dim pnrCode As String = "PNR" & New Random().Next(1000, 9999).ToString()
        Dim newBookingID As Integer = 0

        Dim grandTotal As Decimal = BookingSession.SelectedPrice
        Dim assignedSeats As New List(Of String)
        Dim assignedGate As String = "" ' Holds the flight's actual gate, read from or written to the DB

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Try
                conn.Open()
                ' 1. Insert into Bookings 
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

                ' 2. Get or assign this flight's Gate (persisted, shared across all passengers/bookings on this flight)
                assignedGate = GetOrAssignGate(conn, BookingSession.SelectedFlightID)

                ' 3. LOOP TO INSERT EVERY PASSENGER
                Dim seatArray() As String = BookingSession.SelectedSeat.Split(","c)

                For i As Integer = 0 To BookingSession.PassengerNames.Count - 1
                    Dim passQuery As String = "INSERT INTO Passengers (BookingID, FirstName, LastName, SeatNumber, FrequentFlyerProgram) VALUES (@BID, @FName, @LName, @Seat, @Prog)"
                    Using cmdPass As New SqlCommand(passQuery, conn)
                        cmdPass.Parameters.AddWithValue("@BID", newBookingID)

                        Dim names() As String = BookingSession.PassengerNames(i).Trim().Split(" "c)
                        cmdPass.Parameters.AddWithValue("@FName", names(0))
                        cmdPass.Parameters.AddWithValue("@LName", If(names.Length > 1, names(names.Length - 1), ""))

                        ' Give them a seat. If they are an infant without a seat, mark them as LAP
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

        ' --- PREPARE THE FULL TICKET ---
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
            t.Gate = assignedGate ' Uses the real persisted gate instead of a throwaway random one
            t.Seat = assignedSeats(i)
            t.TicketPrice = "RM " & (grandTotal / BookingSession.TotalPassengers).ToString("N2")
            ticketScreen.Tickets.Add(t)
        Next

        Me.Hide()
        ticketScreen.Show()
    End Sub

    ' ========================================================
    ' 2. ONLINE BANKING LOGIC
    ' ========================================================
    Private Sub btnPayOnlineBanking_Click(sender As Object, e As EventArgs) Handles btnPayOnlineBanking.Click
        Dim selectedBank As String = cmbBanks.SelectedItem.ToString()

        ' --- DATABASE SYNC: SAVE MULTIPLE PASSENGERS ---
        Dim pnrCode As String = "PNR" & New Random().Next(1000, 9999).ToString()
        Dim newBookingID As Integer = 0

        Dim grandTotal As Decimal = BookingSession.SelectedPrice
        Dim assignedSeats As New List(Of String)
        Dim assignedGate As String = "" ' Holds the flight's actual gate, read from or written to the DB

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Try
                conn.Open()
                ' 1. Insert into Bookings 
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

                ' 2. Get or assign this flight's Gate (persisted, shared across all passengers/bookings on this flight)
                assignedGate = GetOrAssignGate(conn, BookingSession.SelectedFlightID)

                ' 3. LOOP TO INSERT EVERY PASSENGER
                Dim seatArray() As String = BookingSession.SelectedSeat.Split(","c)

                For i As Integer = 0 To BookingSession.PassengerNames.Count - 1
                    Dim passQuery As String = "INSERT INTO Passengers (BookingID, FirstName, LastName, SeatNumber, FrequentFlyerProgram) VALUES (@BID, @FName, @LName, @Seat, @Prog)"
                    Using cmdPass As New SqlCommand(passQuery, conn)
                        cmdPass.Parameters.AddWithValue("@BID", newBookingID)

                        Dim names() As String = BookingSession.PassengerNames(i).Trim().Split(" "c)
                        cmdPass.Parameters.AddWithValue("@FName", names(0))
                        cmdPass.Parameters.AddWithValue("@LName", If(names.Length > 1, names(names.Length - 1), ""))

                        ' Give them a seat. If they are an infant without a seat, mark them as LAP
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

        ' --- PREPARE THE FULL TICKET ---
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
            t.Gate = assignedGate ' Uses the real persisted gate instead of a throwaway random one
            t.Seat = assignedSeats(i)
            t.TicketPrice = "RM " & (grandTotal / BookingSession.TotalPassengers).ToString("N2")
            ticketScreen.Tickets.Add(t)
        Next

        Me.Hide()
        ticketScreen.Show()
    End Sub

    ' ========================================================
    ' 3. E-WALLET LOGIC & DYNAMIC QR ENGINE
    ' ========================================================
    Private Sub cmbEWalletType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEwalletType.SelectedIndexChanged
        UpdateQRCodeImage()
    End Sub

    Private Sub UpdateQRCodeImage()
        If cmbEwalletType.SelectedItem Is Nothing Then Exit Sub

        Dim selectedWallet As String = cmbEwalletType.SelectedItem.ToString()

        ' Ensure image scales proportionally into borders
        picQRCode.SizeMode = PictureBoxSizeMode.Zoom

        ' NOTE: To activate dynamic image switching, drag your asset files (.png/.jpg) into:
        ' Project Menu -> Properties -> Resources -> Add Resource. Then uncomment the links below:
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
        ' Verify mobile billing identification token exists
        If String.IsNullOrWhiteSpace(txtWalletPhone.Text) Then
            MessageBox.Show("Please type your verified mobile phone number assigned to this digital account.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedWallet As String = cmbEwalletType.SelectedItem.ToString()

        ' --- DATABASE SYNC: SAVE MULTIPLE PASSENGERS ---
        Dim pnrCode As String = "PNR" & New Random().Next(1000, 9999).ToString()
        Dim newBookingID As Integer = 0

        Dim grandTotal As Decimal = BookingSession.SelectedPrice
        Dim assignedSeats As New List(Of String)
        Dim assignedGate As String = "" ' Holds the flight's actual gate, read from or written to the DB

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Try
                conn.Open()
                ' 1. Insert into Bookings 
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

                ' 2. Get or assign this flight's Gate (persisted, shared across all passengers/bookings on this flight)
                assignedGate = GetOrAssignGate(conn, BookingSession.SelectedFlightID)

                ' 3. LOOP TO INSERT EVERY PASSENGER
                Dim seatArray() As String = BookingSession.SelectedSeat.Split(","c)

                For i As Integer = 0 To BookingSession.PassengerNames.Count - 1
                    Dim passQuery As String = "INSERT INTO Passengers (BookingID, FirstName, LastName, SeatNumber, FrequentFlyerProgram) VALUES (@BID, @FName, @LName, @Seat, @Prog)"
                    Using cmdPass As New SqlCommand(passQuery, conn)
                        cmdPass.Parameters.AddWithValue("@BID", newBookingID)

                        Dim names() As String = BookingSession.PassengerNames(i).Trim().Split(" "c)
                        cmdPass.Parameters.AddWithValue("@FName", names(0))
                        cmdPass.Parameters.AddWithValue("@LName", If(names.Length > 1, names(names.Length - 1), ""))

                        ' Give them a seat. If they are an infant without a seat, mark them as LAP
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

        ' --- PREPARE THE FULL TICKET ---
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
            t.Gate = assignedGate ' Uses the real persisted gate instead of a throwaway random one
            t.Seat = assignedSeats(i)
            t.TicketPrice = "RM " & (grandTotal / BookingSession.TotalPassengers).ToString("N2")
            ticketScreen.Tickets.Add(t)
        Next

        Me.Hide()
        ticketScreen.Show()
    End Sub

End Class