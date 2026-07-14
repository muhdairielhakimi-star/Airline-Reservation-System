Imports System.Data.SqlClient

Module DatabaseHelper
    Public strConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30;ConnectRetryCount=3"
    Public CurrentLoggedInUserID As Integer = 0
End Module