namespace SEACF
{
    partial class Panel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangoHijosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangoCasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangoCasadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangoVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangoPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.rangosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // rangosToolStripMenuItem
            // 
            this.rangosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rangoHijosToolStripMenuItem,
            this.rangoCasaToolStripMenuItem,
            this.rangoCasadoToolStripMenuItem,
            this.rangoVehiculoToolStripMenuItem,
            this.rangoPrestamoToolStripMenuItem});
            this.rangosToolStripMenuItem.Name = "rangosToolStripMenuItem";
            this.rangosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.rangosToolStripMenuItem.Text = "Rangos";
            // 
            // rangoHijosToolStripMenuItem
            // 
            this.rangoHijosToolStripMenuItem.Name = "rangoHijosToolStripMenuItem";
            this.rangoHijosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rangoHijosToolStripMenuItem.Text = "Rango Hijos";
            this.rangoHijosToolStripMenuItem.Click += new System.EventHandler(this.rangoHijosToolStripMenuItem_Click);
            // 
            // rangoCasaToolStripMenuItem
            // 
            this.rangoCasaToolStripMenuItem.Name = "rangoCasaToolStripMenuItem";
            this.rangoCasaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rangoCasaToolStripMenuItem.Text = "Rango Casa";
            this.rangoCasaToolStripMenuItem.Click += new System.EventHandler(this.rangoCasaToolStripMenuItem_Click);
            // 
            // rangoCasadoToolStripMenuItem
            // 
            this.rangoCasadoToolStripMenuItem.Name = "rangoCasadoToolStripMenuItem";
            this.rangoCasadoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rangoCasadoToolStripMenuItem.Text = "Rango Casado";
            this.rangoCasadoToolStripMenuItem.Click += new System.EventHandler(this.rangoCasadoToolStripMenuItem_Click);
            // 
            // rangoVehiculoToolStripMenuItem
            // 
            this.rangoVehiculoToolStripMenuItem.Name = "rangoVehiculoToolStripMenuItem";
            this.rangoVehiculoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rangoVehiculoToolStripMenuItem.Text = "Rango Vehiculo";
            this.rangoVehiculoToolStripMenuItem.Click += new System.EventHandler(this.rangoVehiculoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.agregarToolStripMenuItem.Text = "Agregar ";
            // 
            // rangoPrestamoToolStripMenuItem
            // 
            this.rangoPrestamoToolStripMenuItem.Name = "rangoPrestamoToolStripMenuItem";
            this.rangoPrestamoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rangoPrestamoToolStripMenuItem.Text = "Rango Prestamo";
            this.rangoPrestamoToolStripMenuItem.Click += new System.EventHandler(this.rangoPrestamoToolStripMenuItem_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 304);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangoHijosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangoCasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangoCasadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangoVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangoPrestamoToolStripMenuItem;
    }
}