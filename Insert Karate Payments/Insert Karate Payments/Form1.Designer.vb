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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtMemberId = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.MemberIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsDataSet = New Insert_Karate_Payments.PaymentsDataSet()
        Me.PaymentsTableAdapter = New Insert_Karate_Payments.PaymentsDataSetTableAdapters.PaymentsTableAdapter()
        Me.btnTotal = New System.Windows.Forms.Button()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMemberId
        '
        Me.txtMemberId.Location = New System.Drawing.Point(97, 24)
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(100, 20)
        Me.txtMemberId.TabIndex = 0
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(97, 50)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(97, 76)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Member ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount:"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(212, 27)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(92, 31)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "Insert Payment"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'dgvPayments
        '
        Me.dgvPayments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPayments.AutoGenerateColumns = False
        Me.dgvPayments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberIdDataGridViewTextBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.dgvPayments.DataSource = Me.PaymentsBindingSource
        Me.dgvPayments.Location = New System.Drawing.Point(22, 120)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.RowHeadersVisible = False
        Me.dgvPayments.Size = New System.Drawing.Size(296, 195)
        Me.dgvPayments.TabIndex = 7
        '
        'MemberIdDataGridViewTextBoxColumn
        '
        Me.MemberIdDataGridViewTextBoxColumn.DataPropertyName = "Member_Id"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        Me.MemberIdDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MemberIdDataGridViewTextBoxColumn.HeaderText = "Member_Id"
        Me.MemberIdDataGridViewTextBoxColumn.Name = "MemberIdDataGridViewTextBoxColumn"
        Me.MemberIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        Me.PaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.AmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.PaymentsDataSet
        '
        'PaymentsDataSet
        '
        Me.PaymentsDataSet.DataSetName = "PaymentsDataSet"
        Me.PaymentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(212, 64)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(92, 31)
        Me.btnTotal.TabIndex = 8
        Me.btnTotal.Text = "Show Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 339)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.dgvPayments)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtMemberId)
        Me.Name = "Form1"
        Me.Text = "Insert Karate Payments"
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMemberId As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents PaymentsDataSet As PaymentsDataSet
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents PaymentsTableAdapter As PaymentsDataSetTableAdapters.PaymentsTableAdapter
    Friend WithEvents MemberIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnTotal As Button
End Class
