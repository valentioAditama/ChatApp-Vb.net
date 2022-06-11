Public Class FeedBack
    Dim category As String
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub RdbuttonBugs_CheckedChanged(sender As Object, e As EventArgs) Handles RdbuttonBugs.CheckedChanged
        category = RdbuttonBugs.Text
    End Sub

    Private Sub RdbuttonComment_CheckedChanged(sender As Object, e As EventArgs) Handles RdbuttonComment.CheckedChanged
        category = RdbuttonComment.Text
    End Sub

    Private Sub RdbuttonOther_CheckedChanged(sender As Object, e As EventArgs) Handles RdbuttonOther.CheckedChanged
        category = RdbuttonOther.Text
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        If TxtboxFullname.Text = "" Or TxtBoxIssue.Text = "" Or String.IsNullOrEmpty(category) Then
            MsgBox("Field Tidak boleh kosong!")

        Else
            func_feedback(TxtboxFullname.Text, TxtBoxIssue.Text, category)
            TxtboxFullname.Text = ""
            TxtBoxIssue.Text = ""
            RdbuttonBugs.Checked = False
            RdbuttonComment.Checked = False
            RdbuttonOther.Checked = False
            MsgBox("Terima kasih atas FeedBacknya :)", vbInformation)
            Me.Dispose()
            Home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TxtboxFullname_TextChanged(sender As Object, e As EventArgs) Handles TxtboxFullname.TextChanged

    End Sub

    Private Sub FeedBack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtboxFullname.Text = EditProfile.TxtxboxFullname.Text
    End Sub
End Class