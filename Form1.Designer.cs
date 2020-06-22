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
            this.bt_llegeix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbsortida
            // 
            this.tbsortida.Location = new System.Drawing.Point(12, 12);
            this.tbsortida.Multiline = true;
            this.tbsortida.Name = "tbsortida";
            this.tbsortida.Size = new System.Drawing.Size(329, 146);
            this.tbsortida.TabIndex = 0;
            this.tbsortida.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // bt_llegeix
            // 
            this.bt_llegeix.Location = new System.Drawing.Point(295, 337);
            this.bt_llegeix.Name = "bt_llegeix";
            this.bt_llegeix.Size = new System.Drawing.Size(75, 23);
            this.bt_llegeix.TabIndex = 1;
            this.bt_llegeix.Text = "Llegeix";
            this.bt_llegeix.UseVisualStyleBackColor = true;
            this.bt_llegeix.Click += new System.EventHandler(this.Bt_Click);
            // 
            // WhatsReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_llegeix);
            this.Controls.Add(this.tbsortida);
            this.Name = "WhatsReader";
            this.Text = "WhatsReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsortida;
        private System.Windows.Forms.Button bt_llegeix;
    }
}

