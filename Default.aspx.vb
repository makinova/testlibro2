
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub calendario_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calendario.SelectionChanged
        Me.txt_edicion.Text = calendario.SelectedDate.ToShortDateString()
    End Sub
End Class
