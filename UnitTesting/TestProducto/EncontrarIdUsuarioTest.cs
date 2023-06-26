using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProducto
{
    [TestClass]
    public class EncontrarIdUsuarioTest
    {
        [TestMethod]
        public void EncontrarIdUsuario_DebeDevolverIdCorrecto()
        {

            Usuario usuario = new Usuario(1,"nicolas", "caliari",20,"Nico123",1);
            GestorDeUsuarios.usuarios.Add(usuario);
            string nombre = "nicolas";
            string pass = "Nico123";
            int idEsperado = 1;

            // Act
            int idObtenido = Validador.EncontrarIdUsuario(nombre, pass);

            // Assert
            Assert.AreEqual(idEsperado, idObtenido);
        }

        [TestMethod]
        public void EncontrarIdUsuario_DebeLanzarExcepcionSiUsuarioNoEncontrado()
        {
            // Arrange
            string nombre = "usuario_inexistente";
            string pass = "contraseña_incorrecta";

            // Assert
            Assert.ThrowsException<LoginFallidoException>(() => Validador.EncontrarIdUsuario(nombre, pass));
        }
    }
}
