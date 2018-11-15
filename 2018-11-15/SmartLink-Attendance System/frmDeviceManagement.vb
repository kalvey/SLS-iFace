Imports System.Data.SqlClient
Public Class frmDeviceManagement
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Public axCZKEM1 As New zkemkeeper.CZKEM
    Dim index As Integer = 0

    Private Sub frmDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            showDGV()
            showDGVArea()
        Catch ex As Exception
            MsgBox("Error Happened When Loading frmDevice Form")
            saveError(ex.ToString())
        End Try
    End Sub
    ''' <summary>
    '''  Sub to populate DataGridView with data from tAreaNumber
    ''' </summary>
    Sub showDGVArea()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT areaNumber 'Area Number', areaName 'Area Name', remarks 'Remarks' FROM tArea
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "area")
            dgvArea.DataSource = ds.Tables("area")
        Catch ex As Exception
            MsgBox("Error Happened When Trying to Populate dgvArea")
            saveError(ex.ToString())
        End Try
    End Sub
    ''' <summary>
    ''' Sub to populate DataGridView with data from tDevice
    ''' </summary>
    Sub showDGV()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT devName 'Device Name', serialNumber 'Serial No', commType 'Communication Type',
        ipAddr 'IP Address', serialport 'Serial Port', serialAddr 'Serial Address',
        enabled, personellQty 'Personell Qty', fingerprintQty 'Fingerprint Qty',
        veinQty 'Vein Qty', FaceQty 'Face Qty', devModel 'Device Model',
        firmwareVer 'Firmware Version', area, port, deviceID 'Device ID' FROM tDevice;
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Data")
            dgvDevice.DataSource = ds.Tables("Data")
        Catch ex As Exception
            MsgBox("An Error Happened When Trying to Populate dgvDevice")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click
        Try
            frmAddDevice.Show()
        Catch ex As Exception
            MsgBox("Error Happened when trying to show frmAddDevice (btnAddDevice)")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnEdit_click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim frm As frmEditDevice = New frmEditDevice
            Dim index As Integer
            index = dgvDevice.CurrentCell.RowIndex

            If dgvDevice.Rows(index).Cells(2).Value = "TCP/IP" Then
                frmEditDevice.rdbIP.Checked = True
            ElseIf dgvDevice.Rows(index).Cells(2).Value = "RS485" Then

            End If

            frm.txtDeviceName.Text = dgvDevice.Rows(index).Cells(0).Value
            frm.txtIP.Text = dgvDevice.Rows(index).Cells(3).Value
            frm.cbbArea.Text = dgvDevice.Rows(index).Cells(13).Value
            frm.lblDevModel.Text = dgvDevice.Rows(index).Cells(11).Value
            frm.lblFirmware.Text = dgvDevice.Rows(index).Cells(12).Value
            frm.lblSerialNo.Text = dgvDevice.Rows(index).Cells(1).Value
            frm.txtPort.Text = dgvDevice.Rows(index).Cells(14).Value
            frm.Show()
        Catch ex As Exception
            MsgBox("An Error Happened When btnEdit clicked!")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Confirm Delete?",
                              "Title",
                              MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim cmd As SqlCommand = conn.CreateCommand
                Dim transaction As SqlTransaction
                transaction = conn.BeginTransaction
                cmd.Transaction = transaction
                Try
                    Dim index As Integer
                    index = dgvDevice.CurrentCell.RowIndex
                    openConnection()
                    cmd = New SqlCommand("DELETE FROM tDevice WHERE SerialNumber = '" + dgvDevice.Rows(index).Cells(1).Value + "'", conn)
                    cmd.ExecuteNonQuery()

                    cmd = New SqlCommand("TRUNCATE TABLE tDeviceUser", conn)
                    cmd.ExecuteNonQuery()

                    cmd = New SqlCommand("TRUNCATE TABLE tReport", conn)
                    cmd.ExecuteNonQuery()

                    cmd = New SqlCommand("TRUNCATE TABLE tCard", conn)
                    cmd.ExecuteNonQuery()

                    transaction.Commit()
                    MsgBox("Successfully Deleted!")
                    showDGV()
                Catch EX As Exception
                    transaction.Rollback()
                    saveError(EX.ToString())
                    MsgBox("Error Happened!")
                End Try
            Else
                'Do Nothing
            End If
        Catch ex As Exception
            MsgBox("Error Happened when Trying to Delete Data (btnDelete)")
            saveError(ex.ToString())
        End Try
    End Sub


    Private Sub dgvDevice_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDevice.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then

                dgvDevice.Rows(e.RowIndex).Selected = True
                index = e.RowIndex
                dgvDevice.CurrentCell = dgvDevice.Rows(e.RowIndex).Cells(1)
                ContextMenuStrip1.Show(dgvDevice, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Error Happened when Trying to Right Click dgvDevice")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SetDeviceDateAndTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetDeviceDateAndTimeToolStripMenuItem.Click
        Try
            frmDateTime.Show()
        Catch ex As Exception
            MsgBox("Error Happened when Trying to Set Device Date and Time")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub SynchronizeDeviceDateAndTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SynchronizeDeviceDateAndTimeToolStripMenuItem.Click
        Try
            Dim index As Integer = dgvDevice.CurrentCell.RowIndex
            bIsConnected = axCZKEM1.Connect_Net(dgvDevice.Rows(index).Cells(3).Value.Trim(), dgvDevice.Rows(index).Cells(14).Value.Trim())
            If bIsConnected = False Then
                MsgBox("Can't connect to this device. Please make sure the IP Address correct and the device is turned on")
            End If
            Dim idwErrorCode As Integer

            Cursor = Cursors.WaitCursor
            If axCZKEM1.SetDeviceTime(iMachineNumber) = True Then
                axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
                MsgBox("Successfully set the time of the machine and the terminal to sync PC!", MsgBoxStyle.Information, "Success")

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

    Private Sub UpdateDeviceDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDeviceDataToolStripMenuItem.Click


        '   Try

        Dim personellQty, FingerprintQty, faceQty As String
            Dim idwErrorCode As Integer

            Dim idwValue As Integer
            Dim idwStatus As Integer
            Dim index2 As Integer = dgvDevice.CurrentCell.RowIndex

            Cursor = Cursors.WaitCursor
            bIsConnected = axCZKEM1.Connect_Net(dgvDevice.Rows(index).Cells(3).Value.Trim(), dgvDevice.Rows(index).Cells(14).Value.Trim())
            axCZKEM1.GetDeviceStatus(iMachineNumber, 2, idwValue)
            personellQty = idwValue.ToString()


            axCZKEM1.GetDeviceStatus(iMachineNumber, 3, idwValue)
            FingerprintQty = idwValue.ToString()


            axCZKEM1.GetDeviceStatus(iMachineNumber, 21, idwValue)
            faceQty = idwValue.ToString()


            Cursor = Cursors.Default



            Dim cmd As New SqlCommand("UPDATE tDevice SET personellQty = '" + personellQty + "', fingerprintQty = '" + FingerprintQty + "', faceQty = '" + faceQty + "' WHERE ipAddr = '" + dgvDevice.Rows(index2).Cells(3).Value + "'", conn)
            openConnection()
            cmd.ExecuteNonQuery()
            conn.Close()
            showDGV()
            Dim sdwEnrollNumber As String = ""
            Dim sName As String = ""
            Dim sPassword As String = ""
            Dim iPrivilege As Integer
            Dim bEnabled As Boolean = False
            Dim sCardnumber As String = ""
            Dim devName As String = ""
            Cursor = Cursors.WaitCursor
            axCZKEM1.EnableDevice(iMachineNumber, False) 'disable the device
            axCZKEM1.ReadAllUserID(iMachineNumber) 'read all the user information to the memory
        conn.Close()
        While axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True 'get user information from memory

            If axCZKEM1.GetStrCardNumber(sCardnumber) = True Then 'get the card number from the memory
                Using cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tDeviceUser2 WHERE userId = @enrollNumber) 
                                                  BEGIN 
                                                  INSERT INTO tDeviceUser2(userId, employeeName, cardNumber, privilege, password, enabled) VALUES (@enrollNumber, @sName, @sCardNumber, @iPrivilege, @sPassword, @bool)
                                                  END", conn)
                    cmdGetUser.Parameters.AddWithValue("@enrollNumber", sdwEnrollNumber)
                    cmdGetUser.Parameters.AddWithValue("@sName", sName)
                    cmdGetUser.Parameters.AddWithValue("@sCardNumber", sCardnumber)
                    cmdGetUser.Parameters.AddWithValue("@iPrivilege", iPrivilege)
                    cmdGetUser.Parameters.AddWithValue("@sPassword", sPassword)

                    If bEnabled = True Then
                        cmdGetUser.Parameters.AddWithValue("@bool", "TRUE")
                    Else
                        cmdGetUser.Parameters.AddWithValue("@bool", "FALSE")
                    End If
                    conn.Open()
                    cmdGetUser.ExecuteNonQuery()
                    conn.Close()
                End Using
            End If
        End While
            MsgBox("Successfully Get Newest Data")
            axCZKEM1.EnableDevice(iMachineNumber, True) 'enable the device

            Cursor = Cursors.Default
        'Catch ex As Exception

        '    MsgBox("Update Device Failed!")
        '    saveError(ex.ToString())
        'End Try
    End Sub

    Private Sub ClearAdministratorPrivilegeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAdministratorPrivilegeToolStripMenuItem.Click
        Try
            Dim idwErrorCode As Integer

            Cursor = Cursors.WaitCursor
            bIsConnected = axCZKEM1.Connect_Net(dgvDevice.Rows(index).Cells(3).Value.Trim(), dgvDevice.Rows(index).Cells(14).Value.Trim())
            If axCZKEM1.ClearAdministrators(iMachineNumber) = True Then
                MsgBox("Administrator Privileges has been removed!", MsgBoxStyle.Information, "Success")
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub EnableDeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableDeviceToolStripMenuItem.Click
        Try
            Dim idwErrorCode As Integer
            Cursor = Cursors.WaitCursor
            bIsConnected = axCZKEM1.Connect_Net(dgvDevice.Rows(index).Cells(3).Value.Trim(), dgvDevice.Rows(index).Cells(14).Value.Trim())
            If axCZKEM1.EnableDevice(iMachineNumber, 1) = True Then
                MsgBox("Device has been enabled", MsgBoxStyle.Information, "Success")
                openConnection()
                Dim dgvIndex As Integer = dgvDevice.CurrentCell.RowIndex
                Dim cmd As New SqlCommand("UPDATE tDevice SET enabled = 'TRUE' WHERE ipAddr = '" + dgvDevice.Rows(dgvIndex).Cells(3).Value + "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                showDGV()
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub DisableDeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableDeviceToolStripMenuItem.Click
        Try
            Dim idwErrorCode As Integer
            Cursor = Cursors.WaitCursor
            bIsConnected = axCZKEM1.Connect_Net(dgvDevice.Rows(index).Cells(3).Value.Trim(), dgvDevice.Rows(index).Cells(14).Value.Trim())
            If axCZKEM1.DisableDeviceWithTimeOut(iMachineNumber, 3600) = True Then
                MsgBox("Device has been disabled", MsgBoxStyle.Information, "Success")
                openConnection()
                Dim dgvIndex As Integer = dgvDevice.CurrentCell.RowIndex
                Dim cmd As New SqlCommand("UPDATE tDevice SET enabled = 'FALSE' WHERE ipAddr = '" + dgvDevice.Rows(dgvIndex).Cells(3).Value + "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                showDGV()
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub ShutDownDeviceToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ShutDownDeviceToolStripMenuItem.Click
        Try
            Dim idwErrorCode As Integer

            Cursor = Cursors.WaitCursor
            bIsConnected = axCZKEM1.Connect_Net(dgvDevice.Rows(index).Cells(3).Value.Trim(), dgvDevice.Rows(index).Cells(14).Value.Trim())
            If axCZKEM1.PowerOffDevice(iMachineNumber) = True Then
                MsgBox("Device will be turned off shortly", MsgBoxStyle.Information, "Success")
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnAddArea_Click(sender As Object, e As EventArgs) Handles btnAddArea.Click
        Try
            frmAddArea.Show()
        Catch ex As Exception
            MsgBox("Error Happened When Trying to Show frmAddArea")
            saveError(ex.ToString())
        End Try
    End Sub


    Private Sub btnEditArea_Click(sender As Object, e As EventArgs) Handles btnEditArea.Click
        Try
            Dim index As Integer = dgvArea.CurrentCell.RowIndex
            frmEditArea.txtAreaName.Text = dgvArea.Rows(index).Cells(1).Value
            frmEditArea.txtRemark.Text = dgvArea.Rows(index).Cells(2).Value
            frmEditArea.lblAreaNo.Text = dgvArea.Rows(index).Cells(0).Value
            frmEditArea.Show()
        Catch ex As Exception
            MsgBox("Error Happened! Please Make Sure You Have Selected a Row")
            saveError(ex.ToString)
        End Try
    End Sub

    Private Sub btnDeleteArea_Click(sender As Object, e As EventArgs) Handles btnDeleteArea.Click
        Try
            openConnection()
            Dim index As Integer = dgvArea.CurrentCell.RowIndex
            Dim cmd As SqlCommand = conn.CreateCommand()
            Dim transaction As SqlTransaction
            transaction = conn.BeginTransaction
            cmd.Transaction = transaction
            Try

                openConnection()
                Dim log As String
                log = "Area: " & dgvArea.Rows(index).Cells(1).Value.ToString & " Successfully Deleted by: " & _globalUserId
                cmd = New SqlCommand("DELETE FROM tArea WHERE areaNumber = '" & dgvArea.Rows(index).Cells(0).Value.ToString() & "'", conn)
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
            dgvArea.DataSource = ds.Tables("area")

        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString)
        End Try

    End Sub

    Private Sub ResetDeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetDeviceToolStripMenuItem.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Confirm Reset?",
                              "Title",
                              MessageBoxButtons.YesNo)
            If result.Yes Then
                Try
                    Dim idwErrorCode As Integer

                    Cursor = Cursors.WaitCursor
                    bIsConnected = axCZKEM1.Connect_Net(dgvDevice.Rows(index).Cells(3).Value.Trim(), dgvDevice.Rows(index).Cells(14).Value.Trim())
                    If axCZKEM1.ClearKeeperData(iMachineNumber) = True Then
                        MsgBox("Resetting Device Completed!", MsgBoxStyle.Information, "Success")
                    Else
                        axCZKEM1.GetLastError(idwErrorCode)
                        MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
                    End If
                    Cursor = Cursors.Default

                    Dim personellQty, FingerprintQty, faceQty As String
                    ' Dim idwErrorCode As Integer

                    Dim idwValue As Integer
                    Dim idwStatus As Integer
                    Dim index2 As Integer = dgvDevice.CurrentCell.RowIndex

                    Cursor = Cursors.WaitCursor
                    'get Registered Personnel

                    bIsConnected = axCZKEM1.Connect_Net(dgvDevice.Rows(index).Cells(3).Value.Trim(), "4370")
                    axCZKEM1.GetDeviceStatus(iMachineNumber, 2, idwValue)
                    personellQty = idwValue.ToString()

                    'get Registered Fingerprint Qty
                    axCZKEM1.GetDeviceStatus(iMachineNumber, 3, idwValue)
                    FingerprintQty = idwValue.ToString()

                    'get Registered Face Qty
                    axCZKEM1.GetDeviceStatus(iMachineNumber, 21, idwValue)
                    faceQty = idwValue.ToString()


                    Cursor = Cursors.Default

                    Dim cmd As New SqlCommand("UPDATE tDevice SET personellQty = '" + personellQty + "', fingerprintQty = '" + FingerprintQty + "', faceQty = '" + faceQty + "' WHERE ipAddr = '" + dgvDevice.Rows(index2).Cells(3).Value + "'", conn)
                    openConnection()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    showDGV()

                    Dim sdwEnrollNumber As String = ""
                    Dim sName As String = ""
                    Dim sPassword As String = ""
                    Dim iPrivilege As Integer
                    Dim bEnabled As Boolean = False
                    Dim sCardnumber As String = ""
                    Dim devName As String = ""

                    Cursor = Cursors.WaitCursor
                    axCZKEM1.EnableDevice(iMachineNumber, False) 'disable the device
                    axCZKEM1.ReadAllUserID(iMachineNumber) 'read all the user information to the memory
                    openConnection()

                    While axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True 'get user information from memory

                        If axCZKEM1.GetStrCardNumber(sCardnumber) = True Then 'get the card number from the memory
                            openConnection()
                            Dim cmdGetUser As New SqlCommand("INSERT INTO tDeviceUser VALUES (@enrollNumber, @sName, @sCardNumber, @iPrivilege, @sPassword, @bool)", conn)

                            cmdGetUser.Parameters.AddWithValue("@enrollNumber", sdwEnrollNumber)
                            cmdGetUser.Parameters.AddWithValue("@sName", sName)
                            cmdGetUser.Parameters.AddWithValue("@sCardNumber", sCardnumber)
                            cmdGetUser.Parameters.AddWithValue("@iPrivilege", iPrivilege)
                            cmdGetUser.Parameters.AddWithValue("@sPassword", sPassword)
                            If bEnabled = True Then
                                cmdGetUser.Parameters.AddWithValue("@bool", "TRUE")
                            Else
                                cmdGetUser.Parameters.AddWithValue("@bool", "FALSE")
                            End If
                            cmdGetUser.ExecuteNonQuery()
                        End If
                    End While
                    MsgBox("Successfully Get Newest Data")
                    axCZKEM1.EnableDevice(iMachineNumber, True) 'enable the device
                    Cursor = Cursors.Default
                    'Dim cmd1 As New SqlCommand("TRUNCATE TABLE tDeviceUser", conn)
                    'cmd1.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Error Occured!")
                    saveError(ex.ToString)
                End Try
            Else
            End If
        Catch ex As Exception
            MsgBox("Error Occured!")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Error When Trying to Close")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnClose2_Click(sender As Object, e As EventArgs) Handles btnClose2.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Error When Trying to Close ")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub UseThisDeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UseThisDeviceToolStripMenuItem.Click
        Try
            Dim cell As Integer = dgvDevice.CurrentCell.RowIndex
            _globalIPAddress = dgvDevice.Rows(cell).Cells(3).Value.ToString
            _globalPort = dgvDevice.Rows(cell).Cells(14).Value.ToString

            MsgBox("You are now using device: " & dgvDevice.Rows(cell).Cells(1).Value & " IP Address: " & _globalIPAddress & " Port: " & _globalPort)
        Catch ex As Exception
            MsgBox("Error Happened! Please Select at least 1 row")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub AnnounceDataToDeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnounceDataToDeviceToolStripMenuItem.Click
        frmSyncDevice.MdiParent = MainForm
        frmSyncDevice.Dock = DockStyle.Fill
        frmSyncDevice.Show()
    End Sub

    Private Sub RestartDeviceToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RestartDeviceToolStripMenuItem.Click
        Try
            Dim idwErrorCode As Integer

            Cursor = Cursors.WaitCursor
            bIsConnected = axCZKEM1.Connect_Net(dgvDevice.Rows(index).Cells(3).Value.Trim(), dgvDevice.Rows(index).Cells(14).Value.Trim())
            If axCZKEM1.RestartDevice(iMachineNumber) = True Then
                MsgBox("The device will restart!", MsgBoxStyle.Information, "Success")
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtSearch.Text = "" Then
                    showDGV()
                    conn.Close()
                Else
                    openConnection()
                    Dim adaptor As New SqlDataAdapter("SELECT devName 'Device Name', serialNumber 'Serial No', commType 'Communication Type',
                ipAddr 'IP Address', serialport 'Serial Port', serialAddr 'Serial Address',
                enabled, personellQty 'Personell Qty', fingerprintQty 'Fingerprint Qty',
                veinQty 'Vein Qty', FaceQty 'Face Qty', devModel 'Device Model',
                firmwareVer 'Firmware Version', area, port FROM tDevice
                
                WHERE devName LIKE '%" + txtSearch.Text + "%" + "' or ipAddr like '%" + txtSearch.Text + "%" + "' or commType LIKE '%" + txtSearch.Text + "%" + "'
                or serialPort LIKE '%" + txtSearch.Text + "%" + "' or serialAddr LIKE '%" + txtSearch.Text + "%" + "'", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Data")
                    dgvDevice.DataSource = ds.Tables("Data")
                    conn.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub
End Class