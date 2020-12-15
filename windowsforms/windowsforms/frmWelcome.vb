Public Class frmWelcome
    Dim second As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second = second + 1
        If second >= 4 Then
            Timer1.Stop()
            frmPrincipalMenu.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
End Class