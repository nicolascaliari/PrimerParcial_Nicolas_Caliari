using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class Gato : Mascota
    {
        /// <summary>
        /// Constrcutor usado para factoryMethod
        /// </summary>
        /// <param name="gato"></param>
        public Gato(TipoMascota gato) : this("", 1, 1, gato)
        {
        }


        public Gato(string nombre, int edad, double peso, TipoMascota tipo) : base(nombre, edad, peso, tipo)
        {
        }


        /// <summary>
        /// este método calcula la cantidad de alimento requerida para un gato en función de su edad y peso.
        /// </summary>
        /// <param name="tipoAnimal"></param>
        /// <returns>Retorna double</returns>
        public override double CalcularAlimento(string tipoAnimal)
        {
            if (tipoAnimal == "Gato")
            {
                if (Edad >= 2 && Edad <= 4)
                {
                    return 0.025 * Peso;
                }
                else if (Edad > 4 && Edad <= 6)
                {
                    return 0.03 * Peso;
                }
                else if (Edad > 6 && Edad <= 8)
                {
                    return 0.035 * Peso;
                }
                else if (Edad > 8 && Edad <= 10)
                {
                    return 0.04 * Peso;
                }
                else if (Edad > 10 && Edad <= 12)
                {
                    return 0.045 * Peso;
                }
            }
            return 0;
        }


    }
}
