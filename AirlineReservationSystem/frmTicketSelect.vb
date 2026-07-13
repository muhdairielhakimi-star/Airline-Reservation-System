Imports System.Data.SqlClient

Public Class frmTicketSelect
    Private Structure FlightData
        Dim FlightID As Integer
        Dim Price As Decimal
        Dim DepartureTime As String
        Dim ArrivalTime As String
        Dim FromAirport As String
        Dim ToAirport As String
        Dim AircraftCode As String
        Dim ClassType As String
        Dim DateString As String
    End Structure

    Private Flight1, Flight2, Flight3 As FlightData

    Private Sub frmTicketSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ticket Select"
        Me.BackColor = SystemColors.Control ' REMOVED PURPLE BACKGROUND

        ResetSummaryDisplay()
        LoadFlightsFromDatabase()
    End Sub

    Private Sub LoadFlightsFromDatabase()
        ' Reset all 3 slots to a known "empty" state before querying
        lblFlightRoute1.Text = ""
        lblAircraftCode1.Text = ""
        lblFlightRoute2.Text = "No flight available"
        lblAircraftCode2.Text = ""
        lblFlightRoute3.Text = "No flight available"
        lblAircraftCode3.Text = ""
        btnOption1.Enabled = False
        btnOption2.Enabled = False
        btnOption3.Enabled = False

        Dim query As String = "SELECT TOP 3 * FROM Flights WHERE Origin = @Origin AND Destination = @Destination " &
                  "AND DepartureDate = @Date AND CabinClass = @Class ORDER BY DepartureTime ASC"

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Origin", BookingSession.SelectedDeparture)
                cmd.Parameters.AddWithValue("@Destination", BookingSession.SelectedDestination)
                cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(BookingSession.SelectedDate))
                cmd.Parameters.AddWithValue("@Class", BookingSession.CabinClass)

                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim count As Integer = 1
                        While reader.Read()
                            Dim f As New FlightData()
                            f.FlightID = Convert.ToInt32(reader("FlightID"))

                            Dim baseCost As Decimal = Convert.ToDecimal(reader("BasePrice"))
                            Dim adultTotal As Decimal = baseCost * BookingSession.AdultCount
                            Dim childTotal As Decimal = (baseCost * 0.75D) * BookingSession.ChildCount
                            Dim infantTotal As Decimal = (baseCost * 0.1D) * BookingSession.InfantCount
                            f.Price = adultTotal + childTotal + infantTotal

                            f.AircraftCode = reader("FlightNumber").ToString()
                            f.FromAirport = reader("Origin").ToString()
                            f.ToAirport = reader("Destination").ToString()
                            f.DepartureTime = reader("DepartureTime").ToString()
                            f.ArrivalTime = "TBD"
                            f.ClassType = reader("CabinClass").ToString()
                            f.DateString = Convert.ToDateTime(reader("DepartureDate")).ToShortDateString()

                            If count = 1 Then
                                Flight1 = f
                                lblFlightRoute1.Text = $"{f.FromAirport} ({f.DepartureTime}) ---> {f.ToAirport}"
                                lblAircraftCode1.Text = f.AircraftCode
                                btnOption1.Enabled = True
                            ElseIf count = 2 Then
                                Flight2 = f
                                lblFlightRoute2.Text = $"{f.FromAirport} ({f.DepartureTime}) ---> {f.ToAirport}"
                                lblAircraftCode2.Text = f.AircraftCode
                                btnOption2.Enabled = True
                            ElseIf count = 3 Then
                                Flight3 = f
                                lblFlightRoute3.Text = $"{f.FromAirport} ({f.DepartureTime}) ---> {f.ToAirport}"
                                lblAircraftCode3.Text = f.AircraftCode
                                btnOption3.Enabled = True
                            End If
                            count += 1
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        If Flight1.AircraftCode <> "" Then UpdateRightSummaryPanel(Flight1) : HighlightSelectedCard(1)
    End Sub
    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        If Flight2.AircraftCode <> "" Then UpdateRightSummaryPanel(Flight2) : HighlightSelectedCard(2)
    End Sub
    Private Sub btnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        If Flight3.AircraftCode <> "" Then UpdateRightSummaryPanel(Flight3) : HighlightSelectedCard(3)
    End Sub

    Private Sub ResetSummaryDisplay()
        lblTotalPrice.Text = "RM --"
        lblSummaryTime.Text = "--:--    ----    --:--"
        lblSummaryAirports.Text = "Please select a flight option..."
    End Sub

    Private Sub UpdateRightSummaryPanel(selectedFlight As FlightData)
        lblTotalPrice.Text = $"RM {selectedFlight.Price:N2} ({BookingSession.TotalPassengers} Pax)"
        lblSummaryTime.Text = $"{selectedFlight.DepartureTime}  ---->  {selectedFlight.ArrivalTime}"
        lblSummaryAirports.Text = $"{selectedFlight.FromAirport} to {selectedFlight.ToAirport} ({selectedFlight.AircraftCode})" & vbCrLf &
                                  $"{selectedFlight.DateString} | {selectedFlight.ClassType}"

        BookingSession.SelectedFlightID = selectedFlight.FlightID
        BookingSession.SelectedFlight = selectedFlight.AircraftCode
        BookingSession.SelectedDate = selectedFlight.DateString
        BookingSession.SelectedTime = selectedFlight.DepartureTime
        BookingSession.SelectedPrice = selectedFlight.Price ' Save the flight ticket cost
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblFlightTime3.Click

    End Sub

    Private Sub HighlightSelectedCard(cardNumber As Integer)
        btnOption1.BackColor = Color.White
        btnOption2.BackColor = Color.White
        btnOption3.BackColor = Color.White
        If cardNumber = 1 Then btnOption1.BackColor = Color.AliceBlue
        If cardNumber = 2 Then btnOption2.BackColor = Color.AliceBlue
        If cardNumber = 3 Then btnOption3.BackColor = Color.AliceBlue
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If lblTotalPrice.Text = "RM --" Then
            MessageBox.Show("Please select a flight option before continuing.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Me.Hide()
        Dim passDetails As New PassengerDetails()
        passDetails.Show()
    End Sub
End Class