Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim strInput As String

        If FirstMonths.SelectedIndex = -1 Then
            MessageBox.Show("Select a month.")
        ElseIf FirstYears.SelectedIndex = -1 Then
            MessageBox.Show("Select a year.")
        Else
            strInput = FirstMonths.SelectedItem.ToString() &
                " " & FirstYears.SelectedItem.ToString()
            MessageBox.Show("You selected " & strInput)
        End If
    End Sub
End Class
