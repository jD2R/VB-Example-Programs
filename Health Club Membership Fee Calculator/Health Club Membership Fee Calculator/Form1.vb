Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decBaseFee As Decimal
        Dim decTotalFee As Decimal
        Dim intMonths As Integer
        Dim blnInputOk As Boolean = True

        Const decADULT_FEE As Decimal = 40D
        Const decCHILD_FEE As Decimal = 20D
        Const decSTUDENT_FEE As Decimal = 25D
        Const decSENIOR_FEE As Decimal = 30D

        Const decYOGA_FEE As Decimal = 10D
        Const decKARATE_FEE As Decimal = 30D
        Const decTRAINER_FEE As Decimal = 50D

        lblStatus.Text = String.Empty

        If Integer.TryParse(txtMonths.Text, intMonths) = False Then
            lblStatus.Text = "Months must be an integer."
            blnInputOk = False
        End If

        If intMonths < 1 Or intMonths > 24 Then
            lblStatus.Text = "Months must be in the range 1 - 24."
            blnInputOk = False
        End If

        If blnInputOk = True Then
            If radAdult.Checked = True Then
                decBaseFee = decADULT_FEE
            ElseIf radChild.Checked = True Then
                decBaseFee = decCHILD_FEE
            ElseIf radStudent.Checked = True Then
                decBaseFee = decSTUDENT_FEE
            ElseIf radSenior.Checked = True Then
                decBaseFee = decSENIOR_FEE
            End If

            If chkYoga.Checked = True Then
                decBaseFee += decYOGA_FEE
            End If

            If chkKarate.Checked = True Then
                decBaseFee += decKARATE_FEE
            End If

            If chkTrainer.Checked = True Then
                decBaseFee += decTRAINER_FEE
            End If

            decTotalFee = decBaseFee * intMonths

            lblMonthlyFee.Text = decBaseFee.ToString("c")
            lblTotalFee.Text = decTotalFee.ToString("c")
        End If
    End Sub
End Class
