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
        public static List<Producto> producto;


        static GestorProductos()
        {
            CargarProductos();
        }


        public static void CargarProductos()
        {
            producto = new List<Producto>()
            {
                    new ComidaGato("Comida Gato", 100, 10, 1, Producto.SaborAlimento.cerdo, Producto.CantidadKilos.diezKilos),
                    new ComidaPerro("Comida Perro", 100, 10, 2, Producto.SaborAlimento.cerdo, Producto.CantidadKilos.diezKilos),
                    new ComidaGato("Comida Gato", 100, 10, 3, Producto.SaborAlimento.vaca, Producto.CantidadKilos.cincoKilos),
                    new ComidaPerro("Comida Perro", 100, 10, 4, Producto.SaborAlimento.cerdo, Producto.CantidadKilos.diezKilos),
                    new ComidaGato("Comida Gato", 100, 10, 5, Producto.SaborAlimento.cerdo, Producto.CantidadKilos.diezKilos),
                    new ComidaPerro("Comida Perro", 100, 10, 6, Producto.SaborAlimento.pollo, Producto.CantidadKilos.cincoKilos),
                    new ComidaGato("Comida Gato", 100, 10, 7, Producto.SaborAlimento.vaca, Producto.CantidadKilos.diezKilos),
                    new ComidaPerro("Comida Perro", 100, 10, 8, Producto.SaborAlimento.cerdo, Producto.CantidadKilos.diezKilos),
                    new ComidaGato("Comida Gato", 100, 10, 9, Producto.SaborAlimento.cerdo, Producto.CantidadKilos.cincoKilos),
                    new ComidaPerro("Comida Perro", 100, 10, 10, Producto.SaborAlimento.pollo, Producto.CantidadKilos.diezKilos),
                    new ComidaGato("Comida Gato", 100, 10, 11, Producto.SaborAlimento.cerdo, Producto.CantidadKilos.diezKilos),
                    new ComidaPerro("Comida Perro", 100, 10, 12, Producto.SaborAlimento.vaca, Producto.CantidadKilos.cincoKilos),




            };
        }


        public static void AltaProductoGato(ComidaGato producto)
        {
            if (producto == null)
            {
                throw new Exception("No se pudo dar de alta");
            }
            else
            {
                GestorProductos.producto.Add(producto);
            }

        }

        public static void AltaProductoPerro(ComidaPerro producto)
        {
            if (producto == null)
            {
                throw new Exception("No se pudo dar de alta");
            }
            else
            {
                GestorProductos.producto.Add(producto);
            }

        }



        public static void BajaProducto(Producto producto)
        {
            if (producto is not null)
            {
                GestorProductos.producto.Remove(producto);
            }
            else
            {
                throw new Exception("No se pudo eliminar");
            }
        }
    }

}
