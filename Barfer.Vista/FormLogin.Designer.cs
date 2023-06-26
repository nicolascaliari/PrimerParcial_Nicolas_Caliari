namespace Vistas
{
    partial class FormLogin
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
            txtBoxNombreUsuario = new TextBox();
            txtBoxContraseñaUsuario = new TextBox();
            btnLogin = new Button();
            btnAdmin = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxNombreUsuario
            // 
            txtBoxNombreUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtBoxNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBoxNombreUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxNombreUsuario.ForeColor = SystemColors.Menu;
            txtBoxNombreUsuario.Location = new Point(387, 189);
            txtBoxNombreUsuario.Margin = new Padding(8, 9, 8, 9);
            txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            txtBoxNombreUsuario.PlaceholderText = "Usuario";
            txtBoxNombreUsuario.Size = new Size(394, 29);
            txtBoxNombreUsuario.TabIndex = 2;
            txtBoxNombreUsuario.TextChanged += txtBoxNombreUsuario_TextChanged;
            // 
            // txtBoxContraseñaUsuario
            // 
            txtBoxContraseñaUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtBoxContraseñaUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBoxContraseñaUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxContraseñaUsuario.ForeColor = SystemColors.Menu;
            txtBoxContraseñaUsuario.Location = new Point(387, 305);
            txtBoxContraseñaUsuario.Margin = new Padding(3, 4, 3, 4);
            txtBoxContraseñaUsuario.Name = "txtBoxContraseñaUsuario";
            txtBoxContraseñaUsuario.PlaceholderText = "Contraseña";
            txtBoxContraseñaUsuario.Size = new Size(394, 29);
            txtBoxContraseñaUsuario.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(387, 459);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(394, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(40, 40, 40);
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.ForeColor = SystemColors.ButtonFace;
            btnAdmin.Location = new Point(48, 504);
            btnAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(160, 45);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "Ingresar directo";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Barfer.Vista.Properties.Resources.LogoAzul;
            pictureBox1.Location = new Point(3, 229);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 568);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(520, 36);
            label1.Name = "label1";
            label1.Size = new Size(150, 54);
            label1.TabIndex = 8;
            label1.Text = "LOGIN";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(893, 568);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtBoxNombreUsuario);
            Controls.Add(txtBoxContraseñaUsuario);
            Controls.Add(btnLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxNombreUsuario;
        private TextBox txtBoxContraseñaUsuario;
        private Button btnLogin;
        private Button btnAdmin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
    }
}