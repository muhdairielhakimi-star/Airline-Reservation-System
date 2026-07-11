<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class payment
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreditCard = New System.Windows.Forms.Button()
        Me.btnOnlineBanking = New System.Windows.Forms.Button()
        Me.btnEWallet = New System.Windows.Forms.Button()
        Me.pnlCreditCard = New System.Windows.Forms.Panel()
        Me.btnPayCreditCard = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCountryCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHolderName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.txtExpiry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlOnlineBanking = New System.Windows.Forms.Panel()
        Me.cmbBanks = New System.Windows.Forms.ComboBox()
        Me.btnPayOnlineBanking = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlEWallet = New System.Windows.Forms.Panel()
        Me.btnPayEWallet = New System.Windows.Forms.Button()
        Me.txtWalletPhone = New System.Windows.Forms.TextBox()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.cmbEwalletType = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.pnlCreditCard.SuspendLayout()
        Me.pnlOnlineBanking.SuspendLayout()
        Me.pnlEWallet.SuspendLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(440, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(128, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Your Payment Type"
        '
        'btnCreditCard
        '
        Me.btnCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditCard.Location = New System.Drawing.Point(59, 167)
        Me.btnCreditCard.Name = "btnCreditCard"
        Me.btnCreditCard.Size = New System.Drawing.Size(200, 50)
        Me.btnCreditCard.TabIndex = 2
        Me.btnCreditCard.Text = "Debit/Credit Card"
        Me.btnCreditCard.UseVisualStyleBackColor = True
        '
        'btnOnlineBanking
        '
        Me.btnOnlineBanking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnlineBanking.Location = New System.Drawing.Point(59, 223)
        Me.btnOnlineBanking.Name = "btnOnlineBanking"
        Me.btnOnlineBanking.Size = New System.Drawing.Size(200, 50)
        Me.btnOnlineBanking.TabIndex = 3
        Me.btnOnlineBanking.Text = "Online Banking"
        Me.btnOnlineBanking.UseVisualStyleBackColor = True
        '
        'btnEWallet
        '
        Me.btnEWallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEWallet.Location = New System.Drawing.Point(59, 279)
        Me.btnEWallet.Name = "btnEWallet"
        Me.btnEWallet.Size = New System.Drawing.Size(200, 50)
        Me.btnEWallet.TabIndex = 4
        Me.btnEWallet.Text = "Ewallet"
        Me.btnEWallet.UseVisualStyleBackColor = True
        '
        'pnlCreditCard
        '
        Me.pnlCreditCard.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlCreditCard.Controls.Add(Me.btnPayCreditCard)
        Me.pnlCreditCard.Controls.Add(Me.txtEmail)
        Me.pnlCreditCard.Controls.Add(Me.Label10)
        Me.pnlCreditCard.Controls.Add(Me.txtPhone)
        Me.pnlCreditCard.Controls.Add(Me.Label9)
        Me.pnlCreditCard.Controls.Add(Me.txtCountryCode)
        Me.pnlCreditCard.Controls.Add(Me.Label8)
        Me.pnlCreditCard.Controls.Add(Me.txtHolderName)
        Me.pnlCreditCard.Controls.Add(Me.Label7)
        Me.pnlCreditCard.Controls.Add(Me.txtCVV)
        Me.pnlCreditCard.Controls.Add(Me.txtExpiry)
        Me.pnlCreditCard.Controls.Add(Me.Label6)
        Me.pnlCreditCard.Controls.Add(Me.Label5)
        Me.pnlCreditCard.Controls.Add(Me.txtCardNumber)
        Me.pnlCreditCard.Controls.Add(Me.Label4)
        Me.pnlCreditCard.Controls.Add(Me.Label3)
        Me.pnlCreditCard.Location = New System.Drawing.Point(417, 97)
        Me.pnlCreditCard.Name = "pnlCreditCard"
        Me.pnlCreditCard.Size = New System.Drawing.Size(579, 357)
        Me.pnlCreditCard.TabIndex = 8
        '
        'btnPayCreditCard
        '
        Me.btnPayCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayCreditCard.Location = New System.Drawing.Point(491, 331)
        Me.btnPayCreditCard.Name = "btnPayCreditCard"
        Me.btnPayCreditCard.Size = New System.Drawing.Size(75, 23)
        Me.btnPayCreditCard.TabIndex = 15
        Me.btnPayCreditCard.Text = "Pay"
        Me.btnPayCreditCard.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(3, 312)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(140, 20)
        Me.txtEmail.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Email"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(115, 256)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(225, 20)
        Me.txtPhone.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(111, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Phone Number"
        '
        'txtCountryCode
        '
        Me.txtCountryCode.Location = New System.Drawing.Point(7, 256)
        Me.txtCountryCode.Name = "txtCountryCode"
        Me.txtCountryCode.Size = New System.Drawing.Size(73, 20)
        Me.txtCountryCode.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Country +"
        '
        'txtHolderName
        '
        Me.txtHolderName.Location = New System.Drawing.Point(7, 198)
        Me.txtHolderName.Name = "txtHolderName"
        Me.txtHolderName.Size = New System.Drawing.Size(367, 20)
        Me.txtHolderName.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Cardholder's Name"
        '
        'txtCVV
        '
        Me.txtCVV.Location = New System.Drawing.Point(362, 130)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(100, 20)
        Me.txtCVV.TabIndex = 6
        '
        'txtExpiry
        '
        Me.txtExpiry.Location = New System.Drawing.Point(7, 130)
        Me.txtExpiry.Name = "txtExpiry"
        Me.txtExpiry.Size = New System.Drawing.Size(100, 20)
        Me.txtExpiry.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "CVV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Expiry Date"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(7, 69)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(523, 20)
        Me.txtCardNumber.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Card Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Debit/Credit Card"
        '
        'pnlOnlineBanking
        '
        Me.pnlOnlineBanking.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlOnlineBanking.Controls.Add(Me.cmbBanks)
        Me.pnlOnlineBanking.Controls.Add(Me.btnPayOnlineBanking)
        Me.pnlOnlineBanking.Controls.Add(Me.Label12)
        Me.pnlOnlineBanking.Controls.Add(Me.Label11)
        Me.pnlOnlineBanking.Location = New System.Drawing.Point(417, 100)
        Me.pnlOnlineBanking.Name = "pnlOnlineBanking"
        Me.pnlOnlineBanking.Size = New System.Drawing.Size(579, 357)
        Me.pnlOnlineBanking.TabIndex = 9
        Me.pnlOnlineBanking.Visible = False
        '
        'cmbBanks
        '
        Me.cmbBanks.FormattingEnabled = True
        Me.cmbBanks.Items.AddRange(New Object() {"Maybank2u", "CIMB Clicks", "Public Bank", "Rhb Now"})
        Me.cmbBanks.Location = New System.Drawing.Point(7, 88)
        Me.cmbBanks.Name = "cmbBanks"
        Me.cmbBanks.Size = New System.Drawing.Size(164, 21)
        Me.cmbBanks.TabIndex = 19
        '
        'btnPayOnlineBanking
        '
        Me.btnPayOnlineBanking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayOnlineBanking.Location = New System.Drawing.Point(7, 312)
        Me.btnPayOnlineBanking.Name = "btnPayOnlineBanking"
        Me.btnPayOnlineBanking.Size = New System.Drawing.Size(205, 32)
        Me.btnPayOnlineBanking.TabIndex = 18
        Me.btnPayOnlineBanking.Text = "Proceed to Bank Page"
        Me.btnPayOnlineBanking.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Select Your Bank"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 24)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Online Banking"
        '
        'pnlEWallet
        '
        Me.pnlEWallet.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlEWallet.Controls.Add(Me.btnPayEWallet)
        Me.pnlEWallet.Controls.Add(Me.txtWalletPhone)
        Me.pnlEWallet.Controls.Add(Me.picQRCode)
        Me.pnlEWallet.Controls.Add(Me.cmbEwalletType)
        Me.pnlEWallet.Controls.Add(Me.Label19)
        Me.pnlEWallet.Controls.Add(Me.Label20)
        Me.pnlEWallet.Location = New System.Drawing.Point(417, 103)
        Me.pnlEWallet.Name = "pnlEWallet"
        Me.pnlEWallet.Size = New System.Drawing.Size(579, 357)
        Me.pnlEWallet.TabIndex = 15
        Me.pnlEWallet.Visible = False
        '
        'btnPayEWallet
        '
        Me.btnPayEWallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayEWallet.Location = New System.Drawing.Point(3, 308)
        Me.btnPayEWallet.Name = "btnPayEWallet"
        Me.btnPayEWallet.Size = New System.Drawing.Size(121, 31)
        Me.btnPayEWallet.TabIndex = 18
        Me.btnPayEWallet.Text = "Pay Now"
        Me.btnPayEWallet.UseVisualStyleBackColor = True
        '
        'txtWalletPhone
        '
        Me.txtWalletPhone.Location = New System.Drawing.Point(7, 282)
        Me.txtWalletPhone.Name = "txtWalletPhone"
        Me.txtWalletPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtWalletPhone.TabIndex = 17
        '
        'picQRCode
        '
        Me.picQRCode.Location = New System.Drawing.Point(7, 111)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(186, 165)
        Me.picQRCode.TabIndex = 16
        Me.picQRCode.TabStop = False
        '
        'cmbEwalletType
        '
        Me.cmbEwalletType.FormattingEnabled = True
        Me.cmbEwalletType.Items.AddRange(New Object() {"Touch 'n Go", "GrabPay", "Boost", "ShoppePay", "ShoppePay Later"})
        Me.cmbEwalletType.Location = New System.Drawing.Point(7, 87)
        Me.cmbEwalletType.Name = "cmbEwalletType"
        Me.cmbEwalletType.Size = New System.Drawing.Size(121, 21)
        Me.cmbEwalletType.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(179, 20)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Select E-Wallet Provider"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 24)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "E-Wallet"
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.pnlOnlineBanking)
        Me.Controls.Add(Me.pnlEWallet)
        Me.Controls.Add(Me.pnlCreditCard)
        Me.Controls.Add(Me.btnEWallet)
        Me.Controls.Add(Me.btnOnlineBanking)
        Me.Controls.Add(Me.btnCreditCard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "payment"
        Me.Text = "payment"
        Me.pnlCreditCard.ResumeLayout(False)
        Me.pnlCreditCard.PerformLayout()
        Me.pnlOnlineBanking.ResumeLayout(False)
        Me.pnlOnlineBanking.PerformLayout()
        Me.pnlEWallet.ResumeLayout(False)
        Me.pnlEWallet.PerformLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreditCard As Button
    Friend WithEvents btnOnlineBanking As Button
    Friend WithEvents btnEWallet As Button
    Friend WithEvents pnlCreditCard As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCountryCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHolderName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents txtExpiry As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents pnlOnlineBanking As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents pnlEWallet As Panel
    Friend WithEvents btnPayEWallet As Button
    Friend WithEvents txtWalletPhone As TextBox
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents cmbEwalletType As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnPayCreditCard As Button
    Friend WithEvents cmbBanks As ComboBox
    Friend WithEvents btnPayOnlineBanking As Button
End Class
