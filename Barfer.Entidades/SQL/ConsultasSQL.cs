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
        public async Task<SqlCommand> CrearComandoAsync(string query)
        {
            await AbrirAsync();
            var comando = new SqlCommand(query, _connection);
            return comando;
        }

        public async Task<DataTable> EjecutarConsultaAsync(SqlCommand consulta)
        {
            //await AbrirAsync();
            //var command = new SqlCommand(consulta, _connection);
            var reader = await consulta.ExecuteReaderAsync();

            var dataTable = new DataTable();

            dataTable.Load(reader);

            reader.Close();
            //Cerrar();

            return dataTable;
        }

        public async Task ExcuteNonQueryAsync(SqlCommand consulta)
        {
            await consulta.ExecuteNonQueryAsync();
        }
    }
}
