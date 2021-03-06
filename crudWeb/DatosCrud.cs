﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data.SqlClient;
using crudWeb.App;

namespace crudWeb
{
    public class DatosCrud
    {
        public MySqlConnection conexion;
        public string error;
        public DatosCrud()
        {
            conexion = ConexionMySql.GetConexion();
        }
        public List<Empleado> ConsultaTodoEmpleados()
        {
            List<Empleado> todosLosEmpleados = new List<Empleado>();
            string sql = "select * from empleados";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            MySqlDataReader resultado = cmd.ExecuteReader();
            while (resultado.Read())
            {
              Empleado nuevoEmpleado = new Empleado();
              nuevoEmpleado.Codigo = resultado.GetString(1);
              nuevoEmpleado.Nombre = resultado.GetString(2);
              nuevoEmpleado.Apellido = resultado.GetString(3);
              nuevoEmpleado.Correo = resultado.GetString(4);
              nuevoEmpleado.Celular = resultado.GetString(5);
              nuevoEmpleado.Direccion = resultado.GetString(6);
              nuevoEmpleado.Ciudad = resultado.GetString(7);
              todosLosEmpleados.Add(nuevoEmpleado);
            }
              resultado.Close();
              return todosLosEmpleados; 
        }
        public List<Cliente> ConsultaTodoClientes()
        {
            List<Cliente> todosLosClientes = new List<Cliente>();
            string sql = "select * from clientes";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            MySqlDataReader resultado = cmd.ExecuteReader();
            
            while (resultado.Read()) 
            {
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.Codigo = resultado.GetString(1);
                nuevoCliente.Nombre = resultado.GetString(2);
                nuevoCliente.Apellido = resultado.GetString(3);
                nuevoCliente.Direccion = resultado.GetString(4);
                nuevoCliente.Telefono = resultado.GetString(5);
                nuevoCliente.Correo = resultado.GetString(6);
                todosLosClientes.Add(nuevoCliente);
            }
            resultado.Close();
            return todosLosClientes;
        }
        public Empleado ConsultaEmpleados(string codigo)
        {
            string sql =("select * from empleados where codigo = @codigo");
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader resultado = cmd.ExecuteReader();
            if (resultado.Read())
            {
                Empleado nuevoEmpleado = new Empleado();
                nuevoEmpleado.Nombre = resultado.GetString(2);
                nuevoEmpleado.Apellido = resultado.GetString(3);
                nuevoEmpleado.Correo = resultado.GetString(4);
                nuevoEmpleado.Celular = resultado.GetString(5);
                nuevoEmpleado.Direccion = resultado.GetString(6);
                nuevoEmpleado.Ciudad = resultado.GetString(7);
                resultado.Close();
                return nuevoEmpleado;
            }
            else
            {
                resultado.Close();
                return null;
            }
        }
        public Cliente ConsultaCliente(string codigo)
        {
            string sql = ("select * from clientes where codigoCliente = @codigo");
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader resultado = cmd.ExecuteReader();
            if (resultado.Read())
            {
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.Nombre = resultado.GetString(2);
                nuevoCliente.Apellido = resultado.GetString(3);
                nuevoCliente.Direccion = resultado.GetString(4);
                nuevoCliente.Telefono = resultado.GetString(5);
                nuevoCliente.Correo = resultado.GetString(6);
                resultado.Close();
                return nuevoCliente;
            }
            else
            {
                resultado.Close();
                return null;
            }
        }
        public bool EliminarEmpleado(string codigo)
        {
            bool estado = false;

            try
            {
                string Sql = "delete from empleados where codigo = @codigo";
                MySqlCommand cmd = new MySqlCommand(Sql, conexion);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
                estado = true;
            }
            catch (MySqlException exception)
            {
                error = exception.Message;
                estado = false;
            }

            //conexion.Close();
            return estado;
        }
        public bool EliminarCliente(string codigo)
        {
            bool estado = false;

            try
            {
                string Sql = "delete from clientes where codigo = @codigo";
                MySqlCommand cmd = new MySqlCommand(Sql, conexion);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
                estado = true;
            }
            catch (MySqlException exception)
            {
                error = exception.Message;
                estado = false;
            }

            //conexion.Close();
            return estado;
        }
        public bool ExisteEmpleado(string codigo) //nuevo//
        {
            string sql = ("select * from empleados where codigo = @codigo");
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader Registro= cmd.ExecuteReader(); 

            if (Registro.Read())
            {
                Registro.Close();
                return true;
            }
            else 
            {
                Registro.Close();
                return false;
            }
        }
        public bool ExisteCliente(string codigo)
        {
            string sql = ("select * from clientes where codigoCliente = @codigoCliente");
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@codigoCliente", codigo);
            MySqlDataReader Agregar = cmd.ExecuteReader();

            if (Agregar.Read())
            {
                Agregar.Close();
                return true;
            }
            else
            {
                Agregar.Close();
                return false;
            }
        }
        public bool AgregarEmpleado(Empleado miEmpleado)
        {
            bool estado = false;
            try
            {
                string sql = "insert into empleados(codigo,nombre,apellido,correo,celular,direccion,ciudad) values(@codigo,@nombre,@apellido,@correo,@celular,@direccion,@ciudad)";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@codigo", miEmpleado.Codigo);
                cmd.Parameters.AddWithValue("@nombre", miEmpleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", miEmpleado.Apellido);
                cmd.Parameters.AddWithValue("@correo", miEmpleado.Correo);
                cmd.Parameters.AddWithValue("@celular", miEmpleado.Celular);
                cmd.Parameters.AddWithValue("@direccion", miEmpleado.Direccion);
                cmd.Parameters.AddWithValue("@ciudad", miEmpleado.Ciudad);
                cmd.ExecuteNonQuery();

                estado = true;
            }

            catch (MySqlException exception)
            {
                error = exception.Message;
            }
            return estado;
        }
        public bool AgregarCLiente(Cliente miCliente)
        {
            bool estado = false;
            try
            {
                string sql = "insert into clientes(codigoCliente,nombreCliente,apellidoCliente,direccionCliente,telefonoCliente,correoCliente) values(@codigoCliente,@nombreCliente,@apellidoCliente,@direccionCliente,@telefonoCliente,@correoCliente)";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@codigoCliente", miCliente.Codigo);
                cmd.Parameters.AddWithValue("@nombreCliente", miCliente.Nombre);
                cmd.Parameters.AddWithValue("@apellidoCliente", miCliente.Apellido);
                cmd.Parameters.AddWithValue("@direccionCliente", miCliente.Direccion);
                cmd.Parameters.AddWithValue("@telefonoCliente", miCliente.Telefono);
                cmd.Parameters.AddWithValue("@correoCliente", miCliente.Correo);
                cmd.ExecuteNonQuery();

                estado = true;
            }

            catch (MySqlException exception)
            {
                error = exception.Message;
            }

            return estado;
        }


    }
}




