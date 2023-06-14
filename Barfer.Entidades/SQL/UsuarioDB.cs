using Barfer.Entidades.Usuarios;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class UsuarioDB : ConsultasSQL, IManipulable<Usuario>
    {
        public UsuarioDB() : base()
        {
        }

        public void Agregar(Usuario usuario)
        {
           AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearConsulta("INSERT INTO Usuarios (nombre, apellido, edad, password, idTipoUsuario) VALUES (@nombre, @apellido, @edad, @password, @idTipoUsuario)");
                datos.SetearParametro("@nombre" , usuario.nombreUsuario);
                datos.SetearParametro("@apellido", usuario.apellidoUsuario);
                datos.SetearParametro("@edad", usuario.edadUsuario);
                datos.SetearParametro("@password", usuario.password);
                datos.SetearParametro("@idTipoUsuario", usuario.tipoUsuario);
                datos.EjecutarAccion();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("DELETE FROM Usuarios where id = @id");
                datos.SetearParametro("@id", id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Modificar(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("UPDATE Usuarios SET nombre = @nombre, apellido = @apellido, edad = @edad, password = @password, idTipoUsuario = @idTipoUsuario WHERE id = @id");
                datos.SetearParametro("@id", usuario.idUsuario);
                datos.SetearParametro("@nombre", usuario.nombreUsuario);
                datos.SetearParametro("@apellido", usuario.apellidoUsuario);
                datos.SetearParametro("@edad", usuario.edadUsuario);
                datos.SetearParametro("@password", usuario.password);
                datos.SetearParametro("@idTipoUsuario", usuario.tipoUsuario);

                datos.EjecutarAccion();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
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
