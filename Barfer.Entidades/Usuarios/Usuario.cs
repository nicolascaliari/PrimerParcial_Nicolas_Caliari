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
        //  private List<Usuario> _usuarios;


        public TipoUsuario tipoUsuario
        {
            get { return _tipoUsuario; }
        }



        //public List<Usuario> usuarios
        //{
        //    get { return _usuarios; }
        //    set { _usuarios = value; }
        //}


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


        //public Usuario()
        //{
        //    usuarios = new List<Usuario>();
        //}


        public Usuario(string nombreUsuario, string contraseñaUsuario, string apellido, decimal edad, TipoUsuario tipoUsuario)
        {
            _nombreUsuario = nombreUsuario;
            _contraseñaUsuario = contraseñaUsuario;
            _tipoUsuario = tipoUsuario;
            _apellidoUsuario = apellido;
            _edadUsuario = edad;

        }

    }
}
