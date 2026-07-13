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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpPersonal.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gpContact.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(14, 13)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(293, 47)
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
        Me.grpPersonal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.grpPersonal.Controls.Add(Me.Label5)
        Me.grpPersonal.Controls.Add(Me.Label10)
        Me.grpPersonal.Controls.Add(Me.Label4)
        Me.grpPersonal.Controls.Add(Me.txtLastName)
        Me.grpPersonal.Controls.Add(Me.txtFirstName)
        Me.grpPersonal.Controls.Add(Me.cmbTitle)
        Me.grpPersonal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonal.ForeColor = System.Drawing.Color.DimGray
        Me.grpPersonal.Location = New System.Drawing.Point(46, 186)
        Me.grpPersonal.Margin = New System.Windows.Forms.Padding(2)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Padding = New System.Windows.Forms.Padding(2)
        Me.grpPersonal.Size = New System.Drawing.Size(908, 147)
        Me.grpPersonal.TabIndex = 2
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(182, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "FIRST NAME :"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(539, 57)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(330, 29)
        Me.txtLastName.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(186, 57)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(330, 29)
        Me.txtFirstName.TabIndex = 4
        '
        'cmbTitle
        '
        Me.cmbTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Ms", "Mrs", "Dr"})
        Me.cmbTitle.Location = New System.Drawing.Point(7, 57)
        Me.cmbTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(138, 29)
        Me.cmbTitle.TabIndex = 3
        Me.cmbTitle.Text = "Mr."
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.Black
        Me.lblPass.Location = New System.Drawing.Point(41, 145)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(118, 25)
        Me.lblPass.TabIndex = 0
        Me.lblPass.Text = "Passenger 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.cmbProgram)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(46, 355)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(908, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Frequent Flyer Card"
        '
        'cmbProgram
        '
        Me.cmbProgram.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProgram.ForeColor = System.Drawing.Color.DimGray
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Items.AddRange(New Object() {"None", "AirAsia Rewards", "Enrich", "Singapore KrisFlyer", "Cathay"})
        Me.cmbProgram.Location = New System.Drawing.Point(11, 41)
        Me.cmbProgram.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(858, 33)
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
        Me.gpContact.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gpContact.Controls.Add(Me.Label8)
        Me.gpContact.Controls.Add(Me.Label7)
        Me.gpContact.Controls.Add(Me.Label11)
        Me.gpContact.Controls.Add(Me.Label6)
        Me.gpContact.Controls.Add(Me.cmbCountryCode)
        Me.gpContact.Controls.Add(Me.txtPhoneNumber)
        Me.gpContact.Controls.Add(Me.txtConfirmEmail)
        Me.gpContact.Controls.Add(Me.txtEmail)
        Me.gpContact.Controls.Add(Me.lblContact)
        Me.gpContact.Controls.Add(Me.Label3)
        Me.gpContact.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpContact.ForeColor = System.Drawing.Color.DimGray
        Me.gpContact.Location = New System.Drawing.Point(46, 476)
        Me.gpContact.Margin = New System.Windows.Forms.Padding(2)
        Me.gpContact.Name = "gpContact"
        Me.gpContact.Padding = New System.Windows.Forms.Padding(2)
        Me.gpContact.Size = New System.Drawing.Size(908, 209)
        Me.gpContact.TabIndex = 5
        Me.gpContact.TabStop = False
        Me.gpContact.Text = "Contact Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(9, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email :"
        '
        'cmbCountryCode
        '
        Me.cmbCountryCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountryCode.FormattingEnabled = True
        Me.cmbCountryCode.Items.AddRange(New Object() {"+60", "+65", "+66", "+62", "+1"})
        Me.cmbCountryCode.Location = New System.Drawing.Point(12, 146)
        Me.cmbCountryCode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCountryCode.Name = "cmbCountryCode"
        Me.cmbCountryCode.Size = New System.Drawing.Size(220, 29)
        Me.cmbCountryCode.TabIndex = 12
        Me.cmbCountryCode.Text = "Country Calling Code"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(267, 146)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(341, 29)
        Me.txtPhoneNumber.TabIndex = 11
        '
        'txtConfirmEmail
        '
        Me.txtConfirmEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmEmail.Location = New System.Drawing.Point(447, 84)
        Me.txtConfirmEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConfirmEmail.Name = "txtConfirmEmail"
        Me.txtConfirmEmail.Size = New System.Drawing.Size(400, 29)
        Me.txtConfirmEmail.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(13, 84)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(400, 29)
        Me.txtEmail.TabIndex = 8
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.DimGray
        Me.lblContact.Location = New System.Drawing.Point(10, 24)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(498, 17)
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
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DimGray
        Me.btnClear.Location = New System.Drawing.Point(46, 772)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 49)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Orange
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(609, 764)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(345, 65)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm Passenger Details"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(46, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(908, 119)
        Me.Panel1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(18, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(206, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Please Enter your credential "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(4, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 21)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "TITLE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(535, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "LAST NAME :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(443, 61)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 21)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Confirm Email :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(9, 123)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Country Code :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(263, 123)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Phone Number :"
        '
        'PassengerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 881)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.gpContact)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.grpPersonal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PassengerDetails"
        Me.Text = "Passenger Detail"
        Me.grpPersonal.ResumeLayout(False)
        Me.grpPersonal.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gpContact.ResumeLayout(False)
        Me.gpContact.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
