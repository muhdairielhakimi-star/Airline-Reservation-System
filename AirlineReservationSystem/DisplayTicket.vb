Public Class frmDisplayTicket

    Public Structure TicketData
        Dim Departure As String
        Dim Destination As String
        Dim PassengerName As String
        Dim ProgramName As String
        Dim FlightDate As String
        Dim FlightTime As String
        Dim FlightName As String
        Dim Gate As String
        Dim Seat As String
        Dim TicketPrice As String
    End Structure

    Public Tickets As New List(Of TicketData)
    Private currentIndex As Integer = 0

    Private Sub frmTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentIndex = 0
        RenderCurrentTicket()
    End Sub

    Private Sub RenderCurrentTicket()
        If Tickets.Count = 0 Then Exit Sub

        Dim t As TicketData = Tickets(currentIndex)
        lblFrom.Text = t.Departure
        lblTo.Text = t.Destination
        lblName.Text = t.PassengerName
        lblProgram.Text = t.ProgramName
        lblDate.Text = t.FlightDate
        lblTime.Text = t.FlightTime
        lblFlight.Text = t.FlightName
        lblGate.Text = t.Gate
        lblSeat.Text = t.Seat
        lblPrice.Text = t.TicketPrice

        Me.Text = $"Ticket {currentIndex + 1} of {Tickets.Count}"
        btnNext.Text = $"Ticket {currentIndex + 1} of {Tickets.Count}"

        btnPrev.Enabled = (currentIndex > 0)
        btnNext.Enabled = (currentIndex < Tickets.Count - 1)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < Tickets.Count - 1 Then
            currentIndex += 1
            RenderCurrentTicket()
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            RenderCurrentTicket()
        End If
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim pathForm As New frmPath()
        pathForm.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

    End Sub
End Class