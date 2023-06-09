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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 64);
            label1.Name = "label1";
            label1.Size = new Size(316, 30);
            label1.TabIndex = 0;
            label1.Text = "Descargar las ventas generadas";
            // 
            // btnDescargarCsv
            // 
            btnDescargarCsv.Location = new Point(78, 157);
            btnDescargarCsv.Name = "btnDescargarCsv";
            btnDescargarCsv.Size = new Size(108, 40);
            btnDescargarCsv.TabIndex = 1;
            btnDescargarCsv.Text = "CSV";
            btnDescargarCsv.UseVisualStyleBackColor = true;
            btnDescargarCsv.Click += btnDescargarCsv_Click;
            // 
            // btnDescargarJson
            // 
            btnDescargarJson.Location = new Point(399, 157);
            btnDescargarJson.Name = "btnDescargarJson";
            btnDescargarJson.Size = new Size(108, 40);
            btnDescargarJson.TabIndex = 2;
            btnDescargarJson.Text = "JSON";
            btnDescargarJson.UseVisualStyleBackColor = true;
            btnDescargarJson.Click += btnDescargarJson_Click;
            // 
            // FormInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 511);
            Controls.Add(btnDescargarJson);
            Controls.Add(btnDescargarCsv);
            Controls.Add(label1);
            Name = "FormInformes";
            Text = "FormInformes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDescargarCsv;
        private Button btnDescargarJson;
    }
}