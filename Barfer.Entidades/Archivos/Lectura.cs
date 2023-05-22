using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Barfer.Entidades.Alimento;
using static Barfer.Entidades.Cliente;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Barfer.Entidades.Archivos
{
    public class Lectura
    {
        private static string path = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Usuarios.csv";
        private static string pathAlimento = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Alimento.csv";
        private static string pathClientes = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Clientes.csv";
        public static string[] LeerUsuariosDeArchivo()
        {
            string[] textoUsuario = File.ReadAllLines(path);
            return textoUsuario;    
        }

        public static List<Usuario> CrearListaStringUsuario()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
        
            string[] lineas = LeerUsuariosDeArchivo();

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] datoUsuario = lineas[i].Split(',');

                TipoUsuario tipo = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), datoUsuario[5]);

                var usuario = FactoryMethodUsuario.CrearUsuario(tipo);
                usuario.idUsuario = int.Parse(datoUsuario[0]);
                usuario.nombreUsuario = datoUsuario[1];
                usuario.apellidoUsuario = datoUsuario[2];
                usuario.contraseñaUsuario = datoUsuario[3];
                usuario.edadUsuario = Decimal.Parse(datoUsuario[4]);
                usuario.tipoUsuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), datoUsuario[5]);
                listaUsuarios.Add(usuario);
            }
            return listaUsuarios;
        }








        public static string[] LeerAlimentoDeArchivo()
        {
            string[] lineas = File.ReadAllLines(pathAlimento);
            return lineas;
        }

        public static List<Alimento> CrearListaStringAlimento()
        {
            List<Alimento> listaAlimento = new List<Alimento>();

            string[] lineas = LeerAlimentoDeArchivo();

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] datoAlimento = lineas[i].Split(',');

                listaAlimento.Add(new Alimento
                {
                    id = int.Parse(datoAlimento[0]),
                    nombre = datoAlimento[1],
                    precio = decimal.Parse((datoAlimento[2])),
                    cantidad = decimal.Parse(((datoAlimento[3]))),
                    sabor = (SaborAlimento)Enum.Parse(typeof(SaborAlimento), datoAlimento[4]),
                    cantidadKilos = (CantidadKilos)Enum.Parse(typeof(CantidadKilos), datoAlimento[5]),
                    tipoAlimento = (TipoAlimento)Enum.Parse(typeof(TipoAlimento), datoAlimento[6]),
                });
            }
            return listaAlimento;
        }





        public static string[] LeerClienteDeArchivo()
        {
            string[] lineas = File.ReadAllLines(pathClientes);
            return lineas;
        }

        public static List<Cliente> CrearListaStringCliente()
        {
            List<Cliente> listaCliente = new List<Cliente>();

            string[] lineas = LeerClienteDeArchivo();

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] datoCliente = lineas[i].Split(',');

                listaCliente.Add(new Cliente
                {
                    NombreCliente = datoCliente[0],
                    Apellido = datoCliente[1],
                    Localidad = (Localidades)Enum.Parse(typeof(Localidades), datoCliente[2]),
                });
            }
            return listaCliente;
        }











    }
}
