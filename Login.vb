Imports MySql.Data.MySqlClient
Public Class Login

    Dim connection As MySqlConnection
    Private Sub txtboxPassword_TextChanged(sender As Object, e As EventArgs) Handles txtboxPassword.TextChanged
        txtboxPassword.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Button1.BackColor = Color.LightGreen
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackColor = Color.FromArgb(92, 184, 92)
    End Sub

    Private Sub Register_Click_1(sender As Object, e As EventArgs) Handles btnRegister.MouseEnter
        Me.btnRegister.BackColor = Color.LightBlue
    End Sub

    Private Sub Register_Click_2(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        Me.btnRegister.BackColor = Color.FromArgb(2, 117, 216)
    End Sub

    Private Sub Register_Click_3(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub forgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnForgotpassword.LinkClicked
        ForgotPassword.Show()
        Me.Hide()
    End Sub

    Private Sub linktoform_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linktoform.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi.koneksi()
    End Sub
End Class