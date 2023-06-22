namespace Vistas
{
    partial class FormStock
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGrid = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            btnBack = new PictureBox();
            btnBajaProducto = new PictureBox();
            btnEditarProducto = new PictureBox();
            btnAltaProducto = new PictureBox();
            lblTotalStock = new Label();
            txtBoxBuscar = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBajaProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAltaProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeight = 30;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = Color.SteelBlue;
            dataGrid.Location = new Point(367, 165);
            dataGrid.Margin = new Padding(3, 4, 3, 4);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGrid.RowTemplate.Height = 25;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(1144, 787);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(321, 12);
            label1.Name = "label1";
            label1.Size = new Size(708, 50);
            label1.TabIndex = 1;
            label1.Text = "Listado de productos en stock";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnBajaProducto);
            panel1.Controls.Add(btnEditarProducto);
            panel1.Controls.Add(btnAltaProducto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 1049);
            panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Image = Barfer.Vista.Properties.Resources.back;
            btnBack.Location = new Point(14, 968);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 65);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 7;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnBajaProducto
            // 
            btnBajaProducto.Image = Barfer.Vista.Properties.Resources.basura;
            btnBajaProducto.Location = new Point(79, 415);
            btnBajaProducto.Margin = new Padding(3, 4, 3, 4);
            btnBajaProducto.Name = "btnBajaProducto";
            btnBajaProducto.Size = new Size(149, 103);
            btnBajaProducto.SizeMode = PictureBoxSizeMode.Zoom;
            btnBajaProducto.TabIndex = 7;
            btnBajaProducto.TabStop = false;
            btnBajaProducto.Click += btnBajaProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Image = Barfer.Vista.Properties.Resources.editarProducto;
            btnEditarProducto.Location = new Point(79, 737);
            btnEditarProducto.Margin = new Padding(3, 4, 3, 4);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(149, 103);
            btnEditarProducto.SizeMode = PictureBoxSizeMode.Zoom;
            btnEditarProducto.TabIndex = 6;
            btnEditarProducto.TabStop = false;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnAltaProducto
            // 
            btnAltaProducto.Image = Barfer.Vista.Properties.Resources.AgregarProducto;
            btnAltaProducto.Location = new Point(79, 95);
            btnAltaProducto.Margin = new Padding(3, 4, 3, 4);
            btnAltaProducto.Name = "btnAltaProducto";
            btnAltaProducto.Size = new Size(149, 103);
            btnAltaProducto.SizeMode = PictureBoxSizeMode.Zoom;
            btnAltaProducto.TabIndex = 5;
            btnAltaProducto.TabStop = false;
            btnAltaProducto.Click += btnAltaProducto_Click;
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalStock.ForeColor = SystemColors.ButtonFace;
            lblTotalStock.Location = new Point(423, 991);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(108, 30);
            lblTotalStock.TabIndex = 6;
            lblTotalStock.Text = "Total : ";
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(672, 116);
            txtBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBoxBuscar.Multiline = true;
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Buscar...";
            txtBoxBuscar.Size = new Size(406, 40);
            txtBoxBuscar.TabIndex = 7;
            txtBoxBuscar.TextChanged += txtBoxBuscar_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = Barfer.Vista.Properties.Resources.search;
            pictureBox1.Location = new Point(1047, 123);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1594, 1049);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxBuscar);
            Controls.Add(lblTotalStock);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(200, 200);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormStock";
            Load += FormStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBajaProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAltaProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private Label label1;
        private Button btnBaja;
        private Button button2;
        private Panel panel1;
        private PictureBox btnBajaProducto;
        private PictureBox btnEditarProducto;
        private PictureBox btnAltaProducto;
        private Label lblTotalStock;
        private PictureBox btnBack;
        private TextBox txtBoxBuscar;
        private PictureBox pictureBox1;
    }
}