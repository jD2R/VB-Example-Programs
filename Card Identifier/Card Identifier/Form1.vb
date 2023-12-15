Public Class Form1
    Private Sub card1_Click(sender As Object, e As EventArgs) Handles card1.Click
        labelOutput.Text = "Eight of Diamonds"
    End Sub

    Private Sub card2_Click(sender As Object, e As EventArgs) Handles card2.Click
        labelOutput.Text = "Two of Clubs"
    End Sub

    Private Sub card3_Click(sender As Object, e As EventArgs) Handles card3.Click
        labelOutput.Text = "King of Spades"
    End Sub

    Private Sub card4_Click(sender As Object, e As EventArgs) Handles card4.Click
        labelOutput.Text = "Ace of Spades"
    End Sub

    Private Sub card5_Click(sender As Object, e As EventArgs) Handles card5.Click
        labelOutput.Text = "Joker"
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
