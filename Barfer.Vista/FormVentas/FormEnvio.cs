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
        public FormEnvio()
        {
            InitializeComponent();
        }

        private void FormEnvio_Load(object sender, EventArgs e)
        {
            if (Venta.ventasPreparacion.Count > 0)
            {
                MessageBox.Show("Ya le hemos enviado un mail con la informacion de los pedidos al camion de envio.");
                DateTime fecha = Venta.entregasProgramadas[0];
                string fechaa = fecha.ToString("dd/MM/yyyy hh:mm:ss tt");
                lblTimer.Text = $"El camion vendra a buscar la entrega el dia:{fechaa}";
            }
            else
            {
                lblTimer.Text = "No hay envios programados";
            }


            foreach (Venta cliente in Venta.ventasPreparacion)
            {
                string nombreCompleto = cliente.Cliente + " " + cliente.Alimento + " - " + cliente.Localidades + " - " + cliente.PrecioTotal;

                LbVentas.Items.Add(nombreCompleto);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
