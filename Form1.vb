Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=lms")
    Dim i As Integer

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Dim username As String = txtun.Text
        Dim password As String = txtpw.Text

        Dim query As String = "INSERT INTO `user`( `name`, `pass`) VALUES (@username, @password);"

        Using connection As MySqlConnection = GetConnection()
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                command.ExecuteNonQuery()

                MessageBox.Show("Sign-in successful!")
            End Using
        End Using
        login.Show()
    End Sub

    Private Function GetConnection() As MySqlConnection
        Dim connectionString As String = "Server=localhost;Database=lms;Uid=root;Pwd=;"
        Return New MySqlConnection(connectionString)
    End Function


End Class
