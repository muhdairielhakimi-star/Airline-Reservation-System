Imports System.Data.SqlClient

Public Class selectSeat
    Private Structure SeatData
        Dim SeatNumber As String
        Dim CabinClass As String
        Dim IsBooked As Boolean
    End Structure

    Private seatArray(59) As SeatData
    Private selectedButtons As New List(Of Button)
    Private seatSelectionFeeTotal As Decimal = 0

    Private seatPriceMap As New Dictionary(Of String, Decimal) From {
    {"First Class", 150.0},
    {"Business", 80.0},
    {"Economy", 40.0}
}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = SystemColors.Control
        cmbCabinClass.Items.Clear()
        cmbCabinClass.Items.Add("LOCKED TO: " & BookingSession.CabinClass & " CLASS")
        cmbCabinClass.SelectedIndex = 0
        cmbCabinClass.Enabled = False

        lblPriceTotal.Text = "Seat Add-on Fee: RM 0.00"

        SetupSeatsAndCheckDatabase()

        Dim availableCount As Integer = 0
        For Each seat As SeatData In seatArray
            If seat.CabinClass = BookingSession.CabinClass AndAlso Not seat.IsBooked Then
                availableCount += 1
            End If
        Next

        Dim seatsNeeded As Integer = BookingSession.AdultCount + BookingSession.ChildCount

        If availableCount < seatsNeeded Then
            MessageBox.Show(
            $"Sorry, this flight only has {availableCount} available seat(s) left in {BookingSession.CabinClass}, " &
            $"but your booking needs {seatsNeeded}. Please go back and choose a different flight.",
            "Not Enough Seats Available", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Hide()
            Dim ticketSelectForm As New frmTicketSelect()
            ticketSelectForm.Show()
            Exit Sub
        End If

        RenderEntirePlaneGrid()
    End Sub

    Private Sub SetupSeatsAndCheckDatabase()
        Dim index As Integer = 0

        For r As Integer = 0 To 9
            For c As Integer = 0 To 5
                Dim seatNo As String = (r + 1).ToString() & Chr(65 + c)
                seatArray(index).SeatNumber = seatNo
                seatArray(index).IsBooked = False

                If r < 2 Then
                    seatArray(index).CabinClass = "First Class"
                ElseIf r < 5 Then
                    seatArray(index).CabinClass = "Business"
                Else
                    seatArray(index).CabinClass = "Economy"
                End If
                index += 1
            Next
        Next

        Dim query As String = "SELECT p.SeatNumber FROM Passengers p INNER JOIN Bookings b ON p.BookingID = b.BookingID WHERE b.FlightID = @FlightID"
        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FlightID", BookingSession.SelectedFlightID)
                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim dbSeat As String = reader("SeatNumber").ToString()
                            For i As Integer = 0 To seatArray.Length - 1
                                If seatArray(i).SeatNumber = dbSeat Then
                                    seatArray(i).IsBooked = True
                                    Exit For
                                End If
                            Next
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading occupied seats: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub RenderEntirePlaneGrid()
        TableLayoutPanel1.Controls.Clear()
        TableLayoutPanel2.Controls.Clear()

        Dim rows As Integer = 10
        Dim colsPerPanel As Integer = 3

        For r As Integer = 0 To rows - 1
            For c As Integer = 0 To colsPerPanel - 1
                Dim targetSeatName As String = (r + 1).ToString() & Chr(65 + c)
                TableLayoutPanel1.Controls.Add(BuildSeatButton(FindSeatInArray(targetSeatName)), c, r)
            Next
            For c As Integer = 0 To colsPerPanel - 1
                Dim targetSeatName As String = (r + 1).ToString() & Chr(68 + c)
                TableLayoutPanel2.Controls.Add(BuildSeatButton(FindSeatInArray(targetSeatName)), c, r)
            Next
        Next
    End Sub

    Private Function BuildSeatButton(seat As SeatData) As Button
        Dim btnSeat As New Button()
        btnSeat.Dock = DockStyle.Fill
        btnSeat.Text = seat.SeatNumber
        btnSeat.FlatStyle = FlatStyle.Flat
        btnSeat.FlatAppearance.BorderSize = 1
        btnSeat.Tag = seat

        If seat.IsBooked Then
            btnSeat.BackColor = Color.DarkGray
            btnSeat.ForeColor = Color.White
            btnSeat.Enabled = False
        ElseIf seat.CabinClass <> BookingSession.CabinClass Then
            btnSeat.BackColor = Color.WhiteSmoke
            btnSeat.ForeColor = Color.Silver
            btnSeat.Enabled = False
        Else
            btnSeat.BackColor = Color.White
            AddHandler btnSeat.Click, AddressOf Seat_Click
        End If
        Return btnSeat
    End Function

    Private Sub Seat_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim seat As SeatData = CType(btn.Tag, SeatData)


        If seat.CabinClass <> BookingSession.CabinClass Then
            MessageBox.Show($"You paid for a {BookingSession.CabinClass} ticket! You cannot select a seat in the {seat.CabinClass} section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim maxSeatsAllowed As Integer = BookingSession.AdultCount + BookingSession.ChildCount
        If selectedButtons.Count >= maxSeatsAllowed AndAlso btn.BackColor = Color.White Then
            MessageBox.Show($"You only have {maxSeatsAllowed} seat-requiring passengers on this booking. You cannot select extra seats.", "Seat Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim standardCost As Decimal = seatPriceMap(seat.CabinClass)

        If btn.BackColor = Color.White Then
            btn.BackColor = Color.Lime
            selectedButtons.Add(btn)
            seatSelectionFeeTotal += standardCost
        ElseIf btn.BackColor = Color.Lime Then
            btn.BackColor = Color.White
            selectedButtons.Remove(btn)
            seatSelectionFeeTotal -= standardCost
        End If

        lblPriceTotal.Text = "Seat Add-on Fee: RM " & seatSelectionFeeTotal.ToString("N2")
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim maxSeatsAllowed As Integer = BookingSession.AdultCount + BookingSession.ChildCount
        If selectedButtons.Count < maxSeatsAllowed Then
            MessageBox.Show($"Please select {maxSeatsAllowed} seats before continuing.", "Missing Seats", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim allSeats As String = ""
        For Each btn As Button In selectedButtons
            allSeats &= btn.Text & ", "
        Next
        BookingSession.SelectedSeat = allSeats.TrimEnd(", ".ToCharArray())


        BookingSession.SelectedPrice += seatSelectionFeeTotal

        Me.Hide()
        Dim payForm As New payment()
        payForm.Show()
    End Sub

    Private Function FindSeatInArray(seatNo As String) As SeatData
        For Each seat As SeatData In seatArray
            If seat.SeatNumber = seatNo Then Return seat
        Next
        Return New SeatData()
    End Function

    Private Sub Label9_Paint(sender As Object, e As PaintEventArgs) Handles Label9.Paint
        Dim g As Graphics = e.Graphics
        Dim displayText As String = "First Class"

        g.TranslateTransform(Label9.Width / 2, Label9.Height / 2)
        g.RotateTransform(-90)

        Dim textSize As SizeF = g.MeasureString(displayText, Label9.Font)
        g.DrawString(displayText, Label9.Font, Brushes.Black,
                 -textSize.Width / 2, -textSize.Height / 2)

        g.ResetTransform()
    End Sub

    Private Sub Label10_Paint(sender As Object, e As PaintEventArgs) Handles Label10.Paint
        Dim g As Graphics = e.Graphics
        Dim displayText As String = "Business"

        g.TranslateTransform(Label10.Width / 2, Label10.Height / 2)
        g.RotateTransform(-90)

        Dim textSize As SizeF = g.MeasureString(displayText, Label10.Font)
        g.DrawString(displayText, Label10.Font, Brushes.Black,
                 -textSize.Width / 2, -textSize.Height / 2)

        g.ResetTransform()
    End Sub

    Private Sub Label11_Paint(sender As Object, e As PaintEventArgs) Handles Label11.Paint
        Dim g As Graphics = e.Graphics
        Dim displayText As String = "Economy"

        g.TranslateTransform(Label11.Width / 2, Label11.Height / 2)
        g.RotateTransform(-90)

        Dim textSize As SizeF = g.MeasureString(displayText, Label11.Font)
        g.DrawString(displayText, Label11.Font, Brushes.Black,
                 -textSize.Width / 2, -textSize.Height / 2)

        g.ResetTransform()
    End Sub


End Class