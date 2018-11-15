Imports System.Data.SqlClient
Public Class frmAddGroup
    Private Sub frmAddGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDGVAccess()
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using sqlCon As New SqlConnection(connReader)
            sqlCon.Open()
            Dim SqlTrans As SqlTransaction = sqlCon.BeginTransaction()
            Using cmd As SqlCommand = sqlCon.CreateCommand()
                cmd.Connection = sqlCon
                cmd.Transaction = SqlTrans
                Try
                    Try

                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "INSERT INTO tGroup(groupID, groupName, createBy, createDate, createAt) VALUES (@groupID,@groupName,@createBy,@createDate,@createAt)"
                        cmd.Parameters.AddWithValue("@groupID", txtGroupID.Text)
                        cmd.Parameters.AddWithValue("@groupName", txtGroupName.Text)
                        cmd.Parameters.AddWithValue("@createBy", _globalUserName)
                        cmd.Parameters.AddWithValue("@createDate", DateTime.Now())
                        cmd.Parameters.AddWithValue("createAt", Environment.MachineName())
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
                        MsgBox("Successfully Inserted")
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