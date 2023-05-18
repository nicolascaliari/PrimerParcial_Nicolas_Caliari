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

        public static List<Usuario> CargarUsuariosDesdeArchivo()
        {
           List<Usuario> usuarios = new List<Usuario>();

            if (VerificarSiArchivoEstaCreado(path))
            {
                Escritura.EscribirUsuariosEnArchivo(path);
                List<Usuario> listaString = Lectura.CrearListaStringUsuario();
               // usuarios = Parser.ParserUsuario(listaString);
            }
            else
            {
                usuarios = Lectura.CrearListaStringUsuario();
            }

            return usuarios;
        }






        public static List<Alimento> CargarAlimentoDesdeArchivo()
        {
            List<Alimento> alimentos = new List<Alimento>();

            if (VerificarSiArchivoEstaCreado(pathAlimento))
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






        private static bool VerificarSiArchivoEstaCreado(string rutas)
        {
            bool respuesta = false;
            if (!File.Exists(rutas))
            {
                respuesta = true;
            }

            return respuesta;
        }
    }
}
