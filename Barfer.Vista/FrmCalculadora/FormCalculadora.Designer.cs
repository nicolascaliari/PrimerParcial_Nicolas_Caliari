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
            btnCalcular = new Button();
            txtBoxNombre = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btnBack = new PictureBox();
            numericUpDownEdad = new NumericUpDown();
            numericUpDownPeso = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeso).BeginInit();
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
            cmbMascota.Location = new Point(34, 130);
            cmbMascota.Name = "cmbMascota";
            cmbMascota.Size = new Size(263, 28);
            cmbMascota.TabIndex = 1;
            cmbMascota.Text = "mascota";
            cmbMascota.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBack
            // 
            btnBack.Image = Barfer.Vista.Properties.Resources.back;
            btnBack.Location = new Point(12, 459);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(60, 32);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 12;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // numericUpDownEdad
            // 
            numericUpDownEdad.BackColor = Color.FromArgb(26, 32, 40);
            numericUpDownEdad.ForeColor = SystemColors.Info;
            numericUpDownEdad.Location = new Point(34, 234);
            numericUpDownEdad.Name = "numericUpDownEdad";
            numericUpDownEdad.Size = new Size(263, 23);
            numericUpDownEdad.TabIndex = 13;
            // 
            // numericUpDownPeso
            // 
            numericUpDownPeso.BackColor = Color.FromArgb(26, 32, 40);
            numericUpDownPeso.ForeColor = SystemColors.Info;
            numericUpDownPeso.Location = new Point(34, 335);
            numericUpDownPeso.Name = "numericUpDownPeso";
            numericUpDownPeso.Size = new Size(263, 23);
            numericUpDownPeso.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(39, 205);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 15;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(39, 304);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 16;
            label3.Text = "Peso";
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(705, 503);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDownPeso);
            Controls.Add(numericUpDownEdad);
            Controls.Add(btnBack);
            Controls.Add(txtBoxNombre);
            Controls.Add(btnCalcular);
            Controls.Add(cmbMascota);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalculadora";
            Load += FormCalculadora_Load;
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMascota;
        private Button btnCalcular;
        private TextBox txtBoxNombre;
        private OpenFileDialog openFileDialog1;
        private PictureBox btnBack;
        private NumericUpDown numericUpDownEdad;
        private NumericUpDown numericUpDownPeso;
        private Label label2;
        private Label label3;
    }
}