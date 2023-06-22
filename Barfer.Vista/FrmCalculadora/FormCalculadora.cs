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
using Barfer.Entidades.Logs;
using Barfer.Entidades.Usuarios;

namespace Vistas
{
    public partial class FormCalculadora : Form
    {
        private Mascota mascota;
        public FormCalculadora()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Carga en el comboBox los tipos de mascota que tengo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            foreach (TipoMascota item in Enum.GetValues(typeof(TipoMascota)))
            {
                cmbMascota.Items.Add(item);
            }

            RegistroActividad registro = new RegistroActividad(Usuario.name, " el usuario ingreso a la calculadora", DateTime.Now);
            RegistroActividad.OnMovimientoRealizado(registro);
        }



        /// <summary>
        /// Metodo que crea una mascota, le calcula la cantidad de alimento y envia esa informacion a otro Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            int edad = (int)numericUpDownEdad.Value;
            double peso = (double)numericUpDownPeso.Value;


            try
            {
                Validador.ValidarNombre(nombre);
                Validador.ValidarEdad(edad);
                Validador.ValidarPesoMascota(peso);


                string tipoAnimal = cmbMascota.SelectedItem.ToString();
                mascota = FactoryMethod.CrearMascota(tipoAnimal);
                mascota.Nombre = nombre;
                mascota.Edad = edad;
                mascota.Peso = peso;

                double cantidadAlimento = mascota.CalcularAlimento(tipoAnimal);
                FormMostrarMascota mostrarComida = new FormMostrarMascota(nombre, edad, peso, cantidadAlimento, tipoAnimal);
                mostrarComida.ShowDialog();


            }
            catch (ExceptionCampos ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }


        /// <summary>
        /// evento que cierra la ventana actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

    }
}
