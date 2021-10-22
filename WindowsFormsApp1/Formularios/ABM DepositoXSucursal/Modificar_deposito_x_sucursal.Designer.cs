
namespace WindowsFormsApp1.Formularios.ABM_DepositoXSucursal
{
    partial class Modificar_deposito_x_sucursal
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
            this.lbl_stock_actual = new System.Windows.Forms.Label();
            this.lbl_ID_sucursal = new System.Windows.Forms.Label();
            this.lbl_minimo_stock = new System.Windows.Forms.Label();
            this.lbl_ID_Medicamento = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.cmb_id_sucursal = new WindowsFormsApp1.Back_end.ComboBox01();
            this.cmb_id_medicamento = new WindowsFormsApp1.Back_end.ComboBox01();
            this.txt_stock_actual = new WindowsFormsApp1.Back_end.TextBox01();
            this.txt_minimo_stock = new WindowsFormsApp1.Back_end.TextBox01();
            this.SuspendLayout();
            // 
            // lbl_stock_actual
            // 
            this.lbl_stock_actual.AutoSize = true;
            this.lbl_stock_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_actual.Location = new System.Drawing.Point(67, 231);
            this.lbl_stock_actual.Name = "lbl_stock_actual";
            this.lbl_stock_actual.Size = new System.Drawing.Size(99, 20);
            this.lbl_stock_actual.TabIndex = 13;
            this.lbl_stock_actual.Text = "Stock Actual";
            // 
            // lbl_ID_sucursal
            // 
            this.lbl_ID_sucursal.AutoSize = true;
            this.lbl_ID_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_sucursal.Location = new System.Drawing.Point(74, 132);
            this.lbl_ID_sucursal.Name = "lbl_ID_sucursal";
            this.lbl_ID_sucursal.Size = new System.Drawing.Size(92, 20);
            this.lbl_ID_sucursal.TabIndex = 12;
            this.lbl_ID_sucursal.Text = "ID Sucursal";
            // 
            // lbl_minimo_stock
            // 
            this.lbl_minimo_stock.AutoSize = true;
            this.lbl_minimo_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimo_stock.Location = new System.Drawing.Point(62, 180);
            this.lbl_minimo_stock.Name = "lbl_minimo_stock";
            this.lbl_minimo_stock.Size = new System.Drawing.Size(104, 20);
            this.lbl_minimo_stock.TabIndex = 11;
            this.lbl_minimo_stock.Text = "Minimo Stock";
            // 
            // lbl_ID_Medicamento
            // 
            this.lbl_ID_Medicamento.AutoSize = true;
            this.lbl_ID_Medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_Medicamento.Location = new System.Drawing.Point(40, 79);
            this.lbl_ID_Medicamento.Name = "lbl_ID_Medicamento";
            this.lbl_ID_Medicamento.Size = new System.Drawing.Size(126, 20);
            this.lbl_ID_Medicamento.TabIndex = 10;
            this.lbl_ID_Medicamento.Text = "ID Medicamento";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(275, 285);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(81, 27);
            this.btn_modificar.TabIndex = 9;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cmb_id_sucursal
            // 
            this.cmb_id_sucursal._ComboSinSeleccion = false;
            this.cmb_id_sucursal._tabla_cargar_combo = null;
            this.cmb_id_sucursal._tabla_cargar_condicion = null;
            this.cmb_id_sucursal._tabla_cargar_descriptor = null;
            this.cmb_id_sucursal._tabla_cargar_fk = null;
            this.cmb_id_sucursal._tabla_cargar_pk = null;
            this.cmb_id_sucursal._tabla_cargar_relacion = null;
            this.cmb_id_sucursal._tabla_cargar_relacion_pk = null;
            this.cmb_id_sucursal.FormattingEnabled = true;
            this.cmb_id_sucursal.Location = new System.Drawing.Point(172, 132);
            this.cmb_id_sucursal.Name = "cmb_id_sucursal";
            this.cmb_id_sucursal.Pp_conseleccion = false;
            this.cmb_id_sucursal.Pp_Descripcion = "Nombre_sucursal";
            this.cmb_id_sucursal.Pp_MessageError = null;
            this.cmb_id_sucursal.Pp_Pk = "ID_sucursal";
            this.cmb_id_sucursal.Pp_Tabla = "sucursal";
            this.cmb_id_sucursal.Size = new System.Drawing.Size(198, 21);
            this.cmb_id_sucursal.TabIndex = 19;
            this.cmb_id_sucursal.validable = false;
            // 
            // cmb_id_medicamento
            // 
            this.cmb_id_medicamento._ComboSinSeleccion = false;
            this.cmb_id_medicamento._tabla_cargar_combo = null;
            this.cmb_id_medicamento._tabla_cargar_condicion = null;
            this.cmb_id_medicamento._tabla_cargar_descriptor = null;
            this.cmb_id_medicamento._tabla_cargar_fk = null;
            this.cmb_id_medicamento._tabla_cargar_pk = null;
            this.cmb_id_medicamento._tabla_cargar_relacion = null;
            this.cmb_id_medicamento._tabla_cargar_relacion_pk = null;
            this.cmb_id_medicamento.FormattingEnabled = true;
            this.cmb_id_medicamento.Location = new System.Drawing.Point(172, 79);
            this.cmb_id_medicamento.Name = "cmb_id_medicamento";
            this.cmb_id_medicamento.Pp_conseleccion = false;
            this.cmb_id_medicamento.Pp_Descripcion = "Nombre";
            this.cmb_id_medicamento.Pp_MessageError = null;
            this.cmb_id_medicamento.Pp_Pk = "ID_medicamento";
            this.cmb_id_medicamento.Pp_Tabla = "medicamentos";
            this.cmb_id_medicamento.Size = new System.Drawing.Size(198, 21);
            this.cmb_id_medicamento.TabIndex = 18;
            this.cmb_id_medicamento.validable = false;
            // 
            // txt_stock_actual
            // 
            this.txt_stock_actual.Location = new System.Drawing.Point(172, 233);
            this.txt_stock_actual.Name = "txt_stock_actual";
            this.txt_stock_actual.Pp_campo = "Stock_Actual";
            this.txt_stock_actual.Pp_MensajeError = "No ingreso stock actual";
            this.txt_stock_actual.Pp_tabla = "deposito_x_sucursal";
            this.txt_stock_actual.Pp_Validable = false;
            this.txt_stock_actual.Size = new System.Drawing.Size(198, 20);
            this.txt_stock_actual.TabIndex = 17;
            // 
            // txt_minimo_stock
            // 
            this.txt_minimo_stock.Location = new System.Drawing.Point(172, 182);
            this.txt_minimo_stock.Name = "txt_minimo_stock";
            this.txt_minimo_stock.Pp_campo = "Minimo_stock";
            this.txt_minimo_stock.Pp_MensajeError = "No ingreso el minimo stock";
            this.txt_minimo_stock.Pp_tabla = "deposito_x_sucursal";
            this.txt_minimo_stock.Pp_Validable = false;
            this.txt_minimo_stock.Size = new System.Drawing.Size(198, 20);
            this.txt_minimo_stock.TabIndex = 16;
            // 
            // Modificar_deposito_x_sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 339);
            this.Controls.Add(this.cmb_id_sucursal);
            this.Controls.Add(this.cmb_id_medicamento);
            this.Controls.Add(this.txt_stock_actual);
            this.Controls.Add(this.txt_minimo_stock);
            this.Controls.Add(this.lbl_stock_actual);
            this.Controls.Add(this.lbl_ID_sucursal);
            this.Controls.Add(this.lbl_minimo_stock);
            this.Controls.Add(this.lbl_ID_Medicamento);
            this.Controls.Add(this.btn_modificar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificar_deposito_x_sucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar_deposito_x_sucursal";
            this.Load += new System.EventHandler(this.Modificar_deposito_x_sucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_stock_actual;
        private System.Windows.Forms.Label lbl_ID_sucursal;
        private System.Windows.Forms.Label lbl_minimo_stock;
        private System.Windows.Forms.Label lbl_ID_Medicamento;
        private System.Windows.Forms.Button btn_modificar;
        private Back_end.TextBox01 txt_minimo_stock;
        private Back_end.TextBox01 txt_stock_actual;
        private Back_end.ComboBox01 cmb_id_medicamento;
        private Back_end.ComboBox01 cmb_id_sucursal;
    }
}