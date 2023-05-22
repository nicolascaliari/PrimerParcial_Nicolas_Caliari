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
    public class Validador
    {

        public enum OpcionTipo
        {
            administrador = 0,
            empleado = 1,
            error = -1,
        }



       /////////////Validaciones de tipo


        /// <summary>
        /// Metodo que valida un decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna bool</returns>
        public static bool EsDecimalValido(decimal valor)
        {
            bool esValido = false;
            if (valor > 0)
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
        /// Metodo que valida enums de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Retorna bool</returns>




        /////////////Validaciones con exceptions



        /// <summary>
        /// Metodo que valida password
        /// </summary>
        /// <param name="password"></param>
        /// <returns>Retorna bool</returns>
        public static void ValidarPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 4 || (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit)))
            {
                throw new LoginFallidoException("password de usuario incorrecto, no\n puede estar vacio, no debe ser menor\n a 4 letras, debe contenedor \n una mayuscula, y debe contenedor un\n numero al menos");
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
                throw new LoginFallidoException("Error de nombre de usuario, \n no puede estar vacio y no \n debe contenedor signos");
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




        public static void ValidarPrecioProducto(decimal precio)
        {
            if (!EsDecimalValido(precio) || precio < 1000 || precio > 6000)
            {
                throw new AltaFallidoException("Error de precio, el precio debe ser mayor a 1000\n y menor a 6000");
            }
        }



        public static void ValidarNombreProducto(string nombre)
        {
            if (!ValidarString(nombre))
            {
                throw new AltaFallidoException("Error de nombre, el nombre no debe contener\n caracteres ni estar vacio el campo");
            }
        }

        public static void ValidarCantidadProducto(decimal cantidad)
        {
            if (!EsDecimalValido(cantidad) || cantidad < 0)
            {
                throw new AltaFallidoException("Error de cantidad, la cantidad no puede ser 0");
            }
        }


        public static void ValidarEdadUsuario(decimal edad)
        {
            if(!EsDecimalValido(edad) || edad <=18 || edad >70)
            {
                throw new AltaFallidoException("Error de edad, la edad no puede ser\n menor a 18 o mayor a 70");
            }
        }


        public static void ValidarApellidoUsuario(string apellido)
        {
            if(!ValidarString(apellido) )
            {
                throw new AltaFallidoException("Error de apellido, no puede ser vacio\n y no debe contener signos");
            }
        }





        /// <summary>
        /// Metodo que valida enums de alimento
        /// </summary>
        /// <param name="sabor"></param>
        /// <param name="cantidad"></param>
        /// <param name="tipo"></param>
        /// <returns>Retorna bool</returns>
        public static void ValidarEnumsAlimento(int sabor, int cantidad, int tipo)
        {

            if (sabor == -1 || cantidad == -1 || tipo == -1)
            {
                throw new AltaFallidoException("Error debe seleccionar un tipo, \n un sabor y una cantidad");
            }
        }



        public static void ValidarEnumsUsuario(int usuario)
        {
            if (usuario == -1)
            {
                throw new AltaFallidoException("Error debe seleccionar un tipo.");
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
            //if (ValidarString(nombre) && EsDecimalValido(edad) && ValidarDouble(peso) && ValidarEnumsUsuario(tipo))
            //{
            //    return true;
            //}
            return false;
        }


    }
}
