Public Class Cliente

#Region "Variables"
    Private strNombreCliente As String = String.Empty
    Private strApellidosCliente As String = String.Empty
    Private strIdentificacionCliente As String = String.Empty
    Private strNacionalidadCliente As String = String.Empty
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
#End Region


End Class
