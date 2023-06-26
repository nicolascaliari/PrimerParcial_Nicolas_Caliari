using Barfer.Entidades.Logs;
using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class LogsDB : ConsultasSQL, IManipulable<RegistroActividad>
    {
        public LogsDB() : base()
        {
        }


        /// <summary>
        /// Agrega un log a la base de datos
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public async Task AgregarAsync(RegistroActividad logs)
        {
            string query = "INSERT INTO Logs (usuario, registro, fecha) VALUES (@usuario, @registro, @fecha)";

            using (var comando = await CrearComandoAsync(query))
            {
                comando.Parameters.AddWithValue("@usuario", logs.Usuarioo);
                comando.Parameters.AddWithValue("@registro", logs.Registro);
                comando.Parameters.AddWithValue("@fecha", logs.Fecha);

                await ExcuteNonQueryAsync(comando);
            }
        }

        public async Task EliminarAsync(int id)
        {
            try
            {
                // Código para eliminar registros asincrónicamente
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ModificarAsync(RegistroActividad usuario)
        {
            try
            {
                // Código para modificar registros asincrónicamente
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene todos los logs de la base de datos.
        /// </summary>
        /// <returns></returns>
        public async Task<List<RegistroActividad>> TraerAsync()
        {
            var logs = new List<RegistroActividad>();
            string query = "SELECT * FROM Logs;";
            using (var comando = await CrearComandoAsync(query))
            {
                using (var table = await EjecutarConsultaAsync(comando))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        logs.Add((RegistroActividad)row);
                    }
                }
            }
            return logs;
        }
    }
}
