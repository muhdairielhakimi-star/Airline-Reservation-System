Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Profile

    Private Function VerifyCurrentPassword() As Boolean
        Dim popup As New frmEditField()
        popup.Prompt = "Enter your current password to continue:"
        popup.IsPasswordField = True

        If popup.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        Dim enteredPassword As String = popup.ResultValue
        Dim enteredHash As String = HashPassword(enteredPassword)

        Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Password = @Password"
        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                cmd.Parameters.AddWithValue("@Password", enteredHash)
                Try
                    conn.Open()
                    Dim matchCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If matchCount = 0 Then
                        MessageBox.Show("Incorrect password. Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                    Return True
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserProfile()
        UpdateViewTicketButtonState()
        UpdateCancelTicketButtonState()
    End Sub

    Private Sub LoadUserProfile()
        Dim query As String = "SELECT Email, Title, FirstName, LastName, DateOfBirth, Gender, Nationality, DocumentNo, Phone " &
                               "FROM Users WHERE UserID = @UserID"

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lblEmail.Text = reader("Email").ToString()
                            lblPassword.Text = "••••••••"
                            lblFirstName.Text = reader("FirstName").ToString()
                            lblLastName.Text = reader("LastName").ToString()
                            lblDateOfBirth.Text = Convert.ToDateTime(reader("DateOfBirth")).ToShortDateString()
                            lblPhone.Text = reader("Phone").ToString()
                            lblIC.Text = reader("DocumentNo").ToString()
                            lblGender.Text = reader("Gender").ToString()
                            lblNationality.Text = reader("Nationality").ToString()
                            lblTitle.Text = reader("Title").ToString()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading profile: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub


    Private Sub btnChangeEmail_Click(sender As Object, e As EventArgs) Handles btnChangeEmail.Click

        If Not VerifyCurrentPassword() Then Exit Sub

        Dim popup As New frmEditField()
        popup.Prompt = "Enter new email:"
        popup.IsPasswordField = False

        If popup.ShowDialog() = DialogResult.OK Then
            Dim newEmail As String = popup.ResultValue

            Dim query As String = "UPDATE Users SET Email = @Email WHERE UserID = @UserID"
            Using conn As New SqlConnection(DatabaseHelper.strConn)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Email", newEmail)
                    cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        lblEmail.Text = newEmail
                        MessageBox.Show("Email updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As SqlException
                        If ex.Number = 2627 Then
                            MessageBox.Show("This email is already registered to another account.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click

        If Not VerifyCurrentPassword() Then Exit Sub

        Dim popup As New frmEditField()
        popup.Prompt = "Enter new password:"
        popup.IsPasswordField = True

        If popup.ShowDialog() = DialogResult.OK Then
            Dim newPasswordHash As String = HashPassword(popup.ResultValue)

            Dim query As String = "UPDATE Users SET Password = @Password WHERE UserID = @UserID"
            Using conn As New SqlConnection(DatabaseHelper.strConn)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Password", newPasswordHash)
                    cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub


    Private Sub btnChangePhone_Click(sender As Object, e As EventArgs) Handles btnChangePhone.Click

        If Not VerifyCurrentPassword() Then Exit Sub

        Dim popup As New frmEditField()
        popup.Prompt = "Enter new phone number:"
        popup.IsPasswordField = False

        If popup.ShowDialog() = DialogResult.OK Then
            Dim newPhone As String = popup.ResultValue

            Dim query As String = "UPDATE Users SET Phone = @Phone WHERE UserID = @UserID"
            Using conn As New SqlConnection(DatabaseHelper.strConn)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Phone", newPhone)
                    cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        lblPhone.Text = newPhone
                        MessageBox.Show("Phone number updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub btnViewTicket_Click(sender As Object, e As EventArgs) Handles btnViewTicket.Click
        Dim tickets As New List(Of frmDisplayTicket.TicketData)

        Dim query As String = "
            SELECT p.FirstName, p.LastName, p.FrequentFlyerProgram, p.SeatNumber,
                   f.Origin, f.Destination, f.DepartureDate, f.DepartureTime, f.FlightNumber, f.Gate,
                   b.TotalPrice
            FROM Passengers p
            INNER JOIN Bookings b ON p.BookingID = b.BookingID
            INNER JOIN Flights f ON b.FlightID = f.FlightID
            WHERE b.UserID = @UserID
            ORDER BY f.DepartureDate ASC, p.PassengerID ASC"

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim t As New frmDisplayTicket.TicketData
                            t.Departure = reader("Origin").ToString()
                            t.Destination = reader("Destination").ToString()
                            t.PassengerName = reader("FirstName").ToString() & " " & reader("LastName").ToString()
                            t.ProgramName = If(reader.IsDBNull(reader.GetOrdinal("FrequentFlyerProgram")), "N/A", reader("FrequentFlyerProgram").ToString())
                            t.FlightDate = Convert.ToDateTime(reader("DepartureDate")).ToShortDateString()
                            t.FlightTime = DateTime.Today.Add(CType(reader("DepartureTime"), TimeSpan)).ToShortTimeString() ' FIXED: TIME columns read back as TimeSpan, not DateTime — Convert.ToDateTime crashed on this
                            t.FlightName = reader("FlightNumber").ToString()
                            t.Gate = If(reader.IsDBNull(reader.GetOrdinal("Gate")), "TBA", reader("Gate").ToString())
                            t.Seat = If(reader.IsDBNull(reader.GetOrdinal("SeatNumber")), "Not Assigned", reader("SeatNumber").ToString())
                            t.TicketPrice = Convert.ToDecimal(reader("TotalPrice")).ToString("C")
                            tickets.Add(t)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading tickets: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End Using
        End Using

        Me.Hide()
        Dim ticketForm As New frmDisplayTicket()
        ticketForm.Tickets = tickets
        ticketForm.Show()
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        Dim bookingCount As Integer = 0
        Dim checkQuery As String = "SELECT COUNT(*) FROM Bookings WHERE UserID = @UserID"

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(checkQuery, conn)
                cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                Try
                    conn.Open()
                    bookingCount = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End Using
        End Using

        If bookingCount > 0 Then
            MessageBox.Show($"You have {bookingCount} active booking(s). Please cancel all your bookings before deleting your account.",
                             "Cannot Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to permanently delete your account? This cannot be undone.",
            "Confirm Account Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirm <> DialogResult.Yes Then Exit Sub

        Dim deleteQuery As String = "DELETE FROM Users WHERE UserID = @UserID"
        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(deleteQuery, conn)
                cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End Using
        End Using

        MessageBox.Show("Your account has been deleted.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DatabaseHelper.CurrentLoggedInUserID = 0
        Me.Hide()
        Dim loginForm As New frmLogin()
        loginForm.Show()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        DatabaseHelper.CurrentLoggedInUserID = 0
        Me.Hide()
        Dim loginForm As New frmLogin()
        loginForm.Show()
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim pathForm As New frmPath()
        pathForm.Show()
    End Sub


    Private Sub btnCancelTicket_Click(sender As Object, e As EventArgs) Handles btnCancelTicket.Click
        Dim bookingCount As Integer = 0
        Dim checkQuery As String = "SELECT COUNT(*) FROM Bookings WHERE UserID = @UserID"

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(checkQuery, conn)
                cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                Try
                    conn.Open()
                    bookingCount = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End Using
        End Using

        If bookingCount = 0 Then
            MessageBox.Show("You don't have any tickets to cancel.", "No Tickets Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            $"This will cancel ALL {bookingCount} of your booking(s) and cannot be undone. Continue?",
            "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirm <> DialogResult.Yes Then Exit Sub

        If Not VerifyCurrentPassword() Then Exit Sub

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()
            Try
                Dim deletePassengersQuery As String = "
                    DELETE FROM Passengers 
                    WHERE BookingID IN (SELECT BookingID FROM Bookings WHERE UserID = @UserID)"
                Using cmdPassengers As New SqlCommand(deletePassengersQuery, conn, transaction)
                    cmdPassengers.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                    cmdPassengers.ExecuteNonQuery()
                End Using

                Dim deleteBookingsQuery As String = "DELETE FROM Bookings WHERE UserID = @UserID"
                Using cmdBookings As New SqlCommand(deleteBookingsQuery, conn, transaction)
                    cmdBookings.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                    cmdBookings.ExecuteNonQuery()
                End Using

                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Database Error: " & ex.Message, "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End Using

        MessageBox.Show("All your tickets have been cancelled. Your refund will be processed within approximately 24 hours.",
                         "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        UpdateViewTicketButtonState()
        UpdateCancelTicketButtonState()
    End Sub


    Private Sub UpdateViewTicketButtonState()
        Dim ticketCount As Integer = 0
        Dim query As String = "SELECT COUNT(*) FROM Bookings WHERE UserID = @UserID"

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                Try
                    conn.Open()
                    ticketCount = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Error checking tickets: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End Using
        End Using

        Dim hasTickets As Boolean = (ticketCount > 0)
        btnViewTicket.Enabled = hasTickets

        If hasTickets Then
            btnViewTicket.BackColor = Color.FromArgb(0, 90, 190)
            btnViewTicket.ForeColor = Color.White
            btnViewTicket.Cursor = Cursors.Hand
        Else
            btnViewTicket.BackColor = Color.Gainsboro
            btnViewTicket.ForeColor = Color.DarkGray
            btnViewTicket.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub UpdateCancelTicketButtonState()
        Dim ticketCount As Integer = 0
        Dim query As String = "SELECT COUNT(*) FROM Bookings WHERE UserID = @UserID"

        Using conn As New SqlConnection(DatabaseHelper.strConn)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", DatabaseHelper.CurrentLoggedInUserID)
                Try
                    conn.Open()
                    ticketCount = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Error checking tickets: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End Using
        End Using

        Dim hasTickets As Boolean = (ticketCount > 0)
        btnCancelTicket.Enabled = hasTickets

        If hasTickets Then
            btnCancelTicket.BackColor = Color.FromArgb(200, 20, 40)
            btnCancelTicket.ForeColor = Color.White
            btnCancelTicket.Cursor = Cursors.Hand
        Else
            btnCancelTicket.BackColor = Color.Gainsboro
            btnCancelTicket.ForeColor = Color.DarkGray
            btnCancelTicket.Cursor = Cursors.Default
        End If
    End Sub


End Class