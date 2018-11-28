Imports System.Data.SqlClient
Public Class dgv
    Dim list As New List(Of Integer)
    Dim strDates As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
            list.Add(dates)
            strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
            dgv2.Columns.Add(dates, dates)
        Next

        Dim arrHeader1 As String() = {"TOTAL", "UA", "UL", "MC", "UPL", "SKB", "ML", "DR"}

        Dim nextHeader As Integer = 5 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        For header As Integer = 1 To 7
            dgv2.Columns.Add(header, arrHeader1(header))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openConnection()
        Dim adaptor As New SqlDataAdapter("SELECT * FROM tReport WHERE InOutMode = 'Check In' AND personellName = 'calvin'", conn)
        Dim ds As New DataSet
        adaptor.Fill(ds, "report")
        dgv1.DataSource = ds.Tables("report")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dta As Integer
        Dim count As Integer = 1
        For i As Integer = 0 To dgv1.Rows.Count - 1
            Dim dt As DateTime = dgv1.Rows(0).Cells(1).Value.ToString()
            Dim listStr As List(Of Integer)
            For j As Integer = 4 To dgv2.Columns.Count - 1
                If dt.Day = dgv2.Columns(j).HeaderText Then
                    MsgBox("Column: " & dgv2.Columns(j).HeaderText & "is 1")

                Else
                    MsgBox("Column: " & dgv2.Columns(j).HeaderText & "is 0")
                End If

            Next
            'dgv2.Rows.Add(count, dgv1.Rows(i).Cells(10).Value.ToString(), dgv1.Rows(i).Cells(4).Value.ToString(), dgv1.Rows(i).Cells(9).Value.ToString())
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 0 To dgv1.Rows.Count - 1
            Dim dt As DateTime = dgv1.Rows(0).Cells(1).Value.ToString()
            For j As Integer = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
                If dt.Day = j Then
                    MsgBox("Column: " & dgv2.Columns(j).HeaderText & "is 1")
                Else
                    MsgBox("Column: " & dgv2.Columns(j).HeaderText & "is 0")
                End If
            Next
        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        openConnection()
        Dim cmd As New SqlCommand("SELECT * FROM tReport WHERE personellName = 'CALVIN'", conn)
        Dim dReader = cmd.ExecuteReader
        dReader.Read()

        If dReader.HasRows = True Then
            Dim cmd1 As New SqlCommand("SELECT * FROM tTimeTable WHERE month = '" & dtpAtt.Value.Month & "' AND year = '" & dtpAtt.Value.Year & "' AND EmpName = 'CALVIN'", conn)
            Dim dReader1 = cmd1.ExecuteReader
            dReader1.Read()
            If dReader.HasRows = True Then
                For i As Integer = 0 To dgv1.Rows.Count - 1
                    For j As Integer = 4 To dgv2.Columns.Count - 1
                        If dgv1.Rows(i).Cells(0).Value.ToString.Substring(9, 10) = dgv2.Columns(j).HeaderText Then
                            Dim cmdUpdate = New SqlCommand("UPDATE INTO tTimeTable SET '" & dtpAtt.Value.Day & "' = '1'", conn)
                            cmdUpdate.ExecuteNonQuery()
                        Else
                            Dim cmdUpdate = New SqlCommand("UPDATE INTO tTimeTable SET '" & dtpAtt.Value.Day & "' = '0'", conn)
                            cmdUpdate.ExecuteNonQuery()
                        End If
                    Next
                Next
            Else
                Dim cmdInsert As New SqlCommand("INSERT INTO tTimeTable(month,year,EmployeeNo,EmpName) VALUES ('" & dtpAtt.Value.Month & "', '" & dtpAtt.Value.Day & "', '010101','CALVIN')", conn)
                cmdInsert.ExecuteNonQuery()
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("This process may take a few minutes. Please wait!")
        openConnection()
        populateName()
        Dim datas As Integer
        Dim lst As New List(Of Integer)
        Dim count As Integer = 1
        For j As Integer = 0 To DataGridView1.Rows.Count - 1
            lst.Clear()
            For i As Integer = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
                Dim cmd As New SqlCommand("
                SELECT * FROM tReport WHERE personellName = '" & DataGridView1.Rows(j).Cells(0).Value & "' AND InOutMode = 'Check In' 
                AND DATEPART(yy,[timestamp]) = '" & dtpAtt.Value.Year & "'
                AND DATEPART(mm,[timestamp]) = '" & dtpAtt.Value.Month & "'
                AND DATEPART(dd,[timestamp]) = '" & i & "'", conn)

                Dim dReader As SqlDataReader
                dReader = cmd.ExecuteReader
                dReader.Read()

                If dReader.HasRows = True Then
                    datas = 1
                    lst.Add(datas)
                Else
                    datas = 0
                    lst.Add(datas)
                End If

            Next

            If System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month) = 31 Then
                dgv2.Rows.Add(count, "10101", DataGridView1.Rows(j).Cells(0).Value, "IT", lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29), lst(30))
                count = count + 1
            ElseIf System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month) = 30 Then
                dgv2.Rows.Add(count, "10101", DataGridView1.Rows(j).Cells(0).Value, "IT", lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29))
                count = count + 1
            ElseIf System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month) = 28 Then
                dgv2.Rows.Add(count, "10101", DataGridView1.Rows(j).Cells(0).Value, "IT", lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27))
                count = count + 1
            End If


        Next


    End Sub
    'Get the first day of the month
    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function

    'Get the last day of the month
    Public Function LastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim list As New List(Of String)
        openConnection()
        Dim firstDate As Date = FirstDayOfMonth(dtpAtt.Value.ToString("yyyy-MM-dd"))
        Dim lastDate As Date = LastDayOfMonth(dtpAtt.Value.ToString("yyyy-MM-dd"))

        While firstDate <= lastDate
            list.Add("[" & firstDate.ToString("yyyy-MM-dd") & "]")
            firstDate = DateAdd(DateInterval.Day, 1, firstDate)
        End While

        Dim concat As String = String.Join(",", list)
        MsgBox(concat)
        Dim adaptor As New SqlDataAdapter("
        		DECLARE @firstDay date
        		DECLARE @lastDay date
        		SET @firstDay = DATEADD(mm, DATEDIFF(mm, 0, GETDATE())+0, 0) /* +0 = Current Month */
        		SET @lastDay =  DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,GETDATE())+1,0)) /* +1 = Current Month */

        	    DECLARE @tTime table ([dateStamp] date, nullCol int) 

        		WHILE (@firstDay<=@lastDay)
        		BEGIN
        		INSERT INTO @tTIME(dateStamp) values(@firstDay)
        		SET @firstDay = DATEADD(day, 1, @firstDay) 
        		END
        		SELECT * FROM @tTime
                pivot (count (nullCol) for dateStamp in (" & concat & "))
        ", conn)
        Dim ds As New DataSet
        adaptor.Fill(ds, "report")
        dgv1.DataSource = ds.Tables("report")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub
    Sub populateName()
        openConnection()
        Dim adaptor As New SqlDataAdapter("SELECT name from tDeviceUser", conn)
        Dim ds As New DataSet
        adaptor.Fill(ds, "report")
        DataGridView1.DataSource = ds.Tables("report")
    End Sub
    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class