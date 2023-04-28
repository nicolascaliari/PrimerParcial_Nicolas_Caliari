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
        private decimal _id;
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


        public decimal id
        {
            get { return _id; }
            set { _id = value; }
        }


        public Alimento()
        {

        }



        public Alimento(decimal id, string nombre, decimal precio, decimal cantidad, SaborAlimento saborAlimento, CantidadKilos kilos, TipoAlimento tipo)
        {
            _id = id;
            _nombre = nombre;         
            _precio = precio;
            _cantidad = cantidad;
            _sabor = saborAlimento;
            _cantidadKilos = kilos;
            _tipoAlimento = tipo;
         

        }



        public virtual string MostrarProducto(Alimento producto)
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine($"Nombre: {_nombre}");
            sb.AppendLine($"Precio: {_precio}");
            sb.AppendLine($"Cantidad: {_cantidad}");
            sb.AppendLine($"Sabor: {_sabor}");
            sb.AppendLine($"Cantidad de kilos: {_cantidadKilos}");


            return sb.ToString();

        }
    }
}
