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
        Me.KayaksDataSet = New Kayak_Browser.KayaksDataSet()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesTableAdapter = New Kayak_Browser.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TableAdapterManager = New Kayak_Browser.KayaksDataSetTableAdapters.TableAdapterManager()
        Me.DescriptionLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.KayakTypesBindingSource
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(23, 43)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(201, 134)
        Me.ListBox1.TabIndex = 0
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KayakTypesTableAdapter = Me.KayakTypesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Kayak_Browser.KayaksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DescriptionLabel1
        '
        Me.DescriptionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescriptionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KayakTypesBindingSource, "Description", True))
        Me.DescriptionLabel1.Location = New System.Drawing.Point(230, 43)
        Me.DescriptionLabel1.Name = "DescriptionLabel1"
        Me.DescriptionLabel1.Size = New System.Drawing.Size(346, 134)
        Me.DescriptionLabel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a kayak type to view a description."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 200)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DescriptionLabel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Kayak Browser"
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TableAdapterManager As KayaksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DescriptionLabel1 As Label
    Friend WithEvents Label1 As Label
End Class
