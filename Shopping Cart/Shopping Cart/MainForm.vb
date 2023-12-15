Public Class Form1
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuProductsPrint_Click(sender As Object, e As EventArgs) Handles mnuProductsPrint.Click
        Dim frmPrintBooks As New PrintBooks
        frmPrintBooks.ShowDialog()

        If strBookTitle <> String.Empty Then
            lstOutput.Items.Add(strBookTitle)
        End If
        UpdatePrices()
    End Sub

    Private Sub mnuProductsAudio_Click(sender As Object, e As EventArgs) Handles mnuProductsAudio.Click
        Dim frmAudioBooks As New AudioBooks
        frmAudioBooks.ShowDialog()

        If strBookTitle <> String.Empty Then
            lstOutput.Items.Add(strBookTitle)
        End If
        UpdatePrices()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstOutput.Items.Count > 0 Then
            lstOutput.Items.Remove(lstOutput.SelectedItem)
            UpdatePrices()
        Else
            MessageBox.Show("Nothing to remove.")
        End If
    End Sub

    Private Sub UpdatePrices()
        Dim decSubtotal As Decimal = 0D
        Dim decShipping As Decimal = 0D
        Dim decTax As Decimal = 0D
        Dim decTotal As Decimal = 0D

        If lstOutput.Items.Count > 0 Then
            For intCount As Integer = 0 To lstOutput.Items.Count - 1
                decSubtotal += GetPrice(lstOutput.Items.Item(intCount).ToString())
                decShipping += 2D
            Next
        End If

        decTax = decSubtotal * TAX_RATE
        decTotal = decSubtotal + decTax + decShipping

        lblSubtotal.Text = decSubtotal.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblShipping.Text = decShipping.ToString("c")
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        lstOutput.Items.Clear()

        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
