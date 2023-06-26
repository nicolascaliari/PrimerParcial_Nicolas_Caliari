using Barfer.Entidades;
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
            CargaDataGridConVentasEnPreparacion();

        }


        /// <summary>
        /// Metodo que carga las ventas que estan en preparacion al DataGrid
        /// </summary>
        private void CargaDataGridConVentasEnPreparacion()
        {
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
                    dtgPreparacion.Rows.Add(row.cliente, row.alimento, row.cantidad, row.precioTotal, row.fecha, row.estado);
                }
            }
        }



        /// <summary>
        /// Evento que si hay ventas en preparacion te envia al form de envio, de lo contrario te da una alerta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarPreparacion_Click(object sender, EventArgs e)
        {

            try
            {
                Validador.VerificarSiSeCargoFechaYHayEntregas();
                FormEnvio frmEnvio = new FormEnvio();
                frmEnvio.Show();

            }
            catch (preparacionesCargadasException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento que cierra la ventana actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        /// <summary>
        /// evento que si se le da click muestra el dtp para elegir una fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrega_Click(object sender, EventArgs e)
        {
            dtpFechaEntrega.Visible = true;
        }


        /// <summary>
        /// Evento que setea la fecha de entrega
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime fechaEntrega = dtpFechaEntrega.Value;
            Venta.entregasProgramadas.Add(fechaEntrega);
            lblHorarioConfirmado.Text = $"Horario confirmado para {fechaEntrega.ToString()}";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
