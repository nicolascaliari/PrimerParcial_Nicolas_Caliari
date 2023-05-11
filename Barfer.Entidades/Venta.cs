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




        public int _idVenta { get; set; }
        public Cliente Cliente { get; set; }

        public Cliente.Localidades Localidades { get; set; }
        public Alimento.TipoAlimento Alimento { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public bool Enviar { get; set; }

        public Venta()
        {

        }

        public Venta(int idVenta,Cliente cliente, Cliente.Localidades localidad,Alimento.TipoAlimento alimento, int cantidad, decimal precioTotal, DateTime fecha)
        {
            _idVenta = idVenta;
            Cliente = cliente;
            Localidades = localidad;
            Alimento = alimento;
            Cantidad = cantidad;
            PrecioTotal = precioTotal;
            Fecha = fecha;
            Estado = "Sin preparar";
            Enviar = false;
        }

        public static string Mostrar(List<Venta> venta)
        {
            foreach (Venta item in venta)
            {

                StringBuilder sb = new StringBuilder();
                sb.Append($"ID: {item._idVenta}");
                sb.Append($"{item.Cliente.NombreCliente.ToString()}");
                sb.Append($"{item.Alimento}");
                sb.Append($" {item.Cantidad}");
                sb.Append($" ${item.PrecioTotal}");
                sb.AppendLine($"");
                return sb.ToString();
            }


            return null;

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
            Venta venta = new Venta(idVenta,cliente,cliente.Localidad ,alimento.tipoAlimento, cantidad, precio,fecha);

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



    }
}
