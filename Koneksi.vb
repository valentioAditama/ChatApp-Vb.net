Imports MySql.Data.MySqlClient
Module Koneksi
    Sub koneksi()
        Dim connection As MySqlConnection
        connection = New MySqlConnection()
        connection.ConnectionString = "server=localhost;user id=root; password=;database=chatapp;"
        Try
            connection.Open()
            connection.Close()
        Catch sqlerror As MySqlException
            MessageBox.Show("Database gagal di sambungkan" & sqlerror.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
End Module
