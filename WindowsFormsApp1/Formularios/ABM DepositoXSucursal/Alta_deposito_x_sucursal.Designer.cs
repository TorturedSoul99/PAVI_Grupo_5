
namespace WindowsFormsApp1.Formularios.ABM_DepositoXSucursal
{
    partial class Alta_deposito_x_sucursal
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
            this.lbl_ID_Medicamento = new System.Windows.Forms.Label();
            this.lbl_minimo_stock = new System.Windows.Forms.Label();
            this.lbl_ID_sucursal = new System.Windows.Forms.Label();
            this.lbl_stock_actual = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(298, 274);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(81, 27);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // lbl_ID_Medicamento
            // 
            this.lbl_ID_Medicamento.AutoSize = true;
            this.lbl_ID_Medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_Medicamento.Location = new System.Drawing.Point(63, 68);
            this.lbl_ID_Medicamento.Name = "lbl_ID_Medicamento";
            this.lbl_ID_Medicamento.Size = new System.Drawing.Size(126, 20);
            this.lbl_ID_Medicamento.TabIndex = 1;
            this.lbl_ID_Medicamento.Text = "ID Medicamento";
            // 
            // lbl_minimo_stock
            // 
            this.lbl_minimo_stock.AutoSize = true;
            this.lbl_minimo_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimo_stock.Location = new System.Drawing.Point(85, 169);
            this.lbl_minimo_stock.Name = "lbl_minimo_stock";
            this.lbl_minimo_stock.Size = new System.Drawing.Size(104, 20);
            this.lbl_minimo_stock.TabIndex = 2;
            this.lbl_minimo_stock.Text = "Minimo Stock";
            // 
            // lbl_ID_sucursal
            // 
            this.lbl_ID_sucursal.AutoSize = true;
            this.lbl_ID_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_sucursal.Location = new System.Drawing.Point(97, 121);
            this.lbl_ID_sucursal.Name = "lbl_ID_sucursal";
            this.lbl_ID_sucursal.Size = new System.Drawing.Size(92, 20);
            this.lbl_ID_sucursal.TabIndex = 3;
            this.lbl_ID_sucursal.Text = "ID Sucursal";
            // 
            // lbl_stock_actual
            // 
            this.lbl_stock_actual.AutoSize = true;
            this.lbl_stock_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_actual.Location = new System.Drawing.Point(90, 220);
            this.lbl_stock_actual.Name = "lbl_stock_actual";
            this.lbl_stock_actual.Size = new System.Drawing.Size(99, 20);
            this.lbl_stock_actual.TabIndex = 4;
            this.lbl_stock_actual.Text = "Stock Actual";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 20);
            this.textBox4.TabIndex = 8;
            // 
            // Alta_deposito_x_sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 332);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_stock_actual);
            this.Controls.Add(this.lbl_ID_sucursal);
            this.Controls.Add(this.lbl_minimo_stock);
            this.Controls.Add(this.lbl_ID_Medicamento);
            this.Controls.Add(this.btn_agregar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta_deposito_x_sucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta_deposito_x_sucursal";
            this.Load += new System.EventHandler(this.Alta_deposito_x_sucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_ID_Medicamento;
        private System.Windows.Forms.Label lbl_minimo_stock;
        private System.Windows.Forms.Label lbl_ID_sucursal;
        private System.Windows.Forms.Label lbl_stock_actual;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}