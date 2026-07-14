Imports System.Data.SqlClient


Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtEmail.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MsgBox("Please enter both email and password.", MsgBoxStyle.Exclamation, "Missing Info")
            Return
        End If
        Dim query As String = "SELECT UserID, Password FROM Users WHERE Email = @Email"
        Using conn As New SqlConnection(strConn)
            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())

                Try
                    conn.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            reader.Read()

                            Dim dbPassword As String = reader("Password").ToString()

                            If dbPassword = HashPassword(txtPassword.Text.Trim()) Then

                                CurrentLoggedInUserID = Convert.ToInt32(reader("UserID"))
                                MsgBox("Login Successful!", MsgBoxStyle.Information, "Success")

                                Me.Hide()
                                Dim searchForm As New frmPath()
                                searchForm.Show()
                            Else

                                MsgBox("Invalid Email or Password.", MsgBoxStyle.Critical, "Login Failed")
                                txtPassword.Clear()
                                txtPassword.Focus()
                            End If

                        Else

                            MsgBox("This email isn't registered yet. Please sign up.", MsgBoxStyle.Exclamation, "Account Not Found")
                            txtPassword.Clear()
                            txtEmail.Focus()
                        End If
                    End Using

                Catch ex As Exception
                    MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End Using
        End Using
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSIgnUp.Click
        Me.Hide()
        Dim signUpForm As New frmSignUp()
        signUpForm.Show()
    End Sub

End Class