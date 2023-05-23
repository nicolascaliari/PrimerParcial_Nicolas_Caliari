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
            Venta.GenerarVentasAleatorias(4, GestorDeUsuarios.clientes, GestorProductos.alimento);

            CargarVentas();
        }


        /// <summary>
        /// Metodo encargado de cargar ventas al dataGrid
        /// </summary>
        private void CargarVentas()
        {
            foreach (Venta venta in Venta.ventas)
            {
                dataGridView1.DataSource = Venta.ventas;
            }
        }



        /// <summary>
        /// Prepara las ventas seleccionadas para su procesamiento y muestra el formulario de preparación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreparacion_Click(object sender, EventArgs e)
        {
            FormPreparacion frmPreparacion = new FormPreparacion();
            var ventasEliminar = new List<Venta>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[8] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && (bool)checkBoxCell.Value == true)
                {
                    Venta venta = new Venta();
                    DataGridViewRow selectedRow = checkBoxCell.OwningRow;

                    selectedRow.Selected = true;
                    venta.idVenta = Convert.ToInt32(row.Cells[0].Value);
                    venta.cliente = (Cliente)row.Cells[1].Value;
                    venta.localidades = (Cliente.Localidades)row.Cells[2].Value;
                    venta.alimento = (Alimento)row.Cells[3].Value;    
                    venta.cantidad = Convert.ToInt32(row.Cells[4].Value);
                    venta.precioTotal = Convert.ToDecimal(row.Cells[5].Value);
                    venta.fecha = Convert.ToDateTime(row.Cells[6].Value);
                    row.Cells[7].Value = "en preparacion";
                    venta.estado = "en preparacion";
                    venta.enviar = (bool)row.Cells[8].Value;

                    Venta.ventasPreparacion.Add(venta);
                    ventasEliminar.Add((Venta)row.DataBoundItem);
                   
                }
            }
            foreach (Venta venta in ventasEliminar)
            {
                Venta.ventas.Remove(venta);
            }
            ActualizarDataGrid(dataGridView1);
            frmPreparacion.ShowDialog();
        }


        /// <summary>
        /// Metodo que se encarga de actualizar el dataGrid
        /// </summary>
        /// <param name="dtg"></param>
        private static void ActualizarDataGrid(DataGridView dtg)
        {

            dtg.DataSource = null;
            dtg.DataSource = Venta.ventas;
            dtg.Refresh();
        }


        /// <summary>
        /// Evento que se encarga de cerrar la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }





        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void FormGestorVentas_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}