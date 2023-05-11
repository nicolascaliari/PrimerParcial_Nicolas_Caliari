using Barfer.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barfer.Vista.FormVentas
{
    public partial class FormPreparacion : Form
    {
        public FormPreparacion()
        {
            InitializeComponent();
        }

        private void FormPreparacion_Load(object sender, EventArgs e)
        {
            dtpFechaEntrega.Visible = false;
            if (Venta.ventasPreparacion.Count == 0)
            {
                dtgPreparacion.Visible = false;
                lblNoHayPreparaciones.Text = "No hay preparaciones pendientes";
            }
            else
            {
                lblNoHayPreparaciones.Visible = false;
                foreach (var row in Venta.ventasPreparacion)
                {
                    dtgPreparacion.Rows.Add(row.Cliente, row.Alimento, row.Cantidad, row.PrecioTotal, row.Fecha, row.Estado);
                }
            }
        }

        private void btnFinalizarPreparacion_Click(object sender, EventArgs e)
        {
            if(Venta.ventasPreparacion.Count > 0)
            {
                FormEnvio frmEnvio = new FormEnvio();
                frmEnvio.Show();
            }
            else
            {
                MessageBox.Show("No hay pedidos cargados");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            dtpFechaEntrega.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime fechaEntrega = dtpFechaEntrega.Value;

            Venta.entregasProgramadas.Add(fechaEntrega);
            MessageBox.Show("La fecha se programo correctamente");
        }
    }
}
