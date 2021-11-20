<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarReserva
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.colIdentCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdentVuelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNomClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNacionClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPaisDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaRegreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantAcomp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombAcomp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidoAcomp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdentfAcomp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNacionAcomp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecioTiquete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCedulaCliente)
        Me.GroupBox1.Controls.Add(Me.txtCedulaAConsultar)
        Me.GroupBox1.Controls.Add(Me.btnConsultarReserva)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1226, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'dgvDatos
        '
        Me.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdentCliente, Me.colIdentVuelo, Me.colNomClient, Me.ApellClient, Me.colNacionClient, Me.colPaisDestino, Me.colFechaSalida, Me.colFechaRegreso, Me.colHoraSalida, Me.colCantDias, Me.colCantAcomp, Me.colNombAcomp, Me.colApellidoAcomp, Me.colIdentfAcomp, Me.colNacionAcomp, Me.colPrecioTiquete})
        Me.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatos.Location = New System.Drawing.Point(0, 100)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersWidth = 51
        Me.dgvDatos.RowTemplate.Height = 24
        Me.dgvDatos.Size = New System.Drawing.Size(1226, 360)
        Me.dgvDatos.TabIndex = 5
        '
        'colIdentCliente
        '
        Me.colIdentCliente.HeaderText = "Cedula Cliente"
        Me.colIdentCliente.MinimumWidth = 6
        Me.colIdentCliente.Name = "colIdentCliente"
        Me.colIdentCliente.ReadOnly = True
        Me.colIdentCliente.Width = 125
        '
        'colIdentVuelo
        '
        Me.colIdentVuelo.HeaderText = "Identificador Vuelo"
        Me.colIdentVuelo.MinimumWidth = 6
        Me.colIdentVuelo.Name = "colIdentVuelo"
        Me.colIdentVuelo.ReadOnly = True
        Me.colIdentVuelo.Width = 125
        '
        'colNomClient
        '
        Me.colNomClient.HeaderText = "Nombre Cliente"
        Me.colNomClient.MinimumWidth = 6
        Me.colNomClient.Name = "colNomClient"
        Me.colNomClient.ReadOnly = True
        Me.colNomClient.Width = 125
        '
        'ApellClient
        '
        Me.ApellClient.HeaderText = "Apellidos Cliente"
        Me.ApellClient.MinimumWidth = 6
        Me.ApellClient.Name = "ApellClient"
        Me.ApellClient.ReadOnly = True
        Me.ApellClient.Width = 125
        '
        'colNacionClient
        '
        Me.colNacionClient.HeaderText = "Nacionalidad Cliente"
        Me.colNacionClient.MinimumWidth = 6
        Me.colNacionClient.Name = "colNacionClient"
        Me.colNacionClient.ReadOnly = True
        Me.colNacionClient.Width = 125
        '
        'colPaisDestino
        '
        Me.colPaisDestino.HeaderText = "Pais Destino"
        Me.colPaisDestino.MinimumWidth = 6
        Me.colPaisDestino.Name = "colPaisDestino"
        Me.colPaisDestino.ReadOnly = True
        Me.colPaisDestino.Width = 125
        '
        'colFechaSalida
        '
        Me.colFechaSalida.HeaderText = "Fecha Salida"
        Me.colFechaSalida.MinimumWidth = 6
        Me.colFechaSalida.Name = "colFechaSalida"
        Me.colFechaSalida.ReadOnly = True
        Me.colFechaSalida.Width = 125
        '
        'colFechaRegreso
        '
        Me.colFechaRegreso.HeaderText = "Fecha Regreso"
        Me.colFechaRegreso.MinimumWidth = 6
        Me.colFechaRegreso.Name = "colFechaRegreso"
        Me.colFechaRegreso.ReadOnly = True
        Me.colFechaRegreso.Width = 125
        '
        'colHoraSalida
        '
        Me.colHoraSalida.HeaderText = "Hora Salida"
        Me.colHoraSalida.MinimumWidth = 6
        Me.colHoraSalida.Name = "colHoraSalida"
        Me.colHoraSalida.ReadOnly = True
        Me.colHoraSalida.Width = 125
        '
        'colCantDias
        '
        Me.colCantDias.HeaderText = "Cantidad Dias"
        Me.colCantDias.MinimumWidth = 6
        Me.colCantDias.Name = "colCantDias"
        Me.colCantDias.ReadOnly = True
        Me.colCantDias.Width = 125
        '
        'colCantAcomp
        '
        Me.colCantAcomp.HeaderText = "Cantidad Acompañantes"
        Me.colCantAcomp.MinimumWidth = 6
        Me.colCantAcomp.Name = "colCantAcomp"
        Me.colCantAcomp.ReadOnly = True
        Me.colCantAcomp.Width = 125
        '
        'colNombAcomp
        '
        Me.colNombAcomp.HeaderText = "Nombre Acompañante"
        Me.colNombAcomp.MinimumWidth = 6
        Me.colNombAcomp.Name = "colNombAcomp"
        Me.colNombAcomp.ReadOnly = True
        Me.colNombAcomp.Width = 125
        '
        'colApellidoAcomp
        '
        Me.colApellidoAcomp.HeaderText = "Apellido Acompañante"
        Me.colApellidoAcomp.MinimumWidth = 6
        Me.colApellidoAcomp.Name = "colApellidoAcomp"
        Me.colApellidoAcomp.ReadOnly = True
        Me.colApellidoAcomp.Width = 125
        '
        'colIdentfAcomp
        '
        Me.colIdentfAcomp.HeaderText = "Cedula Acompañante"
        Me.colIdentfAcomp.MinimumWidth = 6
        Me.colIdentfAcomp.Name = "colIdentfAcomp"
        Me.colIdentfAcomp.ReadOnly = True
        Me.colIdentfAcomp.Width = 125
        '
        'colNacionAcomp
        '
        Me.colNacionAcomp.HeaderText = "Nacionalidad Acompañante"
        Me.colNacionAcomp.MinimumWidth = 6
        Me.colNacionAcomp.Name = "colNacionAcomp"
        Me.colNacionAcomp.ReadOnly = True
        Me.colNacionAcomp.Width = 125
        '
        'colPrecioTiquete
        '
        Me.colPrecioTiquete.HeaderText = "Precio Tiquete"
        Me.colPrecioTiquete.MinimumWidth = 6
        Me.colPrecioTiquete.Name = "colPrecioTiquete"
        Me.colPrecioTiquete.ReadOnly = True
        Me.colPrecioTiquete.Width = 125
        '
        'frmConsultarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 460)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsultarReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Reserva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCedulaCliente As Label
    Friend WithEvents txtCedulaAConsultar As TextBox
    Friend WithEvents btnConsultarReserva As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents colIdentCliente As DataGridViewTextBoxColumn
    Friend WithEvents colIdentVuelo As DataGridViewTextBoxColumn
    Friend WithEvents colNomClient As DataGridViewTextBoxColumn
    Friend WithEvents ApellClient As DataGridViewTextBoxColumn
    Friend WithEvents colNacionClient As DataGridViewTextBoxColumn
    Friend WithEvents colPaisDestino As DataGridViewTextBoxColumn
    Friend WithEvents colFechaSalida As DataGridViewTextBoxColumn
    Friend WithEvents colFechaRegreso As DataGridViewTextBoxColumn
    Friend WithEvents colHoraSalida As DataGridViewTextBoxColumn
    Friend WithEvents colCantDias As DataGridViewTextBoxColumn
    Friend WithEvents colCantAcomp As DataGridViewTextBoxColumn
    Friend WithEvents colNombAcomp As DataGridViewTextBoxColumn
    Friend WithEvents colApellidoAcomp As DataGridViewTextBoxColumn
    Friend WithEvents colIdentfAcomp As DataGridViewTextBoxColumn
    Friend WithEvents colNacionAcomp As DataGridViewTextBoxColumn
    Friend WithEvents colPrecioTiquete As DataGridViewTextBoxColumn
End Class
