Public Class FeedBack
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnstars1_Click(sender As Object, e As EventArgs) Handles btnstars1.Click
        btnstars1.Text = "1 stars"
        btnstars1.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "2 stars"
        btnstars1.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = "3 stars"
        btnstars1.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Text = "4 stars"
        btnstars1.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Text = "5 stars"
        btnstars1.BackColor = Color.Gainsboro
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If btnstars1.Text = "" Or Button1.Text = "" Or Button2.Text = "" Or Button3.Text = "" Or Button4.Text = "" Or TxtboxFullname.Text = "" Or TxtBoxIssue.Text = "" Then
            MsgBox("Field Tidak boleh kosong!")
        End If
    End Sub
End Class