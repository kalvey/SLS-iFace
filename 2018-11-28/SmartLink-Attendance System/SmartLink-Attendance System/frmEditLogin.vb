Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient

Public Class frmEditLogin
    Sub showLogin()
        Try
            openConnection()
            Dim adaptor As New SqlDataAdapter(
            "

	         SELECT userId 'User ID', username 'Name', status 'Status', createdBy 'Created By',
             createdDate 'Created Date', createdAt 'Created At', updateBy 'Update By', updateDate 'Update Date',
             updateAt 'Update At' FROM tUser

            ", conn)
            Dim ds As New DataSet
            adaptor.Fill(ds, "userLogin")
            frmMasterData.dgvUserLogin.DataSource = ds.Tables("userLogin")
            ' dgvPersonell.Columns(6).Visible = False
        Catch ex As Exception
            MsgBox("Error when trying to populate userLogin DGV")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        registerUser()
    End Sub

    Sub registerUser()

        ''' <summary>
        ''' This code is used to encrpyt user password
        ''' </summary>
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

        '''<summary>
        ''' End of Encryption - hashVALUE
        ''' </summary>
        openConnection()
        Dim cmd As New SqlCommand("UPDATE tUser SET userName = @username, password = @password, updateBy = @updateBy, updateDate = @updateDate, updateAt = @updateAt WHERE userId = @userId", conn)
        cmd.Parameters.AddWithValue("@userId", txtUserID.Text)
        cmd.Parameters.AddWithValue("@userName", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", hashValue)
        cmd.Parameters.AddWithValue("@updateBy", _globalUserName)
        cmd.Parameters.AddWithValue("@updateDate", DateTime.Now)
        cmd.Parameters.AddWithValue("@updateAt", Environment.MachineName)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Edited")
        showLogin()
        Me.Close()
    End Sub
End Class