Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim dblClassA As Double
            Dim dblClassB As Double
            Dim dblClassC As Double
            Dim dblTotal As Double

            dblClassA = CDbl(txtClassA.Text) * 15
            dblClassB = CDbl(txtClassB.Text) * 12
            dblClassC = CDbl(txtClassC.Text) * 9

            dblTotal += dblClassA
            dblTotal += dblClassB
            dblTotal += dblClassC

            lblClassA.Text = dblClassA.ToString("c")
            lblClassB.Text = dblClassB.ToString("c")
            lblClassC.Text = dblClassC.ToString("c")
            lblTotalRevenue.Text = dblTotal.ToString("c")
        Catch
            MessageBox.Show("All inputs must be numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Text = String.Empty
        txtClassB.Text = String.Empty
        txtClassC.Text = String.Empty

        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblTotalRevenue.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
