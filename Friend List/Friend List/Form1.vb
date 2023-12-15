Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const intMAX_SUBSCRIPT As Integer = 4
        Dim strNames(intMAX_SUBSCRIPT) As String
        Dim intCount As Integer

        MessageBox.Show("I'm going to ask you to enter the names of five friends")

        For intCount = 0 To intMAX_SUBSCRIPT
            strNames(intCount) = InputBox("Enter a friend's name.")
        Next

        lstFriends.Items.Clear()

        For intCount = 0 To intMAX_SUBSCRIPT
            lstFriends.Items.Add(strNames(intCount))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
