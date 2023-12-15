Public Class Form1
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        txtCompany.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtState.Clear()
        txtZip.Clear()

        lblOutput.Text = String.Empty

        intConferenceCost = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim frmOptions As New OptionsForm
        frmOptions.ShowDialog()
        lblOutput.Text = intConferenceCost.ToString("c")
    End Sub
End Class
