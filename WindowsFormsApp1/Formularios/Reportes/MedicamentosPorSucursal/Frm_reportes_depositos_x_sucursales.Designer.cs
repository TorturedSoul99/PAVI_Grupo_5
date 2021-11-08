
namespace WindowsFormsApp1.Formularios.Reportes.MedicamentosPorSucursal
{
    partial class Frm_reportes_depositos_x_sucursales
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
            this.rv_deposito_x_sucursales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar01 = new System.Windows.Forms.Button();
            this.lbl_sucursal = new System.Windows.Forms.Label();
            this.cmb_medicamentos = new WindowsFormsApp1.Back_end.ComboBox01();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv_deposito_x_sucursales);
            this.tabPage1.Controls.Add(this.btn_buscar01);
            this.tabPage1.Controls.Add(this.lbl_sucursal);
            this.tabPage1.Controls.Add(this.cmb_medicamentos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Depositos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rv_deposito_x_sucursales
            // 
            this.rv_deposito_x_sucursales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_deposito_x_sucursales.Location = new System.Drawing.Point(6, 74);
            this.rv_deposito_x_sucursales.Name = "rv_deposito_x_sucursales";
            this.rv_deposito_x_sucursales.ServerReport.BearerToken = null;
            this.rv_deposito_x_sucursales.Size = new System.Drawing.Size(765, 256);
            this.rv_deposito_x_sucursales.TabIndex = 3;
            // 
            // btn_buscar01
            // 
            this.btn_buscar01.Location = new System.Drawing.Point(372, 16);
            this.btn_buscar01.Name = "btn_buscar01";
            this.btn_buscar01.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar01.TabIndex = 2;
            this.btn_buscar01.Text = "Buscar";
            this.btn_buscar01.UseVisualStyleBackColor = true;
            this.btn_buscar01.Click += new System.EventHandler(this.btn_buscar01_Click);
            // 
            // lbl_sucursal
            // 
            this.lbl_sucursal.AutoSize = true;
            this.lbl_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sucursal.Location = new System.Drawing.Point(110, 16);
            this.lbl_sucursal.Name = "lbl_sucursal";
            this.lbl_sucursal.Size = new System.Drawing.Size(63, 17);
            this.lbl_sucursal.TabIndex = 1;
            this.lbl_sucursal.Text = "Sucursal";
            // 
            // cmb_medicamentos
            // 
            this.cmb_medicamentos._ComboSinSeleccion = false;
            this.cmb_medicamentos._tabla_cargar_combo = null;
            this.cmb_medicamentos._tabla_cargar_condicion = null;
            this.cmb_medicamentos._tabla_cargar_descriptor = null;
            this.cmb_medicamentos._tabla_cargar_fk = null;
            this.cmb_medicamentos._tabla_cargar_pk = null;
            this.cmb_medicamentos._tabla_cargar_relacion = null;
            this.cmb_medicamentos._tabla_cargar_relacion_pk = null;
            this.cmb_medicamentos.FormattingEnabled = true;
            this.cmb_medicamentos.Location = new System.Drawing.Point(179, 16);
            this.cmb_medicamentos.Name = "cmb_medicamentos";
            this.cmb_medicamentos.Pp_conseleccion = false;
            this.cmb_medicamentos.Pp_Descripcion = "Nombre_sucursal";
            this.cmb_medicamentos.Pp_MessageError = null;
            this.cmb_medicamentos.Pp_Pk = "ID_sucursal";
            this.cmb_medicamentos.Pp_Tabla = "sucursal";
            this.cmb_medicamentos.Size = new System.Drawing.Size(150, 21);
            this.cmb_medicamentos.TabIndex = 0;
            this.cmb_medicamentos.validable = false;
            // 
            // Frm_reportes_depositos_x_sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 460);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_reportes_depositos_x_sucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de depositos por sucursales";
            this.Load += new System.EventHandler(this.Frm_reportes_depositos_x_sucursales_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Back_end.ComboBox01 cmb_medicamentos;
        private System.Windows.Forms.Label lbl_sucursal;
        private System.Windows.Forms.Button btn_buscar01;
        private Microsoft.Reporting.WinForms.ReportViewer rv_deposito_x_sucursales;
    }
}