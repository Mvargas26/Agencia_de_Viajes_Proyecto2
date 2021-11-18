Public Class Cliente

#Region "Variables"
    Private strNombreCliente As String = String.Empty
    Private strApellidosCliente As String = String.Empty
    Private strIdentificacionCliente As String = String.Empty
    Private strNacionalidadCliente As String = String.Empty
    Private intCantidadMaletas As Integer = 0
    Private intPesoMaleta As Integer = 0
    Private iVueloidentificador As String = String.Empty
    Private iPaisDestino As String = String.Empty
    Private iFechaSalida As String = String.Empty
    Private iHoraSalida As String = String.Empty
    Private iPrecioTiquete As Integer = 0
    Private iCantidadEspaciosDispo As Integer = 0
#End Region

#Region "Properties"
    Public Property NombreCliente As String
        Get
            Return strNombreCliente
        End Get
        Set(value As String)
            strNombreCliente = value
        End Set
    End Property

    Public Property ApellidosCliente As String
        Get
            Return strApellidosCliente
        End Get
        Set(value As String)
            strApellidosCliente = value
        End Set
    End Property

    Public Property IdentificacionCliente As String
        Get
            Return strIdentificacionCliente
        End Get
        Set(value As String)
            strIdentificacionCliente = value
        End Set
    End Property

    Public Property NacionalidadCliente As String
        Get
            Return strNacionalidadCliente
        End Get
        Set(value As String)
            strNacionalidadCliente = value
        End Set
    End Property

    Public Property CantidadMaletas As Integer
        Get
            Return intCantidadMaletas
        End Get
        Set(value As Integer)
            intCantidadMaletas = value
        End Set
    End Property

    Public Property PesoMaleta As Integer
        Get
            Return intPesoMaleta
        End Get
        Set(value As Integer)
            intPesoMaleta = value
        End Set
    End Property

    Public Property Vueloidentificador As String
        Get
            Return iVueloidentificador
        End Get
        Set(value As String)
            iVueloidentificador = value
        End Set
    End Property

    Public Property PaisDestino As String
        Get
            Return iPaisDestino
        End Get
        Set(value As String)
            iPaisDestino = value
        End Set
    End Property

    Public Property FechaSalida As String
        Get
            Return iFechaSalida
        End Get
        Set(value As String)
            iFechaSalida = value
        End Set
    End Property

    Public Property HoraSalida As String
        Get
            Return iHoraSalida
        End Get
        Set(value As String)
            iHoraSalida = value
        End Set
    End Property

    Public Property PrecioTiquete As Integer
        Get
            Return iPrecioTiquete
        End Get
        Set(value As Integer)
            iPrecioTiquete = value
        End Set
    End Property

    Public Property CantidadEspaciosDispo As Integer
        Get
            Return iCantidadEspaciosDispo
        End Get
        Set(value As Integer)
            iCantidadEspaciosDispo = value
        End Set
    End Property
#End Region


End Class
