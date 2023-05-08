namespace Vistas
{
    partial class FormGestionUsuarios
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            btnBack = new PictureBox();
            btnEditarUsuario = new PictureBox();
            btnAltaUsuario = new PictureBox();
            btnBajaUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditarUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAltaUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBajaUsuario).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.SteelBlue;
            dataGridView1.Location = new Point(335, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(972, 576);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(674, 37);
            label1.Name = "label1";
            label1.Size = new Size(359, 40);
            label1.TabIndex = 4;
            label1.Text = "Gestion de usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnEditarUsuario);
            panel1.Controls.Add(btnAltaUsuario);
            panel1.Controls.Add(btnBajaUsuario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 787);
            panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Image = Barfer.Vista.Properties.Resources.back;
            btnBack.Location = new Point(12, 725);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 50);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 6;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Image = Barfer.Vista.Properties.Resources.editarUsuario;
            btnEditarUsuario.Location = new Point(65, 565);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(108, 78);
            btnEditarUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnEditarUsuario.TabIndex = 7;
            btnEditarUsuario.TabStop = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.Image = Barfer.Vista.Properties.Resources.personaAgregar;
            btnAltaUsuario.Location = new Point(65, 91);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(108, 76);
            btnAltaUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnAltaUsuario.TabIndex = 6;
            btnAltaUsuario.TabStop = false;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.Image = Barfer.Vista.Properties.Resources.basura;
            btnBajaUsuario.Location = new Point(65, 330);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(108, 77);
            btnBajaUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnBajaUsuario.TabIndex = 6;
            btnBajaUsuario.TabStop = false;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1395, 787);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGestionUsuarios";
            Load += FormGestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditarUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAltaUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBajaUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private PictureBox btnBajaUsuario;
        private PictureBox btnAltaUsuario;
        private PictureBox btnEditarUsuario;
        private PictureBox btnBack;
    }
}