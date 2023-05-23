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
        private static string path = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Usuarios.csv";
        private static string pathAlimento = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Alimento.csv";
        private static string pathClientes = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Clientes.csv";






        //public static List<T> CargarElementosDesdeArchivo<T>(string path, string tipo)
        //{
        //    List<T> elementos = new List<T>();

        //    if (VerificarSiArchivoEstaCreado(path) == false)
        //    {



        //        Escritura.EscribirElementosEnArchivo(path);
        //        List<T> listaElementos = Lectura.CrearListaString<T>();
        //        elementos = listaElementos;
        //    }
        //    else
        //    {
        //        elementos = Lectura.CrearListaString<T>();
        //    }

        //    return elementos;
        //}





        /// <summary>
        /// Este método si el archivo no existe, primero lo crea y luego carga los usuarios.
        /// Si el archivo ya existe,simplemente carga los usuarios.
        /// </summary>
        /// <returns>Retorna lista de usuarios</returns>
        public static List<Usuario> CargarUsuariosDesdeArchivo()
        {
           List<Usuario> usuarios = new List<Usuario>();

            if (VerificarSiArchivoEstaCreado(path) == false)
            {
                Escritura.EscribirUsuariosEnArchivo(path);
                List<Usuario> listaString = Lectura.CrearListaStringUsuario();
                usuarios = listaString;
               // usuarios = Parser.ParserUsuario(listaString);
            }
            else
            {
                usuarios = Lectura.CrearListaStringUsuario();
            }

            return usuarios;
        }




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
