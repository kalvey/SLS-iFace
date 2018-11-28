Imports System.Data.SqlClient
Public Class frmEditUG
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub ShowDGVAccess()
        Try
            openConnection()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("SELECT description Description, formName FROM taccess ORDER BY description ASC", conn)
            da.Fill(ds, "taccess")
            dgvAccess.DataSource = ds.Tables("taccess")
            dgvAccess.Columns(2).Visible = False
            Dim dgvColumn As DataGridViewColumn = dgvAccess.Columns(1)

            dgvColumn.Width = 250
            dgvAccess.Columns(0).Width = 25
        Catch ex As Exception
            MsgBox("Error")
            saveError(ex.ToString())
        End Try
    End Sub
    Sub compare()
        Dim index = frmMasterData.dgvUserGroup.CurrentCell.RowIndex
        Dim groupId As String
        groupId = frmMasterData.dgvUserGroup.Rows(index).Cells(0).Value.ToString()

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter("SELECT formName FROM tgroupaccess WHERE groupId = '" + groupId + "'", conn)

        da.Fill(ds, "tgroupaccess")
        dgvHidden.DataSource = ds.Tables("tgroupaccess")

        For i As Integer = 0 To dgvHidden.RowCount - 1
            For j As Integer = 0 To dgvAccess.RowCount - 1
                If dgvHidden.Rows(i).Cells(0).Value = dgvAccess.Rows(j).Cells(2).Value Then
                    dgvAccess.Rows(j).Cells(0).Value = True
                End If
            Next
        Next
    End Sub
    Private Sub frmEditUG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDGVAccess()
        compare()
    End Sub
    Sub showGroup()
        Try
            openConnection()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("SELECT groupID 'Group ID', groupName 'Group Name', createBy 'Created By', createDate ' Created Date', createAt 'Created At', updateBy 'Updated By', updateDate 'Updated Date', updateAt 'Updated At' FROM tGroup", conn)
            da.Fill(ds, "taccess")
            frmMasterData.dgvUserGroup.DataSource = ds.Tables("taccess")
        Catch ex As Exception
            MsgBox("Error")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using sqlCon As New SqlConnection(connReader)
            sqlCon.Open()
            Dim SqlTrans As SqlTransaction = sqlCon.BeginTransaction()
            Using cmd As SqlCommand = sqlCon.CreateCommand()
                cmd.Connection = sqlCon
                cmd.Transaction = SqlTrans
                Try
                    Try
                        cmd.Parameters.Clear()
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "DELETE FROM tGroupAccess WHERE groupID = @groupID"
                        cmd.Parameters.AddWithValue("@groupID", txtGroupID.Text)
                        cmd.ExecuteNonQuery()

                        cmd.Parameters.Clear()
                        cmd.CommandText = "UPDATE tGroup SET updateBy = @updateBy, updateDate = @updateDate, updateAt = @updateAt WHERE groupID = @groupID"
                        cmd.Parameters.AddWithValue("@updateBy", _globalUserName)
                        cmd.Parameters.AddWithValue("@updateDate", DateTime.Now())
                        cmd.Parameters.AddWithValue("@updateAt", Environment.MachineName())
                        cmd.Parameters.AddWithValue("@groupID", txtGroupID.Text)
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "INSERT INTO tGroupAccess(groupID, system, formName, createdBy, createdDate, createAt)
                                           VALUES(@groupID, @system, @formName, @createdBy, @createdDate,@createAt)"

                        For i As Integer = 0 To dgvAccess.Rows.Count - 1

                            If CBool(Me.dgvAccess.Rows(i).Cells(0).Value) = True Then
                                cmd.Parameters.Clear()
                                cmd.Parameters.AddWithValue("@groupID", txtGroupID.Text)
                                cmd.Parameters.AddWithValue("@system", "SMARTLINK-ATTENDANCE")
                                cmd.Parameters.AddWithValue("@formName", dgvAccess.Rows(i).Cells(2).Value.ToString)
                                cmd.Parameters.AddWithValue("@createdBy", _globalUserName)
                                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now())
                                cmd.Parameters.AddWithValue("@createAt", Environment.MachineName())
                                cmd.ExecuteNonQuery()
                            End If
                        Next

                        SqlTrans.Commit()
                        MsgBox("Successfully Edited")
                        showGroup()
                        Me.Close()
                    Catch ex As Exception
                        SqlTrans.Rollback()
                        MsgBox(ex.Message.ToString())
                        saveError(ex.ToString())
                    End Try

                Catch ex1 As Exception
                    saveError(ex1.ToString())
                End Try
            End Using
        End Using
    End Sub
End Class