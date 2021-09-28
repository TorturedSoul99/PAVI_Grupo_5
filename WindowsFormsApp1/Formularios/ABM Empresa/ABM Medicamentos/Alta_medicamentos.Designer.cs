
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos
{
    partial class Alta_medicamentos
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
            this.dtp_fechaCompra = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_sucursal_medicamentos = new System.Windows.Forms.Label();
            this.lbl_fecha_compra = new System.Windows.Forms.Label();
            this.lbl_laboratorio_medicamento = new System.Windows.Forms.Label();
            this.lbl_nombre_medicamento = new System.Windows.Forms.Label();
            this.cmb_Sucursal = new WindowsFormsApp1.Back_end.ComboBox01();
            this.cmb_Laboratorio = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(288, 279);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(81, 27);
            this.btn_agregar.TabIndex = 25;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dtp_fechaCompra
            // 
            this.dtp_fechaCompra.Location = new System.Drawing.Point(169, 163);
            this.dtp_fechaCompra.Name = "dtp_fechaCompra";
            this.dtp_fechaCompra.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaCompra.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 20;
            // 
            // lbl_sucursal_medicamentos
            // 
            this.lbl_sucursal_medicamentos.AutoSize = true;
            this.lbl_sucursal_medicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sucursal_medicamentos.Location = new System.Drawing.Point(92, 211);
            this.lbl_sucursal_medicamentos.Name = "lbl_sucursal_medicamentos";
            this.lbl_sucursal_medicamentos.Size = new System.Drawing.Size(71, 20);
            this.lbl_sucursal_medicamentos.TabIndex = 16;
            this.lbl_sucursal_medicamentos.Text = "Sucursal";
            // 
            // lbl_fecha_compra
            // 
            this.lbl_fecha_compra.AutoSize = true;
            this.lbl_fecha_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_compra.Location = new System.Drawing.Point(30, 163);
            this.lbl_fecha_compra.Name = "lbl_fecha_compra";
            this.lbl_fecha_compra.Size = new System.Drawing.Size(133, 20);
            this.lbl_fecha_compra.TabIndex = 15;
            this.lbl_fecha_compra.Text = "Fecha de compra";
            // 
            // lbl_laboratorio_medicamento
            // 
            this.lbl_laboratorio_medicamento.AutoSize = true;
            this.lbl_laboratorio_medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laboratorio_medicamento.Location = new System.Drawing.Point(73, 113);
            this.lbl_laboratorio_medicamento.Name = "lbl_laboratorio_medicamento";
            this.lbl_laboratorio_medicamento.Size = new System.Drawing.Size(90, 20);
            this.lbl_laboratorio_medicamento.TabIndex = 14;
            this.lbl_laboratorio_medicamento.Text = "Laboratorio";
            // 
            // lbl_nombre_medicamento
            // 
            this.lbl_nombre_medicamento.AutoSize = true;
            this.lbl_nombre_medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_medicamento.Location = new System.Drawing.Point(98, 60);
            this.lbl_nombre_medicamento.Name = "lbl_nombre_medicamento";
            this.lbl_nombre_medicamento.Size = new System.Drawing.Size(65, 20);
            this.lbl_nombre_medicamento.TabIndex = 13;
            this.lbl_nombre_medicamento.Text = "Nombre";
            // 
            // cmb_Sucursal
            // 
            this.cmb_Sucursal.FormattingEnabled = true;
            this.cmb_Sucursal.Location = new System.Drawing.Point(170, 209);
            this.cmb_Sucursal.Name = "cmb_Sucursal";
            this.cmb_Sucursal.Pp_conseleccion = false;
            this.cmb_Sucursal.Pp_Descripcion = "Nombre_sucursal";
            this.cmb_Sucursal.Pp_MessageError = "Esta mal";
            this.cmb_Sucursal.Pp_Pk = "ID_sucursal";
            this.cmb_Sucursal.Pp_Tabla = "sucursal";
            this.cmb_Sucursal.Size = new System.Drawing.Size(199, 21);
            this.cmb_Sucursal.TabIndex = 27;
            this.cmb_Sucursal.validable = false;
            // 
            // cmb_Laboratorio
            // 
            this.cmb_Laboratorio.FormattingEnabled = true;
            this.cmb_Laboratorio.Location = new System.Drawing.Point(170, 111);
            this.cmb_Laboratorio.Name = "cmb_Laboratorio";
            this.cmb_Laboratorio.Pp_conseleccion = false;
            this.cmb_Laboratorio.Pp_Descripcion = "Nombre";
            this.cmb_Laboratorio.Pp_MessageError = "Esta mal";
            this.cmb_Laboratorio.Pp_Pk = "ID_laboratorio";
            this.cmb_Laboratorio.Pp_Tabla = "laboratorios";
            this.cmb_Laboratorio.Size = new System.Drawing.Size(199, 21);
            this.cmb_Laboratorio.TabIndex = 26;
            this.cmb_Laboratorio.validable = false;
            // 
            // Alta_medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 324);
            this.Controls.Add(this.cmb_Sucursal);
            this.Controls.Add(this.cmb_Laboratorio);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dtp_fechaCompra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_sucursal_medicamentos);
            this.Controls.Add(this.lbl_fecha_compra);
            this.Controls.Add(this.lbl_laboratorio_medicamento);
            this.Controls.Add(this.lbl_nombre_medicamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta_medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Medicamentos";
            this.Load += new System.EventHandler(this.Alta_medicamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DateTimePicker dtp_fechaCompra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_sucursal_medicamentos;
        private System.Windows.Forms.Label lbl_fecha_compra;
        private System.Windows.Forms.Label lbl_laboratorio_medicamento;
        private System.Windows.Forms.Label lbl_nombre_medicamento;
        private Back_end.ComboBox01 cmb_Laboratorio;
        private Back_end.ComboBox01 cmb_Sucursal;
    }
}