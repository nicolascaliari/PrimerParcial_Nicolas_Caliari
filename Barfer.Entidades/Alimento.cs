using Barfer.Entidades.Usuarios;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Barfer.Entidades.Alimento;
using static Barfer.Entidades.Usuarios.Usuario;

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
            perro = 1,
            gato,
            complemento,
        }


        public enum SaborAlimento
        {
            cerdo = 1,
            vaca,
            pollo,
            cornalito,
            sardinas,
        }

        public enum CantidadKilos
        {
            cincoKilos = 1,
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

        /// <summary>
        /// Constructor usado para cargar los datos del archivo a un alimento
        /// </summary>
        public Alimento()
        {

        }


        public Alimento(string nombre, decimal precio, decimal cantidad, int saborAlimento, int kilos, int tipo)
        {
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;


            if (Enum.IsDefined(typeof(SaborAlimento), saborAlimento))
            {
                sabor = (SaborAlimento)saborAlimento;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(sabor), "Índice de enum no válido");
            }


            if (Enum.IsDefined(typeof(CantidadKilos), kilos))
            {
                cantidadKilos = (CantidadKilos)kilos;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(cantidadKilos), "Índice de enum no válido");
            }


            if (Enum.IsDefined(typeof(TipoAlimento), tipo))
            {
                tipoAlimento = (TipoAlimento)tipo;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(tipoAlimento), "Índice de enum no válido");
            }
            //MetodoGenerico(SaborAlimento, saborAlimento);
            //MetodoGenerico();
            //MetodoGenerico();




        }






        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <param name="saborAlimento"></param>
        /// <param name="kilos"></param>
        /// <param name="tipo"></param>
        public Alimento(int id , string nombre, decimal precio, decimal cantidad, int saborAlimento, int kilos, int tipo)
        {
            _id = id;
            _nombre = nombre;         
            _precio = precio;
            _cantidad = cantidad;


            if (Enum.IsDefined(typeof(SaborAlimento), saborAlimento))
            {
                sabor = (SaborAlimento)saborAlimento;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(sabor), "Índice de enum no válido");
            }


            if (Enum.IsDefined(typeof(CantidadKilos), kilos))
            {
                cantidadKilos = (CantidadKilos)kilos;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(cantidadKilos), "Índice de enum no válido");
            }


            if (Enum.IsDefined(typeof(TipoAlimento), tipo))
            {
                tipoAlimento = (TipoAlimento)tipo;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(tipoAlimento), "Índice de enum no válido");
            }
            //MetodoGenerico(SaborAlimento, saborAlimento);
            //MetodoGenerico();
            //MetodoGenerico();


         

        }


        //public void MetodoGenerico<T>(T saborAlimento, out T sabor) where T : struct, Enum
        //{
        //    // Código del método que utiliza el parámetro genérico
        //    if (Enum.IsDefined(typeof(T), saborAlimento))
        //    {
        //        sabor = (T)saborAlimento;
        //    }
        //    else
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(sabor), "Índice de enum no válido");
        //    }
        //}




        /// <summary>
        /// Metodo para obtener el ultimo id de la lista de alimentos
        /// </summary>
        /// <param name="listaAlimento"></param>
        /// <returns>Retorna un int</returns>
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


        /// <summary>
        /// Sobreescritura del metodo ToString para mostrar el nombre del alimento
        /// </summary>
        /// <returns>Retorna string</returns>
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

        public static explicit operator Alimento(DataRow row)
        {

            var id = Convert.ToInt32(row["id"].ToString());
            var nombre = row["nombre"].ToString();
            var precio = Convert.ToInt32(row["precio"].ToString());
            var cantidad = Convert.ToInt32(row["cantidad"].ToString());
            var tipo = Convert.ToInt32(row["idTipoAlimento"].ToString());
            var sabor = Convert.ToInt32(row["idSaborAlimento"].ToString());
            var kilos = Convert.ToInt32(row["idKilos"].ToString());
            Alimento alimento = new Alimento(id, nombre, precio, cantidad, sabor, kilos,tipo);
            return alimento;
        }
    }
}
