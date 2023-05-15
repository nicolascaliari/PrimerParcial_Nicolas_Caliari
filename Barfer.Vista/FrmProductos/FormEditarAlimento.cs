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

        private void FormEditarAlimento_Load(object sender, EventArgs e)
        {
            MostrarDatos();
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
        }


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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            _editarAlimento.nombre = txtBoxNombre.Text;
            _editarAlimento.precio = decimal.Parse(txtBoxPrecio.Text);
            _editarAlimento.cantidad = decimal.Parse(txtBoxCantidad.Text);
            _editarAlimento.sabor = (SaborAlimento)cboSabor.SelectedIndex;
            _editarAlimento.cantidadKilos = (CantidadKilos)cboCantidad.SelectedIndex;
            _editarAlimento.tipoAlimento = (TipoAlimento)cboTipo.SelectedIndex;




            // if (Validar.ValidarEdicionUsuario(nombre, apellido, password, edad))
            // {
            this.DialogResult = DialogResult.OK;
        
 
        }
    }
}
