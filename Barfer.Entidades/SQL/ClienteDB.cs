using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class ClienteDB : ConsultasSQL
    {
        public ClienteDB() : base()
        {
        }

        /// <summary>
        /// Obtiene todos los clientes de la base de datos.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Cliente>> TraerAsync()
        {
            var clientes = new List<Cliente>();

            string query = "SELECT * FROM Clientes;";
            using (var comando = await CrearComandoAsync(query))
            {
                using (var table = await EjecutarConsultaAsync(comando))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        clientes.Add((Cliente)row);
                    }
                }
            }
            return clientes;
        }
    }
}
