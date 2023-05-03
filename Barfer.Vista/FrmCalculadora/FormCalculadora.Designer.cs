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
            btnCalcular = new Button();
            txtBoxEdad = new TextBox();
            txtBoxNombre = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btnAbrir = new Button();
            btnGuardar = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // txtPeso
            // 
            txtPeso.BackColor = Color.FromArgb(26, 32, 40);
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPeso.ForeColor = SystemColors.Info;
            txtPeso.Location = new Point(34, 312);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Ingrese el peso de su mascota";
            txtPeso.Size = new Size(263, 27);
            txtPeso.TabIndex = 3;
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
            txtBoxEdad.Location = new Point(34, 217);
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(384, 52);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(111, 26);
            btnAbrir.TabIndex = 8;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(550, 53);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 27);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(384, 105);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(277, 253);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Location = new Point(384, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(705, 503);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(btnGuardar);
            Controls.Add(btnAbrir);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxEdad);
            Controls.Add(btnCalcular);
            Controls.Add(txtPeso);
            Controls.Add(cmbMascota);
            Controls.Add(label1);
            Name = "FormCalculadora";
            Text = "FormCalculadora";
            Load += FormCalculadora_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMascota;
        private TextBox txtPeso;
        private Button btnCalcular;
        private TextBox txtBoxEdad;
        private TextBox txtBoxNombre;
        private OpenFileDialog openFileDialog1;
        private Button btnAbrir;
        private Button btnGuardar;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
    }
}