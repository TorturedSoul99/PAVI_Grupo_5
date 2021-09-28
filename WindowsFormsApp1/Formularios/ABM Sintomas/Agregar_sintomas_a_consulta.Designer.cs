
namespace WindowsFormsApp1.Formularios.ABM_Sintomas
{
    partial class Agregar_sintomas_a_consulta
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBoxSintomas = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(69, 47);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(76, 20);
            this.lbl2.TabIndex = 65;
            this.lbl2.Text = "Sintomas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(303, 104);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 40);
            this.btnAgregar.TabIndex = 64;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 40);
            this.button1.TabIndex = 64;
            this.button1.Text = "ABM Sintomas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBoxSintomas
            // 
            this.ComboBoxSintomas._ComboSinSeleccion = true;
            this.ComboBoxSintomas._tabla_cargar_combo = "sintomas";
            this.ComboBoxSintomas._tabla_cargar_condicion = null;
            this.ComboBoxSintomas._tabla_cargar_descriptor = "Nombre";
            this.ComboBoxSintomas._tabla_cargar_fk = null;
            this.ComboBoxSintomas._tabla_cargar_pk = "ID_sintoma";
            this.ComboBoxSintomas._tabla_cargar_relacion = null;
            this.ComboBoxSintomas._tabla_cargar_relacion_pk = null;
            this.ComboBoxSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSintomas.FormattingEnabled = true;
            this.ComboBoxSintomas.Location = new System.Drawing.Point(170, 47);
            this.ComboBoxSintomas.Name = "ComboBoxSintomas";
            this.ComboBoxSintomas.Pp_conseleccion = false;
            this.ComboBoxSintomas.Pp_Descripcion = null;
            this.ComboBoxSintomas.Pp_MessageError = null;
            this.ComboBoxSintomas.Pp_Pk = null;
            this.ComboBoxSintomas.Pp_Tabla = null;
            this.ComboBoxSintomas.Size = new System.Drawing.Size(220, 24);
            this.ComboBoxSintomas.TabIndex = 66;
            this.ComboBoxSintomas.validable = false;
            // 
            // Agregar_sintomas_a_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._787538;
            this.ClientSize = new System.Drawing.Size(420, 178);
            this.Controls.Add(this.ComboBoxSintomas);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_sintomas_a_consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar sintomas";
            this.Load += new System.EventHandler(this.Agregar_sintomas_a_consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button1;
        private Back_end.ComboBox01 ComboBoxSintomas;
    }
}