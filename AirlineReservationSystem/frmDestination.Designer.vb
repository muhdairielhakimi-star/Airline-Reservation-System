<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPath
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbTo = New System.Windows.Forms.ComboBox()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateReturn = New System.Windows.Forms.DateTimePicker()
        Me.dateDepart = New System.Windows.Forms.DateTimePicker()
        Me.btnWay = New System.Windows.Forms.Button()
        Me.pnlPassengerPopup = New System.Windows.Forms.Panel()
        Me.btnFirstClass = New System.Windows.Forms.Button()
        Me.btnInfantsMinus = New System.Windows.Forms.Button()
        Me.btnInfantsPlus = New System.Windows.Forms.Button()
        Me.lblInfantsCount = New System.Windows.Forms.Label()
        Me.lblInfants = New System.Windows.Forms.Label()
        Me.btnChildrenMinus = New System.Windows.Forms.Button()
        Me.btnChildrenPlus = New System.Windows.Forms.Button()
        Me.lblChildrenCount = New System.Windows.Forms.Label()
        Me.lblChildren = New System.Windows.Forms.Label()
        Me.btnBusiness = New System.Windows.Forms.Button()
        Me.btnAdultsPlus = New System.Windows.Forms.Button()
        Me.btnEconomy = New System.Windows.Forms.Button()
        Me.lblAdultsCount = New System.Windows.Forms.Label()
        Me.btnAdultsMinus = New System.Windows.Forms.Button()
        Me.lblAdults = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlPassengerPopup.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.cmbTo)
        Me.Panel1.Controls.Add(Me.cmbFrom)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dateReturn)
        Me.Panel1.Controls.Add(Me.dateDepart)
        Me.Panel1.Controls.Add(Me.btnWay)
        Me.Panel1.Location = New System.Drawing.Point(38, 378)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 137)
        Me.Panel1.TabIndex = 1
        '
        'cmbTo
        '
        Me.cmbTo.FormattingEnabled = True
        Me.cmbTo.Location = New System.Drawing.Point(230, 53)
        Me.cmbTo.Name = "cmbTo"
        Me.cmbTo.Size = New System.Drawing.Size(117, 21)
        Me.cmbTo.TabIndex = 9
        '
        'cmbFrom
        '
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(27, 53)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(117, 21)
        Me.cmbFrom.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(662, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 33)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(704, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Return"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(523, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Depart"
        '
        'dateReturn
        '
        Me.dateReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateReturn.Location = New System.Drawing.Point(707, 53)
        Me.dateReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.dateReturn.Name = "dateReturn"
        Me.dateReturn.Size = New System.Drawing.Size(115, 31)
        Me.dateReturn.TabIndex = 4
        '
        'dateDepart
        '
        Me.dateDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDepart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDepart.Location = New System.Drawing.Point(526, 53)
        Me.dateDepart.Margin = New System.Windows.Forms.Padding(2)
        Me.dateDepart.Name = "dateDepart"
        Me.dateDepart.Size = New System.Drawing.Size(115, 31)
        Me.dateDepart.TabIndex = 3
        '
        'btnWay
        '
        Me.btnWay.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnWay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWay.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnWay.Location = New System.Drawing.Point(153, 49)
        Me.btnWay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWay.Name = "btnWay"
        Me.btnWay.Size = New System.Drawing.Size(72, 35)
        Me.btnWay.TabIndex = 1
        Me.btnWay.Text = "⇄"
        Me.btnWay.UseVisualStyleBackColor = False
        '
        'pnlPassengerPopup
        '
        Me.pnlPassengerPopup.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlPassengerPopup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPassengerPopup.Controls.Add(Me.btnFirstClass)
        Me.pnlPassengerPopup.Controls.Add(Me.btnInfantsMinus)
        Me.pnlPassengerPopup.Controls.Add(Me.btnInfantsPlus)
        Me.pnlPassengerPopup.Controls.Add(Me.lblInfantsCount)
        Me.pnlPassengerPopup.Controls.Add(Me.lblInfants)
        Me.pnlPassengerPopup.Controls.Add(Me.btnChildrenMinus)
        Me.pnlPassengerPopup.Controls.Add(Me.btnChildrenPlus)
        Me.pnlPassengerPopup.Controls.Add(Me.lblChildrenCount)
        Me.pnlPassengerPopup.Controls.Add(Me.lblChildren)
        Me.pnlPassengerPopup.Controls.Add(Me.btnBusiness)
        Me.pnlPassengerPopup.Controls.Add(Me.btnAdultsPlus)
        Me.pnlPassengerPopup.Controls.Add(Me.btnEconomy)
        Me.pnlPassengerPopup.Controls.Add(Me.lblAdultsCount)
        Me.pnlPassengerPopup.Controls.Add(Me.btnAdultsMinus)
        Me.pnlPassengerPopup.Controls.Add(Me.lblAdults)
        Me.pnlPassengerPopup.Location = New System.Drawing.Point(38, 550)
        Me.pnlPassengerPopup.Name = "pnlPassengerPopup"
        Me.pnlPassengerPopup.Size = New System.Drawing.Size(261, 269)
        Me.pnlPassengerPopup.TabIndex = 4
        '
        'btnFirstClass
        '
        Me.btnFirstClass.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnFirstClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirstClass.Location = New System.Drawing.Point(171, 230)
        Me.btnFirstClass.Name = "btnFirstClass"
        Me.btnFirstClass.Size = New System.Drawing.Size(75, 23)
        Me.btnFirstClass.TabIndex = 15
        Me.btnFirstClass.Text = "First Class"
        Me.btnFirstClass.UseVisualStyleBackColor = False
        '
        'btnInfantsMinus
        '
        Me.btnInfantsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfantsMinus.Location = New System.Drawing.Point(76, 153)
        Me.btnInfantsMinus.Name = "btnInfantsMinus"
        Me.btnInfantsMinus.Size = New System.Drawing.Size(67, 23)
        Me.btnInfantsMinus.TabIndex = 14
        Me.btnInfantsMinus.Text = "-"
        Me.btnInfantsMinus.UseVisualStyleBackColor = True
        '
        'btnInfantsPlus
        '
        Me.btnInfantsPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfantsPlus.Location = New System.Drawing.Point(171, 153)
        Me.btnInfantsPlus.Name = "btnInfantsPlus"
        Me.btnInfantsPlus.Size = New System.Drawing.Size(67, 23)
        Me.btnInfantsPlus.TabIndex = 13
        Me.btnInfantsPlus.Text = "+"
        Me.btnInfantsPlus.UseVisualStyleBackColor = True
        '
        'lblInfantsCount
        '
        Me.lblInfantsCount.AutoSize = True
        Me.lblInfantsCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfantsCount.Location = New System.Drawing.Point(149, 157)
        Me.lblInfantsCount.Name = "lblInfantsCount"
        Me.lblInfantsCount.Size = New System.Drawing.Size(16, 16)
        Me.lblInfantsCount.TabIndex = 12
        Me.lblInfantsCount.Text = "0"
        '
        'lblInfants
        '
        Me.lblInfants.AutoSize = True
        Me.lblInfants.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfants.Location = New System.Drawing.Point(3, 160)
        Me.lblInfants.Name = "lblInfants"
        Me.lblInfants.Size = New System.Drawing.Size(53, 16)
        Me.lblInfants.TabIndex = 11
        Me.lblInfants.Text = "Infants"
        '
        'btnChildrenMinus
        '
        Me.btnChildrenMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChildrenMinus.Location = New System.Drawing.Point(76, 86)
        Me.btnChildrenMinus.Name = "btnChildrenMinus"
        Me.btnChildrenMinus.Size = New System.Drawing.Size(67, 23)
        Me.btnChildrenMinus.TabIndex = 10
        Me.btnChildrenMinus.Text = "-"
        Me.btnChildrenMinus.UseVisualStyleBackColor = True
        '
        'btnChildrenPlus
        '
        Me.btnChildrenPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChildrenPlus.Location = New System.Drawing.Point(171, 86)
        Me.btnChildrenPlus.Name = "btnChildrenPlus"
        Me.btnChildrenPlus.Size = New System.Drawing.Size(67, 23)
        Me.btnChildrenPlus.TabIndex = 9
        Me.btnChildrenPlus.Text = "+"
        Me.btnChildrenPlus.UseVisualStyleBackColor = True
        '
        'lblChildrenCount
        '
        Me.lblChildrenCount.AutoSize = True
        Me.lblChildrenCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildrenCount.Location = New System.Drawing.Point(149, 90)
        Me.lblChildrenCount.Name = "lblChildrenCount"
        Me.lblChildrenCount.Size = New System.Drawing.Size(16, 16)
        Me.lblChildrenCount.TabIndex = 8
        Me.lblChildrenCount.Text = "0"
        '
        'lblChildren
        '
        Me.lblChildren.AutoSize = True
        Me.lblChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildren.Location = New System.Drawing.Point(3, 86)
        Me.lblChildren.Name = "lblChildren"
        Me.lblChildren.Size = New System.Drawing.Size(65, 16)
        Me.lblChildren.TabIndex = 7
        Me.lblChildren.Text = "Children"
        '
        'btnBusiness
        '
        Me.btnBusiness.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusiness.Location = New System.Drawing.Point(90, 230)
        Me.btnBusiness.Name = "btnBusiness"
        Me.btnBusiness.Size = New System.Drawing.Size(75, 23)
        Me.btnBusiness.TabIndex = 6
        Me.btnBusiness.Text = "Business"
        Me.btnBusiness.UseVisualStyleBackColor = False
        '
        'btnAdultsPlus
        '
        Me.btnAdultsPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdultsPlus.Location = New System.Drawing.Point(171, 21)
        Me.btnAdultsPlus.Name = "btnAdultsPlus"
        Me.btnAdultsPlus.Size = New System.Drawing.Size(67, 23)
        Me.btnAdultsPlus.TabIndex = 3
        Me.btnAdultsPlus.Text = "+"
        Me.btnAdultsPlus.UseVisualStyleBackColor = True
        '
        'btnEconomy
        '
        Me.btnEconomy.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnEconomy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEconomy.Location = New System.Drawing.Point(6, 230)
        Me.btnEconomy.Name = "btnEconomy"
        Me.btnEconomy.Size = New System.Drawing.Size(75, 23)
        Me.btnEconomy.TabIndex = 5
        Me.btnEconomy.Text = "Economy"
        Me.btnEconomy.UseVisualStyleBackColor = False
        '
        'lblAdultsCount
        '
        Me.lblAdultsCount.AutoSize = True
        Me.lblAdultsCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdultsCount.Location = New System.Drawing.Point(149, 24)
        Me.lblAdultsCount.Name = "lblAdultsCount"
        Me.lblAdultsCount.Size = New System.Drawing.Size(16, 16)
        Me.lblAdultsCount.TabIndex = 2
        Me.lblAdultsCount.Text = "0"
        '
        'btnAdultsMinus
        '
        Me.btnAdultsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdultsMinus.Location = New System.Drawing.Point(76, 21)
        Me.btnAdultsMinus.Name = "btnAdultsMinus"
        Me.btnAdultsMinus.Size = New System.Drawing.Size(67, 23)
        Me.btnAdultsMinus.TabIndex = 1
        Me.btnAdultsMinus.Text = "-"
        Me.btnAdultsMinus.UseVisualStyleBackColor = True
        '
        'lblAdults
        '
        Me.lblAdults.AutoSize = True
        Me.lblAdults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdults.Location = New System.Drawing.Point(3, 24)
        Me.lblAdults.Name = "lblAdults"
        Me.lblAdults.Size = New System.Drawing.Size(51, 16)
        Me.lblAdults.TabIndex = 0
        Me.lblAdults.Text = "Adults"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(35, 835)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(147, 47)
        Me.btnFind.TabIndex = 5
        Me.btnFind.Text = "Find me a flight now"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(230, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(549, 55)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Book your next trip now"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(332, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fly with us to get more benefits"
        '
        'dgvSchedule
        '
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Location = New System.Drawing.Point(148, 112)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.Size = New System.Drawing.Size(686, 251)
        Me.dgvSchedule.TabIndex = 8
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Location = New System.Drawing.Point(787, 832)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(147, 47)
        Me.btnProfile.TabIndex = 10
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'frmPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1008, 891)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.dgvSchedule)
        Me.Controls.Add(Me.pnlPassengerPopup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPath"
        Me.Text = "Flight Path"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlPassengerPopup.ResumeLayout(False)
        Me.pnlPassengerPopup.PerformLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dateReturn As DateTimePicker
    Friend WithEvents dateDepart As DateTimePicker
    Friend WithEvents btnWay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlPassengerPopup As Panel
    Friend WithEvents btnChildrenMinus As Button
    Friend WithEvents btnChildrenPlus As Button
    Friend WithEvents lblChildrenCount As Label
    Friend WithEvents lblChildren As Label
    Friend WithEvents btnBusiness As Button
    Friend WithEvents btnAdultsPlus As Button
    Friend WithEvents btnEconomy As Button
    Friend WithEvents lblAdultsCount As Label
    Friend WithEvents btnAdultsMinus As Button
    Friend WithEvents lblAdults As Label
    Friend WithEvents lblInfants As Label
    Friend WithEvents btnInfantsMinus As Button
    Friend WithEvents btnInfantsPlus As Button
    Friend WithEvents lblInfantsCount As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents btnFirstClass As Button
    Friend WithEvents btnProfile As Button
End Class
