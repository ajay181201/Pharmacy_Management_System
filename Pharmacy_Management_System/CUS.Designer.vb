<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUS
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
        Dim CUSTOMER_IDLabel As System.Windows.Forms.Label
        Dim CUSTOMER_NAMELabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim PINCODELabel As System.Windows.Forms.Label
        Dim MOBILE_NOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CUS))
        Me.Database6DataSet2 = New PHARAMACY1.Database6DataSet2()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMERTableAdapter = New PHARAMACY1.Database6DataSet2TableAdapters.CUSTOMERTableAdapter()
        Me.TableAdapterManager = New PHARAMACY1.Database6DataSet2TableAdapters.TableAdapterManager()
        Me.CUSTOMERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CUSTOMERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMER_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.PINCODETextBox = New System.Windows.Forms.TextBox()
        Me.MOBILE_NOTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CUSTOMER_IDLabel = New System.Windows.Forms.Label()
        CUSTOMER_NAMELabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        PINCODELabel = New System.Windows.Forms.Label()
        MOBILE_NOLabel = New System.Windows.Forms.Label()
        CType(Me.Database6DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CUSTOMERBindingNavigator.SuspendLayout()
        CType(Me.CUSTOMERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(48, 60)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(85, 13)
        CUSTOMER_IDLabel.TabIndex = 1
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'CUSTOMER_NAMELabel
        '
        CUSTOMER_NAMELabel.AutoSize = True
        CUSTOMER_NAMELabel.Location = New System.Drawing.Point(48, 86)
        CUSTOMER_NAMELabel.Name = "CUSTOMER_NAMELabel"
        CUSTOMER_NAMELabel.Size = New System.Drawing.Size(105, 13)
        CUSTOMER_NAMELabel.TabIndex = 3
        CUSTOMER_NAMELabel.Text = "CUSTOMER NAME:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(48, 113)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 5
        DOBLabel.Text = "DOB:"
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Location = New System.Drawing.Point(48, 138)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(62, 13)
        ADDRESSLabel.TabIndex = 7
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'PINCODELabel
        '
        PINCODELabel.AutoSize = True
        PINCODELabel.Location = New System.Drawing.Point(48, 164)
        PINCODELabel.Name = "PINCODELabel"
        PINCODELabel.Size = New System.Drawing.Size(58, 13)
        PINCODELabel.TabIndex = 9
        PINCODELabel.Text = "PINCODE:"
        '
        'MOBILE_NOLabel
        '
        MOBILE_NOLabel.AutoSize = True
        MOBILE_NOLabel.Location = New System.Drawing.Point(48, 190)
        MOBILE_NOLabel.Name = "MOBILE_NOLabel"
        MOBILE_NOLabel.Size = New System.Drawing.Size(69, 13)
        MOBILE_NOLabel.TabIndex = 11
        MOBILE_NOLabel.Text = "MOBILE NO:"
        '
        'Database6DataSet2
        '
        Me.Database6DataSet2.DataSetName = "Database6DataSet2"
        Me.Database6DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.Database6DataSet2
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMERTableAdapter = Me.CUSTOMERTableAdapter
        Me.TableAdapterManager.UpdateOrder = PHARAMACY1.Database6DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CUSTOMERBindingNavigator
        '
        Me.CUSTOMERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CUSTOMERBindingNavigator.BindingSource = Me.CUSTOMERBindingSource
        Me.CUSTOMERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CUSTOMERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CUSTOMERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CUSTOMERBindingNavigatorSaveItem})
        Me.CUSTOMERBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CUSTOMERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CUSTOMERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CUSTOMERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CUSTOMERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CUSTOMERBindingNavigator.Name = "CUSTOMERBindingNavigator"
        Me.CUSTOMERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CUSTOMERBindingNavigator.Size = New System.Drawing.Size(824, 25)
        Me.CUSTOMERBindingNavigator.TabIndex = 0
        Me.CUSTOMERBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CUSTOMERBindingNavigatorSaveItem
        '
        Me.CUSTOMERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CUSTOMERBindingNavigatorSaveItem.Image = CType(resources.GetObject("CUSTOMERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CUSTOMERBindingNavigatorSaveItem.Name = "CUSTOMERBindingNavigatorSaveItem"
        Me.CUSTOMERBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CUSTOMERBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUSTOMER_ID", True))
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(159, 57)
        Me.CUSTOMER_IDTextBox.MaxLength = 5
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CUSTOMER_IDTextBox.TabIndex = 2
        '
        'CUSTOMER_NAMETextBox
        '
        Me.CUSTOMER_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CUSTOMER_NAME", True))
        Me.CUSTOMER_NAMETextBox.Location = New System.Drawing.Point(159, 83)
        Me.CUSTOMER_NAMETextBox.MaxLength = 15
        Me.CUSTOMER_NAMETextBox.Name = "CUSTOMER_NAMETextBox"
        Me.CUSTOMER_NAMETextBox.Size = New System.Drawing.Size(200, 20)
        Me.CUSTOMER_NAMETextBox.TabIndex = 4
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CUSTOMERBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(159, 109)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 6
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(159, 135)
        Me.ADDRESSTextBox.MaxLength = 20
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ADDRESSTextBox.TabIndex = 8
        '
        'PINCODETextBox
        '
        Me.PINCODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "PINCODE", True))
        Me.PINCODETextBox.Location = New System.Drawing.Point(159, 161)
        Me.PINCODETextBox.MaxLength = 6
        Me.PINCODETextBox.Name = "PINCODETextBox"
        Me.PINCODETextBox.Size = New System.Drawing.Size(200, 20)
        Me.PINCODETextBox.TabIndex = 10
        '
        'MOBILE_NOTextBox
        '
        Me.MOBILE_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "MOBILE_NO", True))
        Me.MOBILE_NOTextBox.Location = New System.Drawing.Point(159, 187)
        Me.MOBILE_NOTextBox.MaxLength = 10
        Me.MOBILE_NOTextBox.Name = "MOBILE_NOTextBox"
        Me.MOBILE_NOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MOBILE_NOTextBox.TabIndex = 12
        '
        'CUSTOMERDataGridView
        '
        Me.CUSTOMERDataGridView.AutoGenerateColumns = False
        Me.CUSTOMERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CUSTOMERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CUSTOMERDataGridView.DataSource = Me.CUSTOMERBindingSource
        Me.CUSTOMERDataGridView.Location = New System.Drawing.Point(64, 227)
        Me.CUSTOMERDataGridView.Name = "CUSTOMERDataGridView"
        Me.CUSTOMERDataGridView.Size = New System.Drawing.Size(641, 183)
        Me.CUSTOMERDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CUSTOMER_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CUSTOMER_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CUSTOMER_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CUSTOMER_NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PINCODE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PINCODE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MOBILE_NO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MOBILE_NO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "SEARCH"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(582, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 39
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(545, 198)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(630, 145)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "REMOVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(461, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(630, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "REPORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(461, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CUS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(824, 433)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CUSTOMERDataGridView)
        Me.Controls.Add(CUSTOMER_IDLabel)
        Me.Controls.Add(Me.CUSTOMER_IDTextBox)
        Me.Controls.Add(CUSTOMER_NAMELabel)
        Me.Controls.Add(Me.CUSTOMER_NAMETextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(ADDRESSLabel)
        Me.Controls.Add(Me.ADDRESSTextBox)
        Me.Controls.Add(PINCODELabel)
        Me.Controls.Add(Me.PINCODETextBox)
        Me.Controls.Add(MOBILE_NOLabel)
        Me.Controls.Add(Me.MOBILE_NOTextBox)
        Me.Controls.Add(Me.CUSTOMERBindingNavigator)
        Me.Name = "CUS"
        Me.Text = "CUS"
        CType(Me.Database6DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CUSTOMERBindingNavigator.ResumeLayout(False)
        Me.CUSTOMERBindingNavigator.PerformLayout()
        CType(Me.CUSTOMERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database6DataSet2 As PHARAMACY1.Database6DataSet2
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As PHARAMACY1.Database6DataSet2TableAdapters.CUSTOMERTableAdapter
    Friend WithEvents TableAdapterManager As PHARAMACY1.Database6DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents CUSTOMERBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CUSTOMERBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CUSTOMER_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUSTOMER_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ADDRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PINCODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MOBILE_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUSTOMERDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
