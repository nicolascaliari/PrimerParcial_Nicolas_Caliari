 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Barfer.Entidades.Usuarios
{
    public class Usuario
    {
        public static string name;
        public static int idVerificador { get; set; }
        public enum TipoUsuario
        {
            Administrador = 1,
            Empleado
        }


        private string _nombreUsuario;
        private string _apellidoUsuario;
        private decimal _edadUsuario;
        private string _password;
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

        public string password
        {
            get { return _password; }
            set { _password = value; }
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

        public Usuario(int id, string nombre, string apellido, decimal edad, string password, int tipo):this()
        {
            this.nombreUsuario = nombre;
            this.idUsuario = id;
            this.edadUsuario = edad;
            this.apellidoUsuario=apellido;
            this.password = password;
            if (Enum.IsDefined(typeof(TipoUsuario), tipo))
            {
                tipoUsuario = (TipoUsuario)tipo;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(tipoUsuario), "Índice de enum no válido");
            }
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

            sb.AppendLine($"{idUsuario}");
            sb.AppendLine($"{nombreUsuario}");
            sb.AppendLine($" {apellidoUsuario}");
            sb.AppendLine($" {edadUsuario}");
            sb.AppendLine($" {password}");
            sb.AppendLine($"{tipoUsuario}");
    
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que busca a un usuario por su id y retorna su nombre y apellido
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

        public static explicit operator Usuario(DataRow row)
        {
            var id = Convert.ToInt32(row["id"].ToString());
            var nombre = row["nombre"].ToString();
            var apellido = row["apellido"].ToString();
            var edad = Convert.ToInt32(row["edad"].ToString());
            var password = row["password"].ToString();
            var tipo = Convert.ToInt32(row["idTipoUsuario"].ToString());

            Usuario usuario = new Usuario(id, nombre, apellido,edad,password,tipo);
            return usuario;
        }
    }
}
