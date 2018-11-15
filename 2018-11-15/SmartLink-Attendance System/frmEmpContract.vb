Imports System.Data.SqlClient
Public Class frmEmpContract
    Dim dsAttendance As New DataSet
    Sub dgvAtt()
        Dim yr, month As Integer
        yr = DateTime.Now.Year
        month = DateTime.Now.Month.ToString("00")
        Dim days As New List(Of String)
        Dim value5 As String
        For i As Integer = 1 To System.DateTime.DaysInMonth(yr, month)
            days.Add("[" & yr & "-" & month & "-" & i.ToString("00") & "]")
        Next

        Dim result As String = String.Join(",", days)

        ' Try
        Dim adaptor As New SqlDataAdapter
        openConnection()

        adaptor = New SqlDataAdapter("
            select userId, " & result & "
             INTO #tTemp from
            (
              select userId , FORMAT([timestamp], 'yyyy-MM-dd') tS
              from tReport WHERE InOutMode = 'Check In'
            ) d 
            pivot
            (
              count(ts)
              for ts in ( " & result & ")
            ) piv;

            SELECT tDeviceUser2.userId, tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department Name', " & result & "
            FROM #tTemp INNER JOIN tDeviceUser2 ON tDeviceUser2.userId = #tTemp.userId 

            DROP TABLE #tTemp


        ", conn)


        Dim ds As New DataSet

        adaptor.Fill(ds, "Report")
        dgvAbsence.DataSource = ds.Tables("Report")


        Dim count As Integer = 0
        For iCols As Integer = 0 To dgvAbsence.Rows.Count - 1
            count = count + 1
            dgvAbsence.Rows(iCols).Cells(0).Value = count
        Next

        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        '    saveError(ex.ToString())
        'End Try

    End Sub
    Sub showDGVArea()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
                "
                SELECT employeeNo 'Employee Number', [employeeName] 'Employee Name', 
                employeeType 'Employee Type', departmentNo 'Department Number',
                departmentName 'Department Name', contractStartDate 'Contract Start Date',
                contractEndDate 'Contract End Date', datediff(dd,current_timestamp,contractEndDate) 'Remaining Work Days'
                FROM tDeviceUser2 WHERE datediff(dd, current_timestamp,contractEndDate) <= 3 AND [status] = 'ACTIVE'
                
                ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "emp")
            dgvEmp.DataSource = ds.Tables("emp")
        Catch ex As Exception
            MsgBox("Error Happened When Trying to Populate dgvArea")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Function FirstDayOfYear() As DateTime
        Return FirstDayOfYear(DateTime.Today)
    End Function

    ''' <summary>
    ''' Get first day of the specified year.
    ''' </summary>
    Private Function FirstDayOfYear(ByVal y As DateTime) As DateTime
        Return New DateTime(y.Year, 1, 1)
    End Function
    Sub getTotalAttendance()
        If dgvAbsence.Columns.Contains("TOTAL") Then
        Else
            dsAttendance.Tables(0).Columns.Add("TOTAL", GetType(String))
        End If

        Dim total, increment As Integer
        total = 0
        increment = 0
        For t As Integer = 0 To dgvAbsence.Rows.Count - 1
            total = 0

            For k As Integer = 5 To dgvAbsence.Columns.Count - 2
                total = total + dgvAbsence.Rows(t).Cells(k).Value
            Next

            '     dsAttendance.Tables(0).Rows(t)(2 + System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)) = total
            dgvAbsence.Rows(t).Cells(3 + System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)).Value = total

            Dim dtNow As Date = Date.Now
            Dim dtFirstOfMonth As Date = dtNow.AddDays(-dtNow.Day + 1)
            dgvLog.Rows.Add(dgvAbsence.Rows(t).Cells(0).Value, dgvAbsence.Rows(t).Cells(1).Value, dgvAbsence.Rows(t).Cells(2).Value, dgvAbsence.Rows(t).Cells(3).Value, DateDiff(DateInterval.Day, dtFirstOfMonth, DateTime.Now) - total)
        Next

    End Sub
    Private Sub frmEmpContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        showDGVArea()
        Dim days As New List(Of String)
        Dim value5 As String
        For i As Integer = 1 To System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month.ToString("00"))
            days.Add("[" & DateTime.Now.Year & "-" & DateTime.Now.Month.ToString("00") & "-" & i.ToString("00") & "]")
        Next

        Dim result As String = String.Join(",", days)

        ' Try
        Dim adaptor As New SqlDataAdapter
        openConnection()

        adaptor = New SqlDataAdapter("
            select userId, " & result & "
             INTO #tTemp from
            (
              select userId , FORMAT([timestamp], 'yyyy-MM-dd') tS
              from tReport WHERE InOutMode = 'Check In'
            ) d 
            pivot
            (
              count(ts)
              for ts in ( " & result & ")
            ) piv;

            SELECT  tDeviceUser2.userId, tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department Name', " & result & "
            FROM #tTemp INNER JOIN tDeviceUser2 ON tDeviceUser2.userId = #tTemp.userId 

            DROP TABLE #tTemp


        ", conn)

        adaptor.Fill(dsAttendance, "Report")
        dgvAbsence.DataSource = dsAttendance.Tables("Report")

        getTotalAttendance()
        Dim count As Integer = 0
        For iCols As Integer = 0 To dgvAbsence.Rows.Count - 1
            count = count + 1
            dgvAbsence.Rows(iCols).Cells(0).Value = count
        Next

        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        '    saveError(ex.ToString())
        'End Try
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ThisEmployeeIsNotActiveAnymoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThisEmployeeIsNotActiveAnymoreToolStripMenuItem.Click
        Dim result1 As DialogResult = MessageBox.Show("Does this person is already Inactive?",
                                                      "WARNING",
                                                      MessageBoxButtons.YesNo)
        If result1 = DialogResult.Yes Then
            Try
                Dim index As Integer = dgvEmp.CurrentCell.RowIndex
                openConnection()
                Dim cmd As New SqlCommand("UPDATE tDeviceUser2 SET [status] = 'INACTIVE' WHERE employeeNo = '" & dgvEmp.Rows(index).Cells(0).Value & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("This Employee Has Been Set into ' INACTIVE ' ")
                showDGVArea()
            Catch ex As Exception
                MsgBox("Error Happened")
                saveError(ex.ToString())
            End Try
        End If

    End Sub

    Private Sub dgvEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellContentClick

    End Sub

    Private Sub dgvEmp_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEmp.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim index As Integer
                dgvEmp.Rows(e.RowIndex).Selected = True
                index = e.RowIndex
                dgvEmp.CurrentCell = dgvEmp.Rows(e.RowIndex).Cells(1)
                ContextMenuStrip1.Show(dgvEmp, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Error when trying to Right Click dgvPersonell")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(dgvAbsence.Rows(0).Cells(1).Value)
    End Sub

    Private Sub dgvLog_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLog.CellContentClick

    End Sub

    Private Sub dgvLog_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLog.CellDoubleClick
        Dim index As Integer = dgvLog.CurrentCell.RowIndex

        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
                "
                create table #temp([Date] date)
                declare @sdate datetime= DATEADD(MONTH,DATEDIFF(MONTH,0,'" & DateTime.Now.ToString("yyyy-MM-dd") & "'),0)
                declare @edate datetime= DATEADD(DAY,-1,DATEADD(MONTH,DATEDIFF(MONTH,0,'" & DateTime.Now.ToString("yyyy-MM-dd") & "')+1,0))
                insert into #temp
                select DATEADD(d,number,@sdate) from master..spt_values where type='P' and number<=datediff(d,@sdate,'" & DateTime.Now.ToString("yyyy-MM-dd") & "')

                SELECT userId, FORMAT([timestamp],'yyyy-MM-dd') 'dd' INTO #tTemp1 FROM tReport WHERE userId = '" & dgvLog.Rows(index).Cells(0).Value.ToString() & "' AND DATEPART(mm,[timestamp]) = 11

                SELECT  #temp.[Date] FROM #tTemp1 FULL JOIN #temp ON #tTemp1.dd = #temp.[Date] WHERE userId IS NULL
                GROUP BY [Date]
                drop table #temp
                drop table #tTemp1               
                ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "emp")
            frmAbsDet.dgvAbsence.DataSource = ds.Tables("emp")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            saveError(ex.ToString())
        End Try

        frmAbsDet.txtName.Text = dgvLog.Rows(index).Cells(2).Value.ToString
        frmAbsDet.txtDept.Text = dgvLog.Rows(index).Cells(4).Value.ToString
        frmAbsDet.Show()
    End Sub
End Class