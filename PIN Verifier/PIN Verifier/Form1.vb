Public Class Form1
    Const intUPPER_SUBSCRIPT As Integer = 6
    Dim intMin() As Integer = {7, 5, 0, 0, 6, 3, 4}
    Dim intMax() As Integer = {9, 7, 4, 9, 9, 6, 8}

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt1.Text = String.Empty
        txt2.Text = String.Empty
        txt3.Text = String.Empty
        txt4.Text = String.Empty
        txt5.Text = String.Empty
        txt6.Text = String.Empty
        txt7.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim blnValid As Boolean = True
        Dim strTxt() As String = {txt1.Text, txt2.Text, txt3.Text, txt4.Text,
                                  txt5.Text, txt6.Text, txt7.Text}
        Dim intCount As Integer
        Dim intItem As Integer

        Try
            For intCount = 0 To intUPPER_SUBSCRIPT
                intItem = CInt(strTxt(intCount))
                If intItem > intMax(intCount) Or intItem < intMin(intCount) Then
                    blnValid = False
                End If
            Next

            If blnValid Then
                MessageBox.Show("PIN accepted!")
            Else
                MessageBox.Show("PIN denied!")
            End If
        Catch ex As Exception
            MessageBox.Show("All inputs must be integers.")
        End Try
    End Sub
End Class
