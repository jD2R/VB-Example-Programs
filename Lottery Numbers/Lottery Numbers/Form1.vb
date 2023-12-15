Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Const intMAX_SUBSCRIPT As Integer = 4
        Dim intLottery(intMAX_SUBSCRIPT) As Integer
        Dim intCount As Integer

        Dim rand As New Random

        For intCount = 0 To intMAX_SUBSCRIPT
            intLottery(intCount) = rand.Next(100)
        Next

        lblFirst.Text = intLottery(0).ToString()
        lblSecond.Text = intLottery(1).ToString()
        lblThird.Text = intLottery(2).ToString()
        lblFourth.Text = intLottery(3).ToString()
        lblFifth.Text = intLottery(4).ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
