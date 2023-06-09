using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class ConsultasSQL: ConexionDB
    {
        public ConsultasSQL(string connectionString) : base(connectionString)
        {
        }

        public ConsultasSQL() : base("Server=.\\SQLEXPRESS;Database=BARFER;Trusted_Connection=True;") { }

        protected  DataTable EjecutarConsulta(string consulta)
        {
            Abrir();

            var command = new SqlCommand(consulta, _connection);
            var reader = command.ExecuteReader();

            var dataTable = new DataTable();

            dataTable.Load(reader);

            reader.Close();
            Cerrar();

            return dataTable;
        }
    }
}
