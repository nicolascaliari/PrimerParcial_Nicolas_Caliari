namespace Vistas.FrmUsuarios
{
    partial class FormAltaUsuario
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
            label3 = new Label();
            label4 = new Label();
            txtBoxAltaNombre = new TextBox();
            txtBoxAltaApellido = new TextBox();
            txtBoxAltaPassword = new TextBox();
            btnAltaUsuario = new Button();
            comboBoxAltaTipo = new ComboBox();
            label5 = new Label();
            txtBoxAltaEdad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 18);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 191);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese contraaseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 100);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingrese Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 391);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 3;
            label4.Text = "Ingrese tipo de usuario";
            // 
            // txtBoxAltaNombre
            // 
            txtBoxAltaNombre.Location = new Point(112, 57);
            txtBoxAltaNombre.Name = "txtBoxAltaNombre";
            txtBoxAltaNombre.PlaceholderText = "Nombre";
            txtBoxAltaNombre.Size = new Size(148, 23);
            txtBoxAltaNombre.TabIndex = 4;
            // 
            // txtBoxAltaApellido
            // 
            txtBoxAltaApellido.Location = new Point(112, 139);
            txtBoxAltaApellido.Name = "txtBoxAltaApellido";
            txtBoxAltaApellido.PlaceholderText = "Apellido";
            txtBoxAltaApellido.Size = new Size(148, 23);
            txtBoxAltaApellido.TabIndex = 5;
            // 
            // txtBoxAltaPassword
            // 
            txtBoxAltaPassword.Location = new Point(112, 232);
            txtBoxAltaPassword.Name = "txtBoxAltaPassword";
            txtBoxAltaPassword.PlaceholderText = "Contraseña";
            txtBoxAltaPassword.Size = new Size(148, 23);
            txtBoxAltaPassword.TabIndex = 6;
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.Location = new Point(112, 543);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(148, 27);
            btnAltaUsuario.TabIndex = 8;
            btnAltaUsuario.Text = "Dar de alta";
            btnAltaUsuario.UseVisualStyleBackColor = true;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // comboBoxAltaTipo
            // 
            comboBoxAltaTipo.FormattingEnabled = true;
            comboBoxAltaTipo.Items.AddRange(new object[] { "administrador", "empleado" });
            comboBoxAltaTipo.Location = new Point(112, 442);
            comboBoxAltaTipo.Name = "comboBoxAltaTipo";
            comboBoxAltaTipo.Size = new Size(121, 23);
            comboBoxAltaTipo.TabIndex = 9;
            comboBoxAltaTipo.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 279);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Edad";
            // 
            // txtBoxAltaEdad
            // 
            txtBoxAltaEdad.Location = new Point(112, 319);
            txtBoxAltaEdad.Name = "txtBoxAltaEdad";
            txtBoxAltaEdad.Size = new Size(148, 23);
            txtBoxAltaEdad.TabIndex = 11;
            // 
            // FormAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 582);
            Controls.Add(txtBoxAltaEdad);
            Controls.Add(label5);
            Controls.Add(comboBoxAltaTipo);
            Controls.Add(btnAltaUsuario);
            Controls.Add(txtBoxAltaPassword);
            Controls.Add(txtBoxAltaApellido);
            Controls.Add(txtBoxAltaNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAltaUsuario";
            Text = "FormAltaUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxAltaNombre;
        private TextBox txtBoxAltaApellido;
        private TextBox txtBoxAltaPassword;
        private Button btnAltaUsuario;
        private ComboBox comboBoxAltaTipo;
        private Label label5;
        private TextBox txtBoxAltaEdad;
    }
}