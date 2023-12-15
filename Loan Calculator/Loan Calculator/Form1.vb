Public Class Form1
    Const dblMONTHS_YEAR As Double = 12
    Const dblNEW_RATE As Double = 0.05
    Const dblUSED_RATE As Double = 0.08

    Dim dblAnnualRate As Double = dblNEW_RATE

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblVehicleCost As Double
        Dim dblDownPayment As Double
        Dim intMonths As Integer
        Dim dblLoan As Double
        Dim dblMonthlyPayment As Double
        Dim dblInterest As Double
        Dim dblPrincipal As Double
        Dim intCount As Integer
        Dim strOut As String
        Dim blnInputOk As Boolean = True

        If Not Double.TryParse(txtCost.Text, dblVehicleCost) Then
            lblMessage.Text = "Vehicle cost must be a number."
            blnInputOk = False
        End If

        If Not Double.TryParse(txtDownPayment.Text, dblDownPayment) Then
            lblMessage.Text = "Down payment must be a number."
            blnInputOk = False
        End If

        If Not Integer.TryParse(txtMonths.Text, intMonths) Then
            lblMessage.Text = "Months must be a number."
            blnInputOk = False
        End If


        If blnInputOk = True Then
            dblLoan = dblVehicleCost - dblDownPayment
            dblMonthlyPayment = Pmt(dblAnnualRate / dblMONTHS_YEAR, intMonths, -dblLoan)
            lstOutput.Items.Clear()
            lblMessage.Text = String.Empty

            For intCount = 1 To intMonths
                dblInterest = IPmt(dblAnnualRate / dblMONTHS_YEAR, intCount, intMonths, -dblLoan)

                dblPrincipal = PPmt(dblAnnualRate / dblMONTHS_YEAR, intCount, intMonths, -dblLoan)

                strOut = "Month " & intCount.ToString("d2")
                strOut &= ": payment = " & dblMonthlyPayment.ToString("n2")
                strOut &= ", interest = " & dblInterest.ToString("n2")
                strOut &= ", principal = " & dblPrincipal.ToString("n2")

                lstOutput.Items.Add(strOut)
            Next
        End If
    End Sub

    Private Sub radNew_CheckedChanged(sender As Object, e As EventArgs) Handles radNew.CheckedChanged
        If radNew.Checked = True Then
            dblAnnualRate = dblNEW_RATE
            lblAnnualRate.Text = dblNEW_RATE.ToString("p")
            lstOutput.Items.Clear()
        End If
    End Sub

    Private Sub radUsed_CheckedChanged(sender As Object, e As EventArgs) Handles radUsed.CheckedChanged
        If radUsed.Checked = True Then
            dblAnnualRate = dblUSED_RATE
            lblAnnualRate.Text = dblUSED_RATE.ToString("p")
            lstOutput.Items.Clear()
        End If
    End Sub
End Class
