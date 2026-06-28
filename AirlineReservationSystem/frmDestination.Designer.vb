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
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateReturn = New System.Windows.Forms.DateTimePicker()
        Me.dateDepart = New System.Windows.Forms.DateTimePicker()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.btnWay = New System.Windows.Forms.Button()
        Me.pnlPassengerPopup = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
        Me.pnlPassengerPopup.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFrom
        '
        Me.txtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.Location = New System.Drawing.Point(19, 40)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(80, 26)
        Me.txtFrom.TabIndex = 0
        Me.txtFrom.Text = "From"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dateReturn)
        Me.Panel1.Controls.Add(Me.dateDepart)
        Me.Panel1.Controls.Add(Me.txtTo)
        Me.Panel1.Controls.Add(Me.btnWay)
        Me.Panel1.Controls.Add(Me.txtFrom)
        Me.Panel1.Location = New System.Drawing.Point(74, 43)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 113)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(514, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Return"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Depart"
        '
        'dateReturn
        '
        Me.dateReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateReturn.Location = New System.Drawing.Point(516, 45)
        Me.dateReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.dateReturn.Name = "dateReturn"
        Me.dateReturn.Size = New System.Drawing.Size(115, 26)
        Me.dateReturn.TabIndex = 4
        '
        'dateDepart
        '
        Me.dateDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDepart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDepart.Location = New System.Drawing.Point(358, 45)
        Me.dateDepart.Margin = New System.Windows.Forms.Padding(2)
        Me.dateDepart.Name = "dateDepart"
        Me.dateDepart.Size = New System.Drawing.Size(115, 26)
        Me.dateDepart.TabIndex = 3
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(218, 43)
        Me.txtTo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(76, 26)
        Me.txtTo.TabIndex = 2
        Me.txtTo.Text = "To"
        '
        'btnWay
        '
        Me.btnWay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWay.Location = New System.Drawing.Point(118, 40)
        Me.btnWay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWay.Name = "btnWay"
        Me.btnWay.Size = New System.Drawing.Size(74, 29)
        Me.btnWay.TabIndex = 1
        Me.btnWay.Text = "⇄"
        Me.btnWay.UseVisualStyleBackColor = True
        '
        'pnlPassengerPopup
        '
        Me.pnlPassengerPopup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.pnlPassengerPopup.Location = New System.Drawing.Point(74, 170)
        Me.pnlPassengerPopup.Name = "pnlPassengerPopup"
        Me.pnlPassengerPopup.Size = New System.Drawing.Size(247, 268)
        Me.pnlPassengerPopup.TabIndex = 4
        Me.pnlPassengerPopup.Visible = False
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
        Me.btnFind.Location = New System.Drawing.Point(327, 391)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(147, 47)
        Me.btnFind.TabIndex = 5
        Me.btnFind.Text = "Find me a flight now"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'frmPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.pnlPassengerPopup)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPath"
        Me.Text = "⇄"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlPassengerPopup.ResumeLayout(False)
        Me.pnlPassengerPopup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFrom As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dateReturn As DateTimePicker
    Friend WithEvents dateDepart As DateTimePicker
    Friend WithEvents txtTo As TextBox
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
End Class
