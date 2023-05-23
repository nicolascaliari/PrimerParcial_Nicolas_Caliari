using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class FactoryMethod
    {
        public const int perro = 1;
        public const int gato = 2;

        /// <summary>
        /// Metodo que crea una mascota dependiendo su tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns>Retorna la mascota</returns>
        public static Mascota CrearMascota(string tipo)
        {
            Mascota mascota = null;
            switch (tipo)
            {
                case "Perro":
                    mascota = new Perro(Mascota.TipoMascota.Perro);
                    break;
                case "Gato":
                    mascota = new Gato(Mascota.TipoMascota.Gato);
                    break;
            }
            return mascota;
        }
    }
}
