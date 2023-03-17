Imports System.Data.OleDb
Public Class PUR

    Private Sub PURCHASEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PURCHASEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PURCHASEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database6DataSet3)

    End Sub

    Private Sub PUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet3.PURCHASE' table. You can move, or remove it, as needed.
        Me.PURCHASETableAdapter.Fill(Me.Database6DataSet3.PURCHASE)
        Table1TableAdapter1.Fill(Database6DataSet71.Table1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PURCHASEBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            PURCHASEBindingSource.EndEdit()
            PURCHASETableAdapter.Update(Database6DataSet3.PURCHASE)
            MessageBox.Show("DATA SAVED")
        Catch ex As Exception
            MessageBox.Show("ERROR OCCURED WHILE SAVING DATA")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PURCHASEBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\PROJ\New folder\Database6.mdb")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDbCommand("select MEDICINE_ID,QUANTITY,UNIT_PRICE,PURCHASE_DATE,PAYMENT_METHOD from PURCHASE where MEDICINE_ID like '%" + TextBox1.Text + "%'", con)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        PURCHASEDataGridView.DataSource = dt
        PURCHASEDataGridView.Columns(0).HeaderText = "MEDICINE_ID"
        PURCHASEDataGridView.Columns(1).HeaderText = "MEDICINE_NAME"
        PURCHASEDataGridView.Columns(2).HeaderText = "QUANTITY"
        PURCHASEDataGridView.Columns(3).HeaderText = "UNIT_PRICE"
        PURCHASEDataGridView.Columns(4).HeaderText = "PURCHASE_DATE"
        PURCHASEDataGridView.Columns(5).HeaderText = "PAYMENT_METHOD"
        PURCHASEDataGridView.Columns(6).HeaderText = "TOTAL"
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (RadioButton1.Checked) Then
            PAYMENT_METHODTextBox.Text = "CASH"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (RadioButton2.Checked) Then
            PAYMENT_METHODTextBox.Text = "DEBIT CARD"
            DEBIT_CARD.Show()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (RadioButton3.Checked) Then
            PAYMENT_METHODTextBox.Text = "UPI"
            UPI.Show()
        End If
    End Sub

    Private Sub TOTALTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("ACCEPTS ONLY NUMBER")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TOTALTextBox.Text = Val(QUANTITYTextBox.Text) * Val(UNIT_PRICETextBox.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\PROJ\New folder\Database6.mdb")
        conn.Open()
        Dim strsql As String
        strsql = "select MEDICINE_ID,MEDICINE_NAME,UNIT_PRICE from Table1 where MEDICINE_NAME='" + MEDICINE_NAMEComboBox.Text + "'"
        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        MEDICINE_IDTextBox.Text = myreader("MEDICINE_ID")
        MEDICINE_NAMEComboBox.Text = myreader("MEDICINE_NAME")
        UNIT_PRICETextBox.Text = myreader("UNIT_PRICE")

        conn.Close()


    End Sub
End Class