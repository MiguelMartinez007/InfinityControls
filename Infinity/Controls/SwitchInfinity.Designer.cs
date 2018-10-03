namespace Infinity.Controls
{
    partial class SwitchInfinity
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pON = new System.Windows.Forms.Panel();
            this.pOFF = new System.Windows.Forms.Panel();
            this.ON = new System.Windows.Forms.Label();
            this.OFF = new System.Windows.Forms.Label();
            this.pON.SuspendLayout();
            this.pOFF.SuspendLayout();
            this.SuspendLayout();
            // 
            // pON
            // 
            this.pON.Controls.Add(this.OFF);
            this.pON.Dock = System.Windows.Forms.DockStyle.Left;
            this.pON.Location = new System.Drawing.Point(0, 0);
            this.pON.Name = "pON";
            this.pON.Size = new System.Drawing.Size(40, 35);
            this.pON.TabIndex = 0;
            this.pON.Click += new System.EventHandler(this.pON_Click);
            // 
            // pOFF
            // 
            this.pOFF.Controls.Add(this.ON);
            this.pOFF.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOFF.Location = new System.Drawing.Point(40, 0);
            this.pOFF.Name = "pOFF";
            this.pOFF.Size = new System.Drawing.Size(40, 35);
            this.pOFF.TabIndex = 1;
            this.pOFF.Click += new System.EventHandler(this.pOFF_Click);
            // 
            // ON
            // 
            this.ON.AutoSize = true;
            this.ON.Location = new System.Drawing.Point(9, 11);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(23, 13);
            this.ON.TabIndex = 0;
            this.ON.Text = "ON";
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // OFF
            // 
            this.OFF.AutoSize = true;
            this.OFF.Location = new System.Drawing.Point(7, 11);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(27, 13);
            this.OFF.TabIndex = 2;
            this.OFF.Text = "OFF";
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // SwitchInfinity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pOFF);
            this.Controls.Add(this.pON);
            this.Name = "SwitchInfinity";
            this.Size = new System.Drawing.Size(80, 35);
            this.Load += new System.EventHandler(this.SwitchInfinity_Load);
            this.pON.ResumeLayout(false);
            this.pON.PerformLayout();
            this.pOFF.ResumeLayout(false);
            this.pOFF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pON;
        private System.Windows.Forms.Label ON;
        private System.Windows.Forms.Panel pOFF;
        private System.Windows.Forms.Label OFF;
    }
}
