<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservaVuelo
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
        Me.lblHoraSalida = New System.Windows.Forms.Label()
        Me.dtpikHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.lblPrecioTiquete = New System.Windows.Forms.Label()
        Me.txtPrecioTiquete = New System.Windows.Forms.TextBox()
        Me.txtIdentifVuelo = New System.Windows.Forms.TextBox()
        Me.btnReserva = New System.Windows.Forms.Button()
        Me.grpDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.txtCantidadAcompanantes = New System.Windows.Forms.TextBox()
        Me.lblCantAcompanantes = New System.Windows.Forms.Label()
        Me.txtCantidadDias = New System.Windows.Forms.TextBox()
        Me.lblCantDias = New System.Windows.Forms.Label()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaSalida = New System.Windows.Forms.Label()
        Me.dtpikFechaRegreso = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaRegreso = New System.Windows.Forms.Label()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtZonaPrefe = New System.Windows.Forms.TextBox()
        Me.chkZonaPrefe = New System.Windows.Forms.CheckBox()
        Me.chkZonaExLegrom = New System.Windows.Forms.CheckBox()
        Me.chkInternetIlim = New System.Windows.Forms.CheckBox()
        Me.chkFastTrack = New System.Windows.Forms.CheckBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.txtEspaciosDisponibles = New System.Windows.Forms.TextBox()
        Me.lblEspaciosDisponibles = New System.Windows.Forms.Label()
        Me.grpDatosPersonales.SuspendLayout()
        Me.grpExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIdentfVuelo
        '
        Me.lblIdentfVuelo.AutoSize = True
        Me.lblIdentfVuelo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentfVuelo.Location = New System.Drawing.Point(600, 34)
        Me.lblIdentfVuelo.Name = "lblIdentfVuelo"
        Me.lblIdentfVuelo.Size = New System.Drawing.Size(210, 23)
        Me.lblIdentfVuelo.TabIndex = 0
        Me.lblIdentfVuelo.Text = "Identificador del Vuelo:"
        '
        'lblPaisDestino
        '
        Me.lblPaisDestino.AutoSize = True
        Me.lblPaisDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisDestino.Location = New System.Drawing.Point(19, 237)
        Me.lblPaisDestino.Name = "lblPaisDestino"
        Me.lblPaisDestino.Size = New System.Drawing.Size(154, 23)
        Me.lblPaisDestino.TabIndex = 2
        Me.lblPaisDestino.Text = "Pais de Destino:"
        '
        'cmbPaisDestino
        '
        Me.cmbPaisDestino.FormattingEnabled = True
        Me.cmbPaisDestino.Items.AddRange(New Object() {"U.S.A", "Brasil", "México"})
        Me.cmbPaisDestino.Location = New System.Drawing.Point(184, 234)
        Me.cmbPaisDestino.Name = "cmbPaisDestino"
        Me.cmbPaisDestino.Size = New System.Drawing.Size(202, 29)
        Me.cmbPaisDestino.TabIndex = 3
        '
        'lblHoraSalida
        '
        Me.lblHoraSalida.AutoSize = True
        Me.lblHoraSalida.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraSalida.Location = New System.Drawing.Point(19, 395)
        Me.lblHoraSalida.Name = "lblHoraSalida"
        Me.lblHoraSalida.Size = New System.Drawing.Size(118, 23)
        Me.lblHoraSalida.TabIndex = 6
        Me.lblHoraSalida.Text = "Hora Salida:"
        '
        'dtpikHoraSalida
        '
        Me.dtpikHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpikHoraSalida.Location = New System.Drawing.Point(315, 395)
        Me.dtpikHoraSalida.Name = "dtpikHoraSalida"
        Me.dtpikHoraSalida.Size = New System.Drawing.Size(71, 28)
        Me.dtpikHoraSalida.TabIndex = 7
        Me.dtpikHoraSalida.Value = New Date(2021, 10, 31, 0, 0, 0, 0)
        '
        'lblPrecioTiquete
        '
        Me.lblPrecioTiquete.AutoSize = True
        Me.lblPrecioTiquete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTiquete.Location = New System.Drawing.Point(192, 873)
        Me.lblPrecioTiquete.Name = "lblPrecioTiquete"
        Me.lblPrecioTiquete.Size = New System.Drawing.Size(142, 23)
        Me.lblPrecioTiquete.TabIndex = 8
        Me.lblPrecioTiquete.Text = "Precio Tiquete:"
        '
        'txtPrecioTiquete
        '
        Me.txtPrecioTiquete.Location = New System.Drawing.Point(340, 869)
        Me.txtPrecioTiquete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecioTiquete.Name = "txtPrecioTiquete"
        Me.txtPrecioTiquete.ReadOnly = True
        Me.txtPrecioTiquete.Size = New System.Drawing.Size(102, 27)
        Me.txtPrecioTiquete.TabIndex = 9
        '
        'txtIdentifVuelo
        '
        Me.txtIdentifVuelo.Location = New System.Drawing.Point(674, 69)
        Me.txtIdentifVuelo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdentifVuelo.Name = "txtIdentifVuelo"
        Me.txtIdentifVuelo.ReadOnly = True
        Me.txtIdentifVuelo.Size = New System.Drawing.Size(102, 27)
        Me.txtIdentifVuelo.TabIndex = 12
        '
        'btnReserva
        '
        Me.btnReserva.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserva.Location = New System.Drawing.Point(241, 924)
        Me.btnReserva.Name = "btnReserva"
        Me.btnReserva.Size = New System.Drawing.Size(229, 39)
        Me.btnReserva.TabIndex = 13
        Me.btnReserva.Text = "Realizar Reserva"
        Me.btnReserva.UseVisualStyleBackColor = True
        '
        'grpDatosPersonales
        '
        Me.grpDatosPersonales.Controls.Add(Me.txtCantidadAcompanantes)
        Me.grpDatosPersonales.Controls.Add(Me.lblCantAcompanantes)
        Me.grpDatosPersonales.Controls.Add(Me.txtCantidadDias)
        Me.grpDatosPersonales.Controls.Add(Me.lblCantDias)
        Me.grpDatosPersonales.Controls.Add(Me.dtpFechaSalida)
        Me.grpDatosPersonales.Controls.Add(Me.lblFechaSalida)
        Me.grpDatosPersonales.Controls.Add(Me.dtpikHoraSalida)
        Me.grpDatosPersonales.Controls.Add(Me.lblHoraSalida)
        Me.grpDatosPersonales.Controls.Add(Me.cmbPaisDestino)
        Me.grpDatosPersonales.Controls.Add(Me.dtpikFechaRegreso)
        Me.grpDatosPersonales.Controls.Add(Me.lblPaisDestino)
        Me.grpDatosPersonales.Controls.Add(Me.lblFechaRegreso)
        Me.grpDatosPersonales.Controls.Add(Me.txtNacionalidad)
        Me.grpDatosPersonales.Controls.Add(Me.lblNacionalidad)
        Me.grpDatosPersonales.Controls.Add(Me.lblCedula)
        Me.grpDatosPersonales.Controls.Add(Me.txtCedula)
        Me.grpDatosPersonales.Controls.Add(Me.txtApellidos)
        Me.grpDatosPersonales.Controls.Add(Me.lblApellidos)
        Me.grpDatosPersonales.Controls.Add(Me.txtNombre)
        Me.grpDatosPersonales.Controls.Add(Me.lblNombre)
        Me.grpDatosPersonales.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosPersonales.Location = New System.Drawing.Point(12, 12)
        Me.grpDatosPersonales.Name = "grpDatosPersonales"
        Me.grpDatosPersonales.Size = New System.Drawing.Size(458, 549)
        Me.grpDatosPersonales.TabIndex = 14
        Me.grpDatosPersonales.TabStop = False
        Me.grpDatosPersonales.Text = "Datos Personales"
        '
        'txtCantidadAcompanantes
        '
        Me.txtCantidadAcompanantes.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAcompanantes.Location = New System.Drawing.Point(298, 481)
        Me.txtCantidadAcompanantes.Name = "txtCantidadAcompanantes"
        Me.txtCantidadAcompanantes.Size = New System.Drawing.Size(89, 27)
        Me.txtCantidadAcompanantes.TabIndex = 21
        '
        'lblCantAcompanantes
        '
        Me.lblCantAcompanantes.AutoSize = True
        Me.lblCantAcompanantes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantAcompanantes.Location = New System.Drawing.Point(19, 481)
        Me.lblCantAcompanantes.Name = "lblCantAcompanantes"
        Me.lblCantAcompanantes.Size = New System.Drawing.Size(258, 23)
        Me.lblCantAcompanantes.TabIndex = 20
        Me.lblCantAcompanantes.Text = "Cantidad de Acompañantes:"
        '
        'txtCantidadDias
        '
        Me.txtCantidadDias.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadDias.Location = New System.Drawing.Point(298, 435)
        Me.txtCantidadDias.Name = "txtCantidadDias"
        Me.txtCantidadDias.Size = New System.Drawing.Size(89, 27)
        Me.txtCantidadDias.TabIndex = 19
        '
        'lblCantDias
        '
        Me.lblCantDias.AutoSize = True
        Me.lblCantDias.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantDias.Location = New System.Drawing.Point(19, 435)
        Me.lblCantDias.Name = "lblCantDias"
        Me.lblCantDias.Size = New System.Drawing.Size(164, 23)
        Me.lblCantDias.TabIndex = 18
        Me.lblCantDias.Text = "Cantidad de dias:"
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSalida.Location = New System.Drawing.Point(241, 284)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(145, 30)
        Me.dtpFechaSalida.TabIndex = 17
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.AutoSize = True
        Me.lblFechaSalida.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSalida.Location = New System.Drawing.Point(19, 295)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(130, 23)
        Me.lblFechaSalida.TabIndex = 16
        Me.lblFechaSalida.Text = "Fecha Salida:"
        '
        'dtpikFechaRegreso
        '
        Me.dtpikFechaRegreso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpikFechaRegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpikFechaRegreso.Location = New System.Drawing.Point(241, 344)
        Me.dtpikFechaRegreso.Name = "dtpikFechaRegreso"
        Me.dtpikFechaRegreso.Size = New System.Drawing.Size(145, 30)
        Me.dtpikFechaRegreso.TabIndex = 9
        '
        'lblFechaRegreso
        '
        Me.lblFechaRegreso.AutoSize = True
        Me.lblFechaRegreso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRegreso.Location = New System.Drawing.Point(18, 349)
        Me.lblFechaRegreso.Name = "lblFechaRegreso"
        Me.lblFechaRegreso.Size = New System.Drawing.Size(151, 23)
        Me.lblFechaRegreso.TabIndex = 8
        Me.lblFechaRegreso.Text = "Fecha Regreso:"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNacionalidad.Location = New System.Drawing.Point(182, 172)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(204, 27)
        Me.txtNacionalidad.TabIndex = 7
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacionalidad.Location = New System.Drawing.Point(18, 176)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(127, 23)
        Me.lblNacionalidad.TabIndex = 6
        Me.lblNacionalidad.Text = "Nacionalidad:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(18, 130)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(77, 23)
        Me.lblCedula.TabIndex = 5
        Me.lblCedula.Text = "Cedula:"
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(182, 126)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(204, 27)
        Me.txtCedula.TabIndex = 4
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(124, 79)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(262, 27)
        Me.txtApellidos.TabIndex = 3
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(18, 78)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(95, 23)
        Me.lblApellidos.TabIndex = 2
        Me.lblApellidos.Text = "Apellidos:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(124, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(262, 27)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(18, 36)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(85, 23)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'txtZonaPrefe
        '
        Me.txtZonaPrefe.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtZonaPrefe.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZonaPrefe.Location = New System.Drawing.Point(22, 80)
        Me.txtZonaPrefe.Multiline = True
        Me.txtZonaPrefe.Name = "txtZonaPrefe"
        Me.txtZonaPrefe.ReadOnly = True
        Me.txtZonaPrefe.Size = New System.Drawing.Size(159, 161)
        Me.txtZonaPrefe.TabIndex = 19
        Me.txtZonaPrefe.Text = "Lugares con mas espacios,silla reclinable," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ajuste de cabecera y conexion USB por" &
    " un " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7% mas en el valor del boleto."
        '
        'chkZonaPrefe
        '
        Me.chkZonaPrefe.AutoSize = True
        Me.chkZonaPrefe.Location = New System.Drawing.Point(10, 45)
        Me.chkZonaPrefe.Name = "chkZonaPrefe"
        Me.chkZonaPrefe.Size = New System.Drawing.Size(195, 26)
        Me.chkZonaPrefe.TabIndex = 23
        Me.chkZonaPrefe.Text = "Zona Preferencial"
        Me.chkZonaPrefe.UseVisualStyleBackColor = True
        '
        'chkZonaExLegrom
        '
        Me.chkZonaExLegrom.AutoSize = True
        Me.chkZonaExLegrom.Location = New System.Drawing.Point(211, 45)
        Me.chkZonaExLegrom.Name = "chkZonaExLegrom"
        Me.chkZonaExLegrom.Size = New System.Drawing.Size(209, 26)
        Me.chkZonaExLegrom.TabIndex = 24
        Me.chkZonaExLegrom.Text = "Zona Extra Legrom"
        Me.chkZonaExLegrom.UseVisualStyleBackColor = True
        '
        'chkInternetIlim
        '
        Me.chkInternetIlim.AutoSize = True
        Me.chkInternetIlim.Location = New System.Drawing.Point(426, 45)
        Me.chkInternetIlim.Name = "chkInternetIlim"
        Me.chkInternetIlim.Size = New System.Drawing.Size(186, 26)
        Me.chkInternetIlim.TabIndex = 25
        Me.chkInternetIlim.Text = "Internet Ilimitado"
        Me.chkInternetIlim.UseVisualStyleBackColor = True
        '
        'chkFastTrack
        '
        Me.chkFastTrack.AutoSize = True
        Me.chkFastTrack.Location = New System.Drawing.Point(618, 45)
        Me.chkFastTrack.Name = "chkFastTrack"
        Me.chkFastTrack.Size = New System.Drawing.Size(135, 26)
        Me.chkFastTrack.TabIndex = 26
        Me.chkFastTrack.Text = "Fast Track "
        Me.chkFastTrack.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(227, 80)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(159, 161)
        Me.TextBox6.TabIndex = 27
        Me.TextBox6.Text = "Lugares con mas espacio para estirar sus piernas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por $10 por boleto."
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(426, 77)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(159, 161)
        Me.TextBox7.TabIndex = 28
        Me.TextBox7.Text = "Por un 4% adicional al precio de su boleto."
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(605, 77)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(159, 161)
        Me.TextBox8.TabIndex = 29
        Me.TextBox8.Text = "Prioridad al manejo de su equipaje y acceso azonas VIP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por un 5% adicional a su " &
    "boleto."
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.TextBox8)
        Me.grpExtras.Controls.Add(Me.TextBox7)
        Me.grpExtras.Controls.Add(Me.TextBox6)
        Me.grpExtras.Controls.Add(Me.chkFastTrack)
        Me.grpExtras.Controls.Add(Me.chkInternetIlim)
        Me.grpExtras.Controls.Add(Me.chkZonaExLegrom)
        Me.grpExtras.Controls.Add(Me.chkZonaPrefe)
        Me.grpExtras.Controls.Add(Me.txtZonaPrefe)
        Me.grpExtras.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExtras.Location = New System.Drawing.Point(12, 585)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(791, 265)
        Me.grpExtras.TabIndex = 15
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        '
        'txtEspaciosDisponibles
        '
        Me.txtEspaciosDisponibles.Location = New System.Drawing.Point(674, 187)
        Me.txtEspaciosDisponibles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEspaciosDisponibles.Name = "txtEspaciosDisponibles"
        Me.txtEspaciosDisponibles.ReadOnly = True
        Me.txtEspaciosDisponibles.Size = New System.Drawing.Size(102, 27)
        Me.txtEspaciosDisponibles.TabIndex = 17
        '
        'lblEspaciosDisponibles
        '
        Me.lblEspaciosDisponibles.AutoSize = True
        Me.lblEspaciosDisponibles.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspaciosDisponibles.Location = New System.Drawing.Point(483, 151)
        Me.lblEspaciosDisponibles.Name = "lblEspaciosDisponibles"
        Me.lblEspaciosDisponibles.Size = New System.Drawing.Size(327, 23)
        Me.lblEspaciosDisponibles.TabIndex = 16
        Me.lblEspaciosDisponibles.Text = "Espacios Disponibles en este Vuelo:"
        '
        'frmReservaVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 1012)
        Me.Controls.Add(Me.txtEspaciosDisponibles)
        Me.Controls.Add(Me.lblEspaciosDisponibles)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.grpDatosPersonales)
        Me.Controls.Add(Me.btnReserva)
        Me.Controls.Add(Me.txtIdentifVuelo)
        Me.Controls.Add(Me.txtPrecioTiquete)
        Me.Controls.Add(Me.lblPrecioTiquete)
        Me.Controls.Add(Me.lblIdentfVuelo)
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmReservaVuelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservar un Vuelo"
        Me.grpDatosPersonales.ResumeLayout(False)
        Me.grpDatosPersonales.PerformLayout()
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdentfVuelo As Label
    Friend WithEvents lblPaisDestino As Label
    Friend WithEvents cmbPaisDestino As ComboBox
    Friend WithEvents lblHoraSalida As Label
    Friend WithEvents dtpikHoraSalida As DateTimePicker
    Friend WithEvents lblPrecioTiquete As Label
    Friend WithEvents txtPrecioTiquete As TextBox
    Friend WithEvents txtIdentifVuelo As TextBox
    Friend WithEvents btnReserva As Button
    Friend WithEvents grpDatosPersonales As GroupBox
    Friend WithEvents txtCantidadAcompanantes As TextBox
    Friend WithEvents lblCantAcompanantes As Label
    Friend WithEvents txtCantidadDias As TextBox
    Friend WithEvents lblCantDias As Label
    Friend WithEvents dtpFechaSalida As DateTimePicker
    Friend WithEvents lblFechaSalida As Label
    Friend WithEvents dtpikFechaRegreso As DateTimePicker
    Friend WithEvents lblFechaRegreso As Label
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents lblNacionalidad As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtZonaPrefe As TextBox
    Friend WithEvents chkZonaPrefe As CheckBox
    Friend WithEvents chkZonaExLegrom As CheckBox
    Friend WithEvents chkInternetIlim As CheckBox
    Friend WithEvents chkFastTrack As CheckBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents grpExtras As GroupBox
    Friend WithEvents txtEspaciosDisponibles As TextBox
    Friend WithEvents lblEspaciosDisponibles As Label
End Class
