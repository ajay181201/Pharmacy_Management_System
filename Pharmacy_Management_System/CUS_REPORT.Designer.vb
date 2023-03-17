<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUS_REPORT
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
        Me.CUSTOMERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PINCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOBILENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database6DataSet2 = New PHARAMACY1.Database6DataSet2()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CUSTOMERTableAdapter = New PHARAMACY1.Database6DataSet2TableAdapters.CUSTOMERTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database6DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSTOMERIDDataGridViewTextBoxColumn, Me.CUSTOMERNAMEDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.PINCODEDataGridViewTextBoxColumn, Me.MOBILENODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CUSTOMERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(126, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(641, 192)
        Me.DataGridView1.TabIndex = 0
        '
        'CUSTOMERIDDataGridViewTextBoxColumn
        '
        Me.CUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Name = "CUSTOMERIDDataGridViewTextBoxColumn"
        '
        'CUSTOMERNAMEDataGridViewTextBoxColumn
        '
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_NAME"
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_NAME"
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn.Name = "CUSTOMERNAMEDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'PINCODEDataGridViewTextBoxColumn
        '
        Me.PINCODEDataGridViewTextBoxColumn.DataPropertyName = "PINCODE"
        Me.PINCODEDataGridViewTextBoxColumn.HeaderText = "PINCODE"
        Me.PINCODEDataGridViewTextBoxColumn.Name = "PINCODEDataGridViewTextBoxColumn"
        '
        'MOBILENODataGridViewTextBoxColumn
        '
        Me.MOBILENODataGridViewTextBoxColumn.DataPropertyName = "MOBILE_NO"
        Me.MOBILENODataGridViewTextBoxColumn.HeaderText = "MOBILE_NO"
        Me.MOBILENODataGridViewTextBoxColumn.Name = "MOBILENODataGridViewTextBoxColumn"
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.Database6DataSet2
        '
        'Database6DataSet2
        '
        Me.Database6DataSet2.DataSetName = "Database6DataSet2"
        Me.Database6DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(766, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'CUS_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(987, 298)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CUS_REPORT"
        Me.Text = "CUS_REPORT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database6DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Database6DataSet2 As PHARAMACY1.Database6DataSet2
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As PHARAMACY1.Database6DataSet2TableAdapters.CUSTOMERTableAdapter
    Friend WithEvents CUSTOMERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PINCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOBILENODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
