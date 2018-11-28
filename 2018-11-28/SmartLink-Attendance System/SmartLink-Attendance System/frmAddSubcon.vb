Imports System.Data.SqlClient
Public Class frmAddSubcon
    Private Sub frmAddSubcon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        dgvSubCon.Rows.Add(txtSCCode.Text, txtSCName.Text, txtWorkType.Text)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If dgvSubCon.Rows.Count = 0 Then

            Using Sqlcon As New SqlConnection(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/connString.txt"))
                ' Using sqlCon As New SqlConnection("Data Source=DESKTOP-R5E7QB7;Initial Catalog=sls_iFaceDB;Integrated Security=True;multipleactiveresultsets=true")
                Sqlcon.Open()
                Dim SqlTrans As SqlTransaction = Sqlcon.BeginTransaction()
                Using cmd As SqlCommand = Sqlcon.CreateCommand()
                    cmd.Connection = Sqlcon
                    cmd.Transaction = SqlTrans
                    Try
                        'Insert into tProject
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "INSERT INTO tSubCon(subconID,subconName,remark,createBy,createDate,createAt)
                                       VALUES (@subconID,@subconName,@remark,@createBy,@createDate,@createAt)"

                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@subconID", txtSCCode.Text)
                        cmd.Parameters.AddWithValue("@subconName", txtSCName.Text)
                        cmd.Parameters.AddWithValue("@remark", txtRemark.Text)
                        cmd.Parameters.AddWithValue("@createBy", "CALVIN")
                        cmd.Parameters.AddWithValue("@createDate", DateTime.Now)
                        cmd.Parameters.AddWithValue("@createAt", Environment.MachineName)
                        cmd.ExecuteNonQuery()

                        'Insert into tProjectDet


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
                            adaptor.Fill(ds, "Project")
                            frmMasterData.dgvSC.DataSource = ds.Tables("Project")
                            ' dgvPersonell.Columns(6).Visible = False
                        Catch ex As Exception
                            MsgBox("Error when trying to populate Personnel DGV")
                            saveError(ex.ToString())
                        End Try
                    Catch ex As SqlException
                        SqlTrans.Rollback()
                        MsgBox(ex.Message.ToString())
                    End Try
                End Using
            End Using

        Else

            Using Sqlcon As New SqlConnection(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/connString.txt"))
                ' Using sqlCon As New SqlConnection("Data Source=DESKTOP-R5E7QB7;Initial Catalog=sls_iFaceDB;Integrated Security=True;multipleactiveresultsets=true")
                Sqlcon.Open()
                Dim SqlTrans As SqlTransaction = Sqlcon.BeginTransaction()
                Using cmd As SqlCommand = Sqlcon.CreateCommand()
                    cmd.Connection = Sqlcon
                    cmd.Transaction = SqlTrans
                    Try
                        'Insert into tProject
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "INSERT INTO tSubCon(subconID,subconName,remark,createBy,createDate,createAt)
                                       VALUES (@subconID,@subconName,@remark,@createBy,@createDate,@createAt)"

                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@subconID", txtSCCode.Text)
                        cmd.Parameters.AddWithValue("@subconName", txtSCName.Text)
                        cmd.Parameters.AddWithValue("@remark", txtRemark.Text)
                        cmd.Parameters.AddWithValue("@createBy", "CALVIN")
                        cmd.Parameters.AddWithValue("@createDate", DateTime.Now)
                        cmd.Parameters.AddWithValue("@createAt", Environment.MachineName)
                        cmd.ExecuteNonQuery()

                        'Insert into tProjectDet

                        For i As Integer = 0 To dgvSubCon.RowCount - 1
                            cmd.CommandType = CommandType.Text
                            cmd.CommandText = "
                                          INSERT INTO tSCDet VALUES (@subconID,@subconName,@workType)
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
                            adaptor.Fill(ds, "Project")
                            frmMasterData.dgvSC.DataSource = ds.Tables("Project")
                            ' dgvPersonell.Columns(6).Visible = False
                        Catch ex As Exception
                            MsgBox("Error when trying to populate Personnel DGV")
                            saveError(ex.ToString())
                        End Try
                    Catch ex As SqlException
                        SqlTrans.Rollback()
                        MsgBox(ex.Message.ToString())
                    End Try
                End Using
            End Using
        End If


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtSCCode.Text = "" Then
            MsgBox("Please fill the Project Code")
            txtSCCode.Select()
        ElseIf txtSCName.Text = "" Then
            MsgBox("Please fill the Project Name")
            txtSCName.Select()
        Else
            TabControl1.SelectedTab = proDet
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class