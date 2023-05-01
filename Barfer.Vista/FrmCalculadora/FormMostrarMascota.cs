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
            txtNombre.Text = _nombre;
            txtEdad.Text = _edad.ToString();
            txtPeso.Text = _peso.ToString();
            txtCantidadComida.Text = _cantidadKilos.ToString();
            txtTipo.Text = _tipo;
        }
    }
}
