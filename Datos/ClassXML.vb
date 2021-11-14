Imports System.Xml

Public Class ClassXML
    Public Sub GuardarArchivoXML(ByVal Archivoxml As XmlDocument, ByVal URL As String) 'metodo que solo guarda el documentoXML
        Archivoxml.Save(URL)
    End Sub


End Class
