Imports System.Data.SqlClient

Module BookingSession
    Public CurrentUserEmail As String
    Public SelectedFlightID As Integer
    Public SelectedFlight As String
    Public SelectedDeparture As String
    Public SelectedDestination As String
    Public SelectedDate As String
    Public SelectedTime As String
    Public SelectedPrice As Decimal
    Public TripType As String
    Public ReturnDate As String
    Public PassengerName As String
    Public FrequentFlyerProgram As String
    Public SelectedSeat As String
    Public TotalPassengers As Integer
    Public AdultCount As Integer
    Public ChildCount As Integer
    Public InfantCount As Integer
    Public CabinClass As String
    Public PassengerNames As New List(Of String)
    Public CurrentPassengerIndex As Integer = 1
End Module
