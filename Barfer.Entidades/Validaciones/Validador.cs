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
            administrador = 1,
            empleado = 2,
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
        /// Metodo que valida un string que no sea vacio y solo contenga letras o numeros
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Retorna bool</returns>
        public static bool ValidarString(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || !Regex.IsMatch(str, @"^[a-zA-Z\s]+$"))
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
            if (double.IsNaN(valor) || double.IsInfinity(valor))
            {
                return false;
            }
            return true;
        }



        /////////////Validaciones con exceptions



   /// <summary>
   /// Metodo que valida la password
   /// </summary>
   /// <param name="password"></param>
   /// <exception cref="LoginFallidoException"></exception>
        public static void ValidarPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 4 || (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit)))
            {
                throw new LoginFallidoException("password de usuario incorrecto, no\n puede estar vacio, no debe ser menor\n a 4 letras, debe contenedor \n una mayuscula, y debe contenedor un\n numero al menos");
            }
        }



/// <summary>
/// Metodo que valida el usuario
/// </summary>
/// <param name="usuario"></param>
/// <exception cref="LoginFallidoException"></exception>
        public static void ValidarUsuario(string usuario)
        {
              if (string.IsNullOrEmpty(usuario) || usuario.Length < 3)
              {
                throw new LoginFallidoException("Error de nombre de usuario, \n no puede estar vacio y no \n debe contenedor signos");
              }
        }


/// <summary>
/// Metodo que encuentra el id del usuario en caso contrario lanza error
/// </summary>
/// <param name="nombre"></param>
/// <param name="pass"></param>
/// <returns></returns>
/// <exception cref="LoginFallidoException"></exception>
        public static int EncontrarIdUsuario(string nombre, string pass)
        {
            foreach (Usuario item in GestorDeUsuarios.usuarios)
            {
                if (item.nombreUsuario == nombre && item.password == pass)
                {
                    return item.idUsuario;
                }
            }
            throw new LoginFallidoException("usuario no encontrado");
        }



        /// <summary>
        /// Metodo que valida el precio de un producto
        /// </summary>
        /// <param name="precio"></param>
        /// <exception cref="ExceptionCampos"></exception>
        public static void ValidarPrecioProducto(decimal precio)
        {
            if (!EsDecimalValido(precio) || precio < 1000 || precio > 6000)
            {
                throw new ExceptionCampos("Error de precio, el precio debe ser mayor a 1000\n y menor a 6000");
            }
        }


        /// <summary>
        /// Metodo que valida el nombre del producto
        /// </summary>
        /// <param name="nombre"></param>
        /// <exception cref="ExceptionCampos"></exception>
        public static void ValidarNombre(string nombre)
        {
            if (!ValidarString(nombre))
            {
                throw new ExceptionCampos("Error de nombre, el nombre no debe contener\n caracteres ni estar vacio el campo");
            }
        }


        /// <summary>
        /// Metodo que valida la cantidad de un producto
        /// </summary>
        /// <param name="cantidad"></param>
        /// <exception cref="ExceptionCampos"></exception>
        public static void ValidarCantidadProducto(decimal cantidad)
        {
            if (!EsDecimalValido(cantidad) || cantidad < 0)
            {
                throw new ExceptionCampos("Error de cantidad, la cantidad no puede ser 0");
            }
        }



        /// <summary>
        /// Metodo que valida la edad de un usuario.
        /// </summary>
        /// <param name="edad"></param>
        /// <exception cref="ExceptionCampos"></exception>
        public static void ValidarEdad(decimal edad)
        {
            if(!EsDecimalValido(edad) || edad <=18 || edad >70)
            {
                throw new ExceptionCampos("Error de edad, la edad no puede ser\n menor a 18 o mayor a 70");
            }
        }


        /// <summary>
        /// Metodo que valida la edad de un mascota.
        /// </summary>
        /// <param name="edad"></param>
        /// <exception cref="ExceptionCampos"></exception>
        public static void ValidarEdadMascota(decimal edad)
        {
            if (!EsDecimalValido(edad) || edad <= 2 || edad > 12)
            {
                throw new ExceptionCampos("Error de edad, la edad no puede ser\n menor a 2 o mayor a 12");
            }
        }


        /// <summary>
        /// Metodo que valida el apellido del usuario
        /// </summary>
        /// <param name="apellido"></param>
        /// <exception cref="ExceptionCampos"></exception>
        public static void ValidarApellidoUsuario(string apellido)
        {
            if(!ValidarString(apellido) )
            {
                throw new ExceptionCampos("Error de apellido, no puede ser vacio\n y no debe contener signos");
            }
        }





  
       /// <summary>
       /// Metodo que verifica que los comboBox del alta de un alimento esten seleccionados
       /// </summary>
       /// <param name="sabor"></param>
       /// <param name="cantidad"></param>
       /// <param name="tipo"></param>
       /// <exception cref="ExceptionCampos"></exception>
        public static void ValidarEnumsAlimento(int sabor, int cantidad, int tipo)
        {

            if (sabor == -1 || cantidad == -1 || tipo == -1)
            {
                throw new ExceptionCampos("Error debe seleccionar un tipo, \n un sabor y una cantidad");
            }
        }


        /// <summary>
        /// Metodo que verifica que el comboBox del alta de un usuario este seleccionado.
        /// </summary>
        /// <param name="usuario"></param>
        /// <exception cref="ExceptionCampos"></exception>
        public static void ValidarEnumsUsuario(int usuario)
        {
            if (usuario == -1)
            {
                throw new ExceptionCampos("Error debe seleccionar un tipo.");
            }
        }


        /// <summary>
        /// Metodo que verifica el peso de la mascota
        /// </summary>
        /// <param name="peso"></param>
        /// <exception cref="ExceptionCampos"></exception>
        public static void ValidarPesoMascota(double peso)
        {
            if (!ValidarDouble(peso) || peso <= 1 || peso > 40)
            {
                throw new ExceptionCampos("Error de peso, el peso no puede ser\n menor a 1 o mayor a 40");
            }
        }





        /// <summary>
        /// Metodo que verifica que este cargada una fecha de entrega y qye haya ventas en preparacion
        /// </summary>
        /// <exception cref="preparacionesCargadasException"></exception>
        public static void VerificarSiSeCargoFechaYHayEntregas()
        {
            if (Venta.ventasPreparacion.Count <= 0)
            {
                throw new preparacionesCargadasException("Error, debes tener ventas en preparacion");
            }
            if (Venta.entregasProgramadas.Count <= 0)
            {
                throw new preparacionesCargadasException("Error, debes tener una fecha programada");
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
