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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxNombreAlta = new TextBox();
            numericUpDownAlta = new NumericUpDown();
            txtBoxPrecioAlta = new TextBox();
            btnAlta = new Button();
            numericUpDownId = new NumericUpDown();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 96);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 191);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad del producto";
            // 
            // txtBoxNombreAlta
            // 
            txtBoxNombreAlta.Location = new Point(138, 44);
            txtBoxNombreAlta.Name = "txtBoxNombreAlta";
            txtBoxNombreAlta.Size = new Size(145, 23);
            txtBoxNombreAlta.TabIndex = 3;
            // 
            // numericUpDownAlta
            // 
            numericUpDownAlta.Location = new Point(138, 237);
            numericUpDownAlta.Name = "numericUpDownAlta";
            numericUpDownAlta.Size = new Size(145, 23);
            numericUpDownAlta.TabIndex = 5;
            // 
            // txtBoxPrecioAlta
            // 
            txtBoxPrecioAlta.Location = new Point(138, 136);
            txtBoxPrecioAlta.Name = "txtBoxPrecioAlta";
            txtBoxPrecioAlta.Size = new Size(145, 23);
            txtBoxPrecioAlta.TabIndex = 4;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.DarkOrange;
            btnAlta.Cursor = Cursors.Hand;
            btnAlta.FlatAppearance.MouseDownBackColor = Color.Red;
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.ForeColor = Color.Cornsilk;
            btnAlta.Location = new Point(138, 528);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(145, 30);
            btnAlta.TabIndex = 6;
            btnAlta.Text = "Dar de alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(138, 306);
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(145, 23);
            numericUpDownId.TabIndex = 7;
            numericUpDownId.ValueChanged += numericUpDownId_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 288);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 8;
            label4.Text = "ID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "perro", "gato" });
            comboBox1.Location = new Point(29, 366);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Tipo";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "cincoKilos", "diezKilos" });
            comboBox2.Location = new Point(138, 437);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 23);
            comboBox2.TabIndex = 10;
            comboBox2.Text = "Cantidad";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "cerdo", "vaca", "pollo" });
            comboBox3.Location = new Point(257, 366);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(145, 23);
            comboBox3.TabIndex = 11;
            comboBox3.Text = "Sabor";
            // 
            // FormALta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 600);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDownId);
            Controls.Add(btnAlta);
            Controls.Add(numericUpDownAlta);
            Controls.Add(txtBoxPrecioAlta);
            Controls.Add(txtBoxNombreAlta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormALta";
            Text = "FormALta";
            Load += FormALta_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxNombreAlta;
        private NumericUpDown numericUpDownAlta;
        private TextBox txtBoxPrecioAlta;
        private Button btnAlta;
        private NumericUpDown numericUpDownId;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}