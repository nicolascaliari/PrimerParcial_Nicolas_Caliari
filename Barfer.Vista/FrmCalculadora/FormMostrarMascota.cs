using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas;

namespace Barfer.Vista.FrmCalculadora
{
    public partial class FormMostrarMascota : Form
    {
        private string _nombre;
        private int _edad;
        private double _peso;
        private double _cantidadKilos;
        private string _tipo;
        public FormMostrarMascota(string nombre, int edad, double peso, double cantidadKilos, string tipo)
        {
            InitializeComponent();
            _nombre = nombre;
            _edad = edad;
            _peso = peso;
            _cantidadKilos = cantidadKilos;
            _tipo = tipo;
        }


        /// <summary>
        /// En este evento se cargan en el txt los datos de la mascota.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMostrarMascota_Load(object sender, EventArgs e)
        {
            txtNombre.Text = MostrarMascota();
        }


        /// <summary>
        /// Metodo para mostrar los datos de la mascota que vienen por parametro
        /// </summary>
        /// <returns>Retorna string</returns>
        private string MostrarMascota()
        {
            StringBuilder sb = new StringBuilder();

            double _cantidadKilosRedondeado = Math.Round(_cantidadKilos, 2);

            sb.AppendLine($"mi nombre es {_nombre} tengo {_edad} años");
            sb.AppendLine($"mi peso es {_peso} y soy un {_tipo}");
            sb.AppendLine($"mi cantidad de comida diaria es {_cantidadKilosRedondeado}");
            return sb.ToString();
        }


        /// <summary>
        /// Metodo en donde se cierra esta ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
