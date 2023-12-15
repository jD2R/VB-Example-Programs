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
        Me.leftButton = New System.Windows.Forms.Button()
        Me.middleButton = New System.Windows.Forms.Button()
        Me.rightButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.labelOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'leftButton
        '
        Me.leftButton.Location = New System.Drawing.Point(23, 91)
        Me.leftButton.Name = "leftButton"
        Me.leftButton.Size = New System.Drawing.Size(75, 23)
        Me.leftButton.TabIndex = 0
        Me.leftButton.Text = "Sinister"
        Me.leftButton.UseVisualStyleBackColor = True
        '
        'middleButton
        '
        Me.middleButton.Location = New System.Drawing.Point(104, 91)
        Me.middleButton.Name = "middleButton"
        Me.middleButton.Size = New System.Drawing.Size(75, 23)
        Me.middleButton.TabIndex = 1
        Me.middleButton.Text = "Medium"
        Me.middleButton.UseVisualStyleBackColor = True
        '
        'rightButton
        '
        Me.rightButton.Location = New System.Drawing.Point(185, 91)
        Me.rightButton.Name = "rightButton"
        Me.rightButton.Size = New System.Drawing.Size(75, 23)
        Me.rightButton.TabIndex = 2
        Me.rightButton.Text = "Dexter"
        Me.rightButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(104, 120)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'labelOutput
        '
        Me.labelOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOutput.Location = New System.Drawing.Point(23, 32)
        Me.labelOutput.Name = "labelOutput"
        Me.labelOutput.Size = New System.Drawing.Size(237, 37)
        Me.labelOutput.TabIndex = 4
        Me.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.labelOutput)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.rightButton)
        Me.Controls.Add(Me.middleButton)
        Me.Controls.Add(Me.leftButton)
        Me.Name = "Form1"
        Me.Text = "Latin Translator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftButton As Button
    Friend WithEvents middleButton As Button
    Friend WithEvents rightButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents labelOutput As Label
End Class
