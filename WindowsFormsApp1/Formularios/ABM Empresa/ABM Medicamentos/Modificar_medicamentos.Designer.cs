
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos
{
    partial class Modificar_medicamentos
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dtp_fecha_compra = new System.Windows.Forms.DateTimePicker();
            this.txt_nombre_medicamento = new System.Windows.Forms.TextBox();
            this.lbl_sucursal_medicamentos = new System.Windows.Forms.Label();
            this.lbl_fecha_compra = new System.Windows.Forms.Label();
            this.lbl_laboratorio_medicamento = new System.Windows.Forms.Label();
            this.lbl_nombre_medicamento = new System.Windows.Forms.Label();
            this.cmb_lab_medic = new WindowsFormsApp1.Back_end.ComboBox01();
            this.cmb_sucu_medicamento = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(301, 255);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(81, 27);
            this.btn_agregar.TabIndex = 25;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dtp_fecha_compra
            // 
            this.dtp_fecha_compra.Location = new System.Drawing.Point(182, 141);
            this.dtp_fecha_compra.Name = "dtp_fecha_compra";
            this.dtp_fecha_compra.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_compra.TabIndex = 22;
            // 
            // txt_nombre_medicamento
            // 
            this.txt_nombre_medicamento.Location = new System.Drawing.Point(182, 38);
            this.txt_nombre_medicamento.Name = "txt_nombre_medicamento";
            this.txt_nombre_medicamento.Size = new System.Drawing.Size(200, 20);
            this.txt_nombre_medicamento.TabIndex = 20;
            // 
            // lbl_sucursal_medicamentos
            // 
            this.lbl_sucursal_medicamentos.AutoSize = true;
            this.lbl_sucursal_medicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sucursal_medicamentos.Location = new System.Drawing.Point(105, 189);
            this.lbl_sucursal_medicamentos.Name = "lbl_sucursal_medicamentos";
            this.lbl_sucursal_medicamentos.Size = new System.Drawing.Size(71, 20);
            this.lbl_sucursal_medicamentos.TabIndex = 16;
            this.lbl_sucursal_medicamentos.Text = "Sucursal";
            // 
            // lbl_fecha_compra
            // 
            this.lbl_fecha_compra.AutoSize = true;
            this.lbl_fecha_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_compra.Location = new System.Drawing.Point(43, 141);
            this.lbl_fecha_compra.Name = "lbl_fecha_compra";
            this.lbl_fecha_compra.Size = new System.Drawing.Size(133, 20);
            this.lbl_fecha_compra.TabIndex = 15;
            this.lbl_fecha_compra.Text = "Fecha de compra";
            // 
            // lbl_laboratorio_medicamento
            // 
            this.lbl_laboratorio_medicamento.AutoSize = true;
            this.lbl_laboratorio_medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laboratorio_medicamento.Location = new System.Drawing.Point(86, 91);
            this.lbl_laboratorio_medicamento.Name = "lbl_laboratorio_medicamento";
            this.lbl_laboratorio_medicamento.Size = new System.Drawing.Size(90, 20);
            this.lbl_laboratorio_medicamento.TabIndex = 14;
            this.lbl_laboratorio_medicamento.Text = "Laboratorio";
            // 
            // lbl_nombre_medicamento
            // 
            this.lbl_nombre_medicamento.AutoSize = true;
            this.lbl_nombre_medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_medicamento.Location = new System.Drawing.Point(111, 38);
            this.lbl_nombre_medicamento.Name = "lbl_nombre_medicamento";
            this.lbl_nombre_medicamento.Size = new System.Drawing.Size(65, 20);
            this.lbl_nombre_medicamento.TabIndex = 13;
            this.lbl_nombre_medicamento.Text = "Nombre";
            // 
            // cmb_lab_medic
            // 
            this.cmb_lab_medic.FormattingEnabled = true;
            this.cmb_lab_medic.Location = new System.Drawing.Point(183, 89);
            this.cmb_lab_medic.Name = "cmb_lab_medic";
            this.cmb_lab_medic.Pp_conseleccion = false;
            this.cmb_lab_medic.Pp_Descripcion = "Nombre";
            this.cmb_lab_medic.Pp_MessageError = null;
            this.cmb_lab_medic.Pp_Pk = "ID_laboratorio";
            this.cmb_lab_medic.Pp_Tabla = "laboratorios";
            this.cmb_lab_medic.Size = new System.Drawing.Size(199, 21);
            this.cmb_lab_medic.TabIndex = 26;
            this.cmb_lab_medic.validable = false;
            // 
            // cmb_sucu_medicamento
            // 
            this.cmb_sucu_medicamento.FormattingEnabled = true;
            this.cmb_sucu_medicamento.Location = new System.Drawing.Point(182, 189);
            this.cmb_sucu_medicamento.Name = "cmb_sucu_medicamento";
            this.cmb_sucu_medicamento.Pp_conseleccion = false;
            this.cmb_sucu_medicamento.Pp_Descripcion = "Nombre_sucursal";
            this.cmb_sucu_medicamento.Pp_MessageError = null;
            this.cmb_sucu_medicamento.Pp_Pk = "ID_sucursal";
            this.cmb_sucu_medicamento.Pp_Tabla = "sucursal";
            this.cmb_sucu_medicamento.Size = new System.Drawing.Size(200, 21);
            this.cmb_sucu_medicamento.TabIndex = 27;
            this.cmb_sucu_medicamento.validable = false;
            // 
            // Modificar_medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 310);
            this.Controls.Add(this.cmb_sucu_medicamento);
            this.Controls.Add(this.cmb_lab_medic);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dtp_fecha_compra);
            this.Controls.Add(this.txt_nombre_medicamento);
            this.Controls.Add(this.lbl_sucursal_medicamentos);
            this.Controls.Add(this.lbl_fecha_compra);
            this.Controls.Add(this.lbl_laboratorio_medicamento);
            this.Controls.Add(this.lbl_nombre_medicamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modificar_medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Medicamentos";
            this.Load += new System.EventHandler(this.Modificar_medicamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DateTimePicker dtp_fecha_compra;
        private System.Windows.Forms.TextBox txt_nombre_medicamento;
        private System.Windows.Forms.Label lbl_sucursal_medicamentos;
        private System.Windows.Forms.Label lbl_fecha_compra;
        private System.Windows.Forms.Label lbl_laboratorio_medicamento;
        private System.Windows.Forms.Label lbl_nombre_medicamento;
        private Back_end.ComboBox01 cmb_lab_medic;
        private Back_end.ComboBox01 cmb_sucu_medicamento;
    }
}