﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllMembersForm
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
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllMembersDataSet = New Karate_School_Manager.AllMembersDataSet()
        Me.MembersTableAdapter = New Karate_School_Manager.AllMembersDataSetTableAdapters.MembersTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.AllowUserToDeleteRows = False
        Me.dgvMembers.AutoGenerateColumns = False
        Me.dgvMembers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn})
        Me.dgvMembers.DataSource = Me.MembersBindingSource
        Me.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMembers.Location = New System.Drawing.Point(0, 24)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.Size = New System.Drawing.Size(514, 257)
        Me.dgvMembers.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.AllMembersDataSet
        '
        'AllMembersDataSet
        '
        Me.AllMembersDataSet.DataSetName = "AllMembersDataSet"
        Me.AllMembersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(180, 22)
        Me.mnuSave.Text = "&Save"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(180, 22)
        Me.mnuClose.Text = "&Close"
        '
        'AllMembersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 281)
        Me.Controls.Add(Me.dgvMembers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AllMembersForm"
        Me.Text = "All Members"
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents AllMembersDataSet As AllMembersDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As AllMembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
End Class
