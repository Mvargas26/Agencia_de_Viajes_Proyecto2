<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuPantallaPrincipal = New System.Windows.Forms.MenuStrip()
        Me.DestinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPantallaPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPantallaPrincipal
        '
        Me.MenuPantallaPrincipal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPantallaPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuPantallaPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DestinoToolStripMenuItem, Me.ReservasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuPantallaPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPantallaPrincipal.Name = "MenuPantallaPrincipal"
        Me.MenuPantallaPrincipal.Size = New System.Drawing.Size(1165, 31)
        Me.MenuPantallaPrincipal.TabIndex = 1
        Me.MenuPantallaPrincipal.Text = "MenuStrip1"
        '
        'DestinoToolStripMenuItem
        '
        Me.DestinoToolStripMenuItem.Name = "DestinoToolStripMenuItem"
        Me.DestinoToolStripMenuItem.Size = New System.Drawing.Size(184, 27)
        Me.DestinoToolStripMenuItem.Text = "Reservar un Vuelo"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(186, 27)
        Me.ReservasToolStripMenuItem.Text = "Consultar Reserva"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(163, 27)
        Me.ComprasToolStripMenuItem.Text = "Comprar Boleto"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(114, 27)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(63, 27)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 884)
        Me.Controls.Add(Me.MenuPantallaPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuPantallaPrincipal
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Menu Viajando y conociendo"
        Me.MenuPantallaPrincipal.ResumeLayout(False)
        Me.MenuPantallaPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuPantallaPrincipal As MenuStrip
    Friend WithEvents DestinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
