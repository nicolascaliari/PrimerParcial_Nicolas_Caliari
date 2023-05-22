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
using Barfer.Entidades.Archivos;
using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;

namespace Vistas
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();

            GestorDeUsuarios.CargarUsuariosDesdeArchivo();
            GestorProductos.CargarAlimentoDesdeArchivo();
            GestorDeUsuarios.CargarClientesDesdeArchivo();
            //Archivo.CrearArchivoAlimentos();
           // Archivo.CrearArchivoClientes();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (GestorDeUsuarios.usuarios.Count <= 0)
            {
                MessageBox.Show("No hay usuarios cargados al sistema");
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombreUsuario.Text;
            string contrasenia = txtBoxContraseñaUsuario.Text;

            try
            {
                Validador.ValidarUsuario(nombre);
                Validador.ValidarPassword(contrasenia);

                int id = Validador.EncontrarIdUsuario(nombre, contrasenia);
                AccederMenuPrincipal(id, contrasenia);

            }
            catch(LoginFallidoException ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }


        private void AccederMenuPrincipal(int id, string pass)
        {
            FormContenedor menuPrincipal = new FormContenedor(id, pass);
            this.Hide();
            menuPrincipal.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtBoxNombreUsuario.Text = "nicolas";
            txtBoxContraseñaUsuario.Text = "Agunic1004";
        }


        private void txtBoxNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
