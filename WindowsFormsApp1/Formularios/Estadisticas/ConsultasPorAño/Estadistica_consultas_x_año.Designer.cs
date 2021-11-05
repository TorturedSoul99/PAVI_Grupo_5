
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
            this.label2 = new System.Windows.Forms.Label();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_anno = new System.Windows.Forms.MaskedTextBox();
            this.txt_mes1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mes2 = new System.Windows.Forms.MaskedTextBox();
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
            this.tabPage1.Text = "Consultas por año";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estadistica consultas por mes y año";
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
            // txt_anno
            // 
            this.txt_anno.Location = new System.Drawing.Point(122, 63);
            this.txt_anno.Mask = "9999";
            this.txt_anno.Name = "txt_anno";
            this.txt_anno.Size = new System.Drawing.Size(84, 20);
            this.txt_anno.TabIndex = 6;
            // 
            // txt_mes1
            // 
            this.txt_mes1.Location = new System.Drawing.Point(122, 101);
            this.txt_mes1.Mask = "99";
            this.txt_mes1.Name = "txt_mes1";
            this.txt_mes1.Size = new System.Drawing.Size(84, 20);
            this.txt_mes1.TabIndex = 7;
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
            // txt_mes2
            // 
            this.txt_mes2.Location = new System.Drawing.Point(421, 104);
            this.txt_mes2.Mask = "99";
            this.txt_mes2.Name = "txt_mes2";
            this.txt_mes2.Size = new System.Drawing.Size(84, 20);
            this.txt_mes2.TabIndex = 10;
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
    }
}