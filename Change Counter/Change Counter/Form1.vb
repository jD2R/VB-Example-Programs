Public Class Form1
    Dim decFIVE_CENTS_VALUE As Decimal = 0.05D
    Dim decTEN_CENTS_VALUE As Decimal = 0.1D
    Dim decTWENTY_FIVE_CENTS_VALUE As Decimal = 0.25D
    Dim decFIFTY_CENTS_VALUE As Decimal = 0.5D

    Dim decTotal As Decimal = 0.0D

    Private Sub picFiveCents_Click(sender As Object, e As EventArgs) Handles picFiveCents.Click
        decTotal += decFIVE_CENTS_VALUE
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub picTenCents_Click(sender As Object, e As EventArgs) Handles picTenCents.Click
        decTotal += decTEN_CENTS_VALUE
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub picTwentyFiveCents_Click(sender As Object, e As EventArgs) Handles picTwentyFiveCents.Click
        decTotal += decTWENTY_FIVE_CENTS_VALUE
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub picFiftyCents_Click(sender As Object, e As EventArgs) Handles picFiftyCents.Click
        decTotal += decFIFTY_CENTS_VALUE
        lblTotal.Text = decTotal.ToString("c")
    End Sub
End Class
