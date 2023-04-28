using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class Complemento: Alimento
    {

        public Complemento(decimal id, string nombre, decimal precio, decimal stock,SaborAlimento saborAlimento, CantidadKilos kilos, TipoAlimento tipo) : base(id, nombre, precio, stock, saborAlimento, kilos, tipo)
        {
        }
       
    }
}
