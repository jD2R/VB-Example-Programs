Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        Try
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            decAddCharges = CDec(txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")

            lblTotal.BackColor = Color.Blue
            lblTotal.ForeColor = Color.White
        Catch
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub
End Class
