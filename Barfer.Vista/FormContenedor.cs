using Barfer.Entidades;
using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;
using Barfer.Vista.FormVentas;
using Barfer.Vista.Ventas;
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

            lblDatosUsuario.Text = Usuario.GetNombreApellido(id, GestorDeUsuarios.usuarios);
        }




        private void btnProducto_Click(object sender, EventArgs e)
        {
            int tipo = (int)Validador.VerificarSiEsAdmin(id, GestorDeUsuarios.usuarios);
            FormStock formStock = new FormStock(tipo);
            formStock.ShowDialog();
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            int tipo = (int)Validador.VerificarSiEsAdmin(id, GestorDeUsuarios.usuarios);
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


        private void btnGestorVentas_Click(object sender, EventArgs e)
        {
            var formGestorVentas = new FormGestorVentas();
            formGestorVentas.Show();
        }


        private void btnPreparacion_Click(object sender, EventArgs e)
        {
            FormPreparacion formPreparacion = new FormPreparacion();
            formPreparacion.Show();

        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            var formEnvio = new FormEnvio();
            formEnvio.Show();

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


    }
}