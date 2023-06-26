using Barfer.Entidades.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class Perro : Mascota
    {
        /// <summary>
        /// Constructor usado para factoryMethod
        /// </summary>
        /// <param name="perro"></param>
        public Perro(TipoMascota perro) : this("", 1, 1, perro)
        {
        }

        public Perro(string nombre, int edad, double peso, TipoMascota tipo) : base(nombre, edad, peso, tipo)
        {
        }


        /// <summary>
        /// este método calcula la cantidad de alimento requerida para un perro en función de su edad y peso.
        /// </summary>
        /// <param name="tipoAnimal"></param>
        /// <returns>Retorna double</returns>
        public override double CalcularAlimento(string tipoAnimal)
        {
            if (Validador.ValidarString(tipoAnimal))
            {
                if (Edad >= 2 && Edad <= 4)
                {
                    return 0.03 * Peso;
                }
                else if (Edad > 4 && Edad <= 6)
                {
                    return 0.035 * Peso;
                }
                else if (Edad > 6 && Edad <= 8)
                {
                    return 0.04 * Peso;
                }
                else if (Edad > 8 && Edad <= 10)
                {
                    return 0.045 * Peso;
                }
                else if (Edad > 10 && Edad <= 12)
                {
                    return 0.05 * Peso;
                }
            }
                return 0;
        }

        /// <summary>
        /// Metodo para mostrar la mascota
        /// </summary>
        /// <returns>Retorna string</returns>
        public override string MostrarMascota()
        {
            return base.MostrarMascota();
        }


    }
}
