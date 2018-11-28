Imports System.Data.SqlClient
Module clFunction
    Public Function saveError(ByVal text As String)
        openConnection()
        'Dim cmd As New SqlCommand("INSERT INTO terrorlog VALUES ('SLS-iFace','" + text + "','" + _globalUserId + "','" & DateTime.Now & "', '" & Environment.MachineName & "')", conn)
        'cmd.ExecuteNonQuery()
    End Function
End Module
