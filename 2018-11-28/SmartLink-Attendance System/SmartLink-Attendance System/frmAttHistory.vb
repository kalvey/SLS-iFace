Imports System.Data.SqlClient
Public Class frmAttHistory
    Public userId As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '  Try

        openConnection()
        Dim adaptor As New SqlDataAdapter("
            SELECT 
	          tReport.userId 'User ID',
	            tReport.empNo 'Employee No',
                tReport.personellName 'Personnel Name',
                tDeviceUser2.departmentName 'Department Name',
                tDeviceUser2.position 'Position',
                tDeviceUser2.section 'Section',
                tUserExternal.subcon 'Subcon',
	            tReport.[timestamp] 'Time Stamp',
	            tReport.[deviceName] 'Device Name',
	            tReport.InOutMode 'In Out Mode'
             FROM tReport 
             JOIN tDeviceUser2 ON tDeviceUser2.userId = tReport.userId 
             JOIN tUserExternal ON tReport.userId = tUserExternal.userId
             WHERE tReport.userId = '" & userId & "'
             AND DATEPART(dd,[timestamp]) = '" & dtpSearch.Value.Day.ToString() & "'
             AND DATEPART(mm,[timestamp]) = '" & dtpSearch.Value.Month.ToString() & "'
             AND DATEPART(yy,[timestamp]) = '" & dtpSearch.Value.Year.ToString() & "'
        ", conn)
        Dim ds As New DataSet
        adaptor.Fill(ds, "Report")
        dgvHistory.DataSource = ds.Tables("Report")
        lblHistory.Text = "Jumlah Data  : " & dgvHistory.Rows.Count.ToString
        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        '    saveError(ex.ToString())
        'End Try
    End Sub
End Class