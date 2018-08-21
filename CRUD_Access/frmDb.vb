Public Class frmDb
    Dim dbSelectPath As New ConnectionDB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPath.Click
        Dim strPath As String
        Dim openFD As New OpenFileDialog

        If openFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            strPath = openFD.FileName
            txtPath.Text = strPath
            dbSelectPath.DbPath() = txtPath.Text
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Try
            dbSelectPath.OpenCon()
            MessageBox.Show("connection succsessful")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbSelectPath.CloseCon()
        End Try
    End Sub
End Class