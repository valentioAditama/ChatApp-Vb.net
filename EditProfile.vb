Imports MySql.Data.MySqlClient

Public Class EditProfile
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
        PictureBox1.Load(OpenFileDialog1.FileName)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
            connection.Open()

            Dim cmd As New MySqlCommand("update users set fullname='" & TxtxboxFullname.Text & "', email='" & TxtxboxEmail.Text & "', username='" & TxtxboxUsername.Text & "', password='" & TxtxboxPassword.Text & "' WHERE id='" & txtboxId.Text & "' ", connection)

            Dim myreader As MySqlDataReader
            myreader = cmd.ExecuteReader()
            MsgBox("Profile Berhasil Di perbarui")
            MsgBox("Di mohon untuk Login kembali")
            Login.Show()
            Me.Hide()

        Catch ex As Exception
            msg("error: " & ex.Message)
        End Try
    End Sub

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtxboxPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.CheckState = CheckState.Checked Then
            TxtxboxPassword.UseSystemPasswordChar = False
        Else
            TxtxboxPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class