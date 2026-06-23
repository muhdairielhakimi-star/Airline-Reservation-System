Imports System.Data.SqlClient

Public Class frmSignUp

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Strict Validation: Check textboxes AND make sure Dropdowns are actually selected
        If txtEmail.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or txtFirstName.Text.Trim() = "" Or txtDocumentNo.Text.Trim() = "" Then
            MsgBox("Please fill in all text fields (Email, Password, Name, and IC/Passport).", MsgBoxStyle.Exclamation, "Missing Data")
            Return
        End If

        ' SelectedIndex = -1 means they haven't picked anything from the dropdown yet
        If cmbTitle.SelectedIndex = -1 Or cmbGender.SelectedIndex = -1 Or cmbNationality.SelectedIndex = -1 Then
            MsgBox("Please select your Title, Gender, and Nationality from the dropdown lists.", MsgBoxStyle.Exclamation, "Missing Selection")
            Return
        End If

        ' 2. The SQL INSERT Query
        Dim query As String = "INSERT INTO Users (Email, Password, Title, FirstName, LastName, DateOfBirth, Gender, Nationality, DocumentNo, Phone, Role) " &
                              "VALUES (@Email, @Password, @Title, @FirstName, @LastName, @DOB, @Gender, @Nationality, @DocumentNo, @Phone, 'Passenger')"

        ' 3. Connect and Save
        Using conn As New SqlConnection(strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                cmd.Parameters.AddWithValue("@Title", cmbTitle.Text)
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date)
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)

                ' Updated to grab text from the new locked ComboBox
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

        ' 1. Clear all standard textboxes
        txtEmail.Clear()
        txtPassword.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtDocumentNo.Clear()
        txtPhone.Clear()

        ' Reset the Dropdowns (ComboBoxes) to be blank
        cmbTitle.SelectedIndex = -1
        cmbGender.SelectedIndex = -1
        cmbNationality.SelectedIndex = -1

        ' 3. Reset the Calendar to today's date
        dtpDOB.Value = Date.Now

        ' 4. Put the blinking cursor back in the Email box so they can start over
        txtEmail.Focus()
    End Sub
End Class