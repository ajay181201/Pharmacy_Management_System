<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UPI))
        Dim CUSTOMER_IDLabel As System.Windows.Forms.Label
        Dim UPI_IDLabel As System.Windows.Forms.Label
        Me.Database6DataSet5 = New PHARAMACY1.Database6DataSet5()
        Me.UPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UPITableAdapter = New PHARAMACY1.Database6DataSet5TableAdapters.UPITableAdapter()
        Me.TableAdapterManager = New PHARAMACY1.Database6DataSet5TableAdapters.TableAdapterManager()
        Me.UPIBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.UPIBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.UPI_IDTextBox = New System.Windows.Forms.TextBox()
        Me.UPIDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CUSTOMER_IDLabel = New System.Windows.Forms.Label()
        UPI_IDLabel = New System.Windows.Forms.Label()
        CType(Me.Database6DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPIBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UPIBindingNavigator.SuspendLayout()
        CType(Me.UPIDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database6DataSet5
        '
        Me.Database6DataSet5.DataSetName = "Database6DataSet5"
        Me.Database6DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UPIBindingSource
        '
        Me.UPIBindingSource.DataMember = "UPI"
        Me.UPIBindingSource.DataSource = Me.Database6DataSet5
        '
        'UPITableAdapter
        '
        Me.UPITableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = PHARAMACY1.Database6DataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UPITableAdapter = Me.UPITableAdapter
        '
        'UPIBindingNavigator
        '
        Me.UPIBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UPIBindingNavigator.BindingSource = Me.UPIBindingSource
        Me.UPIBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UPIBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UPIBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UPIBindingNavigatorSaveItem})
        Me.UPIBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UPIBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UPIBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UPIBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UPIBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UPIBindingNavigator.Name = "UPIBindingNavigator"
        Me.UPIBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UPIBindingNavigator.Size = New System.Drawing.Size(689, 25)
        Me.UPIBindingNavigator.TabIndex = 0
        Me.UPIBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'UPIBindingNavigatorSaveItem
        '
        Me.UPIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UPIBindingNavigatorSaveItem.Image = CType(resources.GetObject("UPIBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UPIBindingNavigatorSaveItem.Name = "UPIBindingNavigatorSaveItem"
        Me.UPIBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.UPIBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(58, 98)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(85, 13)
        CUSTOMER_IDLabel.TabIndex = 1
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UPIBindingSource, "CUSTOMER_ID", True))
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(149, 95)
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CUSTOMER_IDTextBox.TabIndex = 2
        '
        'UPI_IDLabel
        '
        UPI_IDLabel.AutoSize = True
        UPI_IDLabel.Location = New System.Drawing.Point(58, 124)
        UPI_IDLabel.Name = "UPI_IDLabel"
        UPI_IDLabel.Size = New System.Drawing.Size(42, 13)
        UPI_IDLabel.TabIndex = 3
        UPI_IDLabel.Text = "UPI ID:"
        '
        'UPI_IDTextBox
        '
        Me.UPI_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UPIBindingSource, "UPI_ID", True))
        Me.UPI_IDTextBox.Location = New System.Drawing.Point(149, 121)
        Me.UPI_IDTextBox.Name = "UPI_IDTextBox"
        Me.UPI_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UPI_IDTextBox.TabIndex = 4
        '
        'UPIDataGridView
        '
        Me.UPIDataGridView.AutoGenerateColumns = False
        Me.UPIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UPIDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.UPIDataGridView.DataSource = Me.UPIBindingSource
        Me.UPIDataGridView.Location = New System.Drawing.Point(36, 168)
        Me.UPIDataGridView.Name = "UPIDataGridView"
        Me.UPIDataGridView.Size = New System.Drawing.Size(300, 110)
        Me.UPIDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CUSTOMER_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CUSTOMER_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UPI_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UPI_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(517, 124)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(390, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(517, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(390, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 429)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UPIDataGridView)
        Me.Controls.Add(CUSTOMER_IDLabel)
        Me.Controls.Add(Me.CUSTOMER_IDTextBox)
        Me.Controls.Add(UPI_IDLabel)
        Me.Controls.Add(Me.UPI_IDTextBox)
        Me.Controls.Add(Me.UPIBindingNavigator)
        Me.Name = "UPI"
        Me.Text = "UPI"
        CType(Me.Database6DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPIBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UPIBindingNavigator.ResumeLayout(False)
        Me.UPIBindingNavigator.PerformLayout()
        CType(Me.UPIDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database6DataSet5 As PHARAMACY1.Database6DataSet5
    Friend WithEvents UPIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UPITableAdapter As PHARAMACY1.Database6DataSet5TableAdapters.UPITableAdapter
    Friend WithEvents TableAdapterManager As PHARAMACY1.Database6DataSet5TableAdapters.TableAdapterManager
    Friend WithEvents UPIBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UPIBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CUSTOMER_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UPI_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UPIDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
