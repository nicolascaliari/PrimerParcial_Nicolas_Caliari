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
using DocumentFormat.OpenXml.Office2010.Excel;

namespace Vistas
{
    public partial class FormStock : Form
    {
        private int _id;


        public FormStock(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {

            dataGrid.DataSource = GestorProductos.CargarAlimentoDesdeArchivo();

          //  ActualizarStock(dataGrid);
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

            if (_id == 1)
            {
                var altaProducto = new FormALta();
                if (altaProducto.ShowDialog() == DialogResult.OK)
                {
                    GestorProductos.AltaAlimento(altaProducto.nuevoAlimento);
                    Archivo.GuardarEnArchivoAlimento(GestorProductos.alimento);
                    ActualizarStock(dataGrid);
                }
            }
            else
            {
                MessageBox.Show("Debes ser administrador para manipular este boton");
            }
        }




        private void btnBajaProducto_Click(object sender, EventArgs e)
        {
            if (_id == 1)
            {
                if(GestorProductos.alimento.Count >= 2)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        GestorProductos.BajaProducto((Alimento)dataGrid.CurrentRow.DataBoundItem);
                        ActualizarStock(dataGrid);
                        Archivo.GuardarEnArchivoAlimento(GestorProductos.alimento);
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

        }






        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
