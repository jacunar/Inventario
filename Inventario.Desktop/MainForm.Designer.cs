namespace Inventario.Desktop {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            catalogosToolStripMenuItem = new ToolStripMenuItem();
            CategoriasTSMI = new ToolStripMenuItem();
            ProveedoresTSMI = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            ProductosTSMI = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            SalirTSBI = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogosToolStripMenuItem, inventarioToolStripMenuItem, reportesToolStripMenuItem, SalirTSBI });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            catalogosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CategoriasTSMI, ProveedoresTSMI });
            catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            catalogosToolStripMenuItem.Size = new Size(72, 20);
            catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // CategoriasTSMI
            // 
            CategoriasTSMI.Name = "CategoriasTSMI";
            CategoriasTSMI.Size = new Size(180, 22);
            CategoriasTSMI.Text = "Categorias";
            CategoriasTSMI.Click += CategoriasTSMI_Click;
            // 
            // ProveedoresTSMI
            // 
            ProveedoresTSMI.Name = "ProveedoresTSMI";
            ProveedoresTSMI.Size = new Size(180, 22);
            ProveedoresTSMI.Text = "Proveedores";
            ProveedoresTSMI.Click += ProveedoresTSMI_Click;
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ProductosTSMI, ventasToolStripMenuItem });
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(72, 20);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // ProductosTSMI
            // 
            ProductosTSMI.Name = "ProductosTSMI";
            ProductosTSMI.Size = new Size(128, 22);
            ProductosTSMI.Text = "Productos";
            ProductosTSMI.Click += ProductosTSMI_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(128, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // SalirTSBI
            // 
            SalirTSBI.Name = "SalirTSBI";
            SalirTSBI.Size = new Size(41, 20);
            SalirTSBI.Text = "Salir";
            SalirTSBI.Click += SalirTSBI_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "GESTION DE INVENTARIOS";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem catalogosToolStripMenuItem;
        private ToolStripMenuItem CategoriasTSMI;
        private ToolStripMenuItem ProveedoresTSMI;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem ProductosTSMI;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem SalirTSBI;
    }
}