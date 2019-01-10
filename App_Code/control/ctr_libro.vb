Imports Microsoft.VisualBasic
Imports cls_libro


Public Class ctr_libro

#Region "Metodos"
    Public Sub insertarLibro(ByVal titulo As String, ByVal fecha_edicion As String, ByVal autores As CheckBoxList)
        Dim cls As New cls_libro
        Dim cls2 As New cls_autorlibro

        Dim idlibro As Integer

        cls.titulo = titulo
        cls.fecha_edicion = fecha_edicion
        cls2.lista_autores = autores


        idlibro = cls.insertarlibro()
        cls2.insertarautorlibro(idlibro)


    End Sub

#End Region

End Class
