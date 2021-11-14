Imports Datos
Imports System.Xml
Public Class OPERACIONES
    Public Sub AlmacenaXMLDestinos(ByVal URL As String, ByVal ListaDestinos As List(Of Destinos))
        Dim XMLDestinos As New XmlDocument

        Dim NodoPadre As XmlNode = XMLDestinos.CreateElement("Destinos")
        XMLDestinos.AppendChild(NodoPadre)

        For Each iDest As Destinos In ListaDestinos
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






End Class
