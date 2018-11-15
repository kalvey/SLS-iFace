Imports System.Data.SqlClient
Public Class bom
    Dim dsAttendance As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dd As String
        Dim days As New List(Of String)
        Dim query As New List(Of String)

        For i As Integer = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
            dd = dtpAtt.Value.Year & "-" & dtpAtt.Value.Month.ToString("00") & "-" & i.ToString("00")
            days.Add("[" & dtpAtt.Value.Year & "-" & dtpAtt.Value.Month.ToString("00") & "-" & i.ToString("00") & "]")
            query.Add("CASE WHEN [" & dd & "] >= 1 THEN '1' WHEN [" & dd & "] <1 THEN ' ' END AS [" & dd & "]")
        Next

        Dim result As String = String.Join(", ", days)
        Dim result2 As String = String.Join(", ", query)
        MsgBox(result)
        MsgBox(result2)
        ' Try
        Dim adaptor As New SqlDataAdapter
        openConnection()
        If cbbDepart.Text = "" Then
            adaptor = New SqlDataAdapter("
            Select userId, " & result & "
             INTO #tTemp from
            (
              select userId , FORMAT([timestamp], 'yyyy-MM-dd') tS
              from tReport WHERE InOutMode = 'Check In'
            ) d
            pivot
            (
              count(ts)
              for ts in ( " & result & ")
            ) piv

            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department Name', " & result2 & "
            
            FROM #tTemp INNER JOIN tDeviceUser2 ON tDeviceUser2.userId = #tTemp.userId
            DROP TABLE #tTemp


        ", conn)
        Else
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
            ) piv

            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department Name', " & result2 & "
            FROM #tTemp INNER JOIN tDeviceUser2 ON tDeviceUser2.userId = #tTemp.userId WHERE tDeviceUser2.departmentName  Like '%" + cbbDepart.Text + "%" + "'

            DROP TABLE #tTemp
        ", conn)
        End If


        adaptor.Fill(dsAttendance, "Report")
        dgvEmployee.DataSource = dsAttendance.Tables("Report")

    End Sub

    Private Sub bom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showDGV()
    End Sub

    Sub showDGV()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT employeeName from tDeviceUser2", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Report")
            DataGridView1.DataSource = ds.Tables("Report")
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub
End Class