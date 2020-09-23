using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudWeb.App
    
{
    public partial class clientes : System.Web.UI.Page
    {
        DatosCrud gestionDatosCrud = new DatosCrud();
        

        protected void Page_Load(object sender, EventArgs e) 
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                    return;
                string valorTraido = Request.QueryString["id"].ToString();
                Response.Write("variable Recibida" + valorTraido);

            }
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            FormEditarCliente.Visible = false;
            TablaDatos.Visible = true;

            List<Cliente> listaClientes = gestionDatosCrud.ConsultaTodoClientes();
            TablaDatos.DataSource = listaClientes;
            TablaDatos.DataBind();
        }

        protected void TablaDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int fila = Convert.ToInt32 (e.CommandArgument);
                string valorCelda = Convert.ToString(TablaDatos.DataKeys[fila].Value);
                Codigo.Text = valorCelda;
                //Response.Redirect("Clientes.aspx?id=" + valorCelda);
            }
        }

        protected void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            FormEditarCliente.Visible = false;
            TablaDatos.Visible = true;

            List<Empleado> listaEmpleados = gestionDatosCrud.ConsultaTodoEmpleados();
            TablaDatos.DataSource = listaEmpleados;
            TablaDatos.DataBind();
        }

        //paginación tabla empleados//
        protected void TablaDatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
        //    TablaDatos.PageIndex = e.NewPageIndex;
        //    if (tablaActiva.Text == "Empleado")
        //    { 
        //        List<Empleado> listaEmpleados = gestionDatosCrud.ConsultaTodoEmpleados();
        //        TablaDatos.DataSource = listaEmpleados;
        //    }

        //    else if(tablaActiva.Text == "Cliente")
        //    {
        //        List<Cliente> listaClientes = gestionDatosCrud.ConsultaTodoClientes();
        //        TablaDatos.DataSource = listaClientes;
        //    }
        //    TablaDatos.DataBind();
        }

        protected void TxtCodigoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            Empleado empleadoEncontrado = gestionDatosCrud.ConsultaEmpleados(Codigo.Text);

            if (empleadoEncontrado != null)
            {
                txtNombre.Text = empleadoEncontrado.Nombre;
                txtApellido.Text = empleadoEncontrado.Apellido;
                txtDireccion.Text = empleadoEncontrado.Direccion;
                txtCorreo.Text = empleadoEncontrado.Correo;
                txtTelefono.Text = empleadoEncontrado.Celular;
                txtCiudad.Text = empleadoEncontrado.Ciudad;

                FormEditarCliente.Visible = true;
            }
            else {
                Cliente clienteEncontrado = gestionDatosCrud.ConsultaCliente(Codigo.Text);

                if (clienteEncontrado != null)
                {
                    txtNombre.Text = clienteEncontrado.Nombre;
                    txtApellido.Text = clienteEncontrado.Apellido;
                    txtDireccion.Text = clienteEncontrado.Direccion;
                    txtCorreo.Text = clienteEncontrado.Correo;
                    txtTelefono.Text = clienteEncontrado.Telefono;

                    FormEditarCliente.Visible = true;
                }
            }
        }

        protected void btnEditarDatos_Click(object sender, EventArgs e)
        {
            FormEditarCliente.Visible = true;
            TablaDatos.Visible = false;
        }

        protected void Codigo_TextChanged2(object sender, EventArgs e)
        {

        }
    }





}
