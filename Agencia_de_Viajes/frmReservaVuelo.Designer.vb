﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.lblPrecioTiquete = New System.Windows.Forms.Label()
        Me.txtPrecioTiquete = New System.Windows.Forms.TextBox()
        Me.txtIdentifVuelo = New System.Windows.Forms.TextBox()
        Me.grpDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.txtCantidadAcompanantes = New System.Windows.Forms.TextBox()
        Me.lblCantAcompanantes = New System.Windows.Forms.Label()
        Me.txtCantidadDias = New System.Windows.Forms.TextBox()
        Me.lblCantDias = New System.Windows.Forms.Label()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaSalida = New System.Windows.Forms.Label()
        Me.dtpFechaRegreso = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaRegreso = New System.Windows.Forms.Label()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnCalcularMonto = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grpAcompanantes = New System.Windows.Forms.GroupBox()
        Me.txtNAcionalidadAcompanante = New System.Windows.Forms.TextBox()
        Me.lblnacionalidadAcompanante = New System.Windows.Forms.Label()
        Me.lblCedulaAcompanante = New System.Windows.Forms.Label()
        Me.txtCedulaAcompanante = New System.Windows.Forms.TextBox()
        Me.txtApellidoAcompanante = New System.Windows.Forms.TextBox()
        Me.lblApellidoAcompanante = New System.Windows.Forms.Label()
        Me.txtNombreAcompanante = New System.Windows.Forms.TextBox()
        Me.lblNombreAcompanante = New System.Windows.Forms.Label()
        Me.grpCantDias = New System.Windows.Forms.GroupBox()
        Me.chkmas20 = New System.Windows.Forms.CheckBox()
        Me.txtmas20 = New System.Windows.Forms.TextBox()
        Me.txt15a19 = New System.Windows.Forms.TextBox()
        Me.txt10a14 = New System.Windows.Forms.TextBox()
        Me.txt5a9 = New System.Windows.Forms.TextBox()
        Me.chk15a19 = New System.Windows.Forms.CheckBox()
        Me.chk10a14 = New System.Windows.Forms.CheckBox()
        Me.chk0a9 = New System.Windows.Forms.CheckBox()
        Me.chk0a5 = New System.Windows.Forms.CheckBox()
        Me.txt0a5 = New System.Windows.Forms.TextBox()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.txtFasttrack = New System.Windows.Forms.TextBox()
        Me.txtInternetIlim = New System.Windows.Forms.TextBox()
        Me.txtZonaLegrom = New System.Windows.Forms.TextBox()
        Me.chkFastTrack = New System.Windows.Forms.CheckBox()
        Me.chkInternetIlim = New System.Windows.Forms.CheckBox()
        Me.chkZonaExLegrom = New System.Windows.Forms.CheckBox()
        Me.chkZonaPrefe = New System.Windows.Forms.CheckBox()
        Me.txtZonaPrefe = New System.Windows.Forms.TextBox()
        Me.grpDatosPersonales.SuspendLayout()
        Me.grpAcompanantes.SuspendLayout()
        Me.grpCantDias.SuspendLayout()
        Me.grpExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIdentfVuelo
        '
        Me.lblIdentfVuelo.AutoSize = True
        Me.lblIdentfVuelo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentfVuelo.Location = New System.Drawing.Point(483, 34)
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
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraSalida.Location = New System.Drawing.Point(315, 395)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.Size = New System.Drawing.Size(71, 28)
        Me.dtpHoraSalida.TabIndex = 7
        Me.dtpHoraSalida.Value = New Date(2021, 10, 31, 0, 0, 0, 0)
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
        Me.txtPrecioTiquete.Size = New System.Drawing.Size(102, 27)
        Me.txtPrecioTiquete.TabIndex = 9
        '
        'txtIdentifVuelo
        '
        Me.txtIdentifVuelo.Location = New System.Drawing.Point(534, 66)
        Me.txtIdentifVuelo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdentifVuelo.Name = "txtIdentifVuelo"
        Me.txtIdentifVuelo.ReadOnly = True
        Me.txtIdentifVuelo.Size = New System.Drawing.Size(102, 27)
        Me.txtIdentifVuelo.TabIndex = 12
        '
        'grpDatosPersonales
        '
        Me.grpDatosPersonales.Controls.Add(Me.txtCantidadAcompanantes)
        Me.grpDatosPersonales.Controls.Add(Me.lblCantAcompanantes)
        Me.grpDatosPersonales.Controls.Add(Me.txtCantidadDias)
        Me.grpDatosPersonales.Controls.Add(Me.lblCantDias)
        Me.grpDatosPersonales.Controls.Add(Me.dtpFechaSalida)
        Me.grpDatosPersonales.Controls.Add(Me.lblFechaSalida)
        Me.grpDatosPersonales.Controls.Add(Me.dtpHoraSalida)
        Me.grpDatosPersonales.Controls.Add(Me.lblHoraSalida)
        Me.grpDatosPersonales.Controls.Add(Me.cmbPaisDestino)
        Me.grpDatosPersonales.Controls.Add(Me.dtpFechaRegreso)
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
        Me.txtCantidadDias.Enabled = False
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
        'dtpFechaRegreso
        '
        Me.dtpFechaRegreso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRegreso.Location = New System.Drawing.Point(241, 344)
        Me.dtpFechaRegreso.Name = "dtpFechaRegreso"
        Me.dtpFechaRegreso.Size = New System.Drawing.Size(145, 30)
        Me.dtpFechaRegreso.TabIndex = 9
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
        'btnCalcularMonto
        '
        Me.btnCalcularMonto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalcularMonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalcularMonto.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularMonto.Location = New System.Drawing.Point(42, 923)
        Me.btnCalcularMonto.Name = "btnCalcularMonto"
        Me.btnCalcularMonto.Size = New System.Drawing.Size(292, 43)
        Me.btnCalcularMonto.TabIndex = 37
        Me.btnCalcularMonto.Text = "Calcular Monto Tiquete"
        Me.btnCalcularMonto.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial Black", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(418, 923)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 43)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Comprar Tiquetes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'grpAcompanantes
        '
        Me.grpAcompanantes.Controls.Add(Me.txtNAcionalidadAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.lblnacionalidadAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.lblCedulaAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.txtCedulaAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.txtApellidoAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.lblApellidoAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.txtNombreAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.lblNombreAcompanante)
        Me.grpAcompanantes.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAcompanantes.Location = New System.Drawing.Point(699, 22)
        Me.grpAcompanantes.Name = "grpAcompanantes"
        Me.grpAcompanantes.Size = New System.Drawing.Size(412, 229)
        Me.grpAcompanantes.TabIndex = 38
        Me.grpAcompanantes.TabStop = False
        Me.grpAcompanantes.Text = "Datos de los Acompañantes"
        Me.grpAcompanantes.Visible = False
        '
        'txtNAcionalidadAcompanante
        '
        Me.txtNAcionalidadAcompanante.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNAcionalidadAcompanante.Location = New System.Drawing.Point(182, 172)
        Me.txtNAcionalidadAcompanante.Name = "txtNAcionalidadAcompanante"
        Me.txtNAcionalidadAcompanante.Size = New System.Drawing.Size(204, 27)
        Me.txtNAcionalidadAcompanante.TabIndex = 14
        '
        'lblnacionalidadAcompanante
        '
        Me.lblnacionalidadAcompanante.AutoSize = True
        Me.lblnacionalidadAcompanante.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnacionalidadAcompanante.Location = New System.Drawing.Point(18, 176)
        Me.lblnacionalidadAcompanante.Name = "lblnacionalidadAcompanante"
        Me.lblnacionalidadAcompanante.Size = New System.Drawing.Size(127, 23)
        Me.lblnacionalidadAcompanante.TabIndex = 6
        Me.lblnacionalidadAcompanante.Text = "Nacionalidad:"
        '
        'lblCedulaAcompanante
        '
        Me.lblCedulaAcompanante.AutoSize = True
        Me.lblCedulaAcompanante.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaAcompanante.Location = New System.Drawing.Point(18, 130)
        Me.lblCedulaAcompanante.Name = "lblCedulaAcompanante"
        Me.lblCedulaAcompanante.Size = New System.Drawing.Size(77, 23)
        Me.lblCedulaAcompanante.TabIndex = 5
        Me.lblCedulaAcompanante.Text = "Cedula:"
        '
        'txtCedulaAcompanante
        '
        Me.txtCedulaAcompanante.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaAcompanante.Location = New System.Drawing.Point(182, 126)
        Me.txtCedulaAcompanante.Name = "txtCedulaAcompanante"
        Me.txtCedulaAcompanante.Size = New System.Drawing.Size(204, 27)
        Me.txtCedulaAcompanante.TabIndex = 13
        '
        'txtApellidoAcompanante
        '
        Me.txtApellidoAcompanante.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoAcompanante.Location = New System.Drawing.Point(124, 79)
        Me.txtApellidoAcompanante.Name = "txtApellidoAcompanante"
        Me.txtApellidoAcompanante.Size = New System.Drawing.Size(262, 27)
        Me.txtApellidoAcompanante.TabIndex = 12
        '
        'lblApellidoAcompanante
        '
        Me.lblApellidoAcompanante.AutoSize = True
        Me.lblApellidoAcompanante.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoAcompanante.Location = New System.Drawing.Point(18, 78)
        Me.lblApellidoAcompanante.Name = "lblApellidoAcompanante"
        Me.lblApellidoAcompanante.Size = New System.Drawing.Size(95, 23)
        Me.lblApellidoAcompanante.TabIndex = 2
        Me.lblApellidoAcompanante.Text = "Apellidos:"
        '
        'txtNombreAcompanante
        '
        Me.txtNombreAcompanante.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAcompanante.Location = New System.Drawing.Point(124, 36)
        Me.txtNombreAcompanante.Name = "txtNombreAcompanante"
        Me.txtNombreAcompanante.Size = New System.Drawing.Size(262, 27)
        Me.txtNombreAcompanante.TabIndex = 11
        '
        'lblNombreAcompanante
        '
        Me.lblNombreAcompanante.AutoSize = True
        Me.lblNombreAcompanante.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreAcompanante.Location = New System.Drawing.Point(18, 36)
        Me.lblNombreAcompanante.Name = "lblNombreAcompanante"
        Me.lblNombreAcompanante.Size = New System.Drawing.Size(85, 23)
        Me.lblNombreAcompanante.TabIndex = 0
        Me.lblNombreAcompanante.Text = "Nombre:"
        '
        'grpCantDias
        '
        Me.grpCantDias.Controls.Add(Me.chkmas20)
        Me.grpCantDias.Controls.Add(Me.txtmas20)
        Me.grpCantDias.Controls.Add(Me.txt15a19)
        Me.grpCantDias.Controls.Add(Me.txt10a14)
        Me.grpCantDias.Controls.Add(Me.txt5a9)
        Me.grpCantDias.Controls.Add(Me.chk15a19)
        Me.grpCantDias.Controls.Add(Me.chk10a14)
        Me.grpCantDias.Controls.Add(Me.chk0a9)
        Me.grpCantDias.Controls.Add(Me.chk0a5)
        Me.grpCantDias.Controls.Add(Me.txt0a5)
        Me.grpCantDias.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCantDias.Location = New System.Drawing.Point(12, 583)
        Me.grpCantDias.Name = "grpCantDias"
        Me.grpCantDias.Size = New System.Drawing.Size(608, 263)
        Me.grpCantDias.TabIndex = 40
        Me.grpCantDias.TabStop = False
        Me.grpCantDias.Text = "Cantidad Dias del Viaje"
        '
        'chkmas20
        '
        Me.chkmas20.AutoSize = True
        Me.chkmas20.Enabled = False
        Me.chkmas20.Location = New System.Drawing.Point(237, 147)
        Me.chkmas20.Name = "chkmas20"
        Me.chkmas20.Size = New System.Drawing.Size(170, 26)
        Me.chkmas20.TabIndex = 31
        Me.chkmas20.Text = "Mas de 20 dias"
        Me.chkmas20.UseVisualStyleBackColor = True
        '
        'txtmas20
        '
        Me.txtmas20.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtmas20.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmas20.Location = New System.Drawing.Point(237, 179)
        Me.txtmas20.Multiline = True
        Me.txtmas20.Name = "txtmas20"
        Me.txtmas20.ReadOnly = True
        Me.txtmas20.Size = New System.Drawing.Size(159, 69)
        Me.txtmas20.TabIndex = 30
        Me.txtmas20.Text = "10% de Descuento en su boleto."
        '
        'txt15a19
        '
        Me.txt15a19.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt15a19.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt15a19.Location = New System.Drawing.Point(24, 179)
        Me.txt15a19.Multiline = True
        Me.txt15a19.Name = "txt15a19"
        Me.txt15a19.ReadOnly = True
        Me.txt15a19.Size = New System.Drawing.Size(159, 69)
        Me.txt15a19.TabIndex = 29
        Me.txt15a19.Text = "8 % de Descuento en su boleto."
        '
        'txt10a14
        '
        Me.txt10a14.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt10a14.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt10a14.Location = New System.Drawing.Point(422, 86)
        Me.txt10a14.Multiline = True
        Me.txt10a14.Name = "txt10a14"
        Me.txt10a14.ReadOnly = True
        Me.txt10a14.Size = New System.Drawing.Size(159, 63)
        Me.txt10a14.TabIndex = 28
        Me.txt10a14.Text = "5 % de Descuento en su boleto."
        '
        'txt5a9
        '
        Me.txt5a9.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt5a9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5a9.Location = New System.Drawing.Point(227, 80)
        Me.txt5a9.Multiline = True
        Me.txt5a9.Name = "txt5a9"
        Me.txt5a9.ReadOnly = True
        Me.txt5a9.Size = New System.Drawing.Size(159, 61)
        Me.txt5a9.TabIndex = 27
        Me.txt5a9.Text = "3 % de Descuento en su boleto."
        '
        'chk15a19
        '
        Me.chk15a19.AutoSize = True
        Me.chk15a19.Enabled = False
        Me.chk15a19.Location = New System.Drawing.Point(10, 147)
        Me.chk15a19.Name = "chk15a19"
        Me.chk15a19.Size = New System.Drawing.Size(173, 26)
        Me.chk15a19.TabIndex = 26
        Me.chk15a19.Text = "De 15 a 19 Dias"
        Me.chk15a19.UseVisualStyleBackColor = True
        '
        'chk10a14
        '
        Me.chk10a14.AutoSize = True
        Me.chk10a14.Enabled = False
        Me.chk10a14.Location = New System.Drawing.Point(422, 45)
        Me.chk10a14.Name = "chk10a14"
        Me.chk10a14.Size = New System.Drawing.Size(173, 26)
        Me.chk10a14.TabIndex = 25
        Me.chk10a14.Text = "De 10 a 14 Dias"
        Me.chk10a14.UseVisualStyleBackColor = True
        '
        'chk0a9
        '
        Me.chk0a9.AutoSize = True
        Me.chk0a9.Enabled = False
        Me.chk0a9.Location = New System.Drawing.Point(211, 45)
        Me.chk0a9.Name = "chk0a9"
        Me.chk0a9.Size = New System.Drawing.Size(151, 26)
        Me.chk0a9.TabIndex = 24
        Me.chk0a9.Text = "De 5 a 9 Dias"
        Me.chk0a9.UseVisualStyleBackColor = True
        '
        'chk0a5
        '
        Me.chk0a5.AutoSize = True
        Me.chk0a5.Enabled = False
        Me.chk0a5.Location = New System.Drawing.Point(10, 45)
        Me.chk0a5.Name = "chk0a5"
        Me.chk0a5.Size = New System.Drawing.Size(151, 26)
        Me.chk0a5.TabIndex = 23
        Me.chk0a5.Text = "De 0 a 5 Dias"
        Me.chk0a5.UseVisualStyleBackColor = True
        '
        'txt0a5
        '
        Me.txt0a5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt0a5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt0a5.Location = New System.Drawing.Point(6, 80)
        Me.txt0a5.Multiline = True
        Me.txt0a5.Name = "txt0a5"
        Me.txt0a5.ReadOnly = True
        Me.txt0a5.Size = New System.Drawing.Size(159, 53)
        Me.txt0a5.TabIndex = 19
        Me.txt0a5.Text = "No tiene Descuento"
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.txtFasttrack)
        Me.grpExtras.Controls.Add(Me.txtInternetIlim)
        Me.grpExtras.Controls.Add(Me.txtZonaLegrom)
        Me.grpExtras.Controls.Add(Me.chkFastTrack)
        Me.grpExtras.Controls.Add(Me.chkInternetIlim)
        Me.grpExtras.Controls.Add(Me.chkZonaExLegrom)
        Me.grpExtras.Controls.Add(Me.chkZonaPrefe)
        Me.grpExtras.Controls.Add(Me.txtZonaPrefe)
        Me.grpExtras.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExtras.Location = New System.Drawing.Point(660, 296)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(451, 534)
        Me.grpExtras.TabIndex = 41
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        '
        'txtFasttrack
        '
        Me.txtFasttrack.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtFasttrack.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFasttrack.Location = New System.Drawing.Point(238, 311)
        Me.txtFasttrack.Multiline = True
        Me.txtFasttrack.Name = "txtFasttrack"
        Me.txtFasttrack.ReadOnly = True
        Me.txtFasttrack.Size = New System.Drawing.Size(159, 181)
        Me.txtFasttrack.TabIndex = 29
        Me.txtFasttrack.Text = "Prioridad al manejo de su equipaje y acceso azonas VIP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por un 5% adicional a su " &
    "boleto."
        '
        'txtInternetIlim
        '
        Me.txtInternetIlim.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtInternetIlim.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInternetIlim.Location = New System.Drawing.Point(10, 311)
        Me.txtInternetIlim.Multiline = True
        Me.txtInternetIlim.Name = "txtInternetIlim"
        Me.txtInternetIlim.ReadOnly = True
        Me.txtInternetIlim.Size = New System.Drawing.Size(159, 181)
        Me.txtInternetIlim.TabIndex = 28
        Me.txtInternetIlim.Text = "Por un 4% adicional al precio de su boleto."
        '
        'txtZonaLegrom
        '
        Me.txtZonaLegrom.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtZonaLegrom.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZonaLegrom.Location = New System.Drawing.Point(227, 80)
        Me.txtZonaLegrom.Multiline = True
        Me.txtZonaLegrom.Name = "txtZonaLegrom"
        Me.txtZonaLegrom.ReadOnly = True
        Me.txtZonaLegrom.Size = New System.Drawing.Size(159, 178)
        Me.txtZonaLegrom.TabIndex = 27
        Me.txtZonaLegrom.Text = "Lugares con mas espacio para estirar sus piernas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por $10 por boleto."
        '
        'chkFastTrack
        '
        Me.chkFastTrack.AutoSize = True
        Me.chkFastTrack.Location = New System.Drawing.Point(251, 279)
        Me.chkFastTrack.Name = "chkFastTrack"
        Me.chkFastTrack.Size = New System.Drawing.Size(135, 26)
        Me.chkFastTrack.TabIndex = 21
        Me.chkFastTrack.Text = "Fast Track "
        Me.chkFastTrack.UseVisualStyleBackColor = True
        '
        'chkInternetIlim
        '
        Me.chkInternetIlim.AutoSize = True
        Me.chkInternetIlim.Location = New System.Drawing.Point(10, 279)
        Me.chkInternetIlim.Name = "chkInternetIlim"
        Me.chkInternetIlim.Size = New System.Drawing.Size(186, 26)
        Me.chkInternetIlim.TabIndex = 20
        Me.chkInternetIlim.Text = "Internet Ilimitado"
        Me.chkInternetIlim.UseVisualStyleBackColor = True
        '
        'chkZonaExLegrom
        '
        Me.chkZonaExLegrom.AutoSize = True
        Me.chkZonaExLegrom.Location = New System.Drawing.Point(211, 45)
        Me.chkZonaExLegrom.Name = "chkZonaExLegrom"
        Me.chkZonaExLegrom.Size = New System.Drawing.Size(209, 26)
        Me.chkZonaExLegrom.TabIndex = 19
        Me.chkZonaExLegrom.Text = "Zona Extra Legrom"
        Me.chkZonaExLegrom.UseVisualStyleBackColor = True
        '
        'chkZonaPrefe
        '
        Me.chkZonaPrefe.AutoSize = True
        Me.chkZonaPrefe.Location = New System.Drawing.Point(10, 45)
        Me.chkZonaPrefe.Name = "chkZonaPrefe"
        Me.chkZonaPrefe.Size = New System.Drawing.Size(195, 26)
        Me.chkZonaPrefe.TabIndex = 28
        Me.chkZonaPrefe.Text = "Zona Preferencial"
        Me.chkZonaPrefe.UseVisualStyleBackColor = True
        '
        'txtZonaPrefe
        '
        Me.txtZonaPrefe.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtZonaPrefe.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZonaPrefe.Location = New System.Drawing.Point(22, 80)
        Me.txtZonaPrefe.Multiline = True
        Me.txtZonaPrefe.Name = "txtZonaPrefe"
        Me.txtZonaPrefe.ReadOnly = True
        Me.txtZonaPrefe.Size = New System.Drawing.Size(159, 193)
        Me.txtZonaPrefe.TabIndex = 19
        Me.txtZonaPrefe.Text = "Lugares con mas espacios,silla reclinable," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ajuste de cabecera y conexion USB por" &
    " un " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7% mas en el valor del boleto."
        '
        'frmReservaVuelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 1012)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.grpCantDias)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grpAcompanantes)
        Me.Controls.Add(Me.btnCalcularMonto)
        Me.Controls.Add(Me.grpDatosPersonales)
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
        Me.grpAcompanantes.ResumeLayout(False)
        Me.grpAcompanantes.PerformLayout()
        Me.grpCantDias.ResumeLayout(False)
        Me.grpCantDias.PerformLayout()
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdentfVuelo As Label
    Friend WithEvents lblPaisDestino As Label
    Friend WithEvents cmbPaisDestino As ComboBox
    Friend WithEvents lblHoraSalida As Label
    Friend WithEvents dtpHoraSalida As DateTimePicker
    Friend WithEvents lblPrecioTiquete As Label
    Friend WithEvents txtPrecioTiquete As TextBox
    Friend WithEvents txtIdentifVuelo As TextBox
    Friend WithEvents grpDatosPersonales As GroupBox
    Friend WithEvents txtCantidadAcompanantes As TextBox
    Friend WithEvents lblCantAcompanantes As Label
    Friend WithEvents txtCantidadDias As TextBox
    Friend WithEvents lblCantDias As Label
    Friend WithEvents dtpFechaSalida As DateTimePicker
    Friend WithEvents lblFechaSalida As Label
    Friend WithEvents dtpFechaRegreso As DateTimePicker
    Friend WithEvents lblFechaRegreso As Label
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents lblNacionalidad As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnCalcularMonto As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents grpAcompanantes As GroupBox
    Friend WithEvents txtNAcionalidadAcompanante As TextBox
    Friend WithEvents lblnacionalidadAcompanante As Label
    Friend WithEvents lblCedulaAcompanante As Label
    Friend WithEvents txtCedulaAcompanante As TextBox
    Friend WithEvents txtApellidoAcompanante As TextBox
    Friend WithEvents lblApellidoAcompanante As Label
    Friend WithEvents txtNombreAcompanante As TextBox
    Friend WithEvents lblNombreAcompanante As Label
    Friend WithEvents grpCantDias As GroupBox
    Friend WithEvents chkmas20 As CheckBox
    Friend WithEvents txtmas20 As TextBox
    Friend WithEvents txt15a19 As TextBox
    Friend WithEvents txt10a14 As TextBox
    Friend WithEvents txt5a9 As TextBox
    Friend WithEvents chk15a19 As CheckBox
    Friend WithEvents chk10a14 As CheckBox
    Friend WithEvents chk0a9 As CheckBox
    Friend WithEvents chk0a5 As CheckBox
    Friend WithEvents txt0a5 As TextBox
    Friend WithEvents grpExtras As GroupBox
    Friend WithEvents txtFasttrack As TextBox
    Friend WithEvents txtInternetIlim As TextBox
    Friend WithEvents txtZonaLegrom As TextBox
    Friend WithEvents chkFastTrack As CheckBox
    Friend WithEvents chkInternetIlim As CheckBox
    Friend WithEvents chkZonaExLegrom As CheckBox
    Friend WithEvents chkZonaPrefe As CheckBox
    Friend WithEvents txtZonaPrefe As TextBox
End Class
