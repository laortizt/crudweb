<%@ Page Title="" Language="C#" MasterPageFile="~/App/pagina.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="crudWeb.App.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title>Mi Primer Pagina Web - Inicio</title> <!--Etiqueta de titulo--> 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="seccion"> <!--Etiqueta de seccion para el contenido principal-->
        <article>  <!--Etiqueta de articulo, fecha, parrafo -->
        <h2 class="titInicio">Titulo Primer Articulo </h2>
       <time datetime="08-09-2020">Publicado 08-09-2020 </time> <!--Etiqueta de fecha -->
            <!--Etiqueta de parrafo y texto de prueba-->
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. 
            Tempora eligendi autem illo nobis minima quo facilis adipisci provident deleniti, vel, mollitia
            nihil numquam Soluta quasi blanditiis provident suscipit ab perspiciatis ipsum aliquid voluptatibus 
            temporibus recusandae magni, voluptates delectus officia,libero molestiae atque ducimus? Facilis
            quod rem dolorem nam impedit. Tempora eligendi molestiae  commodi. 

            Adipisci fuga voluptatum blanditiis temporibus voluptatibus eos et assumenda similique a 
            doloribus, unde rem? Cumque dolor unde autem cum corrupti ad. Ab officia esse consequuntur minus 
            assumenda voluptates nemo temporibus inventore eaque rem quaerat, delectus quibusdam neque omnis 
            quidem. Repudiandae doloremque quae alias odit! Cupiditate voluptates qui aliquam saepe eligendi?
            Adipisci fuga voluptatum blanditiis temporibus voluptatibus eos et assumenda similique a 
            doloribus, unde rem? Cumque dolor unde autem cum corrupti ad. Ab officia esse consequuntur minus 
            assumenda voluptates nemo temporibus inventore eaque rem quaerat, delectus quibusdam neque omnis 
            quidem. Repudiandae doloremque quae alias odit! Cupiditate voluptates qui aliquam saepe eligendi?
            consequatur dolores ab deserunt, earum minus dicta!
        </p> 
         
        </article>
    </section>
            <!--Etiqueta HIPER ENLACE para enviar a otro enlace" -->
    <aside class="columna"> <!--Etiqueta de conenido "no tan importante" -->
        <blockquote cite="https://www.youtube.com/watch?v=rbuYtrNUxg4">  <!--Etiqueta para referenciar contenido -->
           <p>LooK BoocK</p> 
        </blockquote>

        <blockquote cite="https://www.youtube.com/watch?v=rbuYtrNUxg4">  <!--Etiqueta para referenciar contenido -->
            <img class="image2" src="image/OHT9200.jpg" width="280"/>
             <a href="https://www.youtube.com/watch?v=rbuYtrNUxg4">Visita el video tutorial donde aprendí </a> 
            <p>Comentarios (0) </p>
        </blockquote>
    </aside>
</asp:Content>

