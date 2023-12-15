Public Class Form1
    Private lstNames As New List(Of String)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstNames.Add(txtName.Text)

        txtName.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim strName As String

        lstFriends.Items.Clear()

        For Each strName In lstNames
            lstFriends.Items.Add(strName)
        Next
    End Sub
End Class
