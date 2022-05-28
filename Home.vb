Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label6.Text = Login.TxtxboxEmail.Text
    End Sub

    Private Sub editProfile_Click(sender As Object, e As EventArgs)
        btnEditProfile.ForeColor = Color.LightGray
    End Sub

    Private Sub editProfile_Click_1(sender As Object, e As EventArgs)
        btnEditProfile.ForeColor = Control.DefaultForeColor
    End Sub

    Private Sub editProfile_Click_2(sender As Object, e As EventArgs)
        ProfileEdit.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        AboutUs.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        FeedBack.Show()
        Me.Hide()
    End Sub

    Private Sub editProfile_Click_3(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        EditProfile.Show()
        Me.Hide()
    End Sub
End Class