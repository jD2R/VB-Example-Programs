Public Class PrintBooks
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        strBookTitle = String.Empty
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lstOptions.SelectedIndex <> -1 Then
            strBookTitle = lstOptions.SelectedItem.ToString()
            Me.Close()
        Else
            MessageBox.Show("Choose an item.")
        End If
    End Sub
End Class