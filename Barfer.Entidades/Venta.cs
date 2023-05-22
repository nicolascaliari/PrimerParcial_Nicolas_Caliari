using Barfer.Entidades.Archivos;
using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class Venta
    {
        public static List<Venta> ventas = new List<Venta>();
        public static List<Venta> ventasPreparacion = new List<Venta>();
        public static List<DateTime> entregasProgramadas = new List<DateTime>();




        private int _idVenta;
        private Cliente _cliente;
        public Cliente.Localidades _localidades;
        private Alimento _alimento;
        private int _cantidad;
        private decimal _precioTotal;
        private DateTime _fecha;
        private string _estado;
        private bool _enviar;




        public int idVenta { get => _idVenta; set => _idVenta = value; }
        public Cliente cliente { get => _cliente; set => _cliente = value; }
        public Cliente.Localidades localidades { get => _localidades; set => _localidades = value; }
        public Alimento alimento { get => _alimento; set => _alimento = value; }
        public int cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal precioTotal { get => _precioTotal; set => _precioTotal = value; }
        public DateTime fecha { get => _fecha; set => _fecha = value; }
        public string estado { get => _estado; set => _estado = value; }
        public bool enviar { get => _enviar; set => _enviar = value; }





        public Venta()
        {

        }

        public Venta(int idVenta,Cliente cliente, Cliente.Localidades localidad, Alimento alimento, int cantidad, decimal precioTotal, DateTime fecha)
        {
            _idVenta = idVenta;
            _cliente = cliente;
            _localidades = localidad;
            _alimento = alimento;
            _cantidad = cantidad;
            _precioTotal = precioTotal;
            _fecha = fecha;
            _estado = "Sin preparar";
            _enviar = false;
        }


        public static Venta GenerarVentas(List<Cliente> clientes, List<Alimento> alimentos)
        {
            // Generar ventas aleatorias
            Random random = new Random();
            // Obtener un cliente y un alimento aleatorios de las listas
            Cliente cliente = clientes[random.Next(clientes.Count)];
            Alimento alimento = alimentos[random.Next(alimentos.Count)];

            // Generar una cantidad aleatoria entre 1 y 5
            int cantidad = random.Next(1, 6);


            int idVenta = random.Next(1, 1000);

            // Calcular el precio total de la compra
            decimal precio = alimento.precio * cantidad;

            // Generar una fecha aleatoria en el último mes
            DateTime fecha = DateTime.Now.AddDays(-random.Next(1, 31));


            DescontarDelStock(alimentos, alimento, cantidad);


            Venta venta = new Venta(idVenta,cliente,cliente.Localidad ,alimento, cantidad, precio,fecha);

            return venta;
        }

        public static void GenerarVentasAleatorias(int cantidad, List<Cliente> clientes, List<Alimento> alimentos)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Venta venta = GenerarVentas(clientes, alimentos);
                ventas.Add(venta);
            }
        }



        private static void DescontarDelStock(List<Alimento> alimentos, Alimento alimento, int cantidad)
        {
            Alimento productoVendido = alimentos.FirstOrDefault(p => p.nombre == alimento.nombre);
            if (productoVendido != null)
            {
                decimal nuevoStock = productoVendido.cantidad -= cantidad;
                alimento.cantidad = nuevoStock;
                GuardarArchivo.GuardarAlimentoEnArchivo(GestorProductos.alimento);

            }
        }

    }
}
