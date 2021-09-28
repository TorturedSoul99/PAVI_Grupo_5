
namespace WindowsFormsApp1.Back_end
{
    partial class LabelText02
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.TxtDato = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(63, 5);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(35, 13);
            this.lblEtiqueta.TabIndex = 0;
            this.lblEtiqueta.Text = "label1";
            this.lblEtiqueta.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtDato
            // 
            this.TxtDato.Location = new System.Drawing.Point(104, 2);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(133, 20);
            this.TxtDato.TabIndex = 1;
            // 
            // LabelText02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtDato);
            this.Controls.Add(this.lblEtiqueta);
            this.Name = "LabelText02";
            this.Size = new System.Drawing.Size(247, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.MaskedTextBox TxtDato;
    }
}
