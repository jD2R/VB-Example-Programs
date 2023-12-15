' Import IO controls to handle files
Imports System.IO

Public Class Form1
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' MessageBox for the About tab
        MessageBox.Show("This is an application that stores and performs processes on an editable set of movie records. Created by Dominic Rocco in 2023.", "About", MessageBoxButtons.OKCancel)
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' handles file closing
        Me.Close()
    End Sub

    ' saves a record to the a specified file
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Dim recordsFile As StreamWriter
        Dim strFile As String = "records.txt" ' file destination (creates if it doesn't exist)

        Try
            recordsFile = File.AppendText(strFile) ' open the given file to append text

            ' append the relevant information
            recordsFile.WriteLine("Video Name: " & txtName.Text)
            recordsFile.WriteLine("Year Produced: " & txtYearProduced.Text)
            recordsFile.WriteLine("Running Time: " & txtRunningTime.Text)
            recordsFile.WriteLine("Rating: " & txtRating.Text)
            recordsFile.WriteLine("") ' blank line for readability

            ' close the file to prevent leaks
            recordsFile.Close()

            MessageBox.Show("Film successfully saved to records.") ' confirmation message!

            ' reset the boxes
            txtName.Text = String.Empty
            txtYearProduced.Text = String.Empty
            txtRunningTime.Text = String.Empty
            txtRating.Text = String.Empty

        Catch
            MessageBox.Show("Error opening file.") ' fail gracefully
        End Try
    End Sub

    ' handles the search functionality
    Private Sub mnuSearchFind_Click(sender As Object, e As EventArgs) Handles mnuSearchFind.Click
        Dim strInput As String = InputBox("Enter the name of the video.", "Search") ' grabs the inputted name

        ' declare variables for reading purposes
        Dim recordsFile As StreamReader
        Dim strFile As String = "records.txt"
        Dim strName As String
        Dim boolMovieFound As Boolean = False

        ' variables that will hold the info if we find a match
        Dim strMovieName As String = String.Empty
        Dim strYearProduced As String = String.Empty
        Dim strRunningTime As String = String.Empty
        Dim strRating As String = String.Empty

        Try
            recordsFile = File.OpenText(strFile) ' open the records file

            Do Until recordsFile.EndOfStream ' do until we hit the end of the file
                strName = recordsFile.ReadLine() ' read a line

                If (strName = ("Video Name: " & strInput)) Then ' if they're equal, declare a match
                    boolMovieFound = True

                    strMovieName = strInput
                    strYearProduced = recordsFile.ReadLine()
                    strRunningTime = recordsFile.ReadLine()
                    strRating = recordsFile.ReadLine()

                    Exit Do ' break out, there's no use reading any more lines
                End If
            Loop

            If (boolMovieFound = True) Then ' confirmation message
                MessageBox.Show("Movie found! Click for details.")
                MessageBox.Show(strMovieName & ", " & strYearProduced & ", " & strRunningTime & ", " & strRating)
            Else
                MessageBox.Show("The specified title was not found in the records.") ' fail gracefully
            End If

            recordsFile.Close() ' close to prevent leaks
        Catch
            MessageBox.Show("Error opening file.") ' fail gracefully
        End Try
    End Sub

    ' handles the printing dialog
    Private Sub mnuReportPrint_Click(sender As Object, e As EventArgs) Handles mnuReportPrint.Click
        If pddPrintDialog.ShowDialog() = DialogResult.OK Then ' if the user clears the operation, print the document
            pdPrint.PrinterSettings = pddPrintDialog.PrinterSettings ' set the settings equal to what the user wants
            pdPrint.Print() ' print
        End If
    End Sub

    ' handles the actual printing
    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        Dim inputFile As StreamReader ' reader
        Dim intX As Integer = 10 ' pixels from the left
        Dim intY As Integer = 10 ' pixels from the top

        Try
            inputFile = File.OpenText("records.txt") ' open the file

            Do While Not inputFile.EndOfStream ' do until the end of the document
                e.Graphics.DrawString(inputFile.ReadLine(), New Font("Courier", 10, FontStyle.Regular), Brushes.Black, intX, intY) ' draw a graphics string

                intY += 12 ' move down by font size + 2
            Loop
            inputFile.Close() ' close to prevent leaks
        Catch
            MessageBox.Show("Error opening and printing file.") ' fail gracefully
        End Try
    End Sub
End Class
