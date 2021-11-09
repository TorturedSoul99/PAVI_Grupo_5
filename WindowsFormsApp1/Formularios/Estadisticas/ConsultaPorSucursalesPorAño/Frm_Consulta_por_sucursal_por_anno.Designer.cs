
namespace WindowsFormsApp1.Formularios.Estadisticas.ConsultaPorSucursalesPorAño
{
    partial class Frm_Consulta_por_sucursal_por_anno
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rv_consulta_sucursal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.txt_Anno_Desde = new System.Windows.Forms.MaskedTextBox();
            this.txt_ano_sucu = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mes_sucu = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mes_sucu_hasta = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rp_sucu1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_consulta22222 = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Anno_Desde);
            this.tabPage1.Controls.Add(this.btn_consultar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rv_consulta_sucursal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(806, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultas por Sucursales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_consulta22222);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.rp_sucu1);
            this.tabPage2.Controls.Add(this.txt_mes_sucu_hasta);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_mes_sucu);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_ano_sucu);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta por Sucursales por Mes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rv_consulta_sucursal
            // 
            this.rv_consulta_sucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_consulta_sucursal.Location = new System.Drawing.Point(6, 55);
            this.rv_consulta_sucursal.Name = "rv_consulta_sucursal";
            this.rv_consulta_sucursal.ServerReport.BearerToken = null;
            this.rv_consulta_sucursal.Size = new System.Drawing.Size(794, 338);
            this.rv_consulta_sucursal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultas de Sucursales En un Año \r\n";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(250, 13);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 6;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // txt_Anno_Desde
            // 
            this.txt_Anno_Desde.Location = new System.Drawing.Point(48, 13);
            this.txt_Anno_Desde.Mask = "9999";
            this.txt_Anno_Desde.Name = "txt_Anno_Desde";
            this.txt_Anno_Desde.Size = new System.Drawing.Size(100, 20);
            this.txt_Anno_Desde.TabIndex = 8;
            // 
            // txt_ano_sucu
            // 
            this.txt_ano_sucu.Location = new System.Drawing.Point(48, 14);
            this.txt_ano_sucu.Mask = "9999";
            this.txt_ano_sucu.Name = "txt_ano_sucu";
            this.txt_ano_sucu.Size = new System.Drawing.Size(100, 20);
            this.txt_ano_sucu.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Año";
            // 
            // txt_mes_sucu
            // 
            this.txt_mes_sucu.Location = new System.Drawing.Point(122, 56);
            this.txt_mes_sucu.Mask = "99";
            this.txt_mes_sucu.Name = "txt_mes_sucu";
            this.txt_mes_sucu.Size = new System.Drawing.Size(100, 20);
            this.txt_mes_sucu.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Desde";
            // 
            // txt_mes_sucu_hasta
            // 
            this.txt_mes_sucu_hasta.Location = new System.Drawing.Point(292, 56);
            this.txt_mes_sucu_hasta.Mask = "99";
            this.txt_mes_sucu_hasta.Name = "txt_mes_sucu_hasta";
            this.txt_mes_sucu_hasta.Size = new System.Drawing.Size(100, 20);
            this.txt_mes_sucu_hasta.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hasta";
            // 
            // rp_sucu1
            // 
            this.rp_sucu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rp_sucu1.Location = new System.Drawing.Point(6, 85);
            this.rp_sucu1.Name = "rp_sucu1";
            this.rp_sucu1.ServerReport.BearerToken = null;
            this.rp_sucu1.Size = new System.Drawing.Size(794, 305);
            this.rp_sucu1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mes";
            // 
            // btn_consulta22222
            // 
            this.btn_consulta22222.Location = new System.Drawing.Point(465, 53);
            this.btn_consulta22222.Name = "btn_consulta22222";
            this.btn_consulta22222.Size = new System.Drawing.Size(75, 23);
            this.btn_consulta22222.TabIndex = 17;
            this.btn_consulta22222.Text = "Consultar";
            this.btn_consulta22222.UseVisualStyleBackColor = true;
            this.btn_consulta22222.Click += new System.EventHandler(this.btn_consulta22222_Click);
            // 
            // Frm_Consulta_por_sucursal_por_anno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Consulta_por_sucursal_por_anno";
            this.Text = "Frm_Consulta_por_sucursal_por_anno";
            this.Load += new System.EventHandler(this.Frm_Consulta_por_sucursal_por_anno_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer rv_consulta_sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.MaskedTextBox txt_Anno_Desde;
        private Microsoft.Reporting.WinForms.ReportViewer rp_sucu1;
        private System.Windows.Forms.MaskedTextBox txt_mes_sucu_hasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_mes_sucu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_ano_sucu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_consulta22222;
    }
}