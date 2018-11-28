Imports System.Data.SqlClient
Public Class frmEMPtoPRJ
    Dim projectCode, projectNmae As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub showEmployee()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
            "

	        SELECT employeeNo 'Employee Number', employeeName 'Employee Name',
	        identityNo 'Identity Number', employeeType 'Employee Type', 
	        departmentNo 'Department Number', departmentName 'Department Name',
	        TelpNo 'Telephone Number', txtAddr 'Address',contractStartDate 
	        'Contract Start Date', contractEndDate 'Contract End Date', 
	        [status] 'Status' FROM tDeviceUser2

            ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "devUser")
            dgvEMP.DataSource = ds.Tables("devUser")
            dgvEMP.Columns(0).Width = 20
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox("Error when trying to populate Personnel DGV")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub frmEMPtoPRJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showEmployee()
        populateSCcbb()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Try
            For i As Integer = 0 To dgvEMP.RowCount - 1
                If CBool(Me.dgvEMP.Rows(i).Cells(0).Value) = True Then


                    dgvEMPtoPRJ.Rows.Add(tsProjectCode.Text, tsProjectName.Text, cbbSubCon.SelectedValue, cbbSubCon.Text, dgvEMP.Rows(i).Cells(1).Value.ToString, dgvEMP.Rows(i).Cells(2).Value.ToString)

                End If
            Next
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Try
        openConnection()
        For i As Integer = 0 To dgvEMPtoPRJ.RowCount - 1
            Dim cmd As New SqlCommand(
            "INSERT INTO tProjectEMP(projectCode, projectName, subconID, subconName, employeeNo, employeeName)
                                          VALUES(@proCode,@proName,@subconID,@subconName,@employeeNo, @employeeName)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@proCode", dgvEMPtoPRJ.Rows(i).Cells(0).Value.ToString)
            cmd.Parameters.AddWithValue("@proName", dgvEMPtoPRJ.Rows(i).Cells(1).Value.ToString)
            cmd.Parameters.AddWithValue("@subconID", dgvEMPtoPRJ.Rows(i).Cells(2).Value.ToString)
            cmd.Parameters.AddWithValue("@subconName", dgvEMPtoPRJ.Rows(i).Cells(3).Value.ToString)
            cmd.Parameters.AddWithValue("@employeeNo", dgvEMPtoPRJ.Rows(i).Cells(4).Value.ToString)
            cmd.Parameters.AddWithValue("@employeeName", dgvEMPtoPRJ.Rows(i).Cells(5).Value.ToString)
            cmd.ExecuteNonQuery()
        Next
        MsgBox("Success!")
        Me.Close()
        'Catch ex As Exception
        '    MsgBox("Error!")
        '    saveError(ex.ToString)
        'End Try

    End Sub
    Sub SearchBySubcon()
        Try
            openConnection()
            If cbbSubCon.Text = "" Then

                showEmployee()
            Else
                'memload data dari tgroup sesuai dengan keyword yang di input user
                Dim command As New SqlCommand("SELECT employeeNo 'Employee Number', employeeName 'Employee Name',
	        identityNo 'Identity Number', employeeType 'Employee Type', 
	        departmentNo 'Department Number', departmentName 'Department Name', tUserExternal.subcon 'Subcon',
	        TelpNo 'Telephone Number', txtAddr 'Address',contractStartDate 
	        'Contract Start Date', contractEndDate 'Contract End Date', 
	        [status] 'Status' FROM tDeviceUser2 JOIN tUserExternal on tDeviceUser2.userId = tUserExternal.userId WHERE tUserExternal.subcon = '" & cbbSubCon.Text & "'", conn)

                Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
                Dim myDataSet As DataSet = New DataSet()
                myDA.Fill(myDataSet, "MyTable")
                dgvEMP.DataSource = myDataSet.Tables("MyTable").DefaultView
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub SearchData()
        Try
            openConnection()
            If txtSearch.Text = "" Then

                showEmployee()
            Else
                'memload data dari tgroup sesuai dengan keyword yang di input user
                Dim command As New SqlCommand("SELECT employeeNo 'Employee Number', employeeName 'Employee Name',
	        identityNo 'Identity Number', employeeType 'Employee Type', 
	        departmentNo 'Department Number', departmentName 'Department Name',
	        TelpNo 'Telephone Number', txtAddr 'Address',contractStartDate 
	        'Contract Start Date', contractEndDate 'Contract End Date', 
	        [status] 'Status' FROM tDeviceUser2 where userId LIKE '%" + txtSearch.Text + "%" + "' employeeNo Like '%" + txtSearch.Text + "%" + "' or employeeName Like '%" + txtSearch.Text + "%" + "' or identityNo Like '%" + txtSearch.Text + "%" + "' or employeeType Like '%" + txtSearch.Text + "%" + "'or departmentNo Like '%" + txtSearch.Text + "%" + "'or departmentName Like '%" + txtSearch.Text + "%" + "' ", conn)

                Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
                Dim myDataSet As DataSet = New DataSet()
                myDA.Fill(myDataSet, "MyTable")
                dgvEMP.DataSource = myDataSet.Tables("MyTable").DefaultView
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Sub populateSCcbb()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT * FROM tSubcon", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            cbbSubCon.DataSource = table2
            cbbSubCon.ValueMember = "subconID"
            cbbSubCon.DisplayMember = "subconName"
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub cbbSubCon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSubCon.SelectedIndexChanged

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchData()
        End If
    End Sub

    Private Sub cbbSubCon_KeyDown(sender As Object, e As KeyEventArgs) Handles cbbSubCon.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBySubcon()
        End If
    End Sub
End Class