using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Archivos
{
    public class GuardarArchivo
    {
        private static string path = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Usuarios.csv";
        private static string pathAlimento = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Alimento.csv";


        /// <summary>
        /// Metodo para guardar un nuevo usuario en el archivo
        /// </summary>
        /// <param name="usuarioNuevo"></param>
        public static void GuardarUsuarioEnArchivo(List<Usuario> usuarioNuevo)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("id,nombre,apellido,contrasenia,edad,tipo de usuario");

                foreach (Usuario usuario in usuarioNuevo)
                {
                    sw.WriteLine($"{usuario.idUsuario},{usuario.nombreUsuario},{usuario.apellidoUsuario},{usuario.contraseñaUsuario},{usuario.edadUsuario},{usuario.tipoUsuario}");
                }
            }
        }




        /// <summary>
        /// Metodo para guardar un nuevo alimento en el archivo
        /// </summary>
        /// <param name="alimentoNuevo"></param>
        public static void GuardarAlimentoEnArchivo(List<Alimento> alimentoNuevo)
        {
            using (StreamWriter sw = new StreamWriter(pathAlimento))
            {
                sw.WriteLine("id,nombre producto,precio,cantidad,sabor,kilos,tipo");

                foreach (Alimento alimento in alimentoNuevo)
                {
                    sw.WriteLine($"{alimento.id},{alimento.nombre},{alimento.precio},{alimento.cantidad},{alimento.sabor},{alimento.cantidadKilos},{alimento.tipoAlimento}");
                }
            }
        }



        /// <summary>
        /// Metodo para guardar un nuevo cliente en el archivo
        /// </summary>
        /// <param name="clienteNuevo"></param>
        public static void GuardarClienteEnArchivo(List<Cliente> clienteNuevo)
        {
            using (StreamWriter sw = new StreamWriter(pathAlimento))
            {
                sw.WriteLine("id,nombre,apellido,contrasenia,edad,tipo de usuario");

                foreach (Cliente cliente in clienteNuevo)
                {
                    sw.WriteLine($"{cliente.NombreCliente},{cliente.Apellido},{cliente.Localidad}");
                }
            }
        }
    }
}
