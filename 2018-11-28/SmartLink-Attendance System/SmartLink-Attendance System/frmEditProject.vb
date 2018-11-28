Imports System.Data.SqlClient

Public Class frmEditProject
    Dim ds As New DataSet
    Public index1 As Integer
    Public ProjectCode As String
    Sub populatetxtSubCon()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT * FROM tSubCon", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            txtSubCon.DataSource = table2
            txtSubCon.ValueMember = "subconName"
            txtSubCon.DisplayMember = "subconName"
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        saveError(ex.ToString())
        End Try

    End Sub
    Private Sub frmEditProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
            " SELECT * FROM tProjectDet WHERE projectCode = '" & ProjectCode & "'", conn)
            adaptor.Fill(ds, "subCon")
            dgvSubCon.DataSource = ds.Tables("subCon")
            populatetxtSubCon()
        Catch ex As Exception
            MsgBox("Error when trying to populate Personnel DGV")
            saveError(ex.ToString())
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Using SqlCon As New SqlConnection(connReader)
                ' Using Sqlcon As New SqlConnection("Data Source=192.168.1.88\SQLEXPRESS;Initial Catalog=sls_iFaceDB;Persist Security Info=True;User ID=sa;Password=ptgiat1899;multipleactiveresultsets=true")

                '      Using sqlCon As New SqlConnection("Data Source=DESKTOP-R5E7QB7;Initial Catalog=sls_iFaceDB;Integrated Security=True;multipleactiveresultsets=true")
                SqlCon.Open()
                Dim SqlTrans As SqlTransaction = SqlCon.BeginTransaction()
                Using cmd As SqlCommand = SqlCon.CreateCommand()
                    cmd.Connection = SqlCon
                    cmd.Transaction = SqlTrans
                    Try
                        'Insert into tProject
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText =
                         "Update tProject Set [projectName] = @proName,
                         [planStart] = @planStart,
                         [planEnd] = @planEnd,
                         [remark] = @remark,
                         [updateBy] = @updateBy,
                         [updateDate] = @updateDate,
                         [updateAt] = @updateAt
                         WHERE projectCode = @proCode"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@proCode", txtProCode.Text)
                        cmd.Parameters.AddWithValue("@proName", txtProName.Text)
                        cmd.Parameters.AddWithValue("@planStart", dtpStart.Value)
                        cmd.Parameters.AddWithValue("@planEnd", dtpEnd.Value)
                        cmd.Parameters.AddWithValue("@remark", txtRemark.Text)
                        cmd.Parameters.AddWithValue("@updateBy", "CALVIN")
                        cmd.Parameters.AddWithValue("@updateDate", DateTime.Now)
                        cmd.Parameters.AddWithValue("@updateAt", Environment.MachineName)
                        cmd.ExecuteNonQuery()

                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "DELETE FROM tProjectDet WHERE projectCode = '" & txtProCode.Text & "'"
                        cmd.ExecuteNonQuery()

                        'Insert into tProjectDet

                        For i As Integer = 0 To dgvSubCon.RowCount - 1
                            cmd.CommandType = CommandType.Text
                            cmd.CommandText = "
                                          INSERT INTO tProjectDet(projectCode, projectName, subCont, workType, projectPIC)
                                          VALUES(@proCode,@proName,@subCon,@workType,@projectPIC)
                                          "
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@proCode", dgvSubCon.Rows(i).Cells(0).Value.ToString)
                            cmd.Parameters.AddWithValue("@proName", dgvSubCon.Rows(i).Cells(1).Value.ToString)
                            cmd.Parameters.AddWithValue("@subCon", dgvSubCon.Rows(i).Cells(2).Value.ToString)
                            cmd.Parameters.AddWithValue("@workType", dgvSubCon.Rows(i).Cells(3).Value.ToString)
                            cmd.Parameters.AddWithValue("@projectPIC", dgvSubCon.Rows(i).Cells(4).Value.ToString)
                            cmd.ExecuteNonQuery()
                        Next


                        SqlTrans.Commit()
                        MsgBox("Successfully Added to Database")

                    Catch ex As SqlException
                        SqlTrans.Rollback()
                        MessageBox.Show(ex.ToString())
                        saveError(ex.ToString())
                    End Try
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        Dim newRow As DataRow

        newRow = ds.Tables(0).NewRow
        newRow.Item(0) = txtProCode.Text
        newRow.Item(1) = txtProName.Text
        newRow.Item(2) = txtSubCon.Text
        newRow.Item(3) = txtWorkType.Text
        newRow.Item(4) = txtSubPIC.Text
        ds.Tables(0).Rows.Add(newRow)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub

    Private Sub txtSubCon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSubCon.SelectedIndexChanged
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT workType FROM tSCdet WHERE subconName = '" & txtSubCon.Text & "'", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            txtWorkType.DataSource = table2
            txtWorkType.ValueMember = "workType"
            txtWorkType.DisplayMember = "workType"
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        saveError(ex.ToString())
        End Try
    End Sub
End Class