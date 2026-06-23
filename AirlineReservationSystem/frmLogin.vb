Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 1. Check if the boxes are empty
        If txtEmail.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MsgBox("Please enter both email and password.", MsgBoxStyle.Exclamation, "Missing Info")
            Return
        End If

        ' 2. NEW SQL QUERY: We only search for the Email this time!
        Dim query As String = "SELECT UserID, Password FROM Users WHERE Email = @Email"

        ' 3. Connect to the database
        Using conn As New SqlConnection(strConn)
            Using cmd As New SqlCommand(query, conn)
                ' We only need to pass the Email to the database
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())

                Try
                    conn.Open()

                    ' We use a DataReader to read the row the database hands back
                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            ' CONDITION 1: THE EMAIL WAS FOUND IN THE DATABASE
                            reader.Read() ' Move to that specific user's row

                            Dim dbPassword As String = reader("Password").ToString()

                            ' Now we check if the password they typed matches the database
                            If dbPassword = txtPassword.Text.Trim() Then
                                ' SUCCESS! Passwords match.
                                CurrentLoggedInUserID = Convert.ToInt32(reader("UserID"))
                                MsgBox("Login Successful!", MsgBoxStyle.Information, "Success")

                                ' Me.Hide()
                                ' Dim searchForm As New frmSearchFlight()
                                ' searchForm.Show()
                            Else
                                ' FAILED: The email is right, but the password is wrong
                                MsgBox("Invalid Email or Password.", MsgBoxStyle.Critical, "Login Failed")
                                txtPassword.Clear()
                                txtPassword.Focus()
                            End If

                        Else
                            ' CONDITION 2: THE EMAIL WAS NOT FOUND AT ALL
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