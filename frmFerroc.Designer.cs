namespace pryArmaniniFerrocarrilSP2
{
    partial class frmFerroc
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.mrcCosto = new System.Windows.Forms.GroupBox();
            this.lblTotalF = new System.Windows.Forms.Label();
            this.lblPrecioF = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.mrcCosto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(151, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo de Ferrocarril";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(41, 85);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 16);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Dias";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(41, 149);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(63, 16);
            this.lblDistancia.TabIndex = 2;
            this.lblDistancia.Text = "Distancia";
            // 
            // mrcCosto
            // 
            this.mrcCosto.Controls.Add(this.lblTotal1);
            this.mrcCosto.Controls.Add(this.lblPrecio1);
            this.mrcCosto.Controls.Add(this.lblTotalF);
            this.mrcCosto.Controls.Add(this.lblPrecioF);
            this.mrcCosto.Controls.Add(this.lblTotal);
            this.mrcCosto.Controls.Add(this.lblPrecio);
            this.mrcCosto.Location = new System.Drawing.Point(36, 206);
            this.mrcCosto.Name = "mrcCosto";
            this.mrcCosto.Size = new System.Drawing.Size(397, 160);
            this.mrcCosto.TabIndex = 3;
            this.mrcCosto.TabStop = false;
            this.mrcCosto.Text = "Costo";
            // 
            // lblTotalF
            // 
            this.lblTotalF.AutoSize = true;
            this.lblTotalF.Location = new System.Drawing.Point(100, 97);
            this.lblTotalF.Name = "lblTotalF";
            this.lblTotalF.Size = new System.Drawing.Size(0, 16);
            this.lblTotalF.TabIndex = 3;
            // 
            // lblPrecioF
            // 
            this.lblPrecioF.AutoSize = true;
            this.lblPrecioF.Location = new System.Drawing.Point(108, 39);
            this.lblPrecioF.Name = "lblPrecioF";
            this.lblPrecioF.Size = new System.Drawing.Size(0, 16);
            this.lblPrecioF.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(34, 98);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(34, 37);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 16);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio : ";
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(154, 79);
            this.nudDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(59, 22);
            this.nudDias.TabIndex = 4;
            this.nudDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(154, 143);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(129, 22);
            this.txtDistancia.TabIndex = 5;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Location = new System.Drawing.Point(95, 37);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(10, 16);
            this.lblPrecio1.TabIndex = 4;
            this.lblPrecio1.Text = ".";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(95, 97);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(10, 16);
            this.lblTotal1.TabIndex = 4;
            this.lblTotal1.Text = ".";
            // 
            // frmFerroc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 435);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.mrcCosto);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmFerroc";
            this.Text = "Ferrocarril - Calculo";
            this.mrcCosto.ResumeLayout(false);
            this.mrcCosto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.GroupBox mrcCosto;
        private System.Windows.Forms.Label lblTotalF;
        private System.Windows.Forms.Label lblPrecioF;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblPrecio1;
    }
}

