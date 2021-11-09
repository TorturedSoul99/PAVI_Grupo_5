
namespace WindowsFormsApp1.Formularios.Estadisticas.ConsultasPorAño
{
    partial class Estadistica_consultas_x_año
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
            this.txt_mes2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mes1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_anno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_anno2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_anno1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.tabControl1.Location = new System.Drawing.Point(26, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 533);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_mes2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_mes1);
            this.tabPage1.Controls.Add(this.txt_anno);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_calcular);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultas por mes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_mes2
            // 
            this.txt_mes2.Location = new System.Drawing.Point(421, 104);
            this.txt_mes2.Mask = "99";
            this.txt_mes2.Name = "txt_mes2";
            this.txt_mes2.Size = new System.Drawing.Size(84, 20);
            this.txt_mes2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mes hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mes desde";
            // 
            // txt_mes1
            // 
            this.txt_mes1.Location = new System.Drawing.Point(122, 101);
            this.txt_mes1.Mask = "99";
            this.txt_mes1.Name = "txt_mes1";
            this.txt_mes1.Size = new System.Drawing.Size(84, 20);
            this.txt_mes1.TabIndex = 7;
            // 
            // txt_anno
            // 
            this.txt_anno.Location = new System.Drawing.Point(122, 63);
            this.txt_anno.Mask = "9999";
            this.txt_anno.Name = "txt_anno";
            this.txt_anno.Size = new System.Drawing.Size(84, 20);
            this.txt_anno.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estadistica consultas por mes ";
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(6, 142);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(728, 369);
            this.rv01.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año Entrada";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(539, 102);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Buscar";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_anno2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_anno1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.rv02);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(740, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas por Año";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(530, 88);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estadisticas consulta por año";
            // 
            // txt_anno2
            // 
            this.txt_anno2.Location = new System.Drawing.Point(414, 90);
            this.txt_anno2.Mask = "9999";
            this.txt_anno2.Name = "txt_anno2";
            this.txt_anno2.Size = new System.Drawing.Size(84, 20);
            this.txt_anno2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Año hasta";
            // 
            // txt_anno1
            // 
            this.txt_anno1.Location = new System.Drawing.Point(109, 89);
            this.txt_anno1.Mask = "9999";
            this.txt_anno1.Name = "txt_anno1";
            this.txt_anno1.Size = new System.Drawing.Size(84, 20);
            this.txt_anno1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Año desde";
            // 
            // rv02
            // 
            this.rv02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv02.Location = new System.Drawing.Point(3, 135);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(734, 369);
            this.rv02.TabIndex = 4;
            // 
            // Estadistica_consultas_x_año
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "Estadistica_consultas_x_año";
            this.Text = "Estadistica_consultas_x_año";
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
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.MaskedTextBox txt_anno;
        private System.Windows.Forms.MaskedTextBox txt_mes2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_mes1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_anno2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_anno1;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
    }
}