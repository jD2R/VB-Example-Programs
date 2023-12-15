Public Class Form1
    Private Sub leftButton_Click(sender As Object, e As EventArgs) Handles leftButton.Click
        labelOutput.Text = "Left"
    End Sub

    Private Sub middleButton_Click(sender As Object, e As EventArgs) Handles middleButton.Click
        labelOutput.Text = "Middle"
    End Sub

    Private Sub rightButton_Click(sender As Object, e As EventArgs) Handles rightButton.Click
        labelOutput.Text = "Right"
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
