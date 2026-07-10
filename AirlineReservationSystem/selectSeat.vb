Public Class selectSeat

    ' Structure to hold seat properties in our array
    Private Structure SeatData
        Dim SeatNumber As String
        Dim CabinClass As String
        Dim IsBooked As Boolean
    End Structure

    ' The Master Array holding all 60 plane seats
    Private seatArray(59) As SeatData

    ' Global tracking variables for selection
    Private selectedButtons As New List(Of Button)
    Private totalPrice As Decimal = 0

    ' Pricing Dictionary mapping category to price
    Private seatPriceMap As New Dictionary(Of String, Decimal) From {
        {"First", 150.0},
        {"Business", 80.0},
        {"Economy", 40.0}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Set up your dropdown selection items
        cmbCabinClass.Items.Add("First Class ($150)")
        cmbCabinClass.Items.Add("Business Class ($80)")
        cmbCabinClass.Items.Add("Economy Class ($40)")

        lblPriceTotal.Text = "Seat Price Total: $0.00"

        ' 2. Initialize our hardcoded layout data into the array
        SetupHardcodedSeats()

        ' 3. Render the full plane layout immediately so it's always showing
        RenderEntirePlaneGrid()
    End Sub

    ''' <summary>
    ''' Hardcodes all 60 seats with their specific categories and initial booking status
    ''' </summary>
    Private Sub SetupHardcodedSeats()
        Dim index As Integer = 0

        For r As Integer = 0 To 9 ' 10 Rows (0 to 9)
            For c As Integer = 0 To 5 ' 6 Columns (A to F)
                Dim letter As String = Chr(65 + c) ' Converts 0->A, 1->B, etc.
                Dim seatNo As String = (r + 1).ToString() & letter

                seatArray(index).SeatNumber = seatNo

                ' Hardcoding categories by rows
                If r < 2 Then
                    seatArray(index).CabinClass = "First"   ' Rows 1-2
                ElseIf r < 5 Then
                    seatArray(index).CabinClass = "Business" ' Rows 3-5
                Else
                    seatArray(index).CabinClass = "Economy"  ' Rows 6-10
                End If

                ' Hardcoding some random pre-booked seats to show the grey color working
                If seatNo = "1A" Or seatNo = "4C" Or seatNo = "8E" Then
                    seatArray(index).IsBooked = True
                Else
                    seatArray(index).IsBooked = False
                End If

                index += 1
            Next
        Next
    End Sub

    ''' <summary>
    ''' Draws the complete plane structure inside TableLayoutPanel1 and TableLayoutPanel2
    ''' </summary>
    Private Sub RenderEntirePlaneGrid()
        TableLayoutPanel1.Controls.Clear()
        TableLayoutPanel2.Controls.Clear()

        Dim rows As Integer = 10
        Dim colsPerPanel As Integer = 3

        For r As Integer = 0 To rows - 1

            ' --- LEFT SEATING BLOCK (Columns A, B, C) ---
            For c As Integer = 0 To colsPerPanel - 1
                Dim seatLetter As String = Chr(65 + c)
                Dim targetSeatName As String = (r + 1).ToString() & seatLetter

                Dim seatObj As SeatData = FindSeatInArray(targetSeatName)
                Dim btn As Button = BuildSeatButton(seatObj)
                TableLayoutPanel1.Controls.Add(btn, c, r)
            Next

            ' --- RIGHT SEATING BLOCK (Columns D, E, F) ---
            For c As Integer = 0 To colsPerPanel - 1
                Dim seatLetter As String = Chr(68 + c)
                Dim targetSeatName As String = (r + 1).ToString() & seatLetter

                Dim seatObj As SeatData = FindSeatInArray(targetSeatName)
                Dim btn As Button = BuildSeatButton(seatObj)
                TableLayoutPanel2.Controls.Add(btn, c, r)
            Next
        Next
    End Sub

    Private Function BuildSeatButton(seat As SeatData) As Button
        Dim btnSeat As New Button()
        btnSeat.Dock = DockStyle.Fill
        btnSeat.Text = seat.SeatNumber
        btnSeat.FlatStyle = FlatStyle.Flat
        btnSeat.FlatAppearance.BorderSize = 1
        btnSeat.Tag = seat ' Attaches our structural data right to the button control

        ' If it's pre-booked, turn it grey immediately
        If seat.IsBooked Then
            btnSeat.BackColor = Color.DarkGray
            btnSeat.Enabled = False
        Else
            btnSeat.BackColor = Color.White
            AddHandler btnSeat.Click, AddressOf Seat_Click
        End If

        Return btnSeat
    End Function

    ''' <summary>
    ''' Handles clicking a seat. Validates if it matches the chosen dropdown cabin class.
    ''' </summary>
    Private Sub Seat_Click(sender As Object, e As EventArgs)
        ' Check if a class has been selected first
        If cmbCabinClass.SelectedIndex = -1 Then
            MessageBox.Show("Please select your desired Cabin Class first!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim btn As Button = CType(sender, Button)
        Dim seat As SeatData = CType(btn.Tag, SeatData)

        ' Translate dropdown text into standard keys ("First", "Business", "Economy")
        Dim currentSelectedClass As String = ""
        If cmbCabinClass.SelectedItem.ToString().Contains("First Class") Then currentSelectedClass = "First"
        If cmbCabinClass.SelectedItem.ToString().Contains("Business Class") Then currentSelectedClass = "Business"
        If cmbCabinClass.SelectedItem.ToString().Contains("Economy Class") Then currentSelectedClass = "Economy"

        ' Mismatch validation rule
        If seat.CabinClass <> currentSelectedClass Then
            MessageBox.Show($"This seat is a {seat.CabinClass} Class seat. Please select a seat inside the {currentSelectedClass} section.", "Class Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim standardCost As Decimal = seatPriceMap(seat.CabinClass)

        ' Toggle selection color (White <--> Lime Green)
        If btn.BackColor = Color.White Then
            btn.BackColor = Color.Lime
            selectedButtons.Add(btn)
            totalPrice += standardCost
        ElseIf btn.BackColor = Color.Lime Then
            btn.BackColor = Color.White
            selectedButtons.Remove(btn)
            totalPrice -= standardCost
        End If

        lblPriceTotal.Text = "Seat Price Total: $" & totalPrice.ToString("N2")
    End Sub

    ''' <summary>
    ''' Fires when the Continue button is hit. Turns green selections to Grey permanently.
    ''' </summary>
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If selectedButtons.Count = 0 Then
            MessageBox.Show("Please select at least one seat before continuing.", "No Seats Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Loop through current selections and lock them to Grey (Not Available)
        For Each btn As Button In selectedButtons
            btn.BackColor = Color.DarkGray
            btn.Enabled = False

            ' Update the local array status so it remembers the state change
            For i As Integer = 0 To seatArray.Length - 1
                If seatArray(i).SeatNumber = btn.Text Then
                    seatArray(i).IsBooked = True
                    Exit For
                End If
            Next
        Next

        MessageBox.Show($"Seats confirmed! Total Charge: ${totalPrice.ToString("N2")}", "Booking Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Reset selection counters for the next customer purchase simulation
        selectedButtons.Clear()
        totalPrice = 0
        lblPriceTotal.Text = "Seat Price Total: $0.00"
    End Sub

    ' Helper to query our structural array items by seat identification names
    Private Function FindSeatInArray(seatNo As String) As SeatData
        For Each seat As SeatData In seatArray
            If seat.SeatNumber = seatNo Then Return seat
        Next
        Return New SeatData()
    End Function
End Class