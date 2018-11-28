Public Class SDK_Testing
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idwErrorCode As Integer

        Cursor = Cursors.WaitCursor
        bIsConnected = axCZKEM1.Connect_Net("192.168.1.201", "4370")
        If axCZKEM1.SSR_EnableUser(iMachineNumber, 0, 1) = True Then
            MsgBox("Resetting Device Completed!", MsgBoxStyle.Information, "Success")
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default
    End Sub

    Public axCZKEM1 As New zkemkeeper.CZKEM
    Private Sub SDK_Testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class