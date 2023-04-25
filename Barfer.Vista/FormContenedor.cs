using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Vistas
{
    public partial class FormContenedor : Form
    {
        private int usuario;
        private decimal id;

        public FormContenedor(int usuario, decimal id)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.id = id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var hijo = new FormLogin();
            IsMdiContainer = true;
            hijo.BackColor = Color.Black;
            hijo.Height = 100;
            hijo.MdiParent = this;


            labelNombre.Text = GestorDeUsuarios.usuarios.Find(x => x.idUsuario == id).nombreUsuario;
            labelApellido.Text = GestorDeUsuarios.usuarios.Find(x => x.idUsuario == id).apellidoUsuario;
            labelTipo.Text = GestorDeUsuarios.usuarios.Find(x => x.idUsuario == id).tipoUsuario.ToString();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (usuario == 1)
            {
                FormStock formStock = new FormStock();
                // formStock.MdiParent = this;
                formStock.Show();
            }
            else
            {
                MessageBox.Show("debes ser administrados");
            }
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            var formGestionUsuarios = new FormGestionUsuarios();
            formGestionUsuarios.Show();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            var formCalculadora = new FormCalculadora();
            formCalculadora.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var formContenedor = new FormContenedor(usuario, id);
            formContenedor.Show();
            this.Hide();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}