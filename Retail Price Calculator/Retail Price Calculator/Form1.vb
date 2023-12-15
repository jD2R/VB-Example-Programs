Public Class Form1
    Dim decWholesale As Decimal
    Dim decMarkup As Decimal

    Function CalculateRetail(ByVal decWholesale As Decimal,
                             ByVal decMarkup As Decimal) As Decimal
        Dim decRetail As Decimal

        decRetail = decWholesale + decWholesale * (decMarkup / 100)
        Return decRetail

    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Decimal.TryParse(txtWholesale.Text, decWholesale) Then
            If Decimal.TryParse(txtMarkup.Text, decMarkup) Then
                lblRetail.Text = CalculateRetail(decWholesale, decMarkup).ToString("c")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
