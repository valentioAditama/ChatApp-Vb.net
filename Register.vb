Public Class Register
    Private Sub haveAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles haveAccount.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub txtboxPassword_TextChanged(sender As Object, e As EventArgs) Handles txtboxPassword.TextChanged
        txtboxPassword.PasswordChar = "*"
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.MouseEnter
        btnRegister.BackColor = Color.LightGreen
    End Sub

    Private Sub btnRegister_Click_1(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.BackColor = Color.FromArgb(92, 184, 92)
    End Sub
End Class