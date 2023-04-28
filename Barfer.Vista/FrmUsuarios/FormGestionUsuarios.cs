using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
using SpreadsheetLight;
using Vistas.FrmUsuarios;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Vistas
{
    public partial class FormGestionUsuarios : Form
    {
        private string path = @"C:\\Users\\nicolas\\Desktop\\PrimerParcial_Nicolas_Caliari\\Barfer.Vista\\bin\\Debug\\net6.0-windows\miExcel.xlsx";
        public FormGestionUsuarios()
        {
            InitializeComponent();

        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GestorDeUsuarios.CargarUsuariosDesdeArchivo();
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
                GestorDeUsuarios.AltaUsuario(formAlta.nuevoUsuario);
                Archivo.GuardarUsuarioEnArchivo(GestorDeUsuarios.usuarios);
                ActualizarUsuarios(dataGridView1);
            }
        }


        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                GestorDeUsuarios.BajaUsuario((Usuario)dataGridView1.CurrentRow.DataBoundItem);
                Archivo.GuardarUsuarioEnArchivo(GestorDeUsuarios.usuarios);
                ActualizarUsuarios(dataGridView1);
            }
        }


        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount == 0)
            {
                //MessageBox.Show("No hay usuarios para modificar");
            }
            else
            {
                var formModificacion = new FormEditarUsuario((Usuario)dataGridView1.CurrentRow.DataBoundItem);
                if (formModificacion.ShowDialog() == DialogResult.OK)
                {
                    ActualizarUsuarios(dataGridView1);
                    Archivo.GuardarUsuarioEnArchivo(GestorDeUsuarios.usuarios);
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}
