<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DEBIT_CARD
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
        Dim CARD_NUMBERLabel As System.Windows.Forms.Label
        Dim MMLabel As System.Windows.Forms.Label
        Dim YYLabel As System.Windows.Forms.Label
        Dim CVVLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DEBIT_CARD))
        Me.Database6DataSet4 = New PHARAMACY1.Database6DataSet4()
        Me.DEBIT_CARDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEBIT_CARDTableAdapter = New PHARAMACY1.Database6DataSet4TableAdapters.DEBIT_CARDTableAdapter()
        Me.TableAdapterManager = New PHARAMACY1.Database6DataSet4TableAdapters.TableAdapterManager()
        Me.DEBIT_CARDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DEBIT_CARDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CARD_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.MMTextBox = New System.Windows.Forms.TextBox()
        Me.YYTextBox = New System.Windows.Forms.TextBox()
        Me.CVVTextBox = New System.Windows.Forms.TextBox()
        Me.DEBIT_CARDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CUSTOMER_IDLabel = New System.Windows.Forms.Label()
        CARD_NUMBERLabel = New System.Windows.Forms.Label()
        MMLabel = New System.Windows.Forms.Label()
        YYLabel = New System.Windows.Forms.Label()
        CVVLabel = New System.Windows.Forms.Label()
        CType(Me.Database6DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEBIT_CARDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEBIT_CARDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DEBIT_CARDBindingNavigator.SuspendLayout()
        CType(Me.DEBIT_CARDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(52, 56)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(85, 13)
        CUSTOMER_IDLabel.TabIndex = 1
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'CARD_NUMBERLabel
        '
        CARD_NUMBERLabel.AutoSize = True
        CARD_NUMBERLabel.Location = New System.Drawing.Point(52, 82)
        CARD_NUMBERLabel.Name = "CARD_NUMBERLabel"
        CARD_NUMBERLabel.Size = New System.Drawing.Size(90, 13)
        CARD_NUMBERLabel.TabIndex = 3
        CARD_NUMBERLabel.Text = "CARD NUMBER:"
        '
        'MMLabel
        '
        MMLabel.AutoSize = True
        MMLabel.Location = New System.Drawing.Point(52, 108)
        MMLabel.Name = "MMLabel"
        MMLabel.Size = New System.Drawing.Size(28, 13)
        MMLabel.TabIndex = 5
        MMLabel.Text = "MM:"
        '
        'YYLabel
        '
        YYLabel.AutoSize = True
        YYLabel.Location = New System.Drawing.Point(52, 134)
        YYLabel.Name = "YYLabel"
        YYLabel.Size = New System.Drawing.Size(24, 13)
        YYLabel.TabIndex = 7
        YYLabel.Text = "YY:"
        '
        'CVVLabel
        '
        CVVLabel.AutoSize = True
        CVVLabel.Location = New System.Drawing.Point(52, 160)
        CVVLabel.Name = "CVVLabel"
        CVVLabel.Size = New System.Drawing.Size(31, 13)
        CVVLabel.TabIndex = 9
        CVVLabel.Text = "CVV:"
        '
        'Database6DataSet4
        '
        Me.Database6DataSet4.DataSetName = "Database6DataSet4"
        Me.Database6DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DEBIT_CARDBindingSource
        '
        Me.DEBIT_CARDBindingSource.DataMember = "DEBIT_CARD"
        Me.DEBIT_CARDBindingSource.DataSource = Me.Database6DataSet4
        '
        'DEBIT_CARDTableAdapter
        '
        Me.DEBIT_CARDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DEBIT_CARDTableAdapter = Me.DEBIT_CARDTableAdapter
        Me.TableAdapterManager.UpdateOrder = PHARAMACY1.Database6DataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DEBIT_CARDBindingNavigator
        '
        Me.DEBIT_CARDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DEBIT_CARDBindingNavigator.BindingSource = Me.DEBIT_CARDBindingSource
        Me.DEBIT_CARDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DEBIT_CARDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DEBIT_CARDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DEBIT_CARDBindingNavigatorSaveItem})
        Me.DEBIT_CARDBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DEBIT_CARDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DEBIT_CARDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DEBIT_CARDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DEBIT_CARDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DEBIT_CARDBindingNavigator.Name = "DEBIT_CARDBindingNavigator"
        Me.DEBIT_CARDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DEBIT_CARDBindingNavigator.Size = New System.Drawing.Size(650, 25)
        Me.DEBIT_CARDBindingNavigator.TabIndex = 0
        Me.DEBIT_CARDBindingNavigator.Text = "BindingNavigator1"
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
        'DEBIT_CARDBindingNavigatorSaveItem
        '
        Me.DEBIT_CARDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DEBIT_CARDBindingNavigatorSaveItem.Image = CType(resources.GetObject("DEBIT_CARDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DEBIT_CARDBindingNavigatorSaveItem.Name = "DEBIT_CARDBindingNavigatorSaveItem"
        Me.DEBIT_CARDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DEBIT_CARDBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DEBIT_CARDBindingSource, "CUSTOMER_ID", True))
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(148, 53)
        Me.CUSTOMER_IDTextBox.MaxLength = 5
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUSTOMER_IDTextBox.TabIndex = 2
        '
        'CARD_NUMBERTextBox
        '
        Me.CARD_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DEBIT_CARDBindingSource, "CARD_NUMBER", True))
        Me.CARD_NUMBERTextBox.Location = New System.Drawing.Point(148, 79)
        Me.CARD_NUMBERTextBox.MaxLength = 12
        Me.CARD_NUMBERTextBox.Name = "CARD_NUMBERTextBox"
        Me.CARD_NUMBERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CARD_NUMBERTextBox.TabIndex = 4
        '
        'MMTextBox
        '
        Me.MMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DEBIT_CARDBindingSource, "MM", True))
        Me.MMTextBox.Location = New System.Drawing.Point(148, 105)
        Me.MMTextBox.MaxLength = 2
        Me.MMTextBox.Name = "MMTextBox"
        Me.MMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MMTextBox.TabIndex = 6
        '
        'YYTextBox
        '
        Me.YYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DEBIT_CARDBindingSource, "YY", True))
        Me.YYTextBox.Location = New System.Drawing.Point(148, 131)
        Me.YYTextBox.MaxLength = 2
        Me.YYTextBox.Name = "YYTextBox"
        Me.YYTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YYTextBox.TabIndex = 8
        '
        'CVVTextBox
        '
        Me.CVVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DEBIT_CARDBindingSource, "CVV", True))
        Me.CVVTextBox.Location = New System.Drawing.Point(148, 157)
        Me.CVVTextBox.MaxLength = 3
        Me.CVVTextBox.Name = "CVVTextBox"
        Me.CVVTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CVVTextBox.TabIndex = 10
        '
        'DEBIT_CARDDataGridView
        '
        Me.DEBIT_CARDDataGridView.AutoGenerateColumns = False
        Me.DEBIT_CARDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DEBIT_CARDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DEBIT_CARDDataGridView.DataSource = Me.DEBIT_CARDBindingSource
        Me.DEBIT_CARDDataGridView.Location = New System.Drawing.Point(55, 200)
        Me.DEBIT_CARDDataGridView.Name = "DEBIT_CARDDataGridView"
        Me.DEBIT_CARDDataGridView.Size = New System.Drawing.Size(540, 130)
        Me.DEBIT_CARDDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CUSTOMER_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CUSTOMER_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CARD_NUMBER"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CARD_NUMBER"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MM"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MM"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "YY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "YY"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CVV"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CVV"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(465, 124)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(359, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(465, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DEBIT_CARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(650, 365)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DEBIT_CARDDataGridView)
        Me.Controls.Add(CUSTOMER_IDLabel)
        Me.Controls.Add(Me.CUSTOMER_IDTextBox)
        Me.Controls.Add(CARD_NUMBERLabel)
        Me.Controls.Add(Me.CARD_NUMBERTextBox)
        Me.Controls.Add(MMLabel)
        Me.Controls.Add(Me.MMTextBox)
        Me.Controls.Add(YYLabel)
        Me.Controls.Add(Me.YYTextBox)
        Me.Controls.Add(CVVLabel)
        Me.Controls.Add(Me.CVVTextBox)
        Me.Controls.Add(Me.DEBIT_CARDBindingNavigator)
        Me.Name = "DEBIT_CARD"
        Me.Text = "DEBIT_CARD"
        CType(Me.Database6DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEBIT_CARDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEBIT_CARDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DEBIT_CARDBindingNavigator.ResumeLayout(False)
        Me.DEBIT_CARDBindingNavigator.PerformLayout()
        CType(Me.DEBIT_CARDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database6DataSet4 As PHARAMACY1.Database6DataSet4
    Friend WithEvents DEBIT_CARDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DEBIT_CARDTableAdapter As PHARAMACY1.Database6DataSet4TableAdapters.DEBIT_CARDTableAdapter
    Friend WithEvents TableAdapterManager As PHARAMACY1.Database6DataSet4TableAdapters.TableAdapterManager
    Friend WithEvents DEBIT_CARDBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DEBIT_CARDBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CUSTOMER_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CARD_NUMBERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CVVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DEBIT_CARDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
