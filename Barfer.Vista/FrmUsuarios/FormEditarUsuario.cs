using Barfer.Entidades;
using Barfer.Entidades.SQL;
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
using static Barfer.Entidades.Alimento;
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
        /// Este evento deja el label en false, carga el comboBox con los tipos de usuarios que tengo
        /// y muestra los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
       
            foreach (TipoUsuario item in Enum.GetValues(typeof(TipoUsuario)))
            {
                cmbTipo.Items.Add(item);
            }
            ObtenerDatos();

        }



        /// <summary>
        /// Metodo que obtiene los datos en los campos
        /// </summary>
        private void ObtenerDatos()
        {
            txtBoxNombre.Text = editarUsuario.nombreUsuario;
            txtBoxApellido.Text = editarUsuario.apellidoUsuario;
            txtBoxEditarContrasenia.Text = editarUsuario.password;
            txtBoxEdad.Text = editarUsuario.edadUsuario.ToString();
            cmbTipo.Text = editarUsuario.tipoUsuario.ToString();


            cmbTipo.SelectedItem = editarUsuario.tipoUsuario;
        }


       /// <summary>
       /// Evento en donde si no se arroja una excepcion se edita el usuario correctamente.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
           string nombre = editarUsuario.nombreUsuario = txtBoxNombre.Text;
           string apellido = editarUsuario.apellidoUsuario = txtBoxApellido.Text;
           string password =  editarUsuario.password = txtBoxEditarContrasenia.Text;
           decimal edad =  editarUsuario.edadUsuario = int.Parse(txtBoxEdad.Text);
           TipoUsuario tipo = (TipoUsuario)cmbTipo.SelectedItem;
            int id = Validador.EncontrarIdUsuario(nombre, password);

            try
            {
                Validador.ValidarUsuario(nombre);
                Validador.ValidarPassword(password);
                Validador.ValidarApellidoUsuario(apellido);
                Validador.ValidarEdad(edad);
                GestorDeUsuarios.ModificarUsuario(id, editarUsuario,tipo);
                var usuario = new UsuarioDB();
                usuario.ModificarAsync(editarUsuario);
                this.DialogResult = DialogResult.OK;
            }
            catch(ExceptionCampos ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }catch(LoginFallidoException ex)
            {
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }finally { MessageBox.Show("listo"); }
               

        }
    }
}
