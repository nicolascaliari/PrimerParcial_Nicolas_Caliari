using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class Calculadora
    {

        //Porcentajes de perros cachorros
        static double porcentajesDosACuatro = 0.1;
        static  double porcentajesCuatroASeis = 0.08;
        static double porcentajesSeisAOcho = 0.06;
        static double porcentajesOchoADiez = 0.04;
        static double porcentajesDiezADoce = 0.03;

        //porcentajes de perros adultos
        static double porcentajeBajo = 0.02;
        static double porcentajeMedio = 0.025;
        static double porcentajeAlto = 0.03;





        public static double CalcularPerro(string opcionMascota, string opcionEdad, double peso)
        {
            double resultado = 0;
            string resultadoEdad = "";
            double resultadoFinal = 0;

            if (opcionMascota == "perro cachorro")
            {
                resultadoEdad = EdadPerroCachorro(opcionEdad);
            }else if(opcionMascota == "perro adulto")
            {
                if (opcionEdad == "actividad baja")
                {
                    resultado = peso * porcentajeBajo;
                    
                }
                else if (opcionEdad == "actividad media")
                {
                    resultado = peso * porcentajeMedio;
                    
                }
                else if (opcionEdad == "actividad alta")
                {
                    resultado = peso * porcentajeAlto;
                    
                }
            }

            if(resultado < 1)
            {
              resultadoFinal = resultado * 1000;
            }
            else
            {
                resultadoFinal = resultado;
            }


            return resultadoFinal;
        }


        private static string EdadPerroCachorro(string opcionEdad)
        {
            string resultado = "";
            if (opcionEdad == "2-4")
            {
                resultado = opcionEdad;

            }
            else if (opcionEdad == "4-6")
            {
                resultado = opcionEdad;

            }
            else if (opcionEdad == "6-8")
            {
                resultado = opcionEdad;

            }
            else if (opcionEdad == "8-10")
            {
                resultado = opcionEdad;

            }
            else if (opcionEdad == "10-12")
            {
                resultado = opcionEdad;

            }

            return resultado;
        }





    }
}
