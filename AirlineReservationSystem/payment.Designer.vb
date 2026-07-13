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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelPayment = New System.Windows.Forms.Button()
        Me.pnlCreditCard.SuspendLayout()
        Me.pnlOnlineBanking.SuspendLayout()
        Me.pnlEWallet.SuspendLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(130, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment"
        '
        'btnCreditCard
        '
        Me.btnCreditCard.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCreditCard.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditCard.ForeColor = System.Drawing.Color.White
        Me.btnCreditCard.Location = New System.Drawing.Point(17, 69)
        Me.btnCreditCard.Name = "btnCreditCard"
        Me.btnCreditCard.Size = New System.Drawing.Size(260, 55)
        Me.btnCreditCard.TabIndex = 2
        Me.btnCreditCard.Text = "Debit/Credit Card"
        Me.btnCreditCard.UseVisualStyleBackColor = False
        '
        'btnOnlineBanking
        '
        Me.btnOnlineBanking.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnlineBanking.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnOnlineBanking.Location = New System.Drawing.Point(17, 148)
        Me.btnOnlineBanking.Name = "btnOnlineBanking"
        Me.btnOnlineBanking.Size = New System.Drawing.Size(260, 55)
        Me.btnOnlineBanking.TabIndex = 3
        Me.btnOnlineBanking.Text = "Online Banking"
        Me.btnOnlineBanking.UseVisualStyleBackColor = True
        '
        'btnEWallet
        '
        Me.btnEWallet.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEWallet.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnEWallet.Location = New System.Drawing.Point(17, 227)
        Me.btnEWallet.Name = "btnEWallet"
        Me.btnEWallet.Size = New System.Drawing.Size(260, 55)
        Me.btnEWallet.TabIndex = 4
        Me.btnEWallet.Text = "E-wallet"
        Me.btnEWallet.UseVisualStyleBackColor = True
        '
        'pnlCreditCard
        '
        Me.pnlCreditCard.BackColor = System.Drawing.Color.White
        Me.pnlCreditCard.Controls.Add(Me.pnlEWallet)
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
        Me.pnlCreditCard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlCreditCard.Location = New System.Drawing.Point(354, 65)
        Me.pnlCreditCard.Name = "pnlCreditCard"
        Me.pnlCreditCard.Size = New System.Drawing.Size(620, 500)
        Me.pnlCreditCard.TabIndex = 8
        '
        'btnPayCreditCard
        '
        Me.btnPayCreditCard.BackColor = System.Drawing.Color.Blue
        Me.btnPayCreditCard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayCreditCard.ForeColor = System.Drawing.Color.White
        Me.btnPayCreditCard.Location = New System.Drawing.Point(437, 447)
        Me.btnPayCreditCard.Name = "btnPayCreditCard"
        Me.btnPayCreditCard.Size = New System.Drawing.Size(180, 50)
        Me.btnPayCreditCard.TabIndex = 15
        Me.btnPayCreditCard.Text = "Pay Now"
        Me.btnPayCreditCard.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEmail.Location = New System.Drawing.Point(8, 412)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(333, 25)
        Me.txtEmail.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(4, 388)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 21)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Email :"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPhone.Location = New System.Drawing.Point(115, 345)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(225, 25)
        Me.txtPhone.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(111, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 21)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Phone Number :"
        '
        'txtCountryCode
        '
        Me.txtCountryCode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCountryCode.Location = New System.Drawing.Point(7, 345)
        Me.txtCountryCode.Name = "txtCountryCode"
        Me.txtCountryCode.Size = New System.Drawing.Size(73, 25)
        Me.txtCountryCode.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(4, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Country +"
        '
        'txtHolderName
        '
        Me.txtHolderName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtHolderName.Location = New System.Drawing.Point(7, 252)
        Me.txtHolderName.Name = "txtHolderName"
        Me.txtHolderName.Size = New System.Drawing.Size(524, 25)
        Me.txtHolderName.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(4, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Cardholder's Name :"
        '
        'txtCVV
        '
        Me.txtCVV.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCVV.Location = New System.Drawing.Point(215, 185)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(170, 25)
        Me.txtCVV.TabIndex = 6
        '
        'txtExpiry
        '
        Me.txtExpiry.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtExpiry.Location = New System.Drawing.Point(7, 185)
        Me.txtExpiry.Name = "txtExpiry"
        Me.txtExpiry.Size = New System.Drawing.Size(180, 25)
        Me.txtExpiry.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(211, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "CVV :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(4, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Expiry Date :"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCardNumber.Location = New System.Drawing.Point(8, 106)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(523, 25)
        Me.txtCardNumber.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(4, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Card Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(3, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Debit/Credit Card"
        '
        'pnlOnlineBanking
        '
        Me.pnlOnlineBanking.BackColor = System.Drawing.Color.White
        Me.pnlOnlineBanking.Controls.Add(Me.cmbBanks)
        Me.pnlOnlineBanking.Controls.Add(Me.btnPayOnlineBanking)
        Me.pnlOnlineBanking.Controls.Add(Me.Label12)
        Me.pnlOnlineBanking.Controls.Add(Me.Label11)
        Me.pnlOnlineBanking.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOnlineBanking.Location = New System.Drawing.Point(0, 3)
        Me.pnlOnlineBanking.Name = "pnlOnlineBanking"
        Me.pnlOnlineBanking.Size = New System.Drawing.Size(620, 500)
        Me.pnlOnlineBanking.TabIndex = 9
        Me.pnlOnlineBanking.Visible = False
        '
        'cmbBanks
        '
        Me.cmbBanks.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbBanks.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBanks.FormattingEnabled = True
        Me.cmbBanks.Items.AddRange(New Object() {"Maybank2u", "CIMB Clicks", "Public Bank", "Rhb Now"})
        Me.cmbBanks.Location = New System.Drawing.Point(7, 88)
        Me.cmbBanks.Name = "cmbBanks"
        Me.cmbBanks.Size = New System.Drawing.Size(249, 28)
        Me.cmbBanks.TabIndex = 19
        '
        'btnPayOnlineBanking
        '
        Me.btnPayOnlineBanking.BackColor = System.Drawing.Color.Blue
        Me.btnPayOnlineBanking.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayOnlineBanking.ForeColor = System.Drawing.Color.White
        Me.btnPayOnlineBanking.Location = New System.Drawing.Point(437, 447)
        Me.btnPayOnlineBanking.Name = "btnPayOnlineBanking"
        Me.btnPayOnlineBanking.Size = New System.Drawing.Size(180, 50)
        Me.btnPayOnlineBanking.TabIndex = 18
        Me.btnPayOnlineBanking.Text = "Pay now"
        Me.btnPayOnlineBanking.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(4, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 21)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Select Your Bank"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(3, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 25)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Online Banking"
        '
        'pnlEWallet
        '
        Me.pnlEWallet.BackColor = System.Drawing.Color.White
        Me.pnlEWallet.Controls.Add(Me.pnlOnlineBanking)
        Me.pnlEWallet.Controls.Add(Me.Label2)
        Me.pnlEWallet.Controls.Add(Me.btnPayEWallet)
        Me.pnlEWallet.Controls.Add(Me.txtWalletPhone)
        Me.pnlEWallet.Controls.Add(Me.picQRCode)
        Me.pnlEWallet.Controls.Add(Me.cmbEwalletType)
        Me.pnlEWallet.Controls.Add(Me.Label19)
        Me.pnlEWallet.Controls.Add(Me.Label20)
        Me.pnlEWallet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlEWallet.Location = New System.Drawing.Point(0, 4)
        Me.pnlEWallet.Name = "pnlEWallet"
        Me.pnlEWallet.Size = New System.Drawing.Size(620, 500)
        Me.pnlEWallet.TabIndex = 15
        Me.pnlEWallet.Visible = False
        '
        'btnPayEWallet
        '
        Me.btnPayEWallet.BackColor = System.Drawing.Color.Blue
        Me.btnPayEWallet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayEWallet.ForeColor = System.Drawing.Color.White
        Me.btnPayEWallet.Location = New System.Drawing.Point(426, 438)
        Me.btnPayEWallet.Name = "btnPayEWallet"
        Me.btnPayEWallet.Size = New System.Drawing.Size(180, 50)
        Me.btnPayEWallet.TabIndex = 18
        Me.btnPayEWallet.Text = "Pay Now"
        Me.btnPayEWallet.UseVisualStyleBackColor = False
        '
        'txtWalletPhone
        '
        Me.txtWalletPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWalletPhone.Location = New System.Drawing.Point(8, 323)
        Me.txtWalletPhone.Name = "txtWalletPhone"
        Me.txtWalletPhone.Size = New System.Drawing.Size(216, 25)
        Me.txtWalletPhone.TabIndex = 17
        '
        'picQRCode
        '
        Me.picQRCode.Location = New System.Drawing.Point(8, 131)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(186, 165)
        Me.picQRCode.TabIndex = 16
        Me.picQRCode.TabStop = False
        '
        'cmbEwalletType
        '
        Me.cmbEwalletType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEwalletType.FormattingEnabled = True
        Me.cmbEwalletType.Items.AddRange(New Object() {"Touch 'n Go", "GrabPay", "Boost", "ShoppePay", "ShoppePay Later"})
        Me.cmbEwalletType.Location = New System.Drawing.Point(7, 87)
        Me.cmbEwalletType.Name = "cmbEwalletType"
        Me.cmbEwalletType.Size = New System.Drawing.Size(217, 28)
        Me.cmbEwalletType.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(3, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(175, 21)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Select E-Wallet Provider"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(3, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 25)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "E-Wallet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(4, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Phone Number :"
        '
        'btnCancelPayment
        '
        Me.btnCancelPayment.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPayment.Location = New System.Drawing.Point(12, 828)
        Me.btnCancelPayment.Name = "btnCancelPayment"
        Me.btnCancelPayment.Size = New System.Drawing.Size(212, 41)
        Me.btnCancelPayment.TabIndex = 9
        Me.btnCancelPayment.Text = "Cancel Payment"
        Me.btnCancelPayment.UseVisualStyleBackColor = True
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 881)
        Me.Controls.Add(Me.btnCancelPayment)
        Me.Controls.Add(Me.pnlCreditCard)
        Me.Controls.Add(Me.btnEWallet)
        Me.Controls.Add(Me.btnOnlineBanking)
        Me.Controls.Add(Me.btnCreditCard)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelPayment As Button
End Class
