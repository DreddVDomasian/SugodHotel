Public Class addRoom
    Public Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Public Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Public Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Public Sub addRoomBtn_Click(sender As Object, e As EventArgs) Handles addRoomBtn.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO rooms (roomNumber, room_type, 3hrs_rate, 6hrs_rate, 12hrs_rate, overnight_rate, status) VALUES ('" & roomNumBox.Text & "','" & roomTypeComboBox.Text & "','" & rate3hrsBox.Text & "','" & rate6hrsBox.Text & "','" & rate12hrsBox.Text & "','" & rate1dayBox.Text & "','" & roomStatusBox.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Room Added Successfully")
            con.Close()

            roomNumBox.Clear()
            roomTypeComboBox.SelectedIndex = -1
            rate3hrsBox.Clear()
            rate6hrsBox.Clear()
            rate12hrsBox.Clear()
            rate1dayBox.Clear()
            roomStatusBox.SelectedIndex = -1
            dashboard.ReloadRooms()
        Catch ex As Exception
            MessageBox.Show("Error adding room: " & ex.Message)
        End Try

    End Sub

End Class