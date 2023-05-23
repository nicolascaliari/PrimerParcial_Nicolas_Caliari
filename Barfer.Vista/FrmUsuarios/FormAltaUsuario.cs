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
using static Barfer.Entidades.Alimento;
using static Barfer.Entidades.Usuarios.Usuario;
using static System.Windows.Forms.DataFormats;

namespace Vistas.FrmUsuarios
{
    public partial class FormAltaUsuario : Form
    {

        private Usuario _nuevoUsuario;

        public Usuario nuevoUsuario
        {
            get { return _nuevoUsuario; }
            set { _nuevoUsuario = value; }
        }

        public FormAltaUsuario()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Evento que setea el label de error en false y cargas el comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;

            comboBoxAltaTipo.Items.Clear(); 
            foreach (TipoUsuario item in Enum.GetValues(typeof(TipoUsuario)))
            {
                comboBoxAltaTipo.Items.Add(item);
            }
        }



        /// <summary>
        /// Evento que da de alta un usuario caso contrario muestro error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxAltaNombre.Text;
            string apellido = txtBoxAltaApellido.Text;
            string password = txtBoxAltaPassword.Text;
            decimal edad = numericUpDownEdad.Value;


            try
            {
                Validador.ValidarUsuario(nombre);
                Validador.ValidarApellidoUsuario(apellido);
                Validador.ValidarPassword(password);
                Validador.ValidarEdad(edad);
                Validador.ValidarEnumsUsuario(comboBoxAltaTipo.SelectedIndex);

                TipoUsuario usuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), comboBoxAltaTipo.SelectedItem.ToString());

                _nuevoUsuario = FactoryMethodUsuario.CrearUsuario(usuario);
                _nuevoUsuario.nombreUsuario = nombre;
                _nuevoUsuario.apellidoUsuario = apellido;
                _nuevoUsuario.contraseñaUsuario = password;
                _nuevoUsuario.edadUsuario = edad;
                _nuevoUsuario.idUsuario = _nuevoUsuario.ObtenerUltimoId(GestorDeUsuarios.usuarios) + 1;
                this.DialogResult = DialogResult.OK;
            }
            catch (ExceptionCampos ex)
            {
                lblError.Visible = true;
                lblError.Text = $"{ex.Message}";
            }
            catch (LoginFallidoException ex)
            {
                lblError.Visible = true;
                lblError.Text = $"{ex.Message}";
            }
        }


        private void numericUpDownIdUsuario_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
