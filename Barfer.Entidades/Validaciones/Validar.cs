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


        /// <summary>
        /// Metodo que valida password
        /// </summary>
        /// <param name="password"></param>
        /// <returns>Retorna bool</returns>
        public static void ValidarPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 4 || (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit)))
            {
                throw new LoginFallidoException("password de usuario incorrecto");
            }
        }



        /// <summary>
        /// Metodo que valida el nombre de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Retorna bool</returns>
        public static void ValidarUsuario(string usuario)
        {
              if (string.IsNullOrEmpty(usuario) || usuario.Length < 3)
              {
                throw new LoginFallidoException("nombre de usuario incorrecto");
              }
        }


        /// <summary>
        /// Metodo que verifica si el usuario existe
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="pass"></param>
        /// <returns>Retorna el id del usuario encontrado</returns>
        public static int EncontrarIdUsuario(string nombre, string pass)
        {
            foreach (Usuario item in GestorDeUsuarios.usuarios)
            {
                if (item.nombreUsuario == nombre && item.contraseñaUsuario == pass)
                {
                    return item.idUsuario;

                }
            }
            throw new LoginFallidoException("usuario no encontrado");
        }

        /// <summary>
        /// Metodo que busca a un usuaruo por su id y retorna su nombre y apellido
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="usuarios"></param>
        /// <returns>Retorna string</returns>
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


        /// <summary>
        /// Metodo que verifica si el usuario es admin o empleado
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="usuarios"></param>
        /// <returns>Retorna el tipo de usuario</returns>
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


        /// <summary>
        /// Metodo que valida un decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna bool</returns>
        public static bool EsDecimalValido(decimal valor)
        {
            bool esValido = false;
            if(valor  > 0)
            {
                esValido = decimal.TryParse(valor.ToString(), out _);
            }
           
            return esValido;
        }


        /// <summary>
        /// Metodo que valida un string
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Retorna bool</returns>
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

            return true;
        }


        /// <summary>
        /// Metodo que valida un double
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna un bool</returns>
        public static bool ValidarDouble(double valor)
        {
            // Verificar si el valor es válido
            if (double.IsNaN(valor) || double.IsInfinity(valor))
            {
                return false;
            }

            // Si el valor es válido, retornar true
            return true;
        }


        /// <summary>
        /// Metodo que valida enums de alimento
        /// </summary>
        /// <param name="sabor"></param>
        /// <param name="cantidad"></param>
        /// <param name="tipo"></param>
        /// <returns>Retorna bool</returns>
        public static bool ValidarEnumsAlimento(int sabor, int cantidad, int tipo)
        {

            if(sabor == -1 || cantidad == -1 || tipo == -1)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Metodo que valida enums de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Retorna bool</returns>
        public static bool ValidarEnumsUsuario(int usuario)
        {

            if (usuario == -1 )
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Metodo que valida al alta de alimento
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <param name="sabor"></param>
        /// <param name="cantidadKilos"></param>
        /// <param name="tipo"></param>
        /// <returns>Retorna bool</returns>
        public static bool ValidarAlta( string nombre, decimal precio, decimal cantidad, int sabor, int cantidadKilos, int tipo)
        {
            if(ValidarString(nombre) && EsDecimalValido(precio) && EsDecimalValido(cantidad) && ValidarEnumsAlimento(sabor, cantidadKilos, tipo))
            {
                return true;
            }
            return false;
        }



        /// <summary>
        /// Metodo que valida el alta de un usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="password"></param>
        /// <param name="edad"></param>
        /// <param name="tipo"></param>
        /// <returns>Retorna bool</returns>
        public static bool ValidarAlta(string nombre,string apellido,string password, decimal edad ,int tipo)
        {
            
            //if (ValidarString(nombre) && ValidarString(apellido) && ValidarPassword(password) && EsDecimalValido(edad) && ValidarEnumsUsuario(tipo))
            //{
            //    return true;
            //}
            return true;

        }




        /// <summary>
        /// Metodo que valida los nuevos datos del usuario a editar
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="password"></param>
        /// <param name="edad"></param>
        /// <returns>Retorna bool</returns>
        public static bool ValidarEdicionUsuario(string nombre, string apellido, string password, decimal edad)
        {

            //if (ValidarString(nombre) && ValidarString(apellido) && ValidarPassword(password) && EsDecimalValido(edad))
            //{
            //    return true;
            //}
            return false;

        }


        /// <summary>
        /// Metodo que valida los datos que se ingresaro en la calculadora
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="peso"></param>
        /// <param name="tipo"></param>
        /// <returns>Retorna bool</returns>
        public static bool ValidarCalculadora(string nombre, decimal edad, double peso, int tipo)
        {
            if(ValidarString(nombre) && EsDecimalValido(edad) && ValidarDouble(peso) && ValidarEnumsUsuario(tipo))
            {
                return true;
            }
         return false;
        }


    }
}
