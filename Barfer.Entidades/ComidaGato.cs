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
        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(base.ToString());
        //    sb.AppendLine($"Sabor: {this.sabor}");
        //    return sb.ToString();
        //}



    }
}
