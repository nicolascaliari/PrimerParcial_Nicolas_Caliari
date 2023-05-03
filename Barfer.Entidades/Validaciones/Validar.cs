using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Barfer.Entidades.Usuarios;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Barfer.Entidades.Validaciones
{
    public class Validar
    {

        public enum OpcionTipo
        {
            administrador = 0,
            empleado = 1,
            error = -1,
        }

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



        public static int EncontrarIdUsuario(string nombre, string pass)
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


        public static string GetNombreApellido(int userId, List<Usuario> usuarios)
        {
            StringBuilder sb  = new StringBuilder();

            Usuario usuario = usuarios.FirstOrDefault(u => u.idUsuario == userId);
            if (usuario != null)
            {
                sb.AppendLine(usuario.tipoUsuario.ToString());
                sb.AppendLine();
                sb.AppendLine(usuario.nombreUsuario);
                sb.AppendLine();
                sb.AppendLine(usuario.apellidoUsuario);

                
                return sb.ToString();
            }
            else
            {
                return "No se encontró ningún usuario con ese ID";
            }
        }



        public static OpcionTipo VerificarSiEsAdmin(int userId, List<Usuario> usuarios)
        {
            Usuario usuario = usuarios.FirstOrDefault(u => u.idUsuario == userId);
            if(usuario != null)
            {
                if (usuario.tipoUsuario == TipoUsuario.Administrador)
                {
                    return OpcionTipo.administrador;
                }
                else
                {
                    return OpcionTipo.empleado;
                }
            }
            else
            {
                return OpcionTipo.error;
            }


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


        public static bool ValidarAlta( string nombre, decimal precio, decimal cantidad, int sabor, int cantidadKilos, int tipo)
        {
            if(ValidarString(nombre) && EsDecimalValido(precio) && EsDecimalValido(cantidad) && ValidarEnumsAlimento(sabor, cantidadKilos, tipo))
            {
                return true;
            }
            return false;
        }



        public static bool ValidarAltaUsuario(string nombre,string apellido,string password, decimal edad ,int tipo)
        {
            
            if (ValidarString(nombre) && ValidarString(apellido) && ValidarPassword(password) && EsDecimalValido(edad) && ValidarEnumsUsuario(tipo))
            {
                return true;
            }
            return false;

        }
    }
}
