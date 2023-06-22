namespace Barfer.Vista.FormVentas
{
    partial class FormEnvio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnvio));
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            btnBack = new PictureBox();
            LbVentas = new ListBox();
            lblTituloVentas = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(553, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(344, 240);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.Location = new Point(12, 505);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(321, 40);
            lblTimer.TabIndex = 2;
            lblTimer.Text = "DD/MM/YYYY HH:MI:SS";
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(12, 830);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 51);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 3;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // LbVentas
            // 
            LbVentas.BackColor = Color.FromArgb(26, 32, 40);
            LbVentas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LbVentas.ForeColor = SystemColors.Info;
            LbVentas.FormattingEnabled = true;
            LbVentas.HorizontalScrollbar = true;
            LbVentas.ItemHeight = 30;
            LbVentas.Location = new Point(12, 80);
            LbVentas.Name = "LbVentas";
            LbVentas.ScrollAlwaysVisible = true;
            LbVentas.Size = new Size(505, 244);
            LbVentas.TabIndex = 5;
            // 
            // lblTituloVentas
            // 
            lblTituloVentas.AutoSize = true;
            lblTituloVentas.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloVentas.ForeColor = SystemColors.ButtonFace;
            lblTituloVentas.Location = new Point(89, 34);
            lblTituloVentas.Name = "lblTituloVentas";
            lblTituloVentas.Size = new Size(91, 32);
            lblTituloVentas.TabIndex = 6;
            lblTituloVentas.Text = "Ventas ";
            // 
            // timer2
            // 
            
            // 
            // FormEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(1028, 585);
            Controls.Add(lblTituloVentas);
            Controls.Add(LbVentas);
            Controls.Add(btnBack);
            Controls.Add(lblTimer);
            Controls.Add(pictureBox2);
            Name = "FormEnvio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEnvio";
            Load += FormEnvio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private PictureBox btnBack;
        private ListBox LbVentas;
        private Label lblTituloVentas;
        private System.Windows.Forms.Timer timer2;
    }
}