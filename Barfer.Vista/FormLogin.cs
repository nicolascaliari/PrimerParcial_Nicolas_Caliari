using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;

namespace Vistas
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (GestorDeUsuarios.usuarios.Count < 0)
            {

                MessageBox.Show("No hay usuarios cargados al sistema");
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombreUsuario.Text;
            string contrasenia = txtBoxContraseñaUsuario.Text;

            int validar = Validar.VerificarUsuarioContrasenia(nombre, contrasenia);

            decimal id = Validar.EncontrarIdUsuario(nombre, contrasenia);

            if (validar != -1)
            {
                AccederMenuPrincipal(validar, id);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }


        }


        private void AccederMenuPrincipal(int usuario, decimal id)
        {
            FormContenedor menuPrincipal = new FormContenedor(usuario, id);
            this.Hide();
            menuPrincipal.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtBoxNombreUsuario.Text = "nicolas";
            txtBoxContraseñaUsuario.Text = "agunic";
        }


        private void txtBoxNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
