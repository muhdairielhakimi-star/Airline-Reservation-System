Imports System.Data.SqlClient

Public Class frmPath
    Private adultCount As Integer = 1
    Private childCount As Integer = 0
    Private infantCount As Integer = 0
    Private selectedClass As String = "Economy"

    Private Sub frmPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' BUILD THE DROPDOWN LISTS
        cmbFrom.Items.AddRange(New Object() {"Kuala Lumpur", "Penang", "Johor Bahru", "Singapore", "Jakarta", "Tokyo", "London"})
        cmbTo.Items.AddRange(New Object() {"Kuala Lumpur", "Penang", "Johor Bahru", "Singapore", "Jakarta", "Tokyo", "London"})
        cmbFrom.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTo.DropDownStyle = ComboBoxStyle.DropDownList

        ' STOP TIME TRAVEL
        dateDepart.MinDate = DateTime.Today
        dateReturn.MinDate = DateTime.Today

        ' UPDATE PASSENGER UI
        UpdateUI()

        ' --- NEW CODE: LOAD THE SCHEDULE BOARD! ---
        LoadFlightSchedule()
    End Sub

    ' --- COUNTER LOGIC ---
    Private Sub btnAdultsPlus_Click(sender As Object, e As EventArgs) Handles btnAdultsPlus.Click
        If (adultCount + childCount + infantCount) < 9 Then adultCount += 1 : UpdateUI()
    End Sub
    Private Sub btnAdultsMinus_Click(sender As Object, e As EventArgs) Handles btnAdultsMinus.Click
        If adultCount > 1 Then
            adultCount -= 1
            If infantCount > adultCount Then infantCount = adultCount
            UpdateUI()
        End If
    End Sub
    Private Sub btnChildrenPlus_Click(sender As Object, e As EventArgs) Handles btnChildrenPlus.Click
        If (adultCount + childCount + infantCount) < 9 Then childCount += 1 : UpdateUI()
    End Sub
    Private Sub btnChildrenMinus_Click(sender As Object, e As EventArgs) Handles btnChildrenMinus.Click
        If childCount > 0 Then childCount -= 1 : UpdateUI()
    End Sub
    Private Sub btnInfantsPlus_Click(sender As Object, e As EventArgs) Handles btnInfantsPlus.Click
        If (adultCount + childCount + infantCount) < 9 AndAlso infantCount < adultCount Then infantCount += 1 : UpdateUI()
    End Sub
    Private Sub btnInfantsMinus_Click(sender As Object, e As EventArgs) Handles btnInfantsMinus.Click
        If infantCount > 0 Then infantCount -= 1 : UpdateUI()
    End Sub

    ' --- CABIN CLASS LOGIC ---
    Private Sub btnEconomy_Click(sender As Object, e As EventArgs) Handles btnEconomy.Click
        selectedClass = "Economy"

        ' Set Economy to Blue
        btnEconomy.BackColor = Color.FromArgb(0, 90, 190)
        btnEconomy.ForeColor = Color.White

        ' Reset Business and First Class to White
        btnBusiness.BackColor = Color.White
        btnBusiness.ForeColor = Color.Black
        btnFirstClass.BackColor = Color.White
        btnFirstClass.ForeColor = Color.Black
    End Sub

    Private Sub btnBusiness_Click(sender As Object, e As EventArgs) Handles btnBusiness.Click
        selectedClass = "Business"

        ' Set Business to Blue
        btnBusiness.BackColor = Color.FromArgb(0, 90, 190)
        btnBusiness.ForeColor = Color.White

        ' Reset Economy and First Class to White
        btnEconomy.BackColor = Color.White
        btnEconomy.ForeColor = Color.Black
        btnFirstClass.BackColor = Color.White
        btnFirstClass.ForeColor = Color.Black
    End Sub

    Private Sub btnFirstClass_Click(sender As Object, e As EventArgs) Handles btnFirstClass.Click
        selectedClass = "First Class"

        ' Set First Class to Blue
        btnFirstClass.BackColor = Color.FromArgb(0, 90, 190)
        btnFirstClass.ForeColor = Color.White

        ' Reset Economy and Business to White
        btnEconomy.BackColor = Color.White
        btnEconomy.ForeColor = Color.Black
        btnBusiness.BackColor = Color.White
        btnBusiness.ForeColor = Color.Black
    End Sub

    ' --- SWAP BUTTON LOGIC ---
    Private Sub btnWay_Click(sender As Object, e As EventArgs) Handles btnWay.Click
        ' Swap the dropdown selections instantly
        Dim tempIndex As Integer = cmbFrom.SelectedIndex
        cmbFrom.SelectedIndex = cmbTo.SelectedIndex
        cmbTo.SelectedIndex = tempIndex
    End Sub

    ' --- UI REFRESHER ---
    Private Sub UpdateUI()
        lblAdultsCount.Text = adultCount.ToString()
        lblChildrenCount.Text = childCount.ToString()
        lblInfantsCount.Text = infantCount.ToString()
    End Sub
    ' ==========================================
    ' SMART DATABASE SEARCH LOGIC
    ' ==========================================
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If cmbFrom.SelectedIndex = -1 OrElse cmbTo.SelectedIndex = -1 Then
            MessageBox.Show("Please select both Departure and Destination cities from the dropdown lists.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cmbFrom.SelectedItem.ToString() = cmbTo.SelectedItem.ToString() Then
            MessageBox.Show("Departure and Destination cannot be the same city!", "Invalid Route", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' --- SMART ROUND-TRIP LOGIC ---
        If dateReturn.Value.Date > dateDepart.Value.Date Then
            BookingSession.TripType = "Round-Trip"
            BookingSession.ReturnDate = dateReturn.Value.ToShortDateString()
        Else
            BookingSession.TripType = "One-Way"
            BookingSession.ReturnDate = ""
        End If

        ' 1. Check if flight exists FIRST
        Dim flightExists As Integer = 0
        Dim query As String = "SELECT COUNT(*) FROM Flights WHERE Origin = @Origin AND Destination = @Destination AND DepartureDate = @Date AND CabinClass = @Class"

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Origin", cmbFrom.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Destination", cmbTo.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Date", dateDepart.Value.Date)
                cmd.Parameters.AddWithValue("@Class", selectedClass)

                Try
                    conn.Open()
                    flightExists = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message)
                    Exit Sub
                End Try
            End Using
        End Using

        If flightExists = 0 Then
            MessageBox.Show($"No {selectedClass} flights found from {cmbFrom.SelectedItem.ToString()} to {cmbTo.SelectedItem.ToString()} on {dateDepart.Value.ToShortDateString()}. Please try another date or route.", "No Flights Available", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Save data and proceed
        BookingSession.SelectedDeparture = cmbFrom.SelectedItem.ToString()
        BookingSession.SelectedDestination = cmbTo.SelectedItem.ToString()
        BookingSession.SelectedDate = dateDepart.Value.ToShortDateString()
        BookingSession.AdultCount = adultCount
        BookingSession.ChildCount = childCount
        BookingSession.InfantCount = infantCount
        BookingSession.TotalPassengers = adultCount + childCount + infantCount
        BookingSession.CabinClass = selectedClass
        BookingSession.PassengerNames.Clear()
        BookingSession.CurrentPassengerIndex = 1

        Me.Hide()
        Dim ticketSelectForm As New frmTicketSelect()
        ticketSelectForm.Show()
    End Sub

    Private Sub LoadFlightSchedule()
        ' This query grabs all future flights and sorts them by date
        Dim query As String = "SELECT FlightNumber AS [Flight], Origin, Destination, DepartureDate AS [Date], DepartureTime AS [Time], CabinClass AS [Class], BasePrice AS [Price] FROM Flights WHERE DepartureDate >= @Today ORDER BY DepartureDate ASC"

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Today", DateTime.Today)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                Try
                    ' Fill the data table and bind it to your visual grid
                    da.Fill(dt)
                    dgvSchedule.DataSource = dt

                    ' Make the grid look clean and professional
                    dgvSchedule.ReadOnly = True
                    dgvSchedule.AllowUserToAddRows = False
                    dgvSchedule.RowHeadersVisible = False
                    dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect

                Catch ex As Exception
                    MessageBox.Show("Error loading flight schedule: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        Dim profileForm As New Profile()
        profileForm.Show()
    End Sub
End Class