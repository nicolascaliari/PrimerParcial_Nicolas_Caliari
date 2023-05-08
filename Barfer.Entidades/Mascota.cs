﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barfer.Entidades
{
    public  class Mascota
    {
        private string _nombre;
        private int _edad;
        private double _peso;
        private TipoMascota _tipo;

        public enum TipoMascota
        {
            Perro,
            Gato
        }

    public TipoMascota Tipo { get => _tipo; set => _tipo = value; }

    public string Nombre { get => _nombre; set => _nombre = value; }
    public double Peso { get => _peso; set => _peso = value; }

    public int Edad { get => _edad; set => _edad = value; }

        public Mascota(string nombre, int edad ,double peso, TipoMascota tipo)
        {
            _nombre = nombre;
            _edad = edad;
            _peso = peso;
            _tipo = tipo;
        }

        public  virtual double CalcularAlimento(string tipoAnimal)
        {
            return 0;
        }


        public virtual string MostrarMascota()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"peso: {_peso}");
            sb.AppendLine($"edad: {_edad}");
            sb.AppendLine($"Tipo {_tipo}");

            return sb.ToString();
        }
    }
}
