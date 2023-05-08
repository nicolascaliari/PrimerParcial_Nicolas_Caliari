using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Barfer.Entidades.Usuarios
{
    public class Usuario
    {

        public enum TipoUsuario
        {
            Administrador,
            Empleado
        }


        private string _nombreUsuario;
        private string _apellidoUsuario;
        private decimal _edadUsuario;
        private string _contraseñaUsuario;
        private TipoUsuario _tipoUsuario;
        private int _idUsuario;
       


        public TipoUsuario tipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value;}
        }

        public int idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }


        public string nombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        public string contraseñaUsuario
        {
            get { return _contraseñaUsuario; }
            set { _contraseñaUsuario = value; }
        }

        public string apellidoUsuario
        {
            get { return _apellidoUsuario; }
            set { _apellidoUsuario = value; }
        }

        public decimal edadUsuario
        {
            get { return _edadUsuario; }
            set { _edadUsuario = value; }
        }


        public Usuario()
        {
        
        }

        public Usuario(string nombreUsuario, string contraseñaUsuario, string apellido, decimal edad, TipoUsuario tipoUsuario):this()
        {
            _nombreUsuario = nombreUsuario;
            _contraseñaUsuario = contraseñaUsuario;
            _tipoUsuario = tipoUsuario;
            _apellidoUsuario = apellido;
            _edadUsuario = edad;

        }


        public int ObtenerUltimoId(List<Usuario> listaUsuarios)
        {
            int ultimoId = 0;

            if (listaUsuarios is not null)
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (usuario.idUsuario > ultimoId)
                    {
                        ultimoId = usuario.idUsuario;
                    }
                }
            }

                return ultimoId;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{nombreUsuario}");
            sb.Append($" {apellidoUsuario}");

            return sb.ToString();
        }

    }
}
