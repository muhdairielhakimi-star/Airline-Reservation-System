
Public Class frmEditField

        Public Prompt As String = ""
        Public IsPasswordField As Boolean = False
        Public ResultValue As String = ""
        Public WasSaved As Boolean = False

        Private Sub frmEditField_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lblPrompt.Text = Prompt
            If IsPasswordField Then
                txtNewValue.UseSystemPasswordChar = True
            End If
            txtNewValue.Focus()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            If String.IsNullOrWhiteSpace(txtNewValue.Text) Then
                MessageBox.Show("Please enter a value.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ResultValue = txtNewValue.Text.Trim()
            WasSaved = True
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            WasSaved = False
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub

End Class