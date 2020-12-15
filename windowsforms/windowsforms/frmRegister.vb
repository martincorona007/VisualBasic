Public Class frmRegister
    Private Sub Register_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Ctrl_userBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Ctrl_userBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Ctrl_userBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Numeros_MagicosDataSet)

    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Numeros_MagicosDataSet.Permit_type' table. You can move, or remove it, as needed.
        Me.Permit_typeTableAdapter.Fill(Me.Numeros_MagicosDataSet.Permit_type)
        'TODO: This line of code loads data into the 'Numeros_MagicosDataSet.User_type' table. You can move, or remove it, as needed.
        Me.User_typeTableAdapter.Fill(Me.Numeros_MagicosDataSet.User_type)
        'TODO: This line of code loads data into the 'Numeros_MagicosDataSet.Ctrl_user' table. You can move, or remove it, as needed.
        Me.Ctrl_userTableAdapter.Fill(Me.Numeros_MagicosDataSet.Ctrl_user)
        Me.Ctrl_userBindingSource.AddNew()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Ctrl_userTableAdapter.Insert(CType(NameTextBox.Text, String), CType(PasswordTextBox.Text, String), CType(FK_user_typeTextBox.Text, String), CType(FK_permits_typeTextBox.Text, String))

        'TODO: This line of code loads data into the 'Numeros_MagicosDataSet.Ctrl_user' table. You can move, or remove it, as needed.
        Me.Ctrl_userTableAdapter.Fill(Me.Numeros_MagicosDataSet.Ctrl_user)
        MsgBox("Registro exitoso")

        NameTextBox.Text = ""
        PasswordTextBox.Text = ""
        FK_user_typeTextBox.Text = ""
        FK_permits_typeTextBox.Text = ""
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmLogin.Show()
        Me.Close()

    End Sub


End Class