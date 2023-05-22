 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Barfer.Entidades.Usuarios
{
    public abstract class Usuario
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


        /// <summary>
        /// Constructor de la clase Usuario
        /// </summary>
        public Usuario()
        {
        
        }


        /// <summary>
        /// Constructor de la clase Usuario
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contraseñaUsuario"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="tipoUsuario"></param>
        public Usuario(string nombreUsuario, string contraseñaUsuario, string apellido, decimal edad, TipoUsuario tipoUsuario):this()
        {
            _nombreUsuario = nombreUsuario;
            _contraseñaUsuario = contraseñaUsuario;
            _tipoUsuario = tipoUsuario;
            _apellidoUsuario = apellido;
            _edadUsuario = edad;

        }


        /// <summary>
        /// Metodo que obtiene el ultimo id de la lista de usuarios
        /// </summary>
        /// <param name="listaUsuarios"></param>
        /// <returns>Retorna un int</returns>
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


        /// <summary>
        /// Metodo override de ToString para mostrar el nombre y apellido del usuario
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{nombreUsuario}");
            sb.Append($" {apellidoUsuario}");

            return sb.ToString();
        }

        /// <summary>
        /// Metodo que busca a un usuaruo por su id y retorna su nombre y apellido
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="usuarios"></param>
        /// <returns>Retorna string</returns>
        public static string GetNombreApellido(int userId, List<Usuario> usuarios)
        {
            StringBuilder sb = new StringBuilder();

            Usuario usuario = usuarios.FirstOrDefault(u => u.idUsuario == userId);
            if (usuario != null)
            {
                sb.AppendLine(usuario.tipoUsuario.ToString());
                sb.AppendLine();
                sb.AppendLine(usuario.nombreUsuario);
                sb.AppendLine();
                sb.AppendLine(usuario.apellidoUsuario);


                return sb.ToString();
            }
            else
            {
                return "No se encontró ningún usuario con ese ID";
            }
        }
    }
}
