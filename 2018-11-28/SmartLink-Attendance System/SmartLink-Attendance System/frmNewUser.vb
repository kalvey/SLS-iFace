Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class frmNewUser
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        openConnection()
        If txtUserId.Text = "" Then
            MsgBox("User ID field is empty!")
            txtUserId.Select()
        ElseIf txtUsername.Text = "" Then
            MsgBox("Username field is empty!")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Password field is empty!")
            txtPassword.Select()
        ElseIf txtPassword.Text <> txtRePassword.Text Then
            MsgBox("Re-entered password does not match the password field")
        Else
            'dim connection As New MySqlConnection("Server=192.168.1.88;Database=In-ihis;Uid=root;password=ptgiat1899")
            Dim check As New SqlCommand("select * from tuser where userId = @user", conn)
            check.Parameters.AddWithValue("@user", txtUserId.Text)
            Dim adapter As New SqlDataAdapter(check)
            Dim table As New DataTable()
            adapter.Fill(table)
            'mengecek apakah username sudah pernah di gunakan atau belum
            If table.Rows.Count > 0 Then
                If MessageBox.Show("Did you know if " + txtUserId.Text + " already used?" + " or you want to change the password and status?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    'jika sudah pernah tapi ingin mengubah data 

                    '  Dim update As New MySqlCommand("update login set password = @password, status = @status where username=@username", connection)
                    Dim update As New SqlCommand("update tuser set password = @password where userId=@username", conn)
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

                    Dim opf As New OpenFileDialog
                    update.Parameters.AddWithValue("@password", hashValue)
                    '  update.Parameters.Add("@status", MySqlDbType.VarChar).Value = cbbStatus.Text
                    update.Parameters.AddWithValue("@username", txtUserId.Text)
                    Dim rowsAffected As Integer = update.ExecuteNonQuery()
                    MessageBox.Show("User edited successfully")

                End If
            Else
                'Try
                'menambah user baru
                'Dim command As New MySqlCommand("insert into tuser(username, password) values (@username, @password)", connection)
                Dim cmdAddUser As New SqlCommand("INSERT INTO tuser(userId, username, password, groupId,status,createdBy, createdDate, createdAt) VALUES (@userId,@username,@password,@groupId,@status,@createdBy,current_timestamp, '" & Environment.MachineName & "')", conn)

                Dim opf As New OpenFileDialog

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

                'command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text
                'command.Parameters.Add("@password", MySqlDbType.VarChar).Value = hashValue
                ''command.Parameters.Add("@status", MySqlDbType.VarChar).Value = cbbStatus.Text

                cmdAddUser.Parameters.AddWithValue("@userId", txtUserId.Text)
                cmdAddUser.Parameters.AddWithValue("@username", txtUsername.Text)
                cmdAddUser.Parameters.AddWithValue("@password", hashValue)
                cmdAddUser.Parameters.AddWithValue("@groupId", cbbUserGroup.Text)
                cmdAddUser.Parameters.AddWithValue("@status", "OFFLINE")
                cmdAddUser.Parameters.AddWithValue("@createdBy", "CALVIN")


                Dim rowsAffected As Integer = cmdAddUser.ExecuteNonQuery()
                MessageBox.Show("New user added")

                'Catch ex As Exception
                '    MsgBox(ex.ToString())
                '    MessageBox.Show("You can't add this user into database")
                '    saveError(ex.ToString)
                'End Try
            End If

        End If
    End Sub
End Class