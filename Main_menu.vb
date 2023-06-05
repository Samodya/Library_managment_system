Public Class Main_menu
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnAddmember_Click(sender As Object, e As EventArgs) Handles btnAddmember.Click
        mngBooks.Show()
        Me.Close()
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        mngBooks.Show()
        Me.Close()
    End Sub

End Class