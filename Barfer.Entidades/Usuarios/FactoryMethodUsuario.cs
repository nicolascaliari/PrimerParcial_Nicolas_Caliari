using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Barfer.Entidades.Usuarios
{
    public class FactoryMethodUsuario
    {
        public const int Administrador = 1;
        public const int Empleado = 2;


        /// <summary>
        /// Meotodo que crea un usuario dependiendo su tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns>Retorna el usuario</returns>
        public static Usuario CrearUsuario(TipoUsuario tipo)
        {
            Usuario usuario = null;
            switch (tipo)
            {
                case TipoUsuario.Administrador:
                    usuario = new Administrador(TipoUsuario.Administrador);
                    break;
                case TipoUsuario.Empleado:
                    usuario = new Empleado(TipoUsuario.Empleado);
                    break;
            }
            return usuario;
        }
    }
}
