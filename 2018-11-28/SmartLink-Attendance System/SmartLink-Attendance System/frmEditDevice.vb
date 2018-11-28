Imports System.Data.SqlClient
Public Class frmEditDevice
    Dim masterMode As String = False
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub populateCombobox()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT * FROM tArea", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            cbbArea.DataSource = table2
            cbbArea.ValueMember = "areaName"
            cbbArea.DisplayMember = "areaName"
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Happened when trying to populate Combobox")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub frmAddDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            populateCombobox()
        Catch ex As Exception
            MsgBox("Error Happened in formLoad")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub btnEditDevice_Click(sender As Object, e As EventArgs) Handles btnEditDevice.Click
        Try
            openConnection()
            Dim cmdEdit As New SqlCommand("UPDATE tDevice SET devName = '" + txtDeviceName.Text + "', area = '" + cbbArea.Text + "', master = '" & masterMode & "' WHERE serialNumber = '" + lblSerialNo.Text + "'", conn)
            cmdEdit.ExecuteNonQuery()
            conn.Close()
            MsgBox("Successfully Edited")

            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT devName 'Device Name', serialNumber 'Serial No', commType 'Communication Type',
           ipAddr 'IP Address', serialport 'Serial Port', serialAddr 'Serial Address',
            enabled, personellQty 'Personell Qty', fingerprintQty 'Fingerprint Qty',
        veinQty 'Vein Qty', FaceQty 'Face Qty', devModel 'Device Model',
        firmwareVer 'Firmware Version', area, port, deviceID 'Device ID' FROM tDevice;
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Data")
            frmDeviceManagement.dgvDevice.DataSource = ds.Tables("Data")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error Happened when trying to Edit Device")
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
End Class