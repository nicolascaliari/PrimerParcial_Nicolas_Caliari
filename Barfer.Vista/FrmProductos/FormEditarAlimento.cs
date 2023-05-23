using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
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

namespace Barfer.Vista.FrmProductos
{
    public partial class FormEditarAlimento : Form
    {
        private Alimento _editarAlimento;
        public FormEditarAlimento(Alimento alimento)
        {
            InitializeComponent();
            this._editarAlimento = alimento;
        }

        /// <summary>
        /// Se cargan todos los comboBox con los tipos de alimento, sabor, cantidad y muestra los datos del alimento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditarAlimento_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;

            foreach (TipoAlimento item in Enum.GetValues(typeof(TipoAlimento)))
            {
                cboTipo.Items.Add(item);
            }

            foreach (SaborAlimento item in Enum.GetValues(typeof(SaborAlimento)))
            {
                cboSabor.Items.Add(item);
            }

            foreach (CantidadKilos item in Enum.GetValues(typeof(CantidadKilos)))
            {
                cboCantidad.Items.Add(item);
            }

            MostrarDatos();

        }



        /// <summary>
        /// Metodo que muestra los datos del alimento
        /// </summary>
        private void MostrarDatos()
        {
            txtBoxNombre.Text = _editarAlimento.nombre;
            txtBoxPrecio.Text = _editarAlimento.precio.ToString();
            txtBoxCantidad.Text = _editarAlimento.cantidad.ToString();
            cboSabor.Text = _editarAlimento.sabor.ToString();
            cboCantidad.Text = _editarAlimento.cantidadKilos.ToString();
            cboTipo.Text = _editarAlimento.tipoAlimento.ToString();


            cboTipo.SelectedItem = _editarAlimento.tipoAlimento;
            cboSabor.SelectedItem = _editarAlimento.sabor;
            cboCantidad.SelectedItem = _editarAlimento.cantidadKilos;

        }


        /// <summary>
        /// Evento en donde si no se arroja una excepcion se edita el alimento correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre = _editarAlimento.nombre = txtBoxNombre.Text;
            decimal precio = _editarAlimento.precio = decimal.Parse(txtBoxPrecio.Text);
            decimal cantidad = _editarAlimento.cantidad = decimal.Parse(txtBoxCantidad.Text);
            SaborAlimento sabor = _editarAlimento.sabor = (SaborAlimento)cboSabor.SelectedIndex;
            CantidadKilos cantidadKilos = _editarAlimento.cantidadKilos = (CantidadKilos)cboCantidad.SelectedIndex;
            TipoAlimento tipoAlimento = _editarAlimento.tipoAlimento = (TipoAlimento)cboTipo.SelectedIndex;


            try
            {
                Validador.ValidarNombre(nombre);
                Validador.ValidarPrecioProducto(precio);
                Validador.ValidarCantidadProducto(cantidad);
                Validador.ValidarEnumsAlimento(cboSabor.SelectedIndex, cboCantidad.SelectedIndex, cboTipo.SelectedIndex);
                this.DialogResult = DialogResult.OK;
            }
            catch (ExceptionCampos ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }
    }
}
