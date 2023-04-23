using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Vistas
{
    public partial class FormContenedor : Form
    {
        private int usuario;
        public FormContenedor(int usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var hijo = new FormLogin();
            IsMdiContainer = true;
            hijo.BackColor = Color.Black;
            hijo.Height = 100;
            hijo.MdiParent = this;

            if (usuario == 1)
            {
                verStockToolStripMenuItem.Visible = true;
                gestionDeUsuariosToolStripMenuItem.Visible = true;
                calculadoraToolStripMenuItem.Visible = true;
                verCatalogoToolStripMenuItem.Visible = false;

            }
            else
            {
                gestionDeUsuariosToolStripMenuItem.Visible = false;
                calculadoraToolStripMenuItem.Visible = true;
                productoToolStripMenuItem.Visible = false;
                verCatalogoToolStripMenuItem.Visible = true;
            }
        }


        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (usuario == 1)
            {
                var hijo = new FormStock();
                hijo.MdiParent = this;
                hijo.Show();
            }
            else
            {
                MessageBox.Show("debes ser administrados");
            }


        }


        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formContenedor = new FormContenedor(usuario);
            formContenedor.Show();
            this.Hide();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCalculadora = new FormCalculadora();
            formCalculadora.Show();

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var formGestionUsuarios = new FormGestionUsuarios();
            formGestionUsuarios.Show();
        }

        private void barfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogo = new FormCatalogo();
            catalogo.Show();
        }
    }
}