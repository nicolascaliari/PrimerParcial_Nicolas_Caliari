using Barfer.Entidades.Usuarios;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Barfer.Entidades.SQL
{
    public class UsuarioDB : ConsultasSQL, IManipulable<Usuario>
    {
        public UsuarioDB() : base()
        {
        }

        public async Task AgregarAsync(Usuario usuario)
        {
            string query = "INSERT INTO Usuarios (nombre, apellido, edad, password, idTipoUsuario) VALUES (@nombre, @apellido, @edad, @password, @idTipoUsuario)";

            using (var comando = await CrearComandoAsync(query))
            {
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.nombreUsuario;
                comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = usuario.apellidoUsuario;
                comando.Parameters.Add("@edad", SqlDbType.Int).Value = usuario.edadUsuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = usuario.password;
                comando.Parameters.Add("@idTipoUsuario", SqlDbType.Int).Value = usuario.idUsuario;
                await ExcuteNonQueryAsync(comando);
            }
        }


        public async Task EliminarAsync(int id)
        {
            string query = "DELETE FROM Usuarios where id = @id";
            using (var comando = await CrearComandoAsync(query))
            {
                comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                await ExcuteNonQueryAsync(comando);
            }
        }


        public async Task ModificarAsync(Usuario usuario)
        {
            string query = "UPDATE Usuarios SET nombre = @nombre, apellido = @apellido, edad = @edad, password = @password, idTipoUsuario = @idTipoUsuario WHERE id = @id";

            using (var comando = await CrearComandoAsync(query))
            {
                comando.Parameters.Add("@id", SqlDbType.Int).Value = usuario.idUsuario;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.nombreUsuario;
                comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = usuario.apellidoUsuario;
                comando.Parameters.Add("@edad", SqlDbType.Int).Value = usuario.edadUsuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = usuario.password;
                comando.Parameters.Add("@idTipoUsuario", SqlDbType.Int).Value = usuario.idUsuario;
                await ExcuteNonQueryAsync(comando);
            }
        }


        public async Task<List<Usuario>> TraerAsync()
        {
            var personas = new List<Usuario>();

            string query = "SELECT * FROM Usuarios;";
            using (var comando = await CrearComandoAsync(query))
            {
                using (var table = await EjecutarConsultaAsync(comando))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        personas.Add((Usuario)row);
                    }
                }
            }
            return personas;
        }


        public async Task<Usuario> TraerAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
