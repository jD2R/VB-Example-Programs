Public Class Form1

    Const intMAX_SUBSCRIPT As Integer = 4
    Dim strProdNames(intMAX_SUBSCRIPT) As String
    Dim strDesc(intMAX_SUBSCRIPT) As String
    Dim intProdNums(intMAX_SUBSCRIPT) As Integer
    Dim decPrices(intMAX_SUBSCRIPT) As Decimal
    Dim intUnitsSold(intMAX_SUBSCRIPT) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitArrays()
    End Sub

    Private Sub InitArrays()
        strProdNames(0) = "Six Steps to Leadership"
        strDesc(0) = "Book"
        intProdNums(0) = 914
        decPrices(0) = 12.95D

        strProdNames(1) = "Six Steps to Leadership"
        strDesc(1) = "MP3"
        intProdNums(1) = 915
        decPrices(1) = 14.95D

        strProdNames(2) = "The Road to Excellence"
        strDesc(2) = "Video"
        intProdNums(2) = 916
        decPrices(2) = 18.95D

        strProdNames(3) = "Seven Lessons of Quality"
        strDesc(3) = "Book"
        intProdNums(3) = 917
        decPrices(3) = 16.95D

        strProdNames(4) = "Seven Lessons of Quality"
        strDesc(4) = "MP3"
        intProdNums(4) = 918
        decPrices(4) = 21.95D
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EnterSalesDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterSalesDataToolStripMenuItem.Click
        Dim intCount As Integer = 0

        Do While intCount <= intMAX_SUBSCRIPT
            Try
                intUnitsSold(intCount) = CInt(
                    InputBox("Enter units sold of product number " & intProdNums(intCount)))

                intCount += 1
            Catch
                MessageBox.Show("Enter a valid integer.")
            End Try
        Loop
    End Sub

    Private Sub DisplaySalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplaySalesReportToolStripMenuItem.Click
        Dim intCount As Integer
        Dim decRevenue As Decimal
        Dim decTotalRevenue As Decimal

        lstSalesData.Items.Add("SALES REPORT")
        lstSalesData.Items.Add("----------------------")

        For intCount = 0 To intMAX_SUBSCRIPT
            decRevenue = intUnitsSold(intCount) * decPrices(intCount)

            lstSalesData.Items.Add("Product Number: " & intProdNums(intCount).ToString())
            lstSalesData.Items.Add("Name: " & strProdNames(intCount))
            lstSalesData.Items.Add("Description: " & strDesc(intCount))
            lstSalesData.Items.Add("Unit Price: " & decPrices(intCount).ToString("c"))
            lstSalesData.Items.Add("Units Sold: " & intUnitsSold(intCount).ToString())
            lstSalesData.Items.Add("Product Revenue: " & decRevenue.ToString("c"))
            lstSalesData.Items.Add("")

            decTotalRevenue = decTotalRevenue + decRevenue
        Next

        lblTotalRevenue.Text = decTotalRevenue.ToString("c")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Displays a sales report for DLC.", "About")
    End Sub
End Class
