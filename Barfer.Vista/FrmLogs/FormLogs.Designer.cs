namespace Barfer.Vista.FrmLogs
{
    partial class FormLogs
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
            dgvLogs = new DataGridView();
            txtBoxBuscar = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(126, 135);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.RowTemplate.Height = 29;
            dgvLogs.Size = new Size(974, 656);
            dgvLogs.TabIndex = 0;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(345, 53);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.Size = new Size(560, 27);
            txtBoxBuscar.TabIndex = 1;
            txtBoxBuscar.TextChanged += txtBoxBuscar_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(861, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1231, 821);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxBuscar);
            Controls.Add(dgvLogs);
            Name = "FormLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogs";
            FormClosing += FormLogs_FormClosing;
            Load += FormLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLogs;
        private TextBox txtBoxBuscar;
        private PictureBox pictureBox1;
    }
}