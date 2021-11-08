
namespace WindowsFormsApp1.Formularios.ABM_Sintomas
{
    partial class Modificar_Sintomas
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
            this.txtModificarSintomas = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModificarSintomas = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // txtModificarSintomas
            // 
            this.txtModificarSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarSintomas.Location = new System.Drawing.Point(162, 63);
            this.txtModificarSintomas.Name = "txtModificarSintomas";
            this.txtModificarSintomas.Size = new System.Drawing.Size(204, 24);
            this.txtModificarSintomas.TabIndex = 72;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(69, 18);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(76, 20);
            this.lbl2.TabIndex = 71;
            this.lbl2.Text = "Sintomas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(286, 111);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 29);
            this.btnAgregar.TabIndex = 70;
            this.btnAgregar.Text = "Actualizar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Modificar Nombre";
            // 
            // comboBoxModificarSintomas
            // 
            this.comboBoxModificarSintomas._ComboSinSeleccion = true;
            this.comboBoxModificarSintomas._tabla_cargar_combo = "sintomas";
            this.comboBoxModificarSintomas._tabla_cargar_descriptor = "Nombre";
            this.comboBoxModificarSintomas._tabla_cargar_pk = "ID_sintoma";
            this.comboBoxModificarSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModificarSintomas.FormattingEnabled = true;
            this.comboBoxModificarSintomas.Location = new System.Drawing.Point(162, 16);
            this.comboBoxModificarSintomas.Name = "comboBoxModificarSintomas";
            this.comboBoxModificarSintomas.Size = new System.Drawing.Size(204, 26);
            this.comboBoxModificarSintomas.TabIndex = 73;
            // 
            // Modificar_Sintomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(386, 152);
            this.Controls.Add(this.comboBoxModificarSintomas);
            this.Controls.Add(this.txtModificarSintomas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificar_Sintomas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar sintomas";
            this.Load += new System.EventHandler(this.Modificar_Sintomas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModificarSintomas;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private Back_end.ComboBox01 comboBoxModificarSintomas;
    }
}