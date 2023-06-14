using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class ConexionDB
    {
        protected SqlConnection _connection;
        private static string _connectionString;

        static ConexionDB()
        {
            _connectionString = "Server=.\\SQLEXPRESS;Database=BARFER;Trusted_Connection=True;";
        }

        public ConexionDB()
        {
        }

        protected void Abrir()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        protected void Cerrar()
        {
            _connection.Close();
        }
    }
}
