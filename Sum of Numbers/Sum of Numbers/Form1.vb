Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strInput = InputBox("Enter a positive integer to be used as the maximum value.")
        Dim intInput = CInt(strInput)
        Dim intCount = 1
        Dim intTotal = 0

        If intInput <= 0 Then
            MessageBox.Show("Enter a positive integer.")
        Else
            For intCount = 1 To intInput
                intTotal += intCount
            Next

            MessageBox.Show("The sum of numbers 1 through " & intInput & " is " &
                            intTotal)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
