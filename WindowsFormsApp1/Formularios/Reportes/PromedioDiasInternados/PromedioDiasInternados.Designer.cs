
namespace WindowsFormsApp1.Formularios.Reportes.PromedioDiasInternados
{
    partial class PromedioDiasInternados
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
            this.lblPromedio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAnno2 = new System.Windows.Forms.Label();
            this.textBoxAnnoE = new System.Windows.Forms.TextBox();
            this.textBoxAnnoS = new System.Windows.Forms.TextBox();
            this.btnCalcular01 = new System.Windows.Forms.Button();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.btnCalcular01);
            this.tabPage1.Controls.Add(this.textBoxAnnoS);
            this.tabPage1.Controls.Add(this.textBoxAnnoE);
            this.tabPage1.Controls.Add(this.labelAnno2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(16, 13);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(649, 25);
            this.lblPromedio.TabIndex = 1;
            this.lblPromedio.Text = "Reporte sobre: Promedio de dias que un can permanece internado";
            this.lblPromedio.Click += new System.EventHandler(this.lblPromedio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año Entrada";
            // 
            // labelAnno2
            // 
            this.labelAnno2.AutoSize = true;
            this.labelAnno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnno2.Location = new System.Drawing.Point(274, 37);
            this.labelAnno2.Name = "labelAnno2";
            this.labelAnno2.Size = new System.Drawing.Size(86, 20);
            this.labelAnno2.TabIndex = 1;
            this.labelAnno2.Text = "Año Salida";
            // 
            // textBoxAnnoE
            // 
            this.textBoxAnnoE.Location = new System.Drawing.Point(130, 39);
            this.textBoxAnnoE.Name = "textBoxAnnoE";
            this.textBoxAnnoE.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnnoE.TabIndex = 2;
            // 
            // textBoxAnnoS
            // 
            this.textBoxAnnoS.Location = new System.Drawing.Point(366, 37);
            this.textBoxAnnoS.Name = "textBoxAnnoS";
            this.textBoxAnnoS.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnnoS.TabIndex = 3;
            // 
            // btnCalcular01
            // 
            this.btnCalcular01.Location = new System.Drawing.Point(531, 37);
            this.btnCalcular01.Name = "btnCalcular01";
            this.btnCalcular01.Size = new System.Drawing.Size(132, 20);
            this.btnCalcular01.TabIndex = 4;
            this.btnCalcular01.Text = "Calcular";
            this.btnCalcular01.UseVisualStyleBackColor = true;
            this.btnCalcular01.Click += new System.EventHandler(this.btnCalcular01_Click);
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(55, 84);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(684, 256);
            this.rv01.TabIndex = 5;
            // 
            // PromedioDiasInternados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.tabControl1);
            this.Name = "PromedioDiasInternados";
            this.Text = "PromedioDiasInternados";
            this.Load += new System.EventHandler(this.PromedioDiasInternados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox textBoxAnnoS;
        private System.Windows.Forms.TextBox textBoxAnnoE;
        private System.Windows.Forms.Label labelAnno2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private System.Windows.Forms.Button btnCalcular01;
    }
}