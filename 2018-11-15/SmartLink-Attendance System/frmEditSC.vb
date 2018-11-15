Imports System.Data.SqlClient
Public Class frmEditSC
    Dim ds As New DataSet
    Private Sub frmEditSC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim index = frmMasterData.dgvSC.CurrentCell.RowIndex
            openConnection()
            Dim adaptor As New SqlDataAdapter(
            " SELECT * FROM tSCdet WHERE subconID = '" & frmMasterData.dgvSC.Rows(index).Cells(0).Value & "'", conn)
            '   Dim ds As New DataSet
            adaptor.Fill(ds, "subCon")
            dgvSubCon.DataSource = ds.Tables("subCon")
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Using sqlCon As New SqlConnection(connReader)
                '  Using Sqlcon As New SqlConnection("Data Source=192.168.1.88\SQLEXPRESS;Initial Catalog=sls_iFaceDB;Persist Security Info=True;User ID=sa;Password=ptgiat1899;multipleactiveresultsets=true")
                '     Using sqlCon As New SqlConnection("Data Source=DESKTOP-R5E7QB7;Initial Catalog=sls_iFaceDB;Integrated Security=True;multipleactiveresultsets=true")
                sqlCon.Open()
                Dim SqlTrans As SqlTransaction = sqlCon.BeginTransaction()
                Using cmd As SqlCommand = sqlCon.CreateCommand()
                    cmd.Connection = sqlCon
                    cmd.Transaction = SqlTrans
                    Try


                        'Insert into tProject
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText =
                         "Update tSubCon Set [subconName] = @scName,
                         [remark] = @remark,
                         [updateBy] = @updateBy,
                         [updateDate] = @updateDate,
                         [updateAt] = @updateAt
                         WHERE subconID = @scID"

                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@scID", txtSCCode.Text)
                        cmd.Parameters.AddWithValue("@scName", txtSCName.Text)
                        cmd.Parameters.AddWithValue("@remark", txtRemark.Text)
                        cmd.Parameters.AddWithValue("@updateBy", "CALVIN")
                        cmd.Parameters.AddWithValue("@updateDate", DateTime.Now)
                        cmd.Parameters.AddWithValue("@updateAt", Environment.MachineName)
                        cmd.ExecuteNonQuery()

                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "DELETE FROM tSCDet WHERE subconID = '" & txtSCCode.Text & "'"
                        cmd.ExecuteNonQuery()

                        'Insert into tProjectDet

                        For i As Integer = 0 To dgvSubCon.RowCount - 1
                            cmd.CommandType = CommandType.Text
                            cmd.CommandText = "
                                          INSERT INTO tSCdet(subconID, subconName, workType)
                                          VALUES(@subconID, @subconName, @workType)
                                          "
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@subconID", dgvSubCon.Rows(i).Cells(0).Value.ToString)
                            cmd.Parameters.AddWithValue("@subconName", dgvSubCon.Rows(i).Cells(1).Value.ToString)
                            cmd.Parameters.AddWithValue("@workType", dgvSubCon.Rows(i).Cells(2).Value.ToString)

                            cmd.ExecuteNonQuery()
                        Next


                        SqlTrans.Commit()
                        MsgBox("Successfully Added to Database")
                        Me.Close()
                        Try
                            openConnection()
                            Dim adaptor As New SqlDataAdapter(
                            "	      
                          SELECT subconID 'Subcon ID', subconName 'Subcon Name', remark 'Remark'
                          FROM tSubcon
                            ", conn)
                            Dim ds As New DataSet
                            adaptor.Fill(ds, "subCon")
                            frmMasterData.dgvSC.DataSource = ds.Tables("subCon")
                            ' dgvPersonell.Columns(6).Visible = False
                        Catch ex As Exception
                            MsgBox("Error when trying to populate subCon DGV")
                            saveError(ex.ToString())
                        End Try
                    Catch ex As SqlException
                        SqlTrans.Rollback()
                        MsgBox(ex.Message.ToString())
                        saveError(ex.ToString())
                    End Try
                End Using
            End Using



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        Dim newRow As DataRow

        newRow = ds.Tables(0).NewRow
        newRow.Item(0) = txtSCCode.Text
        newRow.Item(1) = txtSCName.Text
        newRow.Item(2) = txtWorkType.Text

        ds.Tables(0).Rows.Add(newRow)
    End Sub
End Class