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
using static Barfer.Entidades.Alimento;

namespace Vistas
{
    public partial class FormALta : Form
    {
        private Alimento _nuevoAlimento;

        public Alimento nuevoAlimento
        {
            get { return _nuevoAlimento; }
            set { _nuevoAlimento = value; }
        }


        public FormALta()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            _nuevoAlimento = new Alimento(numericUpDownId.Value, txtBoxNombreAlta.Text, decimal.Parse(txtBoxPrecioAlta.Text), numericUpDownCantidad.Value, (SaborAlimento)cboCantidades.SelectedItem, (CantidadKilos)cboSabores.SelectedItem, (TipoAlimento)cboTipos.SelectedItem);
            this.DialogResult = DialogResult.OK;

            MessageBox.Show(cboCantidades.SelectedIndex.ToString());



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
