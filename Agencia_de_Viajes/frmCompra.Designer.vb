<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompra
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
        Me.grpDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label1lblNacionalidad = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.dtpikFechaRegreso = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaRegreso = New System.Windows.Forms.Label()
        Me.chkAcompanantes = New System.Windows.Forms.CheckBox()
        Me.lblAcompanantes = New System.Windows.Forms.Label()
        Me.lblMaletasExtra = New System.Windows.Forms.Label()
        Me.chkMaletasExtra = New System.Windows.Forms.CheckBox()
        Me.lblserviExtras = New System.Windows.Forms.Label()
        Me.chkServiciosExtra = New System.Windows.Forms.CheckBox()
        Me.grpAcompanantes = New System.Windows.Forms.GroupBox()
        Me.txtNAcionalidadAcompanante = New System.Windows.Forms.TextBox()
        Me.lblnacionalidadAcompanante = New System.Windows.Forms.Label()
        Me.lblCedulaAcompanante = New System.Windows.Forms.Label()
        Me.txtCedulaAcompanante = New System.Windows.Forms.TextBox()
        Me.txtApellidoAcompanante = New System.Windows.Forms.TextBox()
        Me.lblApellidoAcompanante = New System.Windows.Forms.Label()
        Me.txtNombreAcompanante = New System.Windows.Forms.TextBox()
        Me.lblNombreAcompanante = New System.Windows.Forms.Label()
        Me.grpMaletas = New System.Windows.Forms.GroupBox()
        Me.txtPesoMaletasExtra = New System.Windows.Forms.TextBox()
        Me.lblPesoMaletasExtra = New System.Windows.Forms.Label()
        Me.txtCantidadMaletasExtra = New System.Windows.Forms.TextBox()
        Me.lblCantidadMaletasExtra = New System.Windows.Forms.Label()
        Me.brnAgregarAcompanante = New System.Windows.Forms.Button()
        Me.txtCantAcompanantes = New System.Windows.Forms.TextBox()
        Me.lblCantidadAcompanante = New System.Windows.Forms.Label()
        Me.grpServiciosExtra = New System.Windows.Forms.GroupBox()
        Me.lblZonaLegroom = New System.Windows.Forms.Label()
        Me.chkZonaLegron = New System.Windows.Forms.CheckBox()
        Me.lblFastTrack = New System.Windows.Forms.Label()
        Me.chkfastTrack = New System.Windows.Forms.CheckBox()
        Me.lblInternetIlimitado = New System.Windows.Forms.Label()
        Me.chkInternetIlimitado = New System.Windows.Forms.CheckBox()
        Me.btnComprarTiquete = New System.Windows.Forms.Button()
        Me.grpDatosPersonales.SuspendLayout()
        Me.grpAcompanantes.SuspendLayout()
        Me.grpMaletas.SuspendLayout()
        Me.grpServiciosExtra.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatosPersonales
        '
        Me.grpDatosPersonales.Controls.Add(Me.lblserviExtras)
        Me.grpDatosPersonales.Controls.Add(Me.chkServiciosExtra)
        Me.grpDatosPersonales.Controls.Add(Me.lblMaletasExtra)
        Me.grpDatosPersonales.Controls.Add(Me.chkMaletasExtra)
        Me.grpDatosPersonales.Controls.Add(Me.lblAcompanantes)
        Me.grpDatosPersonales.Controls.Add(Me.chkAcompanantes)
        Me.grpDatosPersonales.Controls.Add(Me.dtpikFechaRegreso)
        Me.grpDatosPersonales.Controls.Add(Me.lblFechaRegreso)
        Me.grpDatosPersonales.Controls.Add(Me.TextBox2)
        Me.grpDatosPersonales.Controls.Add(Me.Label1lblNacionalidad)
        Me.grpDatosPersonales.Controls.Add(Me.lblCedula)
        Me.grpDatosPersonales.Controls.Add(Me.txtCedula)
        Me.grpDatosPersonales.Controls.Add(Me.TextBox1)
        Me.grpDatosPersonales.Controls.Add(Me.lblApellidos)
        Me.grpDatosPersonales.Controls.Add(Me.txtNombre)
        Me.grpDatosPersonales.Controls.Add(Me.lblNombre)
        Me.grpDatosPersonales.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosPersonales.Location = New System.Drawing.Point(12, 12)
        Me.grpDatosPersonales.Name = "grpDatosPersonales"
        Me.grpDatosPersonales.Size = New System.Drawing.Size(408, 386)
        Me.grpDatosPersonales.TabIndex = 0
        Me.grpDatosPersonales.TabStop = False
        Me.grpDatosPersonales.Text = "Datos Personales"
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
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(124, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(262, 27)
        Me.txtNombre.TabIndex = 1
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(124, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(262, 27)
        Me.TextBox1.TabIndex = 3
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(182, 126)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(204, 27)
        Me.txtCedula.TabIndex = 4
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
        'Label1lblNacionalidad
        '
        Me.Label1lblNacionalidad.AutoSize = True
        Me.Label1lblNacionalidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1lblNacionalidad.Location = New System.Drawing.Point(18, 176)
        Me.Label1lblNacionalidad.Name = "Label1lblNacionalidad"
        Me.Label1lblNacionalidad.Size = New System.Drawing.Size(127, 23)
        Me.Label1lblNacionalidad.TabIndex = 6
        Me.Label1lblNacionalidad.Text = "Nacionalidad:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(182, 172)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(204, 27)
        Me.TextBox2.TabIndex = 7
        '
        'dtpikFechaRegreso
        '
        Me.dtpikFechaRegreso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpikFechaRegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpikFechaRegreso.Location = New System.Drawing.Point(241, 232)
        Me.dtpikFechaRegreso.Name = "dtpikFechaRegreso"
        Me.dtpikFechaRegreso.Size = New System.Drawing.Size(145, 30)
        Me.dtpikFechaRegreso.TabIndex = 9
        '
        'lblFechaRegreso
        '
        Me.lblFechaRegreso.AutoSize = True
        Me.lblFechaRegreso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRegreso.Location = New System.Drawing.Point(18, 231)
        Me.lblFechaRegreso.Name = "lblFechaRegreso"
        Me.lblFechaRegreso.Size = New System.Drawing.Size(151, 23)
        Me.lblFechaRegreso.TabIndex = 8
        Me.lblFechaRegreso.Text = "Fecha Regreso:"
        '
        'chkAcompanantes
        '
        Me.chkAcompanantes.AutoSize = True
        Me.chkAcompanantes.Location = New System.Drawing.Point(168, 317)
        Me.chkAcompanantes.Name = "chkAcompanantes"
        Me.chkAcompanantes.Size = New System.Drawing.Size(18, 17)
        Me.chkAcompanantes.TabIndex = 10
        Me.chkAcompanantes.UseVisualStyleBackColor = True
        '
        'lblAcompanantes
        '
        Me.lblAcompanantes.AutoSize = True
        Me.lblAcompanantes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcompanantes.Location = New System.Drawing.Point(4, 313)
        Me.lblAcompanantes.Name = "lblAcompanantes"
        Me.lblAcompanantes.Size = New System.Drawing.Size(141, 23)
        Me.lblAcompanantes.TabIndex = 11
        Me.lblAcompanantes.Text = "Acompañantes"
        '
        'lblMaletasExtra
        '
        Me.lblMaletasExtra.AutoSize = True
        Me.lblMaletasExtra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaletasExtra.Location = New System.Drawing.Point(6, 348)
        Me.lblMaletasExtra.Name = "lblMaletasExtra"
        Me.lblMaletasExtra.Size = New System.Drawing.Size(132, 23)
        Me.lblMaletasExtra.TabIndex = 13
        Me.lblMaletasExtra.Text = "Maletas Extra"
        '
        'chkMaletasExtra
        '
        Me.chkMaletasExtra.AutoSize = True
        Me.chkMaletasExtra.Location = New System.Drawing.Point(168, 353)
        Me.chkMaletasExtra.Name = "chkMaletasExtra"
        Me.chkMaletasExtra.Size = New System.Drawing.Size(18, 17)
        Me.chkMaletasExtra.TabIndex = 12
        Me.chkMaletasExtra.UseVisualStyleBackColor = True
        '
        'lblserviExtras
        '
        Me.lblserviExtras.AutoSize = True
        Me.lblserviExtras.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserviExtras.Location = New System.Drawing.Point(203, 312)
        Me.lblserviExtras.Name = "lblserviExtras"
        Me.lblserviExtras.Size = New System.Drawing.Size(141, 23)
        Me.lblserviExtras.TabIndex = 15
        Me.lblserviExtras.Text = "Servicios Extra"
        '
        'chkServiciosExtra
        '
        Me.chkServiciosExtra.AutoSize = True
        Me.chkServiciosExtra.Location = New System.Drawing.Point(359, 317)
        Me.chkServiciosExtra.Name = "chkServiciosExtra"
        Me.chkServiciosExtra.Size = New System.Drawing.Size(18, 17)
        Me.chkServiciosExtra.TabIndex = 14
        Me.chkServiciosExtra.UseVisualStyleBackColor = True
        '
        'grpAcompanantes
        '
        Me.grpAcompanantes.Controls.Add(Me.txtCantAcompanantes)
        Me.grpAcompanantes.Controls.Add(Me.lblCantidadAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.brnAgregarAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.txtNAcionalidadAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.lblnacionalidadAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.lblCedulaAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.txtCedulaAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.txtApellidoAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.lblApellidoAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.txtNombreAcompanante)
        Me.grpAcompanantes.Controls.Add(Me.lblNombreAcompanante)
        Me.grpAcompanantes.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAcompanantes.Location = New System.Drawing.Point(460, 24)
        Me.grpAcompanantes.Name = "grpAcompanantes"
        Me.grpAcompanantes.Size = New System.Drawing.Size(412, 324)
        Me.grpAcompanantes.TabIndex = 1
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
        Me.txtNAcionalidadAcompanante.TabIndex = 7
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
        Me.txtCedulaAcompanante.TabIndex = 4
        '
        'txtApellidoAcompanante
        '
        Me.txtApellidoAcompanante.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoAcompanante.Location = New System.Drawing.Point(124, 79)
        Me.txtApellidoAcompanante.Name = "txtApellidoAcompanante"
        Me.txtApellidoAcompanante.Size = New System.Drawing.Size(262, 27)
        Me.txtApellidoAcompanante.TabIndex = 3
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
        Me.txtNombreAcompanante.TabIndex = 1
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
        'grpMaletas
        '
        Me.grpMaletas.Controls.Add(Me.txtPesoMaletasExtra)
        Me.grpMaletas.Controls.Add(Me.lblPesoMaletasExtra)
        Me.grpMaletas.Controls.Add(Me.txtCantidadMaletasExtra)
        Me.grpMaletas.Controls.Add(Me.lblCantidadMaletasExtra)
        Me.grpMaletas.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMaletas.Location = New System.Drawing.Point(460, 384)
        Me.grpMaletas.Name = "grpMaletas"
        Me.grpMaletas.Size = New System.Drawing.Size(412, 126)
        Me.grpMaletas.TabIndex = 2
        Me.grpMaletas.TabStop = False
        Me.grpMaletas.Text = "Maletas Extra"
        Me.grpMaletas.Visible = False
        '
        'txtPesoMaletasExtra
        '
        Me.txtPesoMaletasExtra.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoMaletasExtra.Location = New System.Drawing.Point(246, 79)
        Me.txtPesoMaletasExtra.Name = "txtPesoMaletasExtra"
        Me.txtPesoMaletasExtra.Size = New System.Drawing.Size(140, 27)
        Me.txtPesoMaletasExtra.TabIndex = 3
        '
        'lblPesoMaletasExtra
        '
        Me.lblPesoMaletasExtra.AutoSize = True
        Me.lblPesoMaletasExtra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesoMaletasExtra.Location = New System.Drawing.Point(18, 78)
        Me.lblPesoMaletasExtra.Name = "lblPesoMaletasExtra"
        Me.lblPesoMaletasExtra.Size = New System.Drawing.Size(189, 23)
        Me.lblPesoMaletasExtra.TabIndex = 2
        Me.lblPesoMaletasExtra.Text = "Peso Maletas Extra:"
        '
        'txtCantidadMaletasExtra
        '
        Me.txtCantidadMaletasExtra.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadMaletasExtra.Location = New System.Drawing.Point(246, 36)
        Me.txtCantidadMaletasExtra.Name = "txtCantidadMaletasExtra"
        Me.txtCantidadMaletasExtra.Size = New System.Drawing.Size(140, 27)
        Me.txtCantidadMaletasExtra.TabIndex = 1
        '
        'lblCantidadMaletasExtra
        '
        Me.lblCantidadMaletasExtra.AutoSize = True
        Me.lblCantidadMaletasExtra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadMaletasExtra.Location = New System.Drawing.Point(18, 36)
        Me.lblCantidadMaletasExtra.Name = "lblCantidadMaletasExtra"
        Me.lblCantidadMaletasExtra.Size = New System.Drawing.Size(222, 23)
        Me.lblCantidadMaletasExtra.TabIndex = 0
        Me.lblCantidadMaletasExtra.Text = "Cantidad Maletas Extra:"
        '
        'brnAgregarAcompanante
        '
        Me.brnAgregarAcompanante.Location = New System.Drawing.Point(141, 265)
        Me.brnAgregarAcompanante.Name = "brnAgregarAcompanante"
        Me.brnAgregarAcompanante.Size = New System.Drawing.Size(129, 43)
        Me.brnAgregarAcompanante.TabIndex = 8
        Me.brnAgregarAcompanante.Text = "Agregar"
        Me.brnAgregarAcompanante.UseVisualStyleBackColor = True
        '
        'txtCantAcompanantes
        '
        Me.txtCantAcompanantes.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantAcompanantes.Location = New System.Drawing.Point(272, 220)
        Me.txtCantAcompanantes.Name = "txtCantAcompanantes"
        Me.txtCantAcompanantes.ReadOnly = True
        Me.txtCantAcompanantes.Size = New System.Drawing.Size(50, 27)
        Me.txtCantAcompanantes.TabIndex = 10
        '
        'lblCantidadAcompanante
        '
        Me.lblCantidadAcompanante.AutoSize = True
        Me.lblCantidadAcompanante.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadAcompanante.Location = New System.Drawing.Point(18, 220)
        Me.lblCantidadAcompanante.Name = "lblCantidadAcompanante"
        Me.lblCantidadAcompanante.Size = New System.Drawing.Size(248, 23)
        Me.lblCantidadAcompanante.TabIndex = 9
        Me.lblCantidadAcompanante.Text = "Numero de Acompañantes:"
        '
        'grpServiciosExtra
        '
        Me.grpServiciosExtra.Controls.Add(Me.lblInternetIlimitado)
        Me.grpServiciosExtra.Controls.Add(Me.chkInternetIlimitado)
        Me.grpServiciosExtra.Controls.Add(Me.lblFastTrack)
        Me.grpServiciosExtra.Controls.Add(Me.chkfastTrack)
        Me.grpServiciosExtra.Controls.Add(Me.lblZonaLegroom)
        Me.grpServiciosExtra.Controls.Add(Me.chkZonaLegron)
        Me.grpServiciosExtra.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpServiciosExtra.Location = New System.Drawing.Point(12, 420)
        Me.grpServiciosExtra.Name = "grpServiciosExtra"
        Me.grpServiciosExtra.Size = New System.Drawing.Size(359, 105)
        Me.grpServiciosExtra.TabIndex = 3
        Me.grpServiciosExtra.TabStop = False
        Me.grpServiciosExtra.Text = "Servicios Extra"
        Me.grpServiciosExtra.Visible = False
        '
        'lblZonaLegroom
        '
        Me.lblZonaLegroom.AutoSize = True
        Me.lblZonaLegroom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZonaLegroom.Location = New System.Drawing.Point(18, 36)
        Me.lblZonaLegroom.Name = "lblZonaLegroom"
        Me.lblZonaLegroom.Size = New System.Drawing.Size(138, 23)
        Me.lblZonaLegroom.TabIndex = 17
        Me.lblZonaLegroom.Text = "Zona Legroom"
        '
        'chkZonaLegron
        '
        Me.chkZonaLegron.AutoSize = True
        Me.chkZonaLegron.Location = New System.Drawing.Point(182, 43)
        Me.chkZonaLegron.Name = "chkZonaLegron"
        Me.chkZonaLegron.Size = New System.Drawing.Size(18, 17)
        Me.chkZonaLegron.TabIndex = 16
        Me.chkZonaLegron.UseVisualStyleBackColor = True
        '
        'lblFastTrack
        '
        Me.lblFastTrack.AutoSize = True
        Me.lblFastTrack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFastTrack.Location = New System.Drawing.Point(217, 36)
        Me.lblFastTrack.Name = "lblFastTrack"
        Me.lblFastTrack.Size = New System.Drawing.Size(104, 23)
        Me.lblFastTrack.TabIndex = 19
        Me.lblFastTrack.Text = "Fast Track"
        '
        'chkfastTrack
        '
        Me.chkfastTrack.AutoSize = True
        Me.chkfastTrack.Location = New System.Drawing.Point(330, 41)
        Me.chkfastTrack.Name = "chkfastTrack"
        Me.chkfastTrack.Size = New System.Drawing.Size(18, 17)
        Me.chkfastTrack.TabIndex = 18
        Me.chkfastTrack.UseVisualStyleBackColor = True
        '
        'lblInternetIlimitado
        '
        Me.lblInternetIlimitado.AutoSize = True
        Me.lblInternetIlimitado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternetIlimitado.Location = New System.Drawing.Point(18, 67)
        Me.lblInternetIlimitado.Name = "lblInternetIlimitado"
        Me.lblInternetIlimitado.Size = New System.Drawing.Size(156, 23)
        Me.lblInternetIlimitado.TabIndex = 21
        Me.lblInternetIlimitado.Text = "Internet Ilimitado"
        '
        'chkInternetIlimitado
        '
        Me.chkInternetIlimitado.AutoSize = True
        Me.chkInternetIlimitado.Location = New System.Drawing.Point(182, 72)
        Me.chkInternetIlimitado.Name = "chkInternetIlimitado"
        Me.chkInternetIlimitado.Size = New System.Drawing.Size(18, 17)
        Me.chkInternetIlimitado.TabIndex = 20
        Me.chkInternetIlimitado.UseVisualStyleBackColor = True
        '
        'btnComprarTiquete
        '
        Me.btnComprarTiquete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComprarTiquete.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprarTiquete.Location = New System.Drawing.Point(342, 540)
        Me.btnComprarTiquete.Name = "btnComprarTiquete"
        Me.btnComprarTiquete.Size = New System.Drawing.Size(285, 43)
        Me.btnComprarTiquete.TabIndex = 9
        Me.btnComprarTiquete.Text = "Comprar Tiquetes"
        Me.btnComprarTiquete.UseVisualStyleBackColor = True
        '
        'frmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 596)
        Me.Controls.Add(Me.btnComprarTiquete)
        Me.Controls.Add(Me.grpServiciosExtra)
        Me.Controls.Add(Me.grpMaletas)
        Me.Controls.Add(Me.grpAcompanantes)
        Me.Controls.Add(Me.grpDatosPersonales)
        Me.Name = "frmCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra de Tiquetes"
        Me.grpDatosPersonales.ResumeLayout(False)
        Me.grpDatosPersonales.PerformLayout()
        Me.grpAcompanantes.ResumeLayout(False)
        Me.grpAcompanantes.PerformLayout()
        Me.grpMaletas.ResumeLayout(False)
        Me.grpMaletas.PerformLayout()
        Me.grpServiciosExtra.ResumeLayout(False)
        Me.grpServiciosExtra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDatosPersonales As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1lblNacionalidad As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents dtpikFechaRegreso As DateTimePicker
    Friend WithEvents lblFechaRegreso As Label
    Friend WithEvents lblserviExtras As Label
    Friend WithEvents chkServiciosExtra As CheckBox
    Friend WithEvents lblMaletasExtra As Label
    Friend WithEvents chkMaletasExtra As CheckBox
    Friend WithEvents lblAcompanantes As Label
    Friend WithEvents chkAcompanantes As CheckBox
    Friend WithEvents grpAcompanantes As GroupBox
    Friend WithEvents txtCantAcompanantes As TextBox
    Friend WithEvents lblCantidadAcompanante As Label
    Friend WithEvents brnAgregarAcompanante As Button
    Friend WithEvents txtNAcionalidadAcompanante As TextBox
    Friend WithEvents lblnacionalidadAcompanante As Label
    Friend WithEvents lblCedulaAcompanante As Label
    Friend WithEvents txtCedulaAcompanante As TextBox
    Friend WithEvents txtApellidoAcompanante As TextBox
    Friend WithEvents lblApellidoAcompanante As Label
    Friend WithEvents txtNombreAcompanante As TextBox
    Friend WithEvents lblNombreAcompanante As Label
    Friend WithEvents grpMaletas As GroupBox
    Friend WithEvents txtPesoMaletasExtra As TextBox
    Friend WithEvents lblPesoMaletasExtra As Label
    Friend WithEvents txtCantidadMaletasExtra As TextBox
    Friend WithEvents lblCantidadMaletasExtra As Label
    Friend WithEvents grpServiciosExtra As GroupBox
    Friend WithEvents lblInternetIlimitado As Label
    Friend WithEvents chkInternetIlimitado As CheckBox
    Friend WithEvents lblFastTrack As Label
    Friend WithEvents chkfastTrack As CheckBox
    Friend WithEvents lblZonaLegroom As Label
    Friend WithEvents chkZonaLegron As CheckBox
    Friend WithEvents btnComprarTiquete As Button
End Class
