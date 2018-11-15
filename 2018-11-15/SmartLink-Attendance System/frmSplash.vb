Public Class frmSplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If pbSplash.Value < 100 Then

            pbSplash.Value += 5
            If pbSplash.Value < 20 Then
                Label1.Text = "Initializing System"
            ElseIf pbSplash.Value >= 70 Then
                Label1.Text = "Finishing System"

            End If
        ElseIf pbSplash.Value = 100 Then

            Timer1.Stop()
            Me.Hide()
            MainForm.Show()

        End If


    End Sub
End Class