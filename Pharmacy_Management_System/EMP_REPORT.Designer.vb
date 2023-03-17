<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMP_REPORT
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
        Me.EMPLOYEEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLOYEENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESIGNATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PINCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOBILENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database6DataSet = New PHARAMACY1.Database6DataSet()
        Me.EMPLOYEETableAdapter = New PHARAMACY1.Database6DataSetTableAdapters.EMPLOYEETableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPLOYEEIDDataGridViewTextBoxColumn, Me.EMPLOYEENAMEDataGridViewTextBoxColumn, Me.SALARYDataGridViewTextBoxColumn, Me.EMAILIDDataGridViewTextBoxColumn, Me.DESIGNATIONDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.PINCODEDataGridViewTextBoxColumn, Me.MOBILENODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPLOYEEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(76, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(939, 239)
        Me.DataGridView1.TabIndex = 0
        '
        'EMPLOYEEIDDataGridViewTextBoxColumn
        '
        Me.EMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ID"
        Me.EMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_ID"
        Me.EMPLOYEEIDDataGridViewTextBoxColumn.Name = "EMPLOYEEIDDataGridViewTextBoxColumn"
        '
        'EMPLOYEENAMEDataGridViewTextBoxColumn
        '
        Me.EMPLOYEENAMEDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_NAME"
        Me.EMPLOYEENAMEDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_NAME"
        Me.EMPLOYEENAMEDataGridViewTextBoxColumn.Name = "EMPLOYEENAMEDataGridViewTextBoxColumn"
        '
        'SALARYDataGridViewTextBoxColumn
        '
        Me.SALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.HeaderText = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.Name = "SALARYDataGridViewTextBoxColumn"
        '
        'EMAILIDDataGridViewTextBoxColumn
        '
        Me.EMAILIDDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_ID"
        Me.EMAILIDDataGridViewTextBoxColumn.HeaderText = "EMAIL_ID"
        Me.EMAILIDDataGridViewTextBoxColumn.Name = "EMAILIDDataGridViewTextBoxColumn"
        '
        'DESIGNATIONDataGridViewTextBoxColumn
        '
        Me.DESIGNATIONDataGridViewTextBoxColumn.DataPropertyName = "DESIGNATION"
        Me.DESIGNATIONDataGridViewTextBoxColumn.HeaderText = "DESIGNATION"
        Me.DESIGNATIONDataGridViewTextBoxColumn.Name = "DESIGNATIONDataGridViewTextBoxColumn"
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
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.Database6DataSet
        '
        'Database6DataSet
        '
        Me.Database6DataSet.DataSetName = "Database6DataSet"
        Me.Database6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(940, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EMP_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1063, 330)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "EMP_REPORT"
        Me.Text = "EMP_REPORT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database6DataSet As PHARAMACY1.Database6DataSet
    Friend WithEvents EMPLOYEEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPLOYEETableAdapter As PHARAMACY1.Database6DataSetTableAdapters.EMPLOYEETableAdapter
    Friend WithEvents EMPLOYEEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPLOYEENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALARYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAILIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESIGNATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PINCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOBILENODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
