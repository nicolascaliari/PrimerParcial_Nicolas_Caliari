using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barfer.Entidades.SQL;
using Barfer.Entidades.Usuarios;
using DocumentFormat.OpenXml.Drawing;

namespace Barfer.Entidades
{
    public class GestorDeUsuarios
    {
        public static List<Usuario> usuarios { get; set; } = new List<Usuario>();
        public static List<Cliente> clientes;


        /// <summary>
        /// Inicializa la carga de datos de usuarios y clientes.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public static async Task Inicializar()
        {
            await CargarUsuarios();
            await CargarClientes();
        }

        /// <summary>
        /// Carga los datos de los clientes desde la base de datos.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public static async Task CargarClientes()
        {
            var datos = new ClienteDB();
            clientes = await datos.TraerAsync();
        }


        /// <summary>
        /// Carga los datos de los usuarios desde la base de datos.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public static async Task CargarUsuarios()
        {
            var datos = new UsuarioDB();
            usuarios = await datos.TraerAsync();
        }




        /// <summary>
        /// Metodo que agrega un usuario a la lista
        /// </summary>
        /// <param name="usuario"></param>
        /// <exception cref="Exception"></exception>
        public static void AltaUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException("Ocurrio un error al dar de alta usuario");
            }
            else
            {
                usuarios.Add(usuario);
            }

        }



        /// <summary>
        /// Metodo que elimina un usuario de la lista
        /// </summary>
        /// <param name="usuario"></param>
        /// <exception cref="Exception"></exception>
        public static void BajaUsuario(Usuario usuario)
        {
            if (usuario is not null)
            {
                usuarios.Remove(usuario);
            }
            else
            {
                throw new ArgumentNullException("Ocurrio un error al dar de baja usuario");
            }
        }


        /// <summary>
        /// Metodo que modifica un usuario de la lista
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna un usuario modificado</returns>
        public static Usuario ModificarUsuario(int id, Usuario datos, Usuario.TipoUsuario tipo)
        {
            var usuario = usuarios.FirstOrDefault(x => x.idUsuario == id);


            usuario.nombreUsuario = datos.nombreUsuario;
            usuario.password = datos.password;
            usuario.apellidoUsuario = datos.apellidoUsuario;
            usuario.edadUsuario = datos.edadUsuario;
            usuario.idUsuario = datos.idUsuario;


            if (tipo != usuario.tipoUsuario)
            {
                datos = CambiarRol(datos);
            }


            int indice = usuarios.IndexOf(usuario);
            usuarios[indice] = datos;
            usuarios[indice].idUsuario = id;

            return usuario;
        }


        /// <summary>
        /// Metodo para cambiar el rol de un usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Retorna el usuario</returns>
        /// <exception cref="Exception"></exception>
        public static Usuario CambiarRol(Usuario usuario)
        {

            if (usuario is Empleado emp)
            {
                usuario = (Administrador)emp;
                usuario.tipoUsuario = Usuario.TipoUsuario.Administrador;
            }
            else if (usuario is Administrador admin)
            {
                usuario = (Empleado)admin;
                usuario.tipoUsuario = Usuario.TipoUsuario.Empleado;
            }
            else
            {
                throw new Exception("No se pudo cambiar el rol");
            }
            return usuario;

        }

    }
}
