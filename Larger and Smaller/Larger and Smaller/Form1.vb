Public Class Form1
    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim valueA As Integer
        Dim valueB As Integer

        If Integer.TryParse(txtA.Text, valueA) Then
            If Integer.TryParse(txtB.Text, valueB) Then
                valueA = CInt(txtA.Text)
                valueB = CInt(txtB.Text)

                If valueA > valueB Then
                    lblOutput.Text = "Value A is greatest."
                ElseIf valueA < valueB Then
                    lblOutput.Text = "Value B is greatest."
                Else
                    lblOutput.Text = "The two values are equal."
                End If
            Else
                lblOutput.Text = "Input a valid integer for the second value."
            End If
        Else
            lblOutput.Text = "Input a valid integer for the first value."
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
