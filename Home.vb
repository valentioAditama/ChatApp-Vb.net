Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json
Imports MySql.Data.MySqlClient
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
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readData = "conneced to Chat server"
        msg()
        clientSocket.Connect("127.0.0.1", 8888)
        serverStream = clientSocket.GetStream

        Dim outstream As Byte() = System.Text.Encoding.ASCII.GetBytes(TxtboxMessage.Text + "$")
        serverStream.Write(outstream, 0, outstream.Length)
        serverStream.Flush()

        Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        ctThread.Start()
    End Sub

    Private Sub getMessage()
        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            serverStream = clientSocket.GetStream

            Dim buffsize As Integer
            Dim instream(10024) As Byte
            buffsize = clientSocket.ReceiveBufferSize
            serverStream.Read(instream, 0, buffsize)

            Dim returndata As String = System.Text.Encoding.ASCII.GetString(instream)
            readData = "" + returndata
            msg()
        Next
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
            Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(TxtboxIsiMessage.Text + "$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
            Dim connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
            connection.Open()

            Dim room As String = "1"
            Dim time As Date

            func_SendMessage(room, Label1.Text, TxtboxMessage.Text, time)

            Dim cmd As New MySqlCommand("SELECT * FROM chat WHERE room = @1 ORDER BY id DESC LIMIT 1", connection)

            cmd.Parameters.AddWithValue("@1", room)

            Dim myReader As MySqlDataReader = cmd.ExecuteReader()

            While myReader.Read
                TxtboxIsiMessage.Text += myReader.GetValue(3).ToString() + vbNewLine
            End While

            TxtboxMessage.Text = ""

            TxtboxIsiMessage.Refresh()

            connection.Close()

            Livecall()
        End If
    End Sub

    Private Sub msg()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf msg))
        Else
            TxtboxIsiMessage.Text = TxtboxIsiMessage + Environment.NewLine + " >>" + readData
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
End Class