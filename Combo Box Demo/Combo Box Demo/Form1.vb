Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lblCountry.Text = cboCountries.Text
        lblPlay.Text = cboPlays.Text
        lblArtist.Text = cboArtists.Text
    End Sub
End Class
