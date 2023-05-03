using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barfer.Vista.FrmCalculadora
{
    public partial class FormMostrarMascota : Form
    {
        private string _nombre;
        private int _edad;
        private int _peso;
        private double _cantidadKilos;
        private string _tipo;
        public FormMostrarMascota(string nombre, int edad, int peso, double cantidadKilos, string tipo)
        {
            InitializeComponent();
            _nombre = nombre;
            _edad = edad;
            _peso = peso;
            _cantidadKilos = cantidadKilos;
            _tipo = tipo;
        }

        private void FormMostrarMascota_Load(object sender, EventArgs e)
        {
            txtNombre.Text = MostrarMascota();
        }

        private string MostrarMascota()
        {
            StringBuilder sb = new StringBuilder();

            double _cantidadKilosRedondeado = Math.Round(_cantidadKilos, 2);

            sb.AppendLine($"mi nombre es {_nombre} tengo {_edad} años");
            sb.AppendLine($"mi peso es {_peso} y soy un {_tipo}");
            sb.AppendLine($"mi cantidad de comida diaria es {_cantidadKilosRedondeado}");
            return sb.ToString();
        }
    }
}
