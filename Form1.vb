Public Class Form1
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        MessageBox.Show("Connection Successful")
        con.Close()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        openCon()
        Dim username As String = usernameBox.Text
        Dim password As String = passwordBox.Text
        Dim query As String = "SELECT COUNT(*) FROM accounts WHERE username='" & username & "' AND password='" & password & "'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(query, con)
        Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        con.Close()
        If result > 0 Then
            dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password")
        End If
    End Sub
End Class
