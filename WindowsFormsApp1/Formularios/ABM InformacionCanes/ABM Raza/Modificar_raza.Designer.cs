
namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza
{
    partial class Modificar_raza
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
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txt_cuidados_especiales = new System.Windows.Forms.TextBox();
            this.txtdenominacion = new System.Windows.Forms.TextBox();
            this.lblcuidadosespeciales = new System.Windows.Forms.Label();
            this.lbldenominacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(313, 214);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(77, 27);
            this.btnmodificar.TabIndex = 13;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // txt_cuidados_especiales
            // 
            this.txt_cuidados_especiales.Location = new System.Drawing.Point(186, 124);
            this.txt_cuidados_especiales.Name = "txt_cuidados_especiales";
            this.txt_cuidados_especiales.Size = new System.Drawing.Size(204, 20);
            this.txt_cuidados_especiales.TabIndex = 11;
            // 
            // txtdenominacion
            // 
            this.txtdenominacion.Enabled = false;
            this.txtdenominacion.Location = new System.Drawing.Point(186, 53);
            this.txtdenominacion.Name = "txtdenominacion";
            this.txtdenominacion.Size = new System.Drawing.Size(204, 20);
            this.txtdenominacion.TabIndex = 10;
            // 
            // lblcuidadosespeciales
            // 
            this.lblcuidadosespeciales.AutoSize = true;
            this.lblcuidadosespeciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuidadosespeciales.Location = new System.Drawing.Point(23, 122);
            this.lblcuidadosespeciales.Name = "lblcuidadosespeciales";
            this.lblcuidadosespeciales.Size = new System.Drawing.Size(157, 20);
            this.lblcuidadosespeciales.TabIndex = 9;
            this.lblcuidadosespeciales.Text = "Cuidados Especiales";
            // 
            // lbldenominacion
            // 
            this.lbldenominacion.AutoSize = true;
            this.lbldenominacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldenominacion.Location = new System.Drawing.Point(69, 53);
            this.lbldenominacion.Name = "lbldenominacion";
            this.lbldenominacion.Size = new System.Drawing.Size(111, 20);
            this.lbldenominacion.TabIndex = 7;
            this.lbldenominacion.Text = "Denominacion";
            // 
            // Modificar_raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 262);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.txt_cuidados_especiales);
            this.Controls.Add(this.txtdenominacion);
            this.Controls.Add(this.lblcuidadosespeciales);
            this.Controls.Add(this.lbldenominacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificar_raza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar raza";
            this.Load += new System.EventHandler(this.Modificar_raza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TextBox txt_cuidados_especiales;
        private System.Windows.Forms.TextBox txtdenominacion;
        private System.Windows.Forms.Label lblcuidadosespeciales;
        private System.Windows.Forms.Label lbldenominacion;
    }
}