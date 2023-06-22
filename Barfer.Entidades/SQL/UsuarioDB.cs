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

        public void Agregar(Usuario usuario)
        {

            string query = "INSERT INTO Usuarios (nombre, apellido, edad, password, idTipoUsuario) VALUES (@nombre, @apellido, @edad, @password, @idTipoUsuario)";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@nombre", usuario.nombreUsuario);
                comando.Parameters.AddWithValue("@apellido", usuario.apellidoUsuario);
                comando.Parameters.AddWithValue("@edad", usuario.edadUsuario);
                comando.Parameters.AddWithValue("@password", usuario.password);
                comando.Parameters.AddWithValue("@idTipoUsuario", usuario.idUsuario);
                ExcuteNonQuery(comando);
            }  
        }

        public void Eliminar(int id)
        {
            string query = "DELETE FROM Usuarios where id = @id";
            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                ExcuteNonQuery(comando);
            }
        }


        public void Modificar(Usuario usuario)
        {

            string query ="UPDATE Usuarios SET nombre = @nombre, apellido = @apellido, edad = @edad, password = @password, idTipoUsuario = @idTipoUsuario WHERE id = @id";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", usuario.idUsuario);
                comando.Parameters.AddWithValue("@nombre", usuario.nombreUsuario);
                comando.Parameters.AddWithValue("@apellido", usuario.apellidoUsuario);
                comando.Parameters.AddWithValue("@edad", usuario.edadUsuario);
                comando.Parameters.AddWithValue("@password", usuario.password);
                comando.Parameters.AddWithValue("@idTipoUsuario", usuario.idUsuario);
                ExcuteNonQuery(comando);
            }
        }



        public List<Usuario> Traer()
        {
            var personas = new List<Usuario>();

            string query = "SELECT *FROM Usuarios;";
            using (var comando = CrearComando(query))
            {
                using (var table = EjecutarConsulta(comando))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        personas.Add((Usuario)row);
                    }
                }
            }
            return personas;

        }

        public Usuario Traer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
