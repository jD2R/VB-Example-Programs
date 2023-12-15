Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim dblGallons As Double
            Dim dblMileage As Double
            Dim dblMPG As Double

            dblGallons = CDbl(txtGallons.Text)
            dblMileage = CDbl(txtMileage.Text)

            dblMPG = dblMileage / dblGallons
            lblMPG.Text = dblMPG.ToString()
        Catch
            MessageBox.Show("All inputs must be numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Text = String.Empty
        txtMileage.Text = String.Empty
        lblMPG.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
