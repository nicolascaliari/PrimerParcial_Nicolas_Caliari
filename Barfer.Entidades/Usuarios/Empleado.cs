using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Usuarios
{
    public class Empleado : Usuario
    {



        /// <summary>
        /// Constructor para el factory
        /// </summary>
        /// <param name="empleado"></param>
        public Empleado(TipoUsuario empleado):this("","","",1,empleado)
        {
        }



        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contraseñaUsuario"></param>
        /// <param name="apellidoUsuario"></param>
        /// <param name="edadUsuario"></param>
        /// <param name="tipo"></param>
        public Empleado(string nombreUsuario, string contraseñaUsuario, string apellidoUsuario, decimal edadUsuario, TipoUsuario tipo)
            : base(nombreUsuario, contraseñaUsuario, apellidoUsuario, edadUsuario, tipo)
        {
        }



        /// <summary>
        /// operador explicito que convierte un administrador en un empleado
        /// </summary>
        /// <param name="administrador"></param>
        public static explicit operator Empleado(Administrador administrador)
        {
            return new Empleado(administrador.nombreUsuario, administrador.contraseñaUsuario, administrador.apellidoUsuario, administrador.edadUsuario, administrador.tipoUsuario);
        }

    }
}
