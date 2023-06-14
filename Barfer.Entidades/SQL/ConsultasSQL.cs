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

        public SqlCommand CrearComando(string query)
        {
            Abrir();
            var comando = new SqlCommand(query, _connection);
            return comando;
        }

        public DataTable EjecutarConsulta(SqlCommand consulta)
        {
            //Abrir();
            // var command = new SqlCommand(consulta, _connection);
            var reader = consulta.ExecuteReader();

            var dataTable = new DataTable();

            dataTable.Load(reader);

            reader.Close();
            // Cerrar();

            return dataTable;
        }

        public void ExcuteNonQuery(SqlCommand consulta)
        {
            consulta.ExecuteNonQuery();
        }
    }
}
