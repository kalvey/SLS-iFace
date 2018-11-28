Imports System.Data.SqlClient
Public Class frmSyncDevice

    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineMasterNo As Integer
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Sub showDevice()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT devName 'Device Name', devModel 'Device Model', ipAddr 'IP Address', serialNumber 'Serial Number', commType 'Comm Type'
            FROM tDevice WHERE [master] <> 'TRUE'", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            dgvDevice.DataSource = table2
        Catch ex As Exception
            MsgBox("Error Happened when trying to populate Datagridview")
            saveError(ex.ToString())
        End Try
    End Sub
    Sub populateCombobox()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT ipAddr FROM tDevice WHERE [master] = 'TRUE'", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            cbbIP.DataSource = table2
            cbbIP.ValueMember = "ipAddr"
            cbbIP.DisplayMember = "ipAddr"
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Happened when trying to populate Combobox")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub frmSyncDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateCombobox()
        showDevice()
    End Sub
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        bIsConnected = axCZKEM1.Connect_Net(txtTarget.Text.Trim(), Convert.ToInt32("4370"))
        MsgBox("Successfully Connected")
        If bIsConnected = True Then
            If txtTarget.Text.Trim() = "192.168.1.203" Then
                iMachineNumber = 2 'In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535) 'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            Else
                MsgBox("bukan IP sebenarnya")
                Exit Sub
            End If
        Else
            MsgBox("Unable to connect the device, MsgBoxStyle.Exclamation")
        End If
        Cursor = Cursors.Default


        'Upload Finger
        If bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        If lvDownload.Items.Count = 0 Then
            MsgBox("There is no data to upload!", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim idwErrorCode As Integer

        Dim sdwEnrollNumber As String
        Dim sName As String = ""
        Dim sPassword As String = ""
        Dim iPrivilege As Integer
        Dim idwFingerIndex As Integer
        Dim sTmpData As String = ""
        Dim sEnabled As String = ""
        Dim bEnabled As Boolean = False
        Dim iflag As Integer

        Cursor = Cursors.WaitCursor
        axCZKEM1.EnableDevice(iMachineNumber, False)

        Dim lvItem As New ListViewItem

        For Each lvItem In lvDownload.Items
            sdwEnrollNumber = Convert.ToInt32(lvItem.SubItems(0).Text.Trim())
            sName = lvItem.SubItems(1).Text.Trim()
            idwFingerIndex = Convert.ToInt32(lvItem.SubItems(2).Text.Trim())
            sTmpData = lvItem.SubItems(3).Text.Trim()
            iPrivilege = Convert.ToInt32(lvItem.SubItems(4).Text.Trim())
            sPassword = lvItem.SubItems(5).Text.Trim()
            sEnabled = lvItem.SubItems(6).Text.Trim()
            iflag = Convert.ToInt32(lvItem.SubItems(7).Text.Trim())

            If sEnabled = "true" Then
                bEnabled = True
            Else
                bEnabled = False
            End If

            If axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) Then 'upload user information to the device
                axCZKEM1.SetUserTmpExStr(iMachineNumber, sdwEnrollNumber, idwFingerIndex, iflag, sTmpData) 'upload templates information to the device
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
                axCZKEM1.EnableDevice(iMachineNumber, True)
                Cursor = Cursors.Default
                Return
            End If
        Next

        axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
        axCZKEM1.EnableDevice(iMachineNumber, True)
        Cursor = Cursors.Default
        MsgBox("Successfully Upload fingerprint templates, " + "total:" + lvDownload.Items.Count.ToString(), MsgBoxStyle.Information, "Success")


        'Upload Face

        If bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If


        Dim sUserID As String = ""

        Dim iFaceIndex As Integer
        Dim iLength As Integer


        Cursor = Cursors.WaitCursor
        axCZKEM1.EnableDevice(iMachineNumber, False)

        Dim lvItemFace As New ListViewItem

        For Each lvItemFace In lvFace.Items
            sUserID = lvItemFace.SubItems(0).Text.Trim()
            sName = lvItemFace.SubItems(1).Text.Trim()
            sPassword = lvItemFace.SubItems(2).Text.Trim()
            iPrivilege = Convert.ToInt32(lvItemFace.SubItems(3).Text.Trim())
            iFaceIndex = Convert.ToInt32(lvItemFace.SubItems(4).Text.Trim())
            sTmpData = lvItemFace.SubItems(5).Text.Trim()
            iLength = Convert.ToInt32(lvItemFace.SubItems(6).Text.Trim())

            If sEnabled = "true" Then
                bEnabled = True
            Else
                bEnabled = False
            End If

            If axCZKEM1.SSR_SetUserInfo(iMachineNumber, sUserID, sName, sPassword, iPrivilege, bEnabled) Then 'upload user information to the device
                axCZKEM1.SetUserFaceStr(iMachineNumber, sUserID, iFaceIndex, sTmpData, iLength) 'upload face templates information to the device
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
                axCZKEM1.EnableDevice(iMachineNumber, True)
                Cursor = Cursors.Default
                Return
            End If
        Next

        axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
        axCZKEM1.EnableDevice(iMachineNumber, True)
        Cursor = Cursors.Default
        MsgBox("Successfully Upload the face templates, " + "total:" + lvFace.Items.Count.ToString(), MsgBoxStyle.Information, "Success")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getFace()

    End Sub

    Public axCZKEM1 As New zkemkeeper.CZKEM
    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click

        bIsConnected = axCZKEM1.Connect_Net(cbbIP.Text.Trim(), Convert.ToInt32("4370"))
        If bIsConnected = True Then

            iMachineMasterNo = 1 'In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
            axCZKEM1.RegEvent(iMachineNumber, 65535) 'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
        End If

        'Download Fingerprint template
        If bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        Dim sdwEnrollNumber As String = ""
        Dim sName As String = ""
        Dim sPassword As String = ""
        Dim iPrivilege As Integer
        Dim bEnabled As Boolean = False
        Dim idwFingerIndex As Integer
        Dim sTmpData As String = ""
        Dim iTmpLength As Integer
        Dim iFlag As Integer

        Dim lvItem As New ListViewItem("Items", 0)

        lvDownload.Items.Clear()
        lvDownload.BeginUpdate()
        axCZKEM1.EnableDevice(iMachineMasterNo, False)

        Cursor = Cursors.WaitCursor
        axCZKEM1.ReadAllUserID(iMachineMasterNo) 'read all the user information to the memory
        axCZKEM1.ReadAllTemplate(iMachineMasterNo) 'read all the users' fingerprint templates to the memory

        While axCZKEM1.SSR_GetAllUserInfo(iMachineMasterNo, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True  'get all the users' information from the memory
            For idwFingerIndex = 0 To 9

                If axCZKEM1.GetUserTmpExStr(iMachineMasterNo, sdwEnrollNumber, idwFingerIndex, iFlag, sTmpData, iTmpLength) Then 'get the corresponding templates string and length from the memory
                    lvItem = lvDownload.Items.Add(sdwEnrollNumber.ToString())
                    lvItem.SubItems.Add(sName)
                    lvItem.SubItems.Add(idwFingerIndex.ToString())
                    lvItem.SubItems.Add(sTmpData)
                    lvItem.SubItems.Add(iPrivilege.ToString())
                    lvItem.SubItems.Add(sPassword)
                    If bEnabled = True Then
                        lvItem.SubItems.Add("true")
                    Else
                        lvItem.SubItems.Add("false")
                    End If
                    lvItem.SubItems.Add(iFlag.ToString())
                End If
            Next
        End While
        lvDownload.EndUpdate()
        axCZKEM1.EnableDevice(iMachineMasterNo, True)
        Cursor = Cursors.Default

        'Download Face Template

        If bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        Dim sUserID As String = ""
        'Dim sName As String = ""
        'Dim sPassword As String = ""
        'Dim iPrivilege As Integer
        'Dim bEnabled As Boolean = False

        Dim iFaceIndex As Integer = 50 'the only possible parameter value
        ' Dim sTmpData As String = ""
        Dim iLength As Integer

        lvFace.Items.Clear()
        lvFace.BeginUpdate()

        Dim lvFaceItem As New ListViewItem("Items", 0)

        Cursor = Cursors.WaitCursor
        axCZKEM1.EnableDevice(iMachineMasterNo, False)
        axCZKEM1.ReadAllUserID(iMachineMasterNo) 'read all the user information to the memory

        While axCZKEM1.SSR_GetAllUserInfo(iMachineMasterNo, sUserID, sName, sPassword, iPrivilege, bEnabled) = True  'get all the users' information from the memory

            If axCZKEM1.GetUserFaceStr(iMachineMasterNo, sUserID, iFaceIndex, sTmpData, iLength) = True Then 'get the face templates from the memory
                lvFaceItem = lvFace.Items.Add(sUserID)
                lvFaceItem.SubItems.Add(sName)
                lvFaceItem.SubItems.Add(sPassword)
                lvFaceItem.SubItems.Add(iPrivilege.ToString())
                lvFaceItem.SubItems.Add(iFaceIndex.ToString())
                lvFaceItem.SubItems.Add(sTmpData)
                lvFaceItem.SubItems.Add(iLength.ToString())
                If bEnabled = True Then
                    lvFaceItem.SubItems.Add("true")
                Else
                    lvFaceItem.SubItems.Add("false")
                End If
            End If

        End While
        lvFace.EndUpdate()
        axCZKEM1.EnableDevice(iMachineMasterNo, True)
        Cursor = Cursors.Default
    End Sub

    Sub getFace()
        bIsConnected = axCZKEM1.Connect_Net(cbbIP.Text.Trim(), Convert.ToInt32("4370"))
        If bIsConnected = True Then

            iMachineMasterNo = 1 'In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
            axCZKEM1.RegEvent(iMachineNumber, 65535) 'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
        End If
        'Download Face Template

        If bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        Dim sUserID As String = ""

        Dim sdwEnrollNumber As String = ""
        Dim sName As String = ""
        Dim sPassword As String = ""
        Dim iPrivilege As Integer
        Dim bEnabled As Boolean = False
        Dim idwFingerIndex As Integer
        Dim sTmpData As String = ""
        Dim iTmpLength As Integer
        Dim iFlag As Integer

        Dim iFaceIndex As Integer = 50 'the only possible parameter value
        ' Dim sTmpData As String = ""
        Dim iLength As Integer

        lvFace.Items.Clear()
        lvFace.BeginUpdate()

        Dim lvFaceItem As New ListViewItem("Items", 0)

        Cursor = Cursors.WaitCursor
        axCZKEM1.EnableDevice(iMachineMasterNo, True)
        axCZKEM1.ReadAllUserID(iMachineMasterNo) 'read all the user information to the memory

        While axCZKEM1.SSR_GetAllUserInfo(iMachineMasterNo, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True  'get all the users' information from the memory

            If axCZKEM1.GetUserFaceStr(iMachineMasterNo, sdwEnrollNumber, iFaceIndex, sTmpData, iLength) = True Then 'get the face templates from the memory
                lvFaceItem = lvFace.Items.Add(sdwEnrollNumber)
                lvFaceItem.SubItems.Add(sName)
                lvFaceItem.SubItems.Add(sPassword)
                lvFaceItem.SubItems.Add(iPrivilege.ToString())
                lvFaceItem.SubItems.Add(iFaceIndex.ToString())
                lvFaceItem.SubItems.Add(sTmpData)
                lvFaceItem.SubItems.Add(iLength.ToString())
                If bEnabled = True Then
                    lvFaceItem.SubItems.Add("true")
                Else
                    lvFaceItem.SubItems.Add("false")
                End If
            End If

            End While

            lvFace.EndUpdate()
        axCZKEM1.EnableDevice(iMachineMasterNo, True)
        Cursor = Cursors.Default
    End Sub
End Class