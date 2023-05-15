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



        /// <summary>
        /// Metodo que carga los productos desde el archivo a la lista alimento
        /// </summary>
        /// <returns>Retorna la lista</returns>
        public static List<Alimento> CargarAlimentoDesdeArchivo()
        {
           alimento = Archivo.LeerDesdeArchivoAlimento();

            return alimento;
        }



        /// <summary>
        /// Metodo que agrega un producto a la lista alimento
        /// </summary>
        /// <param name="producto"></param>
        /// <exception cref="Exception"></exception>
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



        /// <summary>
        /// Metodo que elimina un producto de la lista alimento
        /// </summary>
        /// <param name="producto"></param>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Metodo que devuelve el total de stock que tiene la lista alimento
        /// </summary>
        /// <returns>Retorna string</returns>
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
