namespace Infinity.Controls
{
    partial class TextBoxInfinity
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.separatorInfinity1 = new Infinity.Controls.SeparatorInfinity();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 27);
            this.textBox1.TabIndex = 1;
            // 
            // separatorInfinity1
            // 
            this.separatorInfinity1.BackColor = System.Drawing.Color.Black;
            this.separatorInfinity1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorInfinity1.Location = new System.Drawing.Point(0, 48);
            this.separatorInfinity1.Name = "separatorInfinity1";
            this.separatorInfinity1.Size = new System.Drawing.Size(350, 2);
            this.separatorInfinity1.TabIndex = 0;
            this.separatorInfinity1.Text = "separatorInfinity1";
            // 
            // TextBoxInfinity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.separatorInfinity1);
            this.Name = "TextBoxInfinity";
            this.Size = new System.Drawing.Size(350, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeparatorInfinity separatorInfinity1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
