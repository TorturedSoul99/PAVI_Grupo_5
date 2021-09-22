
namespace WindowsFormsApp1.Formularios.ABM_CalendarioVacunas
{
    partial class ABM_CalendarioVacunas
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.maskedTextBoxCalendarioVacunas = new System.Windows.Forms.MaskedTextBox();
            this.lblHC = new System.Windows.Forms.Label();
            this.dataGridViewCalendarioVacunas = new WindowsFormsApp1.Back_end.DataGridView01();
            this.Nro_historia_clinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_vacunacion_estimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_vacunacion_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendarioVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(306, 14);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 29);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar según N° de Historia Clínica";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(306, 369);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(454, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(185, 369);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // maskedTextBoxCalendarioVacunas
            // 
            this.maskedTextBoxCalendarioVacunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCalendarioVacunas.Location = new System.Drawing.Point(216, 14);
            this.maskedTextBoxCalendarioVacunas.Mask = "99999";
            this.maskedTextBoxCalendarioVacunas.Name = "maskedTextBoxCalendarioVacunas";
            this.maskedTextBoxCalendarioVacunas.Size = new System.Drawing.Size(59, 29);
            this.maskedTextBoxCalendarioVacunas.TabIndex = 16;
            this.maskedTextBoxCalendarioVacunas.ValidatingType = typeof(int);
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.BackColor = System.Drawing.Color.Transparent;
            this.lblHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHC.Location = new System.Drawing.Point(50, 8);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(150, 40);
            this.lblHC.TabIndex = 17;
            this.lblHC.Text = "Buscar por Número \r\nde Historia Clinica:";
            // 
            // dataGridViewCalendarioVacunas
            // 
            this.dataGridViewCalendarioVacunas.AllowUserToAddRows = false;
            this.dataGridViewCalendarioVacunas.AllowUserToDeleteRows = false;
            this.dataGridViewCalendarioVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendarioVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_historia_clinica,
            this.Vacuna,
            this.Fecha_vacunacion_estimada,
            this.Fecha_vacunacion_real,
            this.Empleado,
            this.Laboratorio,
            this.Dosis});
            this.dataGridViewCalendarioVacunas.Location = new System.Drawing.Point(31, 68);
            this.dataGridViewCalendarioVacunas.Name = "dataGridViewCalendarioVacunas";
            this.dataGridViewCalendarioVacunas.ReadOnly = true;
            this.dataGridViewCalendarioVacunas.Size = new System.Drawing.Size(662, 272);
            this.dataGridViewCalendarioVacunas.TabIndex = 15;
            // 
            // Nro_historia_clinica
            // 
            this.Nro_historia_clinica.HeaderText = "NHC";
            this.Nro_historia_clinica.Name = "Nro_historia_clinica";
            this.Nro_historia_clinica.ReadOnly = true;
            this.Nro_historia_clinica.Width = 50;
            // 
            // Vacuna
            // 
            this.Vacuna.HeaderText = "Vacuna";
            this.Vacuna.Name = "Vacuna";
            this.Vacuna.ReadOnly = true;
            // 
            // Fecha_vacunacion_estimada
            // 
            this.Fecha_vacunacion_estimada.HeaderText = "Fecha estimada";
            this.Fecha_vacunacion_estimada.Name = "Fecha_vacunacion_estimada";
            this.Fecha_vacunacion_estimada.ReadOnly = true;
            this.Fecha_vacunacion_estimada.Width = 80;
            // 
            // Fecha_vacunacion_real
            // 
            this.Fecha_vacunacion_real.HeaderText = "Fecha real";
            this.Fecha_vacunacion_real.Name = "Fecha_vacunacion_real";
            this.Fecha_vacunacion_real.ReadOnly = true;
            this.Fecha_vacunacion_real.Width = 80;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Width = 120;
            // 
            // Laboratorio
            // 
            this.Laboratorio.HeaderText = "Laboratorio";
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.ReadOnly = true;
            this.Laboratorio.Width = 120;
            // 
            // Dosis
            // 
            this.Dosis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            // 
            // ABM_CalendarioVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.leather_black_minimalistic_1920x1080_wallpaper_www_wallpaperto_com_44;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 417);
            this.Controls.Add(this.lblHC);
            this.Controls.Add(this.maskedTextBoxCalendarioVacunas);
            this.Controls.Add(this.dataGridViewCalendarioVacunas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABM_CalendarioVacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM Calendario de Vacunación";
            this.Load += new System.EventHandler(this.ABM_CalendarioVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendarioVacunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private Back_end.DataGridView01 dataGridViewCalendarioVacunas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_historia_clinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_vacunacion_estimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_vacunacion_real;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCalendarioVacunas;
        private System.Windows.Forms.Label lblHC;
    }
}