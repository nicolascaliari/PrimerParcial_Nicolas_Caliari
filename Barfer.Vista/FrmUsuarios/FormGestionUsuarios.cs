﻿using System;
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
using Barfer.Entidades.Archivos;
using Barfer.Entidades.Usuarios;
using SpreadsheetLight;
using Vistas.FrmUsuarios;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Vistas
{
    public partial class FormGestionUsuarios : Form
    {
        public FormGestionUsuarios()
        {
            InitializeComponent();

        }


        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GestorDeUsuarios.CargarUsuariosDesdeArchivo();
        }


        /// <summary>
        /// Metodo para actualizar el dataGrid
        /// </summary>
        /// <param name="dgvUsuario"></param>
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


        /// <summary>
        /// Evento click que da de alta un usuario y actualiza el dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            var formAlta = new FormAltaUsuario();
            if (formAlta.ShowDialog() == DialogResult.OK)
            {
                GestorDeUsuarios.AltaUsuario(formAlta.nuevoUsuario);
                GuardarArchivo.GuardarUsuarioEnArchivo(GestorDeUsuarios.usuarios);
                ActualizarUsuarios(dataGridView1);
            }
        }


        /// <summary>
        /// Evento click que da de baja un usuario y actualiza el dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                GestorDeUsuarios.BajaUsuario((Usuario)dataGridView1.CurrentRow.DataBoundItem);
                GuardarArchivo.GuardarUsuarioEnArchivo(GestorDeUsuarios.usuarios);
                ActualizarUsuarios(dataGridView1);


            }
        }


        /// <summary>
        /// Evento click que te envia a otro form para editar el usuario seleccionado con sus datos correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No hay usuarios para modificar");
            }
            else
            {
                var formModificacion = new FormEditarUsuario((Usuario)dataGridView1.CurrentRow.DataBoundItem);
                if (formModificacion.ShowDialog() == DialogResult.OK)
                {
                    ActualizarUsuarios(dataGridView1);
                    GuardarArchivo.GuardarUsuarioEnArchivo(GestorDeUsuarios.usuarios);
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
