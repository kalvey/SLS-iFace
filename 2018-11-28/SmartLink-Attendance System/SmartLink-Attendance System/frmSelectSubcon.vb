Imports System.Data.SqlClient
Public Class frmSelectSubcon
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSelectSubcon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
            " SELECT subconID 'Subcon ID', subconName 'Subcon Name', remark 'Remark' FROM tSubcon", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Project")
            dgvSubcon.DataSource = ds.Tables("Project")
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox("Error when trying to populate Personnel DGV")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim index As Integer = dgvSubcon.CurrentCell.RowIndex
        frmPopupPersonell.txtType1.Text = dgvSubcon.Rows(index).Cells(1).Value.ToString()
        frmAddUser.txtType1.Text = dgvSubcon.Rows(index).Cells(1).Value.ToString()
        Me.Close()
    End Sub
End Class