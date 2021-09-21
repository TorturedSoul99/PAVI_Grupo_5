
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dataGridViewCalendarioVacunas = new WindowsFormsApp1.Back_end.DataGridView01();
            this.ID_calendario_vacunacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnConsultar.Location = new System.Drawing.Point(48, 15);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(175, 18);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(235, 20);
            this.txtConsulta.TabIndex = 13;
            this.txtConsulta.Text = "Buscar Segun id";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(317, 377);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(465, 377);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(196, 377);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dataGridViewCalendarioVacunas
            // 
            this.dataGridViewCalendarioVacunas.AllowUserToAddRows = false;
            this.dataGridViewCalendarioVacunas.AllowUserToDeleteRows = false;
            this.dataGridViewCalendarioVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendarioVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_calendario_vacunacion,
            this.Nro_historia_clinica,
            this.Vacuna,
            this.Fecha_vacunacion_estimada,
            this.Fecha_vacunacion_real,
            this.Empleado,
            this.Laboratorio,
            this.Dosis});
            this.dataGridViewCalendarioVacunas.Location = new System.Drawing.Point(22, 69);
            this.dataGridViewCalendarioVacunas.Name = "dataGridViewCalendarioVacunas";
            this.dataGridViewCalendarioVacunas.ReadOnly = true;
            this.dataGridViewCalendarioVacunas.Size = new System.Drawing.Size(712, 272);
            this.dataGridViewCalendarioVacunas.TabIndex = 15;
            // 
            // ID_calendario_vacunacion
            // 
            this.ID_calendario_vacunacion.HeaderText = "ID";
            this.ID_calendario_vacunacion.Name = "ID_calendario_vacunacion";
            this.ID_calendario_vacunacion.ReadOnly = true;
            this.ID_calendario_vacunacion.Width = 50;
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
            this.ClientSize = new System.Drawing.Size(753, 436);
            this.Controls.Add(this.dataGridViewCalendarioVacunas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABM_CalendarioVacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM Calendario de Vacunación";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendarioVacunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private Back_end.DataGridView01 dataGridViewCalendarioVacunas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_calendario_vacunacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_historia_clinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_vacunacion_estimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_vacunacion_real;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
    }
}