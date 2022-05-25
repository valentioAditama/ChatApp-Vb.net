Public Class Register
    Private Sub haveAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles haveAccount.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub txtboxPassword_TextChanged(sender As Object, e As EventArgs) Handles txtboxPassword.TextChanged
        txtboxPassword.PasswordChar = "*"
    End Sub
End Class