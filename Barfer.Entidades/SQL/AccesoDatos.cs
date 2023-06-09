using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class AccesoDatos
    {
        public SqlConnection SqlConnection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader SqlDataReader { get; set; }


        public AccesoDatos()
        {
            SqlConnection = new SqlConnection("Server =.\\SQLEXPRESS;Database = BARFER ; integrated security = true ");
            Command = new SqlCommand();
        }


        public void SetearConsulta(string consulta)
        {
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = consulta;
        }

        public void SetearProcedimiento(String sp)
        {
            Command.CommandType = System.Data.CommandType.StoredProcedure;
            Command.CommandText = sp;
        }


        public void EjecutarLectura()
        {
            Command.Connection = SqlConnection;
            try
            {
                SqlConnection.Open();
                SqlDataReader = Command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void EjecutarAccion()
        {
            Command.Connection = SqlConnection;

            try
            {
                SqlConnection.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void SetearParametro(string nombre, object valor)
        {
            Command.Parameters.AddWithValue(nombre, valor);
        }


        public void CerrarConexion()
        {
            if (SqlDataReader != null)
            {
                SqlDataReader.Close();
                SqlConnection.Close();
            }
        }
    }
}
