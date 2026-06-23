Imports System.Data.SqlClient

Module DatabaseHelper
    ' This string safely targets the AirlineDB.mdf file inside your project folder
    Public strConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AirlineDB.mdf;Integrated Security=True;Connect Timeout=30;ConnectRetryCount=3"
    ' Global variable to remember who logged in across all forms
    Public CurrentLoggedInUserID As Integer = 0
End Module