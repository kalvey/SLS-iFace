Public Class splashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        pbSplash.Value = pbSplash.Value + 1

        If pbSplash.Value = "100" Then
            Timer1.Stop()

        End If

    End Sub

    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class