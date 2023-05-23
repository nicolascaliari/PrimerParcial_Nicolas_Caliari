using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Usuarios
{
    public class Administrador : Usuario
    {

        /// <summary>
        /// Constructor usado para el factoryMethod
        /// </summary>
        /// <param name="administrador"></param>
        public Administrador(TipoUsuario administrador) : this("", "", "", 1, administrador)
        {
        }


        /// <summary>
        /// Constrcutor parametrizado
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contraseñaUsuario"></param>
        /// <param name="apellidoUsuario"></param>
        /// <param name="edadUsuario"></param>
        /// <param name="tipo"></param>
        public Administrador(string nombreUsuario, string contraseñaUsuario, string apellidoUsuario, decimal edadUsuario, TipoUsuario tipo)
            : base(nombreUsuario, contraseñaUsuario, apellidoUsuario, edadUsuario, tipo)
        {

        }


        /// <summary>
        /// Operador explicito que convierte un empleado en un administrador
        /// </summary>
        /// <param name="empleado"></param>
        public static explicit operator Administrador(Empleado empleado)
        {
            return new Administrador(empleado.nombreUsuario, empleado.contraseñaUsuario, empleado.apellidoUsuario, empleado.edadUsuario, empleado.tipoUsuario);
        }

    }
}
