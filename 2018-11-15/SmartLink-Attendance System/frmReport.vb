Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmReport
    Dim dsExitPermit As New DataSet
    Dim dsAttendance As New DataSet
    Dim dsOT As New DataSet
    Dim dsLate As New DataSet
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Public axCZKEM1 As New zkemkeeper.CZKEM
    Dim statusInOut As String

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateCombobox()
        populateComboboxSC()
        cbbSubcon.SelectionLength = 0
        'lvLogs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        cbbDevice.SelectionLength = 0
        ' showDGV()
        showATTReport()
        cbbDevName.SelectedIndex = -1
        lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString
    End Sub
    Sub cbbDepartment()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT * FROM tDepartment", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            cbbDepart.DataSource = table2
            cbbDepart.ValueMember = "departmentID"
            cbbDepart.DisplayMember = "DepartmentName"
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Sub populateComboboxSC()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT * FROM tSubCon", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            cbbSubcon.DataSource = table2
            cbbSubcon.ValueMember = "subconName"
            cbbSubcon.DisplayMember = "subconName"

            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Sub populateCombobox()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT * FROM tDevice", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            cbbDevice.DataSource = table2
            cbbDevice.ValueMember = "devName"
            cbbDevice.DisplayMember = "devName"
            cbbDevName.DataSource = table2
            cbbDevName.ValueMember = "devName"
            cbbDevName.DisplayMember = "devName"
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub
    Sub report()
        Try
            Dim statusInOut As String
            Dim devPort As String
            openConnection()
            Dim cmd As New SqlCommand("SELECT port FROM tDevice WHERE ipAddr = '" + txtIP.Text.Trim() + "'", conn)
            dReader = cmd.ExecuteReader
            dReader.Read()
            If dReader.HasRows = True Then
                devPort = dReader.Item("port")
            End If
            bIsConnected = axCZKEM1.Connect_Net(txtIP.Text.Trim(), devPort)

            Dim sdwEnrollNumber As String = ""
            Dim idwVerifyMode As Integer
            Dim idwInOutMode As Integer
            Dim idwYear As Integer
            Dim idwMonth As Integer
            Dim idwDay As Integer
            Dim idwHour As Integer
            Dim idwMinute As Integer
            Dim idwSecond As Integer
            Dim idwWorkcode As Integer
            Dim idwPersonellName As String
            Dim idwEmpNo As String
            Dim idwDeviceName As String
            Dim idwErrorCode As Integer
            Dim idwDepartmentName As String
            Dim idwDepartmentID As String
            Dim iGLCount = 0
            Dim lvItem As New ListViewItem("Items", 0)
            Dim verify As String
            Cursor = Cursors.WaitCursor
            'lvLogs.Items.Clear()
            axCZKEM1.EnableDevice(iMachineNumber, False) 'disable the device

            If axCZKEM1.ReadGeneralLogData(iMachineNumber) Then 'read all the attendance records to the memory
                'get records from the memory
                While axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, sdwEnrollNumber, idwVerifyMode, idwInOutMode, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond, idwWorkcode)
                    iGLCount += 1
                    openConnection()
                    Dim cmdRead As New SqlCommand("SELECT employeeName FROM tDeviceUser2 WHERE userId = '" & sdwEnrollNumber & "'", conn)
                    dReader = cmdRead.ExecuteReader
                    dReader.Read()
                    If dReader.HasRows = True Then
                        idwPersonellName = dReader.Item("name")
                    End If

                    Dim cmdRead2 As New SqlCommand("SELECT devName FROM tDevice WHERE deviceID = '" & iMachineNumber & "' ", conn)
                    Dim dReader2 As SqlDataReader
                    dReader2 = cmdRead2.ExecuteReader()
                    dReader2.Read()
                    If dReader2.HasRows = True Then
                        idwDeviceName = dReader2.Item("devName")
                    End If

                    Dim cmdReadDepartment As New SqlCommand("SELECT * FROM tUserInternal WHERE userId = '" & sdwEnrollNumber & "'", conn)
                    Dim dReader3 As SqlDataReader
                    dReader3 = cmdReadDepartment.ExecuteReader
                    dReader3.Read()

                    If dReader3.HasRows = True Then
                        idwDepartmentID = dReader3.Item("departmentID")
                        idwDepartmentName = dReader3.Item("department")
                    End If

                    Dim cmdReadEmpNo As New SqlCommand("SELECT EmployeeNo From tDeviceUser2 WHERE userId = '" & sdwEnrollNumber & "'", conn)
                    Dim dReader4 As SqlDataReader
                    dReader4 = cmdReadEmpNo.ExecuteReader
                    dReader4.Read()
                    If dReader4.HasRows = True Then
                        idwEmpNo = dReader4.Item("EmployeeNo").ToString
                    Else

                    End If
                    Try
                        Dim cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tReport WHERE timestamp = @reportDate) 
                                                  BEGIN 
                                                  INSERT INTO tReport(count, timestamp,deviceName, userId, personellName, InOutMode, WorkCode, VerifyType, departmentID, departmentName, EmpNo) VALUES (@count, @reportDate,@deviceName, @userId, @personellName, @InOutMode, @WorkCode, @VerifyType, @departmentID, @departmentName, @empNo)
                                                  END", conn)

                        Dim cmdGetUserBC As New SqlCommand("IF NOT EXISTS(SELECT * FROM tReport WHERE timestamp = @reportDate) 
                                                  BEGIN 
                                                  INSERT INTO tReportBackUp(count, timestamp,deviceName, userId, personellName, InOutMode, WorkCode, VerifyType, departmentID, departmentName, empNo) VALUES (@count, @reportDate,@deviceName, @userId, @personellName, @InOutMode, @WorkCode, @VerifyType, @departmentID, @departmentName, @empNo)
                                                  END", conn)

                        cmdGetUser.Parameters.AddWithValue("@count", iGLCount.ToString())
                        cmdGetUser.Parameters.AddWithValue("@reportDate", idwYear.ToString() & "-" + idwMonth.ToString() & "-" & idwDay.ToString() & " " & idwHour.ToString() & ":" & idwMinute.ToString() & ":" & idwSecond.ToString())
                        cmdGetUser.Parameters.AddWithValue("deviceName", idwDeviceName)
                        cmdGetUser.Parameters.AddWithValue("@userId", sdwEnrollNumber)
                        cmdGetUser.Parameters.AddWithValue("@personellName", idwPersonellName)

                        cmdGetUserBC.Parameters.AddWithValue("@count", iGLCount.ToString())
                        cmdGetUserBC.Parameters.AddWithValue("@reportDate", idwYear.ToString() & "-" + idwMonth.ToString() & "-" & idwDay.ToString() & " " & idwHour.ToString() & ":" & idwMinute.ToString() & ":" & idwSecond.ToString())
                        cmdGetUserBC.Parameters.AddWithValue("deviceName", idwDeviceName)
                        cmdGetUserBC.Parameters.AddWithValue("@userId", sdwEnrollNumber)
                        cmdGetUserBC.Parameters.AddWithValue("@personellName", idwPersonellName)
                        If idwInOutMode = "0" Then
                            statusInOut = "Check In"
                            cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                            cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                        ElseIf idwInOutMode = "1" Then
                            statusInOut = "Check Out"
                            cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                            cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                        ElseIf idwInOutMode = "2" Then
                            statusInOut = "Break Out"
                            cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                            cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                        ElseIf idwInOutMode = "3" Then
                            statusInOut = "Break In"
                            cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                            cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                        ElseIf idwInOutMode = "4" Then
                            statusInOut = "Overtime In"
                            cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                            cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                        ElseIf idwInOutMode = "5" Then
                            statusInOut = "Overtime Out"
                            cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                            cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                        Else
                            cmdGetUser.Parameters.AddWithValue("@InOutMode", idwInOutMode)
                            cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                        End If


                        cmdGetUser.Parameters.AddWithValue("@WorkCode", idwWorkcode)
                        cmdGetUserBC.Parameters.AddWithValue("@WorkCode", idwWorkcode)

                        cmdGetUser.Parameters.AddWithValue("@EmpNo", idwEmpNo)
                        cmdGetUserBC.Parameters.AddWithValue("@EmpNo", idwEmpNo)


                        If idwVerifyMode.ToString = "1" Then
                            verify = "Fingerprint"
                        ElseIf idwVerifyMode.ToString = "2" Then
                            verify = "PIN"
                        ElseIf idwVerifyMode.ToString = "3" Then
                            verify = "Password"
                        ElseIf idwVerifyMode.ToString = "4" Then
                            verify = "RFID Card"
                        ElseIf idwVerifyMode.ToString = "5" Then
                            verify = "Fingerprint or Password"
                        ElseIf idwVerifyMode.ToString = "6" Then
                            verify = "Fingerprint or RFID Card"
                        ElseIf idwVerifyMode.ToString = "15" Then
                            verify = "Face"
                        End If
                        cmdGetUser.Parameters.AddWithValue("VerifyType", verify.ToString())
                        cmdGetUser.Parameters.AddWithValue("departmentID", idwDepartmentID.ToString())
                        cmdGetUser.Parameters.AddWithValue("departmentName", idwDepartmentName.ToString())

                        cmdGetUserBC.Parameters.AddWithValue("VerifyType", verify)
                        cmdGetUserBC.Parameters.AddWithValue("departmentID", idwDepartmentID.ToString())
                        cmdGetUserBC.Parameters.AddWithValue("departmentName", idwDepartmentName.ToString())
                        cmdGetUser.ExecuteNonQuery()

                    Catch ex As Exception
                        iGLCount += 1
                        MsgBox(ex.ToString())
                    End Try
                End While

                MsgBox("Success!")
                showDGV()
            Else
                Cursor = Cursors.Default
                axCZKEM1.GetLastError(idwErrorCode)
                If idwErrorCode <> 0 Then
                    MsgBox("Reading data from terminal failed, No Data from Terminal. ErrorCode: " & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
                Else
                    MsgBox("No data from terminal returns!", MsgBoxStyle.Exclamation, "Error")
                End If
            End If

            axCZKEM1.EnableDevice(iMachineNumber, True) 'enable the device
            Cursor = Cursors.Default
            'lvLogs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub
    Sub reportIncrement()
        '  Try
        Dim idwCountNo As Integer
        Dim statusInOut As String
        Dim devPort As String
        openConnection()
        Dim cmd As New SqlCommand("SELECT port FROM tDevice WHERE ipAddr = '" + txtIP.Text.Trim() + "'", conn)
        dReader = cmd.ExecuteReader
        dReader.Read()
        If dReader.HasRows = True Then
            devPort = dReader.Item("port")
        End If
        bIsConnected = axCZKEM1.Connect_Net(txtIP.Text.Trim(), devPort)

        Dim sdwEnrollNumber As String = ""
        Dim idwVerifyMode As Integer
        Dim idwInOutMode As Integer
        Dim idwYear As Integer
        Dim idwMonth As Integer
        Dim idwDay As Integer
        Dim idwHour As Integer
        Dim idwMinute As Integer
        Dim idwSecond As Integer
        Dim idwWorkcode As Integer
        Dim idwPersonellName As String
        Dim idwEmpNo As String
        Dim idwDeviceName As String
        Dim idwErrorCode As Integer
        Dim idwDepartmentName As String
        Dim idwDepartmentID As String
        Dim iGLCount = 0
        Dim lvItem As New ListViewItem("Items", 0)
        Dim verify As String
        Cursor = Cursors.WaitCursor
        'lvLogs.Items.Clear()
        axCZKEM1.EnableDevice(iMachineNumber, False) 'disable the device
        conn.Close()
        If axCZKEM1.ReadGeneralLogData(iMachineNumber) Then 'read all the attendance records to the memory
            'get records from the memory
            While axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, sdwEnrollNumber, idwVerifyMode, idwInOutMode, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond, idwWorkcode)
                iGLCount += 1
                openConnection()
                Dim cmdRead As New SqlCommand("SELECT employeeName FROM tDeviceUser2 WHERE userId = '" & sdwEnrollNumber & "'", conn)
                dReader = cmdRead.ExecuteReader
                dReader.Read()
                If dReader.HasRows = True Then
                    idwPersonellName = dReader.Item("employeeName")
                End If

                Dim cmdRead2 As New SqlCommand("SELECT devName FROM tDevice WHERE deviceID = '" & iMachineNumber & "' ", conn)
                Dim dReader2 As SqlDataReader
                dReader2 = cmdRead2.ExecuteReader()
                dReader2.Read()
                If dReader2.HasRows = True Then
                    idwDeviceName = dReader2.Item("devName")
                End If

                Dim cmdReadDepartment As New SqlCommand("SELECT * FROM tUserInternal WHERE userId = '" & sdwEnrollNumber & "'", conn)
                Dim dReader3 As SqlDataReader
                dReader3 = cmdReadDepartment.ExecuteReader
                dReader3.Read()

                If dReader3.HasRows = True Then
                    idwDepartmentID = dReader3.Item("departmentID")
                    idwDepartmentName = dReader3.Item("department")

                Else
                    idwDepartmentID = "99"
                    idwDepartmentName = "no Department"
                End If

                Dim cmdReadEmpNo As New SqlCommand("SELECT EmployeeNo From tDeviceUser2 WHERE userId = '" & sdwEnrollNumber & "'", conn)
                Dim dReader4 As SqlDataReader
                dReader4 = cmdReadEmpNo.ExecuteReader
                dReader4.Read()
                If dReader4.HasRows = True Then
                    idwEmpNo = dReader4.Item("EmployeeNo").ToString
                Else

                End If
                Try
                    Dim cmdCount As New SqlCommand("SELECT MAX([COUNT]) as 'Data' FROM tReport", conn)
                    Dim dReadCount As SqlDataReader = cmdCount.ExecuteReader
                    dReadCount.Read()
                    If dReadCount.HasRows = True Then
                        If dReadCount.Item("Data").ToString() = "" Then
                            idwCountNo = 0 + 1
                        Else
                            idwCountNo = dReadCount.Item("Data").ToString()
                            idwCountNo = idwCountNo + 1
                        End If
                        conn.Close()
                        'Tambah userId = @userId dan Count = @count
                        'Using cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tReport WHERE timestamp = @reportDate) 
                        '                              BEGIN 
                        '                              INSERT INTO tReport(count, timestamp,deviceName, userId, personellName, InOutMode, WorkCode, VerifyType, departmentID, departmentName, EmpNo) VALUES (@count, @reportDate,@deviceName, @userId, @personellName, @InOutMode, @WorkCode, @VerifyType, @departmentID, @departmentName, @empNo)
                        '                              END", conn)


                        Using cmdGetUser As New SqlCommand(
                    "
                        IF NOT EXISTS 
                            (   SELECT  1
                                FROM    tReport
                                WHERE   [timestamp] = @reportDate
                                AND     [userId] = @userId
                            )
                            BEGIN
                                INSERT INTO tReport(count, timestamp, deviceName, userId, personellName, InOutMode, WorkCode, VerifyType, departmentID, departmentName, EmpNo) VALUES (@count, @reportDate,@deviceName, @userId, @personellName, @InOutMode, @WorkCode, @VerifyType, @departmentID, @departmentName, @empNo)
                            END
                    ", conn)
                            Using cmdGetUserBC As New SqlCommand(
                            "  
                            IF NOT EXISTS 
                            (   SELECT  1
                                FROM    tReportBackUp
                                WHERE   [timestamp] = @reportDate
                                AND     [userId] = @userId
                            )
                            BEGIN
                                INSERT INTO tReportBackUp(count, timestamp, deviceName, userId, personellName, InOutMode, WorkCode, VerifyType, departmentID, departmentName, EmpNo) VALUES (@count, @reportDate,@deviceName, @userId, @personellName, @InOutMode, @WorkCode, @VerifyType, @departmentID, @departmentName, @empNo)
                            END", conn)


                                cmdGetUser.Parameters.AddWithValue("@count", idwCountNo.ToString())
                                cmdGetUser.Parameters.AddWithValue("@reportDate", idwYear.ToString() & "-" + idwMonth.ToString() & "-" & idwDay.ToString() & " " & idwHour.ToString() & ":" & idwMinute.ToString() & ":" & idwSecond.ToString())
                                cmdGetUser.Parameters.AddWithValue("deviceName", cbbDevice.Text)
                                cmdGetUser.Parameters.AddWithValue("@userId", sdwEnrollNumber)
                                cmdGetUser.Parameters.AddWithValue("@personellName", idwPersonellName)

                                cmdGetUserBC.Parameters.AddWithValue("@count", idwCountNo.ToString())
                                cmdGetUserBC.Parameters.AddWithValue("@reportDate", idwYear.ToString() & "-" + idwMonth.ToString() & "-" & idwDay.ToString() & " " & idwHour.ToString() & ":" & idwMinute.ToString() & ":" & idwSecond.ToString())
                                cmdGetUserBC.Parameters.AddWithValue("deviceName", cbbDevice.Text)
                                cmdGetUserBC.Parameters.AddWithValue("@userId", sdwEnrollNumber)
                                cmdGetUserBC.Parameters.AddWithValue("@personellName", idwPersonellName)
                                If idwInOutMode = "0" Then
                                    statusInOut = "Check In"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "1" Then
                                    statusInOut = "Check Out"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "2" Then
                                    statusInOut = "Break Out"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "3" Then
                                    statusInOut = "Break In"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "4" Then
                                    statusInOut = "Overtime In"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "5" Then
                                    statusInOut = "Overtime Out"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                Else
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", idwInOutMode)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                End If

                                cmdGetUser.Parameters.AddWithValue("@WorkCode", idwWorkcode)
                                cmdGetUserBC.Parameters.AddWithValue("@WorkCode", idwWorkcode)

                                cmdGetUser.Parameters.AddWithValue("@EmpNo", idwEmpNo)
                                cmdGetUserBC.Parameters.AddWithValue("@EmpNo", idwEmpNo)


                                If idwVerifyMode.ToString = "1" Then
                                    verify = "Fingerprint"
                                ElseIf idwVerifyMode.ToString = "2" Then
                                    verify = "PIN"
                                ElseIf idwVerifyMode.ToString = "3" Then
                                    verify = "Password"
                                ElseIf idwVerifyMode.ToString = "4" Then
                                    verify = "RFID Card"
                                ElseIf idwVerifyMode.ToString = "5" Then
                                    verify = "Fingerprint or Password"
                                ElseIf idwVerifyMode.ToString = "6" Then
                                    verify = "Fingerprint or RFID Card"
                                ElseIf idwVerifyMode.ToString = "15" Then
                                    verify = "Face"
                                End If
                                cmdGetUser.Parameters.AddWithValue("VerifyType", "FACE + CARD")
                                cmdGetUser.Parameters.AddWithValue("departmentID", idwDepartmentID.ToString())
                                cmdGetUser.Parameters.AddWithValue("departmentName", idwDepartmentName.ToString())

                                cmdGetUserBC.Parameters.AddWithValue("VerifyType", "FACE + CARD")
                                cmdGetUserBC.Parameters.AddWithValue("departmentID", idwDepartmentID.ToString())
                                cmdGetUserBC.Parameters.AddWithValue("departmentName", idwDepartmentName.ToString())
                                conn.Open()
                                cmdGetUser.ExecuteNonQuery()
                                conn.Close()
                            End Using
                        End Using

                    ElseIf IsDBNull(dReadCount.Item(0)) Then
                        Using cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tReport WHERE timestamp = @reportDate) 
                                                  BEGIN 
                                                  INSERT INTO tReport(count, timestamp,deviceName, userId, personellName, InOutMode, WorkCode, VerifyType, departmentID, departmentName, EmpNo) VALUES (@count, @reportDate,@deviceName, @userId, @personellName, @InOutMode, @WorkCode, @VerifyType, @departmentID, @departmentName, @empNo)
                                                  END", conn)

                            Using cmdGetUserBC As New SqlCommand("IF NOT EXISTS(SELECT * FROM tReport WHERE timestamp = @reportDate) 
                                                  BEGIN 
                                                  INSERT INTO tReportBackUp(count, timestamp,deviceName, userId, personellName, InOutMode, WorkCode, VerifyType, departmentID, departmentName, empNo) VALUES (@count, @reportDate,@deviceName, @userId, @personellName, @InOutMode, @WorkCode, @VerifyType, @departmentID, @departmentName, @empNo)
                                                  END", conn)

                                cmdGetUser.Parameters.AddWithValue("@count", "1")
                                cmdGetUser.Parameters.AddWithValue("@reportDate", idwYear.ToString() & "-" + idwMonth.ToString() & "-" & idwDay.ToString() & " " & idwHour.ToString() & ":" & idwMinute.ToString() & ":" & idwSecond.ToString())
                                cmdGetUser.Parameters.AddWithValue("deviceName", cbbDevice.Text)
                                cmdGetUser.Parameters.AddWithValue("@userId", sdwEnrollNumber)
                                cmdGetUser.Parameters.AddWithValue("@personellName", idwPersonellName)

                                cmdGetUserBC.Parameters.AddWithValue("@count", "1")
                                cmdGetUserBC.Parameters.AddWithValue("@reportDate", idwYear.ToString() & "-" + idwMonth.ToString() & "-" & idwDay.ToString() & " " & idwHour.ToString() & ":" & idwMinute.ToString() & ":" & idwSecond.ToString())
                                cmdGetUserBC.Parameters.AddWithValue("deviceName", cbbDevice.Text)
                                cmdGetUserBC.Parameters.AddWithValue("@userId", sdwEnrollNumber)
                                cmdGetUserBC.Parameters.AddWithValue("@personellName", idwPersonellName)
                                If idwInOutMode = "0" Then
                                    statusInOut = "Check In"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "1" Then
                                    statusInOut = "Check Out"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "2" Then
                                    statusInOut = "Break Out"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "3" Then
                                    statusInOut = "Break In"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "4" Then
                                    statusInOut = "Overtime In"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                ElseIf idwInOutMode = "5" Then
                                    statusInOut = "Overtime Out"
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", statusInOut)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                Else
                                    cmdGetUser.Parameters.AddWithValue("@InOutMode", idwInOutMode)
                                    cmdGetUserBC.Parameters.AddWithValue("@InOutMode", statusInOut)
                                End If


                                cmdGetUser.Parameters.AddWithValue("@WorkCode", idwWorkcode)
                                cmdGetUserBC.Parameters.AddWithValue("@WorkCode", idwWorkcode)

                                cmdGetUser.Parameters.AddWithValue("@EmpNo", idwEmpNo)
                                cmdGetUserBC.Parameters.AddWithValue("@EmpNo", idwEmpNo)


                                If idwVerifyMode.ToString = "1" Then
                                    verify = "Fingerprint"
                                ElseIf idwVerifyMode.ToString = "2" Then
                                    verify = "PIN"
                                ElseIf idwVerifyMode.ToString = "3" Then
                                    verify = "Password"
                                ElseIf idwVerifyMode.ToString = "4" Then
                                    verify = "RFID Card"
                                ElseIf idwVerifyMode.ToString = "5" Then
                                    verify = "Fingerprint or Password"
                                ElseIf idwVerifyMode.ToString = "6" Then
                                    verify = "Fingerprint or RFID Card"
                                ElseIf idwVerifyMode.ToString = "15" Then
                                    verify = "Face"
                                End If
                                cmdGetUser.Parameters.AddWithValue("VerifyType", "FACE + CARD")
                                cmdGetUser.Parameters.AddWithValue("departmentID", idwDepartmentID.ToString())
                                cmdGetUser.Parameters.AddWithValue("departmentName", idwDepartmentName.ToString())

                                cmdGetUserBC.Parameters.AddWithValue("VerifyType", "FACE + CARD")
                                cmdGetUserBC.Parameters.AddWithValue("departmentID", idwDepartmentID.ToString())
                                cmdGetUserBC.Parameters.AddWithValue("departmentName", idwDepartmentName.ToString())
                                conn.Open()
                                cmdGetUser.ExecuteNonQuery()
                                conn.Close()
                            End Using
                        End Using

                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString())
                saveError(ex.ToString())
                End Try
            End While

            MsgBox("Success!")
            showDGV()
        Else
            Cursor = Cursors.Default
            axCZKEM1.GetLastError(idwErrorCode)
            If idwErrorCode <> 0 Then
                MsgBox("Reading data from terminal failed, No Data from Terminal. ErrorCode: " & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
            Else
                MsgBox("No data from terminal returns!", MsgBoxStyle.Exclamation, "Error")
            End If
        End If

        axCZKEM1.EnableDevice(iMachineNumber, True) 'enable the device
        Cursor = Cursors.Default
        'lvLogs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        'saveError(ex.ToString())
        'End Try
    End Sub
    Sub showDGV()
        Try
            dgvReport.DataSource = Nothing
            openConnection()
            Dim adaptor As New SqlDataAdapter("USE sls_iFaceDB
                SELECT userId,MIN([timestamp]) 'Check In', 
                (CASE MAX([timestamp])
                WHEN MIN([timestamp]) THEN NULL
                ELSE CAST(MAX([timestamp]) AS DATETIME)
                END)'Check Out',
                DATEDIFF(hh,MIN([timestamp]),MAX([timestamp])) 'Worked Hours'
                into #tAttendanceTemp
                FROM tReport WHERE

                DATEPART(yy,[timestamp]) = '" & DateTime.Now.Year & "'
                AND DATEPART(mm,[timestamp]) = '" & DateTime.Now.Month & "'
                AND DATEPART(dd,[timestamp]) = '" & DateTime.Now.Day & "'
                GROUP BY userId
                SELECT (ROW_NUMBER() OVER(ORDER BY (SELECT COUNT(*) FROM tReport))) 'No',
                rpt1.[deviceName] 'Device Name',
                rpt1.[userId] 'User ID',
                rpt1.[personellName] 'Employee Name',
                tUserExternal.subcon 'SubCon',
                #tAttendanceTemp.[Check In],
                #tAttendanceTemp.[Check Out],
                #tAttendanceTemp.[Worked Hours],
                rpt1.[VerifyType] 'Verify Type'
                FROM tReport rpt1 JOIN #tAttendanceTemp ON rpt1.userId = #tAttendanceTemp.userId 
                AND DATEPART(yy,[timestamp]) = '" & DateTime.Now.Year & "'
                AND DATEPART(mm,[timestamp]) = '" & DateTime.Now.Month & "'
                AND DATEPART(dd,[timestamp]) = '" & DateTime.Now.Day & "'
                JOIN tUserExternal ON #tAttendanceTemp.userId = tUserExternal.userId
				ORDER BY [Check In] asc
                DROP TABLE #tAttendanceTemp

        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Report")
            dgvReport.DataSource = ds.Tables("Report")

        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Sub exportExcel()
        Try
            If dgvReport.RowCount = Nothing Then
                MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim rowsTotal, colsTotal As Long
            Dim I, j, iC As Short
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim xlApp As New Excel.Application
            Try
                Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
                Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
                xlApp.Visible = True
                rowsTotal = dgvReport.RowCount - 1
                colsTotal = dgvReport.Columns.Count - 1
                With excelWorksheet
                    .Cells.Select()
                    .Cells.Delete()
                    For iC = 0 To colsTotal
                        .Cells(1, iC + 1).Value = dgvReport.Columns(iC).HeaderText
                    Next
                    For I = 0 To rowsTotal
                        For j = 0 To colsTotal
                            .Cells(I + 2, j + 1).value = dgvReport.Rows(I).Cells(j).Value.ToString()
                        Next j
                    Next I

                    .Cells("1:1").NumberFormat = "dd/MM/yyyy"
                    .Rows("1:1").Font.FontStyle = "Bold"
                    .Rows("1:1").Font.Size = 12
                    .Cells.Columns.AutoFit()
                    .Cells.Select()
                    .Cells.EntireColumn.AutoFit()
                    .Cells(1, 1).Select()
                    .Cells.NumberFormat = "0"
                End With
            Catch ex As Exception
                saveError(ex.ToString())
            Finally
                'RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                xlApp = Nothing
            End Try
        Catch ex As Exception
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub txtInOut_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            If txtInOut.Text = "Check In" Then
                statusInOut = "0"
            ElseIf txtInOut.Text = "Check Out" Then
                statusInOut = "1"
            ElseIf txtInOut.Text = "Break Out" Then
                statusInOut = "2"
            ElseIf txtInOut.Text = "Break In" Then
                statusInOut = "3"
            ElseIf txtInOut.Text = "Overtime In" Then
                statusInOut = "4"
            ElseIf txtInOut.Text = "Overtime Out" Then
                statusInOut = "5"
            End If
        Catch ex As Exception
            MsgBox("statusInOut can't be populated")
            saveError(ex.ToString)
        End Try
    End Sub


    Private Sub txtPersonellID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbbDevice_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbbDevice.SelectedIndexChanged
        Try
            openConnection()
            Dim cmd As New SqlCommand("SELECT ipAddr FROM tDevice WHERE devName = '" + cbbDevice.Text + "'", conn)

            dReader = cmd.ExecuteReader
            dReader.Read()
            If dReader.HasRows = True Then
                txtIP.Text = dReader.Item("ipAddr")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnGetLogs_Click(sender As Object, e As EventArgs) Handles btnGetLogs.Click
        ' Try
        reportIncrement()
        lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString
        showATTReport()
        ' report()
        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        '    saveError(ex.ToString())
        'End Try

    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim adaptor As New SqlDataAdapter("SELECT [count] 
                                              ,[timestamp] 'Time Stamp'
                                              ,[deviceName] 'Device Name'
                                              ,[userId] 'User ID'
                                              ,[personellName] 'Personell Name'
                                              ,[InOutMode] 'In/Out Mode'
                                              ,[workCode] 'Work Code'
                                              ,[VerifyType] 'Verify Type'
                                               FROM [sls_iFaceDB].[dbo].[tReport] WHERE InOutMode = '" & txtInOut.Text & "' AND deviceName = '" & cbbDevice.Text & "' AND userId = '" & txtPersonellID.Text & "'ORDER BY [count] ASC
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Report")
            dgvReport.DataSource = ds.Tables("Report")
            lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString
        Catch ex As Exception
            MsgBox("Error Happened When Trying to Search")
            saveError(ex.ToString)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        showATTReport()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        exportReport(dgvReport)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Sub populateName()

        openConnection()
        Dim adaptor As New SqlDataAdapter
        If cbbDepart.Text = "" Then
            adaptor = New SqlDataAdapter("SELECT employeeNo, departmentName, [employeeName] FROM tDeviceUser2", conn)
        Else
            adaptor = New SqlDataAdapter("SELECT employeeNo, departmentName, [employeeName] FROM tDeviceUser2 WHERE departmentName = '" & cbbDepart.Text & "'", conn)
        End If
        Dim ds As New DataSet
        adaptor.Fill(ds, "report")
        dgvHidden.DataSource = ds.Tables("report")

    End Sub
    Sub populateLateUser()

        openConnection()
        Dim adaptor As New SqlDataAdapter
        If cbbLateDPT.Text = "" Then
            adaptor = New SqlDataAdapter("SELECT employeeNo, departmentName, [employeeName] FROM tDeviceUser2", conn)
        Else
            adaptor = New SqlDataAdapter("SELECT employeeNo, departmentName, [employeeName] FROM tDeviceUser2 WHERE departmentName = '" & cbbLateDPT.Text & "'", conn)
        End If
        Dim ds As New DataSet
        adaptor.Fill(ds, "report")
        dgvLateUser.DataSource = ds.Tables("report")
    End Sub

    Sub populatePermitUser()

        openConnection()
        Dim adaptor As New SqlDataAdapter
        If cbDeptExit.Text = "" Then
            adaptor = New SqlDataAdapter("SELECT employeeNo, departmentName, [employeeName] FROM tDeviceUser2", conn)
        Else
            adaptor = New SqlDataAdapter("SELECT employeeNo, departmentName, [employeeName] FROM tDeviceUser2 WHERE departmentName = '" & cbDeptExit.Text & "'", conn)
        End If
        Dim ds As New DataSet
        adaptor.Fill(ds, "report")
        dgvExitUser.DataSource = ds.Tables("report")
    End Sub


    'Sub populateOTUser()
    '    openConnection()
    '    Dim adaptor As New SqlDataAdapter
    '    If cbbOTDepart.Text = "" Then
    '        adaptor = New SqlDataAdapter("SELECT employeeNo, departmentName, [employeeName] FROM tDeviceUser2", conn)
    '    Else
    '        adaptor = New SqlDataAdapter("SELECT employeeNo, departmentName, [employeeName] FROM tDeviceUser2 WHERE departmentName = '" & cbbDepart.Text & "'", conn)
    '    End If
    '    Dim ds As New DataSet
    '    adaptor.Fill(ds, "report")
    '    dgvOTUser.DataSource = ds.Tables("report")
    'End Sub
    'Sub generateOTDGV()
    '    Dim list As New List(Of String)
    '    Dim strDates As String
    '    dgvOT.Columns.Add("col1", "No")
    '    dgvOT.Columns.Add("col2", "EmpNo")
    '    dgvOT.Columns.Add("col3", "EmpName")
    '    dgvOT.Columns.Add("col4", "Department")
    '    For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
    '        list.Add(dates)
    '        strDates = dtpExit.Value.Year.ToString & "/" & dtpExit.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
    '        dgvOT.Columns.Add(dates, dates)
    '    Next

    '    'Dim arrHeader1 As String() = {"TOTAL"}

    '    'Dim nextHeader As Integer = 5 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
    '    'For header As Integer = 0 To 0
    '    '    dgvExit.Columns.Add(header, arrHeader1(header))
    '    'Next
    'End Sub
    Sub generatePermitDGV()
        Dim list As New List(Of String)
        Dim strDates As String
        dgvExit.Columns.Add("col1", "No")
        dgvExit.Columns.Add("col2", "EmpNo")
        dgvExit.Columns.Add("col3", "EmpName")
        dgvExit.Columns.Add("col4", "Department")
        For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
            list.Add(dates)
            strDates = dtpExit.Value.Year.ToString & "/" & dtpExit.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
            dgvExit.Columns.Add(dates, dates)
        Next

        Dim arrHeader1 As String() = {"TOTAL"}

        Dim nextHeader As Integer = 5 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        For header As Integer = 0 To 0
            dgvExit.Columns.Add(header, arrHeader1(header))
        Next
    End Sub
    Sub generateLateDGV()
        Dim list As New List(Of String)
        Dim strDates As String
        dgvLate.Columns.Add("col1", "No")
        dgvLate.Columns.Add("col2", "EmpNo")
        dgvLate.Columns.Add("col3", "EmpName")
        dgvLate.Columns.Add("col4", "Department")
        For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
            list.Add(dates)
            strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
            dgvLate.Columns.Add(dates, dates)
        Next

        Dim arrHeader1 As String() = {"TOTAL", "TOTAL LATE"}

        Dim nextHeader As Integer = 5 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        For header As Integer = 0 To 1
            dgvLate.Columns.Add(header, arrHeader1(header))
        Next
    End Sub
    Sub generateColumnDGV()
        Dim list As New List(Of String)
        Dim strDates As String
        dgvEmployee.Columns.Add("col1", "No")
        dgvEmployee.Columns.Add("col2", "EmpNo")
        dgvEmployee.Columns.Add("col3", "EmpName")
        dgvEmployee.Columns.Add("col4", "Department")
        For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
            list.Add(dates)
            strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
            dgvEmployee.Columns.Add(dates, dates)
        Next

        Dim arrHeader1 As String() = {"TOTAL", "UA", "UL", "MC", "UPL", "SKB", "ML", "DR"}

        Dim nextHeader As Integer = 5 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        For header As Integer = 0 To 7
            dgvEmployee.Columns.Add(header, arrHeader1(header))
        Next
    End Sub
    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        dsAttendance.Clear()
        dsAttendance.Tables.Clear()
        dgvEmployee.DataSource = Nothing
        dgvEmployee.Rows.Clear()
        Dim dd As String
        Dim days As New List(Of String)
        Dim query As New List(Of String)

        For i As Integer = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
            dd = dtpAtt.Value.Year & "-" & dtpAtt.Value.Month.ToString("00") & "-" & i.ToString("00")
            days.Add("[" & dtpAtt.Value.Year & "-" & dtpAtt.Value.Month.ToString("00") & "-" & i.ToString("00") & "]")
            query.Add("CASE WHEN [" & dd & "] >= 1 THEN '1' WHEN [" & dd & "] <1 THEN ' ' END AS [" & dd & "]")
        Next

        Dim result As String = String.Join(", ", days)
        Dim result2 As String = String.Join(", ", query)

        ' Try
        Dim adaptor As New SqlDataAdapter
        openConnection()
        If cbbDepart.Text = "" And txtSearchEMP.Text = "" Then
            adaptor = New SqlDataAdapter("
            Select userId, " & result & "
             INTO #tTemp from
            (
              select userId , FORMAT([timestamp], 'yyyy-MM-dd') tS
              from tReport WHERE InOutMode = 'Check In'
            ) d
            pivot
            (
              count(ts)
              for ts in ( " & result & ")
            ) piv

            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department Name', " & result2 & "
            
            FROM #tTemp INNER JOIN tDeviceUser2 ON tDeviceUser2.userId = #tTemp.userId 

            DROP TABLE #tTemp


        ", conn)
        ElseIf cbbDepart.Text <> "" And txtSearchEMP.Text = "" Then
            adaptor = New SqlDataAdapter("
            select userId, " & result & "
             INTO #tTemp from
            (
              select userId , FORMAT([timestamp], 'yyyy-MM-dd') tS
              from tReport WHERE InOutMode = 'Check In'
            ) d
            pivot
            (
              count(ts)
              for ts in ( " & result & ")
            ) piv

            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department Name', " & result2 & "
            FROM #tTemp INNER JOIN tDeviceUser2 ON tDeviceUser2.userId = #tTemp.userId WHERE tDeviceUser2.departmentName  Like '%" + cbbDepart.Text + "%" + "'

            DROP TABLE #tTemp
        ", conn)

        ElseIf cbbDepart.Text = "" And txtSearchEMP.Text <> "" Then

            adaptor = New SqlDataAdapter("
            select userId, " & result & "
             INTO #tTemp from
            (
              select userId , FORMAT([timestamp], 'yyyy-MM-dd') tS
              from tReport WHERE InOutMode = 'Check In'
            ) d
            pivot
            (
              count(ts)
              for ts in ( " & result & ")
            ) piv

            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department Name', " & result2 & "
            FROM #tTemp INNER JOIN tDeviceUser2 ON tDeviceUser2.userId = #tTemp.userId WHERE tDeviceUser2.employeeName  Like '%" + txtSearchEMP.Text + "%" + "'

            DROP TABLE #tTemp
        ", conn)

        ElseIf cbbDepart.Text <> "" And txtSearchEMP.Text <> "" Then

            adaptor = New SqlDataAdapter("
            select userId, " & result & "
             INTO #tTemp from
            (
              select userId , FORMAT([timestamp], 'yyyy-MM-dd') tS
              from tReport WHERE InOutMode = 'Check In'
            ) d
            pivot
            (
              count(ts)
              for ts in ( " & result & ")
            ) piv

            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department Name', " & result2 & "
            FROM #tTemp INNER JOIN tDeviceUser2 ON tDeviceUser2.userId = #tTemp.userId WHERE tDeviceUser2.departmentName  Like '%" + cbbDepart.Text + "%" + "' 
            AND tDeviceUser2.employeeName Like '%" + txtSearchEMP.Text + "%" + "' 

            DROP TABLE #tTemp
        ", conn)

        End If


        adaptor.Fill(dsAttendance, "Report")
        dgvEmployee.DataSource = dsAttendance.Tables("Report")

        getTotalAttendance()
        Dim count As Integer = 0
        For iCols As Integer = 0 To dgvEmployee.Rows.Count - 1
            count = count + 1
            dgvEmployee.Rows(iCols).Cells(0).Value = count
        Next

        For n As Integer = 0 To dgvEmployee.Rows.Count - 1

            For m As Integer = 0 To dgvEmployee.Columns.Count - 1

                If dgvEmployee.Rows(n).Cells(m).Value.ToString Is Nothing Or dgvEmployee.Rows(n).Cells(m).Value.ToString = "0" Or dgvEmployee.Rows(n).Cells(m).Value.ToString = " " Then
                    dgvEmployee.Rows(n).Cells(m).Style.BackColor = Color.LightSalmon
                End If

            Next
        Next

        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        '    saveError(ex.ToString())
        'End Try

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub exportExit(ByVal dgv As DataGridView)

        Dim rowsTotal, colsTotal As Long
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim strDates As String

            'To Change Language of the Days to Local Language, eg: Senin --> Monday

            Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
            Dim list As New List(Of Integer)
            Dim days As New List(Of String)

            'Get Total Days in the Selected Month (Selected Month = dtpAtt.Value.Month)
            For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
                list.Add(dates)
                strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
                Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
                Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
                days.Add(dayName)
            Next

            copyAlltoClipboard(dgv)
            Dim xlexcel As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            '    xlWorkBook = xlexcel.Workbooks.Open(Path)
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            xlexcel = New Microsoft.Office.Interop.Excel.Application()
            xlexcel.Visible = True
            xlWorkBook = xlexcel.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Worksheets(1)

            With xlWorkSheet
                ' Declare Header Text using Array()
                Dim arrHeader As String() = {"NULL", "NO", "EMPNO", "EMPNAME", "DEPARTMENT"}

                '   Populate Header Text using Loop
                For Header As Integer = 1 To 4
                    ' .Cells(1, Header) = arrHeader(Header)
                    .Cells(4, Header) = arrHeader(Header)
                    .Range(.Cells(4, Header), .Cells(5, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Next

                '   Centerize Cells
                .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
                .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

                '   Loop Days Name Based on Dim days As New List(Of String)
                Dim addDays As Integer = 0
                For I = 0 To days.Count - 1
                    .Cells(4, 5 + addDays) = days(I)
                    .Cells(4, 5 + addDays).interior.color = Color.Gold
                    .Range(.Cells(4, 5 + addDays), .Cells(4, 5 + addDays)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    addDays += 1

                Next

                '   Loop Dates Based on Dim list As New List(Of Integer)
                Dim addDate As Integer = 0
                For j = 0 To list.Count - 1
                    .Cells(5, 5 + addDate) = list(j)
                    .Cells(5, 5 + addDate).interior.color = Color.Gold
                    .Range(.Cells(5, 5 + addDate), .Cells(5, 5 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    addDate += 1
                Next

                'Merge First 4 Headers
                For head As Integer = 1 To 4
                    .Range(.Cells(4, head), .Cells(5, head)).Merge()
                    .Cells(4, head).interior.color = Color.Gold
                    .Range(.Cells(4, head), .Cells(5, head)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Next

                'Declare Header Text in Array and Populate Header Text using Loop

                Dim arrHeader1 As String() = {"NULL", "TOTAL"}

                Dim nextHeader As Integer = 4 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month)
                For header As Integer = 1 To 1
                    .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Merge()
                    .Cells(4, nextHeader + header) = arrHeader1(header)
                    .Cells(4, nextHeader + header).interior.color = Color.Gold
                    .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

                Next
                Dim columnCount = xlWorkSheet.UsedRange.Columns.Count
                .Range(.Cells(1, 1), .Cells(1, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month))).Merge()
                .Range(.Cells(2, 1), .Cells(2, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month))).Merge()
                .Range(.Cells(3, 1), .Cells(3, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month))).Merge()
                .Cells(1, 1) = "PT. CITRA SHIPYARD"
                .Cells(2, 1) = "EMPLOYEE EXIT PERMIT REPORT ( IN MINUTE )"
                .Cells(3, 1) = "Document for: " & dtpAtt.Value.Year & "-" & dtpAtt.Value.Month

            End With


            Dim CR As Microsoft.Office.Interop.Excel.Range = xlWorkSheet.Cells(6, 1)
            CR.Select()
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
            saveError(ex.ToString)
        End Try
    End Sub
    Public Sub exportSC2(ByVal dgv As DataGridView)

        copyAlltoClipboard(dgv)
        Dim xlexcel As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        '    xlWorkBook = xlexcel.Workbooks.Open(Path)
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        xlexcel = New Microsoft.Office.Interop.Excel.Application()
        xlexcel.Visible = True
        xlWorkBook = xlexcel.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim strDates As String

        'To Change Language of the Days to Local Language, eg: Senin --> Monday

        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
        Dim list As New List(Of Integer)
        Dim days As New List(Of String)

        'Get Total Days in the Selected Month (Selected Month = dtpSubProject.Value.Month)
        For dates = 1 To System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)
            list.Add(dates)
            strDates = dtpSubProject.Value.Year.ToString & "/" & dtpSubProject.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
            Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
            Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
            days.Add(dayName)
        Next


        With xlWorkSheet

            '''''HEADER START''''''''

            .Range(.Cells(1, 1), .Cells(1, 5)).Merge()
            .Range(.Cells(2, 1), .Cells(2, 5)).Merge()
            .Cells(1, 1) = "DATE ATTENDANCE SUBCONT PER SUBCONT"
            .Cells(2, 1) = "PERIODE: " & dtpSubProject.Value.Month.ToString("00") & "-" & dtpSubProject.Value.Year

            '   Declare Header Text using Array
            Dim arrHeader As String() = {"NULL", "NO", "SUBCON", "PROJECT"}

            '   Populate Header Text using Loop
            For Header As Integer = 1 To 3
                .Cells(3, Header) = arrHeader(Header)
                '    .Cells(4, Header) = arrHeader(Header)
                .Range(.Cells(3, Header), .Cells(4, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Range(.Cells(3, Header), .Cells(4, Header)).Merge()
            Next

            Dim addDate As Integer = 0

            For j = 0 To list.Count - 1
                .Cells(2, 6) = "MONTHLY REPORT"
                .Range(.Cells(3, 6), .Cells(3, 4 + j)).Merge()
                .Range(.Cells(3, 6), .Cells(3, 4 + j)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Cells(4, 4 + addDate) = list(j)

                '  .Cells(5, 5 + addDate).interior.color = Color.Gold
                .Range(.Cells(4, 4 + addDate), .Cells(4, 4 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                addDate += 1

            Next

            .Cells(3, 4 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)) = "TOTAL"
            .Range(.Cells(3, 4 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)), .Cells(4, 6 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month))).Merge()
            .Range(.Cells(3, 4 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)), .Cells(4, 6 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month))).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            '   Centerize Cells
            .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
            .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

            ''''HEADER END'''''''

            ''''START FILL DATA TO EXCEL
        End With


        Dim CR As Microsoft.Office.Interop.Excel.Range = xlWorkSheet.Cells(5, 1)
        CR.Select()
        xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)
    End Sub
    Public Sub exportSC(ByVal dgv As DataGridView)

        copyAlltoClipboard(dgvSubProject)
        Dim xlexcel As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        '    xlWorkBook = xlexcel.Workbooks.Open(Path)
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        xlexcel = New Microsoft.Office.Interop.Excel.Application()
        xlexcel.Visible = True
        xlWorkBook = xlexcel.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Worksheets(1)

        Dim strDates As String

        'To Change Language of the Days to Local Language, eg: Senin --> Monday

        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
        Dim list As New List(Of Integer)
        Dim days As New List(Of String)

        'Get Total Days in the Selected Month (Selected Month = dtpSubProject.Value.Month)
        For dates = 1 To System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)
            list.Add(dates)
            strDates = dtpSubProject.Value.Year.ToString & "/" & dtpSubProject.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
            Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
            Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
            days.Add(dayName)
        Next


        With xlWorkSheet

            '''''HEADER START''''''''

            .Range(.Cells(1, 1), .Cells(1, 5)).Merge()
            .Range(.Cells(2, 1), .Cells(2, 5)).Merge()
            .Cells(1, 1) = "DATE ATTENDANCE SUBCONT PER PROJECT"
            .Cells(2, 1) = "PERIODE: " & dtpSubProject.Value.Month.ToString("00") & "-" & dtpSubProject.Value.Year

            '   Declare Header Text using Array
            Dim arrHeader As String() = {"NULL", "NO", "HULL NO (NAME PROJECT)", "NO", "SUB-CONT", "JENIS PEKERJAAN"}

            '   Populate Header Text using Loop
            For Header As Integer = 1 To 5
                .Cells(3, Header) = arrHeader(Header)
                '    .Cells(4, Header) = arrHeader(Header)
                .Range(.Cells(3, Header), .Cells(4, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Range(.Cells(3, Header), .Cells(4, Header)).Merge()
            Next

            Dim addDate As Integer = 0

            For j = 0 To list.Count - 1
                .Cells(3, 6) = "MONTHLY REPORT"
                .Range(.Cells(3, 6), .Cells(3, 6 + j)).Merge()
                .Range(.Cells(3, 6), .Cells(3, 6 + j)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Cells(4, 6 + addDate) = list(j)

                '  .Cells(5, 5 + addDate).interior.color = Color.Gold
                .Range(.Cells(4, 6 + addDate), .Cells(4, 6 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                addDate += 1

            Next

            .Cells(3, 6 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)) = "TOTAL"
            .Range(.Cells(3, 6 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)), .Cells(4, 6 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month))).Merge()
            .Range(.Cells(3, 6 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)), .Cells(4, 6 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month))).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            '   Centerize Cells
            .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
            .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

            ''''HEADER END'''''''

            ''''START FILL DATA TO EXCEL
        End With


        Dim CR As Microsoft.Office.Interop.Excel.Range = xlWorkSheet.Cells(5, 1)
        CR.Select()
        xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)

        copyAlltoClipboard(DataGridView3)

        Dim CR1 As Microsoft.Office.Interop.Excel.Range = xlWorkSheet.Cells(5, 6)
        CR1.Select()
        xlWorkSheet.PasteSpecial(CR1, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)
    End Sub
    Public Sub exportReport(ByVal dgv As DataGridView)
        Try
            copyAlltoClipboard(dgv)
            Dim xlexcel As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            xlexcel = New Microsoft.Office.Interop.Excel.Application()
            xlexcel.Visible = True
            xlWorkBook = xlexcel.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Worksheets(1)
            Dim CR As Microsoft.Office.Interop.Excel.Range = xlWorkSheet.Cells(1, 1)
            CR.Select()
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)
        Catch ex As Exception
            saveError(ex.ToString)
        End Try
    End Sub
    Public Sub ExportToExcel(ByVal dgv As DataGridView)

        Dim rowsTotal, colsTotal As Long
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim strDates As String

            'To Change Language of the Days to Local Language, eg: Senin --> Monday

            Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
            Dim list As New List(Of Integer)
            Dim days As New List(Of String)

            'Get Total Days in the Selected Month (Selected Month = dtpAtt.Value.Month)
            For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
                list.Add(dates)
                strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
                Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
                Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
                days.Add(dayName)
            Next

            copyAlltoClipboard(dgv)
            Dim xlexcel As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            '    xlWorkBook = xlexcel.Workbooks.Open(Path)
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            xlexcel = New Microsoft.Office.Interop.Excel.Application()
            xlexcel.Visible = True
            xlWorkBook = xlexcel.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Worksheets(1)

            With xlWorkSheet
                '   Declare Header Text using Array
                Dim arrHeader As String() = {"NULL", "NO", "EMPNO", "EMPNAME", "DEPARTMENT"}

                '   Populate Header Text using Loop
                For Header As Integer = 1 To 4
                    ' .Cells(1, Header) = arrHeader(Header)
                    .Cells(4, Header) = arrHeader(Header)
                    .Range(.Cells(4, Header), .Cells(5, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Next

                '   Centerize Cells
                .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
                .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

                '   Loop Days Name Based on Dim days As New List(Of String)
                Dim addDays As Integer = 0
                For I = 0 To days.Count - 1
                    .Cells(4, 5 + addDays) = days(I)
                    .Cells(4, 5 + addDays).interior.color = Color.Gold
                    .Range(.Cells(4, 5 + addDays), .Cells(4, 5 + addDays)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    addDays += 1
                Next

                '   Loop Dates Based on Dim list As New List(Of Integer)
                Dim addDate As Integer = 0
                For j = 0 To list.Count - 1
                    .Cells(5, 5 + addDate) = list(j)
                    .Cells(5, 5 + addDate).interior.color = Color.Gold
                    .Range(.Cells(5, 5 + addDate), .Cells(5, 5 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    addDate += 1

                Next

                'Merge First 4 Headers
                For head As Integer = 1 To 4
                    .Range(.Cells(4, head), .Cells(5, head)).Merge()
                    .Cells(4, head).interior.color = Color.Gold
                    .Range(.Cells(4, head), .Cells(5, head)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Next

                'Declare Header Text in Array and Populate Header Text using Loop

                Dim arrHeader1 As String() = {"NULL", "TOTAL", "UA", "UL", "MC", "UPL", "SKB", "ML", "DR"}

                Dim nextHeader As Integer = 4 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
                For header As Integer = 1 To 8
                    .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Merge()
                    .Cells(4, nextHeader + header) = arrHeader1(header)
                    .Cells(4, nextHeader + header).interior.color = Color.Gold
                    .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

                Next
                Dim columnCount = xlWorkSheet.UsedRange.Columns.Count
                .Range(.Cells(1, 1), .Cells(1, 5 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month) + 7)).Merge()
                .Range(.Cells(2, 1), .Cells(2, 5 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month) + 7)).Merge()
                .Range(.Cells(3, 1), .Cells(3, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month) + 7)).Merge()
                .Cells(1, 1) = "PT. CITRA SHIPYARD"
                .Cells(1, 1) = "EMPLOYEE ATTENDANCE"
                .Cells(2, 1) = "Attendance Report Date: " & dtpAtt.Value.Year & "-" & dtpAtt.Value.Month



            End With


            Dim CR As Microsoft.Office.Interop.Excel.Range = xlWorkSheet.Cells(6, 1)
            CR.Select()
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
            saveError(ex.ToString)
        End Try
    End Sub
    Public Sub lateExcel(ByVal dgv As DataGridView)

        Dim rowsTotal, colsTotal As Long
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim strDates As String

            'To Change Language of the Days to Local Language, eg: Senin --> Monday

            Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
            Dim list As New List(Of Integer)
            Dim days As New List(Of String)

            'Get Total Days in the Selected Month (Selected Month = dtpAtt.Value.Month)
            For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
                list.Add(dates)
                strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
                Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
                Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
                days.Add(dayName)
            Next

            copyAlltoClipboard(dgv)
            Dim xlexcel As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            '    xlWorkBook = xlexcel.Workbooks.Open(Path)
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            xlexcel = New Microsoft.Office.Interop.Excel.Application()
            xlexcel.Visible = True
            xlWorkBook = xlexcel.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Worksheets(1)

            With xlWorkSheet
                '   Declare Header Text using Array
                Dim arrHeader As String() = {"NULL", "NO", "EMPNO", "EMPNAME", "DEPARTMENT"}

                '   Populate Header Text using Loop
                For Header As Integer = 1 To 4
                    ' .Cells(1, Header) = arrHeader(Header)
                    .Cells(4, Header) = arrHeader(Header)
                    .Range(.Cells(4, Header), .Cells(4, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Next

                '   Centerize Cells
                .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
                .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

                '   Loop Days Name Based on Dim days As New List(Of String)
                Dim addDays As Integer = 0
                For I = 0 To days.Count - 1
                    .Cells(4, 5 + addDays) = days(I)
                    .Cells(4, 5 + addDays).interior.color = Color.Gold
                    .Range(.Cells(4, 5 + addDays), .Cells(4, 5 + addDays)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    addDays += 1

                Next

                '   Loop Dates Based on Dim list As New List(Of Integer)
                Dim addDate As Integer = 0
                For j = 0 To list.Count - 1
                    .Cells(5, 5 + addDate) = list(j)
                    .Cells(5, 5 + addDate).interior.color = Color.Gold
                    .Range(.Cells(5, 5 + addDate), .Cells(5, 5 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    addDate += 1

                Next

                'Merge First 4 Headers
                For head As Integer = 1 To 4
                    .Range(.Cells(4, head), .Cells(5, head)).Merge()
                    .Cells(4, head).interior.color = Color.Gold
                    .Range(.Cells(4, head), .Cells(5, head)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Next

                'Declare Header Text in Array and Populate Header Text using Loop

                Dim arrHeader1 As String() = {"NULL", "TOTAL", "TOTAL LATE"}

                Dim nextHeader As Integer = 4 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month)
                For header As Integer = 1 To 2
                    .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Merge()
                    .Cells(4, nextHeader + header) = arrHeader1(header)
                    .Cells(4, nextHeader + header).interior.color = Color.Gold
                    .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

                Next
                Dim columnCount = xlWorkSheet.UsedRange.Columns.Count
                .Range(.Cells(1, 1), .Cells(1, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month) + 1)).Merge()
                .Range(.Cells(2, 1), .Cells(2, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month) + 1)).Merge()
                .Range(.Cells(3, 1), .Cells(3, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month) + 1)).Merge()
                .Cells(1, 1) = "PT. CITRA SHIPYARD"
                .Cells(2, 1) = "EMPLOYEE LATE REPORT ( IN MINUTE )"
                .Cells(3, 1) = "Document for: " & dtpAtt.Value.Month & "-" & dtpAtt.Value.Year



            End With


            Dim CR As Microsoft.Office.Interop.Excel.Range = xlWorkSheet.Cells(6, 1)
            CR.Select()
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
            saveError(ex.ToString)
        End Try
    End Sub
    Public Sub lateOT(ByVal dgv As DataGridView)

        Dim rowsTotal, colsTotal As Long
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim strDates As String

            'To Change Language of the Days to Local Language, eg: Senin --> Monday

            Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
            Dim list As New List(Of Integer)
            Dim days As New List(Of String)

            'Get Total Days in the Selected Month (Selected Month = dtpAtt.Value.Month)
            For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
                list.Add(dates)
                strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
                Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
                Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
                days.Add(dayName)
            Next

            copyAlltoClipboard(dgv)
            Dim xlexcel As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            '    xlWorkBook = xlexcel.Workbooks.Open(Path)
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            xlexcel = New Microsoft.Office.Interop.Excel.Application()
            xlexcel.Visible = True
            xlWorkBook = xlexcel.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Worksheets(1)

            With xlWorkSheet
                '   Declare Header Text using Array
                Dim arrHeader As String() = {"NULL", "NO", "EMPNO", "EMPNAME", "DEPARTMENT"}

                '   Populate Header Text using Loop
                For Header As Integer = 1 To 4
                    ' .Cells(1, Header) = arrHeader(Header)
                    .Cells(4, Header) = arrHeader(Header)
                    .Range(.Cells(4, Header), .Cells(4, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Next

                '   Centerize Cells
                .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
                .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

                '   Loop Days Name Based on Dim days As New List(Of String)
                Dim addDays As Integer = 0
                For I = 0 To days.Count - 1
                    .Cells(4, 5 + addDays) = days(I)
                    .Cells(4, 5 + addDays).interior.color = Color.Gold
                    .Range(.Cells(4, 5 + addDays), .Cells(4, 5 + addDays)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    addDays += 1

                Next

                '   Loop Dates Based on Dim list As New List(Of Integer)
                Dim addDate As Integer = 0
                For j = 0 To list.Count - 1
                    .Cells(5, 5 + addDate) = list(j)
                    .Cells(5, 5 + addDate).interior.color = Color.Gold
                    .Range(.Cells(5, 5 + addDate), .Cells(5, 5 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    addDate += 1

                Next

                'Merge First 4 Headers
                For head As Integer = 1 To 4
                    .Range(.Cells(4, head), .Cells(5, head)).Merge()
                    .Cells(4, head).interior.color = Color.Gold
                    .Range(.Cells(4, head), .Cells(5, head)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Next

                'Declare Header Text in Array and Populate Header Text using Loop


                Dim columnCount = xlWorkSheet.UsedRange.Columns.Count
                .Range(.Cells(1, 1), .Cells(1, 5 + System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month) + 1)).Merge()
                .Range(.Cells(2, 1), .Cells(2, 5 + System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month) + 1)).Merge()
                .Range(.Cells(3, 1), .Cells(3, 5 + System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month) + 1)).Merge()
                .Cells(1, 1) = "PT. CITRA SHIPYARD"
                .Cells(2, 1) = "EMPLOYEE OVERTIME REPORT"
                .Cells(3, 1) = "Document for: " & dtpAtt.Value.Month & "-" & dtpAtt.Value.Year



            End With


            Dim CR As Microsoft.Office.Interop.Excel.Range = xlWorkSheet.Cells(6, 1)
            CR.Select()
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
            saveError(ex.ToString)
        End Try
    End Sub
    Sub copyAlltoClipboard(ByVal dgv As DataGridView)
        Dim dataObj As DataObject
        dgv.MultiSelect = True
        dgv.SelectAll()
        dataObj = dgv.GetClipboardContent()
        If Not IsNothing(dataObj) Then
            Clipboard.SetDataObject(dataObj)
        End If
        dgv.MultiSelect = False
    End Sub

    Private Sub btnExporttoExcel_Click(sender As Object, e As EventArgs)

        ExportToExcel(dgvEmployee)
        'If dgvReport.RowCount = Nothing Then
        '    MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'Dim rowsTotal, colsTotal As Long
        'Dim I, j, iC As Short
        'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'Dim xlApp As New Excel.Application
        'Try
        '    Dim strDates As String

        '    'To Change Language of the Days to Local Language, eg: Senin --> Monday

        '    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
        '    Dim list As New List(Of Integer)
        '    Dim days As New List(Of String)

        '    'Get Total Days in the Selected Month (Selected Month = dtpAtt.Value.Month)
        '    For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        '        list.Add(dates)
        '        strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
        '        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
        '        Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        '        days.Add(dayName)
        '    Next

        '    Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
        '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
        '    xlApp.Visible = True

        '    With excelWorksheet
        '        '   Declare Header Text using Array
        '        Dim arrHeader As String() = {"NULL", "NO", "EMPNO", "EMPNAME", "DEPARTMENT"}

        '        '   Populate Header Text using Loop
        '        For Header As Integer = 1 To 4
        '            ' .Cells(1, Header) = arrHeader(Header)
        '            .Cells(4, Header) = arrHeader(Header)
        '            .Range(.Cells(4, Header), .Cells(5, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '        Next

        '        '   Centerize Cells
        '        .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
        '        .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

        '        '   Loop Days Name Based on Dim days As New List(Of String)
        '        Dim addDays As Integer = 0
        '        For I = 0 To days.Count - 1
        '            .Cells(4, 5 + addDays) = days(I)
        '            .Cells(4, 5 + addDays).interior.color = Color.Gold
        '            .Range(.Cells(4, 5 + addDays), .Cells(4, 5 + addDays)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            addDays += 1
        '        Next

        '        '   Loop Dates Based on Dim list As New List(Of Integer)
        '        Dim addDate As Integer = 0
        '        For j = 0 To list.Count - 1
        '            .Cells(5, 5 + addDate) = list(j)
        '            .Cells(5, 5 + addDate).interior.color = Color.Gold
        '            .Range(.Cells(5, 5 + addDate), .Cells(5, 5 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            addDate += 1

        '        Next

        '        'Merge First 4 Headers
        '        For head As Integer = 1 To 4
        '            .Range(.Cells(4, head), .Cells(5, head)).Merge()
        '            .Cells(4, head).interior.color = Color.Gold
        '            .Range(.Cells(4, head), .Cells(5, head)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '        Next

        '        'Declare Header Text in Array and Populate Header Text using Loop

        '        Dim arrHeader1 As String() = {"NULL", "TOTAL", "UA", "UL", "MC", "UPL", "SKB", "ML", "DR"}

        '        Dim nextHeader As Integer = 4 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        '        For header As Integer = 1 To 8
        '            .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Merge()
        '            .Cells(4, nextHeader + header) = arrHeader1(header)
        '            .Cells(4, nextHeader + header).interior.color = Color.Gold
        '            .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

        '        Next
        '        Dim columnCount = excelWorksheet.UsedRange.Columns.Count
        '        .Range(.Cells(1, 1), .Cells(1, 5 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month) + 7)).Merge()
        '        .Range(.Cells(2, 1), .Cells(2, 5 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month) + 7)).Merge()
        '        .Range(.Cells(3, 1), .Cells(3, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month) + 7)).Merge()
        '        .Cells(1, 1) = "PT. CITRA SHIPYARD"
        '        .Cells(1, 1) = "EMPLOYEE ATTENDANCE"
        '        .Cells(2, 1) = "Attendance Report Date: " & dtpAtt.Value.Year & "-" & dtpAtt.Value.Month
        '        rowsTotal = dgvEmployee.RowCount - 1
        '        colsTotal = dgvEmployee.Columns.Count - 1
        '        Try
        '            For I = 0 To rowsTotal
        '                For j = 0 To colsTotal
        '                    .Cells(I + 6, j + 1).value = dgvEmployee.Rows(I).Cells(j).Value


        '                    'If .Cells(I + 6, j + 1) = "0" Then
        '                    '    .Cells(I + 6, j + 1).interior.color = Color.Red
        '                    'Else
        '                    '    .Cells(I + 6, j + 1).interior.color = Color.Blue
        '                    'End If


        '                    .Cells(I + 6, j + 1).borders.linestyle = Excel.XlLineStyle.xlContinuous

        '                Next j
        '            Next I


        '        Catch ex As Exception

        '        End Try

        '    End With

        'Finally
        '    'RELEASE ALLOACTED RESOURCES
        '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        '    xlApp = Nothing
        'End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If dgvEmployee.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Long
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True
            rowsTotal = dgvEmployee.RowCount - 1
            colsTotal = dgvEmployee.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgvEmployee.Columns(iC).HeaderText
                Next

                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 6, j + 1).value = dgvEmployee.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12
                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
                .Cells.NumberFormat = "0"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Sub getExitAttendance()
        Dim total, increment As Integer
        total = 0
        increment = 0
        For t As Integer = 0 To dgvExit.Rows.Count - 1
            total = 0
            For k As Integer = 5 To dgvExit.Columns.Count - 1
                total = total + dgvExit.Rows(t).Cells(k).Value
            Next
            dgvExit.Rows(t).Cells(4 + System.DateTime.DaysInMonth(dtpExit.Value.Year, dtpExit.Value.Month)).Value = total
        Next

    End Sub

    Sub getLateAttendance()

        If dgvLate.Columns.Contains("TOTAL") Then
        Else
            dsLate.Tables(0).Columns.Add("TOTAL", GetType(String))
        End If
        If dgvLate.Columns.Contains("TOTAL LATE") Then
        Else
            dsLate.Tables(0).Columns.Add("TOTAL LATE", GetType(String))
        End If
        Dim total, increment As Integer
        total = 0
        increment = 0
        For t As Integer = 0 To dgvLate.Rows.Count - 1
            total = 0
            For k As Integer = 4 To dgvLate.Columns.Count - 2
                If dgvLate.Rows(t).Cells(k).Value.ToString = "" Then
                    dgvLate.Rows(t).Cells(k).Value = "0"
                ElseIf dgvLate.Rows(t).Cells(k).Value.ToString <= 0 Then
                    dgvLate.Rows(t).Cells(k).Value = "0"
                End If
                total = total + dgvLate.Rows(t).Cells(k).Value.ToString
            Next
            dgvLate.Rows(t).Cells(4 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month)).Value = total
        Next

        Dim cellvaluescount As Integer = 0
        For iCol As Integer = 0 To dgvLate.Rows.Count - 1
            cellvaluescount = 0
            For jCol As Integer = 4 To System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month)
                If dgvLate.Rows(iCol).Cells(jCol).Value <> 0 And dgvLate.Rows(iCol).Cells(jCol).Value > 0 Then
                    cellvaluescount = cellvaluescount + 1
                End If
            Next
            dgvLate.Rows(iCol).Cells(5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month)).Value = cellvaluescount
        Next
        Dim count As Integer = 0
        For iCols As Integer = 0 To dgvLate.Rows.Count - 1
            count = count + 1
            dgvLate.Rows(iCols).Cells(0).Value = count
        Next

        For tt As Integer = 0 To dgvLate.Rows.Count - 1
            total = 0
            For kk As Integer = 4 To dgvLate.Columns.Count - 2
                If dgvLate.Rows(tt).Cells(kk).Value.ToString = "0" Then
                    dgvLate.Rows(tt).Cells(kk).Value = DBNull.Value
                End If
            Next

        Next
    End Sub
    Sub getTotalMP()
        DataGridView3.Columns.Add(1 + System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month), "TOTAL")
        Dim total, increment As Integer
        total = 0
        increment = 0
        For t As Integer = 0 To DataGridView3.Rows.Count - 1
            total = 0
            For k As Integer = 0 To DataGridView3.Columns.Count - 1
                total = total + DataGridView3.Rows(t).Cells(k).Value
            Next
            DataGridView3.Rows(t).Cells(System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)).Value = total
        Next
    End Sub
    Sub getTotalAttendance()
        If dgvEmployee.Columns.Contains("TOTAL") Then
        Else
            dsAttendance.Tables(0).Columns.Add("TOTAL", GetType(String))
        End If

        Dim total, increment As Integer
        total = 0
        increment = 0
        For t As Integer = 0 To dgvEmployee.Rows.Count - 1
            total = 0

            For k As Integer = 5 To dgvEmployee.Columns.Count - 2
                If dgvEmployee.Rows(t).Cells(k).Value.ToString = " " Then
                    total = total + 0
                Else
                    total = total + dgvEmployee.Rows(t).Cells(k).Value.ToString
                End If
            Next

            dsAttendance.Tables(0).Rows(t)(3 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)) = total
            '    dgvEmployee.Rows(t).Cells(4 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)).Value = total
        Next


    End Sub
    Private Sub btnGetLate_Click_1(sender As Object, e As EventArgs) Handles btnGetLate.Click
        dsLate.Clear()
        dsLate.Tables.Clear()
        dgvLate.DataSource = Nothing
        dgvLate.Rows.Clear()
        Dim query As List(Of String)

        Dim days As New List(Of String)
        Dim value5 As String
        Dim dd As String
        For i As Integer = 1 To System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month)
            days.Add("[" & dtpLateAtt.Value.Year & "-" & dtpLateAtt.Value.Month.ToString("00") & "-" & i.ToString("00") & "]")
            dd = dtpLateAtt.Value.Year & "-" & dtpLateAtt.Value.Month.ToString("00") & "-" & i.ToString("00")
        Next
        Dim result As String = String.Join(", ", days)

        Try
            Dim adaptor As New SqlDataAdapter
            openConnection()
            If cbbLateDPT.Text = "" And txtLateEMPname.Text = "" Then

                adaptor = New SqlDataAdapter("
             
            SELECT userId, FORMAT([timestamp], 'yyyy-MM-dd') 'timestamp', 
            datediff(minute,FORMAT([timestamp],'yyyy-MM-dd') + ' 08:00:00',[timestamp]) 'Lates' INTO #tTable FROM tReport 
            WHERE [timestamp] >= CAST(FORMAT([timestamp],'yyyy-MM-dd') +  ' 08:00:00' AS date) AND InOutMode = 'Check In' 
            SELECT userId, " & result & " INTO #tLate 
            FROM (SELECT userId, [timestamp], Lates FROM #tTable) s
            PIVOT
            (
            SUM(Lates) for [timestamp] in (" & result & ")
            ) piv
       
            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department',  " & result & "
            FROM #tLate FULL JOIN tDeviceUser2 ON tDeviceUser2.userId = #tLate.userId ORDER BY tDeviceUser2.userId ASC

            DROP TABLE #tLate
            DROP TABLE #tTable
                ", conn)
                '    Next

            ElseIf cbbLateDPT.Text <> "" And txtLateEMPname.Text = "" Then
                adaptor = New SqlDataAdapter("
              
            SELECT userId, FORMAT([timestamp], 'yyyy-MM-dd') 'timestamp', 
            datediff(minute,FORMAT([timestamp],'yyyy-MM-dd') + ' 08:00:00',[timestamp]) 'Lates' INTO #tTable FROM tReport 
            WHERE [timestamp] >= CAST(FORMAT([timestamp],'yyyy-MM-dd') +  ' 08:00:00' AS date ) AND InOutMode = 'Check In'
            SELECT userId, " & result & " INTO #tLate 
            FROM (SELECT userId, [timestamp], Lates FROM #tTable) s
            PIVOT
            (
            SUM(Lates) for [timestamp] in (" & result & ")
            ) piv
          

         SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department',  " & result & "
            FROM #tLate FULL JOIN tDeviceUser2 ON tDeviceUser2.userId = #tLate.userId WHERE tDeviceUser2.departmentName Like '%" + cbbLateDPT.Text + "%" + "' ORDER BY tDeviceUser2.userId ASC

            DROP TABLE #tLate
            DROP TABLE #tTable", conn)

            ElseIf txtLateEMPname.Text <> "" And cbbLateDPT.Text = "" Then
                adaptor = New SqlDataAdapter("
              
            SELECT userId, FORMAT([timestamp], 'yyyy-MM-dd') 'timestamp', 
            datediff(minute,FORMAT([timestamp],'yyyy-MM-dd') + ' 08:00:00',[timestamp]) 'Lates' INTO #tTable FROM tReport 
            WHERE [timestamp] >= CAST(FORMAT([timestamp],'yyyy-MM-dd') +  ' 08:00:00' AS date ) AND InOutMode = 'Check In'
            SELECT userId, " & result & " INTO #tLate 
            FROM (SELECT userId, [timestamp], Lates FROM #tTable) s
            PIVOT
            (
            SUM(Lates) for [timestamp] in (" & result & ")
            ) piv
          

         SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department',  " & result & "
            FROM #tLate FULL JOIN tDeviceUser2 ON tDeviceUser2.userId = #tLate.userId WHERE tDeviceUser2.employeeName Like '%" + txtLateEMPname.Text + "%" + "' ORDER BY tDeviceUser2.userId ASC

            DROP TABLE #tLate
            DROP TABLE #tTable", conn)

            ElseIf cbbLateDPT.Text <> "" And txtLateEMPname.Text <> "" Then
                adaptor = New SqlDataAdapter("
              
            SELECT userId, FORMAT([timestamp], 'yyyy-MM-dd') 'timestamp', 
            datediff(minute,FORMAT([timestamp],'yyyy-MM-dd') + ' 08:00:00',[timestamp]) 'Lates' INTO #tTable FROM tReport 
            WHERE [timestamp] >= CAST(FORMAT([timestamp],'yyyy-MM-dd') +  ' 08:00:00' AS date ) AND InOutMode = 'Check In'
            SELECT userId, " & result & " INTO #tLate 
            FROM (SELECT userId, [timestamp], Lates FROM #tTable) s
            PIVOT
            (
            SUM(Lates) for [timestamp] in (" & result & ")
            ) piv
          

            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department',  " & result & "
            FROM #tLate FULL JOIN tDeviceUser2 ON tDeviceUser2.userId = #tLate.userId WHERE tDeviceUser2.departmentName Like '%" + cbbLateDPT.Text + "%" + "' AND tDeviceUser2.employeeName Like '%" + txtLateEMPname.Text + "%" + "'ORDER BY tDeviceUser2.userId ASC

            DROP TABLE #tLate
            DROP TABLE #tTable", conn)

            End If

            adaptor.Fill(dsLate, "Report")
            dgvLate.DataSource = dsLate.Tables("Report")

        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try

        getLateAttendance()

    End Sub

    Private Sub btnLateExcel_Click(sender As Object, e As EventArgs) Handles btnLateExcel.Click


        lateExcel(dgvLate)
        'Dim rowsTotal, colsTotal As Long
        'Dim I, j, iC As Short
        'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'Dim xlApp As New Excel.Application
        'Try
        '    Dim strDates As String

        '    'To Change Language of the Days to Local Language, eg: Senin --> Monday

        '    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
        '    Dim list As New List(Of Integer)
        '    Dim days As New List(Of String)

        '    'Get Total Days in the Selected Month (Selected Month = dtpAtt.Value.Month)
        '    For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        '        list.Add(dates)
        '        strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
        '        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
        '        Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        '        days.Add(dayName)
        '    Next

        '    Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
        '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
        '    xlApp.Visible = True

        '    With excelWorksheet
        '        '   Declare Header Text using Array
        '        Dim arrHeader As String() = {"NULL", "NO", "EMPNO", "EMPNAME", "DEPARTMENT"}

        '        '   Populate Header Text using Loop
        '        For Header As Integer = 1 To 4
        '            ' .Cells(1, Header) = arrHeader(Header)
        '            .Cells(4, Header) = arrHeader(Header)
        '            .Range(.Cells(4, Header), .Cells(4, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '        Next

        '        '   Centerize Cells
        '        .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
        '        .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

        '        '   Loop Days Name Based on Dim days As New List(Of String)
        '        Dim addDays As Integer = 0
        '        For I = 0 To days.Count - 1
        '            .Cells(4, 5 + addDays) = days(I)
        '            .Cells(4, 5 + addDays).interior.color = Color.Gold
        '            .Range(.Cells(4, 5 + addDays), .Cells(4, 5 + addDays)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            addDays += 1

        '        Next

        '        '   Loop Dates Based on Dim list As New List(Of Integer)
        '        Dim addDate As Integer = 0
        '        For j = 0 To list.Count - 1
        '            .Cells(5, 5 + addDate) = list(j)
        '            .Cells(5, 5 + addDate).interior.color = Color.Gold
        '            .Range(.Cells(5, 5 + addDate), .Cells(5, 5 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            addDate += 1

        '        Next

        '        'Merge First 4 Headers
        '        For head As Integer = 1 To 4
        '            .Range(.Cells(4, head), .Cells(5, head)).Merge()
        '            .Cells(4, head).interior.color = Color.Gold
        '            .Range(.Cells(4, head), .Cells(5, head)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '        Next

        '        'Declare Header Text in Array and Populate Header Text using Loop

        '        Dim arrHeader1 As String() = {"NULL", "TOTAL", "TOTAL LATE"}

        '        Dim nextHeader As Integer = 4 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month)
        '        For header As Integer = 1 To 2
        '            .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Merge()
        '            .Cells(4, nextHeader + header) = arrHeader1(header)
        '            .Cells(4, nextHeader + header).interior.color = Color.Gold
        '            .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

        '        Next
        '        Dim columnCount = excelWorksheet.UsedRange.Columns.Count
        '        .Range(.Cells(1, 1), .Cells(1, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month) + 1)).Merge()
        '        .Range(.Cells(2, 1), .Cells(2, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month) + 1)).Merge()
        '        .Range(.Cells(3, 1), .Cells(3, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month) + 1)).Merge()
        '        .Cells(1, 1) = "PT. CITRA SHIPYARD"
        '        .Cells(2, 1) = "EMPLOYEE LATE REPORT ( IN MINUTE )"
        '        .Cells(3, 1) = "Document for: " & dtpAtt.Value.Month & "-" & dtpAtt.Value.Year
        '        rowsTotal = dgvLate.RowCount - 1
        '        colsTotal = dgvLate.Columns.Count - 1
        '        Try
        '            For I = 0 To rowsTotal
        '                For j = 0 To colsTotal
        '                    .Cells(I + 6, j + 1).value = dgvLate.Rows(I).Cells(j).Value
        '                    .Cells(I + 6, j + 1).borders.linestyle = Excel.XlLineStyle.xlContinuous
        '                Next j
        '            Next I
        '        Catch ex As Exception
        '        End Try
        '    End With
        'Finally
        '    'RELEASE ALLOACTED RESOURCES
        '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        '    xlApp = Nothing
        'End Try
    End Sub

    Private Sub btnGetExit_Click(sender As Object, e As EventArgs) Handles btnGetExit.Click
        Try

            dsExitPermit.Clear()
            dsExitPermit.Tables.Clear()
            dgvExit.DataSource = Nothing
            dgvExit.Rows.Clear()
            Dim query As List(Of String)

            Dim days As New List(Of String)
            Dim value5 As String
            Dim dd As String
            For i As Integer = 1 To System.DateTime.DaysInMonth(dtpExit.Value.Year, dtpExit.Value.Month)
                days.Add("[" & dtpExit.Value.Year & "-" & dtpExit.Value.Month.ToString("00") & "-" & i.ToString("00") & "]")
                dd = dtpExit.Value.Year & "-" & dtpExit.Value.Month.ToString("00") & "-" & i.ToString("00")
            Next
            Dim result As String = String.Join(", ", days)

            Try
                Dim adaptor As New SqlDataAdapter
                openConnection()


                adaptor = New SqlDataAdapter("
             
           
			    SELECT * INTO #BreakOut FROM tReport WHERE InOutMode = 'Break Out'
			    SELECT * INTO #BreakIn FROM tReport WHERE InOutMode = 'Break In' 

			    SELECT tReport.userId, FORMAT(tReport.[timestamp], 'yyyy-MM-dd') 'timestamp',
			    (
				    SELECT CONVERT(float,DATEDIFF(minute,#BreakOut.[timestamp], #BreakIn.[timestamp]) / 60.0)
			    )  'ExitPermit' 
			    INTO #tTable FROM tReport 
		
			    FULL JOIN #BreakOut ON tReport.userId = #BreakOut.userId
			    FULL JOIN #BreakIn ON tReport.userId = #BreakIn.userId 

			    SELECT userId, " + result + "  INTO #tLate
			    FROM 
			    (
				    SELECT userId, [timestamp], ExitPermit FROM #tTable
			    ) s
			
			    PIVOT 
			    (
				    SUM(ExitPermit) FOR [timestamp] IN (" + result + " )
			    ) piv

			

                SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department',  " & result & "
                FROM #tLate INNER JOIN tDeviceUser2 ON tDeviceUser2.userId = #tLate.userId ORDER BY tDeviceUser2.userId ASC

			    DROP TABLE #tLate
			    DROP TABLE #tTable
			    DROP TABLE #BreakOut
			    DROP TABLE #BreakIn

                ", conn)

                adaptor.Fill(dsExitPermit, "Report")
                dgvExit.DataSource = dsExitPermit.Tables("Report")
                Dim count As Integer = 0
                For iCols As Integer = 0 To dgvExit.Rows.Count - 1
                    count = count + 1
                    dgvExit.Rows(iCols).Cells(0).Value = count
                Next
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try


            'dgvExit.DataSource = Nothing
            'dgvExit.Rows.Clear()
            'dgvExit.Columns.Clear()
            'MsgBox("This process may take a few minutes. Please wait!")
            'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            'openConnection()
            'populatePermitUser()
            'generatePermitDGV()
            'Dim cmd As New SqlCommand
            'Dim cmdBreakIn As New SqlCommand
            'Dim cmdBreakOut As New SqlCommand
            'Dim datas As Integer
            'Dim lst As New List(Of Integer)
            'Dim count As Integer = 1
            'For j As Integer = 0 To dgvExitUser.Rows.Count - 1
            '    lst.Clear()
            '    For i As Integer = 1 To System.DateTime.DaysInMonth(dtpExit.Value.Year, dtpExit.Value.Month)
            '        If cbbLateDPT.Text = "" Then
            '            cmdBreakOut = New SqlCommand("
            '    SELECT * FROM tReport WHERE personellName = '" & dgvExitUser.Rows(j).Cells(2).Value & "' AND InOutMode = 'Break Out'
            '    AND DATEPART(yy,[timestamp]) = '" & dtpExit.Value.Year & "'
            '    AND DATEPART(mm,[timestamp]) = '" & dtpExit.Value.Month & "'
            '    AND DATEPART(dd,[timestamp]) = '" & i & "'", conn)

            '            cmdBreakIn = New SqlCommand("
            '    SELECT * FROM tReport WHERE personellName = '" & dgvExitUser.Rows(j).Cells(2).Value & "' AND InOutMode = 'Break In'
            '    AND DATEPART(yy,[timestamp]) = '" & dtpExit.Value.Year & "'
            '    AND DATEPART(mm,[timestamp]) = '" & dtpExit.Value.Month & "'
            '    AND DATEPART(dd,[timestamp]) = '" & i & "'", conn)

            '        Else

            '            cmdBreakOut = New SqlCommand("
            '    SELECT * FROM tReport WHERE personellName = '" & dgvExitUser.Rows(j).Cells(2).Value & "' AND departmentName = '" & dgvExitUser.Rows(j).Cells(1).Value & "' AND InOutMode = 'Break Out' 
            '    AND DATEPART(yy,[timestamp]) = '" & dtpExit.Value.Year & "'
            '    AND DATEPART(mm,[timestamp]) = '" & dtpExit.Value.Month & "'
            '    AND DATEPART(dd,[timestamp]) = '" & i & "'", conn)

            '            cmdBreakIn = New SqlCommand("
            '    SELECT * FROM tReport WHERE personellName = '" & dgvExitUser.Rows(j).Cells(2).Value & "' AND departmentName = '" & dgvExitUser.Rows(j).Cells(1).Value & "' AND InOutMode = 'Break In' 
            '    AND DATEPART(yy,[timestamp]) = '" & dtpExit.Value.Year & "'
            '    AND DATEPART(mm,[timestamp]) = '" & dtpExit.Value.Month & "'
            '    AND DATEPART(dd,[timestamp]) = '" & i & "'", conn)
            '        End If

            '        Dim minDiff As String

            '        Dim dReader As SqlDataReader
            '        dReader = cmdBreakOut.ExecuteReader
            '        dReader.Read()

            '        If dReader.HasRows = True Then

            '            Dim dReader2 As SqlDataReader
            '            dReader2 = cmdBreakIn.ExecuteReader
            '            dReader2.Read()

            '            If dReader2.HasRows = True Then
            '                minDiff = DateDiff(DateInterval.Minute, dReader.Item("timestamp"), dReader2.Item("timestamp"))
            '                lst.Add(minDiff)
            '            Else
            '                datas = 0
            '                lst.Add(datas)
            '            End If

            '        Else
            '            datas = 0
            '            lst.Add(datas)
            '        End If

            '    Next

            '    If System.DateTime.DaysInMonth(dtpExit.Value.Year, dtpExit.Value.Month) = 31 Then
            '        dgvExit.Rows.Add(count, dgvExitUser.Rows(j).Cells(0).Value, dgvExitUser.Rows(j).Cells(2).Value, dgvExitUser.Rows(j).Cells(1).Value, lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29), lst(30))
            '        count = count + 1
            '    ElseIf System.DateTime.DaysInMonth(dtpExit.Value.Year, dtpExit.Value.Month) = 30 Then
            '        dgvExit.Rows.Add(count, dgvExitUser.Rows(j).Cells(0).Value, dgvExitUser.Rows(j).Cells(2).Value, dgvExitUser.Rows(j).Cells(1).Value, lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29))
            '        count = count + 1
            '    ElseIf System.DateTime.DaysInMonth(dtpExit.Value.Year, dtpExit.Value.Month) = 28 Then
            '        dgvExit.Rows.Add(count, dgvExitUser.Rows(j).Cells(0).Value, dgvExitUser.Rows(j).Cells(2).Value, dgvExitUser.Rows(j).Cells(1).Value, lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27))
            '        count = count + 1
            '    End If

            'Next
        Catch ex As Exception
            MsgBox("Error Occured when Trying to Generate Exit Permit Report")
            saveError(ex.ToString())
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnExportEXIT_Click(sender As Object, e As EventArgs) Handles btnExportEXIT.Click
        exportExit(dgvExit)
        'Dim rowsTotal, colsTotal As Long
        'Dim I, j, iC As Short
        'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'Dim xlApp As New Excel.Application
        'Try
        '    Dim strDates As String

        '    'To Change Language of the Days to Local Language, eg: Senin --> Monday

        '    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
        '    Dim list As New List(Of Integer)
        '    Dim days As New List(Of String)

        '    'Get Total Days in the Selected Month (Selected Month = dtpAtt.Value.Month)
        '    For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        '        list.Add(dates)
        '        strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
        '        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
        '        Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        '        days.Add(dayName)
        '    Next

        '    Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
        '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
        '    xlApp.Visible = True

        '    With excelWorksheet
        '        '   Declare Header Text using Array
        '        Dim arrHeader As String() = {"NULL", "NO", "EMPNO", "EMPNAME", "DEPARTMENT"}

        '        '   Populate Header Text using Loop
        '        For Header As Integer = 1 To 4
        '            ' .Cells(1, Header) = arrHeader(Header)
        '            .Cells(4, Header) = arrHeader(Header)
        '            .Range(.Cells(4, Header), .Cells(5, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '        Next

        '        '   Centerize Cells
        '        .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
        '        .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

        '        '   Loop Days Name Based on Dim days As New List(Of String)
        '        Dim addDays As Integer = 0
        '        For I = 0 To days.Count - 1
        '            .Cells(4, 5 + addDays) = days(I)
        '            .Cells(4, 5 + addDays).interior.color = Color.Gold
        '            .Range(.Cells(4, 5 + addDays), .Cells(4, 5 + addDays)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            addDays += 1

        '        Next

        '        '   Loop Dates Based on Dim list As New List(Of Integer)
        '        Dim addDate As Integer = 0
        '        For j = 0 To list.Count - 1
        '            .Cells(5, 5 + addDate) = list(j)
        '            .Cells(5, 5 + addDate).interior.color = Color.Gold
        '            .Range(.Cells(5, 5 + addDate), .Cells(5, 5 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            addDate += 1
        '        Next

        '        'Merge First 4 Headers
        '        For head As Integer = 1 To 4
        '            .Range(.Cells(4, head), .Cells(5, head)).Merge()
        '            .Cells(4, head).interior.color = Color.Gold
        '            .Range(.Cells(4, head), .Cells(5, head)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '        Next

        '        'Declare Header Text in Array and Populate Header Text using Loop

        '        Dim arrHeader1 As String() = {"NULL", "TOTAL"}

        '        Dim nextHeader As Integer = 4 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month)
        '        For header As Integer = 1 To 1
        '            .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Merge()
        '            .Cells(4, nextHeader + header) = arrHeader1(header)
        '            .Cells(4, nextHeader + header).interior.color = Color.Gold
        '            .Range(.Cells(4, nextHeader + header), .Cells(5, nextHeader + header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

        '        Next
        '        Dim columnCount = excelWorksheet.UsedRange.Columns.Count
        '        .Range(.Cells(1, 1), .Cells(1, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month))).Merge()
        '        .Range(.Cells(2, 1), .Cells(2, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month))).Merge()
        '        .Range(.Cells(3, 1), .Cells(3, 5 + System.DateTime.DaysInMonth(dtpLateAtt.Value.Year, dtpLateAtt.Value.Month))).Merge()
        '        .Cells(1, 1) = "PT. CITRA SHIPYARD"
        '        .Cells(2, 1) = "EMPLOYEE EXIT PERMIT REPORT ( IN MINUTE )"
        '        .Cells(3, 1) = "Document for: " & dtpAtt.Value.Year & "-" & dtpAtt.Value.Month
        '        rowsTotal = dgvExit.RowCount - 1
        '        colsTotal = dgvExit.Columns.Count - 1
        '        Try
        '            For I = 0 To rowsTotal
        '                For j = 0 To colsTotal
        '                    .Cells(I + 6, j + 1).value = dgvExit.Rows(I).Cells(j).Value
        '                    .Cells(I + 6, j + 1).borders.linestyle = Excel.XlLineStyle.xlContinuous
        '                Next j
        '            Next I
        '        Catch ex As Exception
        '        End Try
        '    End With
        'Finally
        '    'RELEASE ALLOACTED RESOURCES
        '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        '    xlApp = Nothing
        'End Try
    End Sub

    'Private Sub btnGetOT_Click(sender As Object, e As EventArgs)
    '    dgvOT.DataSource = Nothing
    '    dgvOT.Rows.Clear()
    '    dgvOT.Columns.Clear()
    '    MsgBox("This process may take a few minutes. Please wait!")
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '    openConnection()
    '    populateOTUser()
    '    ' generatePermitDGV()
    '    generateOTDGV()
    '    Dim cmd As New SqlCommand
    '    Dim datas As Integer
    '    Dim lst As New List(Of Integer)
    '    Dim count As Integer = 1
    '    For j As Integer = 0 To dgvOTUser.Rows.Count - 1
    '        lst.Clear()
    '        For i As Integer = 1 To System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month)
    '            If cbbOTDepart.Text = "" Then
    '                cmd = New SqlCommand("
    '            SELECT * FROM tReport WHERE personellName = '" & dgvOTUser.Rows(j).Cells(2).Value & "' AND InOutMode = 'Check Out' 
    '            AND DATEPART(yy,[timestamp]) = '" & dtpOT.Value.Year & "'
    '            AND DATEPART(mm,[timestamp]) = '" & dtpOT.Value.Month & "'
    '            AND DATEPART(dd,[timestamp]) = '" & i & "'", conn)
    '            Else
    '                cmd = New SqlCommand("
    '            SELECT * FROM tReport WHERE personellName = '" & dgvOTUser.Rows(j).Cells(2).Value & "' AND departmentName = '" & dgvOTUser.Rows(j).Cells(1).Value & "' AND InOutMode = 'Check Out' 
    '            AND DATEPART(yy,[timestamp]) = '" & dtpOT.Value.Year & "'
    '            AND DATEPART(mm,[timestamp]) = '" & dtpOT.Value.Month & "'
    '            AND DATEPART(dd,[timestamp]) = '" & i & "'", conn)
    '            End If
    '            Dim minDiff As String
    '            Dim workHours As Date = dtpOT.Value.Year & "-" & dtpOT.Value.Month & "-" & i & " 08:30"
    '            Dim dReader As SqlDataReader
    '            dReader = cmd.ExecuteReader
    '            dReader.Read()

    '            If dReader.HasRows = True Then

    '                minDiff = DateDiff(DateInterval.Minute, workHours, dReader.Item("timestamp"))
    '                lst.Add(minDiff)
    '            Else
    '                datas = 0
    '                lst.Add(datas)
    '            End If

    '        Next

    '        If System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month) = 31 Then
    '            dgvOT.Rows.Add(count, dgvOTUser.Rows(j).Cells(0).Value, dgvOTUser.Rows(j).Cells(2).Value, dgvOTUser.Rows(j).Cells(1).Value, lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29), lst(30))
    '            count = count + 1
    '        ElseIf System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month) = 30 Then
    '            dgvOT.Rows.Add(count, dgvOTUser.Rows(j).Cells(0).Value, dgvOTUser.Rows(j).Cells(2).Value, dgvOTUser.Rows(j).Cells(1).Value, lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29))
    '            count = count + 1
    '        ElseIf System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month) = 28 Then
    '            dgvOT.Rows.Add(count, dgvOTUser.Rows(j).Cells(0).Value, dgvOTUser.Rows(j).Cells(2).Value, dgvOTUser.Rows(j).Cells(1).Value, lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27))
    '            count = count + 1
    '        End If

    '    Next
    '    getLateAttendance()
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default



    'End Sub
    Sub showProjectName()
        '    Sub showDGV()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT * FROM tProject
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Report")
            DataGridView2.DataSource = ds.Tables("Report")
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub
    Sub showProject()
        '    Sub showDGV()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT * FROM tProjectDet
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Report")
            DataGridView1.DataSource = ds.Tables("Report")
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub btnSubProject_Click(sender As Object, e As EventArgs) Handles btnSubProject.Click
        dgvSubProject.Rows.Clear()
        DataGridView3.Rows.Clear()
        '   dgvSubProject.Columns.Clear()
        dgvSubProject.DataSource = Nothing
        Dim list As New List(Of Integer)
        Dim strDates As String
        showProject()
        showProjectName()
        Dim firstInt As Integer = 1
        Dim secondInt As Integer = 1
        dgvSubProject.Columns(0).Width = 30
        dgvSubProject.Columns(2).Width = 30
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        For iDGV As Integer = 0 To DataGridView2.Rows.Count - 1

            Try

                openConnection()
                Dim adaptor As New SqlDataAdapter("SELECT * FROM tProjectDet where ProjectCode = '" & DataGridView2.Rows(iDGV).Cells(0).Value & "'
        ", conn)
                Dim ds As New DataSet
                adaptor.Fill(ds, "Report")
                DataGridView1.DataSource = ds.Tables("Report")
            Catch ex As Exception
                MsgBox(ex.ToString())
                saveError(ex.ToString())
            End Try

            For iCols As Integer = 0 To DataGridView1.Rows.Count - 1

                dgvSubProject.Rows.Add(firstInt, DataGridView1.Rows(iCols).Cells(1).Value, secondInt, DataGridView1.Rows(iCols).Cells(2).Value, DataGridView1.Rows(iCols).Cells(3).Value)
                secondInt = secondInt + 1
            Next
            Dim count = (From row As DataGridViewRow In dgvSubProject.Rows
                         Where row.Cells(1).Value = DataGridView2.Rows(iDGV).Cells(1).Value And row.Cells(1).Value IsNot DBNull.Value
                         Select row.Cells(1).Value).Count()

            dgvSubProject.Rows.Add("TOTAL", "SUBCONT", count, "TOTAL MANPOWER PER PROJECT", " ")
            secondInt = 1
            firstInt = firstInt + 1
        Next

        For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
            list.Add(dates)
            strDates = dtpSubProject.Value.Year.ToString & "/" & dtpSubProject.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
            DataGridView3.Columns.Add(dates, dates)
        Next

        Dim cmd As New SqlCommand
        Dim datas As Integer
        Dim lst As New List(Of Integer)
        Dim countt As Integer = 1
        For j As Integer = 0 To dgvSubProject.Rows.Count - 1
            lst.Clear()
            For i As Integer = 1 To System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)

                cmd = New SqlCommand("
                SELECT COUNT(*) Total FROM (
                select tprojectemp.employeeno 'employee number', tprojectemp.employeename 'employee name', 
                treport.[timestamp], treport.inoutmode,tprojectemp.projectcode 'project code',
                tprojectemp.projectname 'project name', tprojectemp.subconid,
                tprojectemp.subconname
                from tprojectemp 
                inner join tdeviceuser2 on tdeviceuser2.employeeno = tprojectemp.employeeno 
                inner join treport on tprojectemp.employeeno= treport.empno where projectName = '" & dgvSubProject.Rows(j).Cells(1).Value & "'
                and subconName = '" & dgvSubProject.Rows(j).Cells(3).Value.ToString & "'
                and datepart(yy,[timestamp]) = '" & dtpSubProject.Value.Year & "'
                and datepart(mm,[timestamp]) = '" & dtpSubProject.Value.Month & "'
                and datepart(dd,[timestamp]) = '" & i & "'
                and inoutmode = 'check in') ct", conn)

                Dim mindiff As String

                Dim dreader As SqlDataReader
                dreader = cmd.ExecuteReader
                dreader.Read()

                If dreader.HasRows = True Then
                    lst.Add(dreader.Item("Total"))
                Else
                    datas = 0
                    lst.Add(datas)
                End If

            Next

            If System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month) = 31 Then

                DataGridView3.Rows.Add(lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29), lst(30))

            ElseIf System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month) = 30 Then
                DataGridView3.Rows.Add(lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29))

            ElseIf System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month) = 28 Then
                DataGridView3.Rows.Add(lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27))

            End If

        Next
        getTotalMP()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        exportSC(DataGridView3)
        'Dim rowsTotal, colsTotal As Long
        'Dim I, j, iC As Short
        'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'Dim xlApp As New Excel.Application
        'Try
        '    Dim strDates As String

        '    'To Change Language of the Days to Local Language, eg: Senin --> Monday

        '    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.GetCultureInfo("id-ID")
        '    Dim list As New List(Of Integer)
        '    Dim days As New List(Of String)

        '    'Get Total Days in the Selected Month (Selected Month = dtpAtt.Value.Month)
        '    For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        '        list.Add(dates)
        '        strDates = dtpAtt.Value.Year.ToString & "/" & dtpAtt.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
        '        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(strDates)
        '        Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        '        days.Add(dayName)
        '    Next

        '    Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
        '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
        '    xlApp.Visible = True

        '    With excelWorksheet

        '        '''''HEADER START''''''''

        '        .Range(.Cells(1, 1), .Cells(1, 5)).Merge()
        '        .Range(.Cells(2, 1), .Cells(2, 5)).Merge()
        '        .Cells(1, 1) = "DATE ATTENDANCE SUBCONT PER PROJECT"
        '        .Cells(2, 1) = "PERIODE: " & dtpSubProject.Value.Month.ToString & "-" & dtpSubProject.Value.Year

        '        '   Declare Header Text using Array
        '        Dim arrHeader As String() = {"NULL", "NO", "HULL NO (NAME PROJECT)", "NO", "SUB-CONT", "JENIS PEKERJAAN"}

        '        '   Populate Header Text using Loop
        '        For Header As Integer = 1 To 5
        '            .Cells(3, Header) = arrHeader(Header)
        '            '    .Cells(4, Header) = arrHeader(Header)
        '            .Range(.Cells(3, Header), .Cells(4, Header)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            .Range(.Cells(3, Header), .Cells(4, Header)).Merge()
        '        Next

        '        Dim addDate As Integer = 0

        '        For j = 0 To list.Count - 1
        '            .Cells(3, 6) = "MONTHLY REPORT"
        '            .Range(.Cells(3, 6), .Cells(3, 6 + j)).Merge()
        '            .Range(.Cells(3, 6), .Cells(3, 6 + j)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            .Cells(4, 6 + addDate) = list(j)

        '            '  .Cells(5, 5 + addDate).interior.color = Color.Gold
        '            .Range(.Cells(4, 6 + addDate), .Cells(4, 6 + addDate)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            addDate += 1

        '        Next

        '        .Cells(3, 6 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)) = "TOTAL"
        '        .Range(.Cells(3, 6 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)), .Cells(4, 6 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month))).Merge()
        '        .Range(.Cells(3, 6 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)), .Cells(4, 6 + System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month))).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '        '   Centerize Cells
        '        .Range("A1:AZ50").VerticalAlignment = Excel.Constants.xlCenter
        '        .Range("A1:AZ50").HorizontalAlignment = Excel.Constants.xlCenter

        '        ''''HEADER END'''''''

        '        ''''START FILL DATA TO EXCEL

        '        rowsTotal = dgvSubProject.RowCount - 1
        '        colsTotal = dgvSubProject.Columns.Count - 1
        '        Dim num As Integer = 1
        '        Try
        '            For I = 0 To rowsTotal
        '                For j = 0 To colsTotal
        '                    .Cells(I + 6, j + 1).value = dgvSubProject.Rows(I).Cells(j).Value
        '                    .Cells(I + 6, j + 1).borders.linestyle = Excel.XlLineStyle.xlContinuous
        '                Next j
        '            Next I
        '        Catch ex As Exception
        '        End Try

        '    End With
        'Finally
        '    'RELEASE ALLOACTED RESOURCES
        '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        '    xlApp = Nothing
        'End Try
    End Sub

    Private Sub btnGenerateOT_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvSubProject_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubProject.CellContentClick

    End Sub

    Private Sub txtPersonellID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPersonellID.KeyDown

        Try
            Dim begin, endtime As String
            begin = dtpFrom.Value.ToString("yyyy-MM-dd")
            endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
            If e.KeyCode = Keys.Enter Then
                openConnection()

                Dim adaptor As New SqlDataAdapter("USE sls_iFaceDB
                SELECT * into #t1 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "' 
               AND InOutMode = 'Check In' AND (userId = '" & txtPersonellID.Text & "' or personellName LIKE '%" & txtPersonellID.Text & "%')

               SELECT * into #t2 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check Out'  AND (userId = '" & txtPersonellID.Text & "' or personellName LIKE '%" & txtPersonellID.Text & "%')
                SELECT 
                (ROW_NUMBER() OVER(ORDER BY #t1.[timestamp])) 'No',
               #t1.deviceName 'Device Name', 

			   (
			   CASE
					WHEN #t1.userId IS NULL then #t2.userId
					ELSE
					#t1.userId
			   END
			   ) 'User ID',

			   (
				CASE 
					WHEN #t1.personellName IS NULL then #t2.personellName
					ELSE
					#t1.personellName
				END
			   ) 'Employee Name', tUserExternal.subcon 'Subcon',

			 
               #t1.[timestamp] 'Check In',
             
            			   #t1.[deviceName] 'Check In Device',
               (
	             CASE 
	                 WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                 ELSE
	                 #t2.[timestamp]
	             END
               ) 'Check Out',
			   #t2.deviceName 'Check Out Device',

               (
                 CASE
	                WHEN datediff(hh,#t1.[timestamp],#t2.[timestamp]) < 0 THEN NULL
                    WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                else 
	                datediff(hh,#t1.[timestamp],#t2.[timestamp])
	             END
               ) 'Worked Hours',

			   (
				CASE
					WHEN #t1.VerifyType IS NULL THEN 'FACE+CARD'
					ELSE
					#t1.VerifyType
				END
			   ) 'Verify Type'

               FROM #t1 FULL JOIN #t2 ON #t1.userId = #t2.UserId
               AND DATEPART(dd,#t1.[timestamp]) = DATEPART(dd,#t2.[timestamp]) 
			   AND DATEPART(mm,#t1.[timestamp]) = DATEPART(mm,#t2.[timestamp]) 
			   AND DATEPART(yy,#t1.[timestamp]) = DATEPART(yy,#t2.[timestamp]) 
               LEFT JOIN tUserExternal ON tUserExternal.userId = #t1.userId
               ORDER BY [Check In] asc
               DROP TABLE #t1
               DROP TABLE #t2
 
        ", conn)
                Dim ds As New DataSet
                adaptor.Fill(ds, "Report")
                dgvReport.DataSource = ds.Tables("Report")
                lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub txtInOut_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInOut.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If cbbDevName.Text = "" Then
                    openConnection()
                    Dim begin, endtime As String
                    begin = dtpFrom.Value.ToString("yyyy-MM-dd")
                    endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
                    Dim adaptor As New SqlDataAdapter("USE sls_iFaceDB
                    SELECT userId,MIN([timestamp]) 'Check In', 
                    (CASE MAX([timestamp])
                    WHEN MIN([timestamp]) THEN NULL
                    ELSE CAST(MAX([timestamp]) AS DATETIME)
                    END)'Check Out',
                    DATEDIFF(hh,MIN([timestamp]),MAX([timestamp])) 'Worked Hours'
                     into #tAttendanceTemp
                    FROM tReport WHERE

                    DATEPART(yy,[timestamp]) = 2018
                    AND DATEPART(mm,[timestamp]) = 10
                    AND DATEPART(dd,[timestamp]) = 25
                    GROUP BY userId
                    SELECT
                   (ROW_NUMBER() OVER(ORDER BY (SELECT COUNT(*) FROM tReport))) 'No',
                    rpt1.[deviceName] 'Device Name',
                    rpt1.[userId] 'User ID',
                    rpt1.[personellName] 'Personell Name',
                    #tAttendanceTemp.[Check In],
                    #tAttendanceTemp.[Check Out],
                    #tAttendanceTemp.[Worked Hours],
                    rpt1.[VerifyType] 'Verify Type'
                    FROM tReport rpt1 JOIN #tAttendanceTemp ON rpt1.userId = #tAttendanceTemp.userId
                    WHERE InOutMode = '" & txtInOut.Text & "' AND [timestamp] BETWEEN '" & begin & "' AND '" & endtime & "'
                    DROP TABLE #tAttendanceTemp

        ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Report")
                    dgvReport.DataSource = ds.Tables("Report")
                    lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString

                Else
                    openConnection()
                    Dim begin, endtime As String
                    begin = dtpFrom.Value.ToString("yyyy-MM-dd")
                    endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
                    Dim adaptor As New SqlDataAdapter("SELECT [count] 
                                              ,[timestamp] 'Time Stamp'
                                              ,[deviceName] 'Device Name'
                                              ,[userId] 'User ID'
                                              ,[personellName] 'Personell Name'
                                              ,[InOutMode] 'In/Out Mode'
                                              ,[workCode] 'Work Code'
                                              ,[VerifyType] 'Verify Type'
                                               FROM [sls_iFaceDB].[dbo].[tReport] WHERE InOutMode = '" & txtInOut.Text & "' AND deviceName = '" & cbbDevName.Text & "' AND [timestamp] BETWEEN '" & begin & "' AND '" & endtime & "' ORDER BY [count] ASC
        ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Report")
                    dgvReport.DataSource = ds.Tables("Report")
                    lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnExporttoExcel_Click_1(sender As Object, e As EventArgs) Handles btnExporttoExcel.Click
        ExportToExcel(dgvEmployee)
    End Sub

    Private Sub cbDeptExit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDeptExit.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCloseAtt.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCloseLate.Click
        Me.Close()
    End Sub

    Private Sub btnCloseEP_Click(sender As Object, e As EventArgs) Handles btnCloseEP.Click
        Me.Close()
    End Sub

    Private Sub btnSP_Click(sender As Object, e As EventArgs) Handles btnSP.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvLate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLate.CellContentClick

    End Sub

    Private Sub dgvSubProject_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvSubProject.CellPainting
        'If e.RowIndex = 0 Then

        '    If (DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString() = DataGridView2.Rows(e.RowIndex + 1).Cells(0).Value.ToString()) Then
        '        If (e.ColumnIndex = 0) Then
        '            DataGridView2.Rows(e.RowIndex + 1).Cells(0).Value = ""
        '            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        '        End If
        '    End If

        'End If

        'If e.RowIndex > 0 Then
        '    If e.RowIndex < DataGridView2.Rows.Count - 2 Then
        '        If (DataGridView2.Rows(e.RowIndex - 1).Cells(0).Value.ToString() = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString()) Then
        '            If (e.ColumnIndex = 0) Then
        '                DataGridView2.Rows(e.RowIndex).Cells(0).Value = ""
        '                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        '            End If
        '        End If

        '        If (DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString() = DataGridView2.Rows(e.RowIndex + 1).Cells(0).Value.ToString()) Then
        '            If (e.ColumnIndex = 0) Then
        '                DataGridView2.Rows(e.RowIndex + 1).Cells(0).Value = ""
        '                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        '            End If
        '        End If
        '    End If

        'End If
    End Sub
    'Sub subconList()
    '    Try
    '        openConnection()
    '        Dim adaptor As New SqlDataAdapter("
    '        SELECT subconName FROM tSubcon WHERE subconName IN
    '        (
    '        SELECT subCont FROM tProjectDet
    '        )", conn)
    '        Dim ds As New DataSet
    '        adaptor.Fill(ds, "Report")
    '        dgvShowSubcon.DataSource = ds.Tables("Report")
    '    Catch ex As Exception
    '        MsgBox(ex.ToString())
    '        saveError(ex.ToString())
    '    End Try
    'End Sub
    'Sub subconProject()
    '    Try
    '        openConnection()
    '        Dim adaptor As New SqlDataAdapter("SELECT projectName, workType from tProjectDet WHERE subCont = 'PT. ORINZA INTERNATIONAL'", conn)
    '        Dim ds As New DataSet
    '        adaptor.Fill(ds, "Report")
    '        dgvShowSCProject.DataSource = ds.Tables("Report")
    '    Catch ex As Exception
    '        MsgBox(ex.ToString())
    '        saveError(ex.ToString())
    '    End Try
    'End Sub
    Sub subconPerSubcon()
        Dim result, result2 As String
        Dim days As New List(Of String)
        Dim countQuery As New List(Of String)
        Dim dd As String
        Dim value5 As String
        If days.Count = 0 Or countQuery.Count = 0 Then
            For i As Integer = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
                dd = dtpSpS.Value.Year & "-" & dtpSpS.Value.Month.ToString("00") & "-" & i.ToString("00")

                days.Add("[" & dd & "]")
                countQuery.Add("(SELECT COUNT(" & dd & ") FROM #tTemp WHERE [" & dd & "] = '1' AND #tTemp.subconName = tSubCon.subconName) '" & dd & "'")

            Next
            result = String.Join(", ", days)
            result2 = String.Join(", ", countQuery)
        End If



        openConnection()
        Dim adaptor As New SqlDataAdapter(
            "
            SELECT userId, subconName, projectName, " & result & " INTO #tTemp
            FROM 
            (
                SELECT DISTINCT tDeviceUser2.userId, FORMAT([timestamp], 'yyyy-MM-dd') ts, tDeviceUser2.employeeNo, tDeviceUser2.employeeName, tProjectEMP.subconName, projectName,
                tReport.[timestamp] FROM tDeviceUser2 
                INNER JOIN tProjectEMP ON tDeviceUser2.employeeNo = tProjectEMP.employeeNO
                INNER JOIN tSubCon ON tProjectEMP.subconName = tProjectEMP.subconName AND projectName = projectName
                INNER JOIN tReport ON tDeviceUser2.userId = tReport.userId WHERE InOutMode = 'Check In'
            ) d
            pivot 
            (
            count (ts)
            for ts in (" & result & ")
            ) pv
             SELECT DISTINCT tSubcon.subconName, projectName, " & result2 & " FROM tSubCon INNER Join #tTemp On tSubCon.subconName = #tTemp.subconName;
             DROP TABLE #tTemp
            ", conn)

        Dim ds As New DataSet
        adaptor.Fill(ds, "Report")
        dgvSpS.DataSource = ds.Tables("Report")

    End Sub
    Private Sub btnSpS_Click(sender As Object, e As EventArgs) Handles btnSpS.Click
        ''Show Subcon List
        'openConnection()
        'Dim adaptor As New SqlDataAdapter("SELECT projectName, workType from tProjectDet WHERE subCont = 'PT. ORINZA INTERNATIONAL'", conn)
        'Dim ds As New DataSet
        'adaptor.Fill(ds, "Report")
        'dgvShowSCProject.DataSource = ds.Tables("Report")
        ''End show subcon list

        ''Show project 


        subconPerSubcon()
        Dim count As Integer = 0
        For iCols As Integer = 0 To dgvSpS.Rows.Count - 1
            count = count + 1
            dgvSpS.Rows(iCols).Cells(0).Value = count
        Next

        'Dim list As New List(Of Integer)
        'Dim strDates As String
        'Dim firstInt As Integer = 1
        'Dim secondInt As Integer = 1
        'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'subconList()
        'subconProject()
        'Dim count As Integer = 1

        'For i As Integer = 0 To dgvShowSubcon.Rows.Count - 1
        '    dgvSpS.Rows.Add(count, dgvShowSubcon.Rows(i).Cells(0).Value.ToString, " ")
        '    count = count + 1

        '    Try
        '        openConnection()
        '        Dim adaptor As New SqlDataAdapter("SELECT projectName, workType from tProjectDet WHERE subCont = '" & dgvShowSubcon.Rows(i).Cells(0).Value.ToString & "'", conn)
        '        Dim ds As New DataSet
        '        adaptor.Fill(ds, "Report")
        '        dgvShowSCProject.DataSource = ds.Tables("Report")
        '    Catch ex As Exception
        '        MsgBox(ex.ToString())
        '        saveError(ex.ToString())
        '    End Try


        '    For j As Integer = 0 To dgvShowSCProject.Rows.Count - 1
        '        dgvSpS.Rows.Add(" ", dgvShowSCProject.Rows(j).Cells(0).Value.ToString, dgvShowSCProject.Rows(j).Cells(1).Value.ToString)
        '    Next



        'Next


        'For dates = 1 To System.DateTime.DaysInMonth(dtpAtt.Value.Year, dtpAtt.Value.Month)
        '    list.Add(dates)
        '    strDates = dtpSubProject.Value.Year.ToString & "/" & dtpSubProject.Value.Month.ToString & "/" & dates.ToString() 'Return Year/Month/Dates (2018/01/01)
        '    dgvSps2.Columns.Add(dates, dates)
        'Next

        'Dim cmd As New SqlCommand
        'Dim datas As Integer
        'Dim lst As New List(Of Integer)
        'Dim countt As Integer = 1
        'For j As Integer = 0 To dgvSpS.Rows.Count - 1
        '    For k As Integer = 0 To dgvShowSubcon.Rows.Count - 1
        '        lst.Clear()
        '        For i As Integer = 1 To System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month)

        '            cmd = New SqlCommand("
        '        SELECT COUNT(*) Total FROM (
        '        SELECT DISTINCT tDeviceUser2.userId, tDeviceUser2.employeeNo, tDeviceUser2.employeeName, 
        '        tReport.[timestamp] FROM tDeviceUser2 
        '        INNER JOIN tProjectEMP ON tDeviceUser2.employeeNo = tProjectEMP.employeeNO
        '        INNER JOIN tSubCon ON tProjectEMP.subconName = '" & dgvShowSubcon.Rows(k).Cells(0).Value.ToString() & "'
        '        INNER JOIN tReport ON tDeviceUser2.userId = tReport.userId 
        '        WHERE  datepart(yy,[timestamp]) = '" & dtpSpS.Value.Year & "'
        '        and datepart(mm,[timestamp]) = '" & dtpSpS.Value.Month.ToString("00") & "'
        '        and datepart(dd,[timestamp]) = '" & i & "'
        '     and InOutMode = 'Check In') ct", conn)

        '            Dim mindiff As String

        '            Dim dreader As SqlDataReader
        '            dreader = cmd.ExecuteReader
        '            dreader.Read()

        '            If dreader.HasRows = True Then
        '                lst.Add(dreader.Item("Total"))
        '            Else
        '                datas = 0
        '                lst.Add(datas)
        '            End If

        '        Next

        '        If System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month) = 31 Then

        '            dgvSps2.Rows.Add(lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29), lst(30))

        '        ElseIf System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month) = 30 Then
        '            dgvSps2.Rows.Add(lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27), lst(28), lst(29))

        '        ElseIf System.DateTime.DaysInMonth(dtpSubProject.Value.Year, dtpSubProject.Value.Month) = 28 Then
        '            dgvSps2.Rows.Add(lst(0), lst(1), lst(2), lst(3), lst(4), lst(5), lst(6), lst(7), lst(8), lst(9), lst(10), lst(11), lst(12), lst(13), lst(14), lst(15), lst(16), lst(17), lst(18), lst(19), lst(20), lst(21), lst(22), lst(23), lst(24), lst(25), lst(26), lst(27))

        '        End If

        '    Next
        'Next
        'getTotalMP()

    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
    Sub showATTReport()
        Try
            openConnection()
            Dim begin, endtime As String
            begin = dtpFrom.Value.ToString("yyyy-MM-dd")
            endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
            Dim adaptor As New SqlDataAdapter("

               SELECT * into #t1 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check In'

               SELECT * into #t2 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check Out' 

          SELECT 
                (ROW_NUMBER() OVER(ORDER BY #t1.[timestamp])) 'No',
             

			   (
			   CASE
					WHEN #t1.userId IS NULL then #t2.userId
					ELSE
					#t1.userId
			   END
			   ) 'User ID',

			   (
				CASE 
					WHEN #t1.personellName IS NULL then #t2.personellName
					ELSE
					#t1.personellName
				END
			   ) 'Employee Name'
			   ,
               tUserExternal.subcon 'Subcon',

               #t1.[timestamp] 'Check In',
              			   #t1.[deviceName] 'Check In Device',
               (
	             CASE 
	                 WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                 ELSE
	                 #t2.[timestamp]
	             END
               ) 'Check Out',
			   #t2.deviceName 'Check Out Device',
               (
                 CASE
	                WHEN datediff(hh,#t1.[timestamp],#t2.[timestamp]) < 0 THEN NULL
                    WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                else 
	                datediff(hh,#t1.[timestamp],#t2.[timestamp])
	             END
               ) 'Worked Hours',

			   (
				CASE
					WHEN #t1.VerifyType IS NULL THEN 'FACE+CARD'
					ELSE
					#t1.VerifyType
				END
			   ) 'Verify Type'

               FROM #t1 FULL JOIN #t2 ON #t1.userId = #t2.UserId
               AND DATEPART(dd,#t1.[timestamp]) = DATEPART(dd,#t2.[timestamp]) 
			   AND DATEPART(mm,#t1.[timestamp]) = DATEPART(mm,#t2.[timestamp]) 
			   AND DATEPART(yy,#t1.[timestamp]) = DATEPART(yy,#t2.[timestamp]) 
               LEFT JOIN tUserExternal ON tUserExternal.userId = #t1.userId
               ORDER BY [Check In] asc
               DROP TABLE #t1
               DROP TABLE #t2

                                        
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Report")
            dgvReport.DataSource = ds.Tables("Report")
            lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString

        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub btnSearchDate_Click(sender As Object, e As EventArgs) Handles btnSearchDate.Click
        Try
            openConnection()
            Dim begin, endtime As String
            begin = dtpFrom.Value.ToString("yyyy-MM-dd")
            endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
            Dim adaptor As New SqlDataAdapter("

               SELECT * into #t1 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check In'

               SELECT * into #t2 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check Out' 

                SELECT 
                (ROW_NUMBER() OVER(ORDER BY #t1.[timestamp])) 'No',

			   (
			   CASE
					WHEN #t1.userId IS NULL then #t2.userId
					ELSE
					#t1.userId
			   END
			   ) 'User ID',

			   (
				CASE 
					WHEN #t1.personellName IS NULL then #t2.personellName
					ELSE
					#t1.personellName
				END
			   ) 'Employee Name', tUserExternal.subcon 'Subcon',
			   
               #t1.[timestamp] 'Check In',

            			   #t1.[deviceName] 'Check In Device',
               (
	             CASE 
	                 WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                 ELSE
	                 #t2.[timestamp]
	             END
               ) 'Check Out',
			   #t2.deviceName 'Check Out Device',

               (
                 CASE
	                WHEN datediff(hh,#t1.[timestamp],#t2.[timestamp]) < 0 THEN NULL
                    WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                else 
	                datediff(hh,#t1.[timestamp],#t2.[timestamp])
	             END
               ) 'Worked Hours',

			   (
				CASE
					WHEN #t1.VerifyType IS NULL THEN 'FACE+CARD'
					ELSE
					#t1.VerifyType
				END
			   ) 'Verify Type'

               FROM #t1 FULL JOIN #t2 ON #t1.userId = #t2.UserId 
               AND DATEPART(dd,#t1.[timestamp]) = DATEPART(dd,#t2.[timestamp]) 
			   AND DATEPART(mm,#t1.[timestamp]) = DATEPART(mm,#t2.[timestamp]) 
			   AND DATEPART(yy,#t1.[timestamp]) = DATEPART(yy,#t2.[timestamp]) 
                   LEFT JOIN tUserExternal ON tUserExternal.userId = #t1.userId
               ORDER BY [Check In] asc
               DROP TABLE #t1
               DROP TABLE #t2

                                        
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Report")
            dgvReport.DataSource = ds.Tables("Report")
            lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString

        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub txtInOut_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles txtInOut.SelectedIndexChanged

    End Sub

    Private Sub txtPersonellID_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbbDevName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbDevName.SelectedIndexChanged

    End Sub

    Private Sub dgvSubProject_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSubProject.CellFormatting
        Try
            If e.RowIndex > 0 And e.ColumnIndex = 0 Then
                If dgvSubProject.Item(0, e.RowIndex - 1).Value = e.Value Then
                    e.Value = ""
                    dgvSubProject.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.GhostWhite

                ElseIf e.RowIndex < dgvSubProject.Rows.Count - 1 Then

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPersonellID_TextChanged_2(sender As Object, e As EventArgs) Handles txtPersonellID.TextChanged

    End Sub

    Private Sub dgvLate_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLate.CellFormatting

    End Sub

    Private Sub txtSearchEMP_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEMP.TextChanged

    End Sub

    Private Sub btnGetOT_Click(sender As Object, e As EventArgs) Handles btnGetOT.Click
        dsOT.Clear()
        dsOT.Tables.Clear()
        dgvGetOT.DataSource = Nothing
        dgvGetOT.Rows.Clear()
        Dim dd As String
        Dim days As New List(Of String)
        Dim query As New List(Of String)

        If txtOTname.Text = "" And cbbDeptOT.Text = "" Then

            For i As Integer = 1 To System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month)
                dd = dtpOT.Value.Year & "-" & dtpOT.Value.Month.ToString("00") & "-" & i.ToString("00")
                days.Add("[" & dtpOT.Value.Year & "-" & dtpOT.Value.Month.ToString("00") & "-" & i.ToString("00") & "]")
                'query.Add("CASE WHEN [" & dd & "] >= 1 THEN '1' WHEN [" & dd & "] <1 THEN ' ' END AS [" & dd & "]")
                query.Add("CASE 
			WHEN [" & dd & "] < 1.0 THEN NULL 
		    WHEN [" & dd & "] >= 1.0 AND [" & dd & "] < 2.0 THEN 1.5
			WHEN [" & dd & "] >= 2.0 AND [" & dd & "] < 2.5 THEN 2.5
			WHEN [" & dd & "] >= 2.5 AND [" & dd & "] < 3.0 THEN 4.5
			WHEN [" & dd & "] >= 3.0 AND [" & dd & "] < 4.0 THEN 6.5
			WHEN [" & dd & "] >= 4.0 AND [" & dd & "] < 5.0 THEN 8.5
			WHEN [" & dd & "] >= 5.0 AND [" & dd & "] < 6.0 THEN 10.5
		    WHEN [" & dd & "] >= 7.0 AND [" & dd & "] < 8.0 THEN 12.5
			WHEN [" & dd & "] >= 8.0 AND [" & dd & "] < 9.0 THEN 14.5
			WHEN [" & dd & "] >= 9.0 AND [" & dd & "] < 10.0 THEN 16.5
			WHEN [" & dd & "] >= 10.0 AND [" & dd & "] < 11.0 THEN 18.5
			WHEN [" & dd & "] >= 12.0 AND [" & dd & "] < 13.0 THEN 20.5
			WHEN [" & dd & "] >= 13.0 AND [" & dd & "] < 14.0 THEN 22.5
		    WHEN [" & dd & "] >= 14.0 AND [" & dd & "] < 15.0 THEN 24.5
			WHEN [" & dd & "] >= 15.0 AND [" & dd & "] < 16.00THEN 26.5
			END AS [" & dd & "]")
            Next

            Dim result As String = String.Join(", ", days)
            Dim result2 As String = String.Join(",", query)
            ' Try
            Dim adaptor As New SqlDataAdapter
            openConnection()

            adaptor = New SqlDataAdapter("
       		   
	
		    SELECT userId, FORMAT([timestamp], 'yyyy-MM-dd') 'timestamp', 
            (
			SELECT CONVERT(float,DATEDIFF(minute,  FORMAT([timestamp], 'yyyy-MM-dd') + ' 16:00', [timestamp]) / 60.0)
			)
				
			'Lates' INTO #tTable FROM tReport 
            WHERE [timestamp] >= CAST(FORMAT([timestamp],'yyyy-MM-dd') +  ' 16:00' AS date) AND InOutMode = 'Check Out' 
            SELECT userId, " & result & "  INTO #tLate 
            FROM (SELECT userId, [timestamp], Lates FROM #tTable) s
            PIVOT
            (
            SUM(Lates) for [timestamp] in (" & result & ")
            ) piv
       
            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department', " & result2 & "
            FROM #tLate FULL JOIN tDeviceUser2 ON tDeviceUser2.userId = #tLate.userId ORDER BY tDeviceUser2.userId ASC

            DROP TABLE #tLate
            DROP TABLE #tTable


        ", conn)

            adaptor.Fill(dsOT, "Report")
            dgvGetOT.DataSource = dsOT.Tables("Report")

        ElseIf txtOTname.Text = "" And cbbDeptOT.Text <> "" Then


            For i As Integer = 1 To System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month)
                dd = dtpOT.Value.Year & "-" & dtpOT.Value.Month.ToString("00") & "-" & i.ToString("00")
                days.Add("[" & dtpOT.Value.Year & "-" & dtpOT.Value.Month.ToString("00") & "-" & i.ToString("00") & "]")
                'query.Add("CASE WHEN [" & dd & "] >= 1 THEN '1' WHEN [" & dd & "] <1 THEN ' ' END AS [" & dd & "]")
                query.Add("CASE 
			WHEN [" & dd & "] < 1.0 THEN NULL 
		    WHEN [" & dd & "] >= 1.0 AND [" & dd & "] < 2.0 THEN 1.5
			WHEN [" & dd & "] >= 2.0 AND [" & dd & "] < 2.5 THEN 2.5
			WHEN [" & dd & "] >= 2.5 AND [" & dd & "] < 3.0 THEN 4.5
			WHEN [" & dd & "] >= 3.0 AND [" & dd & "] < 4.0 THEN 6.5
			WHEN [" & dd & "] >= 4.0 AND [" & dd & "] < 5.0 THEN 8.5
			WHEN [" & dd & "] >= 5.0 AND [" & dd & "] < 6.0 THEN 10.5
		    WHEN [" & dd & "] >= 7.0 AND [" & dd & "] < 8.0 THEN 12.5
			WHEN [" & dd & "] >= 8.0 AND [" & dd & "] < 9.0 THEN 14.5
			WHEN [" & dd & "] >= 9.0 AND [" & dd & "] < 10.0 THEN 16.5
			WHEN [" & dd & "] >= 10.0 AND [" & dd & "] < 11.0 THEN 18.5
			WHEN [" & dd & "] >= 12.0 AND [" & dd & "] < 13.0 THEN 20.5
			WHEN [" & dd & "] >= 13.0 AND [" & dd & "] < 14.0 THEN 22.5
		    WHEN [" & dd & "] >= 14.0 AND [" & dd & "] < 15.0 THEN 24.5
			WHEN [" & dd & "] >= 15.0 AND [" & dd & "] < 16.00THEN 26.5
			END AS [" & dd & "]")
            Next

            Dim result As String = String.Join(", ", days)
            Dim result2 As String = String.Join(",", query)
            ' Try
            Dim adaptor As New SqlDataAdapter
            openConnection()

            adaptor = New SqlDataAdapter("
       		   
	
		    SELECT userId, FORMAT([timestamp], 'yyyy-MM-dd') 'timestamp', 
            (
			SELECT CONVERT(float,DATEDIFF(minute,  FORMAT([timestamp], 'yyyy-MM-dd') + ' 16:00', [timestamp]) / 60.0)
			)
				
			'Lates' INTO #tTable FROM tReport 
            WHERE [timestamp] >= CAST(FORMAT([timestamp],'yyyy-MM-dd') +  ' 16:00' AS date) AND InOutMode = 'Check Out' 
            SELECT userId, " & result & "  INTO #tLate 
            FROM (SELECT userId, [timestamp], Lates FROM #tTable) s
            PIVOT
            (
            SUM(Lates) for [timestamp] in (" & result & ")
            ) piv
       
            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department', " & result2 & "
            FROM #tLate FULL JOIN tDeviceUser2 ON tDeviceUser2.userId = #tLate.userId WHERE tDeviceUser2.departmentName LIKE '%" & cbbDeptOT.Text & "%'
            ORDER BY tDeviceUser2.userId ASC

            DROP TABLE #tLate
            DROP TABLE #tTable


        ", conn)

            adaptor.Fill(dsOT, "Report")
            dgvGetOT.DataSource = dsOT.Tables("Report")

        ElseIf txtOTname.Text <> "" And cbbDeptOT.Text = "" Then


            For i As Integer = 1 To System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month)
                dd = dtpOT.Value.Year & "-" & dtpOT.Value.Month.ToString("00") & "-" & i.ToString("00")
                days.Add("[" & dtpOT.Value.Year & "-" & dtpOT.Value.Month.ToString("00") & "-" & i.ToString("00") & "]")
                'query.Add("CASE WHEN [" & dd & "] >= 1 THEN '1' WHEN [" & dd & "] <1 THEN ' ' END AS [" & dd & "]")
                query.Add("CASE 
			WHEN [" & dd & "] < 1.0 THEN NULL 
		    WHEN [" & dd & "] >= 1.0 AND [" & dd & "] < 2.0 THEN 1.5
			WHEN [" & dd & "] >= 2.0 AND [" & dd & "] < 2.5 THEN 2.5
			WHEN [" & dd & "] >= 2.5 AND [" & dd & "] < 3.0 THEN 4.5
			WHEN [" & dd & "] >= 3.0 AND [" & dd & "] < 4.0 THEN 6.5
			WHEN [" & dd & "] >= 4.0 AND [" & dd & "] < 5.0 THEN 8.5
			WHEN [" & dd & "] >= 5.0 AND [" & dd & "] < 6.0 THEN 10.5
		    WHEN [" & dd & "] >= 7.0 AND [" & dd & "] < 8.0 THEN 12.5
			WHEN [" & dd & "] >= 8.0 AND [" & dd & "] < 9.0 THEN 14.5
			WHEN [" & dd & "] >= 9.0 AND [" & dd & "] < 10.0 THEN 16.5
			WHEN [" & dd & "] >= 10.0 AND [" & dd & "] < 11.0 THEN 18.5
			WHEN [" & dd & "] >= 12.0 AND [" & dd & "] < 13.0 THEN 20.5
			WHEN [" & dd & "] >= 13.0 AND [" & dd & "] < 14.0 THEN 22.5
		    WHEN [" & dd & "] >= 14.0 AND [" & dd & "] < 15.0 THEN 24.5
			WHEN [" & dd & "] >= 15.0 AND [" & dd & "] < 16.00THEN 26.5
			END AS [" & dd & "]")
            Next

            Dim result As String = String.Join(", ", days)
            Dim result2 As String = String.Join(",", query)
            ' Try
            Dim adaptor As New SqlDataAdapter
            openConnection()

            adaptor = New SqlDataAdapter("
       		   
	
		    SELECT userId, FORMAT([timestamp], 'yyyy-MM-dd') 'timestamp', 
            (
			SELECT CONVERT(float,DATEDIFF(minute,  FORMAT([timestamp], 'yyyy-MM-dd') + ' 16:00', [timestamp]) / 60.0)
			)
				
			'Lates' INTO #tTable FROM tReport 
            WHERE [timestamp] >= CAST(FORMAT([timestamp],'yyyy-MM-dd') +  ' 16:00' AS date) AND InOutMode = 'Check Out' 
            SELECT userId, " & result & "  INTO #tLate 
            FROM (SELECT userId, [timestamp], Lates FROM #tTable) s
            PIVOT
            (
            SUM(Lates) for [timestamp] in (" & result & ")
            ) piv
       
            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department', " & result2 & "
            FROM #tLate FULL JOIN tDeviceUser2 ON tDeviceUser2.userId = #tLate.userId WHERE tDeviceUser2.employeeName LIKE '%" & txtOTname.Text & "%'
            ORDER BY tDeviceUser2.userId ASC

            DROP TABLE #tLate
            DROP TABLE #tTable


        ", conn)

            adaptor.Fill(dsOT, "Report")
            dgvGetOT.DataSource = dsOT.Tables("Report")

        ElseIf txtOTname.Text <> "" And cbbDeptOT.Text <> "" Then

            For i As Integer = 1 To System.DateTime.DaysInMonth(dtpOT.Value.Year, dtpOT.Value.Month)
                dd = dtpOT.Value.Year & "-" & dtpOT.Value.Month.ToString("00") & "-" & i.ToString("00")
                days.Add("[" & dtpOT.Value.Year & "-" & dtpOT.Value.Month.ToString("00") & "-" & i.ToString("00") & "]")
                'query.Add("CASE WHEN [" & dd & "] >= 1 THEN '1' WHEN [" & dd & "] <1 THEN ' ' END AS [" & dd & "]")
                query.Add("CASE 
			WHEN [" & dd & "] < 1.0 THEN NULL 
		    WHEN [" & dd & "] >= 1.0 AND [" & dd & "] < 2.0 THEN 1.5
			WHEN [" & dd & "] >= 2.0 AND [" & dd & "] < 2.5 THEN 2.5
			WHEN [" & dd & "] >= 2.5 AND [" & dd & "] < 3.0 THEN 4.5
			WHEN [" & dd & "] >= 3.0 AND [" & dd & "] < 4.0 THEN 6.5
			WHEN [" & dd & "] >= 4.0 AND [" & dd & "] < 5.0 THEN 8.5
			WHEN [" & dd & "] >= 5.0 AND [" & dd & "] < 6.0 THEN 10.5
		    WHEN [" & dd & "] >= 7.0 AND [" & dd & "] < 8.0 THEN 12.5
			WHEN [" & dd & "] >= 8.0 AND [" & dd & "] < 9.0 THEN 14.5
			WHEN [" & dd & "] >= 9.0 AND [" & dd & "] < 10.0 THEN 16.5
			WHEN [" & dd & "] >= 10.0 AND [" & dd & "] < 11.0 THEN 18.5
			WHEN [" & dd & "] >= 12.0 AND [" & dd & "] < 13.0 THEN 20.5
			WHEN [" & dd & "] >= 13.0 AND [" & dd & "] < 14.0 THEN 22.5
		    WHEN [" & dd & "] >= 14.0 AND [" & dd & "] < 15.0 THEN 24.5
			WHEN [" & dd & "] >= 15.0 AND [" & dd & "] < 16.00THEN 26.5
			END AS [" & dd & "]")
            Next

            Dim result As String = String.Join(", ", days)
            Dim result2 As String = String.Join(",", query)
            ' Try
            Dim adaptor As New SqlDataAdapter
            openConnection()

            adaptor = New SqlDataAdapter("
       		   
	
		    SELECT userId, FORMAT([timestamp], 'yyyy-MM-dd') 'timestamp', 
            (
			SELECT CONVERT(float,DATEDIFF(minute,  FORMAT([timestamp], 'yyyy-MM-dd') + ' 16:00', [timestamp]) / 60.0)
			)
				
			'Lates' INTO #tTable FROM tReport 
            WHERE [timestamp] >= CAST(FORMAT([timestamp],'yyyy-MM-dd') +  ' 16:00' AS date) AND InOutMode = 'Check Out' 
            SELECT userId, " & result & "  INTO #tLate 
            FROM (SELECT userId, [timestamp], Lates FROM #tTable) s
            PIVOT
            (
            SUM(Lates) for [timestamp] in (" & result & ")
            ) piv
       
            SELECT tDeviceUser2.employeeNo 'Employee No', tDeviceUser2.employeeName 'Employee Name', tDeviceUser2.departmentName 'Department', " & result2 & "
            FROM #tLate FULL JOIN tDeviceUser2 ON tDeviceUser2.userId = #tLate.userId WHERE tDeviceUser2.departmentName LIKE '%" & cbbDeptOT.Text & "%' AND tDeviceUser2.employeeName LIKE '%" & txtOTname.Text & "%'
            ORDER BY tDeviceUser2.userId ASC

            DROP TABLE #tLate
            DROP TABLE #tTable


        ", conn)

            adaptor.Fill(dsOT, "Report")
            dgvGetOT.DataSource = dsOT.Tables("Report")

        End If
        Dim count As Integer = 0
        For iCols As Integer = 0 To dgvGetOT.Rows.Count - 1
            count = count + 1
            dgvGetOT.Rows(iCols).Cells(0).Value = count
        Next

        'Dim count As Integer = 0
        'For iCols As Integer = 0 To dgvGetOT.Rows.Count - 1
        '    count = count + 1
        '    dgvGetOT.Rows(iCols).Cells(0).Value = count
        'Next

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles btnCloseOT.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lateOT(dgvGetOT)
    End Sub

    Private Sub cbbDevName_KeyDown(sender As Object, e As KeyEventArgs) Handles cbbDevName.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtInOut.Text = "" And txtPersonellID.Text = "" Then
                    openConnection()
                    Dim begin, endtime As String
                    begin = dtpFrom.Value.ToString("yyyy-MM-dd")
                    endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
                    Dim adaptor As New SqlDataAdapter("  
               SELECT * into #t1 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check In' AND deviceName = '" & cbbDevName.Text & "'

               SELECT * into #t2 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check Out' AND deviceName = '" & cbbDevName.Text & "'

              SELECT 
                (ROW_NUMBER() OVER(ORDER BY #t1.[timestamp])) 'No',

			   (
			   CASE
					WHEN #t1.userId IS NULL then #t2.userId
					ELSE
					#t1.userId
			   END
			   ) 'User ID',

			   (
				CASE 
					WHEN #t1.personellName IS NULL then #t2.personellName
					ELSE
					#t1.personellName
				END
			   ) 'Employee Name',
               tUserExternal.subcon 'Subcon',
               #t1.[timestamp] 'Check In',
               #t1.[deviceName] 'Check In Device',
               (
	             CASE 
	                 WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                 ELSE
	                 #t2.[timestamp]
	             END
               ) 'Check Out',
			   #t2.deviceName 'Check Out Device',

               (
                 CASE
	                WHEN datediff(hh,#t1.[timestamp],#t2.[timestamp]) < 0 THEN NULL
                    WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                else 
	                datediff(hh,#t1.[timestamp],#t2.[timestamp])
	             END
               ) 'Worked Hours',

			   (
				CASE
					WHEN #t1.VerifyType IS NULL THEN 'FACE+CARD'
					ELSE
					#t1.VerifyType
				END
			   ) 'Verify Type'

               FROM #t1 FULL JOIN #t2 ON #t1.userId = #t2.UserId 
               AND DATEPART(dd,#t1.[timestamp]) = DATEPART(dd,#t2.[timestamp]) 
			   AND DATEPART(mm,#t1.[timestamp]) = DATEPART(mm,#t2.[timestamp]) 
			   AND DATEPART(yy,#t1.[timestamp]) = DATEPART(yy,#t2.[timestamp]) 
               LEFT JOIN tUserExternal ON tUserExternal.userId = #t1.userId
               ORDER BY [Check In] asc
               DROP TABLE #t1
               DROP TABLE #t2

        ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Report")
                    dgvReport.DataSource = ds.Tables("Report")
                    lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString

                ElseIf txtInOut.Text = "" And txtPersonellID.Text <> "" Then
                    openConnection()
                    Dim begin, endtime As String
                    begin = dtpFrom.Value.ToString("yyyy-MM-dd")
                    endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
                    Dim adaptor As New SqlDataAdapter("

                                   SELECT * into #t1 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check In' AND deviceName = '" & cbbDevName.Text & "' and userId = '" & txtPersonellID.Text & "'

               SELECT * into #t2 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check Out' AND deviceName = '" & cbbDevName.Text & "' and userId = '" & txtPersonellID.Text & "'
  SELECT 
                (ROW_NUMBER() OVER(ORDER BY #t1.[timestamp])) 'No',

			   (
			   CASE
					WHEN #t1.userId IS NULL then #t2.userId
					ELSE
					#t1.userId
			   END
			   ) 'User ID',

			   (
				CASE 
					WHEN #t1.personellName IS NULL then #t2.personellName
					ELSE
					#t1.personellName
				END
			   ) 'Employee Name'
			   , 
               tUserExternal.subcon 'Subcon',
               #t1.[timestamp] 'Check In',
           			   #t1.[deviceName] 'Check In Device',
               (
	             CASE 
	                 WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                 ELSE
	                 #t2.[timestamp]
	             END
               ) 'Check Out',
			   #t2.deviceName 'Check Out Device',
               (
                 CASE
	                WHEN datediff(hh,#t1.[timestamp],#t2.[timestamp]) < 0 THEN NULL
                    WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                else 
	                datediff(hh,#t1.[timestamp],#t2.[timestamp])
	             END
               ) 'Worked Hours',

			   (
				CASE
					WHEN #t1.VerifyType IS NULL THEN 'FACE+CARD'
					ELSE
					#t1.VerifyType
				END
			   ) 'Verify Type'

               FROM #t1 FULL JOIN #t2 ON #t1.userId = #t2.UserId 
               AND DATEPART(dd,#t1.[timestamp]) = DATEPART(dd,#t2.[timestamp]) 
			   AND DATEPART(mm,#t1.[timestamp]) = DATEPART(mm,#t2.[timestamp]) 
			   AND DATEPART(yy,#t1.[timestamp]) = DATEPART(yy,#t2.[timestamp]) 
                   LEFT JOIN tUserExternal ON tUserExternal.userId = #t1.userId
               ORDER BY [Check In] asc
               DROP TABLE #t1
               DROP TABLE #t2
                

        ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Report")
                    dgvReport.DataSource = ds.Tables("Report")
                    lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString
                End If



            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub cbbSubcon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSubcon.SelectedIndexChanged

    End Sub

    Private Sub btnAttendance_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAttendance.KeyDown

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEmpType.SelectedIndexChanged

    End Sub

    Private Sub txtSearchEMP_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchEMP.KeyDown

    End Sub

    Private Sub dgvReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReport.CellContentClick

    End Sub

    Private Sub cbbSubcon_KeyDown(sender As Object, e As KeyEventArgs) Handles cbbSubcon.KeyDown
        Try
            openConnection()
            Dim begin, endtime As String
            begin = dtpFrom.Value.ToString("yyyy-MM-dd")
            endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
            Dim adaptor As New SqlDataAdapter("

               SELECT * into #t1 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check In'

               SELECT * into #t2 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' and '" & endtime & "'
               AND InOutMode = 'Check Out' 

                SELECT 
                (ROW_NUMBER() OVER(ORDER BY #t1.[timestamp])) 'No',

			   (
			   CASE
					WHEN #t1.userId IS NULL then #t2.userId
					ELSE
					#t1.userId
			   END
			   ) 'User ID',

			   (
				CASE 
					WHEN #t1.personellName IS NULL then #t2.personellName
					ELSE
					#t1.personellName
				END
			   ) 'Employee Name', tUserExternal.subcon 'Subcon',
			   
               #t1.[timestamp] 'Check In',

            			   #t1.[deviceName] 'Check In Device',
               (
	             CASE 
	                 WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                 ELSE
	                 #t2.[timestamp]
	             END
               ) 'Check Out',
			   #t2.deviceName 'Check Out Device',

               (
                 CASE
	                WHEN datediff(hh,#t1.[timestamp],#t2.[timestamp]) < 0 THEN NULL
                    WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                else 
	                datediff(hh,#t1.[timestamp],#t2.[timestamp])
	             END
               ) 'Worked Hours',

			   (
				CASE
					WHEN #t1.VerifyType IS NULL THEN 'FACE+CARD'
					ELSE
					#t1.VerifyType
				END
			   ) 'Verify Type'

               FROM #t1 FULL JOIN #t2 ON #t1.userId = #t2.UserId 
               AND DATEPART(dd,#t1.[timestamp]) = DATEPART(dd,#t2.[timestamp]) 
			   AND DATEPART(mm,#t1.[timestamp]) = DATEPART(mm,#t2.[timestamp]) 
			   AND DATEPART(yy,#t1.[timestamp]) = DATEPART(yy,#t2.[timestamp]) 
               JOIN tUserExternal ON tUserExternal.userId = #t1.userId AND tUserExternal.subcon = '" & cbbSubcon.Text & "'
               ORDER BY [Check In] asc
               DROP TABLE #t1
               DROP TABLE #t2

                                        
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Report")
            dgvReport.DataSource = ds.Tables("Report")
            lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString

        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        exportSC2(dgvSpS)
    End Sub

    Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles cbbEmpType.KeyDown
        If e.KeyCode = Keys.Enter Then


            If cbbEmpType.Text = "INTERNAL" Then

                Try
                    openConnection()
                    Dim begin, endtime As String
                    begin = dtpFrom.Value.ToString("yyyy-MM-dd")
                    endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
                    Dim adaptor As New SqlDataAdapter("

               
               SELECT * into #t1 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' AND '" & endtime & "'
               AND InOutMode = 'Check In'

               SELECT * into #t2 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' AND '" & endtime & "'
               AND InOutMode = 'Check Out' 

          SELECT 
                (ROW_NUMBER() OVER(ORDER BY #t1.[timestamp])) 'No',
             

			   (
			   CASE
					WHEN #t1.userId IS NULL then #t2.userId
					ELSE
					#t1.userId
			   END
			   ) 'User ID',

			   (
				CASE 
					WHEN #t1.personellName IS NULL then #t2.personellName
					ELSE
					#t1.personellName
				END
			   ) 'Employee Name'
		   ,
               #t1.[timestamp] 'Check In',
              			   #t1.[deviceName] 'Check In Device',
               (
	             CASE 
	                 WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                 ELSE
	                 #t2.[timestamp]
	             END
               ) 'Check Out',
			   #t2.deviceName 'Check Out Device',
               (
                 CASE
	                WHEN datediff(hh,#t1.[timestamp],#t2.[timestamp]) < 0 THEN NULL
                    WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                else 
	                datediff(hh,#t1.[timestamp],#t2.[timestamp])
	             END
               ) 'Worked Hours',

			   (
				CASE
					WHEN #t1.VerifyType IS NULL THEN 'FACE+CARD'
					ELSE
					#t1.VerifyType
				END
			   ) 'Verify Type'

               FROM #t1 FULL JOIN #t2 ON #t1.userId = #t2.UserId
               AND DATEPART(dd,#t1.[timestamp]) = DATEPART(dd,#t2.[timestamp]) 
			   AND DATEPART(mm,#t1.[timestamp]) = DATEPART(mm,#t2.[timestamp]) 
			   AND DATEPART(yy,#t1.[timestamp]) = DATEPART(yy,#t2.[timestamp]) 
			   JOIN tDeviceUser2 ON tDeviceUser2.userId = #t1.userId AND tDeviceUser2.employeeType = 'INTERNAL'
               ORDER BY [Check In] asc
               DROP TABLE #t1
               DROP TABLE #t2

		
                                        
        ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Report")
                    dgvReport.DataSource = ds.Tables("Report")
                    lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString

                Catch ex As Exception
                    MsgBox(ex.ToString())
                    saveError(ex.ToString())
                End Try

            ElseIf cbbEmpType.Text = "EXTERNAL" Then

                Try
                    openConnection()
                    Dim begin, endtime As String
                    begin = dtpFrom.Value.ToString("yyyy-MM-dd")
                    endtime = dtpTo.Value.AddDays(1).ToString("yyyy-MM-dd")
                    Dim adaptor As New SqlDataAdapter("

              
               SELECT * into #t1 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' AND '" & endtime & "'
               AND InOutMode = 'Check In'

               SELECT * into #t2 FROM tReport WHERE [timestamp] BETWEEN '" & begin & "' AND '" & endtime & "'
               AND InOutMode = 'Check Out' 

          SELECT 
                (ROW_NUMBER() OVER(ORDER BY #t1.[timestamp])) 'No',
             

			   (
			   CASE
					WHEN #t1.userId IS NULL then #t2.userId
					ELSE
					#t1.userId
			   END
			   ) 'User ID',

			   (
				CASE 
					WHEN #t1.personellName IS NULL then #t2.personellName
					ELSE
					#t1.personellName
				END
			   ) 'Employee Name', tUserExternal.subcon 'SubCon'
		   ,
               #t1.[timestamp] 'Check In',
              			   #t1.[deviceName] 'Check In Device',
               (
	             CASE 
	                 WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                 ELSE
	                 #t2.[timestamp]
	             END
               ) 'Check Out',
			   #t2.deviceName 'Check Out Device',
               (
                 CASE
	                WHEN datediff(hh,#t1.[timestamp],#t2.[timestamp]) < 0 THEN NULL
                    WHEN DAY (#t2.[timestamp]) NOT IN (DATEPART(dd,#t1.[timestamp])) THEN NULL
	                else 
	                datediff(hh,#t1.[timestamp],#t2.[timestamp])
	             END
               ) 'Worked Hours',

			   (
				CASE
					WHEN #t1.VerifyType IS NULL THEN 'FACE+CARD'
					ELSE
					#t1.VerifyType
				END
			   ) 'Verify Type'

               FROM #t1 FULL JOIN #t2 ON #t1.userId = #t2.UserId
               AND DATEPART(dd,#t1.[timestamp]) = DATEPART(dd,#t2.[timestamp]) 
			   AND DATEPART(mm,#t1.[timestamp]) = DATEPART(mm,#t2.[timestamp]) 
			   AND DATEPART(yy,#t1.[timestamp]) = DATEPART(yy,#t2.[timestamp]) 
			   JOIN tDeviceUser2 ON tDeviceUser2.userId = #t1.userId AND (tDeviceUser2.employeeType = 'EXTERNAL' OR tDeviceUser2.employeeType = '')
			   JOIN tUserExternal ON tUserExternal.userId = #t1.userId
               ORDER BY [Check In] asc
               DROP TABLE #t1
               DROP TABLE #t2

		
                                        
        ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "Report")
                    dgvReport.DataSource = ds.Tables("Report")
                    lblKeseluruhan.Text = "Jumlah Data  : " & dgvReport.Rows.Count.ToString

                Catch ex As Exception
                    MsgBox(ex.ToString())
                    saveError(ex.ToString())
                End Try
            End If
        End If
    End Sub

    Private Sub dgvReport_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReport.CellDoubleClick
        Dim index As Integer = dgvReport.CurrentCell.RowIndex()
        Dim userId As String
        Dim dateValue As DateTime

        userId = dgvReport.Rows(index).Cells(1).Value()
        If dgvReport.Rows(index).Cells(4).Value.ToString = "" Then
            dateValue = dgvReport.Rows(index).Cells(6).Value.ToString()
        ElseIf dgvReport.Rows(index).Cells(4).Value.ToString = "" And dgvReport.Rows(index).Cells(6).Value.ToString = "" Then
            dateValue = DateTime.Now.ToString("yyyy-MM-dd")
        Else
            dateValue = dgvReport.Rows(index).Cells(4).Value.ToString()
        End If
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter("
            SELECT 
	            tReport.userId 'User ID',
	            tReport.empNo 'Employee No',
                tReport.personellName 'Personnel Name',
	            tReport.[timestamp] 'Time Stamp',
	            tReport.[deviceName] 'Device Name',
	            tReport.InOutMode 'In Out Mode'
             FROM tReport WHERE userId = '" & userId & "'
             AND DATEPART(dd,[timestamp]) = '" & dateValue.Day.ToString() & "'
             AND DATEPART(mm,[timestamp]) = '" & dateValue.Month.ToString() & "'
             AND DATEPART(yy,[timestamp]) = '" & dateValue.Year.ToString() & "'
        ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "Report")
            frmAttHistory.dgvHistory.DataSource = ds.Tables("Report")
            frmAttHistory.lblHistory.Text = "Jumlah Data  : " & frmAttHistory.dgvHistory.Rows.Count.ToString
            frmAttHistory.userId = dgvReport.Rows(index).Cells(1).Value.ToString()
            frmAttHistory.Show()
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub
End Class