<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PUR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PUR))
        Dim MEDICINE_IDLabel As System.Windows.Forms.Label
        Dim MEDICINE_NAMELabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim UNIT_PRICELabel As System.Windows.Forms.Label
        Dim PURCHASE_DATELabel As System.Windows.Forms.Label
        Dim PAYMENT_METHODLabel As System.Windows.Forms.Label
        Dim TOTALLabel As System.Windows.Forms.Label
        Me.Database6DataSet3 = New PHARAMACY1.Database6DataSet3()
        Me.PURCHASEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PURCHASETableAdapter = New PHARAMACY1.Database6DataSet3TableAdapters.PURCHASETableAdapter()
        Me.TableAdapterManager = New PHARAMACY1.Database6DataSet3TableAdapters.TableAdapterManager()
        Me.PURCHASEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PURCHASEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PURCHASEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MEDICINE_IDTextBox = New System.Windows.Forms.TextBox()
        Me.MEDICINE_NAMEComboBox = New System.Windows.Forms.ComboBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.PURCHASE_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PAYMENT_METHODTextBox = New System.Windows.Forms.TextBox()
        Me.TOTALTextBox = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Database6DataSet71 = New PHARAMACY1.Database6DataSet7()
        Me.Table1TableAdapter1 = New PHARAMACY1.Database6DataSet7TableAdapters.Table1TableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        MEDICINE_IDLabel = New System.Windows.Forms.Label()
        MEDICINE_NAMELabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        UNIT_PRICELabel = New System.Windows.Forms.Label()
        PURCHASE_DATELabel = New System.Windows.Forms.Label()
        PAYMENT_METHODLabel = New System.Windows.Forms.Label()
        TOTALLabel = New System.Windows.Forms.Label()
        CType(Me.Database6DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PURCHASEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PURCHASEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PURCHASEBindingNavigator.SuspendLayout()
        CType(Me.PURCHASEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database6DataSet71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database6DataSet3
        '
        Me.Database6DataSet3.DataSetName = "Database6DataSet3"
        Me.Database6DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PURCHASEBindingSource
        '
        Me.PURCHASEBindingSource.DataMember = "PURCHASE"
        Me.PURCHASEBindingSource.DataSource = Me.Database6DataSet3
        '
        'PURCHASETableAdapter
        '
        Me.PURCHASETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PURCHASETableAdapter = Me.PURCHASETableAdapter
        Me.TableAdapterManager.UpdateOrder = PHARAMACY1.Database6DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PURCHASEBindingNavigator
        '
        Me.PURCHASEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PURCHASEBindingNavigator.BindingSource = Me.PURCHASEBindingSource
        Me.PURCHASEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PURCHASEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PURCHASEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PURCHASEBindingNavigatorSaveItem})
        Me.PURCHASEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PURCHASEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PURCHASEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PURCHASEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PURCHASEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PURCHASEBindingNavigator.Name = "PURCHASEBindingNavigator"
        Me.PURCHASEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PURCHASEBindingNavigator.Size = New System.Drawing.Size(837, 25)
        Me.PURCHASEBindingNavigator.TabIndex = 0
        Me.PURCHASEBindingNavigator.Text = "BindingNavigator1"
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
        'PURCHASEBindingNavigatorSaveItem
        '
        Me.PURCHASEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PURCHASEBindingNavigatorSaveItem.Image = CType(resources.GetObject("PURCHASEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PURCHASEBindingNavigatorSaveItem.Name = "PURCHASEBindingNavigatorSaveItem"
        Me.PURCHASEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PURCHASEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(527, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "SEARCH"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(602, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 46
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(650, 201)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 45
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(650, 148)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "REMOVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(481, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(650, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "REPORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PURCHASEDataGridView
        '
        Me.PURCHASEDataGridView.AutoGenerateColumns = False
        Me.PURCHASEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PURCHASEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PURCHASEDataGridView.DataSource = Me.PURCHASEBindingSource
        Me.PURCHASEDataGridView.Location = New System.Drawing.Point(43, 279)
        Me.PURCHASEDataGridView.Name = "PURCHASEDataGridView"
        Me.PURCHASEDataGridView.Size = New System.Drawing.Size(743, 220)
        Me.PURCHASEDataGridView.TabIndex = 47
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MEDICINE_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MEDICINE_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MEDICINE_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MEDICINE_NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UNIT_PRICE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UNIT_PRICE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PURCHASE_DATE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PURCHASE_DATE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PAYMENT_METHOD"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PAYMENT_METHOD"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TOTAL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(481, 201)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "PROCESS"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'MEDICINE_IDLabel
        '
        MEDICINE_IDLabel.AutoSize = True
        MEDICINE_IDLabel.Location = New System.Drawing.Point(87, 59)
        MEDICINE_IDLabel.Name = "MEDICINE_IDLabel"
        MEDICINE_IDLabel.Size = New System.Drawing.Size(76, 13)
        MEDICINE_IDLabel.TabIndex = 48
        MEDICINE_IDLabel.Text = "MEDICINE ID:"
        '
        'MEDICINE_IDTextBox
        '
        Me.MEDICINE_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASEBindingSource, "MEDICINE_ID", True))
        Me.MEDICINE_IDTextBox.Location = New System.Drawing.Point(205, 56)
        Me.MEDICINE_IDTextBox.Name = "MEDICINE_IDTextBox"
        Me.MEDICINE_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MEDICINE_IDTextBox.TabIndex = 49
        '
        'MEDICINE_NAMELabel
        '
        MEDICINE_NAMELabel.AutoSize = True
        MEDICINE_NAMELabel.Location = New System.Drawing.Point(87, 85)
        MEDICINE_NAMELabel.Name = "MEDICINE_NAMELabel"
        MEDICINE_NAMELabel.Size = New System.Drawing.Size(96, 13)
        MEDICINE_NAMELabel.TabIndex = 50
        MEDICINE_NAMELabel.Text = "MEDICINE NAME:"
        '
        'MEDICINE_NAMEComboBox
        '
        Me.MEDICINE_NAMEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASEBindingSource, "MEDICINE_NAME", True))
        Me.MEDICINE_NAMEComboBox.DataSource = Me.BindingSource1
        Me.MEDICINE_NAMEComboBox.DisplayMember = "MEDICINE_NAME"
        Me.MEDICINE_NAMEComboBox.FormattingEnabled = True
        Me.MEDICINE_NAMEComboBox.Location = New System.Drawing.Point(205, 82)
        Me.MEDICINE_NAMEComboBox.Name = "MEDICINE_NAMEComboBox"
        Me.MEDICINE_NAMEComboBox.Size = New System.Drawing.Size(200, 21)
        Me.MEDICINE_NAMEComboBox.TabIndex = 51
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(87, 112)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(65, 13)
        QUANTITYLabel.TabIndex = 52
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASEBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(205, 109)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QUANTITYTextBox.TabIndex = 53
        '
        'UNIT_PRICELabel
        '
        UNIT_PRICELabel.AutoSize = True
        UNIT_PRICELabel.Location = New System.Drawing.Point(87, 138)
        UNIT_PRICELabel.Name = "UNIT_PRICELabel"
        UNIT_PRICELabel.Size = New System.Drawing.Size(71, 13)
        UNIT_PRICELabel.TabIndex = 54
        UNIT_PRICELabel.Text = "UNIT PRICE:"
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASEBindingSource, "UNIT_PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(205, 135)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(200, 20)
        Me.UNIT_PRICETextBox.TabIndex = 55
        '
        'PURCHASE_DATELabel
        '
        PURCHASE_DATELabel.AutoSize = True
        PURCHASE_DATELabel.Location = New System.Drawing.Point(87, 165)
        PURCHASE_DATELabel.Name = "PURCHASE_DATELabel"
        PURCHASE_DATELabel.Size = New System.Drawing.Size(101, 13)
        PURCHASE_DATELabel.TabIndex = 56
        PURCHASE_DATELabel.Text = "PURCHASE DATE:"
        '
        'PURCHASE_DATEDateTimePicker
        '
        Me.PURCHASE_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PURCHASEBindingSource, "PURCHASE_DATE", True))
        Me.PURCHASE_DATEDateTimePicker.Location = New System.Drawing.Point(205, 161)
        Me.PURCHASE_DATEDateTimePicker.Name = "PURCHASE_DATEDateTimePicker"
        Me.PURCHASE_DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PURCHASE_DATEDateTimePicker.TabIndex = 57
        '
        'PAYMENT_METHODLabel
        '
        PAYMENT_METHODLabel.AutoSize = True
        PAYMENT_METHODLabel.Location = New System.Drawing.Point(87, 190)
        PAYMENT_METHODLabel.Name = "PAYMENT_METHODLabel"
        PAYMENT_METHODLabel.Size = New System.Drawing.Size(112, 13)
        PAYMENT_METHODLabel.TabIndex = 58
        PAYMENT_METHODLabel.Text = "PAYMENT METHOD:"
        '
        'PAYMENT_METHODTextBox
        '
        Me.PAYMENT_METHODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASEBindingSource, "PAYMENT_METHOD", True))
        Me.PAYMENT_METHODTextBox.Location = New System.Drawing.Point(205, 187)
        Me.PAYMENT_METHODTextBox.Name = "PAYMENT_METHODTextBox"
        Me.PAYMENT_METHODTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PAYMENT_METHODTextBox.TabIndex = 59
        '
        'TOTALLabel
        '
        TOTALLabel.AutoSize = True
        TOTALLabel.Location = New System.Drawing.Point(87, 246)
        TOTALLabel.Name = "TOTALLabel"
        TOTALLabel.Size = New System.Drawing.Size(45, 13)
        TOTALLabel.TabIndex = 60
        TOTALLabel.Text = "TOTAL:"
        '
        'TOTALTextBox
        '
        Me.TOTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PURCHASEBindingSource, "TOTAL", True))
        Me.TOTALTextBox.Location = New System.Drawing.Point(205, 243)
        Me.TOTALTextBox.Name = "TOTALTextBox"
        Me.TOTALTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TOTALTextBox.TabIndex = 61
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(155, 214)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton1.TabIndex = 62
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CASH"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(229, 214)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 63
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "DEBIT CARD"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(344, 214)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton3.TabIndex = 64
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "UPI"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Database6DataSet71
        '
        Me.Database6DataSet71.DataSetName = "Database6DataSet7"
        Me.Database6DataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter1
        '
        Me.Table1TableAdapter1.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Table1"
        Me.BindingSource1.DataSource = Me.Database6DataSet71
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(558, 230)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 39)
        Me.Button7.TabIndex = 65
        Me.Button7.Text = "Retrive"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(837, 519)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(MEDICINE_IDLabel)
        Me.Controls.Add(Me.MEDICINE_IDTextBox)
        Me.Controls.Add(MEDICINE_NAMELabel)
        Me.Controls.Add(Me.MEDICINE_NAMEComboBox)
        Me.Controls.Add(QUANTITYLabel)
        Me.Controls.Add(Me.QUANTITYTextBox)
        Me.Controls.Add(UNIT_PRICELabel)
        Me.Controls.Add(Me.UNIT_PRICETextBox)
        Me.Controls.Add(PURCHASE_DATELabel)
        Me.Controls.Add(Me.PURCHASE_DATEDateTimePicker)
        Me.Controls.Add(PAYMENT_METHODLabel)
        Me.Controls.Add(Me.PAYMENT_METHODTextBox)
        Me.Controls.Add(TOTALLabel)
        Me.Controls.Add(Me.TOTALTextBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PURCHASEDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PURCHASEBindingNavigator)
        Me.Name = "PUR"
        Me.Text = "PUR"
        CType(Me.Database6DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PURCHASEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PURCHASEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PURCHASEBindingNavigator.ResumeLayout(False)
        Me.PURCHASEBindingNavigator.PerformLayout()
        CType(Me.PURCHASEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database6DataSet71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database6DataSet3 As PHARAMACY1.Database6DataSet3
    Friend WithEvents PURCHASEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PURCHASETableAdapter As PHARAMACY1.Database6DataSet3TableAdapters.PURCHASETableAdapter
    Friend WithEvents TableAdapterManager As PHARAMACY1.Database6DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents PURCHASEBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PURCHASEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PURCHASEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MEDICINE_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MEDICINE_NAMEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QUANTITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UNIT_PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PURCHASE_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PAYMENT_METHODTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TOTALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Database6DataSet71 As PHARAMACY1.Database6DataSet7
    Friend WithEvents Table1TableAdapter1 As PHARAMACY1.Database6DataSet7TableAdapters.Table1TableAdapter
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
