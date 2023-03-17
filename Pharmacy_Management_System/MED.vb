Imports System.Data.OleDb
Public Class MED

    Private Sub MEDICINEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEDICINEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MEDICINEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database6DataSet1)

    End Sub

    Private Sub MED_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet1.MEDICINE' table. You can move, or remove it, as needed.
        Me.MEDICINETableAdapter.Fill(Me.Database6DataSet1.MEDICINE)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MEDICINEBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MED_REPORT.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            MEDICINEBindingSource.EndEdit()
            MEDICINETableAdapter.Update(Database6DataSet1.MEDICINE)
            MessageBox.Show("DATA SAVED")
        Catch ex As Exception
            MessageBox.Show("ERROR OCCURED WHILE SAVING DATA")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MEDICINEBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\PROJ\New folder\Database6.mdb")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDbCommand("select MEDICINE_ID,MEDICINE_NAME,MEDICINE_TYPE,MEDICINE_PRICE,MEDICINE_WEIGHT,MANF_DATE,EXP_DATE from MEDICINE where MEDICINE_NAME like '%" + TextBox1.Text + "%'", con)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        MEDICINEDataGridView.DataSource = dt
        MEDICINEDataGridView.Columns(0).HeaderText = "MEDICINE_ID"
        MEDICINEDataGridView.Columns(1).HeaderText = "MEDICINE_NAME"
        MEDICINEDataGridView.Columns(2).HeaderText = "MEDICINE_TYPE"
        MEDICINEDataGridView.Columns(3).HeaderText = "MEDICINE_PRICE"
        MEDICINEDataGridView.Columns(4).HeaderText = "MEDICINE_WEIGHT"
        MEDICINEDataGridView.Columns(5).HeaderText = "MANF_DATE"
        MEDICINEDataGridView.Columns(6).HeaderText = "EXP_DATE"
    End Sub
End Class