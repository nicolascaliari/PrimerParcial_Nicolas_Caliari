using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
using Barfer.Vista.FormVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Timer = System.Threading.Timer;


namespace Barfer.Vista.Ventas
{
    public partial class FormGestorVentas : Form
    {

        public FormGestorVentas()
        {
            InitializeComponent();
        }

        private void FormGestorVentas_Load(object sender, EventArgs e)
        {
            // Generar 10 ventas aleatorias
            Venta.GenerarVentasAleatorias(10, GestorDeUsuarios.clientes, GestorProductos.alimento);

            // Llenar el ListBox con las ventas generadas
            foreach (Venta venta in Venta.ventas)
            {
                dataGridView1.DataSource = Venta.ventas;
            }
        }


        private void btnPreparacion_Click(object sender, EventArgs e)
        {
            FormPreparacion frmPreparacion = new FormPreparacion();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[8] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && (bool)checkBoxCell.Value == true)
                {
                    Venta venta = new Venta();
                    // Obtener la fila correspondiente al checkbox
                    DataGridViewRow selectedRow = checkBoxCell.OwningRow;
                    // Seleccionar la fila
                    selectedRow.Selected = true;

                    venta._idVenta = Convert.ToInt32(row.Cells[0].Value);
                    venta.Cliente = (Cliente)row.Cells[1].Value;
                    venta.Localidades = (Cliente.Localidades)row.Cells[2].Value;
                    venta.Alimento = (Alimento.TipoAlimento)row.Cells[3].Value;
                    venta.Cantidad = Convert.ToInt32(row.Cells[4].Value);
                    venta.PrecioTotal = Convert.ToDecimal(row.Cells[5].Value);
                    venta.Fecha = Convert.ToDateTime(row.Cells[6].Value);
                    row.Cells[7].Value = "en preparacion";
                    venta.Estado = "en preparacion";
                    venta.Enviar = (bool)row.Cells[8].Value;

                    Venta.ventasPreparacion.Add(venta);
                    Venta.ventas.Remove((Venta)row.DataBoundItem);
                    ActualizarDataGrid(dataGridView1);

                }
            }
            frmPreparacion.ShowDialog();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void FormGestorVentas_Paint(object sender, PaintEventArgs e)
        {

        }


        private static void ActualizarDataGrid(DataGridView dtg)
        {

            dtg.DataSource = null;
            dtg.DataSource = Venta.ventas;
            dtg.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}