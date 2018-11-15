Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.config
Imports System.Configuration
Module connModule

    Public conn As SqlConnection
    Public dataSet As DataSet
    Public dReader As SqlDataReader
    Public adaptor As SqlDataAdapter
    Public cmd As SqlCommand
    Public ass As DataTable
    Public str, sql As String
    Public _globalIPAddress As String
    Public _globalPort As String
    Public _globalUserId As String
    Public _globalUserName As String
    Public connReader As String

    Public Sub openConnection()
        Try

            connReader = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/connString.txt")
            str = connReader
            ' str = "Data Source=DESKTOP-R5E7QB7;Initial Catalog=sls_iFaceDB;Integrated Security=True;multipleactiveresultsets=true"
            '   str = ConfigurationManager.AppSettings("ConString").ToString()
            conn = New SqlConnection(str)

            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            saveError(ex.ToString())
            End
        End Try
    End Sub
End Module
