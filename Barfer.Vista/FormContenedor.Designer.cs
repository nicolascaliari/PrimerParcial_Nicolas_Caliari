namespace Vistas
{
    partial class FormContenedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            productoToolStripMenuItem = new ToolStripMenuItem();
            verStockToolStripMenuItem = new ToolStripMenuItem();
            verTodoToolStripMenuItem = new ToolStripMenuItem();
            gestionDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            verCatalogoToolStripMenuItem = new ToolStripMenuItem();
            barfToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            //pictureBox1.Image = Properties.Resources.LogoAzul;
            pictureBox1.Location = new Point(270, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.CornflowerBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { productoToolStripMenuItem, gestionDeUsuariosToolStripMenuItem, homeToolStripMenuItem, verCatalogoToolStripMenuItem, barfToolStripMenuItem, calculadoraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verStockToolStripMenuItem, verTodoToolStripMenuItem });
            productoToolStripMenuItem.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(89, 24);
            productoToolStripMenuItem.Text = "Producto";
            // 
            // verStockToolStripMenuItem
            // 
            verStockToolStripMenuItem.Name = "verStockToolStripMenuItem";
            verStockToolStripMenuItem.Size = new Size(147, 24);
            verStockToolStripMenuItem.Text = "Ver stock";
            verStockToolStripMenuItem.Click += verStockToolStripMenuItem_Click;
            // 
            // verTodoToolStripMenuItem
            // 
            verTodoToolStripMenuItem.Name = "verTodoToolStripMenuItem";
            verTodoToolStripMenuItem.Size = new Size(147, 24);
            verTodoToolStripMenuItem.Text = "Ver todo";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            gestionDeUsuariosToolStripMenuItem.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            gestionDeUsuariosToolStripMenuItem.Size = new Size(169, 24);
            gestionDeUsuariosToolStripMenuItem.Text = "Gestion de usuarios";
            gestionDeUsuariosToolStripMenuItem.Click += gestionDeUsuariosToolStripMenuItem_Click;
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(111, 24);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(66, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click_1;
            // 
            // verCatalogoToolStripMenuItem
            // 
            verCatalogoToolStripMenuItem.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            verCatalogoToolStripMenuItem.Name = "verCatalogoToolStripMenuItem";
            verCatalogoToolStripMenuItem.Size = new Size(118, 24);
            verCatalogoToolStripMenuItem.Text = "Ver catalogo";
            verCatalogoToolStripMenuItem.Click += verCatalogoToolStripMenuItem_Click;
            // 
            // barfToolStripMenuItem
            // 
            barfToolStripMenuItem.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            barfToolStripMenuItem.Name = "barfToolStripMenuItem";
            barfToolStripMenuItem.Size = new Size(52, 24);
            barfToolStripMenuItem.Text = "Barf";
            barfToolStripMenuItem.Click += barfToolStripMenuItem_Click;
            // 
            // FormContenedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormContenedor";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem verStockToolStripMenuItem;
        private ToolStripMenuItem verTodoToolStripMenuItem;
        private ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem barfToolStripMenuItem;
        private ToolStripMenuItem verCatalogoToolStripMenuItem;
    }
}