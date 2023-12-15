Public Class Form1
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuMembershipAll_Click(sender As Object, e As EventArgs) Handles mnuMembershipAll.Click
        Dim frmAllMembers As New AllMembersForm
        frmAllMembers.ShowDialog()
    End Sub

    Private Sub mnuMembershipAdd_Click(sender As Object, e As EventArgs) Handles mnuMembershipAdd.Click
        Dim frmAddMember As New AddMemberForm
        frmAddMember.ShowDialog()
    End Sub

    Private Sub mnuMembershipFind_Click(sender As Object, e As EventArgs) Handles mnuMembershipFind.Click
        Dim frmFindMember As New FindMemberForm
        frmFindMember.ShowDialog()
    End Sub

    Private Sub mnuPaymentsAll_Click(sender As Object, e As EventArgs) Handles mnuPaymentsAll.Click
        Dim frmPaymentsAll As New AllPaymentsForm
        frmPaymentsAll.ShowDialog()
    End Sub
End Class
