
namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza
{
    partial class Alta_raza
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
            this.lbldenominacion = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblcuidadosespeciales = new System.Windows.Forms.Label();
            this.txtdenominacion = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldenominacion
            // 
            this.lbldenominacion.AutoSize = true;
            this.lbldenominacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldenominacion.Location = new System.Drawing.Point(81, 57);
            this.lbldenominacion.Name = "lbldenominacion";
            this.lbldenominacion.Size = new System.Drawing.Size(111, 20);
            this.lbldenominacion.TabIndex = 0;
            this.lbldenominacion.Text = "Denominacion";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(147, 105);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(45, 20);
            this.lblsexo.TabIndex = 1;
            this.lblsexo.Text = "Sexo";
            // 
            // lblcuidadosespeciales
            // 
            this.lblcuidadosespeciales.AutoSize = true;
            this.lblcuidadosespeciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuidadosespeciales.Location = new System.Drawing.Point(35, 159);
            this.lblcuidadosespeciales.Name = "lblcuidadosespeciales";
            this.lblcuidadosespeciales.Size = new System.Drawing.Size(157, 20);
            this.lblcuidadosespeciales.TabIndex = 2;
            this.lblcuidadosespeciales.Text = "Cuidados Especiales";
            // 
            // txtdenominacion
            // 
            this.txtdenominacion.Location = new System.Drawing.Point(198, 57);
            this.txtdenominacion.Name = "txtdenominacion";
            this.txtdenominacion.Size = new System.Drawing.Size(204, 20);
            this.txtdenominacion.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(198, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(325, 218);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(77, 27);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // Alta_raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 272);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtdenominacion);
            this.Controls.Add(this.lblcuidadosespeciales);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lbldenominacion);
            this.Name = "Alta_raza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta_raza";
            this.Load += new System.EventHandler(this.Alta_raza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldenominacion;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblcuidadosespeciales;
        private System.Windows.Forms.TextBox txtdenominacion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnagregar;
    }
}