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

namespace Vistas
{
    public partial class FormStock : Form
    {

        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            ActualizarStock(dataGrid);
        }


        private static void ActualizarStock(DataGridView dtg)
        {
            if (GestorProductos.producto.Count > 0)
            {
                dtg.DataSource = null;
                dtg.DataSource = GestorProductos.producto;
                dtg.Visible = true;
            }
            else
            {
                dtg.Visible = false;
            }
        }

        private void btnAltaStock_Click(object sender, EventArgs e)
        {
            var altaProducto = new FormALta();
            if (altaProducto.ShowDialog() == DialogResult.OK)
            {
               // GestorProductos.AltaProducto(altaProducto.nuevoProductoGato);
                ActualizarStock(dataGrid);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                GestorProductos.BajaProducto((Producto)dataGrid.CurrentRow.DataBoundItem);
                ActualizarStock(dataGrid);
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
