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
        //Botones de acción
        protected void BtnListar_Click(object sender, EventArgs e)
        {
            
            txtMensaje.Visible = false;        
            Eliminar.Visible = false;
            Agregar.Visible = false;
            FormEditarCliente.Visible = false;
            TablaDatos.Visible = true;
            TablaDatos.SelectedIndex = -1;

            List<Cliente> listaClientes = gestionDatosCrud.ConsultaTodoClientes();
            TablaDatos.DataSource = listaClientes;
            TablaDatos.DataBind();

            tablaActivaLabel.Text = "cliente";
        }
        protected void btnListarEmpleados_Click(object sender, EventArgs e)
        {   
            txtMensaje.Visible = false;
            Eliminar.Visible = false;
            Agregar.Visible = false;
            FormEditarCliente.Visible = false;
            TablaDatos.Visible = true;
            TablaDatos.SelectedIndex = -1;

            List<Empleado> listaEmpleados = gestionDatosCrud.ConsultaTodoEmpleados();
            TablaDatos.DataSource = listaEmpleados;
            TablaDatos.DataBind();

            tablaActivaLabel.Text = "empleado";
        }
        protected void btnBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            if (tablaActivaLabel.Text == "empleado")
            {
                cargarEmpleado(Codigo.Text);
            }
            else if (tablaActivaLabel.Text == "cliente")
            {
                cargarCliente(Codigo.Text);
            }

            FormEditarCliente.Visible = true;
            TablaDatos.Visible = false;

        }

        protected void btnEditarDatos_Click(object sender, EventArgs e)
        {
            FormEditarCliente.Visible = true;
            Eliminar.Visible = true;
            Agregar.Visible = true;
            txtMensaje.Visible = true;
           TablaDatos.Visible = false;
        }
        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaActivaLabel.Text == "empleado")
            {
                if (gestionDatosCrud.EliminarEmpleado(Codigo.Text))
                {
                    txtMensaje.Text = "El empleado #" + Codigo.Text + " fue eliminado exitósamente.";
                }
                else
                {
                    txtMensaje.Text = "Ocurrió un error: " + gestionDatosCrud.error;
                }
            }
            else if (tablaActivaLabel.Text == "cliente")
            {
                if (gestionDatosCrud.EliminarCliente(Codigo.Text))
                {
                    txtMensaje.Text = "El cliente #" + Codigo.Text + " fue eliminado exitósamente.";
                }
                else
                {
                    txtMensaje.Text = "Ocurrió un error: " + gestionDatosCrud.error;
                }
            }

        }
        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            if (tablaActivaLabel.Text == "cliente")
            {
                if (!gestionDatosCrud.ExisteCliente(txtCodigo.Text))
                {
                    Cliente miCliente = new Cliente();
                    miCliente.Codigo = txtCodigo.Text;
                    miCliente.Nombre = txtNombre.Text;
                    miCliente.Apellido = txtApellido.Text;
                    miCliente.Direccion = txtDireccion.Text;
                    miCliente.Telefono = txtTelefono.Text;
                    miCliente.Correo = txtCorreo.Text;

                    if (gestionDatosCrud.AgregarCLiente(miCliente))
                    {
                        txtMensaje.Text = "Se agrego Cliente con Éxito";
                    }
                    else 
                    {
                        txtMensaje.Text = "Ocurrio un error al agregar" + gestionDatosCrud.error;
                    }

                }
            }

            else if (tablaActivaLabel.Text == "empleado")

                if (!gestionDatosCrud.ExisteEmpleado(txtCodigo.Text))
                {
                    Empleado miEmpleado = new Empleado();
                    miEmpleado.Codigo = txtCodigo.Text;
                    miEmpleado.Nombre = txtNombre.Text;
                    miEmpleado.Apellido = txtApellido.Text;
                    miEmpleado.Direccion = txtDireccion.Text;
                    miEmpleado.Celular = txtTelefono.Text;
                    miEmpleado.Correo = txtCorreo.Text;
                    miEmpleado.Ciudad = txtCiudad.Text;


                    if (gestionDatosCrud.AgregarEmpleado(miEmpleado))
                    {
                        txtMensaje.Text = "Se agrego Empleado con Éxito";
                    }
                    else
                    {
                        txtMensaje.Text = "Ocurrio un error al agregar" + gestionDatosCrud.error;
                    }

                }


        }
       
        //Tablas//
        protected void TablaDatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            TablaDatos.PageIndex = e.NewPageIndex;

            if (tablaActivaLabel.Text == "empleado")
            {
                List<Empleado> listaEmpleados = gestionDatosCrud.ConsultaTodoEmpleados();
                TablaDatos.DataSource = listaEmpleados;
            }
            else if (tablaActivaLabel.Text == "cliente")
            {
                List<Cliente> listaClientes = gestionDatosCrud.ConsultaTodoClientes();
                TablaDatos.DataSource = listaClientes;
            }
            TablaDatos.DataBind();
        }
        protected void TablaDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int fila = Convert.ToInt32(e.CommandArgument);
                string valorCelda = Convert.ToString(TablaDatos.DataKeys[fila].Value);
                Codigo.Text = valorCelda;

                if (tablaActivaLabel.Text == "empleado")
                {
                    cargarEmpleado(valorCelda);
                }
                else if (tablaActivaLabel.Text == "cliente")
                {
                    cargarCliente(valorCelda);
                }

                FormEditarCliente.Visible = true;
                TablaDatos.Visible = false;
            }
        }
        protected void TxtCodigoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        //Métodos//
        
        protected void Codigo_TextChanged2(object sender, EventArgs e)
        {

        }
        private void cargarEmpleado(string codigo)
        {
            Empleado miEmpleado = gestionDatosCrud.ConsultaEmpleados(codigo);

            if (miEmpleado != null)
            {
                txtCodigo.Text = miEmpleado.Codigo;
                txtNombre.Text = miEmpleado.Nombre;
                txtApellido.Text = miEmpleado.Apellido;
                txtDireccion.Text = miEmpleado.Direccion;
                txtCorreo.Text = miEmpleado.Correo;
                txtTelefono.Text = miEmpleado.Celular;
                txtCiudad.Text = miEmpleado.Ciudad;
            }
            else
            {
                limpiarCamposEditar();
            }

            //txtCiudad.Enabled = true; es necesario?
        }
        private void cargarCliente(string codigo)
        {
            Cliente miCliente = gestionDatosCrud.ConsultaCliente(codigo);

            if (miCliente != null)
            {
                txtCodigo.Text = miCliente.Codigo;
                txtNombre.Text = miCliente.Nombre;
                txtApellido.Text = miCliente.Apellido;
                txtDireccion.Text = miCliente.Direccion;
                txtCorreo.Text = miCliente.Correo;
                txtTelefono.Text = miCliente.Telefono;
                txtCiudad.Text = "";
            }
            else
            {
                limpiarCamposEditar();
            }

            txtCiudad.Enabled = false;
        }
        private void limpiarCamposEditar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtCiudad.Text = "";
        }
    }
}
