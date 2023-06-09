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
        public Administrador(TipoUsuario administrador) : this(1 ,"", "", 1, "",1)
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
        public Administrador(int id, string nombreUsuario, string apellidoUsuario, decimal edadUsuario, string contraseñaUsuario, int tipo)
            : base(id, nombreUsuario, apellidoUsuario, edadUsuario, contraseñaUsuario, tipo)
        {
        }


        /// <summary>
        /// Operador explicito que convierte un empleado en un administrador
        /// </summary>
        /// <param name="empleado"></param>
        public static explicit operator Administrador(Empleado empleado)
        {
            return new Administrador(empleado.idUsuario, empleado.nombreUsuario, empleado.apellidoUsuario, empleado.edadUsuario,empleado.password, (int)empleado.tipoUsuario);
        }

    }
}
