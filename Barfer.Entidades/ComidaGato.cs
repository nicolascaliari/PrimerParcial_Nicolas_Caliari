using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class ComidaGato : Producto
    {
        public ComidaGato(string nombre, decimal precio, decimal stock, decimal id, SaborAlimento saborAlimento, CantidadKilos kilos) : base(nombre, precio, stock, id, saborAlimento, kilos)
        {

        }

        public override string MostrarProducto(Producto producto)
        {
            return base.MostrarProducto(producto);
        }



    }
}
