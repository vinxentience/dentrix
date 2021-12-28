Imports MySql.Data.MySqlClient
Module Connection
    Public conn As New MySqlConnection
    Public comm As New MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Sub connect()
        With conn
            .ConnectionString = "server=localhost;userid=root;password=1234;database=dentrix"
        End With
    End Sub
End Module
