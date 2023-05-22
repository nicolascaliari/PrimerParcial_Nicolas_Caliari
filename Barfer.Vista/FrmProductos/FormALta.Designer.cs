namespace Vistas
{
    partial class FormALta
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxNombreAlta = new TextBox();
            numericUpDownCantidad = new NumericUpDown();
            btnAlta = new Button();
            cboTipos = new ComboBox();
            cboCantidades = new ComboBox();
            cboSabores = new ComboBox();
            label5 = new Label();
            numericPrecioAlta = new NumericUpDown();
            lblError = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecioAlta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(155, 67);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(165, 140);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 1;
            label2.Text = "Precio del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(157, 248);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad del producto";
            // 
            // txtBoxNombreAlta
            // 
            txtBoxNombreAlta.Location = new Point(123, 101);
            txtBoxNombreAlta.Name = "txtBoxNombreAlta";
            txtBoxNombreAlta.PlaceholderText = "Nombre";
            txtBoxNombreAlta.Size = new Size(226, 23);
            txtBoxNombreAlta.TabIndex = 3;
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(123, 291);
            numericUpDownCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(226, 23);
            numericUpDownCantidad.TabIndex = 5;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.FromArgb(40, 40, 40);
            btnAlta.Cursor = Cursors.Hand;
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.ForeColor = Color.Cornsilk;
            btnAlta.Location = new Point(123, 617);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(217, 38);
            btnAlta.TabIndex = 6;
            btnAlta.Text = "Dar de alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // cboTipos
            // 
            cboTipos.FormattingEnabled = true;
            cboTipos.Items.AddRange(new object[] { "perro", "gato", "complemento" });
            cboTipos.Location = new Point(123, 386);
            cboTipos.Name = "cboTipos";
            cboTipos.Size = new Size(226, 23);
            cboTipos.TabIndex = 9;
            cboTipos.Text = "Tipo";
            cboTipos.Validating += cboTipos_Validating;
            // 
            // cboCantidades
            // 
            cboCantidades.FormattingEnabled = true;
            cboCantidades.Items.AddRange(new object[] { " cincoKilos", "diezKilos" });
            cboCantidades.Location = new Point(123, 542);
            cboCantidades.Name = "cboCantidades";
            cboCantidades.Size = new Size(226, 23);
            cboCantidades.TabIndex = 10;
            cboCantidades.Text = "Cantidad";
            cboCantidades.Validating += cboCantidades_Validating;
            // 
            // cboSabores
            // 
            cboSabores.FormattingEnabled = true;
            cboSabores.Items.AddRange(new object[] { "cerdo", "vaca", "pollo", "cornalitos", "sardinas" });
            cboSabores.Location = new Point(123, 466);
            cboSabores.Name = "cboSabores";
            cboSabores.Size = new Size(226, 23);
            cboSabores.TabIndex = 11;
            cboSabores.Text = "Sabor";
            cboSabores.Validating += cboSabores_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(157, 9);
            label5.Name = "label5";
            label5.Size = new Size(166, 23);
            label5.TabIndex = 12;
            label5.Text = "Alta prodcuto";
            // 
            // numericPrecioAlta
            // 
            numericPrecioAlta.Location = new Point(123, 192);
            numericPrecioAlta.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericPrecioAlta.Name = "numericPrecioAlta";
            numericPrecioAlta.Size = new Size(226, 23);
            numericPrecioAlta.TabIndex = 13;
            numericPrecioAlta.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(59, 582);
            lblError.Name = "lblError";
            lblError.Size = new Size(133, 20);
            lblError.TabIndex = 14;
            lblError.Text = "Error al dar de alta";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormALta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(496, 678);
            Controls.Add(lblError);
            Controls.Add(numericPrecioAlta);
            Controls.Add(label5);
            Controls.Add(cboSabores);
            Controls.Add(cboCantidades);
            Controls.Add(cboTipos);
            Controls.Add(btnAlta);
            Controls.Add(numericUpDownCantidad);
            Controls.Add(txtBoxNombreAlta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormALta";
            Text = "FormALta";
            Load += FormALta_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecioAlta).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxNombreAlta;
        private NumericUpDown numericUpDownCantidad;
        private Button btnAlta;
        private ComboBox cboTipos;
        private ComboBox cboCantidades;
        private ComboBox cboSabores;
        private Label label5;
        private NumericUpDown numericPrecioAlta;
        private Label lblError;
        private ErrorProvider errorProvider1;
    }
}