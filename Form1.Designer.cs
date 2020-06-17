namespace WhatsRead
{
    partial class WhatsReader
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
            this.tbsortida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbsortida
            // 
            this.tbsortida.Location = new System.Drawing.Point(12, 12);
            this.tbsortida.Multiline = true;
            this.tbsortida.Name = "tbsortida";
            this.tbsortida.Size = new System.Drawing.Size(329, 146);
            this.tbsortida.TabIndex = 0;
            this.tbsortida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WhatsReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbsortida);
            this.Name = "WhatsReader";
            this.Text = "WhatsReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsortida;
    }
}

