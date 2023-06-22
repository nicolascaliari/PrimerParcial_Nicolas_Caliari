namespace Barfer.Vista.FrmInformes
{
    partial class FormInformes
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
            btnDescargarCsv = new Button();
            btnDescargarJson = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(154, 85);
            label1.Name = "label1";
            label1.Size = new Size(419, 37);
            label1.TabIndex = 0;
            label1.Text = "Descargar las ventas generadas";
            // 
            // btnDescargarCsv
            // 
            btnDescargarCsv.BackColor = Color.FromArgb(40, 40, 40);
            btnDescargarCsv.FlatAppearance.BorderSize = 0;
            btnDescargarCsv.FlatStyle = FlatStyle.Flat;
            btnDescargarCsv.ForeColor = SystemColors.ButtonFace;
            btnDescargarCsv.Location = new Point(89, 209);
            btnDescargarCsv.Margin = new Padding(3, 4, 3, 4);
            btnDescargarCsv.Name = "btnDescargarCsv";
            btnDescargarCsv.Size = new Size(123, 53);
            btnDescargarCsv.TabIndex = 1;
            btnDescargarCsv.Text = "CSV";
            btnDescargarCsv.UseVisualStyleBackColor = false;
            btnDescargarCsv.Click += btnDescargarCsv_Click;
            // 
            // btnDescargarJson
            // 
            btnDescargarJson.BackColor = Color.FromArgb(40, 40, 40);
            btnDescargarJson.FlatAppearance.BorderSize = 0;
            btnDescargarJson.FlatStyle = FlatStyle.Flat;
            btnDescargarJson.ForeColor = SystemColors.ButtonFace;
            btnDescargarJson.Location = new Point(456, 209);
            btnDescargarJson.Margin = new Padding(3, 4, 3, 4);
            btnDescargarJson.Name = "btnDescargarJson";
            btnDescargarJson.Size = new Size(123, 53);
            btnDescargarJson.TabIndex = 2;
            btnDescargarJson.Text = "JSON";
            btnDescargarJson.UseVisualStyleBackColor = false;
            btnDescargarJson.Click += btnDescargarJson_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = SystemColors.ButtonFace;
            lblError.Location = new Point(187, 411);
            lblError.Name = "lblError";
            lblError.Size = new Size(63, 31);
            lblError.TabIndex = 3;
            lblError.Text = "error";
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(701, 681);
            Controls.Add(lblError);
            Controls.Add(btnDescargarJson);
            Controls.Add(btnDescargarCsv);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInformes";
            Text = "FormInformes";
            Load += FormInformes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDescargarCsv;
        private Button btnDescargarJson;
        private Label lblError;
    }
}