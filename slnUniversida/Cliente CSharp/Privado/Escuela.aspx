<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Escuela.aspx.cs" Inherits="Cliente_CSharp.Escuela" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Consultas a la tabla Escuela</h1>
    <br />
    <p>Consultar: <asp:TextBox runat="server" Id="txtTexto"/>
        <asp:DropDownList runat="server" ID="ddlCriterio">
            <asp:ListItem Text="CodEscuela"/>
            <asp:ListItem Text="Escuela"/>
        </asp:DropDownList>
        <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" />
        </p>
    <p>
        <asp:GridView runat="server" ID="gvEscuela" OnSelectedIndexChanged="gvEscuela_SelectedIndexChanged">
            </asp:GridView>
    </p>
      <p>codEscuela: <asp:TextBox runat="server" Id="TextBox3"/>
      <p>Escuela: <asp:TextBox runat="server" Id="TextBox4"/>
       <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" />
        <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" />
          <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click"  />
          
</asp:Content>
