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
        private Empleado _nuevoUsuarioEmpleado;
        private Administrador _nuevoUsuarioAdministrador;

        public Administrador nuevoUsuarioAdministrador
        {
            get { return _nuevoUsuarioAdministrador; }
        }
        public Usuario nuevoUsuarioEmpleado
        {
            get { return _nuevoUsuarioEmpleado; }
        }
        public FormAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            string tipo = comboBoxAltaTipo.Text;

            if (tipo == "administrador")
            {
                _nuevoUsuarioAdministrador = new Administrador(txtBoxAltaNombre.Text, txtBoxAltaApellido.Text, txtBoxAltaPassword.Text, int.Parse(txtBoxAltaEdad.Text),(TipoUsuario)comboBoxAltaTipo.SelectedIndex);
                GestorDeUsuarios.AltaUsuarioAdministrador(_nuevoUsuarioAdministrador);
                this.DialogResult = DialogResult.OK;
            }
            else if (tipo == "empleado")
            {
                _nuevoUsuarioEmpleado = new Empleado(txtBoxAltaNombre.Text, txtBoxAltaApellido.Text, txtBoxAltaPassword.Text, int.Parse(txtBoxAltaEdad.Text),(TipoUsuario)comboBoxAltaTipo.SelectedIndex);
                GestorDeUsuarios.AltaUsuarioEmpleado(_nuevoUsuarioEmpleado);
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
