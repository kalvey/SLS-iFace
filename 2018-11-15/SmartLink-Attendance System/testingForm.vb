Imports System.Data.SqlClient
Public Class testingForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        populateLate()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim days As New List(Of String)
        Dim countQuery As New List(Of String)
        Dim value5 As String
        For i As Integer = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
            days.Add("[" & dtpAtt.Value.Year & "-" & dtpAtt.Value.Month.ToString("00") & "-" & i.ToString("00") & "]")
            countQuery.Add(
            "(SELECT count( " & dtpAtt.Value.Year & "-" & dtpAtt.Value.Month.ToString("00") & "-" & i.ToString("00") & ")" & " FROM #tTemp WHERE " & dtpAtt.Value.Year & "-" & dtpAtt.Value.Month.ToString("00") & "-" & i.ToString("00") & " = '1')")
        Next

        Dim result As String = String.Join(",", days)
        Dim result2 As String = String.Join(",", countQuery)
        MsgBox(result2)

    End Sub
    Sub populateLate()
        Dim result, result2 As String
        Dim days As New List(Of String)
        Dim countQuery As New List(Of String)
        Dim dd As String
        Dim value5 As String
        If days.Count = 0 Or countQuery.Count = 0 Then
            For i As Integer = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
                dd = dtpAtt.Value.Year & "-" & dtpAtt.Value.Month.ToString("00") & "-" & i.ToString("00")

                days.Add("[" & dd & "]")
                countQuery.Add("(SELECT COUNT(" & dd & ") FROM #tTemp WHERE [" & dd & "] = '1' AND #tTemp.subconName = tSubCon.subconName) '" & dd & "'")

            Next
            result = String.Join(", ", days)
            result2 = String.Join(", ", countQuery)
        End If



        openConnection()
        MessageBox.Show(result2)
        Dim adaptor As New SqlDataAdapter(
            "
            SELECT userId, subconName, projectName, " & result & " INTO #tTemp
            FROM 
            (
                SELECT DISTINCT tDeviceUser2.userId, FORMAT([timestamp], 'yyyy-MM-dd') ts, tDeviceUser2.employeeNo, tDeviceUser2.employeeName, tProjectEMP.subconName, projectName,
                tReport.[timestamp] FROM tDeviceUser2 
                INNER JOIN tProjectEMP ON tDeviceUser2.employeeNo = tProjectEMP.employeeNO
                INNER JOIN tSubCon ON tProjectEMP.subconName = tProjectEMP.subconName AND projectName = projectName
                INNER JOIN tReport ON tDeviceUser2.userId = tReport.userId WHERE InOutMode = 'Check In'
            ) d
            pivot 
            (
            count (ts)
            for ts in (" & result & ")
            ) pv
             SELECT DISTINCT tSubcon.subconName, projectName, " & result2 & " FROM tSubCon INNER Join #tTemp On tSubCon.subconName = #tTemp.subconName;
             DROP TABLE #tTemp
            ", conn)

        Dim ds As New DataSet
        adaptor.Fill(ds, "Report")
        DataGridView1.DataSource = ds.Tables("Report")

    End Sub
End Class