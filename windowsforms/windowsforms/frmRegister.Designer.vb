<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim FK_user_typeLabel As System.Windows.Forms.Label
        Dim FK_permits_typeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.Ctrl_userBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Ctrl_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Numeros_MagicosDataSet = New windowsforms.Numeros_MagicosDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Ctrl_userBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PermittypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermittypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Ctrl_userTableAdapter = New windowsforms.Numeros_MagicosDataSetTableAdapters.Ctrl_userTableAdapter()
        Me.TableAdapterManager = New windowsforms.Numeros_MagicosDataSetTableAdapters.TableAdapterManager()
        Me.NumerosMagicosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsertypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_typeTableAdapter = New windowsforms.Numeros_MagicosDataSetTableAdapters.User_typeTableAdapter()
        Me.UsertypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Permit_typeTableAdapter = New windowsforms.Numeros_MagicosDataSetTableAdapters.Permit_typeTableAdapter()
        Me.FK_user_typeTextBox = New System.Windows.Forms.TextBox()
        Me.FK_permits_typeTextBox = New System.Windows.Forms.TextBox()
        NameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        FK_user_typeLabel = New System.Windows.Forms.Label()
        FK_permits_typeLabel = New System.Windows.Forms.Label()
        CType(Me.Ctrl_userBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ctrl_userBindingNavigator.SuspendLayout()
        CType(Me.Ctrl_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numeros_MagicosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermittypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermittypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumerosMagicosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsertypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsertypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(47, 50)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(71, 25)
        NameLabel.TabIndex = 2
        NameLabel.Text = "name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(47, 102)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(110, 25)
        PasswordLabel.TabIndex = 4
        PasswordLabel.Text = "password:"
        '
        'FK_user_typeLabel
        '
        FK_user_typeLabel.AutoSize = True
        FK_user_typeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FK_user_typeLabel.Location = New System.Drawing.Point(47, 151)
        FK_user_typeLabel.Name = "FK_user_typeLabel"
        FK_user_typeLabel.Size = New System.Drawing.Size(140, 25)
        FK_user_typeLabel.TabIndex = 6
        FK_user_typeLabel.Text = "FK user type:"
        '
        'FK_permits_typeLabel
        '
        FK_permits_typeLabel.AutoSize = True
        FK_permits_typeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FK_permits_typeLabel.Location = New System.Drawing.Point(47, 197)
        FK_permits_typeLabel.Name = "FK_permits_typeLabel"
        FK_permits_typeLabel.Size = New System.Drawing.Size(168, 25)
        FK_permits_typeLabel.TabIndex = 8
        FK_permits_typeLabel.Text = "FK permits type:"
        '
        'Ctrl_userBindingNavigator
        '
        Me.Ctrl_userBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Ctrl_userBindingNavigator.BindingSource = Me.Ctrl_userBindingSource
        Me.Ctrl_userBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Ctrl_userBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Ctrl_userBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Ctrl_userBindingNavigatorSaveItem})
        Me.Ctrl_userBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Ctrl_userBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Ctrl_userBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Ctrl_userBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Ctrl_userBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Ctrl_userBindingNavigator.Name = "Ctrl_userBindingNavigator"
        Me.Ctrl_userBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Ctrl_userBindingNavigator.Size = New System.Drawing.Size(484, 25)
        Me.Ctrl_userBindingNavigator.TabIndex = 0
        Me.Ctrl_userBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Ctrl_userBindingSource
        '
        Me.Ctrl_userBindingSource.DataMember = "Ctrl_user"
        Me.Ctrl_userBindingSource.DataSource = Me.Numeros_MagicosDataSet
        '
        'Numeros_MagicosDataSet
        '
        Me.Numeros_MagicosDataSet.DataSetName = "Numeros_MagicosDataSet"
        Me.Numeros_MagicosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Ctrl_userBindingNavigatorSaveItem
        '
        Me.Ctrl_userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ctrl_userBindingNavigatorSaveItem.Image = CType(resources.GetObject("Ctrl_userBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Ctrl_userBindingNavigatorSaveItem.Name = "Ctrl_userBindingNavigatorSaveItem"
        Me.Ctrl_userBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Ctrl_userBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Ctrl_userBindingSource, "FK_user_type", True))
        Me.PictureBox1.Image = Global.windowsforms.My.Resources.Resources.p21
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(510, 403)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ctrl_userBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(149, 50)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(304, 20)
        Me.NameTextBox.TabIndex = 3
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ctrl_userBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(163, 102)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(290, 20)
        Me.PasswordTextBox.TabIndex = 5
        '
        'PermittypeBindingSource
        '
        Me.PermittypeBindingSource.DataMember = "Permit_type"
        Me.PermittypeBindingSource.DataSource = Me.Numeros_MagicosDataSet
        '
        'PermittypeBindingSource1
        '
        Me.PermittypeBindingSource1.DataMember = "Permit_type"
        Me.PermittypeBindingSource1.DataSource = Me.Numeros_MagicosDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(382, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(62, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Ctrl_userTableAdapter
        '
        Me.Ctrl_userTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Ctrl_userTableAdapter = Me.Ctrl_userTableAdapter
        Me.TableAdapterManager.InfoTableAdapter = Nothing
        Me.TableAdapterManager.NUMMAGICTableAdapter = Nothing
        Me.TableAdapterManager.Permit_typeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = windowsforms.Numeros_MagicosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_typeTableAdapter = Nothing
        '
        'NumerosMagicosDataSetBindingSource
        '
        Me.NumerosMagicosDataSetBindingSource.DataSource = Me.Numeros_MagicosDataSet
        Me.NumerosMagicosDataSetBindingSource.Position = 0
        '
        'UsertypeBindingSource
        '
        Me.UsertypeBindingSource.DataMember = "User_type"
        Me.UsertypeBindingSource.DataSource = Me.Numeros_MagicosDataSet
        '
        'User_typeTableAdapter
        '
        Me.User_typeTableAdapter.ClearBeforeFill = True
        '
        'UsertypeBindingSource1
        '
        Me.UsertypeBindingSource1.DataMember = "User_type"
        Me.UsertypeBindingSource1.DataSource = Me.Numeros_MagicosDataSet
        '
        'Permit_typeTableAdapter
        '
        Me.Permit_typeTableAdapter.ClearBeforeFill = True
        '
        'FK_user_typeTextBox
        '
        Me.FK_user_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ctrl_userBindingSource, "FK_user_type", True))
        Me.FK_user_typeTextBox.Location = New System.Drawing.Point(193, 151)
        Me.FK_user_typeTextBox.Name = "FK_user_typeTextBox"
        Me.FK_user_typeTextBox.Size = New System.Drawing.Size(260, 20)
        Me.FK_user_typeTextBox.TabIndex = 12
        '
        'FK_permits_typeTextBox
        '
        Me.FK_permits_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ctrl_userBindingSource, "FK_permits_type", True))
        Me.FK_permits_typeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FK_permits_typeTextBox.Location = New System.Drawing.Point(221, 197)
        Me.FK_permits_typeTextBox.Name = "FK_permits_typeTextBox"
        Me.FK_permits_typeTextBox.Size = New System.Drawing.Size(232, 20)
        Me.FK_permits_typeTextBox.TabIndex = 13
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 415)
        Me.Controls.Add(Me.FK_permits_typeTextBox)
        Me.Controls.Add(Me.FK_user_typeTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(FK_permits_typeLabel)
        Me.Controls.Add(FK_user_typeLabel)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ctrl_userBindingNavigator)
        Me.Name = "frmRegister"
        Me.Text = "frmRegister"
        CType(Me.Ctrl_userBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ctrl_userBindingNavigator.ResumeLayout(False)
        Me.Ctrl_userBindingNavigator.PerformLayout()
        CType(Me.Ctrl_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numeros_MagicosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermittypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermittypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumerosMagicosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Numeros_MagicosDataSet As Numeros_MagicosDataSet
    Friend WithEvents Ctrl_userBindingSource As BindingSource
    Friend WithEvents Ctrl_userTableAdapter As Numeros_MagicosDataSetTableAdapters.Ctrl_userTableAdapter
    Friend WithEvents TableAdapterManager As Numeros_MagicosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Ctrl_userBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Ctrl_userBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NumerosMagicosDataSetBindingSource As BindingSource
    Friend WithEvents UsertypeBindingSource As BindingSource
    Friend WithEvents User_typeTableAdapter As Numeros_MagicosDataSetTableAdapters.User_typeTableAdapter
    Friend WithEvents UsertypeBindingSource1 As BindingSource
    Friend WithEvents PermittypeBindingSource As BindingSource
    Friend WithEvents Permit_typeTableAdapter As Numeros_MagicosDataSetTableAdapters.Permit_typeTableAdapter
    Friend WithEvents PermittypeBindingSource1 As BindingSource
    Friend WithEvents FK_user_typeTextBox As TextBox
    Friend WithEvents FK_permits_typeTextBox As TextBox
End Class
