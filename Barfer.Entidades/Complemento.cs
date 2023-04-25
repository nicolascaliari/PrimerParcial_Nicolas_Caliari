using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class Complemento: Producto
    {

        public Complemento(string nombre, decimal precio, decimal stock, decimal id, SaborAlimento saborAlimento, CantidadKilos kilos) : base(nombre, precio, stock, id, saborAlimento, kilos)
        {
        }
       
    }
}
