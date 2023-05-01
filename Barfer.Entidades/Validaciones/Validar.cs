using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Barfer.Entidades.Usuarios;


namespace Barfer.Entidades.Validaciones
{
    public class Validar
    {

        public static bool ValidarPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 4)
                return false;

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit))
                return false;

            return true;
        }


        public static bool ValidarUsuario(string usuario)
        {
            if (string.IsNullOrEmpty(usuario) || usuario.Length < 3)
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



        public static decimal EncontrarIdUsuario(string nombre, string pass)
        {
            foreach (Usuario item in GestorDeUsuarios.usuarios)
            {
                if (item.nombreUsuario == nombre && item.contraseñaUsuario == pass)
                {
                    return item.idUsuario;

                }
            }
            return -1;
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


        public static bool EsDecimalValido(decimal valor)
        {
            bool esValido = false;
            if(valor  > 0)
            {
                esValido = decimal.TryParse(valor.ToString(), out _);
            }
           
            return esValido;
        }

        public static bool ValidarString(string str)
        {
            // Verificar si el string está vacío
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            // Verificar si el string contiene algún carácter que no sea una letra o un espacio en blanco
            if (!Regex.IsMatch(str, @"^[a-zA-Z\s]+$"))
            {
                return false;
            }

            // El string es válido
            return true;
        }



        public static bool ValidarEnumsAlimento(int sabor, int cantidad, int tipo)
        {

            if(sabor == -1 || cantidad == -1 || tipo == -1)
            {
                return false;
            }
            return true;
        }


        public static bool ValidarEnumsUsuario(int usuario)
        {

            if (usuario == -1 )
            {
                return false;
            }
            return true;
        }


        public static bool ValidarAlta(decimal id, string nombre, decimal precio, decimal cantidad, int sabor, int cantidadKilos, int tipo)
        {
            if(EsDecimalValido(id) && ValidarString(nombre) && EsDecimalValido(precio) && EsDecimalValido(cantidad) && ValidarEnumsAlimento(sabor, cantidadKilos, tipo))
            {
                return true;
            }
            return false;
        }



        public static bool ValidarAltaUsuario(decimal id ,string nombre,string apellido,string password, decimal edad ,int tipo)
        {
            
            if (EsDecimalValido(id) && ValidarString(nombre) && ValidarString(apellido) && ValidarPassword(password) && EsDecimalValido(edad) && ValidarEnumsUsuario(tipo))
            {
                return true;
            }
            return false;

        }
    }
}
