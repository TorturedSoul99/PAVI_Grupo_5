
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaReal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaEstimada = new System.Windows.Forms.DateTimePicker();
            this.lblHC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtNHC = new System.Windows.Forms.TextBox();
            this.txtVacuna = new System.Windows.Forms.TextBox();
            this.comboBoxEmpleados = new WindowsFormsApp1.Back_end.ComboBox01();
            this.comboBoxLaboratorio = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(327, 310);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 41);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha estimada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vacuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha real";
            // 
            // dateTimePickerFechaReal
            // 
            this.dateTimePickerFechaReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaReal.Location = new System.Drawing.Point(222, 166);
            this.dateTimePickerFechaReal.Name = "dateTimePickerFechaReal";
            this.dateTimePickerFechaReal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaReal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Laboratorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dosis";
            // 
            // txtDosis
            // 
            this.txtDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosis.Location = new System.Drawing.Point(222, 270);
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(200, 24);
            this.txtDosis.TabIndex = 12;
            // 
            // dateTimePickerFechaEstimada
            // 
            this.dateTimePickerFechaEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaEstimada.Location = new System.Drawing.Point(222, 131);
            this.dateTimePickerFechaEstimada.Name = "dateTimePickerFechaEstimada";
            this.dateTimePickerFechaEstimada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaEstimada.TabIndex = 13;
            this.dateTimePickerFechaEstimada.Value = new System.DateTime(2021, 9, 24, 0, 0, 0, 0);
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHC.Location = new System.Drawing.Point(12, 65);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(195, 20);
            this.lblHC.TabIndex = 8;
            this.lblHC.Text = "Numero de Historia Clinica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sucursal";
            // 
            // txtSucursal
            // 
            this.txtSucursal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursal.Location = new System.Drawing.Point(222, 27);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.ReadOnly = true;
            this.txtSucursal.Size = new System.Drawing.Size(136, 24);
            this.txtSucursal.TabIndex = 14;
            // 
            // txtNHC
            // 
            this.txtNHC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNHC.Location = new System.Drawing.Point(222, 62);
            this.txtNHC.Name = "txtNHC";
            this.txtNHC.ReadOnly = true;
            this.txtNHC.Size = new System.Drawing.Size(71, 24);
            this.txtNHC.TabIndex = 14;
            // 
            // txtVacuna
            // 
            this.txtVacuna.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacuna.Location = new System.Drawing.Point(222, 95);
            this.txtVacuna.Name = "txtVacuna";
            this.txtVacuna.ReadOnly = true;
            this.txtVacuna.Size = new System.Drawing.Size(136, 24);
            this.txtVacuna.TabIndex = 14;
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados._ComboSinSeleccion = true;
            this.comboBoxEmpleados._tabla_cargar_combo = "empleados";
            this.comboBoxEmpleados._tabla_cargar_condicion = "Nombre_sucursal";
            this.comboBoxEmpleados._tabla_cargar_descriptor = "Nombre";
            this.comboBoxEmpleados._tabla_cargar_fk = "ID_sucursal";
            this.comboBoxEmpleados._tabla_cargar_pk = "ID_empleado";
            this.comboBoxEmpleados._tabla_cargar_relacion = "sucursal";
            this.comboBoxEmpleados._tabla_cargar_relacion_pk = "ID_sucursal";
            this.comboBoxEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(222, 235);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Pp_conseleccion = false;
            this.comboBoxEmpleados.Pp_Descripcion = null;
            this.comboBoxEmpleados.Pp_MessageError = null;
            this.comboBoxEmpleados.Pp_Pk = null;
            this.comboBoxEmpleados.Pp_Tabla = null;
            this.comboBoxEmpleados.Size = new System.Drawing.Size(198, 26);
            this.comboBoxEmpleados.TabIndex = 16;
            this.comboBoxEmpleados.validable = false;
            // 
            // comboBoxLaboratorio
            // 
            this.comboBoxLaboratorio._ComboSinSeleccion = true;
            this.comboBoxLaboratorio._tabla_cargar_combo = "laboratorios";
            this.comboBoxLaboratorio._tabla_cargar_condicion = null;
            this.comboBoxLaboratorio._tabla_cargar_descriptor = "Nombre";
            this.comboBoxLaboratorio._tabla_cargar_fk = null;
            this.comboBoxLaboratorio._tabla_cargar_pk = "ID_laboratorio";
            this.comboBoxLaboratorio._tabla_cargar_relacion = null;
            this.comboBoxLaboratorio._tabla_cargar_relacion_pk = null;
            this.comboBoxLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLaboratorio.FormattingEnabled = true;
            this.comboBoxLaboratorio.Location = new System.Drawing.Point(222, 198);
            this.comboBoxLaboratorio.Name = "comboBoxLaboratorio";
            this.comboBoxLaboratorio.Pp_conseleccion = false;
            this.comboBoxLaboratorio.Pp_Descripcion = null;
            this.comboBoxLaboratorio.Pp_MessageError = null;
            this.comboBoxLaboratorio.Pp_Pk = null;
            this.comboBoxLaboratorio.Pp_Tabla = null;
            this.comboBoxLaboratorio.Size = new System.Drawing.Size(200, 26);
            this.comboBoxLaboratorio.TabIndex = 10;
            this.comboBoxLaboratorio.validable = false;
            // 
            // Modificar_CalendarioVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(432, 363);
            this.Controls.Add(this.comboBoxEmpleados);
            this.Controls.Add(this.txtVacuna);
            this.Controls.Add(this.txtNHC);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.dateTimePickerFechaEstimada);
            this.Controls.Add(this.dateTimePickerFechaReal);
            this.Controls.Add(this.txtDosis);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.comboBoxLaboratorio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
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

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaReal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Back_end.ComboBox01 comboBoxLaboratorio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEstimada;
        private System.Windows.Forms.Label lblHC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtNHC;
        private System.Windows.Forms.TextBox txtVacuna;
        private Back_end.ComboBox01 comboBoxEmpleados;
    }
}