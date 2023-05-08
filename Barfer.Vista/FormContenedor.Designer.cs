namespace Vistas
{
    partial class FormContenedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContenedor));
            panel1 = new Panel();
            btnReporte = new Button();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            lblDatosUsuario = new Label();
            btnSalir = new PictureBox();
            pictureBox4 = new PictureBox();
            btnCalculadora = new Button();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnGestor = new Button();
            btnProducto = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            btnGestorVentas = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(btnGestorVentas);
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnCalculadora);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnGestor);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 748);
            panel1.TabIndex = 5;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(26, 32, 40);
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporte.ForeColor = SystemColors.ButtonHighlight;
            btnReporte.Location = new Point(94, 498);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(116, 41);
            btnReporte.TabIndex = 3;
            btnReporte.Text = "Reportes";
            btnReporte.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 32, 40);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(lblDatosUsuario);
            panel3.Location = new Point(12, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 100);
            panel3.TabIndex = 2;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Barfer.Vista.Properties.Resources._12506835751543238941_128__1_;
            pictureBox6.Location = new Point(9, 11);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 65);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatosUsuario.ForeColor = SystemColors.ButtonFace;
            lblDatosUsuario.Location = new Point(94, 11);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(41, 17);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "datos";
            // 
            // btnSalir
            // 
            btnSalir.Image = Barfer.Vista.Properties.Resources._13163802951582793675_128;
            btnSalir.Location = new Point(12, 696);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(48, 31);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 2;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Barfer.Vista.Properties.Resources.reportes;
            pictureBox4.Location = new Point(12, 498);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // btnCalculadora
            // 
            btnCalculadora.BackColor = Color.FromArgb(26, 32, 40);
            btnCalculadora.FlatAppearance.BorderSize = 0;
            btnCalculadora.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCalculadora.FlatStyle = FlatStyle.Flat;
            btnCalculadora.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculadora.ForeColor = SystemColors.ButtonHighlight;
            btnCalculadora.Location = new Point(84, 412);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(116, 37);
            btnCalculadora.TabIndex = 2;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = false;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 329);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Barfer.Vista.Properties.Resources.Logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnGestor
            // 
            btnGestor.BackColor = Color.FromArgb(26, 32, 40);
            btnGestor.FlatAppearance.BorderSize = 0;
            btnGestor.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnGestor.FlatStyle = FlatStyle.Flat;
            btnGestor.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestor.ForeColor = SystemColors.ButtonHighlight;
            btnGestor.Location = new Point(84, 329);
            btnGestor.Name = "btnGestor";
            btnGestor.Size = new Size(116, 37);
            btnGestor.TabIndex = 1;
            btnGestor.Text = " Usuarios";
            btnGestor.UseVisualStyleBackColor = false;
            btnGestor.Click += btnGestor_Click;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.FromArgb(26, 32, 40);
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducto.ForeColor = SystemColors.ButtonHighlight;
            btnProducto.Location = new Point(84, 248);
            btnProducto.Name = "btnProducto";
            btnProducto.RightToLeft = RightToLeft.No;
            btnProducto.Size = new Size(116, 37);
            btnProducto.TabIndex = 0;
            btnProducto.Text = "Productos";
            btnProducto.UseVisualStyleBackColor = false;
            btnProducto.Click += btnProducto_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 412);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 66, 82);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(216, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1163, 748);
            panel2.TabIndex = 6;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Barfer.Vista.Properties.Resources.a20c4957_7df7_4574_92d0_d2c95067f156;
            pictureBox7.Location = new Point(469, -2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(525, 678);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(6, 322);
            label1.Name = "label1";
            label1.Size = new Size(459, 52);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a Barfer";
            // 
            // btnGestorVentas
            // 
            btnGestorVentas.Location = new Point(88, 600);
            btnGestorVentas.Name = "btnGestorVentas";
            btnGestorVentas.Size = new Size(112, 23);
            btnGestorVentas.TabIndex = 5;
            btnGestorVentas.Text = "Gestor de ventas";
            btnGestorVentas.UseVisualStyleBackColor = true;
            btnGestorVentas.Click += btnGestorVentas_Click;
            // 
            // FormContenedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1379, 748);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormContenedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button btnProducto;
        private Button btnGestor;
        private Button btnCalculadora;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox btnSalir;
        private Panel panel3;
        private Label lblDatosUsuario;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Button btnReporte;
        private Button btnGestorVentas;
    }
}