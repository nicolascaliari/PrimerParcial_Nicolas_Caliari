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
            lblDatosUsuario.Text = Usuario.GetNombreApellido(id, GestorDeUsuarios.usuarios);
        }



        /// <summary>
        /// Evento click que abre el Form de stock 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProducto_Click(object sender, EventArgs e)
        {
            int tipo = (int)Validador.VerificarSiEsAdmin(id, GestorDeUsuarios.usuarios);
            FormStock formStock = new FormStock(tipo);
            formStock.ShowDialog();
        }


        /// <summary>
        /// Evento click que abre el Form de gestor de usuarios si el usuario tiene permisos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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



        /// <summary>
        /// Evento click que abre el Form de calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            var formCalculadora = new FormCalculadora();
            formCalculadora.Show();
        }


        /// <summary>
        /// Evento click que abre el Form de gestor de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestorVentas_Click(object sender, EventArgs e)
        {
            var formGestorVentas = new FormGestorVentas();
            formGestorVentas.Show();
        }



        /// <summary>
        /// Evento click que abre el Form de preparacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreparacion_Click(object sender, EventArgs e)
        {
            FormPreparacion formPreparacion = new FormPreparacion();
            formPreparacion.Show();

        }

        /// <summary>
        /// Evento click que abre el Form de envios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnvio_Click(object sender, EventArgs e)
        {
            var formEnvio = new FormEnvio();
            formEnvio.Show();

        }



        /// <summary>
        /// Evento que sirve para cerrar la ventana actual y volver a la anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }



    }
}