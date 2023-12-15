Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        dblBill = CDbl(txtBillAmount.Text)

        dblTip = dblBill * 0.15

        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        dblBill = CDbl(txtBillAmount.Text)

        dblTip = dblBill * 0.2

        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        dblBill = CDbl(txtBillAmount.Text)

        dblTip = dblBill * 0.25

        lblTip.Text = CStr(dblTip)
    End Sub
End Class
