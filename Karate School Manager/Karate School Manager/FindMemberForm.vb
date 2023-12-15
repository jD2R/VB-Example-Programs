Public Class FindMemberForm
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.MembersTableAdapter.Fill(Me.FindMemberDataSet.Members, txtLastName.Text)
    End Sub
End Class