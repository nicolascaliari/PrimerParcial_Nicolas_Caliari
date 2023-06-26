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
        /// Filtra los datos de los registros de actividad dependiendo del texto ingresado
        /// Los registros que coinciden con el texto de búsqueda en los campos Registro, Usuarioo o Fecha se agregan a la lista filtrado.
        /// </summary>
        /// <param name="filtrado">La lista donde se agregarán los registros filtrados.</param>
        private void FiltrarDatosDeLogs(List<RegistroActividad> filtrado)
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


        /// <summary>
        /// Evento que se ejecuta cuando se realiza un cambio en el texto del cuadro de búsqueda
        /// Filtra los datos de los registros de actividad dependiendo lo que escribas
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento de cambio de texto.</param>
        private void txtBoxBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBoxBuscar.Text))
            {
                List<RegistroActividad> filtrado = new List<RegistroActividad>();
                FiltrarDatosDeLogs(filtrado);
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
