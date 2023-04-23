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
            groupBox1 = new GroupBox();
            btnAdmin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 89);
            label1.Name = "label1";
            label1.Size = new Size(183, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(75, 205);
            label2.Name = "label2";
            label2.Size = new Size(119, 26);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtBoxNombreUsuario
            // 
            txtBoxNombreUsuario.Location = new Point(92, 145);
            txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            txtBoxNombreUsuario.PlaceholderText = "Nombre de usuario";
            txtBoxNombreUsuario.Size = new Size(166, 23);
            txtBoxNombreUsuario.TabIndex = 2;
            txtBoxNombreUsuario.TextChanged += txtBoxNombreUsuario_TextChanged;
            // 
            // txtBoxContraseñaUsuario
            // 
            txtBoxContraseñaUsuario.Location = new Point(92, 262);
            txtBoxContraseñaUsuario.Name = "txtBoxContraseñaUsuario";
            txtBoxContraseñaUsuario.PlaceholderText = "Contraseña";
            txtBoxContraseñaUsuario.Size = new Size(166, 23);
            txtBoxContraseñaUsuario.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(361, 188);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(btnAdmin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBoxContraseñaUsuario);
            groupBox1.Controls.Add(txtBoxNombreUsuario);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 397);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(20, 368);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(140, 23);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "Ingresar directo";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 426);
            Controls.Add(groupBox1);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxNombreUsuario;
        private TextBox txtBoxContraseñaUsuario;
        private Button btnLogin;
        private GroupBox groupBox1;
        private Button btnAdmin;
    }
}