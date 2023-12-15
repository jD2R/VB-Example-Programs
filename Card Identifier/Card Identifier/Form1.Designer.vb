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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.card1 = New System.Windows.Forms.PictureBox()
        Me.card2 = New System.Windows.Forms.PictureBox()
        Me.card3 = New System.Windows.Forms.PictureBox()
        Me.card4 = New System.Windows.Forms.PictureBox()
        Me.card5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelOutput = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'card1
        '
        Me.card1.Image = CType(resources.GetObject("card1.Image"), System.Drawing.Image)
        Me.card1.InitialImage = Nothing
        Me.card1.Location = New System.Drawing.Point(18, 49)
        Me.card1.Name = "card1"
        Me.card1.Size = New System.Drawing.Size(55, 78)
        Me.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card1.TabIndex = 0
        Me.card1.TabStop = False
        '
        'card2
        '
        Me.card2.Image = CType(resources.GetObject("card2.Image"), System.Drawing.Image)
        Me.card2.Location = New System.Drawing.Point(79, 49)
        Me.card2.Name = "card2"
        Me.card2.Size = New System.Drawing.Size(55, 78)
        Me.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card2.TabIndex = 1
        Me.card2.TabStop = False
        '
        'card3
        '
        Me.card3.Image = CType(resources.GetObject("card3.Image"), System.Drawing.Image)
        Me.card3.Location = New System.Drawing.Point(140, 48)
        Me.card3.Name = "card3"
        Me.card3.Size = New System.Drawing.Size(55, 78)
        Me.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card3.TabIndex = 2
        Me.card3.TabStop = False
        '
        'card4
        '
        Me.card4.Image = CType(resources.GetObject("card4.Image"), System.Drawing.Image)
        Me.card4.Location = New System.Drawing.Point(201, 48)
        Me.card4.Name = "card4"
        Me.card4.Size = New System.Drawing.Size(55, 78)
        Me.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card4.TabIndex = 3
        Me.card4.TabStop = False
        '
        'card5
        '
        Me.card5.Image = CType(resources.GetObject("card5.Image"), System.Drawing.Image)
        Me.card5.Location = New System.Drawing.Point(262, 48)
        Me.card5.Name = "card5"
        Me.card5.Size = New System.Drawing.Size(55, 78)
        Me.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.card5.TabIndex = 4
        Me.card5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Click a Card to See Its Name"
        '
        'labelOutput
        '
        Me.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelOutput.Location = New System.Drawing.Point(18, 140)
        Me.labelOutput.Name = "labelOutput"
        Me.labelOutput.Size = New System.Drawing.Size(299, 23)
        Me.labelOutput.TabIndex = 6
        Me.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(131, 173)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 211)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.labelOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.card5)
        Me.Controls.Add(Me.card4)
        Me.Controls.Add(Me.card3)
        Me.Controls.Add(Me.card2)
        Me.Controls.Add(Me.card1)
        Me.Name = "Form1"
        Me.Text = "Card Identifier"
        CType(Me.card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.card5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents card1 As PictureBox
    Friend WithEvents card2 As PictureBox
    Friend WithEvents card3 As PictureBox
    Friend WithEvents card4 As PictureBox
    Friend WithEvents card5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents labelOutput As Label
    Friend WithEvents exitButton As Button
End Class
