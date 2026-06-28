Public Class frmDestination
    ' Track passenger counts globally
    Private adultCount As Integer = 1
    Private childCount As Integer = 0
    Private infantCount As Integer = 0
    Private selectedClass As String = "Economy"

    ' Form Load event to set initial display states
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default system values when application starts
        UpdateUI()
    End Sub

    ' ==========================================
    ' POPUP VISIBILITY CONTROLLER
    ' ==========================================
    ' Note: If you have a main button that opens/closes this panel, 
    ' change "btnMainSelector" to match that button's actual name.
    Private Sub btnMainSelector_Click(sender As Object, e As EventArgs) Handles btnMainSelector.Click
        pnlPassengerPopup.Visible = Not pnlPassengerPopup.Visible
        pnlPassengerPopup.BringToFront()
    End Sub

    ' ==========================================
    ' ADULTS COUNTER LOGIC
    ' ==========================================
    Private Sub btnAdultsPlus_Click(sender As Object, e As EventArgs) Handles btnAdultsPlus.Click
        ' Maximum total passengers limit across all categories is 9
        If (adultCount + childCount + infantCount) < 9 Then
            adultCount += 1
            UpdateUI()
        End If
    End Sub

    Private Sub btnAdultsMinus_Click(sender As Object, e As EventArgs) Handles btnAdultsMinus.Click
        ' Must have at least 1 adult traveling
        If adultCount > 1 Then
            adultCount -= 1

            ' Safety Check: Infants cannot exceed the number of remaining adults
            If infantCount > adultCount Then
                infantCount = adultCount
            End If

            UpdateUI()
        End If
    End Sub

    ' ==========================================
    ' CHILDREN COUNTER LOGIC
    ' ==========================================
    Private Sub btnChildrenPlus_Click(sender As Object, e As EventArgs) Handles btnChildrenPlus.Click
        If (adultCount + childCount + infantCount) < 9 Then
            childCount += 1
            UpdateUI()
        End If
    End Sub

    Private Sub btnChildrenMinus_Click(sender As Object, e As EventArgs) Handles btnChildrenMinus.Click
        If childCount > 0 Then
            childCount -= 1
            UpdateUI()
        End If
    End Sub

    ' ==========================================
    ' INFANTS COUNTER LOGIC
    ' ==========================================
    Private Sub btnInfantsPlus_Click(sender As Object, e As EventArgs) Handles btnInfantsPlus.Click
        ' Airline rules: Total < 9, and you can't have more lap-infants than adults
        If (adultCount + childCount + infantCount) < 9 AndAlso infantCount < adultCount Then
            infantCount += 1
            UpdateUI()
        End If
    End Sub

    Private Sub btnInfantsMinus_Click(sender As Object, e As EventArgs) Handles btnInfantsMinus.Click
        If infantCount > 0 Then
            infantCount -= 1
            UpdateUI()
        End If
    End Sub

    ' ==========================================
    ' CABIN CLASS LOGIC
    ' ==========================================
    Private Sub btnEconomy_Click(sender As Object, e As EventArgs) Handles btnEconomy.Click
        selectedClass = "Economy"

        ' Change colors to indicate active selection (Deep Royal Blue vs White)
        btnEconomy.BackColor = Color.FromArgb(0, 90, 190)
        btnEconomy.ForeColor = Color.White

        btnBusiness.BackColor = Color.White
        btnBusiness.ForeColor = Color.Black
        UpdateUI()
    End Sub

    Private Sub btnBusiness_Click(sender As Object, e As EventArgs) Handles btnBusiness.Click
        selectedClass = "Business"

        btnBusiness.BackColor = Color.FromArgb(0, 90, 190)
        btnBusiness.ForeColor = Color.White

        btnEconomy.BackColor = Color.White
        btnEconomy.ForeColor = Color.Black
        UpdateUI()
    End Sub

    ' ==========================================
    ' SWAP BUTTON (btnWay) LOGIC
    ' ==========================================
    Private Sub btnWay_Click(sender As Object, e As EventArgs) Handles btnWay.Click
        ' Swap the input locations instantly
        Dim tempCity As String = txtFrom.Text
        txtFrom.Text = txtTo.Text
        txtTo.Text = tempCity
    End Sub

    ' ==========================================
    ' SEARCH BUTTON (btnFind) LOGIC
    ' ==========================================
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ' Simple validation check
        If String.IsNullOrWhiteSpace(txtFrom.Text) OrElse String.IsNullOrWhiteSpace(txtTo.Text) Then
            MessageBox.Show("Please enter both Departure and Destination cities.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Example action: display string layout confirmation
        Dim flightDetails As String = $"Searching flights from {txtFrom.Text} to {txtTo.Text}..." & vbCrLf &
                                     $"Depart: {dateDepart.Value.ToShortDateString()}" & vbCrLf &
                                     $"Return: {dateReturn.Value.ToShortDateString()}" & vbCrLf &
                                     $"Passengers: Adults({adultCount}), Children({childCount}), Infants({infantCount})" & vbCrLf &
                                     $"Class: {selectedClass}"

        MessageBox.Show(flightDetails, "Flight Search Initiated", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ==========================================
    ' DISPLAY UI REFRESHER
    ' ==========================================
    Private Sub UpdateUI()
        ' Sync counting values with UI label elements
        lblAdultCount.Text = adultCount.ToString()
        lblChildrenCount.Text = childCount.ToString()
        lblInfantCount.Text = infantCount.ToString()

        ' Calculate overall total passengers
        Dim totalPass As Integer = adultCount + childCount + infantCount

        ' Updates the text on the button that triggers the dropdown panel
        btnMainSelector.Text = $"{totalPass} Passengers, {selectedClass}"
    End Sub
End Class