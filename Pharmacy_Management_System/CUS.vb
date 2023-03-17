Imports System.Data.OleDb
Public Class CUS

    Private Sub CUSTOMERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CUSTOMERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database6DataSet2)

    End Sub

    Private Sub CUS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet2.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.Database6DataSet2.CUSTOMER)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CUSTOMERBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CUS_REPORT.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            CUSTOMERBindingSource.EndEdit()
            CUSTOMERTableAdapter.Update(Database6DataSet2.CUSTOMER)
            MessageBox.Show("DATA SAVED")
        Catch ex As Exception
            MessageBox.Show("ERROR OCCURED WHILE SAVING DATA")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CUSTOMERBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\PROJ\New folder\Database6.mdb")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New OleDbCommand("select CUSTOMER_ID,CUSTOMER_NAME,DOB,ADDRESS,PINCODE,MOBILE_NO from CUSTOMER where CUSTOMER_NAME like '%" + TextBox1.Text + "%'", con)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd
        dt.Clear()
        da.Fill(dt)
        CUSTOMERDataGridView.DataSource = dt
        CUSTOMERDataGridView.Columns(0).HeaderText = "CUSTOMER_ID"
        CUSTOMERDataGridView.Columns(1).HeaderText = "CUSTOMER_NAME"
        CUSTOMERDataGridView.Columns(2).HeaderText = "DOB"
        CUSTOMERDataGridView.Columns(3).HeaderText = "ADDRESS"
        CUSTOMERDataGridView.Columns(4).HeaderText = "PINCODE"
        CUSTOMERDataGridView.Columns(5).HeaderText = "MOBILE_NO"
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