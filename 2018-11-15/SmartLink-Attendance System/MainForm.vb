Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class MainForm
    Dim index As Integer = 0
    Private Sub btnDevice_Click(sender As Object, e As EventArgs) Handles btnDevice.Click
        Dim frmDevice As New frmDeviceManagement()

        ' open form only if is not open already 
        Dim isFormOpen As Boolean = False

        ' iterate through all open forms 
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmPersonell Then
                ' open already so just bring it to the front 
                frm.BringToFront()
                isFormOpen = True
                Exit For
            End If
        Next

        If Not isFormOpen Then
            ' not open so show it 
            frmDevice.MdiParent = Me
            frmDevice.Dock = DockStyle.Fill
            frmDevice.Show()
        Else
            frmDevice.Dispose()
        End If
    End Sub
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnDevice.Enabled = False
            btnReport.Enabled = False
            btnNotification.Enabled = False
            btnPersonell.Enabled = False
            btnMasterData.Enabled = False

            MsgBox("Welcome to Attendance System! Please Select a Device to use!")
            frmLogin.MdiParent = Me
            frmLogin.Show()
            IsMdiContainer = True
        Catch ex As Exception
            MsgBox("Error Happened When trying to show login form")
            saveError(ex.ToString())
        End Try
    End Sub
    Private Sub btnPersonnel_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim frmReporting As New frmReport()

        ' open form only if is not open already 
        Dim isFormOpen As Boolean = False

        ' iterate through all open forms 
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmPersonell Then
                ' open already so just bring it to the front 
                frm.BringToFront()
                isFormOpen = True
                Exit For
            End If
        Next

        If Not isFormOpen Then
            ' not open so show it 
            frmReporting.MdiParent = Me
            frmReporting.Dock = DockStyle.Fill
            frmReporting.Show()
        Else
            frmReporting.Dispose()
        End If
    End Sub
    Private Sub btnPersonell_Click(sender As Object, e As EventArgs) Handles btnPersonell.Click
        Dim frmPersonnel As New frmPersonell()

        ' open form only if is not open already 
        Dim isFormOpen As Boolean = False

        ' iterate through all open forms 
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmPersonell Then
                ' open already so just bring it to the front 
                frm.BringToFront()
                isFormOpen = True
                Exit For
            End If
        Next

        If Not isFormOpen Then
            ' not open so show it 
            frmPersonnel.MdiParent = Me
            frmPersonnel.Dock = DockStyle.Fill
            frmPersonnel.Show()
        Else
            frmPersonnel.Dispose()
        End If
    End Sub
    Public Function isOpened(ByVal frm As Form) As Boolean
        Dim frmCol As New FormCollection()
        frmCol = Application.OpenForms
        Dim Cnt As Integer = 0
        For Each f As Form In frmCol
            If f.Name = frm.Name Then
                Cnt += 1
            End If
        Next
        Return IIf(Cnt > 0, True, False)
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        openConnection()
        Try
            Timer1.Stop()
            MsgBox("Please Check your Notification")
            Timer1.Start()
        Catch ex As Exception
            saveError(ex.ToString())
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            openConnection()
            Dim result As Integer = MessageBox.Show("You are about to exit the application. Are you sure? ", "WARNING", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                If _globalUserId = "" Then
                    Me.Close()
                Else
                    Dim cmdstatus As New SqlCommand("UPDATE tuser SET status = 'OFFLINE' WHERE userId = '" + _globalUserId + "'", conn)
                    cmdstatus.ExecuteNonQuery()
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        saveError(ex.ToString())
        End Try
    End Sub

    Private Sub btnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        Dim frmContract As New frmEmpContract()

        ' open form only if is not open already 
        Dim isFormOpen As Boolean = False

        ' iterate through all open forms 
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmPersonell Then
                ' open already so just bring it to the front 
                frm.BringToFront()
                isFormOpen = True
                Exit For
            End If
        Next

        If Not isFormOpen Then
            ' not open so show it 
            frmContract.MdiParent = Me
            frmContract.Dock = DockStyle.Fill
            frmContract.Show()
        Else
            frmContract.Dispose()
        End If
    End Sub

    Private Sub btnMasterData_Click(sender As Object, e As EventArgs) Handles btnMasterData.Click
        Dim frmMaster As New frmMasterData()

        ' open form only if is not open already 
        Dim isFormOpen As Boolean = False

        ' iterate through all open forms 
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmPersonell Then
                ' open already so just bring it to the front 
                frm.BringToFront()
                isFormOpen = True
                Exit For
            End If
        Next

        If Not isFormOpen Then
            ' not open so show it 
            frmMaster.MdiParent = Me
            frmMaster.Dock = DockStyle.Fill
            frmMaster.Show()
        Else
            frmMaster.Dispose()
        End If
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        'mengecek apakah user sudah login atau belum
        Try
            openConnection()
            Dim command As New SqlCommand("select * from tuser where userId = @username", conn)
            command.Parameters.AddWithValue("@username", _globalUserId)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count = 1 Then
                Dim cmdstatus As New SqlCommand("UPDATE tuser SET status = 'OFFLINE' WHERE userId = '" + _globalUserId + "'", conn)

                cmdstatus.ExecuteNonQuery()
                'jika sudah
                Dim frmChild As Form
                For Each frmChild In Me.MdiChildren
                    frmChild.Close()
                Next
                MessageBox.Show("You have log out from " + _globalUserId)

                _globalUserId = ""
                btnDevice.Enabled = False
                btnReport.Enabled = False
                btnNotification.Enabled = False
                btnPersonell.Enabled = False
                btnMasterData.Enabled = False

            Else
                'jika belum
                MessageBox.Show("You haven't log in")
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to Log Out")
            saveError(ex.ToString())
        End Try

        Dim login As New frmLogin
        login.ShowDialog()
    End Sub
End Class
