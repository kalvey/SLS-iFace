Public Class pivotTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim days As New List(Of String)
        Dim value5 As String
        For i As Integer = 1 To System.DateTime.DaysInMonth(2018, 8)
            days.Add("[" & "2018-08-" & i & "]")
        Next

        Dim result As String = String.Join(",", days)
        MsgBox(result)
    End Sub
End Class