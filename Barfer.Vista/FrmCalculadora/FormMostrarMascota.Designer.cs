namespace Barfer.Vista.FrmCalculadora
{
    partial class FormMostrarMascota
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
            txtNombre = new Label();
            txtPeso = new Label();
            txtEdad = new Label();
            txtTipo = new Label();
            txtCantidadComida = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(57, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(49, 15);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "nombre";
            // 
            // txtPeso
            // 
            txtPeso.AutoSize = true;
            txtPeso.Location = new Point(57, 58);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(32, 15);
            txtPeso.TabIndex = 1;
            txtPeso.Text = "peso";
            // 
            // txtEdad
            // 
            txtEdad.AutoSize = true;
            txtEdad.Location = new Point(57, 104);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(33, 15);
            txtEdad.TabIndex = 2;
            txtEdad.Text = "edad";
            // 
            // txtTipo
            // 
            txtTipo.AutoSize = true;
            txtTipo.Location = new Point(57, 144);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(28, 15);
            txtTipo.TabIndex = 3;
            txtTipo.Text = "tipo";
            // 
            // txtCantidadComida
            // 
            txtCantidadComida.AutoSize = true;
            txtCantidadComida.Location = new Point(57, 182);
            txtCantidadComida.Name = "txtCantidadComida";
            txtCantidadComida.Size = new Size(53, 15);
            txtCantidadComida.TabIndex = 4;
            txtCantidadComida.Text = "cantidad";
            // 
            // FormMostrarMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 206);
            Controls.Add(txtCantidadComida);
            Controls.Add(txtTipo);
            Controls.Add(txtEdad);
            Controls.Add(txtPeso);
            Controls.Add(txtNombre);
            Name = "FormMostrarMascota";
            Text = "FormMostrarMascota";
            Load += FormMostrarMascota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNombre;
        private Label txtPeso;
        private Label txtEdad;
        private Label txtTipo;
        private Label txtCantidadComida;
    }
}