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
using Barfer.Entidades.Archivos;
using Barfer.Entidades.Usuarios;
using Barfer.Vista.FrmProductos;
using DocumentFormat.OpenXml.Office2010.Excel;
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
            dataGrid.DataSource = GestorProductos.CargarAlimentoDesdeArchivo();
            lblTotalStock.Text = GestorProductos.TotalStock();

        }


        private static void ActualizarStock(DataGridView dtg)
        {
            if (GestorProductos.alimento.Count > 0)
            {
                dtg.DataSource = null;
                dtg.DataSource = GestorProductos.alimento;
                dtg.Visible = true;
            }
            else
            {
                dtg.Visible = false;
            }
        }



        private void btnAltaProducto_Click(object sender, EventArgs e)
        {

            if (_tipo == 0)
            {
                var altaProducto = new FormALta();
                if (altaProducto.ShowDialog() == DialogResult.OK)
                {
                    GestorProductos.AltaAlimento(altaProducto.nuevoAlimento);
                    GuardarArchivo.GuardarAlimentoEnArchivo(GestorProductos.alimento);
                    // Archivo.GuardarEnArchivoAlimento(GestorProductos.alimento);
                    ActualizarStock(dataGrid);
                    lblTotalStock.Text = GestorProductos.TotalStock();
                   
                }
            }
            else
            {
                MessageBox.Show("Debes ser administrador para manipular este boton");
            }
        }




        private void btnBajaProducto_Click(object sender, EventArgs e)
        {
            if (_tipo == 0)
            {
                if (GestorProductos.alimento.Count >= 2)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        GestorProductos.BajaProducto((Alimento)dataGrid.CurrentRow.DataBoundItem);
                        ActualizarStock(dataGrid);
                        GuardarArchivo.GuardarAlimentoEnArchivo(GestorProductos.alimento);
                        lblTotalStock.Text = GestorProductos.TotalStock();
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
                    GuardarArchivo.GuardarAlimentoEnArchivo(GestorProductos.alimento);
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

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



    }
}
