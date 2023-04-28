using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class ComidaPerro : Alimento
    {
        public ComidaPerro(decimal id, string nombre, decimal precio, decimal stock, SaborAlimento saborAlimento, CantidadKilos kilos, TipoAlimento tipo) : base(id , nombre, precio, stock, saborAlimento, kilos, tipo)
        {

        }
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(base.ToString());
        //    sb.AppendLine($"Sabor: {this.sabor}");
        //    return sb.ToString();
        //}
    }
}
