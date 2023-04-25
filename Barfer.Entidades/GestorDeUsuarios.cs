using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barfer.Entidades.Usuarios;

namespace Barfer.Entidades
{
    public class GestorDeUsuarios
    {
        public static List<Usuario> usuarios;


        static GestorDeUsuarios()
        {
            CargarUsuario();
        }


        public static void CargarUsuario()
        {
            usuarios = new List<Usuario>()
            {

                new Administrador("nicolas", "agunic", "caliari", 30, Usuario.TipoUsuario.Administrador, 1),
                new Empleado("malena", "elrojo", "illan", 30, Usuario.TipoUsuario.Empleado, 2),

            };
        }


        public static void AltaUsuarioEmpleado(Empleado usuario)
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

        public static void AltaUsuarioAdministrador(Administrador usuario)
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



    }
}
