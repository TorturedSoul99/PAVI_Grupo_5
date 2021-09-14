
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    partial class Modificar_Sucursales
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
            this.cmboxIDSuplenteSupervisor = new System.Windows.Forms.ComboBox();
            this.cmboxIDSupervisor = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmboxIDSuplenteSupervisor
            // 
            this.cmboxIDSuplenteSupervisor.FormattingEnabled = true;
            this.cmboxIDSuplenteSupervisor.Location = new System.Drawing.Point(171, 76);
            this.cmboxIDSuplenteSupervisor.Name = "cmboxIDSuplenteSupervisor";
            this.cmboxIDSuplenteSupervisor.Size = new System.Drawing.Size(202, 21);
            this.cmboxIDSuplenteSupervisor.TabIndex = 68;
            // 
            // cmboxIDSupervisor
            // 
            this.cmboxIDSupervisor.FormattingEnabled = true;
            this.cmboxIDSupervisor.Location = new System.Drawing.Point(171, 32);
            this.cmboxIDSupervisor.Name = "cmboxIDSupervisor";
            this.cmboxIDSupervisor.Size = new System.Drawing.Size(202, 21);
            this.cmboxIDSupervisor.TabIndex = 67;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(24, 79);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(122, 13);
            this.lbl2.TabIndex = 66;
            this.lbl2.Text = "ID_Supervisor_Suplente";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(24, 35);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 13);
            this.lbl1.TabIndex = 65;
            this.lbl1.Text = "ID_Supervisor";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(298, 123);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 64;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Modificar_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(390, 161);
            this.Controls.Add(this.cmboxIDSuplenteSupervisor);
            this.Controls.Add(this.cmboxIDSupervisor);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Modificar_Sucursales";
            this.Text = "Modificar_Sucursales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboxIDSuplenteSupervisor;
        private System.Windows.Forms.ComboBox cmboxIDSupervisor;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAgregar;
    }
}