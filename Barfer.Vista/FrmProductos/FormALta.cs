using Barfer.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Barfer.Entidades.Producto;

namespace Vistas
{
    public partial class FormALta : Form
    {
        private ComidaGato _nuevoProductoGato;
        private ComidaPerro _nuevoProductoPerro;

        public ComidaGato nuevoProductoGato
        {
            get { return _nuevoProductoGato; }
        }

        public ComidaPerro nuevoProductoPerro
        {
            get { return _nuevoProductoPerro; }
        }

        public FormALta()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            string item = comboBox1.Text;
        

            if (item == "perro")
            {
                
                _nuevoProductoPerro = new ComidaPerro(txtBoxNombreAlta.Text, int.Parse(txtBoxPrecioAlta.Text), numericUpDownAlta.Value, numericUpDownId.Value, (SaborAlimento)comboBox2.SelectedIndex, (CantidadKilos)comboBox3.SelectedIndex);
                GestorProductos.AltaProductoPerro(_nuevoProductoPerro);

                this.DialogResult = DialogResult.OK;
            }
            else if (item == "gato")
            {
                _nuevoProductoGato = new ComidaGato(txtBoxNombreAlta.Text, int.Parse(txtBoxPrecioAlta.Text), numericUpDownAlta.Value, numericUpDownId.Value, (SaborAlimento)comboBox2.SelectedIndex, (CantidadKilos)comboBox3.SelectedIndex);
                GestorProductos.AltaProductoGato(_nuevoProductoGato);

                this.DialogResult = DialogResult.OK;
            }



            //if (txtBoxNombreAlta.Text == "" || txtBoxPrecioAlta.Text == "")
            //{
            //    MessageBox.Show("Debe completar todos los campos");
            //    return;
            //}
            //else
            //{
            //    //_nuevoProducto = new Producto(txtBoxNombreAlta.Text, int.Parse(txtBoxPrecioAlta.Text), numericUpDownAlta.Value, numericUpDownId.Value);
            //    this.DialogResult = DialogResult.OK;
            //}


        }

        private void numericUpDownId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormALta_Load(object sender, EventArgs e)
        {

        }
    }
}
