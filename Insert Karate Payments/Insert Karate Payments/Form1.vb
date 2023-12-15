Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PaymentsDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.PaymentsDataSet.Payments)

        txtDate.Text = Today().ToString("d")

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Me.PaymentsTableAdapter.Insert(CShort(txtMemberId.Text), CDate(txtDate.Text), CDec(txtAmount.Text))
            Me.PaymentsTableAdapter.Fill(PaymentsDataSet.Payments)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Input Error")
        End Try
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim decTotal As Decimal = 0
        Dim row As PaymentsDataSet.PaymentsRow

        For Each row In Me.PaymentsDataSet.Payments.Rows
            decTotal += row.Amount

        Next

        MessageBox.Show("Total payments are equal to " & decTotal.ToString("c"), "Total")
    End Sub
End Class
