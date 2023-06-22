using Barfer.Entidades;
using Barfer.Entidades.Logs;
using Barfer.Entidades.SQL;
using Barfer.Entidades.Usuarios;
using Barfer.Entidades.Validaciones;
using Barfer.Vista.FormVentas;
using Barfer.Vista.FrmInformes;
using Barfer.Vista.FrmLogs;
using Barfer.Vista.FrmNotificacion;
using Barfer.Vista.Ventas;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.Win32;
using static Barfer.Entidades.Usuarios.Usuario;

namespace Vistas
{
    public partial class FormContenedor : Form
    {
        public int id;
        private string pass;
        private bool areButtonsVisible = false;
        private Form notificaiones;
        private Form logs;

        public FormContenedor(int id, string pass)
        {
            InitializeComponent();
            this.id = id;
            this.pass = pass;
            logs = new FormLogs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlVentas.Visible = false;
            lblDatosUsuario.Text = Usuario.GetNombreApellido(id, GestorDeUsuarios.usuarios);

            RegistroActividad registro = new RegistroActividad(Usuario.name, " el usuario ingreso al menu principal", DateTime.Now);
            RegistroActividad.OnMovimientoRealizado(registro);
        }




        Action<int> Saludar = (id) =>
        {
            MessageBox.Show($"Hola que bueno es encontrarte {Usuario.GetNombreApellido(id, GestorDeUsuarios.usuarios)}");
        };

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
            if (tipo == 1)
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
            pnlVentas.Visible = false;
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
            pnlVentas.Visible = false;
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
            pnlVentas.Visible = false;
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

        private void btn_submenuVentas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu();
        }



        private void MostrarSubMenu()
        {
            if (areButtonsVisible)
            {
                pnlVentas.Visible = false;
            }
            else
            {
                pnlVentas.Visible = true;
            }

            areButtonsVisible = !areButtonsVisible;
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            var formInformes = new FormInformes();
            formInformes.Show();
        }

        private void btnNotificacion_Click(object sender, EventArgs e)
        {

            if (notificaiones == null)
            {
                notificaiones = new FormNotificaciones();
            }
            notificaiones.Show();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            if (logs == null)
            {
                logs = new FormLogs();
            }
            logs.Show();
            //int tipo = (int)Validador.VerificarSiEsAdmin(id, GestorDeUsuarios.usuarios);
            //if (tipo == 1)
            //{
            //    FormLogs frmLogs = new FormLogs();
            //    frmLogs.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Solo los administradores tienen acceso");
            //}

        }
    }
}