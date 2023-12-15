Public Class MainForm
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim frmNutrition As New NutritionForm

        If radBanana.Checked = True Then
            frmNutrition.lblFood.Text = "1 banana"
            frmNutrition.lblCalories.Text = "100"
            frmNutrition.lblFat.Text = "0.4"
            frmNutrition.lblCarb.Text = "27"
        ElseIf radPopcorn.Checked = True Then
            frmNutrition.lblFood.Text = "1 cup air popped popcorn"
            frmNutrition.lblCalories.Text = "31"
            frmNutrition.lblFat.Text = "0.4"
            frmNutrition.lblCarb.Text = "6"
        ElseIf radMuffin.Checked = True Then
            frmNutrition.lblFood.Text = "1 blueberry muffin"
            frmNutrition.lblCalories.Text = "385"
            frmNutrition.lblFat.Text = "9"
            frmNutrition.lblCarb.Text = "67"
        End If

        frmNutrition.ShowDialog()
    End Sub
End Class
