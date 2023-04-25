using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Usuarios
{
    public class Administrador : Usuario
    {

        public Administrador(string nombreUsuario, string contraseñaUsuario, string apellidoUsuario, decimal edadUsuario, TipoUsuario tipo, decimal id)
            : base(nombreUsuario, contraseñaUsuario, apellidoUsuario, edadUsuario, tipo, id)
        {

        }
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("Nombre: " + this._nombreUsuario);
        //    sb.AppendLine("Apellido: " + this._apellidoUsuario);
        //    sb.AppendLine("Edad: " + this._edadUsuario);
        //    sb.AppendLine("Contraseña: " + this._contraseñaUsuario);
        //    sb.AppendLine("Tipo de usuario: " + this._tipoUsuario);
        //    return sb.ToString();
        //}
    }
}
