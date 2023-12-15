Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intSpeed = CInt(InputBox("Enter the speed in miles per hour."))
        Dim intHours = CInt(InputBox("Enter the number of hours."))
        Dim intTotal = 0

        lstOutput.Items.Add("Vehicle Speed: " & intSpeed & " MPH")
        lstOutput.Items.Add("Time Traveled: " & intHours & " MPH")
        lstOutput.Items.Add("Hours   Distance Traveled")
        lstOutput.Items.Add("------------------------------------")

        For intCount = 1 To intHours
            lstOutput.Items.Add(intCount & "     " & intSpeed * intCount)
            intTotal += intSpeed * intCount
        Next

        lstOutput.Items.Add("Total Distance: " & intTotal)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
