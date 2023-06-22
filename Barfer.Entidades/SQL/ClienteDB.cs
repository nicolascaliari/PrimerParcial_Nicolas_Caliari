using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
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


                //datos.SetearConsulta("INSERT INTO Usuarios (nombre, apellido, edad, password, idTipoUsuario) VALUES (@nombre, @apellido, @edad, @password, @idTipoUsuario)");
                //datos.SetearParametro("@nombre", usuario.NombreCliente);
                //datos.SetearParametro("@apellido", usuario.Apellido);
                //datos.SetearParametro("@edad", usuario.);
                //datos.SetearParametro("@password", usuario.password);
                //datos.SetearParametro("@idTipoUsuario", usuario.tipoUsuario);
                //datos.EjecutarAccion();

        }

        public void Eliminar(int id)
        {
            string query = "DELETE FROM Clientes where id = @id";
            using (var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                ExcuteNonQuery(comando);
            }
        }


        public void Modificar(Cliente venta)
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



        public List<Cliente> Traer()
        {
            var clientes = new List<Cliente>();

            string query = "SELECT * FROM Clientes;";
            using (var comando = CrearComando(query))
            {
                using (var table = EjecutarConsulta(comando))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        clientes.Add((Cliente)row);
                    }
                }
            }
            return clientes;
        }

        public Cliente Traer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
