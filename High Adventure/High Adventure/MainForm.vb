Public Class Form1
    Private Sub mnuPackagesScuba_Click(sender As Object, e As EventArgs) Handles mnuPackagesScuba.Click
        Dim frmScuba As New ScubaForm
        frmScuba.ShowDialog()
    End Sub

    Private Sub mnuPackagesSkyDiving_Click(sender As Object, e As EventArgs) Handles mnuPackagesSkyDiving.Click
        Dim frmSkyDive As New SkyDiveForm
        frmSkyDive.ShowDialog()
    End Sub
End Class
