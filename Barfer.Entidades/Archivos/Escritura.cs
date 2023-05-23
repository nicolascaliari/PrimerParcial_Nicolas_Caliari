using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades.Archivos
{
    public class Escritura
    {

        /// <summary>
        /// Este metodo crea el archivo de usuarios y lo escribe.
        /// </summary>
        /// <param name="path"></param>
        public static void EscribirUsuariosEnArchivo(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("id,nombre,apellido,contrasenia,edad,tipo de usuario");
                streamWriter.WriteLine("1,nicolas,caliari,Agunic1004,21,Administrador");
                streamWriter.WriteLine("2,malena,illan,Elrojo12,20,Empleado");
            }
        }



        /// <summary>
        /// Este metodo crea el archivo de alimento y lo escribe.
        /// </summary>
        /// <param name="path"></param>
        public static void EscribirAlimentoEnArchivo(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("id,nombre producto,precio,cantidad,sabor,kilos,tipo");
                streamWriter.WriteLine("1,perro pollo con vegetales,2000,100,pollo,cincoKilos,perro");
                streamWriter.WriteLine("2,gato vaca con vegetales,2000,120,vaca,diezKilos,gato");
                streamWriter.WriteLine("3,perro pollo sin vegetales,2000,300,pollo,cincoKilos,perro");
                streamWriter.WriteLine("4,gato vaca sin vegetales,2000,200,vaca,diezKilos,gato");
                streamWriter.WriteLine("5,Cornalitos,2000,80,pollo,cincoKilos,complemento");
                streamWriter.WriteLine("6,Sardinas,2000,134,vaca,diezKilos,complemento");
                streamWriter.WriteLine("7,perro pollo,2000,122,pollo,cincoKilos,perro");
                streamWriter.WriteLine("8,snack de pollo,2000,177,vaca,diezKilos,gato");
                streamWriter.WriteLine("9,snack de higado,2000,77,pollo,cincoKilos,perro");
                streamWriter.WriteLine("10,hueso recreativo,2000,99,vaca,diezKilos,gato");
            }
        }


        /// <summary>
        /// Este metodo crea el archivo de clientes y lo escribe.
        /// </summary>
        /// <param name="path"></param>
        public static void EscribirClienteEnArchivo(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {

                streamWriter.WriteLine("nombre,apellido,localidad");
                streamWriter.WriteLine("nicolas,caliari,CABA");
                streamWriter.WriteLine("pedro,fernandez,ZonaNorte");
                streamWriter.WriteLine("matias,ruiz,CABA");
                streamWriter.WriteLine("esteban,gonzales,ZonaSur");
                streamWriter.WriteLine("richard,garcia,ZonaSur");
                streamWriter.WriteLine("leonardo,perez,ZonaNorte");
                streamWriter.WriteLine("gustavo,rojas,ZonaOeste");
                streamWriter.WriteLine("mauro,rivera,ZonaNorte");
                streamWriter.WriteLine("tomas,sanchez,ZonaOeste");
                streamWriter.WriteLine("ulises,rodriguez,ZonaOeste");
                streamWriter.WriteLine("nicolas,caliari,ZonaOeste");
                streamWriter.WriteLine("malena,illan,ZonaSur");
            }
        }



    }
}
