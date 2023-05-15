using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barfer.Entidades.Usuarios;
using DocumentFormat.OpenXml.Drawing;

namespace Barfer.Entidades
{
    public class GestorDeUsuarios
    {
        public static List<Usuario> usuarios;
        public static List<Cliente> clientes;


        static GestorDeUsuarios()
        {
            CargarUsuariosDesdeArchivo();
            CargarClientesDesdeArchivo();
        }

        /// <summary>
        /// Metodo que carga los clientes desde el archivo a la lista
        /// </summary>
        /// <returns>una lista de Cliente</returns>
        public static List<Cliente> CargarClientesDesdeArchivo()
        {
            return clientes = Archivo.LeerClienteDesdeArchivo();
        }



        /// <summary>
        /// Metodo que carga los Usuarios desde el archivo a la lista
        /// </summary>
        /// <returns>una lista  de Usuario</returns>
        public static List<Usuario> CargarUsuariosDesdeArchivo()
        {
            return usuarios = Archivo.LeerUsuariosDesdeArchivo();
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
                throw new Exception("No se pudo dar de alta");
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
                throw new Exception("No se pudo eliminar");
            }
        }


        /// <summary>
        /// Metodo que modifica un usuario de la lista
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna un usuario modificado</returns>
        public static Usuario ModificarUsuario(int id, Usuario datos)
        {
            var usuario = usuarios.FirstOrDefault(x => x.idUsuario == id);


            usuario.nombreUsuario = datos.nombreUsuario;
            usuario.contraseñaUsuario = datos.contraseñaUsuario;
            usuario.apellidoUsuario = datos.apellidoUsuario;
            usuario.edadUsuario = datos.edadUsuario;
            usuario.idUsuario = datos.idUsuario;


            datos = CambiarRol(datos);

           
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
            else if(usuario is Administrador admin)
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
