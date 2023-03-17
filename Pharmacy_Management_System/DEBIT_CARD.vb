Public Class DEBIT_CARD

    Private Sub DEBIT_CARDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEBIT_CARDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DEBIT_CARDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database6DataSet4)

    End Sub

    Private Sub DEBIT_CARD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet4.DEBIT_CARD' table. You can move, or remove it, as needed.
        Me.DEBIT_CARDTableAdapter.Fill(Me.Database6DataSet4.DEBIT_CARD)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DEBIT_CARDBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            DEBIT_CARDBindingSource.EndEdit()
            DEBIT_CARDTableAdapter.Update(Database6DataSet4.DEBIT_CARD)
            MessageBox.Show("DATA SAVED")
        Catch ex As Exception
            MessageBox.Show("ERROR OCCURED WHILE SAVING DATA")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DEBIT_CARDBindingSource.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub CARD_NUMBERTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CARD_NUMBERTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("ACCEPTS ONLY NUMBER")
        End If
    End Sub

    Private Sub MMTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MMTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("ACCEPTS ONLY NUMBER")
        End If
    End Sub

    Private Sub YYTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles YYTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("ACCEPTS ONLY NUMBER")
        End If
    End Sub

    Private Sub CVVTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CVVTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("ACCEPTS ONLY NUMBER")
        End If
    End Sub
End Class