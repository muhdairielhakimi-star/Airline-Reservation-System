Imports System.Data.SqlClient

Public Class frmSignUp

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtEmail.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or txtFirstName.Text.Trim() = "" Or txtDocumentNo.Text.Trim() = "" Then
            MsgBox("Please fill in all text fields (Email, Password, Name, and IC/Passport).", MsgBoxStyle.Exclamation, "Missing Data")
            Return
        End If

        If cmbTitle.SelectedIndex = -1 Or cmbGender.SelectedIndex = -1 Or cmbNationality.SelectedIndex = -1 Then
            MsgBox("Please select your Title, Gender, and Nationality from the dropdown lists.", MsgBoxStyle.Exclamation, "Missing Selection")
            Return
        End If


        Dim age As Integer = DateTime.Today.Year - dtpDOB.Value.Year
        If dtpDOB.Value.Date > DateTime.Today.AddYears(-age) Then
            age -= 1
        End If

        If age < 18 Then
            MsgBox("You must be at least 18 years old to register an account.", MsgBoxStyle.Exclamation, "Age Restriction")
            Return
        End If

        If dtpDOB.Value.Date > DateTime.Today Then
            MsgBox("Date of birth cannot be in the future.", MsgBoxStyle.Exclamation, "Invalid Date")
            Return
        End If

        Dim query As String = "INSERT INTO Users (Email, Password, Title, FirstName, LastName, DateOfBirth, Gender, Nationality, DocumentNo, Phone, Role) " &
                              "VALUES (@Email, @Password, @Title, @FirstName, @LastName, @DOB, @Gender, @Nationality, @DocumentNo, @Phone, 'Passenger')"


        Using conn As New SqlConnection(strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", HashPassword(txtPassword.Text.Trim()))
                cmd.Parameters.AddWithValue("@Title", cmbTitle.Text)
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date)
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)


                cmd.Parameters.AddWithValue("@Nationality", cmbNationality.Text)

                cmd.Parameters.AddWithValue("@DocumentNo", txtDocumentNo.Text.Trim())
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MsgBox("Account successfully created! You can now log in.", MsgBoxStyle.Information, "Registration Success")

                    Me.Hide()
                    Dim loginForm As New frmLogin()
                    loginForm.Show()

                Catch ex As SqlException
                    If ex.Number = 2627 Then
                        MsgBox("This email is already registered. Please log in instead.", MsgBoxStyle.Exclamation, "Duplicate Email")
                    Else
                        MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
                    End If
                End Try
            End Using
        End Using
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click


        txtEmail.Clear()
        txtPassword.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtDocumentNo.Clear()
        txtPhone.Clear()

        cmbTitle.SelectedIndex = -1
        cmbGender.SelectedIndex = -1
        cmbNationality.SelectedIndex = -1
        dtpDOB.Value = Date.Now


        txtEmail.Focus()
    End Sub


    Private Sub lblSIgnUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSIgnUp.LinkClicked

        Me.Hide()


        Dim loginForm As New frmLogin()
        loginForm.Show()
    End Sub

End Class