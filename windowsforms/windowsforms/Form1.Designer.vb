<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UtilariasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilariasToolStripMenuItem, Me.SalirToolStripMenuItem, Me.ArcercaDeToolStripMenuItem, Me.ControlDeUsuariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UtilariasToolStripMenuItem
        '
        Me.UtilariasToolStripMenuItem.Name = "UtilariasToolStripMenuItem"
        Me.UtilariasToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.UtilariasToolStripMenuItem.Text = "utilarias"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ArcercaDeToolStripMenuItem
        '
        Me.ArcercaDeToolStripMenuItem.Name = "ArcercaDeToolStripMenuItem"
        Me.ArcercaDeToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ArcercaDeToolStripMenuItem.Text = "Arcerca de"
        '
        'ControlDeUsuariosToolStripMenuItem
        '
        Me.ControlDeUsuariosToolStripMenuItem.Name = "ControlDeUsuariosToolStripMenuItem"
        Me.ControlDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.ControlDeUsuariosToolStripMenuItem.Text = "control de usuarios"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UtilariasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeUsuariosToolStripMenuItem As ToolStripMenuItem
End Class
