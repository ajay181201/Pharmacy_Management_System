Public Class UPI

    Private Sub UPIBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPIBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UPIBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database6DataSet5)

    End Sub

    Private Sub UPI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet5.UPI' table. You can move, or remove it, as needed.
        Me.UPITableAdapter.Fill(Me.Database6DataSet5.UPI)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UPIBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            UPIBindingSource.EndEdit()
            UPITableAdapter.Update(Database6DataSet5.UPI)
            MessageBox.Show("DATA SAVED")
        Catch ex As Exception
            MessageBox.Show("ERROR OCCURED WHILE SAVING DATA")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        UPIBindingSource.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class