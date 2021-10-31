<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReserva
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
        Me.lblCedulaCliente = New System.Windows.Forms.Label()
        Me.txtCedulaAConsultar = New System.Windows.Forms.TextBox()
        Me.btnConsultarReserva = New System.Windows.Forms.Button()
        Me.listvConsultaReserva = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCedulaCliente
        '
        Me.lblCedulaCliente.AutoSize = True
        Me.lblCedulaCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaCliente.Location = New System.Drawing.Point(15, 39)
        Me.lblCedulaCliente.Name = "lblCedulaCliente"
        Me.lblCedulaCliente.Size = New System.Drawing.Size(113, 24)
        Me.lblCedulaCliente.TabIndex = 0
        Me.lblCedulaCliente.Text = "ID del Cliente:"
        '
        'txtCedulaAConsultar
        '
        Me.txtCedulaAConsultar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaAConsultar.Location = New System.Drawing.Point(145, 39)
        Me.txtCedulaAConsultar.Name = "txtCedulaAConsultar"
        Me.txtCedulaAConsultar.Size = New System.Drawing.Size(241, 27)
        Me.txtCedulaAConsultar.TabIndex = 1
        '
        'btnConsultarReserva
        '
        Me.btnConsultarReserva.Location = New System.Drawing.Point(423, 40)
        Me.btnConsultarReserva.Name = "btnConsultarReserva"
        Me.btnConsultarReserva.Size = New System.Drawing.Size(184, 27)
        Me.btnConsultarReserva.TabIndex = 2
        Me.btnConsultarReserva.Text = "Consultar Reserva"
        Me.btnConsultarReserva.UseVisualStyleBackColor = True
        '
        'listvConsultaReserva
        '
        Me.listvConsultaReserva.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listvConsultaReserva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listvConsultaReserva.HideSelection = False
        Me.listvConsultaReserva.Location = New System.Drawing.Point(0, 0)
        Me.listvConsultaReserva.Name = "listvConsultaReserva"
        Me.listvConsultaReserva.Size = New System.Drawing.Size(695, 262)
        Me.listvConsultaReserva.TabIndex = 3
        Me.listvConsultaReserva.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCedulaCliente)
        Me.GroupBox1.Controls.Add(Me.txtCedulaAConsultar)
        Me.GroupBox1.Controls.Add(Me.btnConsultarReserva)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'frmReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.listvConsultaReserva)
        Me.Name = "frmReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Reserva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCedulaCliente As Label
    Friend WithEvents txtCedulaAConsultar As TextBox
    Friend WithEvents btnConsultarReserva As Button
    Friend WithEvents listvConsultaReserva As ListView
    Friend WithEvents GroupBox1 As GroupBox
End Class
