Imports System.Security.Cryptography
Imports System.Text
Module PasswordHelper
    Public Function HashPassword(plain As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(plain))
            Return Convert.ToBase64String(bytes)
        End Using
    End Function
End Module
