<%@ Page Title="" Language="C#" MasterPageFile="~/App/pagina.Master" AutoEventWireup="true" CodeBehind="clientes.aspx.cs" Inherits="crudWeb.App.clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Mi Primer Pagina Web - Clientes</title>   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" Text="Listar Clientes" ID="btnListar" 
        OnClick="BtnListar_Click" Width="125px"/>
    <asp:Button runat="server" Text="Listar Empleados" ID="btnListarEmpleados" OnClick="btnListarEmpleados_Click" Width="125px" />
    <asp:Button ID="btnEditarDatos" runat="server" Text="Editar Datos"
        OnClick="btnEditarDatos_Click" Width="125px" />


    <section class="sectionClientes"> <!--Etiqueta de seccion para el contenido principal-->
       <div>
           <asp:TextBox ID="Codigo" runat="server" Text="Código" OnTextChanged="Codigo_TextChanged2"></asp:TextBox>
           <asp:Button ID="btnBuscarPorCodigo" runat="server" Text="Buscar código"
               OnClick="btnBuscarPorCodigo_Click"/>
       </div>

        <asp:GridView CssClass="mGrid" ID="TablaDatos" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" DataKeyNames="codigo" OnRowCommand="TablaDatos_RowCommand" AllowPaging="True" OnPageIndexChanging="TablaDatos_PageIndexChanging">
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
     </section>

    <section class="sectionEditarCliente">
        <div ID="FormEditarCliente" runat="server" Visible="false">
            <div> <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label></div> 
            <div><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></div> 
            
            <div><asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label></div>
            <div><asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></div>
          
            <div><asp:Label ID="lblDirección"  runat="server" Text="Dirección:"></asp:Label></div>
            <div><asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox></div>
          
            <div><asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label></div>
            <div><asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox></div>
           
            <div><asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label></div>
            <div><asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></div>
          
            <div><asp:Label ID="lblCiudad" runat="server" Text="Ciudad:"></asp:Label></div>
            <div><asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox></div>
       </div>
    </section> 
</asp:Content>
