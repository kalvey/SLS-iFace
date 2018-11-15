Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports System.Security.Cryptography

Public Class frmBatchPS

    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet

    '  Dim conns As New SqlConnection("Data Source=192.168.1.88\SQLEXPRESS;Initial Catalog=sls_iFaceDB;Persist Security Info=True;User ID=sa;Password=ptgiat1899;multipleactiveresultsets=true")
    Dim conns As New SqlConnection(str)
    Dim photofilename As String
    Dim serial, firmware, model As String
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
    Public axCZKEM1 As New zkemkeeper.CZKEM

    Dim cmd As OleDbCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For j As Integer = 0 To dgvBatch.Columns.Count - 1
            MsgBox("Rows Number: " & j & dgvBatch.Rows(0).Cells(j).Value.ToString())
        Next
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        Dim path As String = OpenFileDialog1.FileName
        Me.TextBox1.Text = path.ToString

        '  Try
        Me.dgvBatch.DataSource = Nothing
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & Me.TextBox1.Text & "';Extended Properties=Excel 8.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
        MyCommand.TableMappings.Add("Table", "Net-informations.com")
        Dim DtSet = New System.Data.DataTable
        MyCommand.Fill(DtSet)
        Me.dgvBatch.DataSource = DtSet

        MyConnection.Close()

        MessageBox.Show("File successfully imported")

        'Catch ex As Exception
        '    MessageBox.Show("Error")
        'End Try
    End Sub
    'Sub updateDB()
    '    Dim index As Integer = dgvBatch.CurrentCell.RowIndex
    '    '         Sub uploadToDatabase()
    '    ' Try
    '    'Dim cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tDeviceUser WHERE userId = @enrollNumber) 
    '    '                                      BEGIN 
    '    '                                      INSERT INTO tDeviceUser(userId, name, cardNumber, privilege, password, enabled) VALUES (@enrollNumber, @sName, @sCardNumber, @iPrivilege, @sPassword, @bool)
    '    '                                      END", conn)
    '    Dim cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tDeviceUser2 WHERE userId = @enrollNumber) 
    '                                              BEGIN 
    '                                              INSERT INTO tDeviceUser2(userId, [employeeNo], employeeName, cardNumber, privilege, password, enabled, identityNo, telpNo, txtAddr, createBy, createDate, createAt) VALUES (@enrollNumber, @employeeNo, @employeeName , @sCardNumber, @iPrivilege, @sPassword, @bool, @identityNo, @telpNo, @address, @createBy, @createDate, @createAt)
    '                                              END", conns)
    '    cmdGetUser.Parameters.AddWithValue("@enrollNumber", dgvBatch.Rows(index).Cells(0).Value)
    '    cmdGetUser.Parameters.AddWithValue("@employeeNo", dgvBatch.Rows(index).Cells(1).Value)
    '    cmdGetUser.Parameters.AddWithValue("@employeeName", dgvBatch.Rows(index).Cells(2).Value)
    '    cmdGetUser.Parameters.AddWithValue("@sCardNumber", txtCardNumber.Text)
    '    If cbbPrivilege.Text = "SUPER ADMIN" Then
    '        cmdGetUser.Parameters.AddWithValue("@iPrivilege", "0")
    '    Else
    '        cmdGetUser.Parameters.AddWithValue("@iPrivilege", "3")
    '    End If

    '    '''''''''''
    '    Dim strText As String = txtPassword.Text
    '    Dim salt As String = "1131042761328" 'Salt Dictionary
    '    Dim bytHashedData As Byte()
    '    Dim encoder As New UTF8Encoding()
    '    Dim md5Hasher As New MD5CryptoServiceProvider
    '    Dim passwordBytes As Byte() = encoder.GetBytes(strText)
    '    Dim saltBytes As Byte() = encoder.GetBytes(salt)
    '    'Create new byte based on passwordBytes length + SaltBytes length
    '    Dim passwordAndSaltBytes As Byte() = New Byte(passwordBytes.Length + saltBytes.Length - 1) {}
    '    For i As Integer = 0 To passwordBytes.Length - 1
    '        passwordAndSaltBytes(i) = passwordBytes(i)
    '    Next
    '    For i As Integer = 0 To saltBytes.Length - 1
    '        passwordAndSaltBytes(i + passwordBytes.Length) = saltBytes(i)
    '    Next
    '    bytHashedData = md5Hasher.ComputeHash(passwordAndSaltBytes)

    '    Dim hashWithSaltBytes() As Byte = New Byte(bytHashedData.Length + saltBytes.Length - 1) {}

    '    For x As Integer = 0 To bytHashedData.Length - 1
    '        hashWithSaltBytes(x) = bytHashedData(x)
    '    Next x
    '    For x As Integer = 0 To saltBytes.Length - 1
    '        hashWithSaltBytes(bytHashedData.Length + x) = saltBytes(x)
    '    Next x

    '    Dim hashValue As String
    '    hashValue = Convert.ToBase64String(hashWithSaltBytes)

    '    '''''''''
    '    cmdGetUser.Parameters.AddWithValue("@sPassword", hashValue)
    '    cmdGetUser.Parameters.AddWithValue("@bool", "TRUE")
    '    cmdGetUser.Parameters.AddWithValue("@identityNo", txtKTP.Text)
    '    cmdGetUser.Parameters.AddWithValue("@telpNo", txtTelp.Text)
    '    cmdGetUser.Parameters.AddWithValue("@address", txtAddr.Text)

    '    cmdGetUser.Parameters.AddWithValue("@createBy", "ADMIN")
    '    cmdGetUser.Parameters.AddWithValue("@createDate", DateTime.Now)
    '    cmdGetUser.Parameters.AddWithValue("@createAt", Environment.MachineName)

    '    cmdGetUser.ExecuteNonQuery()
    '    'Catch ex As Exception
    '    '    MsgBox("Error Happened When Trying to Insert Data to Database (uploadToDatabase)")
    '    '    MsgBox(ex.ToString)
    '    'End Try
    'End Sub
    'Sub updateDatabase()
    '    openConnection()
    '    ' Try
    '    'Dim cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tDeviceUser WHERE userId = @enrollNumber) 
    '    '                                      BEGIN 
    '    '                                      INSERT INTO tDeviceUser(userId, name, cardNumber, privilege, password, enabled) VALUES (@enrollNumber, @sName, @sCardNumber, @iPrivilege, @sPassword, @bool)
    '    '                                      END", conn)
    '    Dim cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tDeviceUser2 WHERE userId = @enrollNumber) 
    '                                              BEGIN 
    '                                              INSERT INTO tDeviceUser2(userId, [employeeNo], employeeName, cardNumber, privilege, password, enabled, identityNo, telpNo, txtAddr, createBy, createDate, createAt) VALUES (@enrollNumber, @employeeNo, @employeeName , @sCardNumber, @iPrivilege, @sPassword, @bool, @identityNo, @telpNo, @address, @createBy, @createDate, @createAt)
    '                                              END", conn)
    '    cmdGetUser.Parameters.AddWithValue("@enrollNumber", txtUserId.Text)
    '    cmdGetUser.Parameters.AddWithValue("@employeeNo", txtEmpNo.Text)
    '    cmdGetUser.Parameters.AddWithValue("@employeeName", txtName.Text)
    '    cmdGetUser.Parameters.AddWithValue("@sCardNumber", txtCardNumber.Text)

    '    '''''''''''
    '    Dim strText As String = txtPassword.Text
    '    Dim salt As String = "1131042761328" 'Salt Dictionary
    '    Dim bytHashedData As Byte()
    '    Dim encoder As New UTF8Encoding()
    '    Dim md5Hasher As New MD5CryptoServiceProvider
    '    Dim passwordBytes As Byte() = encoder.GetBytes(strText)
    '    Dim saltBytes As Byte() = encoder.GetBytes(salt)
    '    'Create new byte based on passwordBytes length + SaltBytes length
    '    Dim passwordAndSaltBytes As Byte() = New Byte(passwordBytes.Length + saltBytes.Length - 1) {}
    '    For i As Integer = 0 To passwordBytes.Length - 1
    '        passwordAndSaltBytes(i) = passwordBytes(i)
    '    Next
    '    For i As Integer = 0 To saltBytes.Length - 1
    '        passwordAndSaltBytes(i + passwordBytes.Length) = saltBytes(i)
    '    Next
    '    bytHashedData = md5Hasher.ComputeHash(passwordAndSaltBytes)

    '    Dim hashWithSaltBytes() As Byte = New Byte(bytHashedData.Length + saltBytes.Length - 1) {}

    '    For x As Integer = 0 To bytHashedData.Length - 1
    '        hashWithSaltBytes(x) = bytHashedData(x)
    '    Next x
    '    For x As Integer = 0 To saltBytes.Length - 1
    '        hashWithSaltBytes(bytHashedData.Length + x) = saltBytes(x)
    '    Next x

    '    Dim hashValue As String
    '    hashValue = Convert.ToBase64String(hashWithSaltBytes)

    '    '''''''''
    '    cmdGetUser.Parameters.AddWithValue("@sPassword", hashValue)
    '    cmdGetUser.Parameters.AddWithValue("@bool", "TRUE")
    '    cmdGetUser.Parameters.AddWithValue("@identityNo", txtKTP.Text)
    '    cmdGetUser.Parameters.AddWithValue("@telpNo", txtTelp.Text)
    '    cmdGetUser.Parameters.AddWithValue("@address", txtAddr.Text)

    '    cmdGetUser.Parameters.AddWithValue("@createBy", "ADMIN")
    '    cmdGetUser.Parameters.AddWithValue("@createDate", DateTime.Now)
    '    cmdGetUser.Parameters.AddWithValue("@createAt", Environment.MachineName)

    '    cmdGetUser.ExecuteNonQuery()
    '    'Catch ex As Exception
    '    '    MsgBox("Error Happened When Trying to Insert Data to Database (uploadToDatabase)")
    '    '    MsgBox(ex.ToString)
    '    'End Try
    'End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        For iRows As Integer = 0 To dgvBatch.Rows.Count - 1

            Dim iPrivilege As Integer = 0
            Dim index As Integer = dgvBatch.CurrentCell.RowIndex
            bIsConnected = axCZKEM1.Connect_Net("192.168.1.202", "4370")
            If bIsConnected = False Then
                MsgBox("Can't connect to this device. Please make sure the IP Address correct and the device is turned on")
            End If
            Dim idwErrorCode As Integer
            Dim benabled As Boolean = True
            Cursor = Cursors.WaitCursor
            If axCZKEM1.SSR_SetUserInfo(iMachineNumber, dgvBatch.Rows(iRows).Cells(1).Value.ToString, dgvBatch.Rows(iRows).Cells(3).Value.ToString(), "00000", iPrivilege, benabled) = True Then
                '     MsgBox("Successfully enroll user!", MsgBoxStyle.Information, "Success")
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If


            openConnection()
            conns.Close()
            conns.Open()
            Dim cmdGetUser As New SqlCommand("IF NOT EXISTS(SELECT * FROM tDeviceUser2 WHERE userId = @enrollNumber) 
                                                  BEGIN 
                                                  INSERT INTO tDeviceUser2(userId, [employeeNo], employeeName, cardNumber, position, departmentName ,section) VALUES (@enrollNumber,@employeeNo,@employeeName,@sCardNumber,@position,@departmentName,@section)
                                                  END", conns)
            cmdGetUser.Parameters.AddWithValue("@enrollNumber", dgvBatch.Rows(iRows).Cells(1).Value.ToString)
            cmdGetUser.Parameters.AddWithValue("@employeeNo", dgvBatch.Rows(iRows).Cells(2).Value.ToString)
            cmdGetUser.Parameters.AddWithValue("@employeeName", dgvBatch.Rows(iRows).Cells(3).Value.ToString)


            If dgvBatch.Rows(iRows).Cells(0).Value.ToString = "" Or dgvBatch.Rows(iRows).Cells(0).Value.ToString = "0" Then
                cmdGetUser.Parameters.AddWithValue("@sCardNumber", "0")
            Else
                cmdGetUser.Parameters.AddWithValue("@sCardNumber", dgvBatch.Rows(iRows).Cells(0).Value.ToString)
            End If
            cmdGetUser.Parameters.AddWithValue("@position", dgvBatch.Rows(iRows).Cells(6).Value.ToString)
            cmdGetUser.Parameters.AddWithValue("@departmentName", dgvBatch.Rows(iRows).Cells(4).Value.ToString)
            cmdGetUser.Parameters.AddWithValue("@section", dgvBatch.Rows(iRows).Cells(5).Value.ToString)
            cmdGetUser.ExecuteNonQuery()


            Dim sCardnumber As String = dgvBatch.Rows(iRows).Cells(0).Value.ToString


            Cursor = Cursors.WaitCursor
            axCZKEM1.EnableDevice(iMachineNumber, False)
            axCZKEM1.SetStrCardNumber(sCardnumber) 'Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
            If axCZKEM1.SSR_SetUserInfo(iMachineNumber, dgvBatch.Rows(iRows).Cells(1).Value.ToString, dgvBatch.Rows(iRows).Cells(3).Value.ToString, 0, iPrivilege, benabled) = True Then 'upload the user's information(card number included)


                Dim cmd As New SqlCommand("UPDATE tDeviceUser2 set [CardNumber] = @cardNumber, [privilege] = @privilege, [enabled] = @enabled WHERE [userId] = '" & dgvBatch.Rows(iRows).Cells(1).Value & "'", conns)

                cmd.Parameters.Add("@cardNumber", sCardnumber)
                cmd.Parameters.Add("@privilege", "0")
                cmd.Parameters.Add("@enabled", "TRUE")
                cmd.ExecuteNonQuery()
                '        MsgBox("sucessfully Updated")

                Dim cmdCN As New SqlCommand("INSERT INTO tCard(userId, cardNumber) VALUES ('" & dgvBatch.Rows(iRows).Cells(1).Value.ToString() & "', '" & sCardnumber & "')", conns)
                cmdCN.ExecuteNonQuery()
                '            MsgBox("SetUserInfo,UserID:" + sdwEnrollNumber.ToString() + " Privilege:" + iPrivilege.ToString() + " Cardnumber:" + sCardnumber + " Enabled:" + benabled.ToString(), MsgBoxStyle.Information, "Success")
            Else
                axCZKEM1.GetLastError(idwErrorCode)
                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
            End If
            axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
            axCZKEM1.EnableDevice(iMachineNumber, True)
            Cursor = Cursors.Default


        Next
        MsgBox("Successfully Enroll User")
        'Try

        Cursor = Cursors.Default
        ''Use for uploading data 
        'uploadToDatabase()
        ''user for Internal External Employee
        'updateDatabase()
        'showDGVPersonell()
        ''Catch ex As Exception
        ''    MsgBox("Error Happened")
        ''    saveError(ex.ToString())
        ''End Try
    End Sub
End Class