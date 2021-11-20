Imports System.Xml

Public Class ClassXML
    Public Sub GuardarArchivoXML(ByVal Archivoxml As XmlDocument, ByVal URL As String) 'metodo que solo guarda el documentoXML
        Archivoxml.Save(URL)
    End Sub


    Public Function LeerArchivoXML(ByVal URL As String) 'leemos como documento XML el archivo
        Dim LectorEnDatos As New XmlDocument

        LectorEnDatos.Load(URL)


        Return LectorEnDatos
    End Function
End Class
