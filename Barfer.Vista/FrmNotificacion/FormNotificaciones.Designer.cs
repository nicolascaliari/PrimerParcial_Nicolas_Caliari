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
            lbNotificaciones.ForeColor = SystemColors.Desktop;
            lbNotificaciones.FormattingEnabled = true;
            lbNotificaciones.ItemHeight = 15;
            lbNotificaciones.Location = new Point(45, 45);
            lbNotificaciones.Name = "lbNotificaciones";
            lbNotificaciones.Size = new Size(683, 364);
            lbNotificaciones.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(333, 66);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 1;
            label1.Text = "Notificaciones";
            // 
            // FormNotificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbNotificaciones);
            Name = "FormNotificaciones";
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