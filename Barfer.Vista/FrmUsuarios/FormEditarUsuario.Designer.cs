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
            SuspendLayout();
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Location = new Point(142, 545);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(105, 23);
            btnEditarUsuario.TabIndex = 0;
            btnEditarUsuario.Text = "Editar usuario";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 155);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 290);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 425);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 4;
            label4.Text = "Edad usuario";
            // 
            // txtBoxEditarNombre
            // 
            txtBoxEditarNombre.Location = new Point(147, 67);
            txtBoxEditarNombre.Name = "txtBoxEditarNombre";
            txtBoxEditarNombre.Size = new Size(136, 23);
            txtBoxEditarNombre.TabIndex = 5;
            // 
            // txtBoxEditarApellido
            // 
            txtBoxEditarApellido.Location = new Point(147, 235);
            txtBoxEditarApellido.Name = "txtBoxEditarApellido";
            txtBoxEditarApellido.Size = new Size(136, 23);
            txtBoxEditarApellido.TabIndex = 6;
            // 
            // txtBoxEditarContrasenia
            // 
            txtBoxEditarContrasenia.Location = new Point(147, 364);
            txtBoxEditarContrasenia.Name = "txtBoxEditarContrasenia";
            txtBoxEditarContrasenia.Size = new Size(136, 23);
            txtBoxEditarContrasenia.TabIndex = 7;
            // 
            // txtBoxEditarEdad
            // 
            txtBoxEditarEdad.Location = new Point(147, 475);
            txtBoxEditarEdad.Name = "txtBoxEditarEdad";
            txtBoxEditarEdad.Size = new Size(136, 23);
            txtBoxEditarEdad.TabIndex = 8;
            // 
            // FormEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 580);
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
            Text = "FormEditarUsuario";
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
    }
}