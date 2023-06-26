using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class AlimentoDB : ConsultasSQL, IManipulable<Alimento>
    {
        public AlimentoDB() : base()
        {
        }

        /// <summary>
        /// Agrega un alimento a la base de datos
        /// </summary>
        /// <param name="alimento"></param>
        /// <returns></returns>
        public async Task AgregarAsync(Alimento alimento)
        {
            string query = "INSERT INTO Alimentos (nombre, precio, cantidad, idTipoAlimento, idSaborAlimento, idKilos) VALUES (@nombre, @precio, @cantidad, @idTipoAlimento, @idSaborAlimento, @idKilos)";

            using (var comando = await CrearComandoAsync(query))
            {
                comando.Parameters.AddWithValue("@nombre", alimento.nombre);
                comando.Parameters.AddWithValue("@precio", alimento.precio);
                comando.Parameters.AddWithValue("@cantidad", alimento.cantidad);
                comando.Parameters.AddWithValue("@idTipoAlimento", alimento.tipoAlimento);
                comando.Parameters.AddWithValue("@idSaborAlimento", alimento.sabor);
                comando.Parameters.AddWithValue("@idKilos", alimento.cantidadKilos);
                await ExcuteNonQueryAsync(comando);
            }
        }

        /// <summary>
        /// Elimina un alimento de la base de datos por su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task EliminarAsync(int id)
        {
            string query = "DELETE FROM Alimentos where id = @id";
            using (var comando = await CrearComandoAsync(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                await ExcuteNonQueryAsync(comando);
            }
        }

        /// <summary>
        /// Modifica un alimento en la base de datos.
        /// </summary>
        /// <param name="alimento"></param>
        /// <returns></returns>
        public async Task ModificarAsync(Alimento alimento)
        {
            string query = "UPDATE Alimentos SET nombre = @nombre, precio = @precio, cantidad = @cantidad, idTipoAlimento = @idTipoAlimento, idSaborAlimento = @idSaborAlimento, idKilos = @idKilos WHERE id = @id";

            using (var comando = await CrearComandoAsync(query))
            {
                comando.Parameters.AddWithValue("@id", alimento.id);
                comando.Parameters.AddWithValue("@nombre", alimento.nombre);
                comando.Parameters.AddWithValue("@precio", alimento.precio);
                comando.Parameters.AddWithValue("@cantidad", alimento.cantidad);
                comando.Parameters.AddWithValue("@idTipoAlimento", alimento.tipoAlimento);
                comando.Parameters.AddWithValue("@idSaborAlimento", alimento.sabor);
                comando.Parameters.AddWithValue("@idKilos", alimento.cantidadKilos);
                await ExcuteNonQueryAsync(comando);
            }
        }


        /// <summary>
        /// Obtiene todos los alimentos de la base de datos.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Alimento>> TraerAsync()
        {
            var alimentos = new List<Alimento>();
            string query = "SELECT * FROM Alimentos;";
            using (var comando = await CrearComandoAsync(query))
            {
                using (var table = await EjecutarConsultaAsync(comando))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        alimentos.Add((Alimento)row);
                    }
                }
            }
            return alimentos;
        }
    }
}
