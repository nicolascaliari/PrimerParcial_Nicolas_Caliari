using Barfer.Entidades;
using Barfer.Entidades.SQL;
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
using System.Xml.Linq;
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




        /// <summary>
        /// Se cargan todos los camboBox y el label se oculta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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



        /// <summary>
        /// Evento que da de alta un alimento si es que todos los campos estan correctamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {


            AlimentoDB alimentDB = new AlimentoDB();
            try
            {
                if (_nuevoAlimento == null)
                    _nuevoAlimento = new Alimento();


                _nuevoAlimento.nombre = txtBoxNombreAlta.Text;
                _nuevoAlimento.precio = numericPrecioAlta.Value;
                _nuevoAlimento.cantidad = numericUpDownCantidad.Value;
                _nuevoAlimento.tipoAlimento = (TipoAlimento)cboTipos.SelectedItem;
                _nuevoAlimento.sabor = (SaborAlimento)cboSabores.SelectedItem;
                _nuevoAlimento.cantidadKilos = (CantidadKilos)cboCantidades.SelectedItem;


                alimentDB.Agregar(_nuevoAlimento);
                MessageBox.Show($"agregado exitosamente {_nuevoAlimento}");
                this.DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }











            //string nombre = txtBoxNombreAlta.Text;
            //decimal precio = numericPrecioAlta.Value;
            //decimal cantidad = numericUpDownCantidad.Value;



            //try
            //{
            //    AlimentoDB alimentoDB = new AlimentoDB();
            //    Validador.ValidarNombre(nombre);
            //    Validador.ValidarPrecioProducto(precio); ;
            //    Validador.ValidarCantidadProducto(cantidad);
            //    Validador.ValidarEnumsAlimento(cboSabores.SelectedIndex, cboCantidades.SelectedIndex, cboTipos.SelectedIndex);

            //    int tipo = cboTipos.SelectedIndex;
            //    int sabor = cboSabores.SelectedIndex;
            //    int kilos = cboCantidades.SelectedIndex;
            //    //SaborAlimento sabor = (SaborAlimento)Enum.Parse(typeof(SaborAlimento), cboSabores.SelectedItem.ToString());
            //    //CantidadKilos cantidadKilos = (CantidadKilos)Enum.Parse(typeof(CantidadKilos), cboCantidades.SelectedItem.ToString());
            //    //TipoAlimento tipoAlimento = (TipoAlimento)Enum.Parse(typeof(TipoAlimento), cboTipos.SelectedItem.ToString());
            //    _nuevoAlimento = new Alimento(nombre, precio, cantidad, sabor, kilos, tipo);
            //    alimentoDB.Agregar(_nuevoAlimento);



            //    //_nuevoAlimento.id = _nuevoAlimento.ObtenerUltimoIdAlimentos(GestorProductos.alimento) + 1;
            //    this.DialogResult = DialogResult.OK;
            //}
            //catch (ExceptionCampos ex)
            //{
            //    lblError.Visible = true;
            //    lblError.Text = $"{ex.Message}";
            //}
        }





        /// <summary>
        /// Evento que valida que se seleccione un elemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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



        /// <summary>
        /// Evento que valida que se seleccione un elemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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



        /// <summary>
        /// Evento que valida que se seleccione un elemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
