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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPeach = New System.Windows.Forms.CheckBox()
        Me.chkRaspberry = New System.Windows.Forms.CheckBox()
        Me.chkBlueberry = New System.Windows.Forms.CheckBox()
        Me.chkButter = New System.Windows.Forms.CheckBox()
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radWheat = New System.Windows.Forms.RadioButton()
        Me.radWhite = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radCafeAuLait = New System.Windows.Forms.RadioButton()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radRegCoffee = New System.Windows.Forms.RadioButton()
        Me.radNoCoffee = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 283)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPeach)
        Me.GroupBox2.Controls.Add(Me.chkRaspberry)
        Me.GroupBox2.Controls.Add(Me.chkBlueberry)
        Me.GroupBox2.Controls.Add(Me.chkButter)
        Me.GroupBox2.Controls.Add(Me.chkCreamCheese)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 166)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick Your Toppings"
        '
        'chkPeach
        '
        Me.chkPeach.AutoSize = True
        Me.chkPeach.Location = New System.Drawing.Point(17, 109)
        Me.chkPeach.Name = "chkPeach"
        Me.chkPeach.Size = New System.Drawing.Size(116, 17)
        Me.chkPeach.TabIndex = 4
        Me.chkPeach.Text = "Peach Jelly ($0.75)"
        Me.chkPeach.UseVisualStyleBackColor = True
        '
        'chkRaspberry
        '
        Me.chkRaspberry.AutoSize = True
        Me.chkRaspberry.Location = New System.Drawing.Point(17, 89)
        Me.chkRaspberry.Name = "chkRaspberry"
        Me.chkRaspberry.Size = New System.Drawing.Size(132, 17)
        Me.chkRaspberry.TabIndex = 3
        Me.chkRaspberry.Text = "Raspberry Jam ($0.75)"
        Me.chkRaspberry.UseVisualStyleBackColor = True
        '
        'chkBlueberry
        '
        Me.chkBlueberry.AutoSize = True
        Me.chkBlueberry.Location = New System.Drawing.Point(17, 69)
        Me.chkBlueberry.Name = "chkBlueberry"
        Me.chkBlueberry.Size = New System.Drawing.Size(128, 17)
        Me.chkBlueberry.TabIndex = 2
        Me.chkBlueberry.Text = "Blueberry Jam ($0.75)"
        Me.chkBlueberry.UseVisualStyleBackColor = True
        '
        'chkButter
        '
        Me.chkButter.AutoSize = True
        Me.chkButter.Location = New System.Drawing.Point(17, 49)
        Me.chkButter.Name = "chkButter"
        Me.chkButter.Size = New System.Drawing.Size(90, 17)
        Me.chkButter.TabIndex = 1
        Me.chkButter.Text = "Butter ($0.25)"
        Me.chkButter.UseVisualStyleBackColor = True
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(17, 29)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(131, 17)
        Me.chkCreamCheese.TabIndex = 0
        Me.chkCreamCheese.Text = "Cream Cheese ($0.50)"
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radWheat)
        Me.GroupBox1.Controls.Add(Me.radWhite)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a Bagel"
        '
        'radWheat
        '
        Me.radWheat.AutoSize = True
        Me.radWheat.Location = New System.Drawing.Point(17, 50)
        Me.radWheat.Name = "radWheat"
        Me.radWheat.Size = New System.Drawing.Size(127, 17)
        Me.radWheat.TabIndex = 1
        Me.radWheat.TabStop = True
        Me.radWheat.Text = "Whole Wheat ($1.50)"
        Me.radWheat.UseVisualStyleBackColor = True
        '
        'radWhite
        '
        Me.radWhite.AutoSize = True
        Me.radWhite.Location = New System.Drawing.Point(17, 26)
        Me.radWhite.Name = "radWhite"
        Me.radWhite.Size = New System.Drawing.Size(89, 17)
        Me.radWhite.TabIndex = 0
        Me.radWhite.TabStop = True
        Me.radWhite.Text = "White ($1.25)"
        Me.radWhite.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Location = New System.Drawing.Point(218, 48)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 153)
        Me.Panel4.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radCafeAuLait)
        Me.GroupBox3.Controls.Add(Me.radCappuccino)
        Me.GroupBox3.Controls.Add(Me.radRegCoffee)
        Me.GroupBox3.Controls.Add(Me.radNoCoffee)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 128)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Want Coffee with That?"
        '
        'radCafeAuLait
        '
        Me.radCafeAuLait.AutoSize = True
        Me.radCafeAuLait.Location = New System.Drawing.Point(18, 95)
        Me.radCafeAuLait.Name = "radCafeAuLait"
        Me.radCafeAuLait.Size = New System.Drawing.Size(114, 17)
        Me.radCafeAuLait.TabIndex = 3
        Me.radCafeAuLait.TabStop = True
        Me.radCafeAuLait.Text = "Cafe au lait ($1.75)"
        Me.radCafeAuLait.UseVisualStyleBackColor = True
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(18, 71)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(118, 17)
        Me.radCappuccino.TabIndex = 2
        Me.radCappuccino.TabStop = True
        Me.radCappuccino.Text = "Cappuccino ($2.00)"
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radRegCoffee
        '
        Me.radRegCoffee.AutoSize = True
        Me.radRegCoffee.Location = New System.Drawing.Point(18, 48)
        Me.radRegCoffee.Name = "radRegCoffee"
        Me.radRegCoffee.Size = New System.Drawing.Size(132, 17)
        Me.radRegCoffee.TabIndex = 1
        Me.radRegCoffee.TabStop = True
        Me.radRegCoffee.Text = "Regular Coffee ($1.25)"
        Me.radRegCoffee.UseVisualStyleBackColor = True
        '
        'radNoCoffee
        '
        Me.radNoCoffee.AutoSize = True
        Me.radNoCoffee.Location = New System.Drawing.Point(18, 24)
        Me.radNoCoffee.Name = "radNoCoffee"
        Me.radNoCoffee.Size = New System.Drawing.Size(51, 17)
        Me.radNoCoffee.TabIndex = 0
        Me.radNoCoffee.TabStop = True
        Me.radNoCoffee.Text = "None"
        Me.radNoCoffee.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.GroupBox4)
        Me.Panel5.Location = New System.Drawing.Point(218, 207)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 124)
        Me.Panel5.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 104)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Price"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(76, 69)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(74, 20)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(76, 46)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(74, 20)
        Me.lblTax.TabIndex = 5
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(76, 23)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(74, 20)
        Me.lblSubtotal.TabIndex = 4
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tax"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Subtotal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Brandi's Bagel House"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(74, 337)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(109, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(189, 337)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(89, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(284, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 369)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Bagel and Coffee Price Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkPeach As CheckBox
    Friend WithEvents chkRaspberry As CheckBox
    Friend WithEvents chkBlueberry As CheckBox
    Friend WithEvents chkButter As CheckBox
    Friend WithEvents chkCreamCheese As CheckBox
    Friend WithEvents radWheat As RadioButton
    Friend WithEvents radWhite As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radCafeAuLait As RadioButton
    Friend WithEvents radCappuccino As RadioButton
    Friend WithEvents radRegCoffee As RadioButton
    Friend WithEvents radNoCoffee As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
