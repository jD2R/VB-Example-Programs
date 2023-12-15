Public Class Form1
    Const intMAX_SUBSCRIPT As Integer = 9
    Dim intArray(intMAX_SUBSCRIPT) As Integer

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim intCount As Integer

        MessageBox.Show("You will be asked to input 10 integers.")
        For intCount = 0 To intMAX_SUBSCRIPT
            intArray(intCount) = CInt(InputBox("Enter an integer."))
            lstOutput.Items.Add(intArray(intCount))
        Next
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intCount As Integer
        Dim intMin As Integer = intArray(0)
        Dim intMax As Integer = intArray(0)

        For intCount = 1 To intMAX_SUBSCRIPT
            If intArray(intCount) < intMin Then
                intMin = intArray(intCount)
            End If

            If intArray(intCount) > intMax Then
                intMax = intArray(intCount)
            End If
        Next

        lblOutput.Text = "The largest value is " & intMax & " and the smallest value is " & intMin & "."
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOutput.Items.Clear()
        lblOutput.Text = String.Empty
    End Sub
End Class
