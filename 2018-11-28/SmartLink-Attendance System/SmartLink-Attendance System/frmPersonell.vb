Imports System.Data.SqlClient

Public Class frmPersonell
    Dim photoURL As String
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Public axCZKEM1 As New zkemkeeper.CZKEM
    Sub showDGVPersonell()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT userId 'User ID', identityNo 'Identity Number', employeeNo 'Employee Number',
            employeeName 'Employee Name', cardNumber 'Card Number', privilege 'Privilege',
            contractStartDate 'Contract Start Date', contractEndDate 'Contract End Date', section 'Section', position 'Position'
            FROM tDeviceUser2
            ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "devUser")
            dgvPersonell.DataSource = ds.Tables("devUser")
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox("Error when trying to populate Personnel DGV")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Error when trying to close the form")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub frmPersonell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            showDGVPersonell()
        Catch ex As Exception
            MsgBox("Error on formLoad")
            saveError(ex.ToString)
        End Try
    End Sub

    Private Sub BlockUserCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlockUserCardToolStripMenuItem.Click
        Try
            bIsConnected = axCZKEM1.Connect_Net(_globalIPAddress, _globalPort)
            Dim index As Integer = dgvPersonell.CurrentCell.RowIndex
            Dim bEnabled As Boolean
            Dim idwErrorCode As Integer
            bEnabled = False
            openConnection()
            Dim cmdCard As New SqlCommand("UPDATE tCard SET cardStatus = 'BLOCKED' WHERE cardNumber = '" & dgvPersonell.Rows(index).Cells(2).Value & "' AND userId = '" & dgvPersonell.Rows(index).Cells(0).Value & "'", conn)
            cmdCard.ExecuteNonQuery()

            Dim sdwEnrollNumber As Integer = dgvPersonell.Rows(index).Cells(0).Value
            Dim sName As String = dgvPersonell.Rows(index).Cells(1).Value
            Dim sPassword As String = dgvPersonell.Rows(index).Cells(4).Value
            Dim iPrivilege As Integer
            If dgvPersonell.Rows(index).Cells(3).Value = "SUPER ADMIN" Then
                iPrivilege = "3"
            ElseIf dgvPersonell.Rows(index).Cells(3).Value = "NORMAL USER" Then
                iPrivilege = "0"
            End If

            Dim sCardnumber As String = dgvPersonell.Rows(index).Cells(2).Value & "00"

            Cursor = Cursors.WaitCursor
            axCZKEM1.EnableDevice(iMachineNumber, False)
            axCZKEM1.SetStrCardNumber(sCardnumber) 'Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
            If axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True Then 'upload the user's information(card number included)
                MsgBox("SetUserInfo,UserID:" + sdwEnrollNumber.ToString() + " Privilege:" + iPrivilege.ToString() + " Cardnumber:" + sCardnumber + " Enabled:" + bEnabled.ToString(), MsgBoxStyle.Information, "Success")
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
            axCZKEM1.EnableDevice(iMachineNumber, True)
            Cursor = Cursors.Default


            Dim cmd As New SqlCommand("UPDATE tDeviceUser set CardNumber = '" & sCardnumber & "', privilege = '" & dgvPersonell.Rows(index).Cells(3).Value & "', enabled = 'FALSE' WHERE userId = '" & dgvPersonell.Rows(index).Cells(0).Value & "'", conn)
            openConnection()
            cmd.ExecuteNonQuery()
            MsgBox("
ly Updated")
            showDGVPersonell()

        Catch ex As Exception
            MsgBox("Error when trying to block card")
            saveError(ex.ToString())
        End Try
    End Sub

    'Private Sub UnblockUserCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnblockUserCardToolStripMenuItem.Click

    'End Sub

    Private Sub UnblockUserCardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UnblockUserCardToolStripMenuItem1.Click
        Try
            bIsConnected = axCZKEM1.Connect_Net(_globalIPAddress, _globalPort)
            Dim index As Integer = dgvPersonell.CurrentCell.RowIndex
            Dim bEnabled As Boolean
            Dim idwErrorCode As Integer
            bEnabled = True


            Dim sdwEnrollNumber As Integer = dgvPersonell.Rows(index).Cells(0).Value
            Dim sName As String = dgvPersonell.Rows(index).Cells(1).Value
            Dim sPassword As String = dgvPersonell.Rows(index).Cells(4).Value
            Dim iPrivilege As Integer
            If dgvPersonell.Rows(index).Cells(3).Value = "SUPER ADMIN" Then
                iPrivilege = "3"
            ElseIf dgvPersonell.Rows(index).Cells(3).Value = "NORMAL USER" Then
                iPrivilege = "0"
            End If

            Dim cardNumber As String = dgvPersonell.Rows(index).Cells(2).Value
            Dim sCardnumber As String = cardNumber.Substring(0, 7)


            Cursor = Cursors.WaitCursor
            axCZKEM1.EnableDevice(iMachineNumber, False)
            axCZKEM1.SetStrCardNumber(sCardnumber) 'Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
            If axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True Then 'upload the user's information(card number included)
                MsgBox("SetUserInfo,UserID:" + sdwEnrollNumber.ToString() + " Privilege:" + iPrivilege.ToString() + " Cardnumber:" + sCardnumber + " Enabled:" + bEnabled.ToString(), MsgBoxStyle.Information, "Success")
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
            axCZKEM1.EnableDevice(iMachineNumber, True)
            Cursor = Cursors.Default

            Dim cmd As New SqlCommand("UPDATE tDeviceUser set CardNumber = '" & sCardnumber & "', privilege = '" & dgvPersonell.Rows(index).Cells(3).Value & "', enabled = 'TRUE' WHERE userId = '" & dgvPersonell.Rows(index).Cells(0).Value & "'", conn)
            openConnection()
            cmd.ExecuteNonQuery()
            MsgBox("sucessfully Updated")
            showDGVPersonell()
        Catch ex As Exception
            MsgBox("Error when trying to unblock user")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub ReturnCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnCardToolStripMenuItem.Click
        Try
            bIsConnected = axCZKEM1.Connect_Net(_globalIPAddress, "4370")
            Dim index As Integer = dgvPersonell.CurrentCell.RowIndex
            Dim bEnabled As Boolean
            Dim idwErrorCode As Integer
            bEnabled = False


            Dim sdwEnrollNumber As Integer = dgvPersonell.Rows(index).Cells(0).Value
            Dim sName As String = dgvPersonell.Rows(index).Cells(1).Value
            Dim sPassword As String = dgvPersonell.Rows(index).Cells(4).Value
            Dim iPrivilege As Integer
            If dgvPersonell.Rows(index).Cells(3).Value = "SUPER ADMIN" Then
                iPrivilege = "3"
            ElseIf dgvPersonell.Rows(index).Cells(3).Value = "NORMAL USER" Then
                iPrivilege = "0"
            End If

            Dim sCardnumber As String = dgvPersonell.Rows(index).Cells(2).Value & "00"



            Cursor = Cursors.WaitCursor
            axCZKEM1.EnableDevice(iMachineNumber, False)
            axCZKEM1.SetStrCardNumber(sCardnumber) 'Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
            If axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True Then 'upload the user's information(card number included)
                MsgBox("SetUserInfo,UserID:" + sdwEnrollNumber.ToString() + " Privilege:" + iPrivilege.ToString() + " Cardnumber:" + sCardnumber + " Enabled:" + bEnabled.ToString(), MsgBoxStyle.Information, "Success")
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
            axCZKEM1.EnableDevice(iMachineNumber, True)
            Cursor = Cursors.Default


            Dim cmd As New SqlCommand("UPDATE tDeviceUser set CardNumber = '" & sCardnumber & "', privilege = '" & dgvPersonell.Rows(index).Cells(3).Value & "', enabled = 'RETURNED' WHERE userId = '" & dgvPersonell.Rows(index).Cells(0).Value & "'", conn)
            openConnection()
            cmd.ExecuteNonQuery()
            MsgBox("sucessfully Updated")
            showDGVPersonell()
        Catch ex As Exception
            MsgBox("Error when trying to return Card")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub UnblockUserCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnblockUserCardToolStripMenuItem.Click
        Try
            bIsConnected = axCZKEM1.Connect_Net(_globalIPAddress, "4370")
            Dim index As Integer = dgvPersonell.CurrentCell.RowIndex
            Dim bEnabled As Boolean
            Dim idwErrorCode As Integer
            bEnabled = False


            Dim sdwEnrollNumber As Integer = dgvPersonell.Rows(index).Cells(0).Value
            Dim sName As String = dgvPersonell.Rows(index).Cells(3).Value
            Dim sPassword As String = dgvPersonell.Rows(index).Cells(4).Value
            Dim iPrivilege As Integer
            If dgvPersonell.Rows(index).Cells(3).Value = "SUPER ADMIN" Then
                iPrivilege = "3"
            ElseIf dgvPersonell.Rows(index).Cells(3).Value = "NORMAL USER" Then
                iPrivilege = "0"
            End If
            Dim sCardnumber As String = dgvPersonell.Rows(index).Cells(4).Value


            Cursor = Cursors.WaitCursor
            axCZKEM1.EnableDevice(iMachineNumber, False)
            axCZKEM1.SetStrCardNumber(sCardnumber) 'Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
            If axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True Then 'upload the user's information(card number included)
                MsgBox("SetUserInfo,UserID:" + sdwEnrollNumber.ToString() + " Privilege:" + iPrivilege.ToString() + " Cardnumber:" + sCardnumber + " Enabled:" + bEnabled.ToString(), MsgBoxStyle.Information, "Success")
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
            axCZKEM1.EnableDevice(iMachineNumber, True)
            Cursor = Cursors.Default

            openConnection()
            Dim cmd As New SqlCommand("UPDATE tDeviceUser2 set [CardNumber] = @cardNumber, [privilege] = @privilege, [enabled] = @enabled WHERE [userId] = '" & dgvPersonell.Rows(index).Cells(0).Value & "'", conn)

            cmd.Parameters.Add("@cardNumber", sCardnumber)
            cmd.Parameters.Add("@privilege  ", dgvPersonell.Rows(index).Cells(3).Value)
            cmd.Parameters.Add("@enabled", "TRUE")
            cmd.ExecuteNonQuery()
            MsgBox("sucessfully Updated")
            showDGVPersonell()
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            openConnection()
            Dim index As Integer = dgvPersonell.CurrentCell.RowIndex
            If dgvPersonell.Rows(index).Cells(6).Value.ToString = "" Then
            Else

            End If
            'Populate Textboxes 
            Dim cmd As New SqlCommand("SELECT * FROM tDeviceUser2 WHERE userId = '" & dgvPersonell.Rows(index).Cells(0).Value.ToString() & "'", conn)

            dReader = cmd.ExecuteReader
            dReader.Read()
            If dReader.HasRows = True Then


                If dReader.Item("PhotoURL").ToString = "" Then

                Else
                    Try
                        Dim FileStream1 As New System.IO.FileStream(dReader.Item("PhotoURL").ToString, IO.FileMode.Open, IO.FileAccess.Read)
                        Dim MyImage As Image = Image.FromStream(FileStream1)
                        frmPopupPersonell.pbUser.Image = MyImage
                        frmPopupPersonell.pbUser.SizeMode = PictureBoxSizeMode.StretchImage
                        FileStream1.Dispose()
                    Catch ex As Exception
                        MessageBox.Show("Seems like the photo of this employee is missing!")
                    End Try
                End If

                If dReader.Item("employeeType").ToString() = "INTERNAL" Then

                    Dim cmdSelect As New SqlCommand("SELECT * FROM tUserInternal WHERE userId = '" & dgvPersonell.Rows(index).Cells(0).Value.ToString() & "'", conn)
                    Dim dReader2 As SqlDataReader = cmdSelect.ExecuteReader
                    dReader2.Read()

                    If dReader2.HasRows = True Then
                        'Tab 1 
                        frmPopupPersonell.txtUserId.Text = dgvPersonell.Rows(index).Cells(0).Value.ToString()
                        frmPopupPersonell.txtName.Text = dgvPersonell.Rows(index).Cells(3).Value.ToString()
                        frmPopupPersonell.cbbEmployeeType.Text = "INTERNAL"
                        frmPopupPersonell.cbbUserGroup.Text = dReader.Item("userGroup")
                        frmPopupPersonell.txtType1.Text = dReader2.Item("position")
                        frmPopupPersonell.txtType2.Text = dReader2.Item("department")
                        frmPopupPersonell.cbbWorkHours.Text = dReader2.Item("WorkHours")
                        If dgvPersonell.Rows(index).Cells(6).Value.ToString = "" Then
                            frmPopupPersonell.dtpStartDate.Value = DateTime.Now
                        Else
                            frmPopupPersonell.dtpStartDate.Value = dgvPersonell.Rows(index).Cells(6).Value.ToString
                        End If

                        If dgvPersonell.Rows(index).Cells(7).Value.ToString = "" Then
                            frmPopupPersonell.dtpEndDate.Value = DateTime.Now
                        Else
                            frmPopupPersonell.dtpEndDate.Value = dgvPersonell.Rows(index).Cells(7).Value.ToString
                        End If
                        frmPopupPersonell.txtEmpNo.Text = dgvPersonell.Rows(index).Cells(2).Value
                        frmPopupPersonell.txtKTP.Text = dgvPersonell.Rows(index).Cells(1).Value
                        'Tab 2
                        frmPopupPersonell.txtCardNumber.Text = dgvPersonell.Rows(index).Cells(4).Value.ToString()
                        frmPopupPersonell.cbbPrivilege.Text = dgvPersonell.Rows(index).Cells(5).Value.ToString()
                        frmPopupPersonell.txtSection.Text = dgvPersonell.Rows(index).Cells(8).Value.ToString()
                        frmPopupPersonell.txtPosition.Text = dgvPersonell.Rows(index).Cells(9).Value.ToString()
                        frmPopupPersonell.Show()
                    Else
                        frmPopupPersonell.txtKTP.Text = dgvPersonell.Rows(index).Cells(1).Value.ToString()
                        frmPopupPersonell.txtEmpNo.Text = dgvPersonell.Rows(index).Cells(2).Value.ToString()
                        frmPopupPersonell.txtUserId.Text = dgvPersonell.Rows(index).Cells(0).Value.ToString()
                        frmPopupPersonell.txtName.Text = dgvPersonell.Rows(index).Cells(3).Value.ToString()
                        frmPopupPersonell.txtCardNumber.Text = dgvPersonell.Rows(index).Cells(4).Value.ToString()
                        frmPopupPersonell.cbbPrivilege.Text = dgvPersonell.Rows(index).Cells(5).Value.ToString()
                        If dgvPersonell.Rows(index).Cells(6).Value.ToString = "" Then
                            frmPopupPersonell.dtpStartDate.Value = DateTime.Now
                        Else
                            frmPopupPersonell.dtpStartDate.Value = dgvPersonell.Rows(index).Cells(6).Value.ToString
                        End If

                        If dgvPersonell.Rows(index).Cells(7).Value.ToString = "" Then
                            frmPopupPersonell.dtpEndDate.Value = DateTime.Now
                        Else
                            frmPopupPersonell.dtpEndDate.Value = dgvPersonell.Rows(index).Cells(7).Value.ToString
                        End If
                        frmPopupPersonell.Show()
                    End If

                ElseIf dReader.Item("employeeType").ToString() = "EXTERNAL" Then

                    Dim cmdSelect As New SqlCommand("SELECT * FROM tUserExternal WHERE userId = '" & dgvPersonell.Rows(index).Cells(0).Value.ToString() & "'", conn)
                    Dim dReader2 As SqlDataReader = cmdSelect.ExecuteReader
                    dReader2.Read()

                    If dReader2.HasRows = True Then
                        'Tab 1 
                        frmPopupPersonell.txtUserId.Text = dgvPersonell.Rows(index).Cells(0).Value.ToString()

                        frmPopupPersonell.txtEmpNo.Text = dgvPersonell.Rows(index).Cells(2).Value.ToString

                        frmPopupPersonell.txtKTP.Text = dgvPersonell.Rows(index).Cells(1).Value.ToString

                        frmPopupPersonell.txtName.Text = dgvPersonell.Rows(index).Cells(3).Value.ToString()

                        frmPopupPersonell.cbbEmployeeType.Text = "EXTERNAL"

                        If dReader.Item("userGroup").ToString() <> "" Then
                            MsgBox("true")
                            frmPopupPersonell.cbbUserGroup.Text = dReader.Item("userGroup").ToString()

                        Else
                            frmPopupPersonell.cbbUserGroup.Text = ""
                        End If

                        If dReader2.Item("subcon").ToString() <> "" Then
                            frmPopupPersonell.txtType1.Text = dReader2.Item("subcon").ToString()
                        Else
                            frmPopupPersonell.txtType1.Text = ""
                        End If


                        If dReader2.Item("project").ToString() <> "" Then
                            frmPopupPersonell.txtType2.Text = dReader2.Item("project").ToString()
                        Else
                            frmPopupPersonell.txtType2.Text = ""
                        End If

                        If dReader2.Item("WorkHours").ToString() <> "" Then
                            frmPopupPersonell.cbbWorkHours.Text = dReader2.Item("WorkHours").ToString()
                        Else
                            frmPopupPersonell.cbbWorkHours.Text = ""
                        End If

                        If dgvPersonell.Rows(index).Cells(6).Value.ToString = "" Then
                                frmPopupPersonell.dtpStartDate.Value = DateTime.Now
                            Else
                                frmPopupPersonell.dtpStartDate.Value = dgvPersonell.Rows(index).Cells(6).Value.ToString
                            End If

                        If dgvPersonell.Rows(index).Cells(7).Value.ToString = "" Then
                            frmPopupPersonell.dtpEndDate.Value = DateTime.Now
                        Else
                            frmPopupPersonell.dtpEndDate.Value = dgvPersonell.Rows(index).Cells(7).Value.ToString
                        End If

                        If dReader.Item("EmployeeNo").ToString() <> "" Then
                            frmPopupPersonell.txtEmpNo.Text = dReader.Item("EmployeeNo").ToString()
                        Else
                            frmPopupPersonell.txtEmpNo.Text = ""
                        End If

                        'TAB 2
                        frmPopupPersonell.txtCardNumber.Text = dgvPersonell.Rows(index).Cells(4).Value.ToString()
                            frmPopupPersonell.cbbPrivilege.Text = dgvPersonell.Rows(index).Cells(5).Value.ToString()
                            frmPopupPersonell.Show()

                        Else

                            frmPopupPersonell.txtUserId.Text = dgvPersonell.Rows(index).Cells(0).Value.ToString()
                        frmPopupPersonell.txtName.Text = dgvPersonell.Rows(index).Cells(3).Value.ToString()
                        frmPopupPersonell.txtCardNumber.Text = dgvPersonell.Rows(index).Cells(4).Value.ToString()
                        frmPopupPersonell.cbbPrivilege.Text = dgvPersonell.Rows(index).Cells(5).Value.ToString()
                        frmPopupPersonell.txtEmpNo.Text = dgvPersonell.Rows(index).Cells(2).Value.ToString
                        frmPopupPersonell.txtKTP.Text = dgvPersonell.Rows(index).Cells(1).Value.ToString
                        If dgvPersonell.Rows(index).Cells(6).Value.ToString = "" Then
                            frmPopupPersonell.dtpStartDate.Value = DateTime.Now
                        Else
                            frmPopupPersonell.dtpStartDate.Value = dgvPersonell.Rows(index).Cells(6).Value.ToString
                        End If

                        If dgvPersonell.Rows(index).Cells(7).Value.ToString = "" Then
                            frmPopupPersonell.dtpEndDate.Value = DateTime.Now
                        Else
                            frmPopupPersonell.dtpEndDate.Value = dgvPersonell.Rows(index).Cells(7).Value.ToString
                        End If

                        frmPopupPersonell.Show()
                    End If
                Else
                    'Tab 1 

                    frmPopupPersonell.txtUserId.Text = dgvPersonell.Rows(index).Cells(0).Value.ToString()
                    frmPopupPersonell.txtName.Text = dgvPersonell.Rows(index).Cells(3).Value.ToString()
                    frmPopupPersonell.txtCardNumber.Text = dgvPersonell.Rows(index).Cells(4).Value.ToString()
                    frmPopupPersonell.cbbPrivilege.Text = dgvPersonell.Rows(index).Cells(5).Value.ToString()
                    frmPopupPersonell.txtEmpNo.Text = dgvPersonell.Rows(index).Cells(2).Value.ToString
                    frmPopupPersonell.txtKTP.Text = dgvPersonell.Rows(index).Cells(1).Value.ToString
                    If dgvPersonell.Rows(index).Cells(6).Value.ToString = "" Then
                        frmPopupPersonell.dtpStartDate.Value = DateTime.Now
                    Else
                        frmPopupPersonell.dtpStartDate.Value = dgvPersonell.Rows(index).Cells(6).Value.ToString
                    End If

                    If dgvPersonell.Rows(index).Cells(7).Value.ToString = "" Then
                        frmPopupPersonell.dtpEndDate.Value = DateTime.Now
                    Else
                        frmPopupPersonell.dtpEndDate.Value = dgvPersonell.Rows(index).Cells(7).Value.ToString
                    End If

                    frmPopupPersonell.Show()
                End If
            Else
                MsgBox("No Data" & dReader.Item("employeeType"))
            End If
        Catch ex As Exception
            ex.ToString()
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click
        Try
            frmAddUser.Show()
        Catch ex As Exception
            MsgBox("Error happened when trying to open frmAddUser")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub EnableUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableUserToolStripMenuItem.Click
        Try
            Dim ion As Integer = dgvPersonell.CurrentCell.RowIndex
            bIsConnected = axCZKEM1.Connect_Net(_globalIPAddress, _globalPort)
            If bIsConnected = False Then
                MsgBox("Can't connect to this device. Please make sure the IP Address correct and the device is turned on")
            End If
            Dim idwErrorCode As Integer

            Cursor = Cursors.WaitCursor
            If axCZKEM1.SSR_EnableUser(iMachineNumber, dgvPersonell.Rows(ion).Cells(0).Value, True) = True Then

                MsgBox("Successfully Enable User", MsgBoxStyle.Information, "Success")

            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Error when trying to enable user")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub DisableUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableUserToolStripMenuItem.Click
        Try
            Dim ion As Integer = dgvPersonell.CurrentCell.RowIndex
            bIsConnected = axCZKEM1.Connect_Net(_globalIPAddress, _globalPort)
            If bIsConnected = False Then
                MsgBox("Can't connect to this device. Please make sure the IP Address correct and the device is turned on")
            End If
            Dim idwErrorCode As Integer

            Cursor = Cursors.WaitCursor
            If axCZKEM1.SSR_EnableUser(iMachineNumber, dgvPersonell.Rows(ion).Cells(0).Value, False) = True Then

                MsgBox("Successfully Disable User", MsgBoxStyle.Information, "Success")

            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Error when trying to disable user")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub dgvPersonell_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPersonell.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim index As Integer
                dgvPersonell.Rows(e.RowIndex).Selected = True
                index = e.RowIndex
                dgvPersonell.CurrentCell = dgvPersonell.Rows(e.RowIndex).Cells(1)
                ContextMenuStrip1.Show(dgvPersonell, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Error when trying to Right Click dgvPersonell")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            openConnection()
            Dim index As Integer = dgvPersonell.CurrentCell.RowIndex
            Dim cmd As New SqlCommand("SELECT * FROM tDeviceUser2 WHERE userId = '" & dgvPersonell.Rows(index).Cells(0).Value.ToString & "'", conn)
            Dim dReader As SqlDataReader
            dReader = cmd.ExecuteReader
            dReader.Read()
            If dReader.HasRows = True Then
                frmIdCard.lblName.Text = dReader.Item("employeeName").ToString
                frmIdCard.lblEmpNo.Text = dReader.Item("employeeNo").ToString
                frmIdCard.lblJabatan.Text = dReader.Item("position").ToString
                frmIdCard.Show()
            Else
                MsgBox("Operation Failed")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgvPersonell_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonell.CellDoubleClick

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearch.Text = "" Then
                showDGVPersonell()
            Else
                Try
                    openConnection()
                    Dim adaptor As New SqlDataAdapter("SELECT userId 'User ID', identityNo 'Identity Number', employeeNo 'Employee Number',
            employeeName 'Employee Name', cardNumber 'Card Number', privilege 'Privilege',
            contractStartDate 'Contract Start Date', contractEndDate 'Contract End Date', section 'Section', position 'Position'
            FROM tDeviceUser2
WHERE       userId LIKE '%" & txtSearch.Text & "%" & "' or 
            identityNo LIKE '%" & txtSearch.Text & "%" & "' or 
            employeeNo LIKE '%" & txtSearch.Text & "%" & "' or 
            employeeName LIKE '%" & txtSearch.Text & "%" & "' or 
            cardNumber LIKE '%" & txtSearch.Text & "%" & "' or 
            privilege LIKE '%" & txtSearch.Text & "%" & "' or 
            contractStartDate LIKE '%" & txtSearch.Text & "%" & "' or 
            contractEndDate LIKE '%" & txtSearch.Text & "%" & "'

            ", conn)
                    Dim ds As New DataSet
                    adaptor.Fill(ds, "devUser")
                    dgvPersonell.DataSource = ds.Tables("devUser")
                    ' dgvPersonell.Columns(6).Visible = False
                Catch ex As Exception
                    MsgBox("Error when trying to populate Personnel DGV")
                    saveError(ex.ToString())
                End Try
            End If
        End If
    End Sub
End Class