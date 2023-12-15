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
        Me.cboCountries = New System.Windows.Forms.ComboBox()
        Me.cboPlays = New System.Windows.Forms.ComboBox()
        Me.cboArtists = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCountries
        '
        Me.cboCountries.FormattingEnabled = True
        Me.cboCountries.Items.AddRange(New Object() {"England", "Ireland", "Scotland", "Wales"})
        Me.cboCountries.Location = New System.Drawing.Point(111, 13)
        Me.cboCountries.Name = "cboCountries"
        Me.cboCountries.Size = New System.Drawing.Size(121, 21)
        Me.cboCountries.Sorted = True
        Me.cboCountries.TabIndex = 0
        '
        'cboPlays
        '
        Me.cboPlays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboPlays.FormattingEnabled = True
        Me.cboPlays.Items.AddRange(New Object() {"A Comedy of Errors", "Hamlet", "Much Ado About Nothing", "Romeo and Juliet", "The Merchant of Venice"})
        Me.cboPlays.Location = New System.Drawing.Point(111, 40)
        Me.cboPlays.Name = "cboPlays"
        Me.cboPlays.Size = New System.Drawing.Size(121, 72)
        Me.cboPlays.Sorted = True
        Me.cboPlays.TabIndex = 1
        '
        'cboArtists
        '
        Me.cboArtists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArtists.FormattingEnabled = True
        Me.cboArtists.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cboArtists.Location = New System.Drawing.Point(111, 118)
        Me.cboArtists.Name = "cboArtists"
        Me.cboArtists.Size = New System.Drawing.Size(121, 21)
        Me.cboArtists.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose a Country:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Choose a Play:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Choose an Artist:"
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountry.Location = New System.Drawing.Point(12, 22)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(121, 22)
        Me.lblCountry.TabIndex = 6
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlay
        '
        Me.lblPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlay.Location = New System.Drawing.Point(12, 51)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(121, 22)
        Me.lblPlay.TabIndex = 7
        Me.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArtist
        '
        Me.lblArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArtist.Location = New System.Drawing.Point(12, 80)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(121, 22)
        Me.lblArtist.TabIndex = 8
        Me.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCountry)
        Me.GroupBox1.Controls.Add(Me.lblArtist)
        Me.GroupBox1.Controls.Add(Me.lblPlay)
        Me.GroupBox1.Location = New System.Drawing.Point(238, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 127)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Choices"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(77, 151)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(98, 39)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "&Show Selections"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(181, 151)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 39)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(285, 151)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 39)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 202)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboArtists)
        Me.Controls.Add(Me.cboPlays)
        Me.Controls.Add(Me.cboCountries)
        Me.Name = "Form1"
        Me.Text = "Combo Box Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCountries As ComboBox
    Friend WithEvents cboPlays As ComboBox
    Friend WithEvents cboArtists As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblPlay As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnShow As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
