Public Class Acompanante


#Region "VAriables"
    Private strNombreAcom As String = String.Empty
    Private strApellidoAcom As String = String.Empty
    Private strIdentificacionAcom As String = String.Empty
    Private strNAcionalidadAcom As String = String.Empty
#End Region

#Region "Properties"
    Public Property NombreAcom1 As String
        Get
            Return strNombreAcom
        End Get
        Set(value As String)
            strNombreAcom = value
        End Set
    End Property

    Public Property ApellidoAcom1 As String
        Get
            Return strApellidoAcom
        End Get
        Set(value As String)
            strApellidoAcom = value
        End Set
    End Property

    Public Property IdentificacionAcom1 As String
        Get
            Return strIdentificacionAcom
        End Get
        Set(value As String)
            strIdentificacionAcom = value
        End Set
    End Property

    Public Property NAcionalidadAcom1 As String
        Get
            Return strNAcionalidadAcom
        End Get
        Set(value As String)
            strNAcionalidadAcom = value
        End Set
    End Property
#End Region



End Class
