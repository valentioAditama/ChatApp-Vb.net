Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Imports MySql.Data.MySqlClient

Public Class Home

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "QGBLSJU7JxQq6Ain8zbMwdbDhbMI7LaQr42yjQH0",
        .BasePath = "https://chatapp-vbnet-default-rtdb.firebaseio.com/"
        }

    Private client As IFirebaseClient
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("Ada kendala pada Koneksi atau jaringan")
        End Try
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

    Private Sub BtnSendMessage_Click(sender As Object, e As EventArgs) Handles BtnSendMessage.Click

        If TxtboxMessage.Text = "" Then
            MsgBox("Field text tidak boleh Kosong")
        Else
            Dim room As String = "1"
            Dim time As Date
            func_SendMessage(room, Label1.Text, TxtboxMessage.Text, time)
            TxtboxMessage.Text = ""
        End If
    End Sub

    Private Async Sub Livecall()
        While True
            Await Task.Delay(600)
            Dim res As FirebaseResponse = Await client.GetAsync("Messages/1")
            Dim data As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(res.Body.ToString())
            UpdateRTB(data)
        End While
    End Sub

    Private Sub UpdateRTB(ByVal records As Dictionary(Of String, String))
        TxtboxIsiMessage.Text = ""
        TxtboxIsiMessage.Text += records.ElementAt(1).Value & ": " + records.ElementAt(0).Value & vbLf
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Theme.Show()
        Me.Hide()
    End Sub
End Class