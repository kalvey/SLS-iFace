Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Net
Imports System.IO
Public Class frmAddUser
    Dim linkPic As String = ""
    Dim photofilename As String
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Public axCZKEM1 As New zkemkeeper.CZKEM
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateCombobox()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '    Try
        openConnection()
        Dim cmd As New SqlCommand("SELECT * from tCard WHERE cardNumber = '" & txtCardNumber.Text & "'", conn)
        Dim dReaderCMD As SqlDataReader = cmd.ExecuteReader
        dReaderCMD.Read()
        If dReaderCMD.HasRows = True Then

            If (dReaderCMD.Item("userId") <> txtUserId.Text) Then
                MsgBox("This Card Number is already assigned for another user")
            Else
                updateDatatoDevice()
                Me.Close()
            End If
        Else
            updateDatatoDevice()
            Me.Close()
        End If

        'Catch ex As Exception
        '    MsgBox("Error Happened when trying to save data")
        '    saveError(ex.ToString())
        'End Try

    End Sub
    Sub populateCombobox()
        Try
            openConnection()
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=in-ihis;Uid=root;password=ptgiat1899")
            Dim command As New SqlCommand("SELECT * FROM tGroup", conn)
            Dim myDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim table2 As New DataTable()
            myDA.Fill(table2)
            cbbUserGroup.DataSource = table2
            cbbUserGroup.ValueMember = "groupName"
            cbbUserGroup.DisplayMember = "groupName"

            conn.Close()


        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
        End Try
    End Sub

    Sub showDGVPersonell()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter("SELECT userId 'User ID', identityNo 'Identity Number', employeeNo 'Employee Number',
            employeeName 'Employee Name', cardNumber 'Card Number', privilege 'Privilege',
            contractStartDate 'Contract Start Date', contractEndDate 'Contract End Date'
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
        '    Try
        '        openConnection()
        '        Dim adaptor As New SqlDataAdapter(" SELECT * FROM tDeviceUser2
        '    ", conn)
        '        Dim ds As New DataSet
        '        adaptor.Fill(ds, "devUser")
        '        frmPersonell.dgvPersonell.DataSource = ds.Tables("devUser")
        '        frmPersonell.dgvPersonell.Columns(6).Visible = False
        '    Catch ex As Exception
        '        MsgBox("Error Happened when Trying to Populate DataGridView from Personnel Table")
        '        saveError(ex.ToString)
        '    End Try
    End Sub
    Sub updateDatatoDevice()
        'Try
        Dim iPrivilege As Integer
        If cbbEmployeeType.Text = "SUPER ADMIN" Then
            iPrivilege = "3"
        ElseIf cbbEmployeeType.Text = "NORMAL USER" Then
            iPrivilege = "0"
        End If
        bIsConnected = axCZKEM1.Connect_Net(_globalIPAddress, _globalPort)
        If bIsConnected = False Then
            MsgBox("Can't connect to this device. Please make sure the IP Address correct and the device is turned on")
        End If
        Dim idwErrorCode As Integer
        Dim benabled As Boolean = True
        Cursor = Cursors.WaitCursor
        If axCZKEM1.SSR_SetUserInfo(iMachineNumber, txtUserId.Text, txtName.Text, txtPassword.Text, iPrivilege, benabled) = True Then
            MsgBox("Successfully enroll user!", MsgBoxStyle.Information, "Success")
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default
        'Use for uploading data 
        uploadToDatabase()
        'user for Internal External Employee
        updateDatabase()
        showDGVPersonell()
        'Catch ex As Exception
        '    MsgBox("Error Happened")
        '    saveError(ex.ToString())
        'End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Dim opf As New OpenFileDialog

            'untuk menload gambar dari pc user
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If opf.ShowDialog = DialogResult.OK Then
                pbUser.BackgroundImage = Image.FromFile(opf.FileName)
                photofilename = opf.FileName
            End If


        Catch ex As Exception
            MsgBox("Error Happened when trying to populate Picture Box")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Error Happened when Trying to Close the Form")
            saveError(ex.ToString)
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
                cbbDepart.Visible = True
                txtType2.Visible = False
                cbbWorkHours.Visible = True

                lblPosition.Text = "Position"
                lblSection.Text = "Section"
                txtPosition.Visible = True
                txtSection.Visible = True

                lblSection.Visible = True
                lblPosition.Visible = True
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

                lblPosition.Text = "Position"
                lblSection.Text = "Section"
                txtPosition.Visible = True
                txtSection.Visible = True


                lblSection.Visible = True
                lblPosition.Visible = True
            Else
                'do Nothing
            End If
        Catch ex As Exception
            MsgBox("Error Happened When Executing employeeType()")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub cbbEmployeeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEmployeeType.SelectedIndexChanged
        Try
            employeeType()
        Catch ex As Exception
            MsgBox("Error on employeeType")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnSubCon_Click(sender As Object, e As EventArgs) Handles btnSubCon.Click
        frmSelectSubcon.Show()
    End Sub

    'Upload into Database 
    Sub uploadToDatabase()
        ' Try
        'Dim cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tDeviceUser WHERE userId = @enrollNumber) 
        '                                      BEGIN 
        '                                      INSERT INTO tDeviceUser(userId, name, cardNumber, privilege, password, enabled) VALUES (@enrollNumber, @sName, @sCardNumber, @iPrivilege, @sPassword, @bool)
        '                                      END", conn)
        Dim cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tDeviceUser2 WHERE userId = @enrollNumber) 
                                                  BEGIN 
                                                  INSERT INTO tDeviceUser2(userId, [employeeNo], employeeName, cardNumber, privilege, password, enabled, identityNo, telpNo, txtAddr, createBy, createDate, createAt) VALUES (@enrollNumber, @employeeNo, @employeeName , @sCardNumber, @iPrivilege, @sPassword, @bool, @identityNo, @telpNo, @address, @createBy, @createDate, @createAt)
                                                  END", conn)
        cmdGetUser.Parameters.AddWithValue("@enrollNumber", txtUserId.Text)
        cmdGetUser.Parameters.AddWithValue("@employeeNo", txtEmpNo.Text)
        cmdGetUser.Parameters.AddWithValue("@employeeName", txtName.Text)
        cmdGetUser.Parameters.AddWithValue("@sCardNumber", txtCardNumber.Text)
        If cbbPrivilege.Text = "SUPER ADMIN" Then
            cmdGetUser.Parameters.AddWithValue("@iPrivilege", "0")
        Else
            cmdGetUser.Parameters.AddWithValue("@iPrivilege", "3")
        End If

        '''''''''''
        Dim strText As String = txtPassword.Text
        Dim salt As String = "1131042761328" 'Salt Dictionary
        Dim bytHashedData As Byte()
        Dim encoder As New UTF8Encoding()
        Dim md5Hasher As New MD5CryptoServiceProvider
        Dim passwordBytes As Byte() = encoder.GetBytes(strText)
        Dim saltBytes As Byte() = encoder.GetBytes(salt)
        'Create new byte based on passwordBytes length + SaltBytes length
        Dim passwordAndSaltBytes As Byte() = New Byte(passwordBytes.Length + saltBytes.Length - 1) {}
        For i As Integer = 0 To passwordBytes.Length - 1
            passwordAndSaltBytes(i) = passwordBytes(i)
        Next
        For i As Integer = 0 To saltBytes.Length - 1
            passwordAndSaltBytes(i + passwordBytes.Length) = saltBytes(i)
        Next
        bytHashedData = md5Hasher.ComputeHash(passwordAndSaltBytes)

        Dim hashWithSaltBytes() As Byte = New Byte(bytHashedData.Length + saltBytes.Length - 1) {}

        For x As Integer = 0 To bytHashedData.Length - 1
            hashWithSaltBytes(x) = bytHashedData(x)
        Next x
        For x As Integer = 0 To saltBytes.Length - 1
            hashWithSaltBytes(bytHashedData.Length + x) = saltBytes(x)
        Next x

        Dim hashValue As String
        hashValue = Convert.ToBase64String(hashWithSaltBytes)

        '''''''''
        cmdGetUser.Parameters.AddWithValue("@sPassword", hashValue)
        cmdGetUser.Parameters.AddWithValue("@bool", "TRUE")
        cmdGetUser.Parameters.AddWithValue("@identityNo", txtKTP.Text)
        cmdGetUser.Parameters.AddWithValue("@telpNo", txtTelp.Text)
        cmdGetUser.Parameters.AddWithValue("@address", txtAddr.Text)

        cmdGetUser.Parameters.AddWithValue("@createBy", "ADMIN")
        cmdGetUser.Parameters.AddWithValue("@createDate", DateTime.Now)
        cmdGetUser.Parameters.AddWithValue("@createAt", Environment.MachineName)

        cmdGetUser.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox("Error Happened When Trying to Insert Data to Database (uploadToDatabase)")
        '    MsgBox(ex.ToString)
        'End Try
    End Sub
    Sub updateDatabase()

        'Try

        'Update tDeviceUser
        If photofilename <> "" Then
            Dim cmdUser As New SqlCommand("Update tDeviceUser2 SET [position] = '" & txtPosition.Text & "', [section] = '" & txtSection.Text & "',[employeeName] = '" & txtName.Text & "', cardNumber = '" & txtCardNumber.Text & "', privilege = '" & cbbPrivilege.Text & "', employeeType = '" & cbbEmployeeType.Text & "', userGroup = '" & cbbUserGroup.Text & "', updateBy = 'ME', updateDate = '" & DateTime.Now & "', updateAt = '" & Environment.MachineName & "', photoURL = '" & photofilename & "',  contractStartDate = @startDate, contractEndDate = @endDate, [status] = 'ACTIVE' WHERE userId = '" & txtUserId.Text & "'", conn)
            cmdUser.Parameters.AddWithValue("@startDate", dtpStartDate.Value)
                cmdUser.Parameters.AddWithValue("@endDate", dtpEndDate.Value)
                cmdUser.ExecuteNonQuery()
            Else
            Dim cmdUser As New SqlCommand("Update tDeviceUser2 SET [position] = '" & txtPosition.Text & "', [section] = '" & txtSection.Text & "',[employeeName] = '" & txtName.Text & "', cardNumber = '" & txtCardNumber.Text & "', privilege = '" & cbbPrivilege.Text & "', employeeType = '" & cbbEmployeeType.Text & "', userGroup = '" & cbbUserGroup.Text & "', updateBy = 'ME', updateDate = '" & DateTime.Now & "', updateAt = '" & Environment.MachineName & "', contractStartDate = @startDate, contractEndDate = @endDate, [status] = 'ACTIVE' WHERE userId = '" & txtUserId.Text & "'", conn)
            cmdUser.Parameters.AddWithValue("@startDate", dtpStartDate.Value)
                cmdUser.Parameters.AddWithValue("@endDate", dtpEndDate.Value)
                cmdUser.ExecuteNonQuery()
            End If

            'Jika Employee Type == Internal
            If cbbEmployeeType.Text = "INTERNAL" Then

                Dim cmdInternal As New SqlCommand("SELECT * FROM tUserInternal WHERE userId = '" + txtUserId.Text + "'", conn)
                dReader = cmdInternal.ExecuteReader
                dReader.Read()
                If dReader.HasRows = True Then
                    Dim cmdUpdate As New SqlCommand("UPDATE tUserInternal SET [name] = '" + txtName.Text + "', position = '" + txtType1.Text + "', department = '" & txtType2.Text & "', workHours = '" & cbbWorkHours.Text & "'", conn)

                    cmdUpdate.ExecuteNonQuery()
                Else
                Dim cmdInsert As New SqlCommand("INSERT INTO tUserInternal VALUES ('" & txtUserId.Text & "', '" & txtName.Text & "', '" & txtType1.Text & "', '" & txtType2.Text & "', '" & cbbWorkHours.Text & "', '" & txtType1.Text & "')", conn)

                cmdInsert.ExecuteNonQuery()
                End If
            End If

            'Jika Employee Type == External
            If cbbEmployeeType.Text = "EXTERNAL" Then
                'Update tExternal
                Dim cmdExternal As New SqlCommand("SELECT * FROM tUserExternal WHERE userId = '" + txtUserId.Text + "'", conn)
                dReader = cmdExternal.ExecuteReader
                dReader.Read()
                If dReader.HasRows = True Then
                    Dim cmdUpdate As New SqlCommand("UPDATE tUserExternal SET [name] = '" + txtName.Text + "', subcon = '" + txtType1.Text + "', project = '" & txtType2.Text & "', workHours = '" & cbbWorkHours.Text & "'", conn)

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

                Dim cmdUpdate As New SqlCommand("UPDATE tCard SET cardNumber = '" & txtCardNumber.Text & "', cardStatus = 'ACTIVE', validFrom =  '" & dtpFrom.Value.ToString("dd/MM/yyyy") & "', validTo = '" & dtpTo.Value.ToString("dd/MM/yyyy") & "' WHERE userId = '" & txtUserId.Text & "'", conn)
                cmdUpdate.ExecuteNonQuery()

            Else
                Dim cmdInsert As New SqlCommand("INSERT INTO tCard VALUES ('" & txtUserId.Text & "', '" & txtCardNumber.Text & "', 'ACTIVE', '" & dtpFrom.Value.ToString("dd/MM/yyyy") & "',  '" & dtpTo.Value.ToString("dd/MM/yyyy") & "')", conn)
                cmdInsert.ExecuteNonQuery()
            End If
            MsgBox("Successfully Updated to Database")
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub
End Class