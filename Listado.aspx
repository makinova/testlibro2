<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Listado.aspx.vb" Inherits="Listado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


  <div class="contenedor">
        <div class="divcompleto">
            <h2>Listado de Libros</h2>
        </div>
        <div class="divcompleto">
            <asp:GridView ID="listadoAutores" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="titulo" HeaderText="titulo" 
                        SortExpression="titulo" />
                    <asp:BoundField DataField="fecha_edicion" HeaderText="fecha_edicion" 
                        SortExpression="fecha_edicion" />
                    <asp:BoundField DataField="Autores" HeaderText="Autores" ReadOnly="True" 
                        SortExpression="Autores" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:testlibroConnectionString %>" 
                SelectCommand="listarLibrosAutores" SelectCommandType="StoredProcedure">
            </asp:SqlDataSource>
        </div>


  </div>

</asp:Content>

