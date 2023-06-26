using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class ConsultasSQL : ConexionDB
    {

        /// <summary>
        /// Crea un objeto SqlCommand con la consulta especificada.
        /// </summary>
        /// <param name="query">La consulta SQL.</param>
        /// <returns>Un objeto SqlCommand con la consulta y la conexión establecidas.</returns>
        public async Task<SqlCommand> CrearComandoAsync(string query)
        {
            await AbrirAsync();
            var comando = new SqlCommand(query, _connection);
            return comando;
        }


        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados como un DataTable.
        /// </summary>
        /// <param name="consulta">El objeto SqlCommand que representa la consulta.</param>
        /// <returns>Un DataTable con los resultados de la consulta.</returns>
        public async Task<DataTable> EjecutarConsultaAsync(SqlCommand consulta)
        {
            var reader = await consulta.ExecuteReaderAsync();

            var dataTable = new DataTable();

            dataTable.Load(reader);

            reader.Close();
            return dataTable;
        }


        /// <summary>
        /// Ejecuta una consulta SQL que no devuelve ningún resultado.
        /// </summary>
        /// <param name="consulta">El objeto SqlCommand que representa la consulta.</param>
        public async Task ExcuteNonQueryAsync(SqlCommand consulta)
        {
            await consulta.ExecuteNonQueryAsync();
        }
    }
}
