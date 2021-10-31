<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDestinos
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
        Me.lblIdentfVuelo = New System.Windows.Forms.Label()
        Me.lblPaisDestino = New System.Windows.Forms.Label()
        Me.cmbPaisDestino = New System.Windows.Forms.ComboBox()
        Me.lblFechaSalida = New System.Windows.Forms.Label()
        Me.dtpikFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraSalida = New System.Windows.Forms.Label()
        Me.dtpikHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.lblPrecioTiquete = New System.Windows.Forms.Label()
        Me.txtPrecioTiquete = New System.Windows.Forms.TextBox()
        Me.lblCantidadPasajeros = New System.Windows.Forms.Label()
        Me.txtEspaciosdisponibles = New System.Windows.Forms.TextBox()
        Me.txtIdentifVuelo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblIdentfVuelo
        '
        Me.lblIdentfVuelo.AutoSize = True
        Me.lblIdentfVuelo.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentfVuelo.Location = New System.Drawing.Point(26, 15)
        Me.lblIdentfVuelo.Name = "lblIdentfVuelo"
        Me.lblIdentfVuelo.Size = New System.Drawing.Size(176, 19)
        Me.lblIdentfVuelo.TabIndex = 0
        Me.lblIdentfVuelo.Text = "Identificador del Vuelo:"
        '
        'lblPaisDestino
        '
        Me.lblPaisDestino.AutoSize = True
        Me.lblPaisDestino.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisDestino.Location = New System.Drawing.Point(26, 82)
        Me.lblPaisDestino.Name = "lblPaisDestino"
        Me.lblPaisDestino.Size = New System.Drawing.Size(129, 19)
        Me.lblPaisDestino.TabIndex = 2
        Me.lblPaisDestino.Text = "Pais de Destino:"
        '
        'cmbPaisDestino
        '
        Me.cmbPaisDestino.FormattingEnabled = True
        Me.cmbPaisDestino.Location = New System.Drawing.Point(161, 79)
        Me.cmbPaisDestino.Name = "cmbPaisDestino"
        Me.cmbPaisDestino.Size = New System.Drawing.Size(202, 27)
        Me.cmbPaisDestino.TabIndex = 3
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.AutoSize = True
        Me.lblFechaSalida.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSalida.Location = New System.Drawing.Point(26, 139)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(110, 19)
        Me.lblFechaSalida.TabIndex = 4
        Me.lblFechaSalida.Text = "Fecha Salida:"
        '
        'dtpikFechaSalida
        '
        Me.dtpikFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpikFechaSalida.Location = New System.Drawing.Point(161, 133)
        Me.dtpikFechaSalida.Name = "dtpikFechaSalida"
        Me.dtpikFechaSalida.Size = New System.Drawing.Size(145, 27)
        Me.dtpikFechaSalida.TabIndex = 5
        '
        'lblHoraSalida
        '
        Me.lblHoraSalida.AutoSize = True
        Me.lblHoraSalida.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraSalida.Location = New System.Drawing.Point(26, 195)
        Me.lblHoraSalida.Name = "lblHoraSalida"
        Me.lblHoraSalida.Size = New System.Drawing.Size(99, 19)
        Me.lblHoraSalida.TabIndex = 6
        Me.lblHoraSalida.Text = "Hora Salida:"
        '
        'dtpikHoraSalida
        '
        Me.dtpikHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpikHoraSalida.Location = New System.Drawing.Point(161, 189)
        Me.dtpikHoraSalida.Name = "dtpikHoraSalida"
        Me.dtpikHoraSalida.Size = New System.Drawing.Size(88, 27)
        Me.dtpikHoraSalida.TabIndex = 7
        Me.dtpikHoraSalida.Value = New Date(2021, 10, 31, 0, 0, 0, 0)
        '
        'lblPrecioTiquete
        '
        Me.lblPrecioTiquete.AutoSize = True
        Me.lblPrecioTiquete.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTiquete.Location = New System.Drawing.Point(26, 260)
        Me.lblPrecioTiquete.Name = "lblPrecioTiquete"
        Me.lblPrecioTiquete.Size = New System.Drawing.Size(119, 19)
        Me.lblPrecioTiquete.TabIndex = 8
        Me.lblPrecioTiquete.Text = "Precio Tiquete:"
        '
        'txtPrecioTiquete
        '
        Me.txtPrecioTiquete.Location = New System.Drawing.Point(161, 257)
        Me.txtPrecioTiquete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecioTiquete.Name = "txtPrecioTiquete"
        Me.txtPrecioTiquete.ReadOnly = True
        Me.txtPrecioTiquete.Size = New System.Drawing.Size(102, 27)
        Me.txtPrecioTiquete.TabIndex = 9
        '
        'lblCantidadPasajeros
        '
        Me.lblCantidadPasajeros.AutoSize = True
        Me.lblCantidadPasajeros.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPasajeros.Location = New System.Drawing.Point(26, 327)
        Me.lblCantidadPasajeros.Name = "lblCantidadPasajeros"
        Me.lblCantidadPasajeros.Size = New System.Drawing.Size(240, 19)
        Me.lblCantidadPasajeros.TabIndex = 10
        Me.lblCantidadPasajeros.Text = "Cantidad Espacios Disponibles:"
        '
        'txtEspaciosdisponibles
        '
        Me.txtEspaciosdisponibles.Location = New System.Drawing.Point(261, 319)
        Me.txtEspaciosdisponibles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEspaciosdisponibles.Name = "txtEspaciosdisponibles"
        Me.txtEspaciosdisponibles.ReadOnly = True
        Me.txtEspaciosdisponibles.Size = New System.Drawing.Size(102, 27)
        Me.txtEspaciosdisponibles.TabIndex = 11
        '
        'txtIdentifVuelo
        '
        Me.txtIdentifVuelo.Location = New System.Drawing.Point(204, 7)
        Me.txtIdentifVuelo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdentifVuelo.Name = "txtIdentifVuelo"
        Me.txtIdentifVuelo.ReadOnly = True
        Me.txtIdentifVuelo.Size = New System.Drawing.Size(102, 27)
        Me.txtIdentifVuelo.TabIndex = 12
        '
        'frmDestinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 391)
        Me.Controls.Add(Me.txtIdentifVuelo)
        Me.Controls.Add(Me.txtEspaciosdisponibles)
        Me.Controls.Add(Me.lblCantidadPasajeros)
        Me.Controls.Add(Me.txtPrecioTiquete)
        Me.Controls.Add(Me.lblPrecioTiquete)
        Me.Controls.Add(Me.dtpikHoraSalida)
        Me.Controls.Add(Me.lblHoraSalida)
        Me.Controls.Add(Me.dtpikFechaSalida)
        Me.Controls.Add(Me.lblFechaSalida)
        Me.Controls.Add(Me.cmbPaisDestino)
        Me.Controls.Add(Me.lblPaisDestino)
        Me.Controls.Add(Me.lblIdentfVuelo)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDestinos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Destinos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdentfVuelo As Label
    Friend WithEvents lblPaisDestino As Label
    Friend WithEvents cmbPaisDestino As ComboBox
    Friend WithEvents lblFechaSalida As Label
    Friend WithEvents dtpikFechaSalida As DateTimePicker
    Friend WithEvents lblHoraSalida As Label
    Friend WithEvents dtpikHoraSalida As DateTimePicker
    Friend WithEvents lblPrecioTiquete As Label
    Friend WithEvents txtPrecioTiquete As TextBox
    Friend WithEvents lblCantidadPasajeros As Label
    Friend WithEvents txtEspaciosdisponibles As TextBox
    Friend WithEvents txtIdentifVuelo As TextBox
End Class
