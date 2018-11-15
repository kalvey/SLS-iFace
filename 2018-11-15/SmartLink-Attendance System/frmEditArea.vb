Imports System.Data.SqlClient
Public Class frmEditArea

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim cmd As SqlCommand = conn.CreateCommand
        Dim transaction As SqlTransaction
        transaction = conn.BeginTransaction
        cmd.Transaction = transaction
        Try
            Dim log As String
            log = "Area: " & txtAreaName.Text & " Successfully Edited by: " & _globalUserId
            openConnection()

            cmd = New SqlCommand("UPDATE tArea SET areaName = '" & txtAreaName.Text & "', Remarks = '" & txtRemark.Text & "' WHERE areaNumber = '" + lblAreaNo.Text + "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("INSERT INTO tLogs VALUES('" & DateTime.Now & "', '" & log & "')", conn)
            cmd.ExecuteNonQuery()

            transaction.Commit()
            MsgBox("Area: " & lblAreaNo.Text & " Successfully Updated")


            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT areaNumber 'Area Number', areaName 'Area Name', remarks 'Remarks' FROM tArea
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "area")
            frmDeviceManagement.dgvArea.DataSource = ds.Tables("area")
            Me.Close()
        Catch ex As Exception
            transaction.Rollback()
            saveError(ex.ToString())
            MsgBox("Error Happened")
        End Try
    End Sub

    Private Sub frmEditArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class