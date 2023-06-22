using Barfer.Entidades;
using Barfer.Entidades.Logs;
using Barfer.Entidades.SQL;
using Barfer.Entidades.Usuarios;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barfer.Vista.FrmLogs
{
    public partial class FormLogs : Form
    {
        public FormLogs()
        {
            InitializeComponent();
            RegistroActividad.MovimientoRealizado += CargarData;
        }

        private void FormLogs_Load(object sender, EventArgs e)
        {
        }


        public void CargarData(RegistroActividad registro)
        {
            dgvLogs.DataSource = null;
            dgvLogs.DataSource = RegistroActividad.registros;
        }

        private void FormLogs_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
