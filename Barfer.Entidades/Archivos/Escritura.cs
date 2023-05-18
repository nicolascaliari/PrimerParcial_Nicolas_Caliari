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
        public static void EscribirUsuariosEnArchivo(string path)
        {
            StringBuilder usuario = new StringBuilder();

            usuario.AppendLine("id,nombre,apellido,contrasenia,edad,tipo de usuario");
            usuario.AppendLine("1,nicolas,caliari,Agunic1004,21,Administrador");
            usuario.Append("2,malena,illan,Elrojo12,20,Empleado");

            File.WriteAllText(path, usuario.ToString());
        }




        public static void EscribirAlimentoEnArchivo(string path)
        {


            StringBuilder alimento = new StringBuilder();

            //alimento.AppendLine("id,nombre producto,precio,cantidad,sabor,kilos,tipo");
            //alimento.AppendLine("1,perro pollo,2000,20,pollo,cincoKilos,perro");
            //alimento.Append("2,gato vaca,2000,20,pollo,diezKilos,gato");

            //File.WriteAllText(path, alimento.ToString());


            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("id,nombre producto,precio,cantidad,sabor,kilos,tipo");
                streamWriter.WriteLine("1,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("2,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("3,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("4,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("5,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("6,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("7,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("8,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("9,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("10,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("11,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("12,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("13,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("14,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("15,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("16,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("17,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("18,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("19,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("20,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("21,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("22,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("23,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("24,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("25,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("26,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("27,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("28,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("29,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("30,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("31,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("32,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("33,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("34,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("35,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("36,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("37,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("38,perro pollo,2000,5,pollo,cincoKilos,perro");
                streamWriter.WriteLine("39,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("40,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("41,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("42,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("43,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("44,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("45,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("46,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("47,gato vaca,2000,5,vaca,diezKilos,gato");
                streamWriter.WriteLine("48,gato vaca,2000,5,vaca,diezKilos,gato");
            }
        }


        public static void EscribirClienteEnArchivo(string path)
        {
            StringBuilder usuario = new StringBuilder();

            usuario.AppendLine("id,nombre,apellido,contrasenia,edad,tipo de usuario");
            usuario.AppendLine("1,nicolas,caliari,Agunic1004,21,Administrador");
            usuario.Append("2,malena,illan,Elrojo12,20,Empleado");

            File.WriteAllText(path, usuario.ToString());
        }



    }
}
