<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PassengerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpPersonal = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbProgram = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpContact = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCountryCode = New System.Windows.Forms.ComboBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtConfirmEmail = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpPersonal.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gpContact.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTitle.Location = New System.Drawing.Point(189, 2)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(169, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Passenger Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'grpPersonal
        '
        Me.grpPersonal.Controls.Add(Me.Label5)
        Me.grpPersonal.Controls.Add(Me.Label4)
        Me.grpPersonal.Controls.Add(Me.txtLastName)
        Me.grpPersonal.Controls.Add(Me.txtFirstName)
        Me.grpPersonal.Controls.Add(Me.cmbTitle)
        Me.grpPersonal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.grpPersonal.Location = New System.Drawing.Point(20, 44)
        Me.grpPersonal.Margin = New System.Windows.Forms.Padding(2)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Padding = New System.Windows.Forms.Padding(2)
        Me.grpPersonal.Size = New System.Drawing.Size(557, 101)
        Me.grpPersonal.TabIndex = 2
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Location = New System.Drawing.Point(251, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(251, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "First Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(360, 66)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(154, 22)
        Me.txtLastName.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(360, 21)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(154, 22)
        Me.txtFirstName.TabIndex = 4
        '
        'cmbTitle
        '
        Me.cmbTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Ms", "Mrs", "Dr"})
        Me.cmbTitle.Location = New System.Drawing.Point(11, 32)
        Me.cmbTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(102, 22)
        Me.cmbTitle.TabIndex = 3
        Me.cmbTitle.Text = "Choose a Title"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPass.Location = New System.Drawing.Point(22, 24)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(92, 17)
        Me.lblPass.TabIndex = 0
        Me.lblPass.Text = "Passenger 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbProgram)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(20, 150)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(557, 58)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Frequent Flyer Card"
        '
        'cmbProgram
        '
        Me.cmbProgram.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Items.AddRange(New Object() {"None", "AirAsia Rewards", "Enrich", "Singapore KrisFlyer", "Cathay"})
        Me.cmbProgram.Location = New System.Drawing.Point(11, 30)
        Me.cmbProgram.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(126, 22)
        Me.cmbProgram.TabIndex = 6
        Me.cmbProgram.Text = "Choose a Program"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 4
        '
        'gpContact
        '
        Me.gpContact.Controls.Add(Me.Label8)
        Me.gpContact.Controls.Add(Me.Label7)
        Me.gpContact.Controls.Add(Me.Label6)
        Me.gpContact.Controls.Add(Me.cmbCountryCode)
        Me.gpContact.Controls.Add(Me.txtPhoneNumber)
        Me.gpContact.Controls.Add(Me.txtConfirmEmail)
        Me.gpContact.Controls.Add(Me.txtEmail)
        Me.gpContact.Controls.Add(Me.lblContact)
        Me.gpContact.Controls.Add(Me.Label3)
        Me.gpContact.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpContact.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.gpContact.Location = New System.Drawing.Point(20, 220)
        Me.gpContact.Margin = New System.Windows.Forms.Padding(2)
        Me.gpContact.Name = "gpContact"
        Me.gpContact.Padding = New System.Windows.Forms.Padding(2)
        Me.gpContact.Size = New System.Drawing.Size(557, 109)
        Me.gpContact.TabIndex = 5
        Me.gpContact.TabStop = False
        Me.gpContact.Text = "Contact Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Location = New System.Drawing.Point(9, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email:"
        '
        'cmbCountryCode
        '
        Me.cmbCountryCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountryCode.FormattingEnabled = True
        Me.cmbCountryCode.Items.AddRange(New Object() {"+60", "+65", "+66", "+62", "+1"})
        Me.cmbCountryCode.Location = New System.Drawing.Point(403, 42)
        Me.cmbCountryCode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCountryCode.Name = "cmbCountryCode"
        Me.cmbCountryCode.Size = New System.Drawing.Size(154, 22)
        Me.cmbCountryCode.TabIndex = 12
        Me.cmbCountryCode.Text = "Country Calling Code"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(403, 76)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(154, 22)
        Me.txtPhoneNumber.TabIndex = 11
        '
        'txtConfirmEmail
        '
        Me.txtConfirmEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmEmail.Location = New System.Drawing.Point(121, 76)
        Me.txtConfirmEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConfirmEmail.Name = "txtConfirmEmail"
        Me.txtConfirmEmail.Size = New System.Drawing.Size(154, 22)
        Me.txtConfirmEmail.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(121, 41)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(154, 22)
        Me.txtEmail.TabIndex = 8
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblContact.Location = New System.Drawing.Point(9, 20)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(403, 13)
        Me.lblContact.TabIndex = 6
        Me.lblContact.Text = "Enter your Email and phone number to receive booking information and trip update"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(4, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(380, 343)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 26)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(493, 343)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(84, 26)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label7.Location = New System.Drawing.Point(9, 81)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Confirm Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Location = New System.Drawing.Point(282, 81)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Phone Number:"
        '
        'PassengerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 379)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.gpContact)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.grpPersonal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PassengerDetails"
        Me.Text = "Passenger Detail"
        Me.grpPersonal.ResumeLayout(False)
        Me.grpPersonal.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gpContact.ResumeLayout(False)
        Me.gpContact.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbProgram As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpContact As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCountryCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button

    Private Sub PassengerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the UI to show which passenger we are currently entering
        ' Example: "Passenger 1 of 3"
        lblPass.Text = $"Passenger {BookingSession.CurrentPassengerIndex} of {BookingSession.TotalPassengers}"
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' 1. Basic validation: Make sure they typed a name
        If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Then
            MsgBox("Please enter the passenger's first and last name.", MsgBoxStyle.Exclamation, "Missing Information")
            Exit Sub
        End If

        ' 2. Save THIS passenger to our Brain's List
        Dim fullName As String = txtFirstName.Text.Trim() & " " & txtLastName.Text.Trim()
        BookingSession.PassengerNames.Add(fullName)

        ' We only save frequent flyer + contact info for the very first person (the main booker)
        If BookingSession.CurrentPassengerIndex = 1 Then
            If cmbProgram.SelectedIndex <> -1 Then
                BookingSession.FrequentFlyerProgram = cmbProgram.Text
            Else
                BookingSession.FrequentFlyerProgram = "None"
            End If

            ' Validate email match before saving contact info
            If txtEmail.Text.Trim() = "" Or txtConfirmEmail.Text.Trim() = "" Then
                MsgBox("Please enter and confirm your email address.", MsgBoxStyle.Exclamation, "Missing Contact Info")
                Exit Sub
            End If

            If txtEmail.Text.Trim() <> txtConfirmEmail.Text.Trim() Then
                MsgBox("Email and Confirm Email do not match. Please check and try again.", MsgBoxStyle.Exclamation, "Email Mismatch")
                Exit Sub
            End If

            If cmbCountryCode.SelectedIndex = -1 Or txtPhoneNumber.Text.Trim() = "" Then
                MsgBox("Please select a country code and enter your phone number.", MsgBoxStyle.Exclamation, "Missing Contact Info")
                Exit Sub
            End If

            BookingSession.ContactEmail = txtEmail.Text.Trim()
            BookingSession.ContactPhone = cmbCountryCode.Text & txtPhoneNumber.Text.Trim()
        End If

        ' 3. THE LOOP CHECK: Are there more passengers to enter?
        If BookingSession.CurrentPassengerIndex < BookingSession.TotalPassengers Then
            ' Increase the counter
            BookingSession.CurrentPassengerIndex += 1

            MessageBox.Show($"Passenger saved! Please enter details for Passenger {BookingSession.CurrentPassengerIndex}.", "Next Passenger", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the text boxes so the screen is blank for the next person!
            txtFirstName.Clear()
            txtLastName.Clear()
            cmbTitle.SelectedIndex = -1

            ' Hide loyalty + contact info groups — those only apply to Passenger 1
            GroupBox2.Visible = False
            gpContact.Visible = False

            ' Update the label at the top to say "Passenger 2 of 3"
            lblPass.Text = $"Passenger {BookingSession.CurrentPassengerIndex} of {BookingSession.TotalPassengers}"

            ' Put the blinking cursor back in the first name box
            txtFirstName.Focus()
        Else
            ' EVERYONE IS ENTERED! Move to the Seat Selection screen!
            Me.Hide()
            Dim seatForm As New selectSeat()
            seatForm.Show()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears absolutely everything if they make a mistake
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtConfirmEmail.Clear()
        cmbTitle.SelectedIndex = -1
        cmbProgram.SelectedIndex = -1
        cmbCountryCode.SelectedIndex = -1
    End Sub

    Private Sub grpPersonal_Enter(sender As Object, e As EventArgs) Handles grpPersonal.Enter
        ' Leave empty
    End Sub


End Class
