namespace menu_will
{
    partial class Form1
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
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallarElAreaDeUnTrianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallarElAreaDeUnRectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallarElAreaDeUnRomboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borbujaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicaionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.nuevoClienteToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.registroToolStripMenuItem.Text = "numeros naturales";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.procesosToolStripMenuItem.Text = "vectores";
            this.procesosToolStripMenuItem.Click += new System.EventHandler(this.procesosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.consultasToolStripMenuItem.Text = "matrices";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicaionToolStripMenuItem,
            this.divisionToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "aritmetica";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallarElAreaDeUnTrianguloToolStripMenuItem,
            this.hallarElAreaDeUnRectanguloToolStripMenuItem,
            this.hallarElAreaDeUnRomboToolStripMenuItem});
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoClienteToolStripMenuItem.Text = "geometria";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fibonaciToolStripMenuItem,
            this.circularToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoToolStripMenuItem.Text = "serie";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borbujaToolStripMenuItem,
            this.seleccionToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "ordenamiento";
            // 
            // hallarElAreaDeUnTrianguloToolStripMenuItem
            // 
            this.hallarElAreaDeUnTrianguloToolStripMenuItem.Name = "hallarElAreaDeUnTrianguloToolStripMenuItem";
            this.hallarElAreaDeUnTrianguloToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.hallarElAreaDeUnTrianguloToolStripMenuItem.Text = "Hallar el area de un triangulo";
            // 
            // hallarElAreaDeUnRectanguloToolStripMenuItem
            // 
            this.hallarElAreaDeUnRectanguloToolStripMenuItem.Name = "hallarElAreaDeUnRectanguloToolStripMenuItem";
            this.hallarElAreaDeUnRectanguloToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.hallarElAreaDeUnRectanguloToolStripMenuItem.Text = "Hallar el area de un rectangulo";
            // 
            // hallarElAreaDeUnRomboToolStripMenuItem
            // 
            this.hallarElAreaDeUnRomboToolStripMenuItem.Name = "hallarElAreaDeUnRomboToolStripMenuItem";
            this.hallarElAreaDeUnRomboToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.hallarElAreaDeUnRomboToolStripMenuItem.Text = "Hallar el area de un rombo";
            // 
            // fibonaciToolStripMenuItem
            // 
            this.fibonaciToolStripMenuItem.Name = "fibonaciToolStripMenuItem";
            this.fibonaciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fibonaciToolStripMenuItem.Text = "Fibonaci";
            // 
            // circularToolStripMenuItem
            // 
            this.circularToolStripMenuItem.Name = "circularToolStripMenuItem";
            this.circularToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circularToolStripMenuItem.Text = "circular";
            // 
            // borbujaToolStripMenuItem
            // 
            this.borbujaToolStripMenuItem.Name = "borbujaToolStripMenuItem";
            this.borbujaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borbujaToolStripMenuItem.Text = "Borbuja";
            // 
            // seleccionToolStripMenuItem
            // 
            this.seleccionToolStripMenuItem.Name = "seleccionToolStripMenuItem";
            this.seleccionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seleccionToolStripMenuItem.Text = "seleccion";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumaToolStripMenuItem.Text = "suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaToolStripMenuItem.Text = "resta";
            // 
            // multiplicaionToolStripMenuItem
            // 
            this.multiplicaionToolStripMenuItem.Name = "multiplicaionToolStripMenuItem";
            this.multiplicaionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiplicaionToolStripMenuItem.Text = "multiplicaion";
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.divisionToolStripMenuItem.Text = "division";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicaionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallarElAreaDeUnTrianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallarElAreaDeUnRectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallarElAreaDeUnRomboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borbujaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionToolStripMenuItem;
    }
}

