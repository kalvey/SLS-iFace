Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub
    Sub Login()
        Try
            openConnection()
            'mengecek apakah username dan password sudah benar

            '''''Starting Hash
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

            '''''Ending Hash
            Dim command As New SqlCommand("select * from tuser where userId = @username and password = @password", conn)
            command.Parameters.AddWithValue("@username", txtUsername.Text)
            command.Parameters.AddWithValue("@password", hashValue)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            '    Try
            adapter.Fill(table)
            If table.Rows.Count <= 0 Then
                'jika salah
                MessageBox.Show("Username Or Password Are Invalid")
            ElseIf table.Rows(0).Item(5) = "ONLINE" Then
                MessageBox.Show("This user is already Online!")
                Dim cmdStatus As New SqlCommand("UPDATE tuser SET status = 'OFFLINE', lastLogin = current_timestamp WHERE userId = '" & txtUsername.Text & "'", conn)
                cmdStatus.ExecuteNonQuery()
                MainForm.btnPersonell.Enabled = True
                MainForm.btnReport.Enabled = True
                MainForm.btnNotification.Enabled = True
                MainForm.btnDevice.Enabled = True
                MainForm.btnMasterData.Enabled = True

            Else
                'jika benar
                MessageBox.Show("Login Successfully")
                _globalUserId = table.Rows(0).Item(0)
                _globalUserName = table.Rows(0).Item(1)
                frmSelectDevice.MdiParent = MainForm
                frmSelectDevice.Show()
                Me.Close()

                Dim cmdStatus As New SqlCommand("UPDATE tuser SET status = 'ONLINE', lastLogin = current_timestamp WHERE userId = '" + _globalUserId + "'", conn)
                cmdStatus.ExecuteNonQuery()
                MainForm.btnPersonell.Enabled = True
                MainForm.btnReport.Enabled = True
                MainForm.btnNotification.Enabled = True
                MainForm.btnDevice.Enabled = True
                MainForm.btnMasterData.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            MessageBox.Show("You didn't connect our database")
            saveError(ex.ToString())
        End Try
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Call Login()
            End If
        Catch ex As Exception
            MsgBox("Error When Trying to Login")
            saveError(ex.ToString())
        End Try
    End Sub
End Class