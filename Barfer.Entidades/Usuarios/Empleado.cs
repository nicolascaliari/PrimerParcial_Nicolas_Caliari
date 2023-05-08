using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Usuarios
{
    public class Empleado : Usuario
    {

        public Empleado(TipoUsuario empleado):this("","","",1,empleado,1)
        {
        }

        public Empleado(string nombreUsuario, string contraseñaUsuario, string apellidoUsuario, decimal edadUsuario, TipoUsuario tipo, int salario)
            : base(nombreUsuario, contraseñaUsuario, apellidoUsuario, edadUsuario, tipo)
        {
        }

        
        //public override string MostrarUsuario()
        //{        
        //   return base.MostrarUsuario();
        //}



        //public static explicit operator Empleado(Administrador administrador)
        //{
        //    return new Empleado();
        //}

    }
}
