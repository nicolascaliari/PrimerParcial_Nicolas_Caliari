using Barfer.Entidades;

namespace TestProducto
{
    [TestClass]
    public class CalcularAlimentoTest
    {
        [TestMethod]
        public void CalcularAlimento_CuandoElTipoNoEsNull_DeberiaRetornarLaCantidadDeComida()
        {
            string tipo = "Perro";
            Mascota perro = new Perro("asia", 10, 10, Mascota.TipoMascota.Perro);
           
            perro.CalcularAlimento(tipo);

            Assert.IsNotNull(tipo);
        }

        [TestMethod]
        public void CalcularAlimento_CuandoElTipoEsNull_DeberiaRetornarCero()
        {
            string tipo = null;
            Mascota perro = new Perro("asia", 10, 10, Mascota.TipoMascota.Perro);

            perro.CalcularAlimento(tipo);

            Assert.IsNull(tipo);
        }
    }
}