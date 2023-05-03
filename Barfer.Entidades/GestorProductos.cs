using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class GestorProductos
    {
        public static List<Alimento> alimento;


        static GestorProductos()
        {
            CargarAlimentoDesdeArchivo();
        }


        public static List<Alimento> CargarAlimentoDesdeArchivo()
        {
           alimento = Archivo.LeerDesdeArchivoAlimento();

            return alimento;
        }


        public static void AltaAlimento(Alimento producto)
        {
            if (producto == null)
            {
                throw new Exception("No se pudo dar de alta");
            }
            else
            {
                alimento.Add(producto);
            }

        }




        public static void BajaProducto(Alimento producto)
        {
            if (producto is not null)
            {
                alimento.Remove(producto);
            }
            else
            {
                throw new Exception("No se pudo eliminar");
            }
        }


        public static string TotalStock()
        {
            StringBuilder sb = new StringBuilder();
            decimal total = 0;
            foreach (Alimento item in alimento)
            {
                total += item.cantidad;
            }

            sb.AppendLine($"Total:{total.ToString()}");

            return sb.ToString();
        }
    }

}
