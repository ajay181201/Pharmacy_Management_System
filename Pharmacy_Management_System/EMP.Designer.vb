<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMP
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
        Dim EMPLOYEE_IDLabel As System.Windows.Forms.Label
        Dim EMPLOYEE_NAMELabel As System.Windows.Forms.Label
        Dim SALARYLabel As System.Windows.Forms.Label
        Dim EMAIL_IDLabel As System.Windows.Forms.Label
        Dim DESIGNATIONLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim PINCODELabel As System.Windows.Forms.Label
        Dim MOBILE_NOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMP))
        Me.Database6DataSet = New PHARAMACY1.Database6DataSet()
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEETableAdapter = New PHARAMACY1.Database6DataSetTableAdapters.EMPLOYEETableAdapter()
        Me.TableAdapterManager = New PHARAMACY1.Database6DataSetTableAdapters.TableAdapterManager()
        Me.EMPLOYEEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EMPLOYEEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EMPLOYEE_IDTextBox = New System.Windows.Forms.TextBox()
        Me.EMPLOYEE_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.SALARYTextBox = New System.Windows.Forms.TextBox()
        Me.EMAIL_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DESIGNATIONComboBox = New System.Windows.Forms.ComboBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.PINCODETextBox = New System.Windows.Forms.TextBox()
        Me.MOBILE_NOTextBox = New System.Windows.Forms.TextBox()
        Me.EMPLOYEEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        EMPLOYEE_IDLabel = New System.Windows.Forms.Label()
        EMPLOYEE_NAMELabel = New System.Windows.Forms.Label()
        SALARYLabel = New System.Windows.Forms.Label()
        EMAIL_IDLabel = New System.Windows.Forms.Label()
        DESIGNATIONLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        PINCODELabel = New System.Windows.Forms.Label()
        MOBILE_NOLabel = New System.Windows.Forms.Label()
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMPLOYEEBindingNavigator.SuspendLayout()
        CType(Me.EMPLOYEEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EMPLOYEE_IDLabel
        '
        EMPLOYEE_IDLabel.AutoSize = True
        EMPLOYEE_IDLabel.Location = New System.Drawing.Point(59, 59)
        EMPLOYEE_IDLabel.Name = "EMPLOYEE_IDLabel"
        EMPLOYEE_IDLabel.Size = New System.Drawing.Size(82, 13)
        EMPLOYEE_IDLabel.TabIndex = 1
        EMPLOYEE_IDLabel.Text = "EMPLOYEE ID:"
        '
        'EMPLOYEE_NAMELabel
        '
        EMPLOYEE_NAMELabel.AutoSize = True
        EMPLOYEE_NAMELabel.Location = New System.Drawing.Point(59, 85)
        EMPLOYEE_NAMELabel.Name = "EMPLOYEE_NAMELabel"
        EMPLOYEE_NAMELabel.Size = New System.Drawing.Size(102, 13)
        EMPLOYEE_NAMELabel.TabIndex = 3
        EMPLOYEE_NAMELabel.Text = "EMPLOYEE NAME:"
        '
        'SALARYLabel
        '
        SALARYLabel.AutoSize = True
        SALARYLabel.Location = New System.Drawing.Point(59, 111)
        SALARYLabel.Name = "SALARYLabel"
        SALARYLabel.Size = New System.Drawing.Size(52, 13)
        SALARYLabel.TabIndex = 5
        SALARYLabel.Text = "SALARY:"
        '
        'EMAIL_IDLabel
        '
        EMAIL_IDLabel.AutoSize = True
        EMAIL_IDLabel.Location = New System.Drawing.Point(59, 137)
        EMAIL_IDLabel.Name = "EMAIL_IDLabel"
        EMAIL_IDLabel.Size = New System.Drawing.Size(56, 13)
        EMAIL_IDLabel.TabIndex = 7
        EMAIL_IDLabel.Text = "EMAIL ID:"
        '
        'DESIGNATIONLabel
        '
        DESIGNATIONLabel.AutoSize = True
        DESIGNATIONLabel.Location = New System.Drawing.Point(59, 163)
        DESIGNATIONLabel.Name = "DESIGNATIONLabel"
        DESIGNATIONLabel.Size = New System.Drawing.Size(84, 13)
        DESIGNATIONLabel.TabIndex = 9
        DESIGNATIONLabel.Text = "DESIGNATION:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(59, 191)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 11
        DOBLabel.Text = "DOB:"
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Location = New System.Drawing.Point(59, 216)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(62, 13)
        ADDRESSLabel.TabIndex = 13
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'PINCODELabel
        '
        PINCODELabel.AutoSize = True
        PINCODELabel.Location = New System.Drawing.Point(59, 242)
        PINCODELabel.Name = "PINCODELabel"
        PINCODELabel.Size = New System.Drawing.Size(58, 13)
        PINCODELabel.TabIndex = 15
        PINCODELabel.Text = "PINCODE:"
        '
        'MOBILE_NOLabel
        '
        MOBILE_NOLabel.AutoSize = True
        MOBILE_NOLabel.Location = New System.Drawing.Point(59, 268)
        MOBILE_NOLabel.Name = "MOBILE_NOLabel"
        MOBILE_NOLabel.Size = New System.Drawing.Size(69, 13)
        MOBILE_NOLabel.TabIndex = 17
        MOBILE_NOLabel.Text = "MOBILE NO:"
        '
        'Database6DataSet
        '
        Me.Database6DataSet.DataSetName = "Database6DataSet"
        Me.Database6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.Database6DataSet
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EMPLOYEETableAdapter = Me.EMPLOYEETableAdapter
        Me.TableAdapterManager.UpdateOrder = PHARAMACY1.Database6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMPLOYEEBindingNavigator
        '
        Me.EMPLOYEEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EMPLOYEEBindingNavigator.BindingSource = Me.EMPLOYEEBindingSource
        Me.EMPLOYEEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EMPLOYEEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EMPLOYEEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EMPLOYEEBindingNavigatorSaveItem})
        Me.EMPLOYEEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EMPLOYEEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EMPLOYEEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EMPLOYEEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EMPLOYEEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EMPLOYEEBindingNavigator.Name = "EMPLOYEEBindingNavigator"
        Me.EMPLOYEEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EMPLOYEEBindingNavigator.Size = New System.Drawing.Size(1001, 25)
        Me.EMPLOYEEBindingNavigator.TabIndex = 0
        Me.EMPLOYEEBindingNavigator.Text = "BindingNavigator1"
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
        'EMPLOYEEBindingNavigatorSaveItem
        '
        Me.EMPLOYEEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EMPLOYEEBindingNavigatorSaveItem.Image = CType(resources.GetObject("EMPLOYEEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EMPLOYEEBindingNavigatorSaveItem.Name = "EMPLOYEEBindingNavigatorSaveItem"
        Me.EMPLOYEEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EMPLOYEEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EMPLOYEE_IDTextBox
        '
        Me.EMPLOYEE_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "EMPLOYEE_ID", True))
        Me.EMPLOYEE_IDTextBox.Location = New System.Drawing.Point(167, 56)
        Me.EMPLOYEE_IDTextBox.MaxLength = 5
        Me.EMPLOYEE_IDTextBox.Name = "EMPLOYEE_IDTextBox"
        Me.EMPLOYEE_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EMPLOYEE_IDTextBox.TabIndex = 2
        '
        'EMPLOYEE_NAMETextBox
        '
        Me.EMPLOYEE_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "EMPLOYEE_NAME", True))
        Me.EMPLOYEE_NAMETextBox.Location = New System.Drawing.Point(167, 82)
        Me.EMPLOYEE_NAMETextBox.MaxLength = 15
        Me.EMPLOYEE_NAMETextBox.Name = "EMPLOYEE_NAMETextBox"
        Me.EMPLOYEE_NAMETextBox.Size = New System.Drawing.Size(200, 20)
        Me.EMPLOYEE_NAMETextBox.TabIndex = 4
        '
        'SALARYTextBox
        '
        Me.SALARYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "SALARY", True))
        Me.SALARYTextBox.Location = New System.Drawing.Point(167, 108)
        Me.SALARYTextBox.Name = "SALARYTextBox"
        Me.SALARYTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SALARYTextBox.TabIndex = 6
        '
        'EMAIL_IDTextBox
        '
        Me.EMAIL_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "EMAIL_ID", True))
        Me.EMAIL_IDTextBox.Location = New System.Drawing.Point(167, 134)
        Me.EMAIL_IDTextBox.Name = "EMAIL_IDTextBox"
        Me.EMAIL_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EMAIL_IDTextBox.TabIndex = 8
        '
        'DESIGNATIONComboBox
        '
        Me.DESIGNATIONComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "DESIGNATION", True))
        Me.DESIGNATIONComboBox.FormattingEnabled = True
        Me.DESIGNATIONComboBox.Items.AddRange(New Object() {"SALES PERSON", "SALES MANAGER", "SALES EXECUTIVE", "ACCOUNT MANAGER", "PRODUCT DEVELOPMENT", "MANAGER", "RETAIL MANAGER", "ACCOUNT EXECUTIVE", "CLERK", "SECURITY", "SWEEPER"})
        Me.DESIGNATIONComboBox.Location = New System.Drawing.Point(167, 160)
        Me.DESIGNATIONComboBox.Name = "DESIGNATIONComboBox"
        Me.DESIGNATIONComboBox.Size = New System.Drawing.Size(200, 21)
        Me.DESIGNATIONComboBox.TabIndex = 10
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EMPLOYEEBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(167, 187)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 12
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(167, 213)
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ADDRESSTextBox.TabIndex = 14
        '
        'PINCODETextBox
        '
        Me.PINCODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "PINCODE", True))
        Me.PINCODETextBox.Location = New System.Drawing.Point(167, 239)
        Me.PINCODETextBox.MaxLength = 6
        Me.PINCODETextBox.Name = "PINCODETextBox"
        Me.PINCODETextBox.Size = New System.Drawing.Size(200, 20)
        Me.PINCODETextBox.TabIndex = 16
        '
        'MOBILE_NOTextBox
        '
        Me.MOBILE_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "MOBILE_NO", True))
        Me.MOBILE_NOTextBox.Location = New System.Drawing.Point(167, 265)
        Me.MOBILE_NOTextBox.MaxLength = 10
        Me.MOBILE_NOTextBox.Name = "MOBILE_NOTextBox"
        Me.MOBILE_NOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MOBILE_NOTextBox.TabIndex = 18
        '
        'EMPLOYEEDataGridView
        '
        Me.EMPLOYEEDataGridView.AutoGenerateColumns = False
        Me.EMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMPLOYEEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.EMPLOYEEDataGridView.DataSource = Me.EMPLOYEEBindingSource
        Me.EMPLOYEEDataGridView.Location = New System.Drawing.Point(26, 310)
        Me.EMPLOYEEDataGridView.Name = "EMPLOYEEDataGridView"
        Me.EMPLOYEEDataGridView.Size = New System.Drawing.Size(943, 220)
        Me.EMPLOYEEDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EMPLOYEE_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EMPLOYEE_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EMPLOYEE_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "EMPLOYEE_NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SALARY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SALARY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EMAIL_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EMAIL_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DESIGNATION"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DESIGNATION"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PINCODE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PINCODE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MOBILE_NO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MOBILE_NO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(528, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(697, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "REPORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(528, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(697, 173)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "REMOVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(612, 226)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(649, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(574, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "SEARCH"
        '
        'EMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1001, 547)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EMPLOYEEDataGridView)
        Me.Controls.Add(EMPLOYEE_IDLabel)
        Me.Controls.Add(Me.EMPLOYEE_IDTextBox)
        Me.Controls.Add(EMPLOYEE_NAMELabel)
        Me.Controls.Add(Me.EMPLOYEE_NAMETextBox)
        Me.Controls.Add(SALARYLabel)
        Me.Controls.Add(Me.SALARYTextBox)
        Me.Controls.Add(EMAIL_IDLabel)
        Me.Controls.Add(Me.EMAIL_IDTextBox)
        Me.Controls.Add(DESIGNATIONLabel)
        Me.Controls.Add(Me.DESIGNATIONComboBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(ADDRESSLabel)
        Me.Controls.Add(Me.ADDRESSTextBox)
        Me.Controls.Add(PINCODELabel)
        Me.Controls.Add(Me.PINCODETextBox)
        Me.Controls.Add(MOBILE_NOLabel)
        Me.Controls.Add(Me.MOBILE_NOTextBox)
        Me.Controls.Add(Me.EMPLOYEEBindingNavigator)
        Me.Name = "EMP"
        Me.Text = "EMP"
        CType(Me.Database6DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMPLOYEEBindingNavigator.ResumeLayout(False)
        Me.EMPLOYEEBindingNavigator.PerformLayout()
        CType(Me.EMPLOYEEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database6DataSet As PHARAMACY1.Database6DataSet
    Friend WithEvents EMPLOYEEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPLOYEETableAdapter As PHARAMACY1.Database6DataSetTableAdapters.EMPLOYEETableAdapter
    Friend WithEvents TableAdapterManager As PHARAMACY1.Database6DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMPLOYEEBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EMPLOYEEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EMPLOYEE_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMPLOYEE_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SALARYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMAIL_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESIGNATIONComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ADDRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PINCODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MOBILE_NOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMPLOYEEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
