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
using Barfer.Entidades.Usuarios;
using Vistas.FrmUsuarios;

namespace Vistas
{
    public partial class FormGestionUsuarios : Form
    {

        public FormGestionUsuarios()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarUsuarios(dataGridView1);
        }


        private void ActualizarUsuarios(DataGridView dgvUsuario)
        {
            if (GestorDeUsuarios.usuarios.Count > 0)
            {
                dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = GestorDeUsuarios.usuarios;
                dgvUsuario.Visible = true;
            }
            else
            {
                dgvUsuario.Visible = false;
            }
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            var formAlta = new FormAltaUsuario();
            if (formAlta.ShowDialog() == DialogResult.OK)
            {
                ActualizarUsuarios(dataGridView1);
            }
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                GestorDeUsuarios.BajaUsuario((Usuario)dataGridView1.CurrentRow.DataBoundItem);
                ActualizarUsuarios(dataGridView1);
            }
        }

        private void btnModificacionUsuario_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.RowCount == 0)
            {
                //MessageBox.Show("No hay usuarios para modificar");
            }
            else
            {
                    var formModificacion = new FormEditarUsuario((Usuario)dataGridView1.CurrentRow.DataBoundItem);
                    if (formModificacion.ShowDialog() == DialogResult.OK)
                {
                        ActualizarUsuarios(dataGridView1);
                    }
            }
        }
    }
}
