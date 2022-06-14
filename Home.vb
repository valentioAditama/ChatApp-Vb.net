Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Home

    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim readData As String
    Dim infiniteCounter As Integer


    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "QGBLSJU7JxQq6Ain8zbMwdbDhbMI7LaQr42yjQH0",
        .BasePath = "https://chatapp-vbnet-default-rtdb.firebaseio.com/"
        }

    Private client As IFirebaseClient

    Dim _client As TcpClient
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ip As String = "127.0.0.1"
            Dim port As Integer = 1234

            _client = New TcpClient(ip, port)

            CheckForIllegalCrossThreadCalls = False

            Threading.ThreadPool.QueueUserWorkItem(AddressOf ReceiveMessage)

            AcceptButton = BtnSendMessage
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReceiveMessage(state As Object)
        Try
            While True
                Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
                connection.Open()

                Dim room As String = "1"
                Dim time As Date

                Dim cmd As New MySqlCommand("SELECT * FROM chat WHERE room = @1 ORDER BY id DESC LIMIT 1", connection)

                cmd.Parameters.AddWithValue("@1", room)

                Dim myReader As MySqlDataReader = cmd.ExecuteReader()
                Dim ns As NetworkStream = _client.GetStream()

                Dim toReceive(100000) As Byte
                ns.Read(toReceive, 0, toReceive.Length)
                Dim txt As String = Encoding.ASCII.GetString(toReceive)
                If TxtboxIsiMessage.TextLength > 0 Then
                    While myReader.Read
                        TxtboxIsiMessage.Text &= myReader.GetValue(2) + ": " + txt & vbNewLine + vbNewLine
                    End While
                Else
                    TxtboxIsiMessage.Text = txt
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
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

        Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
        connection.Open()

        Dim cmd As New MySqlCommand("SELECT * from `users` where username = @1 and password =@2 ", connection)

        Dim username As String = EditProfile.TxtxboxUsername.Text
        Dim password As String = EditProfile.TxtxboxPassword.Text

        With cmd
            .Parameters.AddWithValue("@1", username)
            .Parameters.AddWithValue("@2", password)
        End With

        Dim myreader As MySqlDataReader
        myreader = cmd.ExecuteReader()

        myreader.Read()

        EditProfile.txtboxId.Text = myreader("id")
        EditProfile.TxtxboxEmail.Text = myreader("email")
        EditProfile.TxtxboxFullname.Text = myreader("fullname")
    End Sub

    Private Sub BtnSendMessage_Click(sender As Object, e As EventArgs) Handles BtnSendMessage.Click
        If TxtboxMessage.Text = "" Then
            MsgBox("Field text tidak boleh Kosong")
        Else
            Try
                Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
                connection.Open()

                Dim room As String = "1"

                func_SendMessage(room, Label1.Text, TxtboxMessage.Text)

                Dim ns As NetworkStream = _client.GetStream()

                ns.Write(Encoding.ASCII.GetBytes(TxtboxMessage.Text), 0, TxtboxMessage.Text.Length)
                'TxtboxIsiMessage.Text += TxtboxMessage.Text + vbNewLine
                TxtboxMessage.Text = "" + vbNewLine

                Dim cmd As New MySqlCommand("SELECT * FROM chat WHERE room = @1 ORDER BY id DESC LIMIT 1", connection)

                cmd.Parameters.AddWithValue("@1", room)

                Dim myReader As MySqlDataReader = cmd.ExecuteReader()

                While myReader.Read
                    TxtboxIsiMessage.Text += myReader.GetValue(2) + ": " + myReader.GetValue(3).ToString() + vbNewLine + vbNewLine
                End While

                TxtboxMessage.Text = ""

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Async Sub Livecall()
        While True
            Await Task.Delay(600)
            'TxtboxIsiMessage.Text = ""
            ' Dim res As FirebaseResponse = Await client.GetAsync("Messages/1")
            ' Dim data As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(res.Body.ToString())
            ' UpdateRTB(data)
        End While
    End Sub

    Private Sub UpdateRTB(ByVal records As Dictionary(Of String, String))
        'TxtboxIsiMessage.Text = ""
        'TxtboxIsiMessage.Text += records.ElementAt(1).Value & ": " + records.ElementAt(0).Value & vbLf
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Theme.Show()
        Me.Hide()
    End Sub

    Private Sub TxtboxIsiMessage_TextChanged(sender As Object, e As EventArgs) Handles TxtboxIsiMessage.TextChanged

    End Sub

    Private Sub TxtboxMessage_TextChanged(sender As Object, e As EventArgs) Handles TxtboxMessage.TextChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
        connection.Open()

        Dim cmd As New MySqlCommand("SELECT * from `users` where username = @1 and password =@2 ", connection)

        Dim username As String = EditProfile.TxtxboxUsername.Text
        Dim password As String = EditProfile.TxtxboxPassword.Text

        With cmd
            .Parameters.AddWithValue("@1", username)
            .Parameters.AddWithValue("@2", password)
        End With

        Dim myreader As MySqlDataReader
        myreader = cmd.ExecuteReader()

        myreader.Read()

        EditProfile.txtboxId.Text = myreader("id")
        EditProfile.TxtxboxEmail.Text = myreader("email")
        EditProfile.TxtxboxFullname.Text = myreader("fullname")
    End Sub
End Class