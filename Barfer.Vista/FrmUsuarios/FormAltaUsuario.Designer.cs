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
            numericUpDownIdUsuario = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            numericUpDownAltaEdad = new NumericUpDown();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAltaEdad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(116, 63);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(143, 240);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese contraaseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(145, 147);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingrese Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(135, 502);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingrese tipo de usuario";
            // 
            // txtBoxAltaNombre
            // 
            txtBoxAltaNombre.Location = new Point(89, 112);
            txtBoxAltaNombre.Name = "txtBoxAltaNombre";
            txtBoxAltaNombre.PlaceholderText = "Nombre";
            txtBoxAltaNombre.Size = new Size(248, 23);
            txtBoxAltaNombre.TabIndex = 4;
            // 
            // txtBoxAltaApellido
            // 
            txtBoxAltaApellido.Location = new Point(89, 193);
            txtBoxAltaApellido.Name = "txtBoxAltaApellido";
            txtBoxAltaApellido.PlaceholderText = "Apellido";
            txtBoxAltaApellido.Size = new Size(248, 23);
            txtBoxAltaApellido.TabIndex = 5;
            // 
            // txtBoxAltaPassword
            // 
            txtBoxAltaPassword.Location = new Point(89, 286);
            txtBoxAltaPassword.Name = "txtBoxAltaPassword";
            txtBoxAltaPassword.PlaceholderText = "Contraseña";
            txtBoxAltaPassword.Size = new Size(248, 23);
            txtBoxAltaPassword.TabIndex = 6;
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.BackColor = Color.FromArgb(40, 40, 40);
            btnAltaUsuario.FlatAppearance.BorderSize = 0;
            btnAltaUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAltaUsuario.FlatStyle = FlatStyle.Flat;
            btnAltaUsuario.ForeColor = SystemColors.ButtonFace;
            btnAltaUsuario.Location = new Point(112, 601);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(204, 38);
            btnAltaUsuario.TabIndex = 8;
            btnAltaUsuario.Text = "Dar de alta";
            btnAltaUsuario.UseVisualStyleBackColor = false;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // comboBoxAltaTipo
            // 
            comboBoxAltaTipo.FormattingEnabled = true;
            comboBoxAltaTipo.Items.AddRange(new object[] { "administrador", "empleado" });
            comboBoxAltaTipo.Location = new Point(89, 540);
            comboBoxAltaTipo.Name = "comboBoxAltaTipo";
            comboBoxAltaTipo.Size = new Size(248, 23);
            comboBoxAltaTipo.TabIndex = 9;
            comboBoxAltaTipo.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(186, 331);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 10;
            label5.Text = "Edad";
            // 
            // numericUpDownIdUsuario
            // 
            numericUpDownIdUsuario.Location = new Point(89, 459);
            numericUpDownIdUsuario.Name = "numericUpDownIdUsuario";
            numericUpDownIdUsuario.Size = new Size(248, 23);
            numericUpDownIdUsuario.TabIndex = 12;
            numericUpDownIdUsuario.ValueChanged += numericUpDownIdUsuario_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(154, 9);
            label6.Name = "label6";
            label6.Size = new Size(143, 23);
            label6.TabIndex = 13;
            label6.Text = "Alta usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(200, 424);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 14;
            label7.Text = "ID";
            // 
            // numericUpDownAltaEdad
            // 
            numericUpDownAltaEdad.Location = new Point(89, 379);
            numericUpDownAltaEdad.Name = "numericUpDownAltaEdad";
            numericUpDownAltaEdad.Size = new Size(248, 23);
            numericUpDownAltaEdad.TabIndex = 15;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(145, 578);
            lblError.Name = "lblError";
            lblError.Size = new Size(146, 20);
            lblError.TabIndex = 16;
            lblError.Text = "Error al crear usuario";
            // 
            // FormAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(435, 653);
            Controls.Add(lblError);
            Controls.Add(numericUpDownAltaEdad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numericUpDownIdUsuario);
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
            Load += FormAltaUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAltaEdad).EndInit();
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
        private NumericUpDown numericUpDownIdUsuario;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownAltaEdad;
        private Label lblError;
    }
}