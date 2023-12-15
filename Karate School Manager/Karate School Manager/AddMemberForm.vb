﻿Public Class AddMemberForm

    Private Sub AddMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MembersBindingSource.AddNew()
        Date_JoinedDateTimePicker.Value = Today()

    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Try
            Me.MembersBindingSource.EndEdit()
            Me.MembersTableAdapter.Update(AllMembersDataSet.Members)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.MembersBindingSource.CancelEdit()
        Me.Close()
    End Sub
End Class