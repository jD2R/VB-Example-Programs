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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KayaksDataSet = New Kayak_Rental_Prices.KayaksDataSet()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesTableAdapter = New Kayak_Rental_Prices.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeeklyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.HourlyRateDataGridViewTextBoxColumn, Me.DailyRateDataGridViewTextBoxColumn, Me.WeeklyRateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KayakTypesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(485, 231)
        Me.DataGridView1.TabIndex = 0
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HourlyRateDataGridViewTextBoxColumn
        '
        Me.HourlyRateDataGridViewTextBoxColumn.DataPropertyName = "Hourly Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.HeaderText = "Hourly Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.Name = "HourlyRateDataGridViewTextBoxColumn"
        Me.HourlyRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DailyRateDataGridViewTextBoxColumn
        '
        Me.DailyRateDataGridViewTextBoxColumn.DataPropertyName = "Daily Rate"
        Me.DailyRateDataGridViewTextBoxColumn.HeaderText = "Daily Rate"
        Me.DailyRateDataGridViewTextBoxColumn.Name = "DailyRateDataGridViewTextBoxColumn"
        Me.DailyRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeeklyRateDataGridViewTextBoxColumn
        '
        Me.WeeklyRateDataGridViewTextBoxColumn.DataPropertyName = "Weekly Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.HeaderText = "Weekly Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.Name = "WeeklyRateDataGridViewTextBoxColumn"
        Me.WeeklyRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 231)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Kayak Rental Prices"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DailyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeeklyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
