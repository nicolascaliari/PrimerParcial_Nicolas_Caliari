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

        public Usuario Cliente { get; set; }
        public Alimento.TipoAlimento Alimento { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }

        public Venta()
        {

        }

        public Venta(Usuario cliente, Alimento.TipoAlimento alimento, int cantidad, decimal precioTotal, DateTime fecha)
        {
            Cliente = cliente;
            Alimento = alimento;
            Cantidad = cantidad;
            PrecioTotal = precioTotal;
            Fecha = fecha;
            Estado = false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Cliente.nombreUsuario.ToString()}");
            sb.Append($"{Alimento}");
            sb.Append($" {Cantidad}");
            sb.Append($" ${PrecioTotal}");
            sb.Append($"Fecha: {Fecha}");
                return sb.ToString();
        }

        public static Venta GenerarVentas(List<Usuario> clientes, List<Alimento> alimentos)
        {
            // Generar ventas aleatorias
            Random random = new Random();
            // Obtener un cliente y un alimento aleatorios de las listas
            Usuario cliente = clientes[random.Next(clientes.Count)];
            Alimento alimento = alimentos[random.Next(alimentos.Count)];

            // Generar una cantidad aleatoria entre 1 y 5
            int cantidad = random.Next(1, 6);

            // Calcular el precio total de la compra
            decimal precio = alimento.precio * cantidad;

            // Generar una fecha aleatoria en el último mes
            DateTime fecha = DateTime.Now.AddDays(-random.Next(1, 31));
            Venta venta = new Venta(cliente,alimento.tipoAlimento, cantidad, precio,fecha);

            return venta;
        }

        public static void GenerarVentasAleatorias(int cantidad, List<Usuario> clientes, List<Alimento> alimentos)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Venta venta = GenerarVentas(clientes, alimentos);
                ventas.Add(venta);
            }
        }



    }
}
