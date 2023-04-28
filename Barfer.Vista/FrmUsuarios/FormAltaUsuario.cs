using Barfer.Entidades;
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
            string tipo = comboBoxAltaTipo.Text;
            _nuevoUsuario = new Usuario(numericUpDownIdUsuario.Value, txtBoxAltaNombre.Text, txtBoxAltaApellido.Text, txtBoxAltaPassword.Text, decimal.Parse(txtBoxAltaEdad.Text), (TipoUsuario)comboBoxAltaTipo.SelectedIndex);
            this.DialogResult = DialogResult.OK;


        }

        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
