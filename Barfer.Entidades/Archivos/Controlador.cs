using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Archivos
{
    public class Controlador
    {
        private static string pathAlimento = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Alimento.csv";
        private static string pathClientes = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Clientes.csv";


        /// <summary>
        /// Este método si el archivo no existe, primero lo crea y luego carga los alimentos.
        /// Si el archivo ya existe,simplemente carga los alimentos.
        /// </summary>
        /// <returns>Retorna una lista de alimentos</returns>

        public static List<Alimento> CargarAlimentoDesdeArchivo()
        {
            List<Alimento> alimentos = new List<Alimento>();

            if (VerificarSiArchivoEstaCreado(pathAlimento) == false)
            {
                Escritura.EscribirAlimentoEnArchivo(pathAlimento);
                List<Alimento> listaString = Lectura.CrearListaStringAlimento();
                alimentos = listaString;
            }
            else
            {
                alimentos = Lectura.CrearListaStringAlimento();
            }

            return alimentos;
        }





        /// <summary>
        /// Este método si el archivo no existe, primero lo crea y luego carga los clientes.
        /// Si el archivo ya existe,simplemente carga los clientes.
        /// </summary>
        /// <returns>Retorna una lista de clientes</returns>
        public static List<Cliente> CargarClienteDesdeArchivo()
        {
            List<Cliente> clientes = new List<Cliente>();

            if (VerificarSiArchivoEstaCreado(pathClientes) == false)
            {
                Escritura.EscribirClienteEnArchivo(pathClientes);
                List<Cliente> listaString = Lectura.CrearListaStringCliente();
                clientes = listaString;
            }
            else
            {
                clientes = Lectura.CrearListaStringCliente();
            }

            return clientes;
        }



        /// <summary>
        /// Este metodo verifica si el archivo pasado por parametro existe o no.
        /// </summary>
        /// <param name="rutas"></param>
        /// <returns>Retorna un bool</returns>
        private static bool VerificarSiArchivoEstaCreado(string rutas)
        {
            bool respuesta = false;
            if (File.Exists(rutas))
            {
                respuesta = true;
            }

            return respuesta;
        }
    }
}
