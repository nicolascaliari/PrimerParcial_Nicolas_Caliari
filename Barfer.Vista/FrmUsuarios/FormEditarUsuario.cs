using Barfer.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Vistas.FrmUsuarios
{
    public partial class FormEditarUsuario : Form
    {
        private Usuario editarUsuario;
        public FormEditarUsuario(Usuario editarUsuario)
        {
            InitializeComponent();
            this.editarUsuario = editarUsuario;
        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            txtBoxEditarNombre.Text = editarUsuario.nombreUsuario;
            txtBoxEditarApellido.Text = editarUsuario.apellidoUsuario;
            txtBoxEditarContrasenia.Text = editarUsuario.contraseñaUsuario;
            txtBoxEditarEdad.Text = editarUsuario.edadUsuario.ToString();
            //comboBoxEditarTipo.Text = editarUsuario.Tipo.ToString();

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            editarUsuario.nombreUsuario = txtBoxEditarNombre.Text;
            editarUsuario.apellidoUsuario = txtBoxEditarApellido.Text;
            editarUsuario.contraseñaUsuario = txtBoxEditarContrasenia.Text;
            editarUsuario.edadUsuario = int.Parse(txtBoxEditarEdad.Text);
            //editarUsuario.Tipo = (TipoUsuario)comboBoxEditarTipo.SelectedIndex;
           // GestorDeUsuarios.EditarUsuario(editarUsuario);
            this.DialogResult = DialogResult.OK;

        }
    }
}
