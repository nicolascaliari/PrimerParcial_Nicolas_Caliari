using Barfer.Entidades.Usuarios;
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
        private string _apellido;
        private Localidades _localidad;


        public enum Localidades
        {
            CABA,
            ZonaNorte,
            ZonaSur,
            ZonaOeste
        }



        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public Localidades Localidad { get => _localidad; set => _localidad = value; }
        


        public Cliente()
        {
        
        }


        public Cliente(string nombre, string apellido, Localidades localidad):this()
        {

            _nombreCliente = nombre;
            _apellido = apellido;
            _localidad = localidad;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();       
            sb.AppendLine($"{NombreCliente}");
            sb.AppendLine($" {Apellido}");
            
            return sb.ToString();
        }



    }
}
