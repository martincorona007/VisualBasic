Public Class frmAbout
    Dim second As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        second = second + 1
        If second >= 3 Then
            Timer2.Stop()
            frmPrincipalMenu.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = 1000
        Timer2.Start()
    End Sub
End Class