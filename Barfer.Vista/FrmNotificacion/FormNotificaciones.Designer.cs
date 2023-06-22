namespace Barfer.Vista.FrmNotificacion
{
    partial class FormNotificaciones
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
            lbNotificaciones = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbNotificaciones
            // 
            lbNotificaciones.BackColor = Color.FromArgb(26, 32, 40);
            lbNotificaciones.Font = new Font("Stencil", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lbNotificaciones.ForeColor = SystemColors.ButtonHighlight;
            lbNotificaciones.FormattingEnabled = true;
            lbNotificaciones.ItemHeight = 27;
            lbNotificaciones.Location = new Point(51, 60);
            lbNotificaciones.Margin = new Padding(3, 4, 3, 4);
            lbNotificaciones.Name = "lbNotificaciones";
            lbNotificaciones.Size = new Size(780, 463);
            lbNotificaciones.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(381, 88);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 1;
            label1.Text = "Notificaciones";
            // 
            // FormNotificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(lbNotificaciones);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNotificaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNotificaciones";
            FormClosing += FormNotificaciones_FormClosing;
            Load += FormNotificaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbNotificaciones;
        private Label label1;
    }
}