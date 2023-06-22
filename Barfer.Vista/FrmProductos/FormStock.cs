using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barfer.Entidades;
using Barfer.Entidades.Logs;
using Barfer.Entidades.SQL;
using Barfer.Entidades.Usuarios;
using Barfer.Vista.FrmProductos;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.Win32;
using Vistas.FrmUsuarios;

namespace Vistas
{
    public partial class FormStock : Form
    {
        private int _tipo;


        public FormStock(int tipo)
        {
            InitializeComponent();
            _tipo = tipo;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            ActualizarStock(dataGrid);
            lblTotalStock.Text = GestorProductos.TotalStock();
            RegistroActividad registro = new RegistroActividad(Usuario.name, " el usuario ingreso al gestor de stock", DateTime.Now);
            RegistroActividad.OnMovimientoRealizado(registro);
        }



        /// <summary>
        /// Metodo que actualiza el stock pasandole al DataGrid la lista de alimento
        /// </summary>
        /// <param name="dtg"></param>
        private static void ActualizarStock(DataGridView dtg)
        {
            if (GestorProductos.alimento.Count > 0)
            {
                AlimentoDB alimento = new AlimentoDB();
                dtg.DataSource = null;
                dtg.DataSource = GestorProductos.alimento;
                dtg.Visible = true;
            }
            else
            {
                dtg.Visible = false;
            }
        }


        /// <summary>
        /// Este evento permite agregar un producto a la lista y se ve reflejado en el dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaProducto_Click(object sender, EventArgs e)
        {

            if (_tipo == 0)
            {
                var altaProducto = new FormALta();
                if (altaProducto.ShowDialog() == DialogResult.OK)
                {
                    GestorProductos.AltaAlimento(altaProducto.nuevoAlimento);
                    ActualizarStock(dataGrid);
                    lblTotalStock.Text = GestorProductos.TotalStock();

                }
            }
            else
            {
                MessageBox.Show("Debes ser administrador para manipular este boton");
            }
        }



        /// <summary>
        ///  Este evento permite al usuario eliminar un producto seleccionado en el DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBajaProducto_Click(object sender, EventArgs e)
        {
            if (_tipo == 0)
            {
                if (GestorProductos.alimento.Count >= 2)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (respuesta == DialogResult.Yes)
                    {
                        Alimento alimento = (Alimento)dataGrid.CurrentRow.DataBoundItem;

                        int idProducto = alimento.id;
                        GestorProductos.BajaProducto(alimento);
                        AlimentoDB alimentoDB = new AlimentoDB();
                        alimentoDB.EliminarAsync(idProducto);

                        lblTotalStock.Text = GestorProductos.TotalStock();
                        ActualizarStock(dataGrid);
                        string mostrar = Alimento.MostrarProductoEliminado((Alimento)dataGrid.CurrentRow.DataBoundItem);
                        MessageBox.Show(mostrar);
                    }
                }
                else
                {
                    MessageBox.Show("Debes tener mas de un producto para poder eliminar");
                }
            }
            else
            {
                MessageBox.Show("Debes ser administrador");
            }
        }



        /// <summary>
        ///  Este evento permite al usuario editar un producto seleccionado en el DataGridView y enviandolo a otro Form donde estaran sus datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (this.dataGrid.RowCount == 0)
            {
                MessageBox.Show("No hay usuarios para modificar");
            }
            else
            {
                var formModificacion = new FormEditarAlimento((Alimento)dataGrid.CurrentRow.DataBoundItem);
                if (formModificacion.ShowDialog() == DialogResult.OK)
                {
                    ActualizarStock(dataGrid);
                }
            }
        }

        /// <summary>
        /// Evento para volver a la ventana anterior y cierra la actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        /// <summary>
        /// Maneja el evento de cambio de texto en el TextBox de busqueda y me muestra el data grid dependiendo lo que le pase al TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBoxBuscar.Text))
            {
                List<Alimento> filtrado = new List<Alimento>();
                FiltrarDatosDeAlimento(filtrado);
                this.dataGrid.DataSource = filtrado;
            }
            else
            {
                if (GestorProductos.alimento.Count > 0)
                {
                    dataGrid.DataSource = GestorProductos.alimento;
                }
            }
        }


        /// <summary>
        /// Este metodo filtra los datos de alimento segun el texto ingresado en el TextBox
        /// </summary>
        /// <param name="filtrado"></param>
        private void FiltrarDatosDeAlimento(List<Alimento> filtrado)
        {
            foreach (Alimento item in GestorProductos.alimento)
            {
                if (item.sabor.ToString().ToUpper().StartsWith(this.txtBoxBuscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.tipoAlimento.ToString().ToUpper().StartsWith(this.txtBoxBuscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.id.ToString().ToUpper().StartsWith(this.txtBoxBuscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
