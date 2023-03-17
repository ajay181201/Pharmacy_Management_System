Imports System.Data.OleDb
Public Class EMP

    Private Sub EMPLOYEEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPLOYEEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMPLOYEEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database6DataSet)

    End Sub

    Private Sub EMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.EMPLOYEETableAdapter.Fill(Me.Database6DataSet.EMPLOYEE)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EMPLOYEEBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        EMP_REPORT.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            EMPLOYEEBindingSource.EndEdit()
            EMPLOYEETableAdapter.Update(Database6DataSet.EMPLOYEE)
            MessageBox.Show("DATA SAVED")
        Catch ex As Exception
            MessageBox.Show("ERROR OCCURED WHILE SAVING DATA")
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        EMPLOYEEBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\PROJ\New folder\Database6.mdb")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDbCommand("select EMPLOYEE_ID,EMPLOYEE_NAME,SALARY,EMAIL_ID,DESIGNATION,DOB,ADDRESS,PINCODE,MOBILE_NO from EMPLOYEE where EMPLOYEE_NAME like '%" + TextBox1.Text + "%'", con)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        EMPLOYEEDataGridView.DataSource = dt
        EMPLOYEEDataGridView.Columns(0).HeaderText = "EMPLOYEE_ID"
        EMPLOYEEDataGridView.Columns(1).HeaderText = "EMPLOYEE_NAME"
        EMPLOYEEDataGridView.Columns(2).HeaderText = "SALARY"
        EMPLOYEEDataGridView.Columns(3).HeaderText = "EMAIL_ID"
        EMPLOYEEDataGridView.Columns(4).HeaderText = "DESIGNATION"
        EMPLOYEEDataGridView.Columns(5).HeaderText = "DOB"
        EMPLOYEEDataGridView.Columns(6).HeaderText = "ADDRESS"
        EMPLOYEEDataGridView.Columns(7).HeaderText = "PINCODE"
        EMPLOYEEDataGridView.Columns(8).HeaderText = "MOBILE_NO"
    End Sub

    Private Sub SALARYTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SALARYTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("ACCEPTS ONLY NUMBER")
        End If
    End Sub

    Private Sub PINCODETextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PINCODETextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("ACCEPTS ONLY NUMBER")
        End If
    End Sub

    Private Sub MOBILE_NOTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MOBILE_NOTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("ACCEPTS ONLY NUMBER")
        End If
    End Sub
End Class