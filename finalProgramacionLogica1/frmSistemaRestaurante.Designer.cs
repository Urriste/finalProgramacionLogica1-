namespace finalProgramacionLogica1
{
    partial class frmSistemaRestaurante
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
            this.punto2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punto3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punto4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punto5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punto6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.punto2ToolStripMenuItem,
            this.punto3ToolStripMenuItem,
            this.punto4ToolStripMenuItem,
            this.punto5ToolStripMenuItem,
            this.punto6ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // punto2ToolStripMenuItem
            // 
            this.punto2ToolStripMenuItem.Name = "punto2ToolStripMenuItem";
            this.punto2ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.punto2ToolStripMenuItem.Text = "Punto 2";
            this.punto2ToolStripMenuItem.Click += new System.EventHandler(this.punto2ToolStripMenuItem_Click);
            // 
            // punto3ToolStripMenuItem
            // 
            this.punto3ToolStripMenuItem.Name = "punto3ToolStripMenuItem";
            this.punto3ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.punto3ToolStripMenuItem.Text = "Punto 3";
            this.punto3ToolStripMenuItem.Click += new System.EventHandler(this.punto3ToolStripMenuItem_Click);
            // 
            // punto4ToolStripMenuItem
            // 
            this.punto4ToolStripMenuItem.Name = "punto4ToolStripMenuItem";
            this.punto4ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.punto4ToolStripMenuItem.Text = "Punto 4";
            this.punto4ToolStripMenuItem.Click += new System.EventHandler(this.punto4ToolStripMenuItem_Click);
            // 
            // punto5ToolStripMenuItem
            // 
            this.punto5ToolStripMenuItem.Name = "punto5ToolStripMenuItem";
            this.punto5ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.punto5ToolStripMenuItem.Text = "Punto 5";
            this.punto5ToolStripMenuItem.Click += new System.EventHandler(this.punto5ToolStripMenuItem_Click);
            // 
            // punto6ToolStripMenuItem
            // 
            this.punto6ToolStripMenuItem.Name = "punto6ToolStripMenuItem";
            this.punto6ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.punto6ToolStripMenuItem.Text = "Punto 6";
            this.punto6ToolStripMenuItem.Click += new System.EventHandler(this.punto6ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lucas Urriste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Programación Lógica 1";
            // 
            // frmSistemaRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSistemaRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Restaurante";
            this.Load += new System.EventHandler(this.frmSistemaRestaurante_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem punto2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punto3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punto4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punto5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punto6ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

