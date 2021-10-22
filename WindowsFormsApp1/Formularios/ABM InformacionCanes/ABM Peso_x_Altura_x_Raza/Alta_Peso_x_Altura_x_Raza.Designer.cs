﻿
namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Peso_x_Altura_x_Raza
{
    partial class Alta_Peso_x_Altura_x_Raza
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.textBox013 = new WindowsFormsApp1.Back_end.TextBox01();
            this.textBox012 = new WindowsFormsApp1.Back_end.TextBox01();
            this.textBox011 = new WindowsFormsApp1.Back_end.TextBox01();
            this.cmb_sexo = new WindowsFormsApp1.Back_end.ComboBox01();
            this.cmb_denominacion = new WindowsFormsApp1.Back_end.ComboBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(343, 311);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(94, 23);
            this.btn_Agregar.TabIndex = 21;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // textBox013
            // 
            this.textBox013.Location = new System.Drawing.Point(222, 208);
            this.textBox013.Name = "textBox013";
            this.textBox013.Pp_campo = null;
            this.textBox013.Pp_MensajeError = null;
            this.textBox013.Pp_tabla = null;
            this.textBox013.Pp_Validable = false;
            this.textBox013.Size = new System.Drawing.Size(172, 20);
            this.textBox013.TabIndex = 20;
            // 
            // textBox012
            // 
            this.textBox012.Location = new System.Drawing.Point(222, 171);
            this.textBox012.Name = "textBox012";
            this.textBox012.Pp_campo = null;
            this.textBox012.Pp_MensajeError = null;
            this.textBox012.Pp_tabla = null;
            this.textBox012.Pp_Validable = false;
            this.textBox012.Size = new System.Drawing.Size(172, 20);
            this.textBox012.TabIndex = 19;
            // 
            // textBox011
            // 
            this.textBox011.Location = new System.Drawing.Point(222, 135);
            this.textBox011.Name = "textBox011";
            this.textBox011.Pp_campo = null;
            this.textBox011.Pp_MensajeError = null;
            this.textBox011.Pp_tabla = null;
            this.textBox011.Pp_Validable = false;
            this.textBox011.Size = new System.Drawing.Size(172, 20);
            this.textBox011.TabIndex = 18;
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
            this.cmb_sexo.Location = new System.Drawing.Point(222, 98);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Pp_conseleccion = false;
            this.cmb_sexo.Pp_Descripcion = "Nombre";
            this.cmb_sexo.Pp_MessageError = "Por favor seleccione algun sexo";
            this.cmb_sexo.Pp_Pk = "ID";
            this.cmb_sexo.Pp_Tabla = "sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(172, 21);
            this.cmb_sexo.TabIndex = 17;
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
            this.cmb_denominacion.FormattingEnabled = true;
            this.cmb_denominacion.Location = new System.Drawing.Point(222, 61);
            this.cmb_denominacion.Name = "cmb_denominacion";
            this.cmb_denominacion.Pp_conseleccion = false;
            this.cmb_denominacion.Pp_Descripcion = "Denominacion";
            this.cmb_denominacion.Pp_MessageError = "Por favor seleccione alguna Denominacion";
            this.cmb_denominacion.Pp_Pk = "Denominacion";
            this.cmb_denominacion.Pp_Tabla = "raza";
            this.cmb_denominacion.Size = new System.Drawing.Size(172, 21);
            this.cmb_denominacion.TabIndex = 16;
            this.cmb_denominacion.validable = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Altura Media";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Peso Maximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Peso Minimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Denominacion";
            // 
            // Alta_Peso_x_Altura_x_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 353);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.textBox013);
            this.Controls.Add(this.textBox012);
            this.Controls.Add(this.textBox011);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.cmb_denominacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alta_Peso_x_Altura_x_Raza";
            this.Text = "Alta Peso por Altura por Raza";
            this.Load += new System.EventHandler(this.Alta_Peso_x_Altura_x_Raza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private Back_end.TextBox01 textBox013;
        private Back_end.TextBox01 textBox012;
        private Back_end.TextBox01 textBox011;
        private Back_end.ComboBox01 cmb_sexo;
        private Back_end.ComboBox01 cmb_denominacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}