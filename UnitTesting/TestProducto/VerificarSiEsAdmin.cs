using Barfer.Entidades.Usuarios;
using Barfer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Barfer.Entidades.Usuarios.Usuario;
using static Barfer.Entidades.Validaciones.Validador;
using Barfer.Entidades.Validaciones;

namespace TestProducto
{
    [TestClass]
    public class VerificarSiEsAdmin
    {
        [TestMethod]

        public void VerificarSiEsAdmin_DebeDevolverOpcionAdministradorSiUsuarioEsAdmin()
        {
            int idUsuario = 1;
            List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario(1,"nicolas","caliari",21,"Nico123",1)
        };
            OpcionTipo opcionEsperada = OpcionTipo.administrador;


            OpcionTipo opcionObtenida = Validador.VerificarSiEsAdmin(idUsuario, usuarios);

            Assert.AreEqual(opcionEsperada, opcionObtenida);
        }

        [TestMethod]
        public void VerificarSiEsAdmin_DebeDevolverOpcionEmpleadoSiUsuarioNoEsAdmin()
        {

            int idUsuario = 2;
            List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario(2,"malena","illan",21,"Male123",2)

        };
            OpcionTipo opcionEsperada = OpcionTipo.empleado;


            OpcionTipo opcionObtenida = Validador.VerificarSiEsAdmin(idUsuario, usuarios);

            Assert.AreEqual(opcionEsperada, opcionObtenida);
        }

        [TestMethod]
        public void VerificarSiEsAdmin_DebeDevolverOpcionErrorSiUsuarioNoExiste()
        {
            int idUsuario = 5;
            List<Usuario> usuarios = new List<Usuario>
        {
             new Usuario(3,"pedro","fernandez",21,"Pedro123",2)
        };
            OpcionTipo opcionEsperada = OpcionTipo.error;


            OpcionTipo opcionObtenida = Validador.VerificarSiEsAdmin(idUsuario, usuarios);


            Assert.AreEqual(opcionEsperada, opcionObtenida);
        }
    }
}
