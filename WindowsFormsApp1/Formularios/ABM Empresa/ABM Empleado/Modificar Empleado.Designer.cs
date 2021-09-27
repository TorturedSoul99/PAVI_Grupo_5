
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado
{
    partial class Modificar_Empleado
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
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_nroDoc = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblE4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbltipoDoc = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_tipoDoc = new System.Windows.Forms.TextBox();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.cmb_IDSucursal = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(193, 241);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaNacimiento.TabIndex = 60;
            this.dtp_FechaNacimiento.Value = new System.DateTime(2001, 9, 27, 19, 10, 0, 0);
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(193, 283);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaIngreso.TabIndex = 59;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(193, 199);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(202, 20);
            this.txt_Apellido.TabIndex = 58;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(193, 161);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(202, 20);
            this.txt_Nombre.TabIndex = 57;
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Location = new System.Drawing.Point(193, 117);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(202, 20);
            this.txt_nroDoc.TabIndex = 56;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(114, 361);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(73, 20);
            this.lbl7.TabIndex = 53;
            this.lbl7.Text = "Matricula";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(102, 324);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(85, 20);
            this.lbl6.TabIndex = 52;
            this.lbl6.Text = "IdSucursal";
            // 
            // lblE4
            // 
            this.lblE4.AutoSize = true;
            this.lblE4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE4.Location = new System.Drawing.Point(50, 241);
            this.lblE4.Name = "lblE4";
            this.lblE4.Size = new System.Drawing.Size(137, 20);
            this.lblE4.TabIndex = 51;
            this.lblE4.Text = "Fecha Nacimiento";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(55, 283);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(132, 20);
            this.lbl5.TabIndex = 50;
            this.lbl5.Text = "Fecha de ingreso";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(122, 199);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(65, 20);
            this.lbl3.TabIndex = 49;
            this.lbl3.Text = "Apellido";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(122, 161);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 20);
            this.lbl2.TabIndex = 48;
            this.lbl2.Text = "Nombre";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(16, 117);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(171, 20);
            this.lbl1.TabIndex = 47;
            this.lbl1.Text = "Numero de documento";
            // 
            // lbltipoDoc
            // 
            this.lbltipoDoc.AutoSize = true;
            this.lbltipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoDoc.Location = new System.Drawing.Point(61, 78);
            this.lbltipoDoc.Name = "lbltipoDoc";
            this.lbltipoDoc.Size = new System.Drawing.Size(126, 20);
            this.lbltipoDoc.TabIndex = 46;
            this.lbltipoDoc.Text = "Tipo Documento";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(244, 429);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(187, 23);
            this.btn_aceptar.TabIndex = 44;
            this.btn_aceptar.Text = "Aceptar Modificacion Cliente";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_tipoDoc
            // 
            this.txt_tipoDoc.Location = new System.Drawing.Point(194, 77);
            this.txt_tipoDoc.Name = "txt_tipoDoc";
            this.txt_tipoDoc.Size = new System.Drawing.Size(199, 20);
            this.txt_tipoDoc.TabIndex = 61;
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(194, 360);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(199, 20);
            this.txt_Matricula.TabIndex = 62;
            // 
            // cmb_IDSucursal
            // 
            this.cmb_IDSucursal.FormattingEnabled = true;
            this.cmb_IDSucursal.Location = new System.Drawing.Point(194, 322);
            this.cmb_IDSucursal.Name = "cmb_IDSucursal";
            this.cmb_IDSucursal.Pp_conseleccion = false;
            this.cmb_IDSucursal.Pp_Descripcion = "Nombre_sucursal";
            this.cmb_IDSucursal.Pp_MessageError = null;
            this.cmb_IDSucursal.Pp_Pk = "ID_sucursal";
            this.cmb_IDSucursal.Pp_Tabla = "sucursal";
            this.cmb_IDSucursal.Size = new System.Drawing.Size(199, 21);
            this.cmb_IDSucursal.TabIndex = 63;
            this.cmb_IDSucursal.validable = false;
            // 
            // Modificar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(477, 476);
            this.Controls.Add(this.cmb_IDSucursal);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.txt_tipoDoc);
            this.Controls.Add(this.dtp_FechaNacimiento);
            this.Controls.Add(this.dtp_FechaIngreso);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblE4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbltipoDoc);
            this.Controls.Add(this.btn_aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificar_Empleado";
            this.Text = "Modificar Empleado";
            this.Load += new System.EventHandler(this.Modificar_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtp_FechaIngreso;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_nroDoc;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblE4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbltipoDoc;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_tipoDoc;
        private System.Windows.Forms.TextBox txt_Matricula;
        private Back_end.ComboBox01 cmb_IDSucursal;
    }
}