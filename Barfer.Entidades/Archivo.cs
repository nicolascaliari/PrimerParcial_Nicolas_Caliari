﻿using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Barfer.Entidades.Alimento;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Barfer.Entidades
{
    public class Archivo
    {

        private static string path = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Usuarios.csv";
        private static string pathAlimento = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Alimento.csv";
        private static string pathVenta = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\Ventas.csv";
        public static void CrearArchivoUsuario()
        {

            if(VerificarSiArchivoEstaCreado(path) == true)
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    
                    streamWriter.WriteLine("id,nombre,apellido,contrasenia,edad,tipo de usuario");
                    streamWriter.WriteLine("1,nicolas,caliari,Agunic1004,21,Administrador");
                    streamWriter.WriteLine("2,malena,illan,Elrojo12,20,Empleado");
                }
            }
        }



        public static List<Usuario> LeerUsuariosDesdeArchivo()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string[] lineas = File.ReadAllLines(path);

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] datoUsuario = lineas[i].Split(',');


                usuarios.Add(new Usuario
                {
                    idUsuario = int.Parse(datoUsuario[0]),
                    nombreUsuario = datoUsuario[1],
                    apellidoUsuario = datoUsuario[2],
                    contraseñaUsuario = datoUsuario[3],
                    edadUsuario = Decimal.Parse(datoUsuario[4]),
                    tipoUsuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), datoUsuario[5]),
                });
            }

            return usuarios;
        }


        public static void GuardarUsuarioEnArchivo(List<Usuario> usuarioNuevo)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("id,nombre,apellido,contrasenia,edad,tipo de usuario");

                foreach (Usuario usuario in usuarioNuevo)
                {
                    sw.WriteLine($"{usuario.idUsuario},{usuario.nombreUsuario},{usuario.apellidoUsuario},{usuario.contraseñaUsuario},{usuario.edadUsuario},{usuario.tipoUsuario}");
                }
            }
        }


        public static bool VerificarSiArchivoEstaCreado(string rutas)
        {
            bool respuesta = false;
            if (!File.Exists(rutas))
            {
                // Archivo.CrearArchivoUsuario();
                respuesta = true;
            }

            return respuesta;
        }




        //=======================================================================================//
        //=======================================================================================//
        //=======================================================================================//
        //=======================================================================================//
        //=======================================================================================//
        //=======================================================================================//
        //=======================================================================================//
        //=======================================================================================//







        public static void CrearArchivoAlimentos()
        {

            if (VerificarSiArchivoAlimentoEstaCreadoAlimento(pathAlimento) == true)
            {
                using (StreamWriter streamWriter = new StreamWriter(pathAlimento))
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
        }


        public static bool VerificarSiArchivoAlimentoEstaCreadoAlimento(string rutas)
        {
            bool respuesta = false;
            if (!File.Exists(rutas))
            {
                respuesta = true;
            }

            return respuesta;
        }




        public static List<Alimento> LeerDesdeArchivoAlimento()
        {
            List<Alimento> alimentos = new List<Alimento>();

            string[] lineas = File.ReadAllLines(pathAlimento);

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] datoUsuario = lineas[i].Split(',');


                alimentos.Add(new Alimento
                {
                    id = int.Parse(datoUsuario[0]),
                    nombre = datoUsuario[1],
                    precio = Decimal.Parse((datoUsuario[2])),
                    cantidad = Decimal.Parse(((datoUsuario[3]))),
                    sabor = (SaborAlimento)Enum.Parse(typeof(SaborAlimento) , datoUsuario[4]),
                    cantidadKilos = (CantidadKilos)Enum.Parse(typeof(CantidadKilos), datoUsuario[5]),
                    tipoAlimento = (TipoAlimento)Enum.Parse(typeof(TipoAlimento), datoUsuario[6]),
                });
            }

            return alimentos;
        }


        public static void GuardarEnArchivoAlimento(List<Alimento> alimentoNuevo)
        {
            using (StreamWriter sw = new StreamWriter(pathAlimento))
            {
                sw.WriteLine("id,nombre producto,precio,cantidad,sabor,kilos,tipo");

                foreach (Alimento alimento in alimentoNuevo)
                {
                    sw.WriteLine($"{alimento.id},{alimento.nombre},{alimento.precio},{alimento.cantidad},{alimento.sabor},{alimento.cantidadKilos},{alimento.tipoAlimento}");
                }
            }
        }






    }
}
