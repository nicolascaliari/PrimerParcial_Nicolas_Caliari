namespace Barfer.Vista.FormVentas
{
    partial class FormPreparacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgPreparacion = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Alimento = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnFinalizarPreparacion = new Button();
            btnBack = new PictureBox();
            btnEntrega = new Button();
            dtpFechaEntrega = new DateTimePicker();
            btnConfirmar = new Button();
            lblNoHayPreparaciones = new Label();
            lblHorarioConfirmado = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgPreparacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // dtgPreparacion
            // 
            dtgPreparacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPreparacion.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgPreparacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPreparacion.Columns.AddRange(new DataGridViewColumn[] { Cliente, Alimento, Cantidad, Precio, Fecha, Estado });
            dtgPreparacion.Location = new Point(35, 221);
            dtgPreparacion.Margin = new Padding(3, 4, 3, 4);
            dtgPreparacion.Name = "dtgPreparacion";
            dtgPreparacion.RowHeadersWidth = 51;
            dtgPreparacion.RowTemplate.Height = 25;
            dtgPreparacion.Size = new Size(1115, 836);
            dtgPreparacion.TabIndex = 0;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            // 
            // Alimento
            // 
            Alimento.HeaderText = "Alimento";
            Alimento.MinimumWidth = 6;
            Alimento.Name = "Alimento";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(216, 61);
            label1.Name = "label1";
            label1.Size = new Size(310, 41);
            label1.TabIndex = 1;
            label1.Text = "Preparacion de ventas";
            // 
            // btnFinalizarPreparacion
            // 
            btnFinalizarPreparacion.BackColor = Color.FromArgb(40, 40, 40);
            btnFinalizarPreparacion.FlatAppearance.BorderSize = 0;
            btnFinalizarPreparacion.FlatStyle = FlatStyle.Flat;
            btnFinalizarPreparacion.ForeColor = SystemColors.ButtonFace;
            btnFinalizarPreparacion.Location = new Point(1598, 1104);
            btnFinalizarPreparacion.Margin = new Padding(3, 4, 3, 4);
            btnFinalizarPreparacion.Name = "btnFinalizarPreparacion";
            btnFinalizarPreparacion.Size = new Size(181, 71);
            btnFinalizarPreparacion.TabIndex = 2;
            btnFinalizarPreparacion.Text = "Finalizar preparacion";
            btnFinalizarPreparacion.UseVisualStyleBackColor = false;
            btnFinalizarPreparacion.Click += btnFinalizarPreparacion_Click;
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(14, 1113);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(89, 61);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 3;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEntrega
            // 
            btnEntrega.BackColor = Color.FromArgb(40, 40, 40);
            btnEntrega.FlatAppearance.BorderSize = 0;
            btnEntrega.FlatStyle = FlatStyle.Flat;
            btnEntrega.ForeColor = SystemColors.ButtonFace;
            btnEntrega.Location = new Point(1346, 437);
            btnEntrega.Margin = new Padding(3, 4, 3, 4);
            btnEntrega.Name = "btnEntrega";
            btnEntrega.Size = new Size(243, 55);
            btnEntrega.TabIndex = 4;
            btnEntrega.Text = "Programar fecha de entrega";
            btnEntrega.UseVisualStyleBackColor = false;
            btnEntrega.Click += btnEntrega_Click;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.CalendarForeColor = SystemColors.ButtonHighlight;
            dtpFechaEntrega.CalendarMonthBackground = SystemColors.HotTrack;
            dtpFechaEntrega.CalendarTitleBackColor = SystemColors.ButtonShadow;
            dtpFechaEntrega.CalendarTitleForeColor = SystemColors.ControlDark;
            dtpFechaEntrega.CalendarTrailingForeColor = SystemColors.ControlText;
            dtpFechaEntrega.Location = new Point(1330, 526);
            dtpFechaEntrega.Margin = new Padding(3, 4, 3, 4);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(281, 27);
            dtpFechaEntrega.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(40, 40, 40);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = SystemColors.ButtonFace;
            btnConfirmar.Location = new Point(1395, 623);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(150, 49);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar fecha";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblNoHayPreparaciones
            // 
            lblNoHayPreparaciones.AutoSize = true;
            lblNoHayPreparaciones.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoHayPreparaciones.Location = new Point(442, 612);
            lblNoHayPreparaciones.Name = "lblNoHayPreparaciones";
            lblNoHayPreparaciones.Size = new Size(142, 60);
            lblNoHayPreparaciones.TabIndex = 7;
            lblNoHayPreparaciones.Text = "label2";
            // 
            // lblHorarioConfirmado
            // 
            lblHorarioConfirmado.AutoSize = true;
            lblHorarioConfirmado.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblHorarioConfirmado.Location = new Point(1293, 741);
            lblHorarioConfirmado.Name = "lblHorarioConfirmado";
            lblHorarioConfirmado.Size = new Size(288, 31);
            lblHorarioConfirmado.TabIndex = 8;
            lblHorarioConfirmado.Text = "No hay horario confirmado";
            // 
            // FormPreparacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1835, 1162);
            Controls.Add(lblHorarioConfirmado);
            Controls.Add(lblNoHayPreparaciones);
            Controls.Add(btnConfirmar);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(btnEntrega);
            Controls.Add(btnBack);
            Controls.Add(btnFinalizarPreparacion);
            Controls.Add(label1);
            Controls.Add(dtgPreparacion);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPreparacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPreparacion";
            Load += FormPreparacion_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPreparacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgPreparacion;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Alimento;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Estado;
        private Label label1;
        private Button btnFinalizarPreparacion;
        private PictureBox btnBack;
        private Button btnEntrega;
        private DateTimePicker dtpFechaEntrega;
        private Button btnConfirmar;
        private Label lblNoHayPreparaciones;
        private Label lblHorarioConfirmado;
    }
}