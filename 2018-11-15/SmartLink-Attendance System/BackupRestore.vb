Public Class BackupRestore
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Public axCZKEM1 As New zkemkeeper.CZKEM

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim result As DialogResult = MessageBox.Show("Confirm Reset?",
                              "Title",
                              MessageBoxButtons.YesNo)
        If result.Yes Then
            Try
                Dim idwErrorCode As Integer

                Cursor = Cursors.WaitCursor
                bIsConnected = axCZKEM1.Connect_Net("192.168.1.203", "4370")
                If axCZKEM1.ClearKeeperData(iMachineNumber) = True Then
                    MsgBox("Resetting Device Completed!", MsgBoxStyle.Information, "Success")
                Else
                    axCZKEM1.GetLastError(idwErrorCode)
                    MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
                End If
                Cursor = Cursors.Default

            Catch ex As Exception
                MsgBox("Eror")
            End Try
        End If
    End Sub

    Dim index As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            bIsConnected = axCZKEM1.Connect_Net("192.168.1.203", "4370")
            If bIsConnected = False Then
                MsgBox("Can't connect to this device. Please make sure the IP Address correct and the device is turned on")
            End If
            Dim idwErrorCode As Integer

            Cursor = Cursors.WaitCursor
            If axCZKEM1.BackupData(txtDataFile.Text) = True Then

                MsgBox("Successfully Restore Data", MsgBoxStyle.Information, "Success")

            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Error Happened When Trying to Synchronize Date and Time to Device")
            saveError(ex.ToString())
        End Try
    End Sub
End Class