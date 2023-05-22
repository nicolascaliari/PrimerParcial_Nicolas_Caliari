using Barfer.Entidades.Usuarios;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class Alimento
    {
        private string _nombre;
        private decimal _precio;
        private decimal _cantidad;
        private int _id;
        private SaborAlimento _sabor;
        private CantidadKilos _cantidadKilos;
        private TipoAlimento _tipoAlimento;



        public enum TipoAlimento
        {
            perro,
            gato,
            complemento,
        }


        public enum SaborAlimento
        {
            cerdo,
            vaca,
            pollo,
            cornalito,
            sardinas,
        }

        public enum CantidadKilos
        {
            cincoKilos,
            diezKilos,
        }



        public TipoAlimento tipoAlimento
        {
            get { return _tipoAlimento; }
            set { _tipoAlimento = value;}
        }


        public CantidadKilos cantidadKilos
        {
            get { return _cantidadKilos; }
            set { _cantidadKilos = value; }
        }


        public SaborAlimento sabor
        {
            get { return _sabor; }
            set { _sabor = value; }
        }




        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public decimal precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        public decimal cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }


        public Alimento()
        {

        }


        public Alimento(string nombre, decimal precio, decimal cantidad, SaborAlimento saborAlimento, CantidadKilos kilos, TipoAlimento tipo):this()
        {
            _nombre = nombre;         
            _precio = precio;
            _cantidad = cantidad;
            _sabor = saborAlimento;
            _cantidadKilos = kilos;
            _tipoAlimento = tipo;
         

        }

        /// <summary>
        /// Metodo para obtener el ultimo id de la lista de alimentos
        /// </summary>
        /// <param name="listaAlimento"></param>
        /// <returns>Retorna un entero</returns>
        public int ObtenerUltimoIdAlimentos(List<Alimento> listaAlimento)
        {
            int ultimoId = 0;

            if (listaAlimento is not null)
            {
                foreach (Alimento alimento in listaAlimento)
                {
                    if (alimento.id > ultimoId)
                    {
                        ultimoId = alimento.id;
                    }
                }
            }

            return ultimoId;
        }


        public override string ToString()
        {
           
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{nombre}");


            return sb.ToString();
        }




        /// <summary>
        /// Metodo para mostrar el producto eliminado
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Retorna los datos del alimento eliminado</returns>
        public static string MostrarProductoEliminado(Alimento producto)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Usted elimino el siguiente producto");
            sb.AppendLine($"Nombre: {producto.nombre}");
            sb.AppendLine($"Precio: {producto.precio}");
            sb.AppendLine($"Cantidad: {producto.cantidad}");
            sb.AppendLine($"Sabor: {producto.sabor}");
            sb.AppendLine($"Cantidad de kilos: {producto.cantidadKilos}");


            return sb.ToString();

        }


     
    }
}
