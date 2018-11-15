Imports System.Data.SqlClient
Public Class frmAddProject
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtProCode.Text = "" Then
            MsgBox("Please fill the Project Code")
            txtProCode.Select()
        ElseIf txtProName.Text = "" Then
            MsgBox("Please fill the Project Name")
            txtProName.Select()
        Else
            TabControl1.SelectedTab = proDet
        End If

    End Sub
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
    Private Sub frmAddProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populatetxtSubCon()
    End Sub

    Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        If txtProCode.Text = "" Then
            MsgBox("Please fill the Project Code")
            txtProCode.Select()
        ElseIf txtProName.Text = "" Then
            MsgBox("Please fill the Project Name")
            txtProName.Select()
        Else
            dgvSubCon.Rows.Add(txtProCode.Text, txtProName.Text, txtSubCon.Text, txtWorkType.Text, txtSubPIC.Text)
            txtSubCon.Text = ""
            txtWorkType.Text = ""
            txtSubPIC.Text = ""
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
                    cmd.CommandText = "INSERT INTO tProject(projectCode, projectName, planStart, planEnd, 
                                      [status], remark, createBy, createDate,createAt)
                                      VALUES(@proCode,@proName,@planStart,@planEnd,@status,
                                      @remark,@createBy,@createDate,@createAt)"

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@proCode", txtProCode.Text)
                    cmd.Parameters.AddWithValue("@proName", txtProName.Text)
                    cmd.Parameters.AddWithValue("@planStart", dtpStart.Value)
                    cmd.Parameters.AddWithValue("@planEnd", dtpEnd.Value)
                    cmd.Parameters.AddWithValue("@status", "OPEN")
                    cmd.Parameters.AddWithValue("@remark", txtRemark.Text)
                    cmd.Parameters.AddWithValue("@createBy", "CALVIN")
                    cmd.Parameters.AddWithValue("@createDate", DateTime.Now)
                    cmd.Parameters.AddWithValue("@createAt", Environment.MachineName)
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
                    MsgBox(ex.Message.ToString())
                End Try
            End Using
        End Using


        ''  Try
        'openConnection()

        ''Dim conTransaction As SqlClient.SqlTransaction
        ''conTransaction = con.BeginTransaction

        'Dim cmd As SqlCommand = conn.CreateCommand
        'Dim transaction As SqlTransaction
        'transaction = conn.BeginTransaction
        'cmd.Transaction = transaction
        ''Try

        ''    Try

        'cmd = New SqlCommand("
        '    INSERT INTO tProject(projectCode, projectName, planStart, planEnd, 
        '    [status], remark, createBy, createDate,
        '    createAt)
        '    VALUES(@proCode,@proName,@planStart,@planEnd,@status,@remark,@createBy,@createDate,@createAt)", conn)

        '        cmd.Parameters.Clear()
        '        cmd.Parameters.AddWithValue("@proCode", txtProCode.Text)
        '        cmd.Parameters.AddWithValue("@proName", txtProName.Text)
        '        cmd.Parameters.AddWithValue("@planStart", dtpStart.Value)
        '        cmd.Parameters.AddWithValue("@planEnd", dtpEnd.Value)
        '        cmd.Parameters.AddWithValue("@status", "OPEN")
        '        cmd.Parameters.AddWithValue("@remark", txtRemark.Text)
        '        cmd.Parameters.AddWithValue("@createBy", _globalUserId)
        '        cmd.Parameters.AddWithValue("@createDate", DateTime.Now)
        '        cmd.Parameters.AddWithValue("@createAt", Environment.MachineName)
        '        cmd.ExecuteNonQuery()

        '        For i As Integer = 0 To dgvSubCon.RowCount - 1
        '            cmd = New SqlCommand("
        '                INSERT INTO tProjectDet(projectCode, projectName, subCont, workType, projectPIC)
        '                VALUES(@proCode,@proName,@subCon,@workType,@projectPIC)
        '                ", conn)

        '            cmd.Parameters.Clear()
        '            cmd.Parameters.AddWithValue("@proCode", dgvSubCon.Rows(i).Cells(0).Value.ToString)
        '            cmd.Parameters.AddWithValue("@proName", dgvSubCon.Rows(i).Cells(1).Value.ToString)
        '            cmd.Parameters.AddWithValue("@subCon", dgvSubCon.Rows(i).Cells(2).Value.ToString)
        '            cmd.Parameters.AddWithValue("@workType", dgvSubCon.Rows(i).Cells(3).Value.ToString)
        '            cmd.Parameters.AddWithValue("@projectPIC", dgvSubCon.Rows(i).Cells(4).Value.ToString)
        '            cmd.ExecuteNonQuery()
        '        Next

        '        transaction.Commit()
        '        MsgBox("Successfully Inserted")
        ''    Catch ex As Exception
        ''        transaction.Rollback()
        ''        saveError(ex.ToString())
        ''        MsgBox("Error Happened!")
        ''    End Try
        ''Catch ex2 As Exception
        ''    saveError(ex2.ToString)
        ''    MsgBox("Error EX2. " & ex2.ToString())
        ''End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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