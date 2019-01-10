Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class cls_autorlibro
    Private _idautor As Integer
    Private _idlibro As Integer
    Private _lista_autores As CheckBoxList

    '----
    Private _query As String

    Dim miconexion As SqlConnection
    Dim micomando As SqlCommand
    Dim mireader As SqlDataReader

#Region "Propiedades"
    Public Property lista_autores() As CheckBoxList
        Get
            Return Me._lista_autores

        End Get
        Set(ByVal value As CheckBoxList)
            Me._lista_autores = value
        End Set
    End Property

    Public Property idautor() As UInteger
        Get
            Return Me._idautor

        End Get
        Set(ByVal value As UInteger)
            Me._idautor = value
        End Set
    End Property

    Public Property idlibro() As UInteger
        Get
            Return Me._idlibro
        End Get
        Set(ByVal value As UInteger)
            Me._idlibro = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function insertarautorlibro(ByVal _idlibro As UInteger) As UInteger

        miconexion = New SqlConnection("Data Source=localhost;Initial Catalog=testlibro;Integrated Security=True")


        _query = String.Format(" EXEC [insertarAutorLibro] {0},{1},{2}", _
                               "@idAutor", _
                               _idlibro,
                               "@isSelected")
        micomando = New SqlCommand()
        micomando.CommandText = _query
        micomando.Connection = miconexion
        miconexion.Open()
        For Each item As ListItem In Me.lista_autores.Items
            micomando.Parameters.Clear()
            micomando.Parameters.AddWithValue("@isSelected", item.Selected)
            micomando.Parameters.AddWithValue("@idAutor", item.Value)
            micomando.ExecuteNonQuery()
        Next
        miconexion.Close()

        Return _idlibro
    End Function
#End Region
End Class
