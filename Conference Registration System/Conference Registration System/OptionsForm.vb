Public Class OptionsForm
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        chkConference.Checked = False
        chkOpening.Checked = False

        lstOptions.SelectedIndex = -1

        intConferenceCost = 0
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If chkConference.Checked Then
            intConferenceCost += 895

            If chkOpening.Checked Then
                intConferenceCost += 30
            End If

            Select Case lstOptions.SelectedIndex
                Case 0, 1
                    intConferenceCost += 295

                Case 2, 3
                    intConferenceCost += 395
            End Select

            Me.Close()
        Else
            If chkOpening.Checked Then
                MessageBox.Show("Cannot sign up for the keynote if conference is not selected.")
            ElseIf lstOptions.SelectedIndex <> -1 Then
                MessageBox.Show("Cannot sign up for preconference programs if conference is not selected.")
            End If
        End If
    End Sub
End Class