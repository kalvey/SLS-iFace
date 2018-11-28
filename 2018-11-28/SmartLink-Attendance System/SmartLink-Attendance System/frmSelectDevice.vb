Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frmSelectDevice
    Private Sub frmSelectDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showDGV()
    End Sub
    Sub showDGV()
        openConnection()
        Dim adaptor As New SqlDataAdapter("SELECT devName 'Device Name', serialNumber 'Serial No', commType 'Communication Type',
        ipAddr 'IP Address', serialport 'Serial Port', serialAddr 'Serial Address',
        enabled, personellQty 'Personell Qty', fingerprintQty 'Fingerprint Qty',
        veinQty 'Vein Qty', FaceQty 'Face Qty', devModel 'Device Model',
        firmwareVer 'Firmware Version', area, port FROM tDevice;
        ", conn)
        Dim ds As New DataSet
        adaptor.Fill(ds, "Data")
        DataGridView1.DataSource = ds.Tables("Data")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cell As Integer = DataGridView1.CurrentCell.RowIndex
            _globalIPAddress = DataGridView1.Rows(cell).Cells(3).Value.ToString
            _globalPort = DataGridView1.Rows(cell).Cells(14).Value.ToString
            MsgBox("You are now using device: " & DataGridView1.Rows(cell).Cells(1).Value & " IP Address: " & _globalIPAddress & " Port: " & _globalPort)
            Me.Close()
            frmEmpContract.MdiParent = MainForm
            frmEmpContract.Dock = DockStyle.Fill
            frmEmpContract.Show()
        Catch ex As Exception
            MsgBox("No Device Selected")
            Me.Close()
            frmEmpContract.Show()
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

        frmEmpContract.MdiParent = MainForm
        frmEmpContract.Dock = DockStyle.Fill
        frmEmpContract.Show()
    End Sub
End Class