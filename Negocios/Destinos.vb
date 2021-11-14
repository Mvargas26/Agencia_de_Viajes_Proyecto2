Public Class Destinos

#Region "Variables"
    Private iVueloidentificador As String = String.Empty
    Private iPaisDestino As String = String.Empty
    Private iFechaSalida As String = String.Empty
    Private iHoraSalida As String = String.Empty
    Private iPrecioTiquete As Integer = 0
    Private iCantidadEspaciosDispo As Integer = 0

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

#Region "Properties"

#End Region

End Class
