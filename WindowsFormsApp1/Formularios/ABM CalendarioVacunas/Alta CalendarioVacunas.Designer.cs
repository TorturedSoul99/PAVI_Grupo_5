
namespace WindowsFormsApp1.Formularios.ABM_CalendarioVacunas
{
    partial class Alta_CalendarioVacunas
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
            this.dateTimePickerFechaEstimada = new System.Windows.Forms.DateTimePicker();
            this.lblHC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboBoxVacuna = new WindowsFormsApp1.Back_end.ComboBox01();
            this.comboBoxNHC = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // dateTimePickerFechaEstimada
            // 
            this.dateTimePickerFechaEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaEstimada.Location = new System.Drawing.Point(220, 116);
            this.dateTimePickerFechaEstimada.Name = "dateTimePickerFechaEstimada";
            this.dateTimePickerFechaEstimada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaEstimada.TabIndex = 0;
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHC.Location = new System.Drawing.Point(12, 23);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(195, 20);
            this.lblHC.TabIndex = 2;
            this.lblHC.Text = "Numero de Historia Clinica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vacuna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha estimada";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(327, 163);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 41);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // comboBoxVacuna
            // 
            this.comboBoxVacuna._ComboSinSeleccion = true;
            this.comboBoxVacuna._tabla_cargar_combo = "vacunas";
            this.comboBoxVacuna._tabla_cargar_descriptor = "Nombre";
            this.comboBoxVacuna._tabla_cargar_pk = "ID_vacuna";
            this.comboBoxVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVacuna.FormattingEnabled = true;
            this.comboBoxVacuna.Location = new System.Drawing.Point(222, 68);
            this.comboBoxVacuna.Name = "comboBoxVacuna";
            this.comboBoxVacuna.Size = new System.Drawing.Size(177, 26);
            this.comboBoxVacuna.TabIndex = 3;
            // 
            // comboBoxNHC
            // 
            this.comboBoxNHC._ComboSinSeleccion = true;
            this.comboBoxNHC._tabla_cargar_combo = "historia_clinica";
            this.comboBoxNHC._tabla_cargar_descriptor = "Nro_historia_clinica";
            this.comboBoxNHC._tabla_cargar_pk = "Nro_historia_clinica";
            this.comboBoxNHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNHC.FormattingEnabled = true;
            this.comboBoxNHC.Location = new System.Drawing.Point(222, 20);
            this.comboBoxNHC.Name = "comboBoxNHC";
            this.comboBoxNHC.Size = new System.Drawing.Size(71, 26);
            this.comboBoxNHC.TabIndex = 3;
            // 
            // Alta_CalendarioVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(432, 215);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboBoxVacuna);
            this.Controls.Add(this.comboBoxNHC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHC);
            this.Controls.Add(this.dateTimePickerFechaEstimada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta_CalendarioVacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Calendario de Vacunación";
            this.Load += new System.EventHandler(this.Alta_CalendarioVacunas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEstimada;
        private System.Windows.Forms.Label lblHC;
        private Back_end.ComboBox01 comboBoxNHC;
        private System.Windows.Forms.Label label1;
        private Back_end.ComboBox01 comboBoxVacuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
    }
}