Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Numeros_MagicosDataSet1.Ctrl_user' table. You can move, or remove it, as needed.
        Me.Ctrl_userTableAdapter.Fill(Me.Numeros_MagicosDataSet1.Ctrl_user)
        'TODO: This line of code loads data into the 'Numeros_MagicosDataSet1.Permit_type' table. You can move, or remove it, as needed.
        Me.Permit_typeTableAdapter.Fill(Me.Numeros_MagicosDataSet1.Permit_type)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub
End Class