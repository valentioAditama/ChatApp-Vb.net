Public Class AboutUs
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnBackAbaoutUS.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click1(sender As Object, e As EventArgs) Handles btnBackAbaoutUS.MouseEnter
        Me.btnBackAbaoutUS.BackColor = Color.LightBlue
    End Sub

    Private Sub btnRegister_Click2(sender As Object, e As EventArgs) Handles btnBackAbaoutUS.MouseLeave
        Me.btnBackAbaoutUS.BackColor = Color.FromArgb(2, 117, 216)
    End Sub
End Class