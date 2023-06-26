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

        /// <summary>
        /// Abre la conexión con la base de datos de forma asincrónica.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica de apertura de la conexión.</returns>
        protected async Task AbrirAsync()
        {
            _connection = new SqlConnection(_connectionString);
            await _connection.OpenAsync();
        }

        /// <summary>
        /// Cierra la conexión con la base de datos.
        /// </summary>
        protected void Cerrar()
        {
            _connection.Close();
        }
    }
}
