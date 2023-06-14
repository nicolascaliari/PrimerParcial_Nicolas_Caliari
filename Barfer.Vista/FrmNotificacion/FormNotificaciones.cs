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
using Barfer.Entidades;

namespace Barfer.Vista.FrmNotificacion
{
    public partial class FormNotificaciones : Form
    {
        public FormNotificaciones()
        {
            InitializeComponent();
            Venta.pasarDatoEvento += NotificarCamionEnCamino;
        }

        private void FormNotificaciones_Load(object sender, EventArgs e)
        {

        }

        public void NotificarCamionEnCamino(string venta)
        {
            lbNotificaciones.Items.Add(venta);
        }

        private void FormNotificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
