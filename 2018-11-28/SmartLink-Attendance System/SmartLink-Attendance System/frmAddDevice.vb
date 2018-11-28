Imports System.Data.SqlClient
Imports MySql.Data

Public Class frmAddDevice
    Dim masterMode As String = False
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Public axCZKEM1 As New zkemkeeper.CZKEM
    Sub populateCombobox()
        Try
            openConnection()
            Dim command As New SqlCommand("SELECT * FROM tArea", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            cbbArea.DataSource = table2
            cbbArea.ValueMember = "areaName"
            cbbArea.DisplayMember = "areaName"
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Happened")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub frmAddDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateCombobox()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        If txtIP.Text.Trim() = "" Or txtPort.Text.Trim() = "" Then
            MsgBox("IP and Port cannot be null", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        bIsConnected = axCZKEM1.Connect_Net(txtIP.Text.Trim(), Convert.ToInt32(txtPort.Text.Trim()))
        If bIsConnected = True Then
            MsgBox("Device Sucessfully Connected")
            btnAddDevice.Enabled = True
        Else
            MsgBox("Something happened! Connection to device failed!")
        End If
        Cursor = Cursors.Default

        'Get Firmware Version
        Try
            Dim sVersion As String = ""
            Cursor = Cursors.WaitCursor

            If axCZKEM1.GetFirmwareVersion(iMachineNumber, sVersion) = True Then
                lblFirmware.Text = "Firmware Version: " & sVersion
                firmware = sVersion
            Else
                MsgBox("Failed to get Firmware Version")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try

        'Get Serial Number
        Try
            Dim sdwSerialNumber As String = ""
            Cursor = Cursors.WaitCursor
            If axCZKEM1.GetSerialNumber(iMachineNumber, sdwSerialNumber) = True Then
                lblSerialNo.Text = "Serial Number: " & sdwSerialNumber
                serial = sdwSerialNumber
            Else
                MsgBox("Failed to get Serial Number")
            End If
        Catch ex As Exception
            MsgBox("Error when trying to get the Serial Number")
            saveError(ex.ToString())
        End Try

        'Get Device Model
        Try
            Dim sProductCode As String = ""
            Cursor = Cursors.WaitCursor
            If axCZKEM1.GetProductCode(iMachineNumber, sProductCode) = True Then
                lblDevModel.Text = "Device Mode: " & sProductCode
                model = sProductCode
            Else
                MsgBox("Failed to get Device Model")

            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Error when trying to get the Device Model")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub chkMaster_CheckedChanged(sender As Object, e As EventArgs) Handles chkMaster.CheckedChanged
        If chkMaster.Checked = True Then
            masterMode = "TRUE"
        Else
            masterMode = "FALSE"
        End If
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Error Happened when trying to close the form")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click
        Try
            If rdbIP.Checked = False Then
                MsgBox("Please check the connection type. TCP/IP or RS485")
            Else
                If rdbIP.Checked = True Then
                    openConnection()
                    Dim cmd As New SqlCommand("INSERT INTO tDevice(devName, serialNumber, commType, ipAddr, enabled, devModel, firmwareVer, area, port, deviceID, master) VALUES 
                                 ('" + txtDeviceName.Text + "','" & serial & "', 'TCP/IP', '" + txtIP.Text + "', 'FALSE', '" + model + "', '" + firmware + "', '" + cbbArea.Text + "', '" + txtPort.Text + "', '" & iMachineNumber & "', '" & masterMode & "')", conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MsgBox("Sucessfully Inserted")
                    openConnection()
                    Dim adaptor As New SqlDataAdapter("SELECT devName 'Device Name', serialNumber 'Serial No', commType 'Communication Type',
                    ipAddr 'IP Address', serialport 'Serial Port', serialAddr 'Serial Address',
                    enabled, personellQty 'Personell Qty', fingerprintQty 'Fingerprint Qty',
                    veinQty 'Vein Qty', FaceQty 'Face Qty', devModel 'Device Model',
                    firmwareVer 'Firmware Version', area, deviceID 'Device ID' FROM tDevice;
                    ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Data")
                    frmDeviceManagement.dgvDevice.DataSource = ds.Tables("Data")
                    If chkSync.Checked = True Then
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
                    End If

                    If chkReset.Checked = True Then
                        Dim idwErrorCode As Integer

                        Cursor = Cursors.WaitCursor
                        If axCZKEM1.SetDeviceTime(iMachineNumber) = True Then
                            axCZKEM1.ClearData(iMachineNumber, 5) 'the data in the device should be refreshed
                            MsgBox("Device Reset Successfully Executed!", MsgBoxStyle.Information, "Success")

                        Else
                            axCZKEM1.GetLastError(idwErrorCode)
                            MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
                        End If
                        Cursor = Cursors.Default
                    End If

                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error Happened when trying to add Device")
            saveError(ex.ToString())
        End Try

    End Sub

End Class