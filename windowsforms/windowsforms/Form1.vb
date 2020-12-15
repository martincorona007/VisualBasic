Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ArcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArcercaDeToolStripMenuItem.Click

    End Sub

    Private Sub UtilariasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtilariasToolStripMenuItem.Click

    End Sub

    Private Sub ControlDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeUsuariosToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub
End Class