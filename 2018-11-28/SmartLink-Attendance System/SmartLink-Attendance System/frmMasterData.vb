Imports System.Data.SqlClient

Public Class frmMasterData
    Public dss As New DataSet
    Sub showLogin()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
            "

	         SELECT userId 'User ID', username 'Name', status 'Status', createdBy 'Created By',
             createdDate 'Created Date', createdAt 'Created At', updateBy 'Update By', updateDate 'Update Date',
             updateAt 'Update At' FROM tUser

            ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "userLogin")
            dgvUserLogin.DataSource = ds.Tables("userLogin")
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox("Error when trying to populate userLogin DGV")
            saveError(ex.ToString())
        End Try
    End Sub
    Sub populateComboboxSC()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT * FROM tSubCon", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            cbbBySubcon.DataSource = table2
            cbbBySubcon.ValueMember = "subconName"
            cbbBySubcon.DisplayMember = "subconName"
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub
    Sub showEmployee()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
            "

	       
           SELECT employeeNo 'Employee Number', employeeName 'Employee Name',
	        identityNo 'Identity Number', employeeType 'Employee Type', departmentName 'Department Name', 
			section 'Section', position 'Postiion', tUserExternal.subcon 'Subcon',
	        TelpNo 'Telephone Number', txtAddr 'Address',contractStartDate 
	        'Contract Start Date', contractEndDate 'Contract End Date', 
	        [status] 'Status' FROM tDeviceUser2 LEFT JOIN tUserExternal ON tUserExternal.userId = tDeviceUser2.userId

            ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "devUser")
            dgvMasterEMP.DataSource = ds.Tables("devUser")
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox("Error when trying to populate Personnel DGV")
            saveError(ex.ToString())
        End Try
    End Sub
    Sub showProject()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
            "	      
          SELECT projectCode 'Project Code', projectName 'Project Name', planStart 'Project Plan Start Date',
          planEnd 'Project Plan End Date', [status] 'Status', remark 'Remark'
          FROM tProject
            ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Project")
            dgvMasterPRJ.DataSource = ds.Tables("Project")
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox("Error when trying to populate Personnel DGV")
            saveError(ex.ToString())
        End Try
    End Sub
    Sub showSubcon()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
            " SELECT subconID 'Subcon ID', subconName 'Subcon Name', remark 'Remark' FROM tSubcon", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Project")
            dgvSC.DataSource = ds.Tables("Project")
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox("Error when trying to populate Personnel DGV")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub frmMasterData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showEmployee()
        showProject()
        showSubcon()
        showLogin()
        showGroup()
        populateComboboxSC()
    End Sub

    Private Sub btnCloseEmployee_Click(sender As Object, e As EventArgs) Handles btnCloseEmployee.Click
        Me.Close()
    End Sub

    Private Sub btnClosePRJ_Click(sender As Object, e As EventArgs) Handles btnClosePRJ.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddProject.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim index As Integer = dgvMasterPRJ.CurrentCell.RowIndex

            frmEditProject.txtProCode.Text = dgvMasterPRJ.Rows(index).Cells(0).Value
            frmEditProject.txtProName.Text = dgvMasterPRJ.Rows(index).Cells(1).Value
            frmEditProject.dtpStart.Value = dgvMasterPRJ.Rows(index).Cells(2).Value
            frmEditProject.dtpEnd.Value = dgvMasterPRJ.Rows(index).Cells(3).Value
            frmEditProject.txtRemark.Text = dgvMasterPRJ.Rows(index).Cells(4).Value
            frmEditProject.index1 = index
            frmEditProject.ProjectCode = dgvMasterPRJ.Rows(index).Cells(0).Value
            frmEditProject.Show()
        Catch ex As Exception
            MsgBox("Error Happened When trying to click btnEdit")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result1 As DialogResult = MessageBox.Show("You are about to delete this Project. Are you sure?",
                                                      "Important Question",
                                                      MessageBoxButtons.YesNo)
        If result1 = DialogResult.Yes Then
            Try
                Dim index As Integer = dgvMasterPRJ.CurrentCell.RowIndex
                '     Using Sqlcon As New SqlConnection("Data Source=192.168.1.88\SQLEXPRESS;Initial Catalog=sls_iFaceDB;Persist Security Info=True;User ID=sa;Password=ptgiat1899;multipleactiveresultsets=true")
                Using sqlCon As New SqlConnection(connReader)
                    sqlCon.Open()
                    Dim SqlTrans As SqlTransaction = sqlCon.BeginTransaction()
                    Using cmd As SqlCommand = sqlCon.CreateCommand()
                        cmd.Connection = sqlCon
                        cmd.Transaction = SqlTrans
                        Try
                            Try

                                cmd.CommandType = CommandType.Text
                                cmd.CommandText = "DELETE FROM tProject WHERE projectCode = '" & dgvMasterPRJ.Rows(index).Cells(0).Value.ToString & "'"
                                cmd.ExecuteNonQuery()

                                cmd.CommandText = "DELETE FROM tProjectDet WHERE projectCode = '" & dgvMasterPRJ.Rows(index).Cells(0).Value.ToString() & "'"
                                cmd.ExecuteNonQuery()

                                SqlTrans.Commit()
                                MsgBox("Successfully Deleted")
                                showProject()
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


            Catch ex As Exception
                MsgBox("Error when trying to delete data")
                saveError(ex.ToString())
            End Try
        Else
        End If
    End Sub

    Private Sub btnEMPtoPRJ_Click(sender As Object, e As EventArgs) Handles btnEMPtoPRJ.Click
        Dim index As Integer = dgvMasterPRJ.CurrentCell.RowIndex
        frmEMPtoPRJ.lblSubCon.Text = dgvMasterPRJ.Rows(index).Cells(1).Value
        frmEMPtoPRJ.tsProjectCode.Text = dgvMasterPRJ.Rows(index).Cells(0).Value
        frmEMPtoPRJ.tsProjectName.Text = dgvMasterPRJ.Rows(index).Cells(1).Value
        frmEMPtoPRJ.Show()
    End Sub

    Private Sub btnDelSC_Click(sender As Object, e As EventArgs) Handles btnDelSC.Click
        Dim result1 As DialogResult = MessageBox.Show("You are about to delete this Subcon. Are you sure?",
                                                      "Important Question",
                                                      MessageBoxButtons.YesNo)
        If result1 = DialogResult.Yes Then
            Try
                Dim index As Integer = dgvSC.CurrentCell.RowIndex
                '         Using Sqlcon As New SqlConnection("Data Source=192.168.1.88\SQLEXPRESS;Initial Catalog=sls_iFaceDB;Persist Security Info=True;User ID=sa;Password=ptgiat1899;multipleactiveresultsets=true")
                Using sqlCon As New SqlConnection(connReader)
                    sqlCon.Open()
                    Dim SqlTrans As SqlTransaction = sqlCon.BeginTransaction()
                    Using cmd As SqlCommand = sqlCon.CreateCommand()
                        cmd.Connection = sqlCon
                        cmd.Transaction = SqlTrans
                        Try
                            Try

                                cmd.CommandType = CommandType.Text
                                cmd.CommandText = "DELETE FROM tSCdet WHERE subconID = '" & dgvSC.Rows(index).Cells(0).Value.ToString & "'"
                                cmd.ExecuteNonQuery()

                                cmd.CommandText = "DELETE FROM tSubcon WHERE subconID = '" & dgvSC.Rows(index).Cells(0).Value.ToString() & "'"
                                cmd.ExecuteNonQuery()

                                SqlTrans.Commit()
                                MsgBox("Successfully Deleted")
                                showSubcon()
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
            Catch ex As Exception
                MsgBox("Error when trying to delete data")
                saveError(ex.ToString())
            End Try
        Else

        End If

    End Sub

    Private Sub btnAddSC_Click(sender As Object, e As EventArgs) Handles btnAddSC.Click
        frmAddSubcon.Show()
    End Sub

    Private Sub btnEditSC_Click(sender As Object, e As EventArgs) Handles btnEditSC.Click
        Try
            Dim index As Integer = dgvSC.CurrentCell.RowIndex

            frmEditSC.txtSCCode.Text = dgvSC.Rows(index).Cells(0).Value.ToString
            frmEditSC.txtSCName.Text = dgvSC.Rows(index).Cells(1).Value.ToString
            frmEditSC.txtRemark.Text = dgvSC.Rows(index).Cells(2).Value.ToString
            frmEditSC.Show()
        Catch ex As Exception
            MsgBox("Error Happened When trying to click btnEdit")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearchEMP_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEMP.TextChanged

    End Sub

    Private Sub txtSearchEMP_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchEMP.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearchEMP.Text = "" Then
                showEmployee()
            Else
                Try
                    openConnection()
                    Dim adaptor As New SqlDataAdapter(
                    "

	        SELECT employeeNo 'Employee Number', employeeName 'Employee Name',
	        identityNo 'Identity Number', employeeType 'Employee Type', departmentName 'Department Name', 
			section 'Section', position 'Postiion', tUserExternal.subcon 'Subcon',
	        TelpNo 'Telephone Number', txtAddr 'Address',contractStartDate 
	        'Contract Start Date', contractEndDate 'Contract End Date', 
	        [status] 'Status' FROM tDeviceUser2 LEFT JOIN tUserExternal ON tUserExternal.userId = tDeviceUser2.userId
            WHERE
            employeeNo LIKE '%" & txtSearchEMP.Text & "%" & "' or 
            employeeName LIKE '%" & txtSearchEMP.Text & "%" & "' or 
            identityNo LIKE '%" & txtSearchEMP.Text & "%" & "' or 
            employeeType LIKE '%" & txtSearchEMP.Text & "%" & "' or 
            departmentName LIKE '%" & txtSearchEMP.Text & "%" & "' or 
            TelpNo LIKE '%" & txtSearchEMP.Text & "%" & "' or 
            txtAddr LIKE '%" & txtSearchEMP.Text & "%" & "' or 
            contractStartDate LIKE '%" & txtSearchEMP.Text & "%" & "' or 
            contractEndDate LIKE '%" & txtSearchEMP.Text & "%" & "'

            ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "devUser")
                    dgvMasterEMP.DataSource = ds.Tables("devUser")
                    ' dgvPersonell.Columns(6).Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString())
                    saveError(ex.ToString())
                End Try
            End If
        End If
    End Sub

    Private Sub txtSearchPRJ_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPRJ.TextChanged

    End Sub

    Private Sub txtSearchPRJ_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchPRJ.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearchPRJ.Text = "" Then
                showProject()
            Else
                Try
                    openConnection()
                    Dim adaptor As New SqlDataAdapter(
                    "	      
          SELECT projectCode 'Project Code', projectName 'Project Name', planStart 'Project Plan Start Date',
          planEnd 'Project Plan End Date', [status] 'Status', remark 'Remark'
          FROM tProject
                      WHERE
            projectCode LIKE '%" & txtSearchPRJ.Text & "%" & "' or 
            projectName LIKE '%" & txtSearchPRJ.Text & "%" & "' or 
            planStart LIKE '%" & txtSearchPRJ.Text & "%" & "' or 
            planEnd LIKE '%" & txtSearchPRJ.Text & "%" & "' or 
            status LIKE '%" & txtSearchPRJ.Text & "%" & "' or 
            remark LIKE '%" & txtSearchPRJ.Text & "%" & "'
            ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Project")
                    dgvMasterPRJ.DataSource = ds.Tables("Project")
                    ' dgvPersonell.Columns(6).Visible = False
                Catch ex As Exception
                    MsgBox("Error when trying to populate Personnel DGV")
                    saveError(ex.ToString())
                End Try
            End If
        End If
    End Sub

    Private Sub txtSearchSC_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSC.TextChanged

    End Sub

    Private Sub txtSearchSC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchSC.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearchSC.Text = "" Then
                showSubcon()
            Else
                Try
                    openConnection()
                    Dim adaptor As New SqlDataAdapter(
                    "	      
                     SELECT subconID 'Subcon ID', subconName 'Subcon Name', remark 'Remark'
                     FROM tSubcon
                     WHERE
                     subconID LIKE '%" & txtSearchSC.Text & "%" & "' or 
                     subconName LIKE '%" & txtSearchSC.Text & "%" & "' or 
                     remark LIKE '%" & txtSearchSC.Text & "%" & "'
                    ", conn)

                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Project")
                    dgvSC.DataSource = ds.Tables("Project")
                    ' dgvPersonell.Columns(6).Visible = False
                Catch ex As Exception
                    MsgBox("Error when trying to populate Personnel DGV")
                    saveError(ex.ToString())
                End Try
            End If
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        frmBatchPS.Show()
    End Sub

    Private Sub btnCloseLogin_Click(sender As Object, e As EventArgs) Handles btnCloseLogin.Click
        Me.Close()
    End Sub

    Private Sub btnAddUserLogin_Click(sender As Object, e As EventArgs) Handles btnAddUserLogin.Click
        frmSoftUser.Show()
    End Sub

    Private Sub btnEditLogin_Click(sender As Object, e As EventArgs) Handles btnEditLogin.Click
        Dim index As Integer = dgvUserLogin.CurrentCell.RowIndex
        frmEditLogin.txtUserID.Text = dgvUserLogin.Rows(index).Cells(0).Value
        frmEditLogin.txtUsername.Text = dgvUserLogin.Rows(index).Cells(1).Value
        frmEditLogin.Show()
    End Sub
    Sub showGroup()
        Try
            openConnection()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("SELECT groupID 'Group ID', groupName 'Group Name', createBy 'Created By', createDate ' Created Date', createAt 'Created At', updateBy 'Updated By', updateDate 'Updated Date', updateAt 'Updated At' FROM tGroup", conn)
            da.Fill(ds, "taccess")
            dgvUserGroup.DataSource = ds.Tables("taccess")
        Catch ex As Exception
            MsgBox("Error")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub btnDelLogin_Click(sender As Object, e As EventArgs) Handles btnDelLogin.Click
        Dim result1 As DialogResult = MessageBox.Show("You are about to delete this user. Are you sure?",
                                                 "Important Question",
                                                 MessageBoxButtons.YesNo)
        If result1 = DialogResult.Yes Then
            Try
                Dim index As Integer = dgvUserLogin.CurrentCell.RowIndex
                '         Using Sqlcon As New SqlConnection("Data Source=192.168.1.88\SQLEXPRESS;Initial Catalog=sls_iFaceDB;Persist Security Info=True;User ID=sa;Password=ptgiat1899;multipleactiveresultsets=true")
                Using sqlCon As New SqlConnection(connReader)
                    sqlCon.Open()
                    Dim SqlTrans As SqlTransaction = sqlCon.BeginTransaction()
                    Using cmd As SqlCommand = sqlCon.CreateCommand()
                        cmd.Connection = sqlCon
                        cmd.Transaction = SqlTrans
                        Try
                            Try
                                cmd.CommandText = "DELETE FROM tUser WHERE userId = '" & dgvUserLogin.Rows(index).Cells(0).Value.ToString() & "'"
                                cmd.ExecuteNonQuery()

                                SqlTrans.Commit()
                                MsgBox("Successfully Deleted")
                                showLogin()
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
            Catch ex As Exception
                MsgBox("Error when trying to delete data")
                saveError(ex.ToString())
            End Try
        Else

        End If
    End Sub

    Private Sub frmAddGroup_Click(sender As Object, e As EventArgs) Handles btnAddGR.Click
        frmAddGroup.Show()
    End Sub

    Private Sub btnCloseUG_Click(sender As Object, e As EventArgs) Handles btnCloseUG.Click
        Me.Close()
    End Sub

    Private Sub btnEditUG_Click(sender As Object, e As EventArgs) Handles btnEditUG.Click
        Dim index = dgvUserGroup.CurrentCell.RowIndex
        frmEditUG.txtGroupID.Text = dgvUserGroup.Rows(index).Cells(0).Value.ToString
        frmEditUG.txtGroupName.Text = dgvUserGroup.Rows(index).Cells(1).Value.ToString
        frmEditUG.Show()
    End Sub

    Private Sub cbbBySubcon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbBySubcon.SelectedIndexChanged

    End Sub

    Private Sub cbbBySubcon_KeyDown(sender As Object, e As KeyEventArgs) Handles cbbBySubcon.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbbBySubcon.Text <> "" Then
                Try
                    openConnection()
                    Dim adaptor As New SqlDataAdapter(
                    "      
            SELECT employeeNo 'Employee Number', employeeName 'Employee Name',
	        identityNo 'Identity Number', employeeType 'Employee Type', departmentName 'Department Name', 
			section 'Section', position 'Postiion', tUserExternal.subcon 'Subcon',
	        TelpNo 'Telephone Number', txtAddr 'Address',contractStartDate 
	        'Contract Start Date', contractEndDate 'Contract End Date', 
	        [status] 'Status' FROM tDeviceUser2 LEFT JOIN tUserExternal ON tUserExternal.userId = tDeviceUser2.userId WHERE tUserExternal.subcon = '" & cbbBySubcon.Text & "'

            ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "devUser")
                    dgvMasterEMP.DataSource = ds.Tables("devUser")
                    ' dgvPersonell.Columns(6).Visible = False
                Catch ex As Exception
                    MsgBox("Error when trying to populate Personnel DGV")
                    saveError(ex.ToString())
                End Try
            Else
                showEmployee()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result1 As DialogResult = MessageBox.Show("You are about to delete this user. Are you sure?",
                                         "Important Question",
                                         MessageBoxButtons.YesNo)
        If result1 = DialogResult.Yes Then
            Try
                Dim index As Integer = dgvUserGroup.CurrentCell.RowIndex
                '         Using Sqlcon As New SqlConnection("Data Source=192.168.1.88\SQLEXPRESS;Initial Catalog=sls_iFaceDB;Persist Security Info=True;User ID=sa;Password=ptgiat1899;multipleactiveresultsets=true")
                Using sqlCon As New SqlConnection(connReader)
                    sqlCon.Open()
                    Dim SqlTrans As SqlTransaction = sqlCon.BeginTransaction()
                    Using cmd As SqlCommand = sqlCon.CreateCommand()
                        cmd.Connection = sqlCon
                        cmd.Transaction = SqlTrans
                        Try
                            Try
                                cmd.CommandText = "DELETE FROM tGroup WHERE GroupId = '" & dgvUserGroup.Rows(index).Cells(0).Value.ToString() & "'"
                                cmd.ExecuteNonQuery()

                                SqlTrans.Commit()
                                MsgBox("Successfully Deleted")
                                showGroup()
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
            Catch ex As Exception
                MsgBox("Error when trying to delete data")
                saveError(ex.ToString())
            End Try
        Else

        End If
    End Sub
End Class