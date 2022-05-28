Public Class FeedBack
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnstars1_Click(sender As Object, e As EventArgs) Handles btnstars1.Click
        btnstars1.Text = "1 stars"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class