
namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Peso_x_Altura_x_Raza
{
    partial class Mostrar_Peso_x_Altura_x_Raza
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_alturaMedia = new WindowsFormsApp1.Back_end.TextBox01();
            this.txt_PesoMax = new WindowsFormsApp1.Back_end.TextBox01();
            this.txt_pesoMin = new WindowsFormsApp1.Back_end.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_denominacion = new System.Windows.Forms.TextBox();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(267, 269);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(94, 23);
            this.btn_Eliminar.TabIndex = 43;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_alturaMedia
            // 
            this.txt_alturaMedia.Enabled = false;
            this.txt_alturaMedia.Location = new System.Drawing.Point(146, 166);
            this.txt_alturaMedia.Name = "txt_alturaMedia";
            this.txt_alturaMedia.Pp_campo = null;
            this.txt_alturaMedia.Pp_MensajeError = "Por favor agregue una altura media";
            this.txt_alturaMedia.Pp_tabla = null;
            this.txt_alturaMedia.Pp_Validable = false;
            this.txt_alturaMedia.Size = new System.Drawing.Size(172, 20);
            this.txt_alturaMedia.TabIndex = 42;
            // 
            // txt_PesoMax
            // 
            this.txt_PesoMax.Enabled = false;
            this.txt_PesoMax.Location = new System.Drawing.Point(146, 129);
            this.txt_PesoMax.Name = "txt_PesoMax";
            this.txt_PesoMax.Pp_campo = null;
            this.txt_PesoMax.Pp_MensajeError = "Por favor agregue un peso maximo";
            this.txt_PesoMax.Pp_tabla = null;
            this.txt_PesoMax.Pp_Validable = false;
            this.txt_PesoMax.Size = new System.Drawing.Size(172, 20);
            this.txt_PesoMax.TabIndex = 41;
            // 
            // txt_pesoMin
            // 
            this.txt_pesoMin.Enabled = false;
            this.txt_pesoMin.Location = new System.Drawing.Point(146, 93);
            this.txt_pesoMin.Name = "txt_pesoMin";
            this.txt_pesoMin.Pp_campo = null;
            this.txt_pesoMin.Pp_MensajeError = "Por favor agregue Un peso minimo";
            this.txt_pesoMin.Pp_tabla = null;
            this.txt_pesoMin.Pp_Validable = false;
            this.txt_pesoMin.Size = new System.Drawing.Size(172, 20);
            this.txt_pesoMin.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Altura Media";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Peso Maximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Peso Minimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Denominacion";
            // 
            // txt_denominacion
            // 
            this.txt_denominacion.Enabled = false;
            this.txt_denominacion.Location = new System.Drawing.Point(146, 19);
            this.txt_denominacion.Name = "txt_denominacion";
            this.txt_denominacion.Size = new System.Drawing.Size(172, 20);
            this.txt_denominacion.TabIndex = 44;
            // 
            // txt_sexo
            // 
            this.txt_sexo.Enabled = false;
            this.txt_sexo.Location = new System.Drawing.Point(146, 56);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(172, 20);
            this.txt_sexo.TabIndex = 45;
            // 
            // Mostrar_Peso_x_Altura_x_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 310);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.txt_denominacion);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txt_alturaMedia);
            this.Controls.Add(this.txt_PesoMax);
            this.Controls.Add(this.txt_pesoMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mostrar_Peso_x_Altura_x_Raza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Peso por Altura por Raza";
            this.Load += new System.EventHandler(this.Mostrar_Peso_x_Altura_x_Raza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private Back_end.TextBox01 txt_alturaMedia;
        private Back_end.TextBox01 txt_PesoMax;
        private Back_end.TextBox01 txt_pesoMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_denominacion;
        private System.Windows.Forms.TextBox txt_sexo;
    }
}