namespace Vistas
{
    partial class FormCalculadora
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
            cmbMascota = new ComboBox();
            txtPeso = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            txtBoxEdad = new TextBox();
            txtBoxNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 0;
            label1.Text = "Calculadora";
            // 
            // cmbMascota
            // 
            cmbMascota.BackColor = Color.FromArgb(26, 32, 40);
            cmbMascota.FlatStyle = FlatStyle.Flat;
            cmbMascota.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMascota.ForeColor = SystemColors.Info;
            cmbMascota.FormattingEnabled = true;
            cmbMascota.Location = new Point(34, 114);
            cmbMascota.Name = "cmbMascota";
            cmbMascota.Size = new Size(263, 28);
            cmbMascota.TabIndex = 1;
            cmbMascota.Text = "mascota";
            cmbMascota.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.FromArgb(26, 32, 40);
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPeso.ForeColor = SystemColors.Info;
            txtPeso.Location = new Point(34, 243);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Ingrese el peso de su mascota";
            txtPeso.Size = new Size(263, 27);
            txtPeso.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.FromArgb(26, 32, 40);
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.ForeColor = SystemColors.Info;
            txtResultado.Location = new Point(34, 331);
            txtResultado.Name = "txtResultado";
            txtResultado.PlaceholderText = "Resultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(263, 27);
            txtResultado.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(40, 40, 40);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.ForeColor = SystemColors.ButtonFace;
            btnCalcular.Location = new Point(64, 382);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(182, 40);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtBoxEdad
            // 
            txtBoxEdad.BackColor = Color.FromArgb(26, 32, 40);
            txtBoxEdad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEdad.ForeColor = SystemColors.Info;
            txtBoxEdad.Location = new Point(34, 184);
            txtBoxEdad.Name = "txtBoxEdad";
            txtBoxEdad.PlaceholderText = "Edad";
            txtBoxEdad.Size = new Size(263, 27);
            txtBoxEdad.TabIndex = 6;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.BackColor = Color.FromArgb(26, 32, 40);
            txtBoxNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxNombre.ForeColor = SystemColors.Info;
            txtBoxNombre.Location = new Point(34, 52);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre de tu mascota";
            txtBoxNombre.Size = new Size(263, 27);
            txtBoxNombre.TabIndex = 7;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(320, 434);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxEdad);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtPeso);
            Controls.Add(cmbMascota);
            Controls.Add(label1);
            Name = "FormCalculadora";
            Text = "FormCalculadora";
            Load += FormCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMascota;
        private TextBox txtPeso;
        private TextBox txtResultado;
        private Button btnCalcular;
        private TextBox txtBoxEdad;
        private TextBox txtBoxNombre;
    }
}