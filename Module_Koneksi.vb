Imports MySql.Data.MySqlClient
Module Module_Koneksi
    Public connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=chatapp")
    Public Sub connect()
        If connection.State = ConnectionState.Open Then
            connection.Close()
            connection.Open()
        Else
            connection.Open()
        End If
    End Sub

    Public Function func_showMessage(room As String, username As String, message As String)
        connect()
        Dim cmd As New MySqlCommand("SELECT * FROM `chat` WHERE room = @1 ORDER BY id DESC LIMIT 1", connection)
        With cmd
            .Parameters.AddWithValue("@1", room)
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            Dim result = Home.TxtboxIsiMessage.DataBindings.Add("chat", dt, "room")
        End With
    End Function

    Public Function func_ShowProfile(username As String, password As String)
        connect()
        Dim cmd As New MySqlCommand("SELECT * from `users` where username = @1 and password = @2 ", connection)
        With cmd
            .Parameters.AddWithValue("@1", username)
            .Parameters.AddWithValue("@2", password)
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        End With
        Return True
    End Function

    Public Function func_login(username As String, password As String)
        connect()
        Dim cmd As New MySqlCommand("SELECT * from `users` where username = @1 and password = @2", connection)
        With cmd
            .Parameters.AddWithValue("@1", username)
            .Parameters.AddWithValue("@2", password)
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        End With
        Return True
    End Function

    Public Function func_register(fullname As String, email As String, username As String, password As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO `users`(`fullname`, `email`, `username`, `password`) VALUES (@1, @2, @3, @4)", connection)
        With cmd
            .Parameters.AddWithValue("@1", fullname)
            .Parameters.AddWithValue("@2", email)
            .Parameters.AddWithValue("@3", username)
            .Parameters.AddWithValue("@4", password)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

    Public Function func_feedback(fullname As String, describe As String, category As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO `feedback`(`fullname`, `describe`, `category`) VALUES (@1, @2, @3)", connection)
        With cmd
            .Parameters.AddWithValue("@1", fullname)
            .Parameters.AddWithValue("@2", describe)
            .Parameters.AddWithValue("@3", category)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

    Public Function func_EditProfile(fullname As String, email As String, username As String, password As String)
        connect()
        Dim cmd As New MySqlCommand("UPDATE `users` SET `id`='@1',`fullname`='@2',`email`='@3',`username`='@4',`password`='@5',`Bio`='@6' ", connection)
        With cmd
            .Parameters.AddWithValue("@1", fullname)
            .Parameters.AddWithValue("@2", email)
            .Parameters.AddWithValue("@3", username)
            .Parameters.AddWithValue("@4", password)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

    Public Function func_SendMessage(room As String, username As String, message As String, created_at As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO `chat`(`room`, `username`, `message`, `created_at`) VALUES (@1, @2, @3, @4)", connection)
        With cmd
            .Parameters.AddWithValue("@1", room)
            .Parameters.AddWithValue("@2", username)
            .Parameters.AddWithValue("@3", message)
            .Parameters.AddWithValue("@4", created_at)
            .ExecuteNonQuery()
        End With
        Return True
    End Function
End Module
