Public Class dashboard
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        Dim query As String = "SELECT * FROM rooms"
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DashDataGrid.DataSource = table
        con.Close()
    End Sub
    Private Sub ShowOnly(targetPanel As Panel)
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        targetPanel.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowOnly(Panel2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowOnly(Panel3)
        RoomDataGrid.DataSource = LoadRooms()
    End Sub

    Public Sub ReloadRooms()
        RoomDataGrid.DataSource = LoadRooms()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowOnly(Panel4)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ShowOnly(Panel5)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        addRoom.Show()
    End Sub
End Class