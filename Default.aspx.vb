
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub calendario_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calendario.SelectionChanged
        Me.txt_edicion.Text = calendario.SelectedDate.ToShortDateString()
    End Sub

    Protected Sub btn_guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim ctr As New ctr_libro
        Dim libro As String = Me.txt_titulo.Text
        Dim edicion As String = Me.txt_edicion.Text
        Dim listado As CheckBoxList = Me.cbx_autores

        ctr.insertarLibro(libro, edicion, listado)

        Response.Redirect("Listado.aspx")


    End Sub
End Class
