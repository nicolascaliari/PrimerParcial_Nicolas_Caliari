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
            btnVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(910, 116);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(414, 250);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.Location = new Point(71, 533);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(409, 50);
            lblTimer.TabIndex = 2;
            lblTimer.Text = "DD/MM/YYYY HH:MI:SS";
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(14, 1107);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 68);
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
            LbVentas.ItemHeight = 36;
            LbVentas.Location = new Point(71, 116);
            LbVentas.Margin = new Padding(3, 4, 3, 4);
            LbVentas.Name = "LbVentas";
            LbVentas.ScrollAlwaysVisible = true;
            LbVentas.Size = new Size(749, 364);
            LbVentas.TabIndex = 5;
            // 
            // lblTituloVentas
            // 
            lblTituloVentas.AutoSize = true;
            lblTituloVentas.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloVentas.ForeColor = SystemColors.ButtonFace;
            lblTituloVentas.Location = new Point(71, 21);
            lblTituloVentas.Name = "lblTituloVentas";
            lblTituloVentas.Size = new Size(114, 41);
            lblTituloVentas.TabIndex = 6;
            lblTituloVentas.Text = "Ventas ";
            // 
            // btnVolver
            // 
            btnVolver.Image = Properties.Resources.back;
            btnVolver.Location = new Point(1345, 581);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(65, 49);
            btnVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolver.TabIndex = 7;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormEnvio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1422, 642);
            ControlBox = false;
            Controls.Add(btnVolver);
            Controls.Add(lblTituloVentas);
            Controls.Add(LbVentas);
            Controls.Add(btnBack);
            Controls.Add(lblTimer);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEnvio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEnvio";
            Load += FormEnvio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
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
        private PictureBox btnVolver;
    }
}