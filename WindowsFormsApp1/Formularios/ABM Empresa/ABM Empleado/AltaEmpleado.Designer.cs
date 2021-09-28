
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado
{
    partial class AltaEmpleado
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
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblE4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbltipoDoc = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.cmb_Sucursales = new WindowsFormsApp1.Back_end.ComboBox01();
            this.txt_ApellidoEmpleado = new WindowsFormsApp1.Back_end.TextBox01();
            this.txt_NombreEmpleado = new WindowsFormsApp1.Back_end.TextBox01();
            this.txt_NroDocumento = new WindowsFormsApp1.Back_end.TextBox01();
            this.txt_tipoDocumento = new WindowsFormsApp1.Back_end.TextBox01();
            this.SuspendLayout();
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(139, 342);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(73, 20);
            this.lbl7.TabIndex = 32;
            this.lbl7.Text = "Matricula";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(127, 305);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(85, 20);
            this.lbl6.TabIndex = 31;
            this.lbl6.Text = "IdSucursal";
            // 
            // lblE4
            // 
            this.lblE4.AutoSize = true;
            this.lblE4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE4.Location = new System.Drawing.Point(75, 222);
            this.lblE4.Name = "lblE4";
            this.lblE4.Size = new System.Drawing.Size(137, 20);
            this.lblE4.TabIndex = 30;
            this.lblE4.Text = "Fecha Nacimiento";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(80, 264);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(132, 20);
            this.lbl5.TabIndex = 29;
            this.lbl5.Text = "Fecha de ingreso";
            this.lbl5.Click += new System.EventHandler(this.lblDiagnostico_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(147, 180);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(65, 20);
            this.lbl3.TabIndex = 28;
            this.lbl3.Text = "Apellido";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(147, 142);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 20);
            this.lbl2.TabIndex = 27;
            this.lbl2.Text = "Nombre";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(41, 98);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(171, 20);
            this.lbl1.TabIndex = 26;
            this.lbl1.Text = "Numero de documento";
            // 
            // lbltipoDoc
            // 
            this.lbltipoDoc.AutoSize = true;
            this.lbltipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoDoc.Location = new System.Drawing.Point(86, 60);
            this.lbltipoDoc.Name = "lbltipoDoc";
            this.lbltipoDoc.Size = new System.Drawing.Size(126, 20);
            this.lbltipoDoc.TabIndex = 24;
            this.lbltipoDoc.Text = "Tipo Documento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(381, 410);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(218, 264);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaIngreso.TabIndex = 42;
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(218, 222);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaNacimiento.TabIndex = 43;
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(219, 341);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(199, 20);
            this.txt_Matricula.TabIndex = 48;
            // 
            // cmb_Sucursales
            // 
            this.cmb_Sucursales.FormattingEnabled = true;
            this.cmb_Sucursales.Location = new System.Drawing.Point(219, 303);
            this.cmb_Sucursales.Name = "cmb_Sucursales";
            this.cmb_Sucursales.Pp_conseleccion = false;
            this.cmb_Sucursales.Pp_Descripcion = "Nombre_sucursal";
            this.cmb_Sucursales.Pp_MessageError = "Esta mal";
            this.cmb_Sucursales.Pp_Pk = "ID_sucursal";
            this.cmb_Sucursales.Pp_Tabla = "sucursal";
            this.cmb_Sucursales.Size = new System.Drawing.Size(199, 21);
            this.cmb_Sucursales.TabIndex = 49;
            this.cmb_Sucursales.validable = false;
            // 
            // txt_ApellidoEmpleado
            // 
            this.txt_ApellidoEmpleado.Location = new System.Drawing.Point(219, 179);
            this.txt_ApellidoEmpleado.Name = "txt_ApellidoEmpleado";
            this.txt_ApellidoEmpleado.Pp_campo = null;
            this.txt_ApellidoEmpleado.Pp_MensajeError = "No se ingreso el Apellido del Empleado ";
            this.txt_ApellidoEmpleado.Pp_tabla = null;
            this.txt_ApellidoEmpleado.Pp_Validable = false;
            this.txt_ApellidoEmpleado.Size = new System.Drawing.Size(199, 20);
            this.txt_ApellidoEmpleado.TabIndex = 47;
            // 
            // txt_NombreEmpleado
            // 
            this.txt_NombreEmpleado.Location = new System.Drawing.Point(218, 142);
            this.txt_NombreEmpleado.Name = "txt_NombreEmpleado";
            this.txt_NombreEmpleado.Pp_campo = "Nombre";
            this.txt_NombreEmpleado.Pp_MensajeError = "No se Ingreso un nombre de Empleado";
            this.txt_NombreEmpleado.Pp_tabla = null;
            this.txt_NombreEmpleado.Pp_Validable = false;
            this.txt_NombreEmpleado.Size = new System.Drawing.Size(200, 20);
            this.txt_NombreEmpleado.TabIndex = 46;
            // 
            // txt_NroDocumento
            // 
            this.txt_NroDocumento.Location = new System.Drawing.Point(219, 97);
            this.txt_NroDocumento.Name = "txt_NroDocumento";
            this.txt_NroDocumento.Pp_campo = "Nro_documento";
            this.txt_NroDocumento.Pp_MensajeError = "No se Ingreso un numero de Documento";
            this.txt_NroDocumento.Pp_tabla = null;
            this.txt_NroDocumento.Pp_Validable = false;
            this.txt_NroDocumento.Size = new System.Drawing.Size(201, 20);
            this.txt_NroDocumento.TabIndex = 45;
            // 
            // txt_tipoDocumento
            // 
            this.txt_tipoDocumento.Location = new System.Drawing.Point(219, 60);
            this.txt_tipoDocumento.Name = "txt_tipoDocumento";
            this.txt_tipoDocumento.Pp_campo = "Tipo_documento";
            this.txt_tipoDocumento.Pp_MensajeError = "No se ingreso un Tipo de Documento";
            this.txt_tipoDocumento.Pp_tabla = null;
            this.txt_tipoDocumento.Pp_Validable = true;
            this.txt_tipoDocumento.Size = new System.Drawing.Size(199, 20);
            this.txt_tipoDocumento.TabIndex = 44;
            // 
            // AltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(491, 469);
            this.Controls.Add(this.cmb_Sucursales);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.txt_ApellidoEmpleado);
            this.Controls.Add(this.txt_NombreEmpleado);
            this.Controls.Add(this.txt_NroDocumento);
            this.Controls.Add(this.txt_tipoDocumento);
            this.Controls.Add(this.dtp_FechaNacimiento);
            this.Controls.Add(this.dtp_FechaIngreso);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblE4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbltipoDoc);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Empleado";
            this.Load += new System.EventHandler(this.AltaEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblE4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbltipoDoc;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtp_FechaIngreso;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private Back_end.TextBox01 txt_tipoDocumento;
        private Back_end.TextBox01 txt_NroDocumento;
        private Back_end.TextBox01 txt_NombreEmpleado;
        private Back_end.TextBox01 txt_ApellidoEmpleado;
        private System.Windows.Forms.TextBox txt_Matricula;
        private Back_end.ComboBox01 cmb_Sucursales;
    }
}