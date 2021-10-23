
namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes
{
    partial class Modificar_Peso_x_Altura_x_Raza
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
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_alturaMedia = new WindowsFormsApp1.Back_end.TextBox01();
            this.txt_PesoMax = new WindowsFormsApp1.Back_end.TextBox01();
            this.txt_pesoMin = new WindowsFormsApp1.Back_end.TextBox01();
            this.cmb_sexo = new WindowsFormsApp1.Back_end.ComboBox01();
            this.cmb_denominacion = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(271, 273);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(94, 23);
            this.btn_Modificar.TabIndex = 32;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Altura Media";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Peso Maximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Peso Minimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Denominacion";
            // 
            // txt_alturaMedia
            // 
            this.txt_alturaMedia.Location = new System.Drawing.Point(150, 170);
            this.txt_alturaMedia.Name = "txt_alturaMedia";
            this.txt_alturaMedia.Pp_campo = null;
            this.txt_alturaMedia.Pp_MensajeError = "Por favor agregue una altura media";
            this.txt_alturaMedia.Pp_tabla = null;
            this.txt_alturaMedia.Pp_Validable = false;
            this.txt_alturaMedia.Size = new System.Drawing.Size(172, 20);
            this.txt_alturaMedia.TabIndex = 31;
            // 
            // txt_PesoMax
            // 
            this.txt_PesoMax.Location = new System.Drawing.Point(150, 133);
            this.txt_PesoMax.Name = "txt_PesoMax";
            this.txt_PesoMax.Pp_campo = null;
            this.txt_PesoMax.Pp_MensajeError = "Por favor agregue un peso maximo";
            this.txt_PesoMax.Pp_tabla = null;
            this.txt_PesoMax.Pp_Validable = false;
            this.txt_PesoMax.Size = new System.Drawing.Size(172, 20);
            this.txt_PesoMax.TabIndex = 30;
            // 
            // txt_pesoMin
            // 
            this.txt_pesoMin.Location = new System.Drawing.Point(150, 97);
            this.txt_pesoMin.Name = "txt_pesoMin";
            this.txt_pesoMin.Pp_campo = null;
            this.txt_pesoMin.Pp_MensajeError = "Por favor agregue Un peso minimo";
            this.txt_pesoMin.Pp_tabla = null;
            this.txt_pesoMin.Pp_Validable = false;
            this.txt_pesoMin.Size = new System.Drawing.Size(172, 20);
            this.txt_pesoMin.TabIndex = 29;
            // 
            // cmb_sexo
            // 
            this.cmb_sexo._ComboSinSeleccion = false;
            this.cmb_sexo._tabla_cargar_combo = null;
            this.cmb_sexo._tabla_cargar_condicion = null;
            this.cmb_sexo._tabla_cargar_descriptor = null;
            this.cmb_sexo._tabla_cargar_fk = null;
            this.cmb_sexo._tabla_cargar_pk = null;
            this.cmb_sexo._tabla_cargar_relacion = null;
            this.cmb_sexo._tabla_cargar_relacion_pk = null;
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Location = new System.Drawing.Point(150, 60);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Pp_conseleccion = false;
            this.cmb_sexo.Pp_Descripcion = "Nombre";
            this.cmb_sexo.Pp_MessageError = "Por favor seleccione algun sexo";
            this.cmb_sexo.Pp_Pk = "ID";
            this.cmb_sexo.Pp_Tabla = "sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(172, 21);
            this.cmb_sexo.TabIndex = 28;
            this.cmb_sexo.validable = false;
            // 
            // cmb_denominacion
            // 
            this.cmb_denominacion._ComboSinSeleccion = false;
            this.cmb_denominacion._tabla_cargar_combo = null;
            this.cmb_denominacion._tabla_cargar_condicion = null;
            this.cmb_denominacion._tabla_cargar_descriptor = null;
            this.cmb_denominacion._tabla_cargar_fk = null;
            this.cmb_denominacion._tabla_cargar_pk = null;
            this.cmb_denominacion._tabla_cargar_relacion = null;
            this.cmb_denominacion._tabla_cargar_relacion_pk = null;
            this.cmb_denominacion.Enabled = false;
            this.cmb_denominacion.FormattingEnabled = true;
            this.cmb_denominacion.Location = new System.Drawing.Point(150, 23);
            this.cmb_denominacion.Name = "cmb_denominacion";
            this.cmb_denominacion.Pp_conseleccion = false;
            this.cmb_denominacion.Pp_Descripcion = "Denominacion";
            this.cmb_denominacion.Pp_MessageError = "Por favor seleccione alguna Denominacion";
            this.cmb_denominacion.Pp_Pk = "Denominacion";
            this.cmb_denominacion.Pp_Tabla = "raza";
            this.cmb_denominacion.Size = new System.Drawing.Size(172, 21);
            this.cmb_denominacion.TabIndex = 27;
            this.cmb_denominacion.validable = false;
            // 
            // Modificar_Peso_x_Altura_x_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 308);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.txt_alturaMedia);
            this.Controls.Add(this.txt_PesoMax);
            this.Controls.Add(this.txt_pesoMin);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.cmb_denominacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modificar_Peso_x_Altura_x_Raza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar_Peso_x_Altura_x_Raza";
            this.Load += new System.EventHandler(this.Modificar_Peso_x_Altura_x_Raza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modificar;
        private Back_end.TextBox01 txt_alturaMedia;
        private Back_end.TextBox01 txt_PesoMax;
        private Back_end.TextBox01 txt_pesoMin;
        private Back_end.ComboBox01 cmb_sexo;
        private Back_end.ComboBox01 cmb_denominacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}