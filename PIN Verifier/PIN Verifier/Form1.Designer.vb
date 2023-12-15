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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt7 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(10, 19)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(33, 20)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(49, 19)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(33, 20)
        Me.txt2.TabIndex = 1
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(88, 19)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(33, 20)
        Me.txt3.TabIndex = 2
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(127, 19)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(33, 20)
        Me.txt4.TabIndex = 3
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(166, 19)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(33, 20)
        Me.txt5.TabIndex = 4
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(205, 19)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(33, 20)
        Me.txt6.TabIndex = 5
        '
        'txt7
        '
        Me.txt7.Location = New System.Drawing.Point(244, 19)
        Me.txt7.Name = "txt7"
        Me.txt7.Size = New System.Drawing.Size(33, 20)
        Me.txt7.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt7)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.txt6)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.txt5)
        Me.GroupBox1.Controls.Add(Me.txt3)
        Me.GroupBox1.Controls.Add(Me.txt4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 51)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter the PIN"
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(12, 69)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(82, 23)
        Me.btnVerify.TabIndex = 8
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(114, 69)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(217, 69)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 103)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "PIN Verifier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt6 As TextBox
    Friend WithEvents txt7 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVerify As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
