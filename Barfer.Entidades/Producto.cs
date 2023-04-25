using System.Text;

namespace Barfer.Entidades
{
    public class Producto
    {
        private string _nombre;
        private decimal _precio;
        private decimal _cantidad;
        private decimal _id;
        private SaborAlimento _sabor;
        private CantidadKilos _cantidadKilos;


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


        public Producto(string nombre, decimal precio, decimal cantidad, decimal id, SaborAlimento saborAlimento, CantidadKilos kilos)
        {
            _cantidadKilos = kilos;
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
            _id = id;
            _sabor = saborAlimento;
           
        }



        public virtual string MostrarProducto(Producto producto)
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