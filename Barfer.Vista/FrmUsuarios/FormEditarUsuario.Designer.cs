namespace Vistas.FrmUsuarios
{
    partial class FormEditarUsuario
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
            btnEditarUsuario = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxEditarNombre = new TextBox();
            txtBoxEditarApellido = new TextBox();
            txtBoxEditarContrasenia = new TextBox();
            txtBoxEditarEdad = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.FromArgb(40, 40, 40);
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnEditarUsuario.ForeColor = SystemColors.ButtonFace;
            btnEditarUsuario.Location = new Point(157, 597);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(184, 45);
            btnEditarUsuario.TabIndex = 0;
            btnEditarUsuario.Text = "Editar usuario";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(192, 75);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(190, 159);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(187, 269);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(203, 378);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 4;
            label4.Text = "Edad usuario";
            // 
            // txtBoxEditarNombre
            // 
            txtBoxEditarNombre.Location = new Point(115, 113);
            txtBoxEditarNombre.Name = "txtBoxEditarNombre";
            txtBoxEditarNombre.Size = new Size(269, 23);
            txtBoxEditarNombre.TabIndex = 5;
            // 
            // txtBoxEditarApellido
            // 
            txtBoxEditarApellido.Location = new Point(115, 216);
            txtBoxEditarApellido.Name = "txtBoxEditarApellido";
            txtBoxEditarApellido.Size = new Size(269, 23);
            txtBoxEditarApellido.TabIndex = 6;
            // 
            // txtBoxEditarContrasenia
            // 
            txtBoxEditarContrasenia.Location = new Point(115, 326);
            txtBoxEditarContrasenia.Name = "txtBoxEditarContrasenia";
            txtBoxEditarContrasenia.Size = new Size(269, 23);
            txtBoxEditarContrasenia.TabIndex = 7;
            // 
            // txtBoxEditarEdad
            // 
            txtBoxEditarEdad.Location = new Point(115, 440);
            txtBoxEditarEdad.Name = "txtBoxEditarEdad";
            txtBoxEditarEdad.Size = new Size(269, 23);
            txtBoxEditarEdad.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(175, 9);
            label5.Name = "label5";
            label5.Size = new Size(166, 23);
            label5.TabIndex = 9;
            label5.Text = "Editar usuario";
            // 
            // FormEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(481, 654);
            Controls.Add(label5);
            Controls.Add(txtBoxEditarEdad);
            Controls.Add(txtBoxEditarContrasenia);
            Controls.Add(txtBoxEditarApellido);
            Controls.Add(txtBoxEditarNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEditarUsuario);
            Name = "FormEditarUsuario";
            Text = " ";
            Load += FormEditarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditarUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxEditarNombre;
        private TextBox txtBoxEditarApellido;
        private TextBox txtBoxEditarContrasenia;
        private TextBox txtBoxEditarEdad;
        private Label label5;
    }
}