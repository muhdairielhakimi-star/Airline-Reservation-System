<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpPersonal = New System.Windows.Forms.GroupBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbProgram = New System.Windows.Forms.ComboBox()
        Me.txtFlyerNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpContact = New System.Windows.Forms.GroupBox()
        Me.cmbCountryCode = New System.Windows.Forms.ComboBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtConfirmEmail = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
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
        Me.lblTitle.Location = New System.Drawing.Point(252, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(212, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Passenger Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 1
        '
        'grpPersonal
        '
        Me.grpPersonal.Controls.Add(Me.txtLastName)
        Me.grpPersonal.Controls.Add(Me.txtFirstName)
        Me.grpPersonal.Controls.Add(Me.cmbTitle)
        Me.grpPersonal.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.grpPersonal.Location = New System.Drawing.Point(26, 54)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Size = New System.Drawing.Size(743, 124)
        Me.grpPersonal.TabIndex = 2
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal Information"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(480, 81)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(204, 26)
        Me.txtLastName.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(10, 81)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(204, 26)
        Me.txtFirstName.TabIndex = 4
        '
        'cmbTitle
        '
        Me.cmbTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Ms", "Mrs", "Dr"})
        Me.cmbTitle.Location = New System.Drawing.Point(15, 40)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(134, 26)
        Me.cmbTitle.TabIndex = 3
        Me.cmbTitle.Text = "Choose a Title"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPass.Location = New System.Drawing.Point(29, 30)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(114, 21)
        Me.lblPass.TabIndex = 0
        Me.lblPass.Text = "Passenger 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbProgram)
        Me.GroupBox2.Controls.Add(Me.txtFlyerNo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(26, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(743, 71)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Frequent Flyer Card"
        '
        'cmbProgram
        '
        Me.cmbProgram.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Items.AddRange(New Object() {"None", "AirAsia Rewards", "Enrich", "Singapore KrisFlyer", "Cathay"})
        Me.cmbProgram.Location = New System.Drawing.Point(15, 37)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(167, 26)
        Me.cmbProgram.TabIndex = 6
        Me.cmbProgram.Text = "Choose a Program"
        '
        'txtFlyerNo
        '
        Me.txtFlyerNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlyerNo.Location = New System.Drawing.Point(480, 37)
        Me.txtFlyerNo.Name = "txtFlyerNo"
        Me.txtFlyerNo.Size = New System.Drawing.Size(204, 26)
        Me.txtFlyerNo.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 21)
        Me.Label1.TabIndex = 4
        '
        'gpContact
        '
        Me.gpContact.Controls.Add(Me.cmbCountryCode)
        Me.gpContact.Controls.Add(Me.txtPhoneNumber)
        Me.gpContact.Controls.Add(Me.txtConfirmEmail)
        Me.gpContact.Controls.Add(Me.txtEmail)
        Me.gpContact.Controls.Add(Me.lblContact)
        Me.gpContact.Controls.Add(Me.Label3)
        Me.gpContact.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpContact.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.gpContact.Location = New System.Drawing.Point(26, 271)
        Me.gpContact.Name = "gpContact"
        Me.gpContact.Size = New System.Drawing.Size(743, 134)
        Me.gpContact.TabIndex = 5
        Me.gpContact.TabStop = False
        Me.gpContact.Text = "Contact Information"
        '
        'cmbCountryCode
        '
        Me.cmbCountryCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountryCode.FormattingEnabled = True
        Me.cmbCountryCode.Items.AddRange(New Object() {"+60", "+65", "+66", "+62", "+1"})
        Me.cmbCountryCode.Location = New System.Drawing.Point(480, 50)
        Me.cmbCountryCode.Name = "cmbCountryCode"
        Me.cmbCountryCode.Size = New System.Drawing.Size(204, 26)
        Me.cmbCountryCode.TabIndex = 12
        Me.cmbCountryCode.Text = "Country Calling Code"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(480, 94)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(204, 26)
        Me.txtPhoneNumber.TabIndex = 11
        '
        'txtConfirmEmail
        '
        Me.txtConfirmEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmEmail.Location = New System.Drawing.Point(10, 94)
        Me.txtConfirmEmail.Name = "txtConfirmEmail"
        Me.txtConfirmEmail.Size = New System.Drawing.Size(204, 26)
        Me.txtConfirmEmail.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(10, 50)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(204, 26)
        Me.txtEmail.TabIndex = 8
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblContact.Location = New System.Drawing.Point(12, 24)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(519, 17)
        Me.lblContact.TabIndex = 6
        Me.lblContact.Text = "Enter your Email and phone number to receive booking information and trip update"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 21)
        Me.Label3.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(506, 422)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 32)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(657, 422)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(112, 32)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.gpContact)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.grpPersonal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
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

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpPersonal As GroupBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents cmbTitle As ComboBox
    Friend WithEvents lblPass As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents txtFlyerNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gpContact As GroupBox
    Friend WithEvents cmbCountryCode As ComboBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtConfirmEmail As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnConfirm As Button
End Class
