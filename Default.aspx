﻿<%@ Page Title="Página principal" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="contenedor">
        <div class="divcompleto"><h2>Libros</h2>
        <p>Agregar/Editar</p>
        </div>
        <div class="divmitad">
        <h2>  </h2>
            <div class="divmitad"><span>Titulo</span></div>
            <div class="divmitad"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
            
            <div class="divmitad" style="margin-top:10px;"><span>Edicion</span></div>
            <div class="divmitad" style="margin-top:10px;">
                <asp:TextBox ID="txt_edicion" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:Calendar ID="calendario" runat="server"></asp:Calendar>
            </div>
        </div>
        <div class="divmitad">
            <h2>Lista de Autores</h2>
        </div>
        <div class="divcompleto">
            <div class="divmitad">
                <asp:Button ID="btn_guardar" runat="server" Text="Guardar" />
            </div>
            <div class="divmitad">
                <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" />
            </div>
        </div>
   </div>
</asp:Content>