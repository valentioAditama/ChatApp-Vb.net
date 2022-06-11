Imports MySql.Data.MySqlClient
Public Class Login

    Dim connection As MySqlConnection
    Private Sub txtboxPassword_TextChanged(sender As Object, e As EventArgs) Handles txtboxPassword.TextChanged
        ' txtboxPassword.PasswordChar = "*"
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
        If TxtxboxUsername.Text = "" Or txtboxPassword.Text = "" Then
            MsgBox("field tidak boleh kosong")
        End If
        Try
            Dim username, pass As String
            username = TxtxboxUsername.Text
            pass = txtboxPassword.Text
            Dim dt As DataTable = func_login(username, pass)
            If dt.Rows.Count > 0 Then
                MsgBox("berhasil login!", vbInformation)
                Me.Dispose()
                'Loading.Show()
                Home.Show()
                Home.Label1.Text = username
                Home.TxtboxListName.Text = "- " + username
                EditProfile.TxtxboxUsername.Text = username
                EditProfile.TxtxboxPassword.Text = pass
                Home.TxtboxIsiMessage.Text = username + " Connected to Server" + vbNewLine
                Me.Hide()
            Else
                MsgBox("Invalid Username dan Password", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
        End Try
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.CheckState = CheckState.Checked Then
            txtboxPassword.UseSystemPasswordChar = False
        Else
            txtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxPassword.UseSystemPasswordChar = True
    End Sub
End Class