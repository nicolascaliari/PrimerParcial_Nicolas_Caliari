using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barfer.Entidades.Usuarios;


namespace Barfer.Entidades.Validaciones
{
    public class Validar
    {

        public bool ValidarPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 9)
                return false;

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit))
                return false;

            return true;
        }


        public bool ValidarUsuario(string usuario)
        {
            if (string.IsNullOrEmpty(usuario) || usuario.Length < 5)
                return false;

            return true;
        }


        public static bool UsuarioExistente(string nombreUsuario, List<Usuario> _usuario)
        {
            foreach (Usuario item in _usuario)
            {
                if (item.nombreUsuario == nombreUsuario)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool PasswordExistente(string passwordUsuario, List<Usuario> _usuario)
        {
            foreach (Usuario item in _usuario)
            {
                if (item.contraseñaUsuario == passwordUsuario)
                {
                    return true;
                }
            }
            return false;
        }



        public static bool ValidarSiEsAdmin(string nombreUsuario, List<Usuario> _usuario)
        {

            foreach (Usuario item in _usuario)
            {
                if (item.nombreUsuario == nombreUsuario)
                {
                    if (item.tipoUsuario == Usuario.TipoUsuario.Administrador)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public static int VerificarUsuarioContrasenia(string nombreUsuario, string contrasenia)
        {

            foreach (Usuario item in GestorDeUsuarios.usuarios)
            {
                if (item.nombreUsuario == nombreUsuario && item.contraseñaUsuario == contrasenia)
                {
                    if (item.tipoUsuario == Usuario.TipoUsuario.Administrador)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }

                }
            }
            return -1;

        }

    }
}
