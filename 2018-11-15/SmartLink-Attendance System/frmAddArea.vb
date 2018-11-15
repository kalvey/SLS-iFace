Imports System.Data.SqlClient
Public Class frmAddArea
    Dim areaNumber As String
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            openConnection()
            Dim cmd As SqlCommand = conn.CreateCommand()
            Dim transaction As SqlTransaction
            transaction = conn.BeginTransaction
            cmd.Transaction = transaction
            Try
                autoNumber()
                openConnection()
                Dim log As String
                log = "Area: " & txtAreaName.Text & " Successfully Created by: " & _globalUserId
                cmd = New SqlCommand("INSERT INTO tArea VALUES ('" & areaNumber & "', '" & txtAreaName.Text & "', '" & txtRemark.Text & "')", conn)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("INSERT INTO tLogs VALUES('" & DateTime.Now & "', '" & log & "')", conn)
                cmd.ExecuteNonQuery()

                transaction.Commit()
                MsgBox("Successfully Add Area")
            Catch ex As Exception
                transaction.Rollback()
                MsgBox("Error Happened")
                saveError(ex.ToString())
            End Try
            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT areaNumber 'Area Number', areaName 'Area Name', remarks 'Remarks' FROM tArea
           ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "area")
            frmDeviceManagement.dgvArea.DataSource = ds.Tables("area")

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Create Auto Number Based on Latest AreaCode 
    ''' </summary>
    Sub autoNumber()
        Try
            openConnection()
            Dim cmd = New SqlCommand("select areaNumber from tArea order by areaNumber desc", conn)
            Dim dReader As SqlDataReader
            dReader = cmd.ExecuteReader
            dReader.Read()
            Dim YearMonth = DateTime.Today.ToString("yyMM")

            If dReader.HasRows = False Then
                areaNumber = "AR" + YearMonth + "001"
            ElseIf dReader.HasRows = True Then
                If dReader.Item("areaNumber").ToString().Substring(0, 6) <> "AR" + YearMonth Then
                    areaNumber = "AR" + YearMonth + "001"
                Else
                    areaNumber = Val(Microsoft.VisualBasic.Mid(dReader.Item("areaNumber").ToString, 7, 3)) + 1
                    If Len(areaNumber) = 1 Then
                        areaNumber = "AR" + YearMonth + "00" + areaNumber
                    ElseIf Len(areaNumber) = 2 Then
                        areaNumber = "AR" + YearMonth + "0" + areaNumber
                    ElseIf Len(areaNumber) = 3 Then
                        areaNumber = "AR" + YearMonth + areaNumber
                    Else
                        areaNumber = "AR" + YearMonth + areaNumber
                    End If
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Happened When Trying to Run autoNumber Function")
            saveError(ex.ToString())
        End Try
    End Sub
End Class