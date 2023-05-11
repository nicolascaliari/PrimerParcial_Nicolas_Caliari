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
            dtgPreparacion.Location = new Point(31, 166);
            dtgPreparacion.Name = "dtgPreparacion";
            dtgPreparacion.RowTemplate.Height = 25;
            dtgPreparacion.Size = new Size(976, 627);
            dtgPreparacion.TabIndex = 0;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Alimento
            // 
            Alimento.HeaderText = "Alimento";
            Alimento.Name = "Alimento";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(189, 46);
            label1.Name = "label1";
            label1.Size = new Size(249, 32);
            label1.TabIndex = 1;
            label1.Text = "Preparacion de ventas";
            // 
            // btnFinalizarPreparacion
            // 
            btnFinalizarPreparacion.BackColor = Color.FromArgb(40, 40, 40);
            btnFinalizarPreparacion.FlatAppearance.BorderSize = 0;
            btnFinalizarPreparacion.FlatStyle = FlatStyle.Flat;
            btnFinalizarPreparacion.ForeColor = SystemColors.ButtonFace;
            btnFinalizarPreparacion.Location = new Point(1398, 828);
            btnFinalizarPreparacion.Name = "btnFinalizarPreparacion";
            btnFinalizarPreparacion.Size = new Size(158, 53);
            btnFinalizarPreparacion.TabIndex = 2;
            btnFinalizarPreparacion.Text = "Finalizar preparacion";
            btnFinalizarPreparacion.UseVisualStyleBackColor = false;
            btnFinalizarPreparacion.Click += btnFinalizarPreparacion_Click;
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(12, 835);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 46);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 3;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEntrega
            // 
            btnEntrega.Location = new Point(1086, 338);
            btnEntrega.Name = "btnEntrega";
            btnEntrega.Size = new Size(213, 41);
            btnEntrega.TabIndex = 4;
            btnEntrega.Text = "Programar fecha de entrega";
            btnEntrega.UseVisualStyleBackColor = true;
            btnEntrega.Click += btnEntrega_Click;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(1070, 401);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(246, 23);
            dtpFechaEntrega.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(1224, 447);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar fecha";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblNoHayPreparaciones
            // 
            lblNoHayPreparaciones.AutoSize = true;
            lblNoHayPreparaciones.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoHayPreparaciones.Location = new Point(387, 459);
            lblNoHayPreparaciones.Name = "lblNoHayPreparaciones";
            lblNoHayPreparaciones.Size = new Size(112, 47);
            lblNoHayPreparaciones.TabIndex = 7;
            lblNoHayPreparaciones.Text = "label2";
            // 
            // FormPreparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1568, 893);
            Controls.Add(lblNoHayPreparaciones);
            Controls.Add(btnConfirmar);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(btnEntrega);
            Controls.Add(btnBack);
            Controls.Add(btnFinalizarPreparacion);
            Controls.Add(label1);
            Controls.Add(dtgPreparacion);
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
    }
}