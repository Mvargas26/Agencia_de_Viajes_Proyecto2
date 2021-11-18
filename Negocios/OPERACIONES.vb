
Imports Datos
Imports System.Xml
Public Class OPERACIONES

#Region "Variables"
    Private strNombreCliente As String = String.Empty
    Private strApellidosCliente As String = String.Empty
    Private strIdentificacionCliente As String = String.Empty
    Private strNacionalidadCliente As String = String.Empty

    Private intValorMaletasExtra As Integer = 0
    Private intPesoMaleta As Integer = 0

    Private iVueloidentificador As String = String.Empty
    Private iPaisDestino As String = String.Empty
    Private iFechaSalida As String = String.Empty
    Private iHoraSalida As String = String.Empty
    Private iPrecioTiquete As Integer = 0
    Private iCantidaddias As Integer = 0
    Private icantAcompanantes As Integer = 0
    Private idescuento As Decimal = 0
    Private iextrasZonaPrefe As Decimal = 0
    Private iextraZonaLegrom As Integer = 0
    Private iextraInternet As Decimal = 0
    Private iextrafasttrack As Decimal = 0


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

    Public Property ValorMaletasExtra As Integer
        Get
            Return intValorMaletasExtra
        End Get
        Set(value As Integer)
            intValorMaletasExtra = value
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

    Public Property Cantidaddias As Integer
        Get
            Return iCantidaddias
        End Get
        Set(value As Integer)
            iCantidaddias = value
        End Set
    End Property

    Public Property CantAcompanantes As Integer
        Get
            Return icantAcompanantes
        End Get
        Set(value As Integer)
            icantAcompanantes = value
        End Set
    End Property

    Public Property descuento As Decimal
        Get
            Return idescuento
        End Get
        Set(value As Decimal)
            idescuento = value
        End Set
    End Property

    Public Property extrasZonaPrefe As Decimal
        Get
            Return iextrasZonaPrefe
        End Get
        Set(value As Decimal)
            iextrasZonaPrefe = value
        End Set
    End Property

    Public Property extraInternet As Integer
        Get
            Return iextraInternet
        End Get
        Set(value As Integer)
            iextraInternet = value
        End Set
    End Property

    Public Property extraZonaLegrom As Integer
        Get
            Return iextraZonaLegrom
        End Get
        Set(value As Integer)
            iextraZonaLegrom = value
        End Set
    End Property

    Public Property extrafasttrack As Decimal
        Get
            Return iextrafasttrack
        End Get
        Set(value As Decimal)
            iextrafasttrack = value
        End Set
    End Property
#End Region



#Region "Metodos"


    Public Function calculoPrecioBoleto() As Integer

        Dim precioFinal As Integer = PrecioTiquete

        precioFinal -= (precioFinal * descuento) 'aplicamos el descuento

        precioFinal += ValorMaletasExtra  'sumamos el costo por maleta extra

        If extrasZonaPrefe <> 0 Then ' sumamos impuesto por zona preferencial
            precioFinal += (precioFinal * extrasZonaPrefe)
        End If

        If extraZonaLegrom > 0 Then 'sumamos los 10 dolares por zona legroom si fue elegida
            precioFinal += extraZonaLegrom
        End If

        If extraInternet <> 0 Then 'sumamos 4% si desean internet ilimitado 
            precioFinal += extraInternet
        End If

        Return precioFinal
    End Function

    Public Sub AlmacenaXMLDestinos(ByVal URL As String, ByVal ListaDestinos As List(Of Cliente))
        Dim XMLDestinos As New XmlDocument

        Dim NodoPadre As XmlNode = XMLDestinos.CreateElement("Destinos")
        XMLDestinos.AppendChild(NodoPadre)

        For Each iDest As Cliente In ListaDestinos
            Dim nodoDetalles As XmlNode = XMLDestinos.CreateElement("Detalles")

            With nodoDetalles
                Dim nodoInfo As XmlNode = XMLDestinos.CreateElement("Identificador_Vuelo")
                nodoInfo.InnerText = iDest.Vueloidentificador
                .AppendChild(nodoInfo)

                nodoInfo = XMLDestinos.CreateElement("Pais_Destino")
                nodoInfo.InnerText = iDest.PaisDestino
                .AppendChild(nodoInfo)

                nodoInfo = XMLDestinos.CreateElement("Fecha_Salida")
                nodoInfo.InnerText = iDest.FechaSalida
                .AppendChild(nodoInfo)

                nodoInfo = XMLDestinos.CreateElement("Hora_Salida")
                nodoInfo.InnerText = iDest.HoraSalida
                .AppendChild(nodoInfo)

                nodoInfo = XMLDestinos.CreateElement("Precio_Tiquete")
                nodoInfo.InnerText = iDest.PrecioTiquete
                .AppendChild(nodoInfo)

                nodoInfo = XMLDestinos.CreateElement("Espacios_Disponibles")
                nodoInfo.InnerText = iDest.CantidadEspaciosDispo
                .AppendChild(nodoInfo)
            End With

            NodoPadre.AppendChild(nodoDetalles)
        Next

        Dim iArchivoXML As New ClassXML
        iArchivoXML.GuardarArchivoXML(XMLDestinos, URL)
    End Sub

#End Region




End Class
