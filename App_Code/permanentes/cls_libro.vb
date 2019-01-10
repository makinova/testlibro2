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
    Dim mireader As SqlDataReader


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

        miconexion = New SqlConnection("Data Source=localhost;Initial Catalog=testlibro;Integrated Security=True")
        miconexion.Open()

        _query = String.Format("DECLARE @id float EXEC [insertarLibro] '{0}','{1}',{2}", _
                               Me.titulo, _
                               Me._fecha_edicion, _
                               "@idLibro=@id OUTPUT")
        micomando = New SqlCommand(_query, miconexion)
        'micomando.ExecuteNonQuery()
        mireader = micomando.ExecuteReader()
        While mireader.Read()
            Me._idlibro = mireader("idLibro")
        End While
        mireader.Close()
        miconexion.Close()

        Return _idlibro
    End Function
#End Region

End Class
