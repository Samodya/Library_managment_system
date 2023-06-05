Imports MySql.Data.MySqlClient
Public Class mngBooks
    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
        Main_menu.Show()
    End Sub

    Private Sub mngBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As MySqlConnection = GetConnection()
            Dim query As String = "SELECT `isbn_no`, `bookname`, `language`, `auther_name`, `publisher`, `catagory`, `pages`, `price`, `status`, `date` FROM `books`;"


            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()

                    ' Execute the query and retrieve the data using a DataReader
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        'dgvBookM.Columns.Clear()
                        dgvBookM.Rows.Clear()

                        While reader.Read()
                            ' Extract data from the DataReader
                            Dim isbn As Integer = reader.GetInt32("isbn_no")
                            Dim bname As String = reader.GetString("bookname")
                            Dim lang As String = reader.GetString("language")
                            Dim auth As String = reader.GetString("auther_name")
                            Dim publish As String = reader.GetString("publisher")
                            Dim catog As Integer = reader.GetInt32("catagory")
                            Dim pages As String = reader.GetInt32("pages")
                            Dim price As Decimal = reader.GetDecimal("price")
                            Dim stat As String = reader.GetString("status")
                            Dim regdate As String = reader.GetString("date")

                            ' Add a new row to the DataGridView and populate the cells
                            dgvBookM.Rows.Add(isbn, bname, lang, auth, publish, catog, pages, price, stat, regdate)

                        End While
                    End Using
                    connection.Close()
                Catch ex As Exception
                    ' Handle any exceptions that occur during the process
                    MessageBox.Show("Error: " & ex.Message)
                End Try

            End Using
        End Using
    End Sub

    Private Sub dgvBookM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookM.CellContentClick
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvBookM.Rows(e.RowIndex)

            ' Assign the cell values to TextBoxes
            txtISBN.Text = selectedRow.Cells("isbn").Value.ToString()
            txtBookname.Text = selectedRow.Cells("bookname").Value.ToString()
            txtAuth.Text = selectedRow.Cells("author").Value.ToString()
            txtLang.Text = selectedRow.Cells("language").Value.ToString()
            txtPublish.Text = selectedRow.Cells("publisher").Value.ToString()
            txtCat.Text = selectedRow.Cells("catogory").Value.ToString()
            txtPage.Text = selectedRow.Cells("pages").Value.ToString()
            txtPrice.Text = selectedRow.Cells("price").Value.ToString()
            txtStat.Text = selectedRow.Cells("Status").Value.ToString()
            'txtAuth.Text = selectedRow.Cells("author").Value.ToString()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newForm As New mngBooks()

        Dim isbn As String = txtISBN.Text
        Dim bname As String = txtBookname.Text
        Dim lang As String = txtLang.Text
        Dim auth As String = txtAuth.Text
        Dim publish As String = txtPublish.Text
        Dim catog As String = CInt(txtCat.Text)
        Dim pages As String = CInt(txtPage.Text)
        Dim price As String = CDec(txtPrice.Text)
        Dim stat As String = "Available"
        Dim Addate As String = dtpreg_date.Value

        Dim query As String = "INSERT INTO `books`(`isbn_no`, `bookname`, `language`, `auther_name`, `publisher`, `catagory`, `pages`, `price`, `status`, `date`) VALUES (@isbn,@bname,@lang,@author,@publish,@catog, @pages, @price,@stat,@regdate);"

        Using connection As MySqlConnection = GetConnection()
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@isbn", isbn)
                command.Parameters.AddWithValue("@bname", bname)
                command.Parameters.AddWithValue("@lang", lang)
                command.Parameters.AddWithValue("@author", auth)
                command.Parameters.AddWithValue("@publish", publish)
                command.Parameters.AddWithValue("@catog", catog)
                command.Parameters.AddWithValue("@pages", pages)
                command.Parameters.AddWithValue("@price", price)
                command.Parameters.AddWithValue("@stat", stat)
                command.Parameters.AddWithValue("@regdate", Addate)

                command.ExecuteNonQuery()

                MessageBox.Show("Book Adding successful!")
            End Using
            connection.Close()
        End Using
        newForm.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click




    End Sub

    Private Function GetConnection() As MySqlConnection
        Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=lms;"
        Return New MySqlConnection(connectionString)

    End Function

End Class