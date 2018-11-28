Imports System.Data.Sql
Imports System.Data.SqlClient
Module connModule

    Public conn As SqlConnection
    Public dataSet As DataSet
    Public dReader As SqlDataReader
    Public adaptor As SqlDataAdapter
    Public cmd As SqlCommand
    Public ass As DataTable
    Public str, sql As String

    Sub openConnection()
        Try
            Dim str = "Data Source=192.168.1.88\SQLEXPRESS;Initial Catalog=sls_iFaceDB;Persist Security Info=True;User ID=sa;Password=ptgiat1899"
            conn = New SqlConnection(str)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("Database berhasil terkoneksi")
            End If
        Catch ex As Exception
            MsgBox("An error happened when connecting to database!")
        End Try
    End Sub
End Module
