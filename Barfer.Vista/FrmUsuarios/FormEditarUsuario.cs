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



        /// <summary>
        /// Metodo que obtiene los datos en los campos
        /// </summary>
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
            lblError.Visible = false;
            ObtenerDatos();
            cmbTipo.Items.Add(TipoUsuario.Administrador);
            cmbTipo.Items.Add(TipoUsuario.Empleado);
            int id = Validador.EncontrarIdUsuario(editarUsuario.nombreUsuario, editarUsuario.contraseñaUsuario);
            var usuario = GestorDeUsuarios.usuarios.FirstOrDefault(x => x.idUsuario == id);

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
           string nombre = editarUsuario.nombreUsuario = txtBoxNombre.Text;
           string apellido = editarUsuario.apellidoUsuario = txtBoxApellido.Text;
           string password =  editarUsuario.contraseñaUsuario = txtBoxEditarContrasenia.Text;
           decimal edad =  editarUsuario.edadUsuario = int.Parse(txtBoxEdad.Text);
           TipoUsuario tipo = (TipoUsuario)cmbTipo.SelectedIndex;
            int id = Validador.EncontrarIdUsuario(nombre, password);

            try
            {
                Validador.ValidarUsuario(nombre);
                Validador.ValidarPassword(password);
                Validador.ValidarApellidoUsuario(apellido);
                Validador.ValidarEdadUsuario(edad);
                GestorDeUsuarios.ModificarUsuario(id, editarUsuario,tipo);

                this.DialogResult = DialogResult.OK;
            }
            catch(AltaFallidoException ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }catch(LoginFallidoException ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
               

        }
    }
}
