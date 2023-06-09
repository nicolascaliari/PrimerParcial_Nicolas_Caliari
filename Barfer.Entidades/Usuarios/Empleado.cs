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
        /// Constructor para el factoryMethod
        /// </summary>
        /// <param name="empleado"></param>
        public Empleado(TipoUsuario empleado):this(2,"","",2, "",2)
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
        public Empleado(int id,string nombreUsuario, string apellidoUsuario, decimal edadUsuario, string contraseñaUsuario,  int tipo)
            : base(id, nombreUsuario, apellidoUsuario, edadUsuario , contraseñaUsuario , tipo)
        {
        }



        /// <summary>
        /// operador explicito que convierte un administrador en un empleado
        /// </summary>
        /// <param name="administrador"></param>
        public static explicit operator Empleado(Administrador administrador)
        {
            return new Empleado(administrador.idUsuario,administrador.nombreUsuario, administrador.apellidoUsuario, administrador.edadUsuario, administrador.password, (int)administrador.tipoUsuario);
        }

    }
}
