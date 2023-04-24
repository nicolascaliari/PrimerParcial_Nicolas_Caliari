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
            label1 = new Label();
            label2 = new Label();
            txtBoxNombreUsuario = new TextBox();
            txtBoxContraseñaUsuario = new TextBox();
            btnLogin = new Button();
            btnAdmin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(241, 106);
            label1.Name = "label1";
            label1.Size = new Size(183, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(264, 203);
            label2.Name = "label2";
            label2.Size = new Size(119, 26);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtBoxNombreUsuario
            // 
            txtBoxNombreUsuario.Location = new Point(241, 163);
            txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            txtBoxNombreUsuario.PlaceholderText = "Nombre de usuario";
            txtBoxNombreUsuario.Size = new Size(166, 23);
            txtBoxNombreUsuario.TabIndex = 2;
            txtBoxNombreUsuario.TextChanged += txtBoxNombreUsuario_TextChanged;
            // 
            // txtBoxContraseñaUsuario
            // 
            txtBoxContraseñaUsuario.Location = new Point(241, 268);
            txtBoxContraseñaUsuario.Name = "txtBoxContraseñaUsuario";
            txtBoxContraseñaUsuario.PlaceholderText = "Contraseña";
            txtBoxContraseñaUsuario.Size = new Size(166, 23);
            txtBoxContraseñaUsuario.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(282, 349);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(255, 128, 0);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Location = new Point(24, 380);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(140, 34);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "Ingresar directo";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Barfer.Vista.Properties.Resources.LogoAzul;
            pictureBox1.Location = new Point(157, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(657, 426);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdmin);
            Controls.Add(txtBoxContraseñaUsuario);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxNombreUsuario);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxNombreUsuario;
        private TextBox txtBoxContraseñaUsuario;
        private Button btnLogin;
        private Button btnAdmin;
        private PictureBox pictureBox1;
    }
}