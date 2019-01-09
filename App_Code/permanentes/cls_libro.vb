Imports Microsoft.VisualBasic

Public Class cls_libro
    Private _idlibro As Integer
    Private _titulo As String
    Private _fecha_edicion As String
    '----
    Private _query As String


#Region "Propiedades"
    Public ReadOnly Property idLibro() As Integer
        Get
            Return Me._idlibro
        End Get
    End Property
    Public Property titulo() As String
        Get
            Return Me._titulo

        End Get
        Set(ByVal value As String)
            Me._titulo = value
        End Set
    End Property
    Public Property fecha_edicion() As String
        Get
            Return Me._fecha_edicion

        End Get
        Set(ByVal value As String)
            Me._fecha_edicion = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function insertarlibro() As UInteger
        _query = String.Format("EXEC [insertarLibro] '{0}','{1}'", _
                               Me.titulo, _
                               Me._fecha_edicion)
        Me._idlibro = 
    End Function
#End Region

End Class
