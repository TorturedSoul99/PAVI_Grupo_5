
namespace WindowsFormsApp1.Formularios.Reportes.Reporte_peso_altura_x_raza
{
    partial class Reporte_empleado
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_anno = new System.Windows.Forms.TextBox();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb_sucursales = new WindowsFormsApp1.Back_end.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar_sucu = new System.Windows.Forms.Button();
            this.RV_empleado_x_sucursal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_anno);
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_calcular);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de empleados pòr año";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_anno
            // 
            this.txt_anno.Location = new System.Drawing.Point(95, 15);
            this.txt_anno.Name = "txt_anno";
            this.txt_anno.Size = new System.Drawing.Size(115, 20);
            this.txt_anno.TabIndex = 4;
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(6, 85);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(899, 310);
            this.rv01.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(300, 15);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Buscar";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RV_empleado_x_sucursal);
            this.tabPage2.Controls.Add(this.btn_buscar_sucu);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmb_sucursales);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empleados por Sucursal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_sucursales
            // 
            this.cmb_sucursales._ComboSinSeleccion = false;
            this.cmb_sucursales._tabla_cargar_combo = null;
            this.cmb_sucursales._tabla_cargar_condicion = null;
            this.cmb_sucursales._tabla_cargar_descriptor = null;
            this.cmb_sucursales._tabla_cargar_fk = null;
            this.cmb_sucursales._tabla_cargar_pk = null;
            this.cmb_sucursales._tabla_cargar_relacion = null;
            this.cmb_sucursales._tabla_cargar_relacion_pk = null;
            this.cmb_sucursales.FormattingEnabled = true;
            this.cmb_sucursales.Location = new System.Drawing.Point(190, 22);
            this.cmb_sucursales.Name = "cmb_sucursales";
            this.cmb_sucursales.Pp_conseleccion = false;
            this.cmb_sucursales.Pp_Descripcion = "Nombre_sucursal";
            this.cmb_sucursales.Pp_MessageError = null;
            this.cmb_sucursales.Pp_Pk = "ID_sucursal";
            this.cmb_sucursales.Pp_Tabla = "sucursal";
            this.cmb_sucursales.Size = new System.Drawing.Size(166, 21);
            this.cmb_sucursales.TabIndex = 0;
            this.cmb_sucursales.validable = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sucursal";
            // 
            // btn_buscar_sucu
            // 
            this.btn_buscar_sucu.Location = new System.Drawing.Point(398, 23);
            this.btn_buscar_sucu.Name = "btn_buscar_sucu";
            this.btn_buscar_sucu.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_sucu.TabIndex = 2;
            this.btn_buscar_sucu.Text = "Buscar";
            this.btn_buscar_sucu.UseVisualStyleBackColor = true;
            this.btn_buscar_sucu.Click += new System.EventHandler(this.btn_buscar_sucu_Click);
            // 
            // RV_empleado_x_sucursal
            // 
            this.RV_empleado_x_sucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RV_empleado_x_sucursal.Location = new System.Drawing.Point(6, 52);
            this.RV_empleado_x_sucursal.Name = "RV_empleado_x_sucursal";
            this.RV_empleado_x_sucursal.ServerReport.BearerToken = null;
            this.RV_empleado_x_sucursal.Size = new System.Drawing.Size(912, 346);
            this.RV_empleado_x_sucursal.TabIndex = 3;
            // 
            // Reporte_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reporte_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Empleado";
            this.Load += new System.EventHandler(this.Reporte_empleado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_anno;
        private System.Windows.Forms.Button btn_buscar_sucu;
        private System.Windows.Forms.Label label2;
        private Back_end.ComboBox01 cmb_sucursales;
        private Microsoft.Reporting.WinForms.ReportViewer RV_empleado_x_sucursal;
    }
}