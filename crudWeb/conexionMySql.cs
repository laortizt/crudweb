using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data.SqlClient;





namespace crudWeb
{
    public class ConexionMySql
    {
        private static MySqlConnection objetoConexion;
        private static string error;


        public static MySqlConnection GetConexion()
        {
            if (objetoConexion != null)
                return objetoConexion;

            objetoConexion = new MySqlConnection("Server=localhost;Database=staller;Uid=root;Pwd=50430;");

            try
            {
                objetoConexion.Open();
                return objetoConexion;
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
        }

        public static void CerrarConexion() 
        {
            if (objetoConexion != null)
                objetoConexion.Close();
        }
    }
 }