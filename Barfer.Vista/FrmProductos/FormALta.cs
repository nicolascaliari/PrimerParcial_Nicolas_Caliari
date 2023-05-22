using Barfer.Entidades;
using Barfer.Entidades.Validaciones;
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

            string nombre = txtBoxNombreAlta.Text;
            decimal precio = numericPrecioAlta.Value;
            decimal cantidad = numericUpDownCantidad.Value;



            try
            {
                Validador.ValidarNombreProducto(nombre);
                Validador.ValidarPrecioProducto(precio); ;
                Validador.ValidarCantidadProducto(cantidad);
                Validador.ValidarEnumsAlimento(cboSabores.SelectedIndex, cboCantidades.SelectedIndex, cboTipos.SelectedIndex);
                SaborAlimento sabor = (SaborAlimento)Enum.Parse(typeof(SaborAlimento), cboSabores.SelectedItem.ToString());
                CantidadKilos cantidadKilos = (CantidadKilos)Enum.Parse(typeof(CantidadKilos), cboCantidades.SelectedItem.ToString());
                TipoAlimento tipoAlimento = (TipoAlimento)Enum.Parse(typeof(TipoAlimento), cboTipos.SelectedItem.ToString());



                _nuevoAlimento = new Alimento(nombre, precio, cantidad, sabor, cantidadKilos, tipoAlimento);
                _nuevoAlimento.id = _nuevoAlimento.ObtenerUltimoIdAlimentos(GestorProductos.alimento) + 1;
                this.DialogResult = DialogResult.OK;
            }
            catch (AltaFallidoException ex)
            {
                lblError.Visible = true;
                lblError.Text = $"{ex.Message}";
            }
        }



        private void FormALta_Load(object sender, EventArgs e)
        {

            lblError.Visible = false;
            cboTipos.Items.Clear();
            cboSabores.Items.Clear();
            cboCantidades.Items.Clear();

            foreach (TipoAlimento item in Enum.GetValues(typeof(TipoAlimento)))
            {
                cboTipos.Items.Add(item);
            }

            foreach (SaborAlimento item in Enum.GetValues(typeof(SaborAlimento)))
            {
                cboSabores.Items.Add(item);
            }

            foreach (CantidadKilos item in Enum.GetValues(typeof(CantidadKilos)))
            {
                cboCantidades.Items.Add(item);
            }

        }






        private void cboTipos_Validating(object sender, CancelEventArgs e)
        {
            if (cboTipos.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cboTipos, "Debe seleccionar un elemento.");
            }
            else
            {
                errorProvider1.SetError(cboTipos, "");
            }
        }

        private void cboSabores_Validating(object sender, CancelEventArgs e)
        {
            if (cboSabores.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cboSabores, "Debe seleccionar un elemento.");
            }
            else
            {
                errorProvider1.SetError(cboSabores, "");
            }
        }

        private void cboCantidades_Validating(object sender, CancelEventArgs e)
        {
            if (cboCantidades.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cboCantidades, "Debe seleccionar un elemento.");
            }
            else
            {
                errorProvider1.SetError(cboCantidades, "");
            }
        }





        private void numericUpDownId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
