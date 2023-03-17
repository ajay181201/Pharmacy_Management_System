<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MED
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
        Dim MEDICINE_IDLabel As System.Windows.Forms.Label
        Dim MEDICINE_NAMELabel As System.Windows.Forms.Label
        Dim MEDICINE_TYPELabel As System.Windows.Forms.Label
        Dim MEDICINE_PRICELabel As System.Windows.Forms.Label
        Dim MEDICINE_WEIGHTLabel As System.Windows.Forms.Label
        Dim MANF_DATELabel As System.Windows.Forms.Label
        Dim EXP_DATELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MED))
        Me.Database6DataSet1 = New PHARAMACY1.Database6DataSet1()
        Me.MEDICINEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICINETableAdapter = New PHARAMACY1.Database6DataSet1TableAdapters.MEDICINETableAdapter()
        Me.TableAdapterManager = New PHARAMACY1.Database6DataSet1TableAdapters.TableAdapterManager()
        Me.MEDICINEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MEDICINEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MEDICINE_IDTextBox = New System.Windows.Forms.TextBox()
        Me.MEDICINE_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.MEDICINE_TYPEComboBox = New System.Windows.Forms.ComboBox()
        Me.MEDICINE_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.MEDICINE_WEIGHTTextBox = New System.Windows.Forms.TextBox()
        Me.MANF_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EXP_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MEDICINEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        MEDICINE_IDLabel = New System.Windows.Forms.Label()
        MEDICINE_NAMELabel = New System.Windows.Forms.Label()
        MEDICINE_TYPELabel = New System.Windows.Forms.Label()
        MEDICINE_PRICELabel = New System.Windows.Forms.Label()
        MEDICINE_WEIGHTLabel = New System.Windows.Forms.Label()
        MANF_DATELabel = New System.Windows.Forms.Label()
        EXP_DATELabel = New System.Windows.Forms.Label()
        CType(Me.Database6DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICINEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MEDICINEBindingNavigator.SuspendLayout()
        CType(Me.MEDICINEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEDICINE_IDLabel
        '
        MEDICINE_IDLabel.AutoSize = True
        MEDICINE_IDLabel.Location = New System.Drawing.Point(39, 58)
        MEDICINE_IDLabel.Name = "MEDICINE_IDLabel"
        MEDICINE_IDLabel.Size = New System.Drawing.Size(76, 13)
        MEDICINE_IDLabel.TabIndex = 1
        MEDICINE_IDLabel.Text = "MEDICINE ID:"
        '
        'MEDICINE_NAMELabel
        '
        MEDICINE_NAMELabel.AutoSize = True
        MEDICINE_NAMELabel.Location = New System.Drawing.Point(39, 84)
        MEDICINE_NAMELabel.Name = "MEDICINE_NAMELabel"
        MEDICINE_NAMELabel.Size = New System.Drawing.Size(96, 13)
        MEDICINE_NAMELabel.TabIndex = 3
        MEDICINE_NAMELabel.Text = "MEDICINE NAME:"
        '
        'MEDICINE_TYPELabel
        '
        MEDICINE_TYPELabel.AutoSize = True
        MEDICINE_TYPELabel.Location = New System.Drawing.Point(39, 110)
        MEDICINE_TYPELabel.Name = "MEDICINE_TYPELabel"
        MEDICINE_TYPELabel.Size = New System.Drawing.Size(93, 13)
        MEDICINE_TYPELabel.TabIndex = 5
        MEDICINE_TYPELabel.Text = "MEDICINE TYPE:"
        '
        'MEDICINE_PRICELabel
        '
        MEDICINE_PRICELabel.AutoSize = True
        MEDICINE_PRICELabel.Location = New System.Drawing.Point(39, 137)
        MEDICINE_PRICELabel.Name = "MEDICINE_PRICELabel"
        MEDICINE_PRICELabel.Size = New System.Drawing.Size(97, 13)
        MEDICINE_PRICELabel.TabIndex = 7
        MEDICINE_PRICELabel.Text = "MEDICINE PRICE:"
        '
        'MEDICINE_WEIGHTLabel
        '
        MEDICINE_WEIGHTLabel.AutoSize = True
        MEDICINE_WEIGHTLabel.Location = New System.Drawing.Point(39, 163)
        MEDICINE_WEIGHTLabel.Name = "MEDICINE_WEIGHTLabel"
        MEDICINE_WEIGHTLabel.Size = New System.Drawing.Size(109, 13)
        MEDICINE_WEIGHTLabel.TabIndex = 9
        MEDICINE_WEIGHTLabel.Text = "MEDICINE WEIGHT:"
        '
        'MANF_DATELabel
        '
        MANF_DATELabel.AutoSize = True
        MANF_DATELabel.Location = New System.Drawing.Point(39, 190)
        MANF_DATELabel.Name = "MANF_DATELabel"
        MANF_DATELabel.Size = New System.Drawing.Size(72, 13)
        MANF_DATELabel.TabIndex = 11
        MANF_DATELabel.Text = "MANF DATE:"
        '
        'EXP_DATELabel
        '
        EXP_DATELabel.AutoSize = True
        EXP_DATELabel.Location = New System.Drawing.Point(39, 216)
        EXP_DATELabel.Name = "EXP_DATELabel"
        EXP_DATELabel.Size = New System.Drawing.Size(63, 13)
        EXP_DATELabel.TabIndex = 13
        EXP_DATELabel.Text = "EXP DATE:"
        '
        'Database6DataSet1
        '
        Me.Database6DataSet1.DataSetName = "Database6DataSet1"
        Me.Database6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICINEBindingSource
        '
        Me.MEDICINEBindingSource.DataMember = "MEDICINE"
        Me.MEDICINEBindingSource.DataSource = Me.Database6DataSet1
        '
        'MEDICINETableAdapter
        '
        Me.MEDICINETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MEDICINETableAdapter = Me.MEDICINETableAdapter
        Me.TableAdapterManager.UpdateOrder = PHARAMACY1.Database6DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MEDICINEBindingNavigator
        '
        Me.MEDICINEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MEDICINEBindingNavigator.BindingSource = Me.MEDICINEBindingSource
        Me.MEDICINEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MEDICINEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MEDICINEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MEDICINEBindingNavigatorSaveItem})
        Me.MEDICINEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MEDICINEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MEDICINEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MEDICINEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MEDICINEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MEDICINEBindingNavigator.Name = "MEDICINEBindingNavigator"
        Me.MEDICINEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MEDICINEBindingNavigator.Size = New System.Drawing.Size(810, 25)
        Me.MEDICINEBindingNavigator.TabIndex = 0
        Me.MEDICINEBindingNavigator.Text = "BindingNavigator1"
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
        'MEDICINEBindingNavigatorSaveItem
        '
        Me.MEDICINEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MEDICINEBindingNavigatorSaveItem.Image = CType(resources.GetObject("MEDICINEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MEDICINEBindingNavigatorSaveItem.Name = "MEDICINEBindingNavigatorSaveItem"
        Me.MEDICINEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MEDICINEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MEDICINE_IDTextBox
        '
        Me.MEDICINE_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "MEDICINE_ID", True))
        Me.MEDICINE_IDTextBox.Location = New System.Drawing.Point(154, 55)
        Me.MEDICINE_IDTextBox.MaxLength = 5
        Me.MEDICINE_IDTextBox.Name = "MEDICINE_IDTextBox"
        Me.MEDICINE_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MEDICINE_IDTextBox.TabIndex = 2
        '
        'MEDICINE_NAMETextBox
        '
        Me.MEDICINE_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "MEDICINE_NAME", True))
        Me.MEDICINE_NAMETextBox.Location = New System.Drawing.Point(154, 81)
        Me.MEDICINE_NAMETextBox.MaxLength = 15
        Me.MEDICINE_NAMETextBox.Name = "MEDICINE_NAMETextBox"
        Me.MEDICINE_NAMETextBox.Size = New System.Drawing.Size(200, 20)
        Me.MEDICINE_NAMETextBox.TabIndex = 4
        '
        'MEDICINE_TYPEComboBox
        '
        Me.MEDICINE_TYPEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "MEDICINE_TYPE", True))
        Me.MEDICINE_TYPEComboBox.FormattingEnabled = True
        Me.MEDICINE_TYPEComboBox.Items.AddRange(New Object() {"TABLET", "SYRUP", "CAPSULE", "DROPS", "OINTMENT", "INHALES", "INJECTION", "PATCHES", "SUPPOSITORIES"})
        Me.MEDICINE_TYPEComboBox.Location = New System.Drawing.Point(154, 107)
        Me.MEDICINE_TYPEComboBox.Name = "MEDICINE_TYPEComboBox"
        Me.MEDICINE_TYPEComboBox.Size = New System.Drawing.Size(200, 21)
        Me.MEDICINE_TYPEComboBox.TabIndex = 6
        '
        'MEDICINE_PRICETextBox
        '
        Me.MEDICINE_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "MEDICINE_PRICE", True))
        Me.MEDICINE_PRICETextBox.Location = New System.Drawing.Point(154, 134)
        Me.MEDICINE_PRICETextBox.MaxLength = 5
        Me.MEDICINE_PRICETextBox.Name = "MEDICINE_PRICETextBox"
        Me.MEDICINE_PRICETextBox.Size = New System.Drawing.Size(200, 20)
        Me.MEDICINE_PRICETextBox.TabIndex = 8
        '
        'MEDICINE_WEIGHTTextBox
        '
        Me.MEDICINE_WEIGHTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICINEBindingSource, "MEDICINE_WEIGHT", True))
        Me.MEDICINE_WEIGHTTextBox.Location = New System.Drawing.Point(154, 160)
        Me.MEDICINE_WEIGHTTextBox.MaxLength = 5
        Me.MEDICINE_WEIGHTTextBox.Name = "MEDICINE_WEIGHTTextBox"
        Me.MEDICINE_WEIGHTTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MEDICINE_WEIGHTTextBox.TabIndex = 10
        '
        'MANF_DATEDateTimePicker
        '
        Me.MANF_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MEDICINEBindingSource, "MANF_DATE", True))
        Me.MANF_DATEDateTimePicker.Location = New System.Drawing.Point(154, 186)
        Me.MANF_DATEDateTimePicker.Name = "MANF_DATEDateTimePicker"
        Me.MANF_DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.MANF_DATEDateTimePicker.TabIndex = 12
        '
        'EXP_DATEDateTimePicker
        '
        Me.EXP_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MEDICINEBindingSource, "EXP_DATE", True))
        Me.EXP_DATEDateTimePicker.Location = New System.Drawing.Point(154, 212)
        Me.EXP_DATEDateTimePicker.Name = "EXP_DATEDateTimePicker"
        Me.EXP_DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.EXP_DATEDateTimePicker.TabIndex = 14
        '
        'MEDICINEDataGridView
        '
        Me.MEDICINEDataGridView.AutoGenerateColumns = False
        Me.MEDICINEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MEDICINEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.MEDICINEDataGridView.DataSource = Me.MEDICINEBindingSource
        Me.MEDICINEDataGridView.Location = New System.Drawing.Point(42, 264)
        Me.MEDICINEDataGridView.Name = "MEDICINEDataGridView"
        Me.MEDICINEDataGridView.Size = New System.Drawing.Size(737, 220)
        Me.MEDICINEDataGridView.TabIndex = 15
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MEDICINE_TYPE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MEDICINE_TYPE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MEDICINE_PRICE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MEDICINE_PRICE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MEDICINE_WEIGHT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MEDICINE_WEIGHT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MANF_DATE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "MANF_DATE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "EXP_DATE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "EXP_DATE"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(585, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "SEARCH"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(660, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 32
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(623, 198)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(708, 145)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "REMOVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(539, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(708, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "REPORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(539, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(810, 518)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MEDICINEDataGridView)
        Me.Controls.Add(MEDICINE_IDLabel)
        Me.Controls.Add(Me.MEDICINE_IDTextBox)
        Me.Controls.Add(MEDICINE_NAMELabel)
        Me.Controls.Add(Me.MEDICINE_NAMETextBox)
        Me.Controls.Add(MEDICINE_TYPELabel)
        Me.Controls.Add(Me.MEDICINE_TYPEComboBox)
        Me.Controls.Add(MEDICINE_PRICELabel)
        Me.Controls.Add(Me.MEDICINE_PRICETextBox)
        Me.Controls.Add(MEDICINE_WEIGHTLabel)
        Me.Controls.Add(Me.MEDICINE_WEIGHTTextBox)
        Me.Controls.Add(MANF_DATELabel)
        Me.Controls.Add(Me.MANF_DATEDateTimePicker)
        Me.Controls.Add(EXP_DATELabel)
        Me.Controls.Add(Me.EXP_DATEDateTimePicker)
        Me.Controls.Add(Me.MEDICINEBindingNavigator)
        Me.Name = "MED"
        Me.Text = "MED"
        CType(Me.Database6DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICINEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MEDICINEBindingNavigator.ResumeLayout(False)
        Me.MEDICINEBindingNavigator.PerformLayout()
        CType(Me.MEDICINEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database6DataSet1 As PHARAMACY1.Database6DataSet1
    Friend WithEvents MEDICINEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICINETableAdapter As PHARAMACY1.Database6DataSet1TableAdapters.MEDICINETableAdapter
    Friend WithEvents TableAdapterManager As PHARAMACY1.Database6DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents MEDICINEBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MEDICINEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MEDICINE_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MEDICINE_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MEDICINE_TYPEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MEDICINE_PRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MEDICINE_WEIGHTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MANF_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EXP_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MEDICINEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
