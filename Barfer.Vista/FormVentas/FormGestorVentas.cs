using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
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
        private List<Usuario> clientes;
        private List<Alimento> alimentos;
        private Random random;


        public FormGestorVentas()
        {
            InitializeComponent();
        }

        private void FormGestorVentas_Load(object sender, EventArgs e)
        {
            //checkedListBox1.ForeColor = Color.Black;
            //checkedListBox1.Font = new Font("Arial", 10);
            //checkedListBox1.Padding = new Padding(10);
            //listBox1.ItemHeight = 50;

            // Generar 10 ventas aleatorias
            Venta.GenerarVentasAleatorias(10, GestorDeUsuarios.usuarios, GestorProductos.alimento);

            // Llenar el ListBox con las ventas generadas
            foreach (Venta venta in Venta.ventas)
            {
                dataGridView1.DataSource = Venta.ventas;
                // MessageBox.Show(venta.ToString());
            }
        }


        private List<DataGridViewRow> GetSelectedRows()
        {
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[5] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && (bool)checkBoxCell.Value)
                {
                    selectedRows.Add(row);
                }
            }
            return selectedRows;
        }


        private void FormGestorVentas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPreparacion_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Venta venta = new Venta();
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[5] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && (bool)checkBoxCell.Value)
                { 
                    venta.Cliente = (Usuario)row.Cells[0].Value;
                    venta.Alimento = (Alimento.TipoAlimento)row.Cells[1].Value;
                    venta.Cantidad = Convert.ToInt32(row.Cells[2].Value);
                    venta.PrecioTotal = Convert.ToDecimal(row.Cells[3].Value);
                    venta.Fecha = Convert.ToDateTime(row.Cells[4].Value);
                    venta.Estado = (bool)row.Cells[5].Value;
                    reporte.venta.Add(venta);
                }
            }
            reporte.ShowDialog();
        }
    }

}