Public Class MED_REPORT

    Private Sub MED_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database6DataSet1.MEDICINE' table. You can move, or remove it, as needed.
        Me.MEDICINETableAdapter.Fill(Me.Database6DataSet1.MEDICINE)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class