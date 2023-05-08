using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public class Cliente
    {
        private string _nombreCliente;
        private int _dni;
        private string _apellido;

        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
 
        public Cliente(string nombre, string apellido, int dni)
        {
            _nombreCliente = nombre;
            _apellido = apellido;
            _dni = dni;
        }


        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {NombreCliente}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Dni: {Dni}");
            return sb.ToString();
        }
    }
}
