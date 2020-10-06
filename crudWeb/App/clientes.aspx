<%@ Page Title="" Language="C#" MasterPageFile="~/App/pagina.Master" AutoEventWireup="true" CodeBehind="clientes.aspx.cs" Inherits="crudWeb.App.clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Mi Primer Pagina Web - Clientes</title>   
    <style type="text/css">
        .btnAccion1 {}
        .btnAccion2 {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button runat="server" Text="Listar Clientes" ID="btnListar" 
            OnClick="BtnListar_Click" Width="125px"/>
        <asp:Button runat="server" Text="Listar Empleados" ID="btnListarEmpleados" OnClick="btnListarEmpleados_Click" Width="125px" />
    </div>

    <section class="sectionClientes"><!--Etiqueta de seccion para el contenido principal-->
        <div class="sectionClientesAcciones">
             <asp:Label ID="tablaActivaLabel" CssClass="TablaActiva" runat="server" Text="Tabla activa"></asp:Label>

            <div>
                <asp:TextBox ID="Codigo" runat="server" Text="Código" OnTextChanged="Codigo_TextChanged2"></asp:TextBox>
                <asp:Button ID="btnBuscarPorCodigo" runat="server" Text="Buscar código"
                   OnClick="btnBuscarPorCodigo_Click"/>
            </div>
        </div>

        <asp:GridView CssClass="mGrid" ID="TablaDatos" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" DataKeyNames="codigo" OnRowCommand="TablaDatos_RowCommand" AllowPaging="True" OnPageIndexChanging="TablaDatos_PageIndexChanging" Width="679px" >
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:ButtonField CommandName="Select" Text="Seleccionar" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>

        <div class="sectionFormEditar" ID="FormEditarCliente" runat="server" Visible="false">
            <div class="campoEditar">
                <asp:Label ID="lblCodigo" runat="server" Text="Código:"></asp:Label>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            </div>

            <div class="campoEditar">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div> 
            
            <div class="campoEditar">
                <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </div>

            <div class="campoEditar">
                <asp:Label ID="lblDirección"  runat="server" Text="Dirección:"></asp:Label>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </div>

            <div class="campoEditar">
                <asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            </div>

            <div class="campoEditar">
                <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </div>

            <div class="campoEditar">
                <asp:Label ID="lblCiudad" runat="server" Text="Ciudad:"></asp:Label>
                <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
            </div>
        </div>

        <div> 
            <%--<asp:Button ID="btnEditarDatos" runat="server" Text="Editar Datos"
            OnClick="btnEditarDatos_Click" Width="125px" Visible="False" />--%>
            <asp:Button CssClass="btnAccion1" ID="Eliminar" runat="server" OnClick="BtnEliminar_Click" Text="Eliminar" Visible="False" Width="74px" BackColor="#CCCCCC" />
            <asp:Button CssClass="btnAccion2"  ID="Agregar" runat="server" BackColor="#CCCCCC" OnClick="BtnAgregar_Click" Text="Agregar" Visible="False" Width="75px" />
        </div>
           
        <div>
            <asp:Label CssClass="mensaje" ID="txtMensaje" runat="server" Text="Mensaje" Visible="False">
            </asp:Label>
        </div>
    </section> 
   
</asp:Content>
