Imports Microsoft.VisualBasic
Imports cls_libro


Public Class ctr_libro

#Region "Metodos"
    Public Sub insertarLibro(ByVal titulo As String, ByVal fecha_edicion As String)
        Dim cls As New cls_libro

        cls.titulo = titulo
        cls.fecha_edicion = fecha_edicion


    End Sub

#End Region

End Class
