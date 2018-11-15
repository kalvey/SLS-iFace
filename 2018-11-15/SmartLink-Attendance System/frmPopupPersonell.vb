Imports System.Data.SqlClient
Imports System.Net
Imports System.IO

Public Class frmPopupPersonell
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Public axCZKEM1 As New zkemkeeper.CZKEM

    Dim bEnabled As Boolean
    Dim idwErrorCode As Integer

    Dim photoFileName As String
    Dim sdwEnrollNumber As Integer
    Dim sName As String
    Dim sPassword As String
    Dim iPrivilege As Integer
    Dim sCardnumber As String
    Public filePath As String
    Private Sub frmPopupPersonell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbbDepartment()
            cbbDepart.SelectionLength = 0
        Catch ex As Exception
            MsgBox("Error when initiating: employeeType")
            saveError(ex.ToString())
        End Try
    End Sub
    Sub employeeType()
        Try
            If cbbEmployeeType.Text = "INTERNAL" Then
                lbl1.Visible = True
                lbl2.Visible = True
                lbl3.Visible = True
                lbl1.Text = "Position"
                lbl2.Text = "Department"
                lbl3.Text = "Work Hours"
                txtType1.Visible = True
                txtType2.Visible = False
                cbbDepart.Visible = True
                cbbWorkHours.Visible = True

                lblSection.Visible = True
                lblPosition.Visible = True
                lblPosition.Text = "Position"
                lblSection.Text = "Section"
                txtPosition.Visible = True
                txtSection.Visible = True
            ElseIf cbbEmployeeType.Text = "EXTERNAL" Then
                lbl1.Visible = True
                lbl2.Visible = True
                lbl3.Visible = True
                lbl1.Text = "Subcon"
                lbl2.Text = "Project"
                lbl3.Text = "Work Hours"
                txtType1.Visible = True
                txtType2.Visible = True
                cbbDepart.Visible = False

                cbbWorkHours.Visible = True

                lblPosition.Visible = True
                lblSection.Visible = True
                lblPosition.Text = "Position"
                lblSection.Text = "Section"
                txtPosition.Visible = True
                txtSection.Visible = True
            Else
                'do Nothing
            End If
        Catch ex As Exception
            MsgBox("Error when trying to initialize cbbEmployee")
            saveError(ex.ToString())
        End Try
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
    Private Sub cbbEmployeeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEmployeeType.SelectedIndexChanged
        Try
            employeeType()
        Catch ex As Exception
            MsgBox("Error when trying to initialize employeeType")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Try
        openConnection()
            Dim result As DialogResult = MessageBox.Show("Do you want to update the data to device?", "warning", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim cmd As New SqlCommand("SELECT * from tCard WHERE cardNumber = '" & txtCardNumber.Text & "'", conn)
                Dim dReaderCMD As SqlDataReader = cmd.ExecuteReader
                dReaderCMD.Read()
                If dReaderCMD.HasRows = True Then
                    If dReaderCMD.Item("userId") <> txtUserId.Text Then
                        MsgBox("This Card Number is already assigned for another user")
                    Else
                        updateDatatoDevice()
                        Me.Close()
                    End If
                Else
                    updateDatatoDevice()
                    Me.Close()
                End If
            Else

            ' updateDatabase()
            UpdateData()
            showDGVPersonell()
                Me.Close()
            End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        'End Try
    End Sub

    Sub updateDatatoDevice()
        Try
            sdwEnrollNumber = txtUserId.Text
            sName = txtName.Text
            sPassword = ""
            If cbbPrivilege.Text = "Normal User" Then
                iPrivilege = "0"
            ElseIf cbbPrivilege.Text = "Super Admin" Then
                iPrivilege = "3"
            End If
            sCardnumber = txtCardNumber.Text

            If _globalIPAddress = "" And _globalPort = "" Then
                MsgBox("Please Select Device to Use in Device Management")
                frmSelectDevice.Show()
            Else
                bIsConnected = axCZKEM1.Connect_Net(_globalIPAddress, _globalPort)
                '   Dim index As Integer = frmdgvPersonell.CurrentCell.RowIndex
                bEnabled = True

                Cursor = Cursors.WaitCursor
                axCZKEM1.EnableDevice(iMachineNumber, False)
                axCZKEM1.SetStrCardNumber(sCardnumber) 'Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
                If axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True Then 'upload the user's information(card number included)
                    MsgBox("Data has been updated to device!")
                    '     MsgBox("SetUserInfo,UserID:" + sdwEnrollNumber.ToString() + " Privilege:" + iPrivilege.ToString() + " Cardnumber:" + sCardnumber + " Enabled:" + bEnabled.ToString(), MsgBoxStyle.Information, "Success")
                Else
                    axCZKEM1.GetLastError(idwErrorCode)
                    MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
                End If
                axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
                axCZKEM1.EnableDevice(iMachineNumber, True)
                Cursor = Cursors.Default
                updateDatabase()
                showDGVPersonell()
            End If
        Catch ex As Exception
            MsgBox("Error when trying to save data")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Error happened when trying to close: btnCancel")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPicture.Click
        Try
            '  Dim index As Integer = dgvPersonell.CurrentCell.RowIndex
            'Populate PictureBox
            Dim opf As New OpenFileDialog

            'untuk menload gambar dari pc user
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If opf.ShowDialog = DialogResult.OK Then
                pbUser.BackgroundImage = Image.FromFile(opf.FileName)
                photoFileName = opf.FileName
                lblImagePath.Text = System.IO.Path.GetFileName(opf.FileName)
            End If

        Catch ex As Exception
            MsgBox("Error when trying to access btnPicture")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Function TakeScreenShot(ByVal Control As Control) As Bitmap
        Dim tmpImg As New Bitmap(Control.Width, Control.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(Control.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(Control.Width, Control.Height))
        End Using
        Return tmpImg
    End Function
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

        TakeScreenShot(Me).Save("D:\Screenshot.png", System.Drawing.Imaging.ImageFormat.Png)
    End Sub
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
            frmPersonell.dgvPersonell.DataSource = ds.Tables("devUser")
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox("Error when trying to populate Personnel DGV")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnSubCon_Click(sender As Object, e As EventArgs) Handles btnSubCon.Click
        frmSelectSubcon.Show()
    End Sub
    'Sub updateDatabase()
    '    Try

    '        'Update tDeviceUser
    '        If photoFileName <> "" Then
    '            Dim cmdUser As New SqlCommand("Update tDeviceUser SET [name] = '" & txtName.Text & "', cardNumber = '" & txtCardNumber.Text & "', privilege = '" & cbbPrivilege.Text & "', employeeType = '" & cbbEmployeeType.Text & "', userGroup = '" & cbbUserGroup.Text & "', updateBy = 'ME', updateDate = '" & DateTime.Now & "', updateAt = '" & Environment.MachineName & "', photoURL = '" & photoFileName & "',  contractStartDate = @startDate, contractEndDate = @endDate, EmployeeNo = '" & txtEmpNo.Text & "' , departmentNo = '" & cbbDepart.SelectedValue & "', departmentName = '" & cbbDepart.Text & "'WHERE userId = '" & txtUserId.Text & "'", conn)
    '            cmdUser.Parameters.AddWithValue("@startDate", dtpStartDate.Value)
    '            cmdUser.Parameters.AddWithValue("@endDate", dtpEndDate.Value)
    '            cmdUser.ExecuteNonQuery()
    '        Else
    '            Dim cmdUser As New SqlCommand("Update tDeviceUser SET [name] = '" & txtName.Text & "', cardNumber = '" & txtCardNumber.Text & "', privilege = '" & cbbPrivilege.Text & "', employeeType = '" & cbbEmployeeType.Text & "', userGroup = '" & cbbUserGroup.Text & "', updateBy = 'ME', updateDate = '" & DateTime.Now & "', updateAt = '" & Environment.MachineName & "', photoURL = '" & photoFileName & "', contractStartDate = @startDate, contractEndDate = @endDate, EmployeeNo = '" & txtEmpNo.Text & "', departmentNo = '" & cbbDepart.SelectedValue & "', departmentName = '" & cbbDepart.Text & "' WHERE userId = '" & txtUserId.Text & "'", conn)
    '            cmdUser.Parameters.AddWithValue("@startDate", dtpStartDate.Value)
    '            cmdUser.Parameters.AddWithValue("@endDate", dtpEndDate.Value)
    '            cmdUser.ExecuteNonQuery()
    '        End If

    '        'Jika Employee Type == Internal
    '        If cbbEmployeeType.Text = "INTERNAL" Then

    '            Dim cmdInternal As New SqlCommand("SELECT * FROM tUserInternal WHERE userId = '" + txtUserId.Text + "'", conn)
    '            dReader = cmdInternal.ExecuteReader
    '            dReader.Read()
    '            If dReader.HasRows = True Then
    '                Dim cmdUpdate As New SqlCommand("UPDATE tUserInternal SET [name] = '" + txtName.Text + "', position = '" + txtType1.Text + "', department = '" & cbbDepart.Text & "', workHours = '" & cbbWorkHours.Text & "', departmentID = '" & cbbDepart.SelectedValue & "' WHERE userId = '" & txtUserId.Text & "'", conn)

    '                cmdUpdate.ExecuteNonQuery()
    '            Else
    '                Dim cmdInsert As New SqlCommand("INSERT INTO tUserInternal VALUES ('" & txtUserId.Text & "', '" & txtName.Text & "', '" & txtType1.Text & "', '" & cbbDepart.Text & "', '" & cbbWorkHours.Text & "', '" & cbbDepart.SelectedValue & "')", conn)

    '                cmdInsert.ExecuteNonQuery()
    '            End If
    '        End If

    '        'Jika Employee Type == External
    '        If cbbEmployeeType.Text = "EXTERNAL" Then
    '            'Update tExternal
    '            Dim cmdExternal As New SqlCommand("SELECT * FROM tUserExternal WHERE userId = '" + txtUserId.Text + "'", conn)
    '            dReader = cmdExternal.ExecuteReader
    '            dReader.Read()
    '            If dReader.HasRows = True Then
    '                Dim cmdUpdate As New SqlCommand("UPDATE tUserExternal SET [name] = '" + txtName.Text + "', subcon = '" + txtType1.Text + "', project = '" & txtType2.Text & "', workHours = '" & cbbWorkHours.Text & "' WHERE userId = '" & txtUserId.Text & "'", conn)

    '                cmdUpdate.ExecuteNonQuery()
    '            Else
    '                Dim cmdInsert As New SqlCommand("INSERT INTO tUserExternal VALUES ('" & txtUserId.Text & "', '" & txtName.Text & "', '" & txtType1.Text & "', '" & txtType2.Text & "', '" & cbbWorkHours.Text & "')", conn)

    '                cmdInsert.ExecuteNonQuery()
    '            End If
    '        End If

    '        Dim cmdCard As New SqlCommand("SELECT * FROM tCard WHERE userId = '" & txtUserId.Text & "'", conn)

    '        Dim dReader3 As SqlDataReader = cmdCard.ExecuteReader
    '        dReader3.Read()
    '        If dReader3.HasRows = True Then

    '            Dim cmdUpdate As New SqlCommand("UPDATE tCard SET cardNumber = '" & txtCardNumber.Text & "', cardStatus = 'ACTIVE', validFrom =  '" & dtpFrom.Value & "', validTo = '" & dtpTo.Value & "' WHERE userId = '" & txtUserId.Text & "'", conn)
    '            cmdUpdate.ExecuteNonQuery()

    '        Else
    '            Dim cmdInsert As New SqlCommand("INSERT INTO tCard VALUES ('" & txtUserId.Text & "', '" & txtCardNumber.Text & "', 'ACTIVE', '" & dtpFrom.Value & "',  '" & dtpTo.Value & "')", conn)
    '            cmdInsert.ExecuteNonQuery()
    '        End If
    '        MsgBox("Successfully Updated to Database")
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '        saveError(ex.ToString())
    '    End Try
    'End Sub


    Sub updateDatabase()


        'Update tDeviceUser

        If lblImagePath.Text <> "" Then
            MessageBox.Show(lblImagePath.Text & " is Available")
            Dim path As String
            Dim Client As New WebClient
            path = Application.StartupPath & "\images\0\" & txtName.Text & "\"
            If Not Directory.Exists(path) Then
                Directory.CreateDirectory(path)
                filePath = path & lblImagePath.Text
                Client.DownloadFile(photoFileName, filePath)
                Client.Dispose()
            Else
                filePath = path & lblImagePath.Text
                Client.DownloadFile(photoFileName, filePath)
                Client.Dispose()
            End If
            Dim cmdUser As New SqlCommand("Update tDeviceUser2 SET [position] = '" & txtPosition.Text & "', [section] = '" & txtSection.Text & "',[employeeName] = '" & txtName.Text & "', cardNumber = '" & txtCardNumber.Text & "', privilege = '" & cbbPrivilege.Text & "', employeeType = '" & cbbEmployeeType.Text & "', userGroup = '" & cbbUserGroup.Text & "', updateBy = 'ME', updateDate = '" & DateTime.Now & "', updateAt = '" & Environment.MachineName & "', photoURL = '" & filePath & "',  contractStartDate = @startDate, contractEndDate = @endDate,  [status] = 'ACTIVE' WHERE userId = '" & txtUserId.Text & "'", conn)

            cmdUser.Parameters.AddWithValue("@startDate", dtpStartDate.Value)
            cmdUser.Parameters.AddWithValue("@endDate", dtpEndDate.Value)

            cmdUser.ExecuteNonQuery()

            MsgBox(filePath)
        Else

            'Dim cmdUser As New SqlCommand("Update tDeviceUser2 SET [position] = '" & txtPosition.Text & "', [section] = '" & txtSection.Text & "',[employeeName] = '" & txtName.Text & "', cardNumber = '" & txtCardNumber.Text & "', privilege = '" & cbbPrivilege.Text & "', employeeType = '" & cbbEmployeeType.Text & "', userGroup = '" & cbbUserGroup.Text & "', updateBy = 'ME', updateDate = '" & DateTime.Now & "', updateAt = '" & Environment.MachineName & "', contractStartDate = @startDate, contractEndDate = @endDate, [status] = 'ACTIVE' WHERE userId = '" & txtUserId.Text & "'", conn)
            Dim cmdUser As New SqlCommand("Update tDeviceUser2 SET [position] = '" & txtPosition.Text & "', [section] = '" & txtSection.Text & "',[employeeName] = '" & txtName.Text & "', cardNumber = '" & txtCardNumber.Text & "', privilege = '" & cbbPrivilege.Text & "', employeeType = '" & cbbEmployeeType.Text & "', userGroup = '" & cbbUserGroup.Text & "', updateBy = 'ME', updateDate = '" & DateTime.Now.ToString("yyyy-MM-dd") & "', updateAt = '" & Environment.MachineName & "',[status] = 'ACTIVE' WHERE userId = '" & txtUserId.Text & "'", conn)
            MsgBox("cmdUser 1")
            Dim begin, endDate As DateTime
            begin = dtpStartDate.Value
            endDate = dtpEndDate.Value
            cmdUser.Parameters.AddWithValue("@startDate", begin)
            cmdUser.Parameters.AddWithValue("@endDate", endDate)
            cmdUser.ExecuteNonQuery()
        End If

        'Jika Employee Type == Internal
        If cbbEmployeeType.Text = "INTERNAL" Then

            Dim cmdInternal As New SqlCommand("SELECT * FROM tUserInternal WHERE userId = '" + txtUserId.Text + "'", conn)
            dReader = cmdInternal.ExecuteReader
            dReader.Read()
            If dReader.HasRows = True Then
                Dim cmdUpdate As New SqlCommand("UPDATE tUserInternal SET [name] = '" + txtName.Text + "', position = '" + txtType1.Text + "', department = '" & txtType2.Text & "', workHours = '" & cbbWorkHours.Text & "' WHERE txtUserId = '" & txtUserId.Text & "'", conn)

                cmdUpdate.ExecuteNonQuery()
            Else

                Dim cmdInsert As New SqlCommand("INSERT INTO tUserInternal VALUES ('" & txtUserId.Text & "', '" & txtName.Text & "', '" & txtType1.Text & "', '" & txtType2.Text & "', '" & cbbWorkHours.Text & "')", conn)

                cmdInsert.ExecuteNonQuery()
            End If
        End If

        'Jika Employee Type == External
        If cbbEmployeeType.Text = "EXTERNAL" Then
            btnSubCon.Visible = True
            'Update tExternal
            Dim cmdExternal As New SqlCommand("SELECT * FROM tUserExternal WHERE userId = '" + txtUserId.Text + "'", conn)
            dReader = cmdExternal.ExecuteReader
            dReader.Read()
            If dReader.HasRows = True Then
                Dim cmdUpdate As New SqlCommand("UPDATE tUserExternal SET [name] = '" + txtName.Text + "', subcon = '" + txtType1.Text + "', project = '" & txtType2.Text & "', workHours = '" & cbbWorkHours.Text & "' WHERE userId = '" & txtUserId.Text & "'", conn)

                cmdUpdate.ExecuteNonQuery()
            Else
                Dim cmdInsert As New SqlCommand("INSERT INTO tUserExternal VALUES ('" & txtUserId.Text & "', '" & txtName.Text & "', '" & txtType1.Text & "', '" & txtType2.Text & "', '" & cbbWorkHours.Text & "')", conn)

                cmdInsert.ExecuteNonQuery()
            End If
        End If

        Dim cmdCard As New SqlCommand("SELECT * FROM tCard WHERE userId = '" & txtUserId.Text & "'", conn)

        Dim dReader3 As SqlDataReader = cmdCard.ExecuteReader
        dReader3.Read()
        If dReader3.HasRows = True Then
            Try
                Dim cmdUpdate As New SqlCommand("UPDATE tCard SET cardNumber = '" & txtCardNumber.Text & "', cardStatus = 'ACTIVE', validFrom =  @validFrom, validTo = @validTo WHERE userId = '" & txtUserId.Text & "'", conn)
                cmdUpdate.Parameters.AddWithValue("@validFrom", dtpFrom.Value)
                cmdUpdate.Parameters.AddWithValue("@validTo", dtpTo.Value)
                cmdUpdate.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error di dReader3. HasRows")
            End Try

        Else
            Try
                Dim beginDate As String = dtpFrom.Value.ToString("yyyy-MM-dd")
                Dim endDate As String = dtpTo.Value.ToString("yyyy-MM-dd")
                Dim cmdInsert As New SqlCommand("INSERT INTO tCard VALUES ('" & txtUserId.Text & "', '" & txtCardNumber.Text & "', 'ACTIVE', '" & beginDate & "',  '" & endDate & "')", conn)
                cmdInsert.ExecuteNonQuery()
                MsgBox("Successfully Updated to Database")
            Catch ex As Exception

                MsgBox("error di else")
            End Try

        End If


    End Sub
    ''' <summary>
    ''' Using Sql Transaction to Input / Update data to tCard, tDeviceUser2, tUserExternal and tUserInternal (Used by: btnSave)
    ''' </summary>
    Sub UpdateData()

        Using sqlCon As New SqlConnection(connReader)
            sqlCon.Open()
            Dim SqlTrans As SqlTransaction = sqlCon.BeginTransaction()
            Using cmd As SqlCommand = sqlCon.CreateCommand()
                cmd.Connection = sqlCon
                cmd.Transaction = SqlTrans
                Try

                    If lblImagePath.Text <> "" Then

                        MessageBox.Show(lblImagePath.Text & " is Available")
                        Dim path As String
                        Dim Client As New WebClient
                        path = Application.StartupPath & "\images\0\" & txtName.Text & "\"
                        If Not Directory.Exists(path) Then
                            Directory.CreateDirectory(path)
                            filePath = path & lblImagePath.Text
                            Client.DownloadFile(photoFileName, filePath)
                            Client.Dispose()
                        Else
                            filePath = path & lblImagePath.Text
                            Client.DownloadFile(photoFileName, filePath)
                            Client.Dispose()
                        End If
                        cmd.Parameters.Clear()
                        cmd.CommandText = "Update tDeviceUser2 SET [position] = '" & txtPosition.Text & "', [section] = '" & txtSection.Text & "',[employeeName] = '" & txtName.Text & "', cardNumber = '" & txtCardNumber.Text & "', privilege = '" & cbbPrivilege.Text & "', employeeType = '" & cbbEmployeeType.Text & "', userGroup = '" & cbbUserGroup.Text & "', updateBy = 'ME', updateDate = '" & DateTime.Now & "', updateAt = '" & Environment.MachineName & "', photoURL = '" & filePath & "',  contractStartDate = @startDate, contractEndDate = @endDate,  [status] = 'ACTIVE' WHERE userId = '" & txtUserId.Text & "'"
                        cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value)
                        cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value)
                        cmd.ExecuteNonQuery()

                    Else

                        cmd.Parameters.Clear()
                        cmd.CommandText = "Update tDeviceUser2 SET [position] = @position, [section] = @section, [employeeName] = @employeeName, cardNumber = @cardNumber, privilege = @privilege, employeeType = @employeeType, userGroup = @userGroup, updateBy = @updateBy, updateDate = @updateDate , updateAt = @updateAt, [status] = @status, contractStartDate = @startDate, contractEndDate = @endDate WHERE userId = @userId"
                        cmd.Parameters.AddWithValue("@userId", txtUserId.Text)
                        cmd.Parameters.AddWithValue("@position", txtPosition.Text)
                        cmd.Parameters.AddWithValue("@section", txtSection.Text)
                        cmd.Parameters.AddWithValue("@employeeName", txtName.Text)
                        cmd.Parameters.AddWithValue("@cardNumber", txtCardNumber.Text)
                        cmd.Parameters.AddWithValue("@privilege", cbbPrivilege.Text)
                        cmd.Parameters.AddWithValue("@employeeType", cbbEmployeeType.Text)
                        cmd.Parameters.AddWithValue("@userGroup", cbbUserGroup.Text)
                        cmd.Parameters.AddWithValue("@updateBy", _globalUserName)
                        cmd.Parameters.AddWithValue("@updateDate", DateTime.Now)
                        cmd.Parameters.AddWithValue("@updateAt", Environment.MachineName)
                        cmd.Parameters.AddWithValue("@status", "ACTIVE")
                        cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value)
                        cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value)
                        cmd.ExecuteNonQuery()

                        If cbbEmployeeType.Text = "INTERNAL" Then

                            Dim cmdInternal As New SqlCommand("SELECT * FROM tUserInternal WHERE userId = @userId", conn)
                            cmdInternal.Parameters.AddWithValue("@userId", txtUserId.Text)
                            dReader = cmdInternal.ExecuteReader
                            dReader.Read()
                            If dReader.HasRows = True Then

                                cmd.Parameters.Clear()
                                cmd.CommandText = "UPDATE tUserInternal SET [name] = '" + txtName.Text + "', position = '" + txtType1.Text + "', department = '" & txtType2.Text & "', workHours = '" & cbbWorkHours.Text & "' WHERE txtUserId = '" & txtUserId.Text & "'"
                                cmd.Parameters.AddWithValue("@name", txtName.Text)
                                cmd.Parameters.AddWithValue("@position", txtType1.Text)
                                cmd.Parameters.AddWithValue("@department", txtType2.Text)
                                cmd.Parameters.AddWithValue("@workHours", cbbWorkHours.Text)
                                cmd.Parameters.AddWithValue("@userId", txtUserId)
                                cmd.ExecuteNonQuery()

                            Else

                                cmd.Parameters.Clear()
                                cmd.CommandText = "INSERT INTO tUserInternal VALUES (@userId,@name,@position,@department,@workHours)"
                                cmd.Parameters.AddWithValue("@name", txtName.Text)
                                cmd.Parameters.AddWithValue("@position", txtType1.Text)
                                cmd.Parameters.AddWithValue("@department", txtType2.Text)
                                cmd.Parameters.AddWithValue("@workHours", cbbWorkHours.Text)
                                cmd.Parameters.AddWithValue("@userId", txtUserId)
                                cmd.ExecuteNonQuery()

                            End If

                        ElseIf cbbEmployeeType.Text = "EXTERNAL" Then

                            btnSubCon.Visible = True
                            Dim cmdExternal As New SqlCommand("SELECT * FROM tUserExternal WHERE userId = '" + txtUserId.Text + "'", conn)
                            dReader = cmdExternal.ExecuteReader
                            dReader.Read()

                            If dReader.HasRows = True Then

                                cmd.Parameters.Clear()
                                cmd.CommandText = "UPDATE tUserExternal SET [name] = @name, subcon = @subcon, project = @project, workHours = @workHours WHERE userId = @userId"
                                cmd.Parameters.AddWithValue("@userId", txtUserId.Text)
                                cmd.Parameters.AddWithValue("@name", txtName.Text)
                                cmd.Parameters.AddWithValue("@subcon", txtType1.Text)
                                cmd.Parameters.AddWithValue("@project", txtType2.Text)
                                cmd.Parameters.AddWithValue("@workHours", cbbWorkHours.Text)
                                cmd.ExecuteNonQuery()

                            Else

                                cmd.Parameters.Clear()
                                cmd.CommandText = "INSERT INTO tUserExternal VALUES (@userId, @name, @subcon, @project, @workHours)"
                                cmd.Parameters.AddWithValue("@userId", txtUserId.Text)
                                cmd.Parameters.AddWithValue("@name", txtName.Text)
                                cmd.Parameters.AddWithValue("@subcon", txtType1.Text)
                                cmd.Parameters.AddWithValue("@project", txtType2.Text)
                                cmd.Parameters.AddWithValue("@workHours", cbbWorkHours.Text)
                                cmd.ExecuteNonQuery()

                            End If
                        End If

                        Dim cmdCard As New SqlCommand("SELECT * FROM tCard WHERE userId = '" & txtUserId.Text & "'", conn)

                        Dim dReader3 As SqlDataReader = cmdCard.ExecuteReader
                        dReader3.Read()

                        If dReader3.HasRows = True Then

                            cmd.Parameters.Clear()
                            cmd.CommandText = "UPDATE tCard SET cardNumber = @cardNumber, cardStatus = @cardStatus, validFrom =  @validFrom, validTo = @validTo WHERE userId = @userId"
                            cmd.Parameters.AddWithValue("@userId", txtUserId.Text)
                            cmd.Parameters.AddWithValue("@cardNumber", txtCardNumber.Text)
                            cmd.Parameters.AddWithValue("@cardStatus", "ACTIVE")
                            cmd.Parameters.AddWithValue("@validFrom", dtpFrom.Value)
                            cmd.Parameters.AddWithValue("@validTo", dtpTo.Value)
                            cmd.ExecuteNonQuery()

                        Else

                            cmd.Parameters.Clear()
                            cmd.CommandText = "INSERT INTO tCard VALUES (@userId, @cardNumber, 'ACTIVE', @validFrom,@validTo)"
                            cmd.Parameters.AddWithValue("@userId", txtUserId.Text)
                            cmd.Parameters.AddWithValue("@cardNumber", txtCardNumber.Text)
                            cmd.Parameters.AddWithValue("@cardStatus", "ACTIVE")
                            cmd.Parameters.AddWithValue("@validFrom", dtpFrom.Value)
                            cmd.Parameters.AddWithValue("@validTo", dtpTo.Value)
                            cmd.ExecuteNonQuery()
                            MsgBox("Successfully Updated to Database")
                        End If

                    End If
                    SqlTrans.Commit()
                    MessageBox.Show("Successfully Edited!")
                Catch ex As Exception
                    SqlTrans.Rollback()
                    MsgBox(ex.Message.ToString())
                    saveError(ex.Message.ToString())
                End Try
            End Using
        End Using

    End Sub
End Class