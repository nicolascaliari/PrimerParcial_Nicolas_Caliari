using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class ClienteDB : ConsultasSQL, IManipulable<Cliente>
    {
        public ClienteDB() : base()
        {
        }

        public void Agregar(Cliente usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                //datos.SetearConsulta("INSERT INTO Usuarios (nombre, apellido, edad, password, idTipoUsuario) VALUES (@nombre, @apellido, @edad, @password, @idTipoUsuario)");
                //datos.SetearParametro("@nombre", usuario.nombreUsuario);
                //datos.SetearParametro("@apellido", usuario.apellidoUsuario);
                //datos.SetearParametro("@edad", usuario.edadUsuario);
                //datos.SetearParametro("@password", usuario.password);
                //datos.SetearParametro("@idTipoUsuario", usuario.tipoUsuario);
                //datos.EjecutarAccion();


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
                datos.SetearConsulta("DELETE FROM Clientes where id = @id");
                datos.SetearParametro("@id", id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Modificar(Cliente venta)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.SetearConsulta("UPDATE Ventas SET idCliente = @idCliente, idLocalidad = @idLocalidad, idAlimento = @idAlimento, cantidad = @cantidad, estado = @estado, enviar = @enviar WHERE id = @id");
                //datos.SetearParametro("@id", venta.idVenta);
                //datos.SetearParametro("@idCliente", venta.cliente);
                //datos.SetearParametro("@idLocalidad", venta.localidades);
                //datos.SetearParametro("@idAlimento", venta.alimento);
                //datos.SetearParametro("@cantidad", venta.cantidad);
                //datos.SetearParametro("@estado", venta.estado);
                //datos.SetearParametro("@enviar", venta.enviar);

                //datos.EjecutarAccion();


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



        public List<Cliente> Traer()
        {
            var clientes = new List<Cliente>();

            //using (var table = EjecutarConsulta("SELECT * FROM Clientes;"))
            //{
            //    foreach (System.Data.DataRow row in table.Rows)
            //    {
            //        var _id = Convert.ToInt32(row["id"].ToString());
            //        var nombre = row["nombre"].ToString() ?? "";
            //        var apellido = row["apellido"].ToString() ?? "";
            //        var idLocalidad = Convert.ToInt32(row["idLocalidad"].ToString());
                   

            //        clientes.Add(new Cliente(_id,nombre,apellido,idLocalidad));
            //    }
            //}

            return clientes;

        }

        public Cliente Traer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
