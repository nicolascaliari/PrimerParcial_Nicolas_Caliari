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

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            decimal id = numericUpDownIdUsuario.Value;
            string nombre = txtBoxAltaNombre.Text;
            string apellido = txtBoxAltaApellido.Text;
            string password = txtBoxAltaPassword.Text;
            decimal edad = numericUpDownAltaEdad.Value;

            if (Validar.ValidarAltaUsuario(id, nombre, apellido, password, edad, comboBoxAltaTipo.SelectedIndex))
            {
                TipoUsuario usuario = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), comboBoxAltaTipo.SelectedItem.ToString());
                _nuevoUsuario = new Usuario(id, nombre, apellido, password, edad, usuario);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Visible = true;
            }





        }

        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void numericUpDownIdUsuario_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
