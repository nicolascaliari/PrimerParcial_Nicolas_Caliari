﻿using Barfer.Entidades.SQL;
using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;
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


        /// <summary>
        /// Inicializa la carga de datos de los alimentos.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public static async Task Inicializar()
        {
            await CargarAlimento();
        }

        /// <summary>
        /// Carga los datos de los alimentos desde la base de datos.
        /// </summary>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public static async Task CargarAlimento()
        {
            var datos = new AlimentoDB();
             alimento = await datos.TraerAsync();
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
                throw new ExceptionCampos("Hubo un error al dar de alta");
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
                throw new ExceptionCampos("Hubo un error al eliminar un producto");
            }
        }

        /// <summary>
        /// Metodo que devuelve el total de stock que tiene la lista alimento
        /// </summary>
        /// <returns>Retorna string</returns>
        public static string TotalStock()
        {
            decimal total = alimento.Sum(item => item.cantidad);

            Func<decimal, string> formatTotal = value => $"Total: {value}";

            return formatTotal(total);
        }


    }

}
