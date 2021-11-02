
namespace WindowsFormsApp1.Formularios.Reportes.ReportePromedioDeVacunadosDiarios
{
    partial class ReporteVacunadosDiarios
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
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtboxAno = new System.Windows.Forms.TextBox();
            this.txtboxMes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxDia = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 284);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(6, 6);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(755, 246);
            this.rv01.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(152, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(532, 29);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Cantidad de canes que se vacunan en un dia";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(566, 95);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 32);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(268, 102);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(37, 18);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "mes";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(125, 103);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(34, 18);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Año";
            // 
            // txtboxAno
            // 
            this.txtboxAno.Location = new System.Drawing.Point(177, 104);
            this.txtboxAno.Name = "txtboxAno";
            this.txtboxAno.Size = new System.Drawing.Size(85, 20);
            this.txtboxAno.TabIndex = 5;
            // 
            // txtboxMes
            // 
            this.txtboxMes.Location = new System.Drawing.Point(311, 104);
            this.txtboxMes.Name = "txtboxMes";
            this.txtboxMes.Size = new System.Drawing.Size(80, 20);
            this.txtboxMes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dia";
            // 
            // txtboxDia
            // 
            this.txtboxDia.Location = new System.Drawing.Point(433, 103);
            this.txtboxDia.Name = "txtboxDia";
            this.txtboxDia.Size = new System.Drawing.Size(80, 20);
            this.txtboxDia.TabIndex = 8;
            this.txtboxDia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ReporteVacunadosDiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxMes);
            this.Controls.Add(this.txtboxAno);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReporteVacunadosDiarios";
            this.Text = "ReporteVacunadosDiarios";
            this.Load += new System.EventHandler(this.ReporteVacunadosDiarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtboxAno;
        private System.Windows.Forms.TextBox txtboxMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxDia;
    }
}