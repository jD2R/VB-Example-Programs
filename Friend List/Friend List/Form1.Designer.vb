﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.Location = New System.Drawing.Point(12, 12)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(157, 95)
        Me.lstFriends.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Enter &Names"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 146)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstFriends)
        Me.Name = "Form1"
        Me.Text = "Friend List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFriends As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
