
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    partial class Modificar_Sucursales
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_sucursal = new WindowsFormsApp1.Back_end.TextBox01();
            this.cmb_supervisor_suplente = new WindowsFormsApp1.Back_end.ComboBox01();
            this.cmb_supervisor = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(48, 125);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(152, 20);
            this.lbl2.TabIndex = 66;
            this.lbl2.Text = "Supervisor Suplente";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(116, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 20);
            this.lbl1.TabIndex = 65;
            this.lbl1.Text = "Supervisor";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(295, 166);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 27);
            this.btnModificar.TabIndex = 64;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nombre Sucursal";
            // 
            // txt_nombre_sucursal
            // 
            this.txt_nombre_sucursal.Location = new System.Drawing.Point(208, 41);
            this.txt_nombre_sucursal.Name = "txt_nombre_sucursal";
            this.txt_nombre_sucursal.Pp_campo = "Nombre_sucursal";
            this.txt_nombre_sucursal.Pp_MensajeError = "No ingreso un nombre";
            this.txt_nombre_sucursal.Pp_tabla = "sucursal";
            this.txt_nombre_sucursal.Pp_Validable = false;
            this.txt_nombre_sucursal.Size = new System.Drawing.Size(200, 20);
            this.txt_nombre_sucursal.TabIndex = 73;
            // 
            // cmb_supervisor_suplente
            // 
            this.cmb_supervisor_suplente._ComboSinSeleccion = false;
            this.cmb_supervisor_suplente._tabla_cargar_combo = null;
            this.cmb_supervisor_suplente._tabla_cargar_condicion = null;
            this.cmb_supervisor_suplente._tabla_cargar_descriptor = null;
            this.cmb_supervisor_suplente._tabla_cargar_fk = null;
            this.cmb_supervisor_suplente._tabla_cargar_pk = null;
            this.cmb_supervisor_suplente._tabla_cargar_relacion = null;
            this.cmb_supervisor_suplente._tabla_cargar_relacion_pk = null;
            this.cmb_supervisor_suplente.FormattingEnabled = true;
            this.cmb_supervisor_suplente.Location = new System.Drawing.Point(207, 125);
            this.cmb_supervisor_suplente.Name = "cmb_supervisor_suplente";
            this.cmb_supervisor_suplente.Pp_conseleccion = false;
            this.cmb_supervisor_suplente.Pp_Descripcion = "Nombre";
            this.cmb_supervisor_suplente.Pp_MessageError = "No se Ingreso";
            this.cmb_supervisor_suplente.Pp_Pk = "ID_empleado";
            this.cmb_supervisor_suplente.Pp_Tabla = "empleados";
            this.cmb_supervisor_suplente.Size = new System.Drawing.Size(201, 21);
            this.cmb_supervisor_suplente.TabIndex = 72;
            this.cmb_supervisor_suplente.validable = false;
            // 
            // cmb_supervisor
            // 
            this.cmb_supervisor._ComboSinSeleccion = false;
            this.cmb_supervisor._tabla_cargar_combo = null;
            this.cmb_supervisor._tabla_cargar_condicion = null;
            this.cmb_supervisor._tabla_cargar_descriptor = null;
            this.cmb_supervisor._tabla_cargar_fk = null;
            this.cmb_supervisor._tabla_cargar_pk = null;
            this.cmb_supervisor._tabla_cargar_relacion = null;
            this.cmb_supervisor._tabla_cargar_relacion_pk = null;
            this.cmb_supervisor.FormattingEnabled = true;
            this.cmb_supervisor.Location = new System.Drawing.Point(206, 81);
            this.cmb_supervisor.Name = "cmb_supervisor";
            this.cmb_supervisor.Pp_conseleccion = false;
            this.cmb_supervisor.Pp_Descripcion = "Nombre";
            this.cmb_supervisor.Pp_MessageError = "Esta mal";
            this.cmb_supervisor.Pp_Pk = "ID_empleado";
            this.cmb_supervisor.Pp_Tabla = "empleados";
            this.cmb_supervisor.Size = new System.Drawing.Size(202, 21);
            this.cmb_supervisor.TabIndex = 71;
            this.cmb_supervisor.validable = false;
            // 
            // Modificar_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(435, 207);
            this.Controls.Add(this.txt_nombre_sucursal);
            this.Controls.Add(this.cmb_supervisor_suplente);
            this.Controls.Add(this.cmb_supervisor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificar_Sucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Sucursal";
            this.Load += new System.EventHandler(this.Modificar_Sucursales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private Back_end.ComboBox01 cmb_supervisor;
        private Back_end.ComboBox01 cmb_supervisor_suplente;
        private Back_end.TextBox01 txt_nombre_sucursal;
    }
}