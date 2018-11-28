
Public Class frmDateTime
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Public axCZKEM1 As New zkemkeeper.CZKEM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim index As Integer = frmDeviceManagement.dgvDevice.CurrentCell.RowIndex
            Dim idwErrorCode As Integer
            bIsConnected = axCZKEM1.Connect_Net(frmDeviceManagement.dgvDevice.Rows(index).Cells(3).Value.Trim(), "4370")

            Cursor = Cursors.WaitCursor
            If axCZKEM1.SetDeviceTime2(iMachineNumber, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, DateTimePicker1.Value.Day, DateTimePicker1.Value.Hour, DateTimePicker1.Value.Minute, DateTimePicker1.Value.Second) = True Then
                axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
                MsgBox("Successfully set the time of the machine as you have set!", MsgBoxStyle.Information, "Success")
                Me.Close()
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Error when trying to set date time")
            saveError(ex.ToString())
        End Try
    End Sub
End Class