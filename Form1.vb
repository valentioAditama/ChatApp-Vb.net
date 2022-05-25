Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Button1.BackColor = Color.DodgerBlue
        Me.Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackColor = Color.FromArgb(2, 117, 216)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Me.Button2.BackColor = Color.Red
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackColor = Color.FromArgb(217, 83, 79)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
