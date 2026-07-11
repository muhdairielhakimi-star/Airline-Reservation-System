Public Class frmTicket

    ' Declarations
    Public Departure As String
    Public Destination As String
    Public PassengerName As String
    Public ProgramName As String
    Public FlightDate As String
    Public FlightTime As String
    Public FlightName As String
    Public Gate As String
    Public Seat As String
    Public TicketPrice As String

    Private Sub frmTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblFrom.Text = Departure
        lblTo.Text = Destination
        lblName.Text = PassengerName
        lblProgram.Text = ProgramName
        lblDate.Text = FlightDate
        lblTime.Text = FlightTime
        lblFlight.Text = FlightName
        lblGate.Text = Gate
        lblSeat.Text = Seat
        lblPrice.Text = TicketPrice

    End Sub

End Class