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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWeekly = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWeek1 = New System.Windows.Forms.TextBox()
        Me.txtWeek2 = New System.Windows.Forms.TextBox()
        Me.txtWeek3 = New System.Windows.Forms.TextBox()
        Me.txtWeek4 = New System.Windows.Forms.TextBox()
        Me.lblWeek1 = New System.Windows.Forms.Label()
        Me.lblWeek2 = New System.Windows.Forms.Label()
        Me.lblWeek3 = New System.Windows.Forms.Label()
        Me.lblWeek4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This application calculates the amount of advertising revenue paid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to a Web site" &
    " that displays links to a selected vendor."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Advertising cost per week:"
        '
        'txtWeekly
        '
        Me.txtWeekly.Location = New System.Drawing.Point(160, 68)
        Me.txtWeekly.Name = "txtWeekly"
        Me.txtWeekly.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekly.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(0, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 2)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 52)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Number of ad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "clicks during the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "past 4 weekly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "periods:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "1:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "3:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(138, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "4:"
        '
        'txtWeek1
        '
        Me.txtWeek1.Location = New System.Drawing.Point(160, 140)
        Me.txtWeek1.Name = "txtWeek1"
        Me.txtWeek1.Size = New System.Drawing.Size(100, 20)
        Me.txtWeek1.TabIndex = 9
        Me.txtWeek1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWeek2
        '
        Me.txtWeek2.Location = New System.Drawing.Point(160, 168)
        Me.txtWeek2.Name = "txtWeek2"
        Me.txtWeek2.Size = New System.Drawing.Size(100, 20)
        Me.txtWeek2.TabIndex = 10
        Me.txtWeek2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWeek3
        '
        Me.txtWeek3.Location = New System.Drawing.Point(160, 197)
        Me.txtWeek3.Name = "txtWeek3"
        Me.txtWeek3.Size = New System.Drawing.Size(100, 20)
        Me.txtWeek3.TabIndex = 11
        Me.txtWeek3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWeek4
        '
        Me.txtWeek4.Location = New System.Drawing.Point(160, 228)
        Me.txtWeek4.Name = "txtWeek4"
        Me.txtWeek4.Size = New System.Drawing.Size(100, 20)
        Me.txtWeek4.TabIndex = 12
        Me.txtWeek4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWeek1
        '
        Me.lblWeek1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek1.Location = New System.Drawing.Point(266, 139)
        Me.lblWeek1.Name = "lblWeek1"
        Me.lblWeek1.Size = New System.Drawing.Size(87, 20)
        Me.lblWeek1.TabIndex = 13
        Me.lblWeek1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWeek2
        '
        Me.lblWeek2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek2.Location = New System.Drawing.Point(266, 168)
        Me.lblWeek2.Name = "lblWeek2"
        Me.lblWeek2.Size = New System.Drawing.Size(87, 20)
        Me.lblWeek2.TabIndex = 14
        Me.lblWeek2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWeek3
        '
        Me.lblWeek3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek3.Location = New System.Drawing.Point(266, 197)
        Me.lblWeek3.Name = "lblWeek3"
        Me.lblWeek3.Size = New System.Drawing.Size(87, 20)
        Me.lblWeek3.TabIndex = 15
        Me.lblWeek3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWeek4
        '
        Me.lblWeek4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek4.Location = New System.Drawing.Point(266, 227)
        Me.lblWeek4.Name = "lblWeek4"
        Me.lblWeek4.Size = New System.Drawing.Size(87, 20)
        Me.lblWeek4.TabIndex = 16
        Me.lblWeek4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(263, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Revenue"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(0, 308)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(380, 22)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.Text = "StatusStrip1"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(70, 268)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 19
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(151, 268)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 268)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 330)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblWeek4)
        Me.Controls.Add(Me.lblWeek3)
        Me.Controls.Add(Me.lblWeek2)
        Me.Controls.Add(Me.lblWeek1)
        Me.Controls.Add(Me.txtWeek4)
        Me.Controls.Add(Me.txtWeek3)
        Me.Controls.Add(Me.txtWeek2)
        Me.Controls.Add(Me.txtWeek1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWeekly)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pay Per Click Advertising Revenue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWeekly As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtWeek1 As TextBox
    Friend WithEvents txtWeek2 As TextBox
    Friend WithEvents txtWeek3 As TextBox
    Friend WithEvents txtWeek4 As TextBox
    Friend WithEvents lblWeek1 As Label
    Friend WithEvents lblWeek2 As Label
    Friend WithEvents lblWeek3 As Label
    Friend WithEvents lblWeek4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblStatus As StatusStrip
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
