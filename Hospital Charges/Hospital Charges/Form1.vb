Public Class Form1

    Dim intLength As Integer
    Dim decMedication As Decimal
    Dim decSurgical As Decimal
    Dim decLab As Decimal
    Dim decRehab As Decimal

    Function ValidateInputFields() As Boolean
        If Not Integer.TryParse(txtLength.Text, intLength) Then
            lblOutput.Text = "Length of stay must be an integer."
            Return False
        End If

        If Not Decimal.TryParse(txtMedication.Text, decMedication) Then
            lblOutput.Text = "Medication cost must be a decimal."
            Return False
        End If

        If Not Decimal.TryParse(txtSurgical.Text, decSurgical) Then
            lblOutput.Text = "Surgical cost must be a decimal."
            Return False
        End If

        If Not Decimal.TryParse(txtLab.Text, decLab) Then
            lblOutput.Text = "Lab cost must be a decimal."
            Return False
        End If

        If Not Decimal.TryParse(txtRehab.Text, decRehab) Then
            lblOutput.Text = "Rehab cost must be a decimal."
            Return False
        End If

        Return True

    End Function

    Function CalcStayCharges() As Decimal
        Return intLength * 350D
    End Function

    Function CalcMiscCharges() As Decimal
        Dim decMisc As Decimal = 0D

        decMisc += decMedication
        decMisc += decSurgical
        decMisc += decLab
        decMisc += decRehab

        Return decMisc
    End Function

    Function CalcTotalCharges() As Decimal
        Return CalcStayCharges() + CalcMiscCharges()
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If ValidateInputFields() Then
            lblOutput.Text = "Total cost: " & CalcTotalCharges.ToString("c")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLength.Text = String.Empty
        txtMedication.Text = String.Empty
        txtSurgical.Text = String.Empty
        txtLab.Text = String.Empty
        txtRehab.Text = String.Empty

        lblOutput.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
