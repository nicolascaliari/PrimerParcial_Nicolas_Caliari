namespace Barfer.Vista.Ventas
{
    partial class FormGestorVentas
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
            dataGridView1 = new DataGridView();
            btnPreparacion = new Button();
            btnBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(155, 26);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 1;
            label1.Text = "Gestor de ventas";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1508, 536);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // btnPreparacion
            // 
            btnPreparacion.Location = new Point(672, 737);
            btnPreparacion.Name = "btnPreparacion";
            btnPreparacion.Size = new Size(196, 49);
            btnPreparacion.TabIndex = 3;
            btnPreparacion.Text = "Enviar a preparacion";
            btnPreparacion.UseVisualStyleBackColor = true;
            btnPreparacion.Click += btnPreparacion_Click;
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(12, 830);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 51);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 4;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormGestorVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1568, 893);
            Controls.Add(btnBack);
            Controls.Add(btnPreparacion);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FormGestorVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGestorVentas";
            Load += FormGestorVentas_Load;
            Paint += FormGestorVentas_Paint;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnPreparacion;
        private PictureBox btnBack;
    }
}