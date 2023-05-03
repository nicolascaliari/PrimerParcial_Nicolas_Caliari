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
            btnEditarUsuario = new PictureBox();
            btnAltaUsuario = new PictureBox();
            btnBajaUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnEditarUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAltaUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBajaUsuario).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(291, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(633, 370);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(402, 37);
            label1.Name = "label1";
            label1.Size = new Size(359, 40);
            label1.TabIndex = 4;
            label1.Text = "Gestion de usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(btnEditarUsuario);
            panel1.Controls.Add(btnAltaUsuario);
            panel1.Controls.Add(btnBajaUsuario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 536);
            panel1.TabIndex = 5;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Image = Barfer.Vista.Properties.Resources.editarUsuario;
            btnEditarUsuario.Location = new Point(65, 435);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(94, 60);
            btnEditarUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnEditarUsuario.TabIndex = 7;
            btnEditarUsuario.TabStop = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.Image = Barfer.Vista.Properties.Resources.personaAgregar;
            btnAltaUsuario.Location = new Point(65, 37);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(94, 60);
            btnAltaUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnAltaUsuario.TabIndex = 6;
            btnAltaUsuario.TabStop = false;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.Image = Barfer.Vista.Properties.Resources.basura;
            btnBajaUsuario.Location = new Point(65, 234);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(94, 60);
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
            ClientSize = new Size(936, 536);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormGestionUsuarios";
            Text = "FormGestionUsuarios";
            Load += FormGestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
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
    }
}