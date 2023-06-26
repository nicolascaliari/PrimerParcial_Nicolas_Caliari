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
            dgvLogs.DataSource = null;
            dgvLogs.DataSource = RegistroActividad.registros;

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




        /// <summary>
        /// Este metodo filtra los datos de alimento segun el texto ingresado en el TextBox
        /// </summary>
        /// <param name="filtrado"></param>
        private void FiltrarDatosDeAlimento(List<RegistroActividad> filtrado)
        {
            foreach (RegistroActividad item in RegistroActividad.registros)
            {
                if (item.Registro.ToString().ToUpper().StartsWith(this.txtBoxBuscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.Usuarioo.ToString().ToUpper().StartsWith(this.txtBoxBuscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }
                else if (item.Fecha.ToString().ToUpper().StartsWith(this.txtBoxBuscar.Text.ToUpper()))
                {
                    filtrado.Add(item);
                }

            }
        }

        private void txtBoxBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBoxBuscar.Text))
            {
                List<RegistroActividad> filtrado = new List<RegistroActividad>();
                FiltrarDatosDeAlimento(filtrado);
                this.dgvLogs.DataSource = filtrado;
            }
            else
            {
                if (RegistroActividad.registros.Count > 0)
                {
                    dgvLogs.DataSource = RegistroActividad.registros;
                }
            }
        }
    }
}
