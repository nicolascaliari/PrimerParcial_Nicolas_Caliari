using Barfer.Entidades.Validaciones;
using Barfer.Vista.FrmCalculadora;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Barfer.Entidades.Alimento;
using static Barfer.Entidades.Gato;
using static Barfer.Entidades.Mascota;
using static Barfer.Entidades.Perro;
using Barfer.Entidades;

namespace Vistas
{
    public partial class FormCalculadora : Form
    {
        private Mascota mascota;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            foreach (TipoMascota item in Enum.GetValues(typeof(TipoMascota)))
            {
                cmbMascota.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            int edad = (int)numericUpDownEdad.Value;
            double peso = (double)numericUpDownPeso.Value;

            if(Validador.ValidarCalculadora(nombre, edad , peso , cmbMascota.SelectedIndex))
            {
                string tipoAnimal = cmbMascota.SelectedItem.ToString();
                mascota = FactoryMethod.CrearMascota(tipoAnimal);
                mascota.Nombre = nombre;
                mascota.Edad = edad;
                mascota.Peso = peso;

                double cantidadAlimento = mascota.CalcularAlimento(tipoAnimal);
                FormMostrarMascota mostrarComida = new FormMostrarMascota(nombre, edad, peso, cantidadAlimento, tipoAnimal);
                mostrarComida.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faltan datos o ingreso algo por error");
            }

        }


        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Elige foto de tu peludo";
            openFileDialog1.ShowDialog();

            if (File.Exists(openFileDialog1.FileName))
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }


        private void cmbEdad_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
