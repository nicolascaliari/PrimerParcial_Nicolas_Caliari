using Barfer.Entidades;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Barfer.Vista.FormVentas
{
    public partial class FormEnvio : Form
    {
        private DateTime fechaEntrega;
        private string fecha;
        private Timer timer;
        public FormEnvio()
        {
            InitializeComponent();
        }


        private async void FormEnvio_Load(object sender, EventArgs e)
        {
            MostrarFechaDeEntrega();
            CargarDatosDeEnvios();
            if (Venta.ventasPreparacion.Count > 0)
            {
                Venta.NotificarVenta("Ya se llamo al camion para entregar los productos");
                Venta.NotificarCamion(fecha);
                await EsperarHastaFechaEntrega();
            }

        }




        /// <summary>
        /// Este metodo se encarga de mostrar la fecha de entrega de los pedidos.
        /// </summary>
        private void MostrarFechaDeEntrega()
        {
            if (Venta.ventasPreparacion.Count > 0)
            {
                fechaEntrega = Venta.entregasProgramadas[0];
                //fechaEntrega = new DateTime(2023, 6, 27, 19, 30, 0);
                fecha = fechaEntrega.ToString("dd/MM/yyyy hh:mm:ss tt");
                lblTimer.Text = $"El camion vendra a buscar la entrega el dia: {fecha}";
            }
            else
            {
                lblTimer.Text = "No hay envios programados";
            }
        }




        /// <summary>
        /// Este metodo se encarga de cargar los datos de los clientes que compraron en el ListBox
        /// </summary>
        private void CargarDatosDeEnvios()
        {

            foreach (Venta cliente in Venta.ventasPreparacion)
            {
                string nombreCompleto = cliente.cliente + " " + cliente.alimento + " - " + cliente.localidades + " - " + cliente.precioTotal;

                LbVentas.Items.Add(nombreCompleto);

            }
        }


        /// <summary>
        /// Evento para cerrar la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private async Task EsperarHastaFechaEntrega()
        {
            DateTime now = DateTime.Now;
            DateTime fechaEntregaSinSegundos = fechaEntrega.Date.AddHours(fechaEntrega.Hour).AddMinutes(fechaEntrega.Minute);
            DateTime nowSinSegundos = now.Date.AddHours(now.Hour).AddMinutes(now.Minute);

            if (fechaEntregaSinSegundos == nowSinSegundos)
            {
                await Task.Delay(0);
            }
            else if (fechaEntregaSinSegundos > nowSinSegundos)
            {
                TimeSpan tiempoEspera = fechaEntregaSinSegundos - nowSinSegundos;
                await Task.Delay(tiempoEspera);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
