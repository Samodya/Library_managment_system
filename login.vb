Imports MySql.Data.MySqlClient
Public Class login

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim username As String = txtun.Text
        Dim password As String = txtpw.Text

        Dim query As String = "SELECT COUNT(*) FROM user WHERE name = @username AND pass = @password;"

        Using connection As MySqlConnection = GetConnection()
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                If result > 0 Then
                    MessageBox.Show("Login successful!")
                    Main_menu.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password.")
                End If
            End Using
        End Using
    End Sub

    Private Function GetConnection() As MySqlConnection
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=lms;"
        Return New MySqlConnection(connectionString)
    End Function
End Class