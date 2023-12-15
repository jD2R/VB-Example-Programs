<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FirstMonths = New System.Windows.Forms.ListBox()
        Me.FirstYears = New System.Windows.Forms.ListBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FirstMonths
        '
        Me.FirstMonths.FormattingEnabled = True
        Me.FirstMonths.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.FirstMonths.Location = New System.Drawing.Point(11, 12)
        Me.FirstMonths.Name = "FirstMonths"
        Me.FirstMonths.Size = New System.Drawing.Size(120, 95)
        Me.FirstMonths.TabIndex = 0
        '
        'FirstYears
        '
        Me.FirstYears.FormattingEnabled = True
        Me.FirstYears.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020"})
        Me.FirstYears.Location = New System.Drawing.Point(137, 12)
        Me.FirstYears.Name = "FirstYears"
        Me.FirstYears.Size = New System.Drawing.Size(120, 95)
        Me.FirstYears.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(56, 113)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(137, 113)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 145)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.FirstYears)
        Me.Controls.Add(Me.FirstMonths)
        Me.Name = "Form1"
        Me.Text = "List Box Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FirstMonths As ListBox
    Friend WithEvents FirstYears As ListBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnReset As Button
End Class
