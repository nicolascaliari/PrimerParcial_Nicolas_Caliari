using Barfer.Entidades;
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
        Usuario editarUsuario;
        public FormEditarUsuario(Usuario editarUsuario)
        {
            InitializeComponent();
            this.editarUsuario = editarUsuario;
        }


        private void ObtenerDatos()
        {
            txtBoxNombre.Text = editarUsuario.nombreUsuario;
            txtBoxApellido.Text = editarUsuario.apellidoUsuario;
            txtBoxEditarContrasenia.Text = editarUsuario.contraseñaUsuario;
            txtBoxEdad.Text = editarUsuario.edadUsuario.ToString();
            cmbTipo.Text = editarUsuario.tipoUsuario.ToString();
        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
            cmbTipo.Items.Add(TipoUsuario.Empleado);
            cmbTipo.Items.Add(TipoUsuario.Administrador);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

            MessageBox.Show(editarUsuario.idUsuario.ToString());
            editarUsuario.nombreUsuario = txtBoxNombre.Text;
            editarUsuario.apellidoUsuario = txtBoxApellido.Text;
            editarUsuario.contraseñaUsuario = txtBoxEditarContrasenia.Text;
            editarUsuario.edadUsuario = int.Parse(txtBoxEdad.Text);
            int id = Validar.EncontrarIdUsuario(editarUsuario.nombreUsuario, editarUsuario.contraseñaUsuario);

            MessageBox.Show(id.ToString());

            GestorDeUsuarios.ModificarUsuario(id, editarUsuario);


            // if (Validar.ValidarEdicionUsuario(nombre, apellido, password, edad))
            // {
            this.DialogResult = DialogResult.OK;
            // }
            //else
            // {
            //  lblError.Visible = true;
            // }

            // editarUsuario.tipoUsuario = (TipoUsuario)cmbTipo.SelectedIndex;
            // GestorDeUsuarios.EditarUsuario(editarUsuario);


        }
    }
}
