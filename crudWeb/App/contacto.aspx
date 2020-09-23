<%@ Page Title="" Language="C#" MasterPageFile="~/App/pagina.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="crudWeb.App.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Mi Primer Pagina Web - Contacto</title>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section> <!--Etiqueta de seccion para el contenido principal-->
            <article class="articuloContacto">  <!--Etiqueta de articulo, fecha, parrafo -->
            <h2>Información de Contacto </h2>
            <p>
            Empieza escribiendo un texto que te describa. Debe ser persuasivo y atractivo, dinámico y creativo.
            <img class="imageMap" src="image/mapanav.png" width="500"/> 
            </p> <!--Etiqueta de parrafo y texto de prueba-->
            
            </article>
           
     </section>
</asp:Content>

