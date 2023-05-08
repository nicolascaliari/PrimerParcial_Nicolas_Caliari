using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;
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
            txtBoxEdad.Text = editarUsuario.edadUsuario.ToString();
            lblError.Visible = false;

            cmbTipo.Text = editarUsuario.tipoUsuario.ToString();
            cmbTipo.Items.Add(TipoUsuario.Empleado);
            cmbTipo.Items.Add(TipoUsuario.Administrador);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = editarUsuario.nombreUsuario = txtBoxEditarNombre.Text;
            string apellido = editarUsuario.apellidoUsuario = txtBoxEditarApellido.Text;
            string password = editarUsuario.contraseñaUsuario = txtBoxEditarContrasenia.Text;
            decimal edad = editarUsuario.edadUsuario = int.Parse(txtBoxEdad.Text);
            //TipoUsuario tipo = editarUsuario.tipoUsuario = (TipoUsuario)cmbTipo.SelectedIndex;

            if (Validar.ValidarEdicionUsuario(nombre, apellido, password, edad))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Visible = true;
            }

            // editarUsuario.tipoUsuario = (TipoUsuario)cmbTipo.SelectedIndex;
            // GestorDeUsuarios.EditarUsuario(editarUsuario);


        }
    }
}
