using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class Creador
    {
        public const int perro = 1;
        public const int gato = 2;

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
