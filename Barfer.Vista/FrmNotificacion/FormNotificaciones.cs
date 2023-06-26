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

        /// <summary>
        /// Metodo que agrega las notificaciones a listBox
        /// </summary>
        /// <param name="venta"></param>
        public void NotificarCamionEnCamino(string venta)
        {
            lbNotificaciones.Items.Add(venta);
        }

        /// <summary>
        /// Evento que se ejecuta cuando el formulario está en proceso de cerrarse.
        /// Cancela el cierre del formulario y lo oculta en lugar de cerrarlo.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento de cierre del formulario.</param>
        private void FormNotificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
