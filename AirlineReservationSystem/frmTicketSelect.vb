Public Class frmTicketSelect

    ' Structure to hold custom data for each flight choice cleanly
    Private Structure FlightData
        Dim Price As Decimal
        Dim DepartureTime As String
        Dim ArrivalTime As String
        Dim FromAirport As String
        Dim ToAirport As String
        Dim AircraftCode As String
        Dim ClassType As String
        Dim DateString As String
    End Structure

    ' Class-level storage variables for our 3 unique options
    Private Flight1 As FlightData
    Private Flight2 As FlightData
    Private Flight3 As FlightData

    Private Sub frmTicketSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Set up overall form aesthetics
        Me.Text = "Ticket Select"
        Me.BackColor = Color.FromArgb(40, 20, 80) ' Deep purple frame layout

        ' 2. Configure UNIQUE data for each separate flight departure
        ' Option 1: Early Morning Flight to Singapore
        Flight1.Price = 450D
        Flight1.DepartureTime = "06:30"
        Flight1.ArrivalTime = "07:20"
        Flight1.FromAirport = "KUL"
        Flight1.ToAirport = "SIN"
        Flight1.AircraftCode = "MH710"
        Flight1.ClassType = "Economy Flexi"
        Flight1.DateString = "Thu, 21 May 2026"

        ' Option 2: Afternoon Flight to Jakarta
        Flight2.Price = 680D
        Flight2.DepartureTime = "13:15"
        Flight2.ArrivalTime = "14:25"
        Flight2.FromAirport = "KUL"
        Flight2.ToAirport = "CGK"
        Flight2.AircraftCode = "MH721"
        Flight2.ClassType = "Economy Promo"
        Flight2.DateString = "Thu, 21 May 2026"

        ' Option 3: Night Flight to Tokyo
        Flight3.Price = 2850D
        Flight3.DepartureTime = "22:50"
        Flight3.ArrivalTime = "07:05"
        Flight3.FromAirport = "KUL"
        Flight3.ToAirport = "HND"
        Flight3.AircraftCode = "MH884"
        Flight3.ClassType = "Business Standard"
        Flight3.DateString = "Fri, 22 May 2026"

        ' 3. Dynamically populate the descriptive left-side UI labels
        ' Option 1 Card (Top)
        lblFlightRoute1.Text = $"{Flight1.FromAirport} ({Flight1.DepartureTime})  --->  {Flight1.ToAirport} ({Flight1.ArrivalTime})"
        lblAircraftCode1.Text = Flight1.AircraftCode

        ' Option 2 Card (Middle)
        lblFlightRoute2.Text = $"{Flight2.FromAirport} ({Flight2.DepartureTime})  --->  {Flight2.ToAirport} ({Flight2.ArrivalTime})"
        lblAircraftCode2.Text = Flight2.AircraftCode

        ' Option 3 Card (Bottom)
        lblFlightRoute3.Text = $"{Flight3.FromAirport} ({Flight3.DepartureTime})  --->  {Flight3.ToAirport} ({Flight3.ArrivalTime})"
        lblAircraftCode3.Text = Flight3.AircraftCode

        ' 4. Initialize the Right Summary Display as empty at startup
        ResetSummaryDisplay()
    End Sub

    ' ==========================================================
    ' BUTTON CLICK LOGIC (Maps your specific 'Select' buttons)
    ' ==========================================================

    Private Sub btnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        UpdateRightSummaryPanel(Flight1)
        HighlightSelectedCard(1)
    End Sub

    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        UpdateRightSummaryPanel(Flight2)
        HighlightSelectedCard(2)
    End Sub

    Private Sub btnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        UpdateRightSummaryPanel(Flight3)
        HighlightSelectedCard(3)
    End Sub

    ' ==========================================================
    ' UI SUB-ROUTINES & CONTROLLERS
    ' ==========================================================

    ''' <summary>
    ''' Resets the summary panel labels back to their empty default states
    ''' </summary>
    Private Sub ResetSummaryDisplay()
        lblTotalPrice.Text = "RM --"
        lblSummaryTime.Text = "--:--   ----   --:--"
        lblSummaryAirports.Text = "Please select a flight option..."
    End Sub

    ''' <summary>
    ''' Populates the right-hand container elements with the active selection data
    ''' </summary>
    Private Sub UpdateRightSummaryPanel(selectedFlight As FlightData)
        lblTotalPrice.Text = $"RM {selectedFlight.Price:N0}"
        lblSummaryTime.Text = $"{selectedFlight.DepartureTime}  ---->  {selectedFlight.ArrivalTime}"
        lblSummaryAirports.Text = $"{selectedFlight.FromAirport} to {selectedFlight.ToAirport} ({selectedFlight.AircraftCode})" & vbCrLf &
                                  $"{selectedFlight.DateString} | {selectedFlight.ClassType}"
    End Sub

    ''' <summary>
    ''' Cycles button backgrounds to provide selection feedback
    ''' </summary>
    Private Sub HighlightSelectedCard(cardNumber As Integer)
        btnOption1.BackColor = Color.White
        btnOption2.BackColor = Color.White
        btnOption3.BackColor = Color.White

        If cardNumber = 1 Then
            btnOption1.BackColor = Color.AliceBlue
        ElseIf cardNumber = 2 Then
            btnOption2.BackColor = Color.AliceBlue
        ElseIf cardNumber = 3 Then
            btnOption3.BackColor = Color.AliceBlue
        End If
    End Sub

End Class