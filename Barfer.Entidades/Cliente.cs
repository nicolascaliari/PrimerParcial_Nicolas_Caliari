using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Barfer.Entidades
{
    public class Cliente
    {
        private int _id;
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


        public int id { get => _id; set => _id = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public Localidades Localidad { get => _localidad; set => _localidad = value; }


        /// <summary>
        /// Constructor usado para cargar los datos del archivo a un cliente
        /// </summary>
        public Cliente()
        {
        
        }

        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="localidad"></param>
        public Cliente(int id,string nombre, string apellido, int localidad):this()
        {
            _id = id;
            _nombreCliente = nombre;
            _apellido = apellido;

            if (Enum.IsDefined(typeof(Localidades), localidad))
            {
                Localidad = (Localidades)localidad;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(Localidad), "Índice de enum no válido");
            }
        }

        /// <summary>
        /// Sobreescritura del metodo ToString para mostrar el nombre y apellido del cliente
        /// </summary>
        /// <returns>Retorna string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();       
            sb.AppendLine($"{NombreCliente}");
            sb.AppendLine($" {Apellido}");
            
            return sb.ToString();
        }



    }
}
