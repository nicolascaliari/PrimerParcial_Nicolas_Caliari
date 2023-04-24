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
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnGestor = new Button();
            btnHome = new Button();
            btnProducto = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnCalculadora = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnGestor);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnProducto);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnCalculadora);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 383);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(21, 206);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Barfer.Vista.Properties.Resources.Logo;
            pictureBox1.Location = new Point(19, 12);
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
            btnGestor.Location = new Point(84, 206);
            btnGestor.Name = "btnGestor";
            btnGestor.Size = new Size(116, 37);
            btnGestor.TabIndex = 1;
            btnGestor.Text = " Usuarios";
            btnGestor.UseVisualStyleBackColor = false;
            btnGestor.Click += btnGestor_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(26, 32, 40);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Location = new Point(84, 387);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(116, 37);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnProducto
            // 
            btnProducto.BackColor = Color.FromArgb(26, 32, 40);
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducto.ForeColor = SystemColors.ButtonHighlight;
            btnProducto.Location = new Point(84, 124);
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
            pictureBox3.Location = new Point(19, 299);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnCalculadora
            // 
            btnCalculadora.BackColor = Color.FromArgb(26, 32, 40);
            btnCalculadora.FlatAppearance.BorderSize = 0;
            btnCalculadora.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCalculadora.FlatStyle = FlatStyle.Flat;
            btnCalculadora.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculadora.ForeColor = SystemColors.ButtonHighlight;
            btnCalculadora.Location = new Point(84, 299);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(116, 37);
            btnCalculadora.TabIndex = 2;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = false;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 66, 82);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 450);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 58);
            label1.Name = "label1";
            label1.Size = new Size(409, 44);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a Barfer";
            // 
            // FormContenedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormContenedor";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button btnHome;
        private Button btnProducto;
        private Button btnGestor;
        private Button btnCalculadora;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
    }
}