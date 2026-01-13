Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    Sub openCon()
        con.ConnectionString = "server=localhost;userid=root;password=;database=sugodhotel"
        con.Open()
    End Sub
    Public Function LoadRooms() As DataTable
        openCon()
        Dim query As String = "SELECT * FROM rooms"
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim table As New DataTable()
        adapter.Fill(table)
        con.Close()
        Return table
    End Function
End Module

