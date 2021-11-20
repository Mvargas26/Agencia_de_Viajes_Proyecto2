
Imports Datos
Imports System.Xml
Imports System.IO
Public Class OPERACIONES

#Region "Variables"
    Private strNombreCliente As String = String.Empty
    Private strApellidosCliente As String = String.Empty
    Private intIdentificacionCliente As Integer = 0
    Private strNacionalidadCliente As String = String.Empty

    Private intValorMaletasExtra As Integer = 0
    Private intPesoMaleta As Integer = 0

    Private iVueloidentificador As String = String.Empty
    Private iPaisDestino As String = String.Empty
    Private iFechaSalida As String = String.Empty
    Private iFechaRegreso As String = String.Empty
    Private iHoraSalida As String = String.Empty
    Private iPrecioTiquete As Integer = 0
    Private iCantidaddias As Integer = 0
    Private icantAcompanantes As Integer = 0
    Private idescuento As Decimal = 0
    Private iextrasZonaPrefe As Decimal = 0
    Private iextraZonaLegrom As Integer = 0
    Private iextraInternet As Decimal = 0
    Private iextrafasttrack As Decimal = 0

    Private strNombreAcompanante As String = String.Empty
    Private strApellidosAcompanante As String = String.Empty
    Private intIdentificacionAcompanante As Integer = 0
    Private strNacionalidadAcompanante As String = String.Empty


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

    Public Property IdentificacionCliente As Integer
        Get
            Return intIdentificacionCliente
        End Get
        Set(value As Integer)
            intIdentificacionCliente = value
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

    Public Property FechaRegreso As String
        Get
            Return iFechaRegreso
        End Get
        Set(value As String)
            iFechaRegreso = value
        End Set
    End Property

    Public Property NombreAcompanante As String
        Get
            Return strNombreAcompanante
        End Get
        Set(value As String)
            strNombreAcompanante = value
        End Set
    End Property

    Public Property ApellidosAcompanante As String
        Get
            Return strApellidosAcompanante
        End Get
        Set(value As String)
            strApellidosAcompanante = value
        End Set
    End Property

    Public Property IdentificacionAcompanante As Integer
        Get
            Return intIdentificacionAcompanante
        End Get
        Set(value As Integer)
            intIdentificacionAcompanante = value
        End Set
    End Property

    Public Property NacionalidadAcompanante As String
        Get
            Return strNacionalidadAcompanante
        End Get
        Set(value As String)
            strNacionalidadAcompanante = value
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

        If extrafasttrack <> 0 Then 'sumamos un 5% si seleccionaron fast track
            precioFinal += extrafasttrack
        End If

        Return precioFinal
    End Function

    Public Sub AlmacenaXML(ByVal URL As String, ByVal ListaBoletos As List(Of OPERACIONES))
        Try

            Dim XMLBoletoComprado As New XmlDocument

            Dim NodoPadre As XmlNode = XMLBoletoComprado.CreateElement("Boletos")
            XMLBoletoComprado.AppendChild(NodoPadre)

            For Each iBoleto As OPERACIONES In ListaBoletos
                Dim nodoDetalles As XmlNode = XMLBoletoComprado.CreateElement("Detalles")

                With nodoDetalles
                    Dim nodoInfo As XmlNode = XMLBoletoComprado.CreateElement("Identificacion_Cliente")
                    nodoInfo.InnerText = iBoleto.IdentificacionCliente
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Identificador_Vuelo")
                    nodoInfo.InnerText = iBoleto.Vueloidentificador
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Nombre_Cliente")
                    nodoInfo.InnerText = iBoleto.NombreCliente
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Apellidos_Cliente")
                    nodoInfo.InnerText = iBoleto.ApellidosCliente
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Nacionalidad_Cliente")
                    nodoInfo.InnerText = iBoleto.NacionalidadCliente
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Pais_Destino")
                    nodoInfo.InnerText = iBoleto.PaisDestino
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Fecha_Salida")
                    nodoInfo.InnerText = iBoleto.FechaSalida
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Fecha_Regreso")
                    nodoInfo.InnerText = iBoleto.FechaRegreso
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Hora_Salida")
                    nodoInfo.InnerText = iBoleto.HoraSalida
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Cantidad_Dias")
                    nodoInfo.InnerText = iBoleto.Cantidaddias
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Cantidad_Acompanantes")
                    nodoInfo.InnerText = iBoleto.CantAcompanantes
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Nombre_Acompanante")
                    nodoInfo.InnerText = iBoleto.NombreAcompanante
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Apellido_Acompanante")
                    nodoInfo.InnerText = iBoleto.ApellidosAcompanante
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Identif_Acompanante")
                    nodoInfo.InnerText = iBoleto.IdentificacionAcompanante
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Nacionalidad_Acompanante")
                    nodoInfo.InnerText = iBoleto.NacionalidadAcompanante
                    .AppendChild(nodoInfo)

                    nodoInfo = XMLBoletoComprado.CreateElement("Precio_Tiquete")
                    nodoInfo.InnerText = iBoleto.PrecioTiquete
                    .AppendChild(nodoInfo)


                    .AppendChild(nodoInfo)
                End With

                NodoPadre.AppendChild(nodoDetalles)
            Next

            Dim iArchivoXML As New ClassXML
            iArchivoXML.GuardarArchivoXML(XMLBoletoComprado, URL)

        Catch ex As Exception
            Console.Write("Error al crear el xml en Negocios-Operaciones")
        End Try
    End Sub


    Public Function LeerXML(ByVal URL As String) As ArrayList
        Try
            Dim InfoClienteCargada As New ArrayList

            Dim aNombreCliente, aApellidosCliente, aIdentificacionCliente, aNacionalidadCliente, aValorMaletasExtra,
             aPesoMaleta, aVueloidentificador, aPaisDestino, aFechaSalida, aFechaRegreso, aHoraSalida,
                 aPrecioTiquete, aCantidaddias, acantAcompanantes, aNombreAcompanante, aApellidosAcompanante,
                 aIdentificacionAcompanante, aNacionalidadAcompanante, lineaLeida As String

            Dim objDatos As New ClassXML
            Dim DocumentEnCliente As New XmlDocument

            DocumentEnCliente = objDatos.LeerArchivoXML(URL)
            Dim Nodo As XmlNode = DocumentEnCliente.DocumentElement

            For Each info2 As XmlElement In Nodo
                For Each info As XmlElement In info2
                    If info.Name = "Identificacion_Cliente" Then
                        aIdentificacionCliente = info.InnerText
                    End If
                    If info.Name = "Identificador_Vuelo" Then
                        aVueloidentificador = info.InnerText
                    End If
                    If info.Name = "Nombre_Cliente" Then
                        aNombreCliente = info.InnerText
                    End If
                    If info.Name = "Apellidos_Cliente" Then
                        aApellidosCliente = info.InnerText
                    End If
                    If info.Name = "Nacionalidad_Cliente" Then
                        aNacionalidadCliente = info.InnerText
                    End If
                    If info.Name = "Pais_Destino" Then
                        aPaisDestino = info.InnerText
                    End If
                    If info.Name = "Fecha_Salida" Then
                        aFechaSalida = info.InnerText.Trim
                    End If
                    If info.Name = "Fecha_Regreso" Then
                        aFechaRegreso = info.InnerText.Trim
                    End If
                    If info.Name = "Hora_Salida" Then
                        aHoraSalida = info.InnerText.Trim
                    End If
                    If info.Name = "Cantidad_Dias" Then
                        aCantidaddias = info.InnerText
                    End If
                    If info.Name = "Cantidad_Acompanantes" Then
                        acantAcompanantes = info.InnerText
                    End If
                    If info.Name = "Nombre_Acompanante" Then
                        If info.InnerText = "" Then
                            aNombreAcompanante = "No indicado"
                        Else
                            aNombreAcompanante = info.InnerText
                        End If

                    End If
                    If info.Name = "Apellido_Acompanante" Then
                        If info.InnerText = "" Then
                            aApellidosAcompanante = "No indicado"
                        Else
                            aApellidosAcompanante = info.InnerText
                        End If

                    End If
                    If info.Name = "Identif_Acompanante" Then
                        If info.InnerText = "" Then
                            aIdentificacionAcompanante = "No indicado"
                        Else
                            aIdentificacionAcompanante = info.InnerText
                        End If

                    End If
                    If info.Name = "Nacionalidad_Acompanante" Then
                        If info.InnerText = "" Then
                            aNacionalidadAcompanante = "No indicada"
                        Else
                            aNacionalidadAcompanante = info.InnerText
                        End If

                    End If
                    If info.Name = "Precio_Tiquete" Then
                        aPrecioTiquete = info.InnerText
                        lineaLeida = aIdentificacionCliente + "#" + aVueloidentificador + "#" + aNombreCliente + "#" + aApellidosCliente + "#" + aNacionalidadCliente + "#" +
                            aPaisDestino + "#" + aFechaSalida + "#" + aFechaRegreso + "#" + aHoraSalida + "#" + aCantidaddias + "#" + acantAcompanantes + "#" +
                             aNombreAcompanante + "#" + aApellidosAcompanante + "#" + aIdentificacionAcompanante + "#" + aNacionalidadAcompanante + "#" + aPrecioTiquete

                        Dim vecValores() As String = lineaLeida.Split("#")

                        InfoClienteCargada.Add(vecValores)

                    End If

                Next
            Next

            Return InfoClienteCargada


        Catch ex As Exception
            Throw New Exception("Error al leer el archivo XML en negocios, cliente")
        End Try

    End Function
#End Region




End Class
