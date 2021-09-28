
namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza
{
    partial class Mostrar_raza
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtdenominacion = new System.Windows.Forms.TextBox();
            this.lblcuidadosespeciales = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lbldenominacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(308, 204);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(77, 27);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "Mostrar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 11;
            // 
            // txtdenominacion
            // 
            this.txtdenominacion.Location = new System.Drawing.Point(181, 43);
            this.txtdenominacion.Name = "txtdenominacion";
            this.txtdenominacion.Size = new System.Drawing.Size(204, 20);
            this.txtdenominacion.TabIndex = 10;
            // 
            // lblcuidadosespeciales
            // 
            this.lblcuidadosespeciales.AutoSize = true;
            this.lblcuidadosespeciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuidadosespeciales.Location = new System.Drawing.Point(18, 145);
            this.lblcuidadosespeciales.Name = "lblcuidadosespeciales";
            this.lblcuidadosespeciales.Size = new System.Drawing.Size(157, 20);
            this.lblcuidadosespeciales.TabIndex = 9;
            this.lblcuidadosespeciales.Text = "Cuidados Especiales";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(130, 91);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(45, 20);
            this.lblsexo.TabIndex = 8;
            this.lblsexo.Text = "Sexo";
            // 
            // lbldenominacion
            // 
            this.lbldenominacion.AutoSize = true;
            this.lbldenominacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldenominacion.Location = new System.Drawing.Point(64, 43);
            this.lbldenominacion.Name = "lbldenominacion";
            this.lbldenominacion.Size = new System.Drawing.Size(111, 20);
            this.lbldenominacion.TabIndex = 7;
            this.lbldenominacion.Text = "Denominacion";
            // 
            // Mostrar_raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 248);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtdenominacion);
            this.Controls.Add(this.lblcuidadosespeciales);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lbldenominacion);
            this.Name = "Mostrar_raza";
            this.Text = "Mostrar_raza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtdenominacion;
        private System.Windows.Forms.Label lblcuidadosespeciales;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbldenominacion;
    }
}