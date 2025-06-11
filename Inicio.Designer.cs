namespace Proyecto_1_PAvanzada
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            gestionarSuplidoresToolStripMenuItem = new ToolStripMenuItem();
            gestionarCategoriasToolStripMenuItem = new ToolStripMenuItem();
            gestionarToolStripMenuItem = new ToolStripMenuItem();
            gestionarProductosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionarSuplidoresToolStripMenuItem, gestionarCategoriasToolStripMenuItem, gestionarToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1051, 517);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionarSuplidoresToolStripMenuItem
            // 
            gestionarSuplidoresToolStripMenuItem.Name = "gestionarSuplidoresToolStripMenuItem";
            gestionarSuplidoresToolStripMenuItem.Size = new Size(1044, 43);
            gestionarSuplidoresToolStripMenuItem.Text = "Gestionar Suplidores";
            gestionarSuplidoresToolStripMenuItem.Click += gestionarSuplidoresToolStripMenuItem_Click;
            // 
            // gestionarCategoriasToolStripMenuItem
            // 
            gestionarCategoriasToolStripMenuItem.Name = "gestionarCategoriasToolStripMenuItem";
            gestionarCategoriasToolStripMenuItem.Size = new Size(1044, 43);
            gestionarCategoriasToolStripMenuItem.Text = "Gestionar Categorias";
            gestionarCategoriasToolStripMenuItem.Click += gestionarCategoriasToolStripMenuItem_Click;
            // 
            // gestionarToolStripMenuItem
            // 
            gestionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarProductosToolStripMenuItem });
            gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            gestionarToolStripMenuItem.Size = new Size(1044, 43);
            gestionarToolStripMenuItem.Text = "Gestionar  Productos";
            gestionarToolStripMenuItem.Click += gestionarToolStripMenuItem_Click;
            // 
            // gestionarProductosToolStripMenuItem
            // 
            gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            gestionarProductosToolStripMenuItem.Size = new Size(224, 26);
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1051, 517);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionarSuplidoresToolStripMenuItem;
        private ToolStripMenuItem gestionarCategoriasToolStripMenuItem;
        private ToolStripMenuItem gestionarToolStripMenuItem;
        private ToolStripMenuItem gestionarProductosToolStripMenuItem;
    }
}