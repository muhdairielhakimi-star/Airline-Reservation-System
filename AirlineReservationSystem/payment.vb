Public Class payment

    ' ========================================================
    ' FORM INITIALIZATION & LOAD EVENT
    ' ========================================================
    ' FIXED: Changed name to payment_Load to match your class name "payment"
    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Populate Online Banking Dropdown items
        cmbBanks.Items.Clear()
        cmbBanks.Items.AddRange(New Object() {"Maybank2u", "CIMB Clicks", "Public Bank", "RHB Now", "Bank Islam"})
        cmbBanks.SelectedIndex = 0 ' Default to first bank

        ' 2. Populate E-Wallet Dropdown items
        cmbEwalletType.Items.Clear()
        cmbEwalletType.Items.AddRange(New Object() {"Touch 'n Go eWallet", "GrabPay", "Boost", "ShopeePay"})
        cmbEwalletType.SelectedIndex = 0 ' Default to first e-wallet

        ' 3. Establish initial UI state (Show Credit Card frame first)
        ShowPaymentPanel(pnlCreditCard)
        HighlightActiveButton(btnCreditCard)
    End Sub

    ' ========================================================
    ' INTERFACE MANAGEMENT (PANELS & TABS)
    ' ========================================================

    ''' <summary>
    ''' Hides all interface layout containers and targets the requested panel view.
    ''' </summary>
    Private Sub ShowPaymentPanel(panelToShow As Panel)
        ' Hide all panels to prevent overlap conflicts
        pnlCreditCard.Visible = False
        pnlOnlineBanking.Visible = False
        pnlEWallet.Visible = False

        ' Display the requested active panel container
        panelToShow.Visible = True
        panelToShow.BringToFront()
    End Sub

    ''' <summary>
    ''' Styles the active navigation link to visually guide the user.
    ''' </summary>
    Private Sub HighlightActiveButton(activeButton As Button)
        Dim navigationButtons() As Button = {btnCreditCard, btnOnlineBanking, btnEWallet}

        ' Reset all side-bar buttons back to white background
        For Each btn As Button In navigationButtons
            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
        Next

        ' Style the clicked/active method
        activeButton.BackColor = Color.LightGray
        activeButton.ForeColor = Color.Black
    End Sub

    ' ========================================================
    ' LEFT PANEL NAVIGATION CONTROLS
    ' ========================================================
    Private Sub btnCreditCard_Click(sender As Object, e As EventArgs) Handles btnCreditCard.Click
        ShowPaymentPanel(pnlCreditCard)
        HighlightActiveButton(btnCreditCard)
    End Sub

    Private Sub btnOnlineBanking_Click(sender As Object, e As EventArgs) Handles btnOnlineBanking.Click
        ShowPaymentPanel(pnlOnlineBanking)
        HighlightActiveButton(btnOnlineBanking)
    End Sub

    Private Sub btnEWallet_Click(sender As Object, e As EventArgs) Handles btnEWallet.Click
        ShowPaymentPanel(pnlEWallet)
        HighlightActiveButton(btnEWallet)
        ' Run update rule to ensure a QR displays instantly when panel mounts
        UpdateQRCodeImage()
    End Sub

    ' ========================================================
    ' 1. CREDIT/DEBIT CARD LOGIC
    ' ========================================================
    Private Sub btnPayCreditCard_Click(sender As Object, e As EventArgs) Handles btnPayCreditCard.Click
        ' Enforce mandatory card formatting rules
        If String.IsNullOrWhiteSpace(txtCardNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtExpiry.Text) OrElse
           String.IsNullOrWhiteSpace(txtCVV.Text) OrElse
           String.IsNullOrWhiteSpace(txtHolderName.Text) Then

            MessageBox.Show("Please complete all required fields within the Credit/Debit card form.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' TODO: Insert Database submission parameters here (e.g., using DatabaseHelper)
        MessageBox.Show("Credit/Debit Card payment captured successfully! Your airline reservation has been processed.", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ========================================================
    ' 2. ONLINE BANKING LOGIC
    ' ========================================================
    Private Sub btnPayOnlineBanking_Click(sender As Object, e As EventArgs)
        Dim selectedBank As String = cmbBanks.SelectedItem.ToString()

        MessageBox.Show("Routing to " & selectedBank & " portal payment processing engine...", "Secure Redirection", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' TODO: Commit ticket update transactions to your DB here
        MessageBox.Show("Transaction authorized by " & selectedBank & ". Order confirmation finalized!", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ========================================================
    ' 3. E-WALLET LOGIC & DYNAMIC QR ENGINE
    ' ========================================================

    ' Triggers when user selects a different item from the dropdown
    Private Sub cmbEWalletType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEwalletType.SelectedIndexChanged
        UpdateQRCodeImage()
    End Sub

    ''' <summary>
    ''' Switches out placeholder imagery according to target provider selection.
    ''' </summary>
    Private Sub UpdateQRCodeImage()
        If cmbEwalletType.SelectedItem Is Nothing Then Exit Sub

        Dim selectedWallet As String = cmbEwalletType.SelectedItem.ToString()

        ' Ensure image scales proportionally into borders
        picQRCode.SizeMode = PictureBoxSizeMode.Zoom

        ' NOTE: To activate dynamic image switching, drag your asset files (.png/.jpg) into:
        ' Project Menu -> Properties -> Resources -> Add Resource. Then uncomment the links below:
        Select Case selectedWallet
            Case "Touch 'n Go eWallet"
                ' picQRCode.Image = My.Resources.tng_qr_file
            Case "GrabPay"
                ' picQRCode.Image = My.Resources.grab_qr_file
            Case "Boost"
                ' picQRCode.Image = My.Resources.boost_qr_file
            Case "ShopeePay"
                ' picQRCode.Image = My.Resources.shopee_qr_file
        End Select
    End Sub

    Private Sub btnPayEWallet_Click(sender As Object, e As EventArgs) Handles btnPayEWallet.Click
        ' Verify mobile billing identification token exists
        If String.IsNullOrWhiteSpace(txtWalletPhone.Text) Then
            MessageBox.Show("Please type your verified mobile phone number assigned to this digital account.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedWallet As String = cmbEwalletType.SelectedItem.ToString()

        ' TODO: Process database state transitions here 
        MessageBox.Show("A push payment alert has been dispatched to your mobile terminal through " & selectedWallet & ". Verify transaction details inside your phone app.", "Awaiting Account Authorization", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class