Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtWeekly.Text = String.Empty

        txtWeek1.Text = String.Empty
        txtWeek2.Text = String.Empty
        txtWeek3.Text = String.Empty
        txtWeek4.Text = String.Empty

        lblWeek1.Text = String.Empty
        lblWeek2.Text = String.Empty
        lblWeek3.Text = String.Empty
        lblWeek4.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decPerWeek As Decimal ' advertising cost per week

        ' number of clicks in each week
        Dim intWeek1 As Integer
        Dim intWeek2 As Integer
        Dim intWeek3 As Integer
        Dim intWeek4 As Integer

        If Decimal.TryParse(txtWeekly.Text, decPerWeek) Then
            decPerWeek = CDec(txtWeekly.Text)

            If Integer.TryParse(txtWeek1.Text, intWeek1) Then
                intWeek1 = CInt(txtWeek1.Text)
                lblWeek1.Text = (decPerWeek / intWeek1).ToString("F2")
            Else
                lblStatus.Text = "Click values must be valid integers."
            End If

            If Integer.TryParse(txtWeek2.Text, intWeek2) Then
                intWeek2 = CInt(txtWeek2.Text)
                lblWeek2.Text = (decPerWeek / intWeek2).ToString("F2")
            Else
                lblStatus.Text = "Click values must be valid integers."
            End If

            If Integer.TryParse(txtWeek3.Text, intWeek3) Then
                intWeek3 = CInt(txtWeek3.Text)
                lblWeek3.Text = (decPerWeek / intWeek3).ToString("F2")
            Else
                lblStatus.Text = "Click values must be valid integers."
            End If

            If Integer.TryParse(txtWeek4.Text, intWeek4) Then
                intWeek4 = CInt(txtWeek4.Text)
                lblWeek4.Text = (decPerWeek / intWeek4).ToString("F2")
            Else
                lblStatus.Text = "Click values must be valid integers."
            End If
        Else
            lblStatus.Text = "Advertising cost per week must be a valid decimal."
        End If
    End Sub
End Class
