namespace Barfer.Vista.FrmProductos
{
    partial class FormEditarAlimento
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
            txtBoxNombre = new TextBox();
            txtBoxPrecio = new TextBox();
            txtBoxCantidad = new TextBox();
            cboSabor = new ComboBox();
            cboTipo = new ComboBox();
            cboCantidad = new ComboBox();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 0;
            label1.Text = "Editar alimento";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(118, 78);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre";
            txtBoxNombre.Size = new Size(341, 23);
            txtBoxNombre.TabIndex = 1;
            // 
            // txtBoxPrecio
            // 
            txtBoxPrecio.Location = new Point(118, 167);
            txtBoxPrecio.Name = "txtBoxPrecio";
            txtBoxPrecio.PlaceholderText = "Precio";
            txtBoxPrecio.Size = new Size(341, 23);
            txtBoxPrecio.TabIndex = 2;
            // 
            // txtBoxCantidad
            // 
            txtBoxCantidad.Location = new Point(118, 259);
            txtBoxCantidad.Name = "txtBoxCantidad";
            txtBoxCantidad.PlaceholderText = "Cantidad";
            txtBoxCantidad.Size = new Size(341, 23);
            txtBoxCantidad.TabIndex = 3;
            // 
            // cboSabor
            // 
            cboSabor.FormattingEnabled = true;
            cboSabor.Location = new Point(118, 353);
            cboSabor.Name = "cboSabor";
            cboSabor.Size = new Size(341, 23);
            cboSabor.TabIndex = 4;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(118, 527);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(341, 23);
            cboTipo.TabIndex = 5;
            // 
            // cboCantidad
            // 
            cboCantidad.FormattingEnabled = true;
            cboCantidad.Location = new Point(118, 447);
            cboCantidad.Name = "cboCantidad";
            cboCantidad.Size = new Size(341, 23);
            cboCantidad.TabIndex = 6;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(201, 627);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(178, 43);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormEditarAlimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(583, 692);
            Controls.Add(btnEditar);
            Controls.Add(cboCantidad);
            Controls.Add(cboTipo);
            Controls.Add(cboSabor);
            Controls.Add(txtBoxCantidad);
            Controls.Add(txtBoxPrecio);
            Controls.Add(txtBoxNombre);
            Controls.Add(label1);
            Name = "FormEditarAlimento";
            Text = "FormEditarAlimento";
            Load += FormEditarAlimento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxNombre;
        private TextBox txtBoxPrecio;
        private TextBox txtBoxCantidad;
        private ComboBox cboSabor;
        private ComboBox cboTipo;
        private ComboBox cboCantidad;
        private Button btnEditar;
    }
}