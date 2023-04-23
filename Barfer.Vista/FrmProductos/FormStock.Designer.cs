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
            dataGrid = new DataGridView();
            label1 = new Label();
            btnAltaStock = new Button();
            btnBaja = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(204, 145);
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(633, 446);
            dataGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(414, 41);
            label1.Name = "label1";
            label1.Size = new Size(340, 31);
            label1.TabIndex = 1;
            label1.Text = "Listado de productos en stock";
            label1.Click += label1_Click;
            // 
            // btnAltaStock
            // 
            btnAltaStock.Location = new Point(13, 110);
            btnAltaStock.Name = "btnAltaStock";
            btnAltaStock.Size = new Size(171, 43);
            btnAltaStock.TabIndex = 2;
            btnAltaStock.Text = "Alta de producto";
            btnAltaStock.UseVisualStyleBackColor = true;
            btnAltaStock.Click += btnAltaStock_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(13, 318);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(171, 45);
            btnBaja.TabIndex = 3;
            btnBaja.Text = "Baja de producto";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // button2
            // 
            button2.Location = new Point(13, 513);
            button2.Name = "button2";
            button2.Size = new Size(170, 48);
            button2.TabIndex = 4;
            button2.Text = "Modificacion de producto";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 624);
            Controls.Add(button2);
            Controls.Add(btnBaja);
            Controls.Add(btnAltaStock);
            Controls.Add(label1);
            Controls.Add(dataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(200, 200);
            Name = "FormStock";
            StartPosition = FormStartPosition.Manual;
            Text = "FormStock";
            Load += FormStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private Label label1;
        private Button btnAltaStock;
        private Button btnBaja;
        private Button button2;
    }
}