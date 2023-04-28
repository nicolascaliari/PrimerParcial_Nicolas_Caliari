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


        static GestorDeUsuarios()
        {
            CargarUsuariosDesdeArchivo();
        }


        public static List<Usuario> CargarUsuariosDesdeArchivo()
        {
            return usuarios = Archivo.LeerUsuariosDesdeArchivo();
        }


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
