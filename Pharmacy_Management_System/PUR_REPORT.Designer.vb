<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PUR_REPORT
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
        Me.MEDICINEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDICINENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PURCHASEDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYMENTMETHODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PURCHASEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database6DataSet3 = New PHARAMACY1.Database6DataSet3()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PURCHASETableAdapter = New PHARAMACY1.Database6DataSet3TableAdapters.PURCHASETableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PURCHASEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database6DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MEDICINEIDDataGridViewTextBoxColumn, Me.MEDICINENAMEDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn, Me.UNITPRICEDataGridViewTextBoxColumn, Me.PURCHASEDATEDataGridViewTextBoxColumn, Me.PAYMENTMETHODDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PURCHASEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(64, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 220)
        Me.DataGridView1.TabIndex = 0
        '
        'MEDICINEIDDataGridViewTextBoxColumn
        '
        Me.MEDICINEIDDataGridViewTextBoxColumn.DataPropertyName = "MEDICINE_ID"
        Me.MEDICINEIDDataGridViewTextBoxColumn.HeaderText = "MEDICINE_ID"
        Me.MEDICINEIDDataGridViewTextBoxColumn.Name = "MEDICINEIDDataGridViewTextBoxColumn"
        '
        'MEDICINENAMEDataGridViewTextBoxColumn
        '
        Me.MEDICINENAMEDataGridViewTextBoxColumn.DataPropertyName = "MEDICINE_NAME"
        Me.MEDICINENAMEDataGridViewTextBoxColumn.HeaderText = "MEDICINE_NAME"
        Me.MEDICINENAMEDataGridViewTextBoxColumn.Name = "MEDICINENAMEDataGridViewTextBoxColumn"
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        '
        'UNITPRICEDataGridViewTextBoxColumn
        '
        Me.UNITPRICEDataGridViewTextBoxColumn.DataPropertyName = "UNIT_PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.HeaderText = "UNIT_PRICE"
        Me.UNITPRICEDataGridViewTextBoxColumn.Name = "UNITPRICEDataGridViewTextBoxColumn"
        '
        'PURCHASEDATEDataGridViewTextBoxColumn
        '
        Me.PURCHASEDATEDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_DATE"
        Me.PURCHASEDATEDataGridViewTextBoxColumn.HeaderText = "PURCHASE_DATE"
        Me.PURCHASEDATEDataGridViewTextBoxColumn.Name = "PURCHASEDATEDataGridViewTextBoxColumn"
        '
        'PAYMENTMETHODDataGridViewTextBoxColumn
        '
        Me.PAYMENTMETHODDataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_METHOD"
        Me.PAYMENTMETHODDataGridViewTextBoxColumn.HeaderText = "PAYMENT_METHOD"
        Me.PAYMENTMETHODDataGridViewTextBoxColumn.Name = "PAYMENTMETHODDataGridViewTextBoxColumn"
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        '
        'PURCHASEBindingSource
        '
        Me.PURCHASEBindingSource.DataMember = "PURCHASE"
        Me.PURCHASEBindingSource.DataSource = Me.Database6DataSet3
        '
        'Database6DataSet3
        '
        Me.Database6DataSet3.DataSetName = "Database6DataSet3"
        Me.Database6DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(767, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PURCHASETableAdapter
        '
        Me.PURCHASETableAdapter.ClearBeforeFill = True
        '
        'PUR_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(901, 303)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PUR_REPORT"
        Me.Text = "PUR_REPORT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PURCHASEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database6DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Database6DataSet3 As PHARAMACY1.Database6DataSet3
    Friend WithEvents PURCHASEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PURCHASETableAdapter As PHARAMACY1.Database6DataSet3TableAdapters.PURCHASETableAdapter
    Friend WithEvents MEDICINEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEDICINENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNITPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PURCHASEDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAYMENTMETHODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
