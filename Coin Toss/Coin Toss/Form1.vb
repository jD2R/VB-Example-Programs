Public Class Form1
    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intSideUp As Integer
        Dim rand As New Random

        intSideUp = rand.Next(2)

        If intSideUp = 0 Then
            picTails.Visible = True
            picHeads.Visible = False
        Else
            picTails.Visible = False
            picHeads.Visible = True
        End If
    End Sub
End Class
