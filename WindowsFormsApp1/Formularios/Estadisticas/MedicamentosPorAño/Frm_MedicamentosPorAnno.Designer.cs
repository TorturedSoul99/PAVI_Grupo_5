
namespace WindowsFormsApp1.Formularios.Estadisticas.MedicamentosPorAño
{
    partial class Frm_MedicamentosPorAnno
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
            this.txt_Anno_Hasta = new System.Windows.Forms.MaskedTextBox();
            this.txt_Anno_Desde = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.rp_medicamentos_Anno = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_año = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_consultar_medicamentosXmes = new System.Windows.Forms.Button();
            this.rv_medicamentos_por_mes = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.tabControl1.Location = new System.Drawing.Point(-1, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Anno_Hasta);
            this.tabPage1.Controls.Add(this.txt_Anno_Desde);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_Consultar);
            this.tabPage1.Controls.Add(this.rp_medicamentos_Anno);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medicamentos por Año";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_Anno_Hasta
            // 
            this.txt_Anno_Hasta.Location = new System.Drawing.Point(266, 25);
            this.txt_Anno_Hasta.Mask = "9999";
            this.txt_Anno_Hasta.Name = "txt_Anno_Hasta";
            this.txt_Anno_Hasta.Size = new System.Drawing.Size(100, 20);
            this.txt_Anno_Hasta.TabIndex = 8;
            // 
            // txt_Anno_Desde
            // 
            this.txt_Anno_Desde.Location = new System.Drawing.Point(112, 25);
            this.txt_Anno_Desde.Mask = "9999";
            this.txt_Anno_Desde.Name = "txt_Anno_Desde";
            this.txt_Anno_Desde.Size = new System.Drawing.Size(100, 20);
            this.txt_Anno_Desde.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.Location = new System.Drawing.Point(604, 25);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 1;
            this.btn_Consultar.Text = "Calcular";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // rp_medicamentos_Anno
            // 
            this.rp_medicamentos_Anno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rp_medicamentos_Anno.DocumentMapWidth = 90;
            this.rp_medicamentos_Anno.Location = new System.Drawing.Point(9, 56);
            this.rp_medicamentos_Anno.Name = "rp_medicamentos_Anno";
            this.rp_medicamentos_Anno.ServerReport.BearerToken = null;
            this.rp_medicamentos_Anno.Size = new System.Drawing.Size(927, 343);
            this.rp_medicamentos_Anno.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_año);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btn_consultar_medicamentosXmes);
            this.tabPage2.Controls.Add(this.rv_medicamentos_por_mes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(942, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medicamentos por mes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estadisticas de Medicamentos";
            // 
            // txt_año
            // 
            this.txt_año.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_año.Location = new System.Drawing.Point(189, 17);
            this.txt_año.Mask = "9999";
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(50, 29);
            this.txt_año.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Año:";
            // 
            // btn_consultar_medicamentosXmes
            // 
            this.btn_consultar_medicamentosXmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_medicamentosXmes.Location = new System.Drawing.Point(257, 16);
            this.btn_consultar_medicamentosXmes.Name = "btn_consultar_medicamentosXmes";
            this.btn_consultar_medicamentosXmes.Size = new System.Drawing.Size(91, 35);
            this.btn_consultar_medicamentosXmes.TabIndex = 10;
            this.btn_consultar_medicamentosXmes.Text = "Calcular";
            this.btn_consultar_medicamentosXmes.UseVisualStyleBackColor = true;
            this.btn_consultar_medicamentosXmes.Click += new System.EventHandler(this.btn_consultar_medicamentosXmes_Click);
            // 
            // rv_medicamentos_por_mes
            // 
            this.rv_medicamentos_por_mes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_medicamentos_por_mes.DocumentMapWidth = 90;
            this.rv_medicamentos_por_mes.Location = new System.Drawing.Point(8, 56);
            this.rv_medicamentos_por_mes.Name = "rv_medicamentos_por_mes";
            this.rv_medicamentos_por_mes.ServerReport.BearerToken = null;
            this.rv_medicamentos_por_mes.Size = new System.Drawing.Size(927, 343);
            this.rv_medicamentos_por_mes.TabIndex = 9;
            // 
            // Frm_MedicamentosPorAnno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_MedicamentosPorAnno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas de medicamentos";
            this.Load += new System.EventHandler(this.Frm_MedicamentosPorAnno_Load);
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
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rp_medicamentos_Anno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.MaskedTextBox txt_Anno_Hasta;
        private System.Windows.Forms.MaskedTextBox txt_Anno_Desde;
        private System.Windows.Forms.MaskedTextBox txt_año;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_consultar_medicamentosXmes;
        private Microsoft.Reporting.WinForms.ReportViewer rv_medicamentos_por_mes;
    }
}