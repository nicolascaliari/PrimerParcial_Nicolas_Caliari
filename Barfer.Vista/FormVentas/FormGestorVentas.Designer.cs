﻿namespace Barfer.Vista.Ventas
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
            btnVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(177, 35);
            label1.Name = "label1";
            label1.Size = new Size(241, 41);
            label1.TabIndex = 1;
            label1.Text = "Gestor de ventas";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 110);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1053, 494);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // btnPreparacion
            // 
            btnPreparacion.BackColor = Color.FromArgb(40, 40, 40);
            btnPreparacion.FlatAppearance.BorderSize = 0;
            btnPreparacion.FlatStyle = FlatStyle.Flat;
            btnPreparacion.ForeColor = SystemColors.ButtonFace;
            btnPreparacion.Location = new Point(1153, 110);
            btnPreparacion.Margin = new Padding(3, 4, 3, 4);
            btnPreparacion.Name = "btnPreparacion";
            btnPreparacion.Size = new Size(224, 65);
            btnPreparacion.TabIndex = 3;
            btnPreparacion.Text = "Enviar a preparacion";
            btnPreparacion.UseVisualStyleBackColor = false;
            btnPreparacion.Click += btnPreparacion_Click;
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(14, 1107);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 68);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 4;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnVolver
            // 
            btnVolver.Image = Properties.Resources.back;
            btnVolver.Location = new Point(1350, 583);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(60, 47);
            btnVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolver.TabIndex = 5;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormGestorVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1422, 642);
            Controls.Add(btnVolver);
            Controls.Add(btnBack);
            Controls.Add(btnPreparacion);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestorVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGestorVentas";
            Load += FormGestorVentas_Load;
            Paint += FormGestorVentas_Paint;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnPreparacion;
        private PictureBox btnBack;
        private PictureBox btnVolver;
    }
}