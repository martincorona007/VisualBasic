Public Class frmLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmRegister.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Ctrl_userTableAdapter.BuscarDATOSUser(Me.Numeros_MagicosDataSet.Ctrl_user, TextBox1.Text, TextBox2.Text) Then
            frmConsulta.Show()
            Me.Close()
        Else
            MsgBox("Datos incorrectos!!!")
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Numeros_MagicosDataSet.Ctrl_user' table. You can move, or remove it, as needed.
        Me.Ctrl_userTableAdapter.Fill(Me.Numeros_MagicosDataSet.Ctrl_user)
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Ctrl_userBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Ctrl_userBindingSource.CurrentChanged

    End Sub
End Class
