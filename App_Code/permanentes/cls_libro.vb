Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient


Public Class cls_libro
    Private _idlibro As Integer
    Private _titulo As String
    Private _fecha_edicion As String
    '----
    Private _query As String

    Dim miconexion As SqlConnection
    Dim micomando As SqlCommand




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
    Public Sub insertarlibro()

        miconexion = New SqlConnection("Data Source=localhost;Initial Catalog=testlibro;Integrated Security=True")
        miconexion.Open()

        _query = String.Format("EXEC [insertarLibro] '{0}','{1}'", _
                               Me.titulo, _
                               Me._fecha_edicion)
        micomando = New SqlCommand(_query)
        micomando.ExecuteNonQuery()

        miconexion.Close()

    End Sub
#End Region

End Class
