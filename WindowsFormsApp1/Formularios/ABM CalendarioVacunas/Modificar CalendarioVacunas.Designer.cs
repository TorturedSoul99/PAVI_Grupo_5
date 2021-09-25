
namespace WindowsFormsApp1.Formularios.ABM_CalendarioVacunas
{
    partial class Modificar_CalendarioVacunas
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaReal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDosis = new System.Windows.Forms.TextBox();
            this.comboBoxLaboratorio = new WindowsFormsApp1.Back_end.ComboBox01();
            this.comboBoxVacuna = new WindowsFormsApp1.Back_end.ComboBox01();
            this.dateTimePickerFechaEstomada = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEmpleados = new WindowsFormsApp1.Back_end.ComboBox01();
            this.comboBoxNHC = new WindowsFormsApp1.Back_end.ComboBox01();
            this.lblHC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(327, 324);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 41);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha estimada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vacuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha real";
            // 
            // dateTimePickerFechaReal
            // 
            this.dateTimePickerFechaReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaReal.Location = new System.Drawing.Point(222, 151);
            this.dateTimePickerFechaReal.Name = "dateTimePickerFechaReal";
            this.dateTimePickerFechaReal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaReal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Laboratorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dosis";
            // 
            // textBoxDosis
            // 
            this.textBoxDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDosis.Location = new System.Drawing.Point(222, 273);
            this.textBoxDosis.Name = "textBoxDosis";
            this.textBoxDosis.Size = new System.Drawing.Size(200, 24);
            this.textBoxDosis.TabIndex = 12;
            // 
            // comboBoxLaboratorio
            // 
            this.comboBoxLaboratorio._ComboSinSeleccion = true;
            this.comboBoxLaboratorio._tabla_cargar_combo = "laboratorios";
            this.comboBoxLaboratorio._tabla_cargar_descriptor = "Nombre";
            this.comboBoxLaboratorio._tabla_cargar_pk = "ID_laboratorio";
            this.comboBoxLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLaboratorio.FormattingEnabled = true;
            this.comboBoxLaboratorio.Location = new System.Drawing.Point(222, 230);
            this.comboBoxLaboratorio.Name = "comboBoxLaboratorio";
            this.comboBoxLaboratorio.Size = new System.Drawing.Size(200, 26);
            this.comboBoxLaboratorio.TabIndex = 10;
            // 
            // comboBoxVacuna
            // 
            this.comboBoxVacuna._ComboSinSeleccion = true;
            this.comboBoxVacuna._tabla_cargar_combo = "";
            this.comboBoxVacuna._tabla_cargar_descriptor = "";
            this.comboBoxVacuna._tabla_cargar_pk = "";
            this.comboBoxVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVacuna.FormattingEnabled = true;
            this.comboBoxVacuna.Location = new System.Drawing.Point(222, 71);
            this.comboBoxVacuna.Name = "comboBoxVacuna";
            this.comboBoxVacuna.Size = new System.Drawing.Size(180, 26);
            this.comboBoxVacuna.TabIndex = 10;
            // 
            // dateTimePickerFechaEstomada
            // 
            this.dateTimePickerFechaEstomada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaEstomada.Location = new System.Drawing.Point(222, 111);
            this.dateTimePickerFechaEstomada.Name = "dateTimePickerFechaEstomada";
            this.dateTimePickerFechaEstomada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaEstomada.TabIndex = 13;
            this.dateTimePickerFechaEstomada.Value = new System.DateTime(2021, 9, 24, 0, 0, 0, 0);
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados._ComboSinSeleccion = true;
            this.comboBoxEmpleados._tabla_cargar_combo = "empleados";
            this.comboBoxEmpleados._tabla_cargar_descriptor = "Nombre";
            this.comboBoxEmpleados._tabla_cargar_pk = "ID_empleado";
            this.comboBoxEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(222, 190);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(200, 26);
            this.comboBoxEmpleados.TabIndex = 10;
            // 
            // comboBoxNHC
            // 
            this.comboBoxNHC._ComboSinSeleccion = true;
            this.comboBoxNHC._tabla_cargar_combo = "calendario_vacunas";
            this.comboBoxNHC._tabla_cargar_descriptor = "ID_historia_clinica";
            this.comboBoxNHC._tabla_cargar_pk = "ID_historia_clinica";
            this.comboBoxNHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNHC.FormattingEnabled = true;
            this.comboBoxNHC.Location = new System.Drawing.Point(222, 29);
            this.comboBoxNHC.Name = "comboBoxNHC";
            this.comboBoxNHC.Size = new System.Drawing.Size(71, 26);
            this.comboBoxNHC.TabIndex = 10;
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHC.Location = new System.Drawing.Point(12, 32);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(195, 20);
            this.lblHC.TabIndex = 8;
            this.lblHC.Text = "Numero de Historia Clinica";
            // 
            // Modificar_CalendarioVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(432, 378);
            this.Controls.Add(this.dateTimePickerFechaEstomada);
            this.Controls.Add(this.dateTimePickerFechaReal);
            this.Controls.Add(this.textBoxDosis);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboBoxEmpleados);
            this.Controls.Add(this.comboBoxLaboratorio);
            this.Controls.Add(this.comboBoxVacuna);
            this.Controls.Add(this.comboBoxNHC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificar_CalendarioVacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Calendario de Vacunas";
            this.Load += new System.EventHandler(this.Modificar_CalendarioVacunas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaReal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Back_end.ComboBox01 comboBoxLaboratorio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDosis;
        private Back_end.ComboBox01 comboBoxVacuna;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEstomada;
        private Back_end.ComboBox01 comboBoxEmpleados;
        private Back_end.ComboBox01 comboBoxNHC;
        private System.Windows.Forms.Label lblHC;
    }
}