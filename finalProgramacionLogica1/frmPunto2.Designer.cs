namespace finalProgramacionLogica1
{
    partial class frmPunto2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmxPlato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmxVendedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalVentas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmxPlato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmxVendedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnTotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas por vendedor y plato";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Location = new System.Drawing.Point(100, 105);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.ReadOnly = true;
            this.txtTotalVentas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalVentas.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total de ventas:";
            // 
            // cmxPlato
            // 
            this.cmxPlato.FormattingEnabled = true;
            this.cmxPlato.Location = new System.Drawing.Point(149, 47);
            this.cmxPlato.Name = "cmxPlato";
            this.cmxPlato.Size = new System.Drawing.Size(121, 21);
            this.cmxPlato.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elija el plato";
            // 
            // cmxVendedor
            // 
            this.cmxVendedor.FormattingEnabled = true;
            this.cmxVendedor.Location = new System.Drawing.Point(6, 47);
            this.cmxVendedor.Name = "cmxVendedor";
            this.cmxVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmxVendedor.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Elija el vendedor";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(298, 41);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(100, 30);
            this.btnTotal.TabIndex = 7;
            this.btnTotal.Text = "Obtener Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // frmPunto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 203);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPunto2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPunto2";
            this.Load += new System.EventHandler(this.frmPunto2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmxVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ComboBox cmxPlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalVentas;
    }
}