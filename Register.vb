Imports MySql.Data.MySqlClient
Public Class Register
    Private Sub haveAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles haveAccount.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub txtboxPassword_TextChanged(sender As Object, e As EventArgs) Handles txtboxPassword.TextChanged
        ' txtboxPassword.PasswordChar = "*"
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.MouseEnter
        btnRegister.BackColor = Color.LightGreen
    End Sub

    Private Sub btnRegister_Click_1(sender As Object, e As EventArgs) Handles btnRegister.MouseLeave
        btnRegister.BackColor = Color.FromArgb(92, 184, 92)
    End Sub

    Private Sub btnRegister_Click_2(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtboxFullname.Text = "" Or txtboxEmail.Text = "" Or txtboxUsername.Text = "" Or txtboxPassword.Text = "" Then
            MsgBox("Isikan terlebih dahulu")
        Else
            func_register(txtboxFullname.Text, txtboxEmail.Text, txtboxUsername.Text, txtboxPassword.Text)
            MsgBox("Register sukses", vbInformation)
            Me.Dispose()
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.CheckState = CheckState.Checked Then
            txtboxPassword.UseSystemPasswordChar = False
        Else
            txtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxPassword.UseSystemPasswordChar = True
    End Sub
End Class