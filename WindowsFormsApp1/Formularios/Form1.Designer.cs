
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consulñtaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulñtaToolStripMenuItem,
            this.vacunacionToolStripMenuItem,
            this.internacionToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.laboratoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consulñtaToolStripMenuItem
            // 
            this.consulñtaToolStripMenuItem.Name = "consulñtaToolStripMenuItem";
            this.consulñtaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consulñtaToolStripMenuItem.Text = "Consulta";
            this.consulñtaToolStripMenuItem.Click += new System.EventHandler(this.consulñtaToolStripMenuItem_Click);
            // 
            // vacunacionToolStripMenuItem
            // 
            this.vacunacionToolStripMenuItem.Name = "vacunacionToolStripMenuItem";
            this.vacunacionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vacunacionToolStripMenuItem.Text = "Vacunacion";
            // 
            // internacionToolStripMenuItem
            // 
            this.internacionToolStripMenuItem.Name = "internacionToolStripMenuItem";
            this.internacionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.internacionToolStripMenuItem.Text = "Internacion";
            // 
            // laboratoriosToolStripMenuItem
            // 
            this.laboratoriosToolStripMenuItem.Name = "laboratoriosToolStripMenuItem";
            this.laboratoriosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.laboratoriosToolStripMenuItem.Text = "Laboratorios";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2021_09_07_at_15_52_30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 377);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consulñtaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
    }
}

