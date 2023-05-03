using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Vistas
{
    public partial class FormContenedor : Form
    {
        private int id;
        private string pass;

        public FormContenedor(int id, string pass)
        {
            InitializeComponent();
            this.id = id;
            this.pass = pass;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var hijo = new FormLogin();
            this.IsMdiContainer = true;
            hijo.BackColor = Color.Black;
            hijo.Height = 100;
            hijo.MdiParent = this;

            lblDatosUsuario.Text = Validar.GetNombreApellido(id, GestorDeUsuarios.usuarios);
        }




        private void btnProducto_Click(object sender, EventArgs e)
        {
            int tipo = (int)Validar.VerificarSiEsAdmin(id, GestorDeUsuarios.usuarios);
            MessageBox.Show(tipo.ToString());
            FormStock formStock = new FormStock(tipo);
            // formStock.MdiParent = this;
            formStock.ShowDialog();
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            int tipo = (int)Validar.VerificarSiEsAdmin(id, GestorDeUsuarios.usuarios);
            if (tipo == 0)
            {
                var formGestionUsuarios = new FormGestionUsuarios();
                formGestionUsuarios.Show();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a esta seccion");
            }

        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            var formCalculadora = new FormCalculadora();
            formCalculadora.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var formContenedor = new FormContenedor(id, pass);
            formContenedor.Show();
            this.Hide();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}