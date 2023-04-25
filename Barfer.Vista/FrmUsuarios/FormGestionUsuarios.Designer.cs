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
            btnAltaUsuario = new Button();
            btnBajaUsuario = new Button();
            btnModificacionUsuario = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.Location = new Point(31, 68);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(139, 46);
            btnAltaUsuario.TabIndex = 0;
            btnAltaUsuario.Text = "Dar de alta usuario";
            btnAltaUsuario.UseVisualStyleBackColor = true;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.Location = new Point(31, 238);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(139, 47);
            btnBajaUsuario.TabIndex = 1;
            btnBajaUsuario.Text = "Dar de baja usuario";
            btnBajaUsuario.UseVisualStyleBackColor = true;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // btnModificacionUsuario
            // 
            btnModificacionUsuario.Location = new Point(31, 435);
            btnModificacionUsuario.Name = "btnModificacionUsuario";
            btnModificacionUsuario.Size = new Size(139, 47);
            btnModificacionUsuario.TabIndex = 2;
            btnModificacionUsuario.Text = "Modificar usuario";
            btnModificacionUsuario.UseVisualStyleBackColor = true;
            btnModificacionUsuario.Click += btnModificacionUsuario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(291, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(571, 370);
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
            panel1.Controls.Add(btnAltaUsuario);
            panel1.Controls.Add(btnBajaUsuario);
            panel1.Controls.Add(btnModificacionUsuario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 536);
            panel1.TabIndex = 5;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAltaUsuario;
        private Button button2;
        private Button btnModificacionUsuario;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnBajaUsuario;
        private Panel panel1;
    }
}