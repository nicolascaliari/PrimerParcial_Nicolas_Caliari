using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.SQL
{
    public class AlimentoDB: ConsultasSQL, IManipulable<Alimento>
    {
        public AlimentoDB() : base()
        {
        }

        public void Agregar(Alimento alimento)
        {

            string query = "INSERT INTO Alimentos (nombre, precio, cantidad, idTipoAlimento, idSaborAlimento, idKilos) VALUES (@nombre, @precio, @cantidad, @idTipoAlimento, @idSaborAlimento, @idKilos)";
            
            using(var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@nombre", alimento.nombre);
                comando.Parameters.AddWithValue("@precio", alimento.precio);
                comando.Parameters.AddWithValue("@cantidad", alimento.cantidad);
                comando.Parameters.AddWithValue("@idTipoAlimento", alimento.tipoAlimento);
                comando.Parameters.AddWithValue("@idSaborAlimento", alimento.sabor);
                comando.Parameters.AddWithValue("@idKilos", alimento.cantidadKilos);
                ExcuteNonQuery(comando);
            }
        }

        public void Eliminar(int id)
        {
            string query = "DELETE FROM Alimentos where id = @id";
            using(var comando = CrearComando(query))
            {
                comando.Parameters.AddWithValue("@id", id);
                ExcuteNonQuery(comando);
            }
        }


        public void Modificar(Alimento alimento)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("UPDATE Alimentos SET nombre = @nombre, precio = @precio, cantidad = @cantidad, idTipoAlimento = @idTipoAlimento, idSaborAlimento = @idSaborAlimento, idKilos = @idKilos WHERE id = @id");
                datos.SetearParametro("@id", alimento.id);
                datos.SetearParametro("@nombre", alimento.nombre);
                datos.SetearParametro("@precio", alimento.precio);
                datos.SetearParametro("@cantidad", alimento.cantidad);
                datos.SetearParametro("@idTipoAlimento", alimento.tipoAlimento);
                datos.SetearParametro("@idSaborAlimento", alimento.sabor);
                datos.SetearParametro("@idKilos", alimento.cantidadKilos);

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



        public List<Alimento> Traer()
        {
            var alimento = new List<Alimento>();
            string query = "SELECT *FROM Alimentos;";
            using (var comando = CrearComando(query))
            {
                using(var table = EjecutarConsulta(comando))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        alimento.Add((Alimento)row);
                    }
                }
            }
        

            return alimento;

        }

        public Alimento Traer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
