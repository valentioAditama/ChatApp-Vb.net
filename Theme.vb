Public Class Theme
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.BackColor = Color.SkyBlue
        AboutUs.BackColor = Color.SkyBlue
        EditProfile.BackColor = Color.SkyBlue
        FeedBack.BackColor = Color.SkyBlue
        Loading.BackColor = Color.SkyBlue
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Home.BackColor = Color.White
        AboutUs.BackColor = Color.White
        EditProfile.BackColor = Color.White
        FeedBack.BackColor = Color.White
        Loading.BackColor = Color.White
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.BackColor = Color.LightGreen
        AboutUs.BackColor = Color.LightGreen
        EditProfile.BackColor = Color.LightGreen
        FeedBack.BackColor = Color.LightGreen
        Loading.BackColor = Color.LightGreen
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.BackColor = Color.Aquamarine
        AboutUs.BackColor = Color.Aquamarine
        EditProfile.BackColor = Color.Aquamarine
        FeedBack.BackColor = Color.Aquamarine
        Loading.BackColor = Color.Aquamarine
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim bg As New OpenFileDialog
        If bg.ShowDialog = Windows.Forms.DialogResult.OK Then
            AboutUs.BackgroundImage = Image.FromFile(bg.FileName)
            FeedBack.BackgroundImage = Image.FromFile(bg.FileName)
            EditProfile.BackgroundImage = Image.FromFile(bg.FileName)
            Loading.BackgroundImage = Image.FromFile(bg.FileName)
            Login.BackgroundImage = Image.FromFile(bg.FileName)
            Me.BackgroundImage = Image.FromFile(bg.FileName)
        End If
    End Sub
End Class