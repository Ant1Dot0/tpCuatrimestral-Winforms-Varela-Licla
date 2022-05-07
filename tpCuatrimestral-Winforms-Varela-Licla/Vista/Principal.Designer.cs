
namespace Vista
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetalleDeArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTMOSTRARDATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.eliminarArtículoToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem.Text = "Agregar Articulo";
            // 
            // eliminarArtículoToolStripMenuItem
            // 
            this.eliminarArtículoToolStripMenuItem.Name = "eliminarArtículoToolStripMenuItem";
            this.eliminarArtículoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarArtículoToolStripMenuItem.Text = "Eliminar Articulo";
            this.eliminarArtículoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArtículoToolStripMenuItem_Click);
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarArticuloToolStripMenuItem.Text = "Modificar Articulo";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeArticulosToolStripMenuItem,
            this.verDetalleDeArticuloToolStripMenuItem,
            this.buscarArticuloToolStripMenuItem,
            this.tESTMOSTRARDATOSToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listadoDeArticulosToolStripMenuItem
            // 
            this.listadoDeArticulosToolStripMenuItem.Name = "listadoDeArticulosToolStripMenuItem";
            this.listadoDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.listadoDeArticulosToolStripMenuItem.Text = "Listado de articulos";
            this.listadoDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosToolStripMenuItem_Click);
            // 
            // verDetalleDeArticuloToolStripMenuItem
            // 
            this.verDetalleDeArticuloToolStripMenuItem.Name = "verDetalleDeArticuloToolStripMenuItem";
            this.verDetalleDeArticuloToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.verDetalleDeArticuloToolStripMenuItem.Text = "Ver detalle de articulo";
            this.verDetalleDeArticuloToolStripMenuItem.Click += new System.EventHandler(this.verDetalleDeArticuloToolStripMenuItem_Click);
            // 
            // buscarArticuloToolStripMenuItem
            // 
            this.buscarArticuloToolStripMenuItem.Name = "buscarArticuloToolStripMenuItem";
            this.buscarArticuloToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.buscarArticuloToolStripMenuItem.Text = "Buscar articulo";
            this.buscarArticuloToolStripMenuItem.Click += new System.EventHandler(this.buscarArticuloToolStripMenuItem_Click);
            // 
            // tESTMOSTRARDATOSToolStripMenuItem
            // 
            this.tESTMOSTRARDATOSToolStripMenuItem.Name = "tESTMOSTRARDATOSToolStripMenuItem";
            this.tESTMOSTRARDATOSToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.tESTMOSTRARDATOSToolStripMenuItem.Text = "TEST MOSTRAR DATOS";
            this.tESTMOSTRARDATOSToolStripMenuItem.Click += new System.EventHandler(this.tESTMOSTRARDATOSToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetalleDeArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTMOSTRARDATOSToolStripMenuItem;
    }
}

