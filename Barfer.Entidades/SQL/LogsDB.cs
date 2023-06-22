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

        public void Agregar(RegistroActividad logs)
        {
            string query = "INSERT INTO Logs (usuario, registro, fecha) VALUES (@usuario, @registro, @fecha)";

            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@usuario", logs.Usuarioo);
                comando.Parameters.AddWithValue("@registro", logs.Registro);
                comando.Parameters.AddWithValue("@fecha", logs.Fecha);

                ExcuteNonQuery(comando);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                //AccesoDatos datos = new AccesoDatos();
                //datos.SetearConsulta("DELETE FROM Usuarios where id = @id");
                //datos.SetearParametro("@id", id);
                //datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Modificar(RegistroActividad usuario)
        {

                //datos.SetearConsulta("UPDATE Usuarios SET nombre = @nombre, apellido = @apellido, edad = @edad, password = @password, idTipoUsuario = @idTipoUsuario WHERE id = @id");
                //datos.SetearParametro("@id", usuario.idUsuario);
                //datos.SetearParametro("@nombre", usuario.nombreUsuario);
                //datos.SetearParametro("@apellido", usuario.apellidoUsuario);
                //datos.SetearParametro("@edad", usuario.edadUsuario);
                //datos.SetearParametro("@password", usuario.password);
                //datos.SetearParametro("@idTipoUsuario", usuario.tipoUsuario);

                //datos.EjecutarAccion();

        }



        public List<RegistroActividad> Traer()
        {
            var logs = new List<RegistroActividad>();
            string query = "SELECT * FROM Logs;";
            using (var comando = CrearComando(query))
            {
                using (var table = EjecutarConsulta(comando))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        logs.Add((RegistroActividad)row);
                    }
                }
            }
            return logs;

        }

        public RegistroActividad Traer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
