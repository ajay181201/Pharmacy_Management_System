<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MED_REPORT
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
        Me.MEDICINETYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDICINEPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDICINEWEIGHTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MANFDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXPDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDICINEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database6DataSet1 = New PHARAMACY1.Database6DataSet1()
        Me.MEDICINETableAdapter = New PHARAMACY1.Database6DataSet1TableAdapters.MEDICINETableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database6DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MEDICINEIDDataGridViewTextBoxColumn, Me.MEDICINENAMEDataGridViewTextBoxColumn, Me.MEDICINETYPEDataGridViewTextBoxColumn, Me.MEDICINEPRICEDataGridViewTextBoxColumn, Me.MEDICINEWEIGHTDataGridViewTextBoxColumn, Me.MANFDATEDataGridViewTextBoxColumn, Me.EXPDATEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MEDICINEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(37, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 204)
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
        'MEDICINETYPEDataGridViewTextBoxColumn
        '
        Me.MEDICINETYPEDataGridViewTextBoxColumn.DataPropertyName = "MEDICINE_TYPE"
        Me.MEDICINETYPEDataGridViewTextBoxColumn.HeaderText = "MEDICINE_TYPE"
        Me.MEDICINETYPEDataGridViewTextBoxColumn.Name = "MEDICINETYPEDataGridViewTextBoxColumn"
        '
        'MEDICINEPRICEDataGridViewTextBoxColumn
        '
        Me.MEDICINEPRICEDataGridViewTextBoxColumn.DataPropertyName = "MEDICINE_PRICE"
        Me.MEDICINEPRICEDataGridViewTextBoxColumn.HeaderText = "MEDICINE_PRICE"
        Me.MEDICINEPRICEDataGridViewTextBoxColumn.Name = "MEDICINEPRICEDataGridViewTextBoxColumn"
        '
        'MEDICINEWEIGHTDataGridViewTextBoxColumn
        '
        Me.MEDICINEWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "MEDICINE_WEIGHT"
        Me.MEDICINEWEIGHTDataGridViewTextBoxColumn.HeaderText = "MEDICINE_WEIGHT"
        Me.MEDICINEWEIGHTDataGridViewTextBoxColumn.Name = "MEDICINEWEIGHTDataGridViewTextBoxColumn"
        '
        'MANFDATEDataGridViewTextBoxColumn
        '
        Me.MANFDATEDataGridViewTextBoxColumn.DataPropertyName = "MANF_DATE"
        Me.MANFDATEDataGridViewTextBoxColumn.HeaderText = "MANF_DATE"
        Me.MANFDATEDataGridViewTextBoxColumn.Name = "MANFDATEDataGridViewTextBoxColumn"
        '
        'EXPDATEDataGridViewTextBoxColumn
        '
        Me.EXPDATEDataGridViewTextBoxColumn.DataPropertyName = "EXP_DATE"
        Me.EXPDATEDataGridViewTextBoxColumn.HeaderText = "EXP_DATE"
        Me.EXPDATEDataGridViewTextBoxColumn.Name = "EXPDATEDataGridViewTextBoxColumn"
        '
        'MEDICINEBindingSource
        '
        Me.MEDICINEBindingSource.DataMember = "MEDICINE"
        Me.MEDICINEBindingSource.DataSource = Me.Database6DataSet1
        '
        'Database6DataSet1
        '
        Me.Database6DataSet1.DataSetName = "Database6DataSet1"
        Me.Database6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICINETableAdapter
        '
        Me.MEDICINETableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(820, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MED_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(977, 283)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MED_REPORT"
        Me.Text = "MED_REPORT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database6DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database6DataSet1 As PHARAMACY1.Database6DataSet1
    Friend WithEvents MEDICINEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICINETableAdapter As PHARAMACY1.Database6DataSet1TableAdapters.MEDICINETableAdapter
    Friend WithEvents MEDICINEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEDICINENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEDICINETYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEDICINEPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEDICINEWEIGHTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MANFDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
