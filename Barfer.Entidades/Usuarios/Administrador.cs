using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Usuarios
{
    public class Administrador : Usuario
    {


        public Administrador(TipoUsuario administrador) : this("", "", "", 1, administrador)
        {
        }

        public Administrador(string nombreUsuario, string contraseñaUsuario, string apellidoUsuario, decimal edadUsuario, TipoUsuario tipo)
            : base(nombreUsuario, contraseñaUsuario, apellidoUsuario, edadUsuario, tipo)
        {

        }



        public void CrearReporte()
        {

        }


        //public static explicit operator Administrador(Empleado empleado)
        //{
        //    return new Administrador();
        //}




        //public override string MostrarUsuario()
        //  {
        //      return base.MostrarUsuario();
        //  }
    }
}
