Public Class Login

    Dim conteo As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cadena As String
        If TextBox1.Text = "" Then
            MsgBox("Campo Vacio")
            TextBox1.Focus()
        Else
            Cadena = Encriptar(TextBox1.Text, "1234")
            MsgBox("Cadena original " & TextBox1.Text)
            MsgBox("Cadena Encriptada" & Cadena)
            MsgBox("Cadena Desencriptada" & DesEncriptar(Cadena, "1234"))
        End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub


End Class