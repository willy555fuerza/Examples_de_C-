namespace main_will
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
            this.numerosNaturalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionAritmeticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numerosNaturalesToolStripMenuItem,
            this.vectoresToolStripMenuItem,
            this.matricesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numerosNaturalesToolStripMenuItem
            // 
            this.numerosNaturalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionAritmeticaToolStripMenuItem});
            this.numerosNaturalesToolStripMenuItem.Name = "numerosNaturalesToolStripMenuItem";
            this.numerosNaturalesToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.numerosNaturalesToolStripMenuItem.Text = "numeros naturales";
            // 
            // vectoresToolStripMenuItem
            // 
            this.vectoresToolStripMenuItem.Name = "vectoresToolStripMenuItem";
            this.vectoresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.vectoresToolStripMenuItem.Text = "vectores";
            // 
            // matricesToolStripMenuItem
            // 
            this.matricesToolStripMenuItem.Name = "matricesToolStripMenuItem";
            this.matricesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.matricesToolStripMenuItem.Text = "matrices";
            // 
            // operacionAritmeticaToolStripMenuItem
            // 
            this.operacionAritmeticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicacionToolStripMenuItem,
            this.divisionToolStripMenuItem});
            this.operacionAritmeticaToolStripMenuItem.Name = "operacionAritmeticaToolStripMenuItem";
            this.operacionAritmeticaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.operacionAritmeticaToolStripMenuItem.Text = "operacion aritmetica";
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
            // multiplicacionToolStripMenuItem
            // 
            this.multiplicacionToolStripMenuItem.Name = "multiplicacionToolStripMenuItem";
            this.multiplicacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiplicacionToolStripMenuItem.Text = "multiplicacion";
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
        private System.Windows.Forms.ToolStripMenuItem numerosNaturalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionAritmeticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matricesToolStripMenuItem;
    }
}

