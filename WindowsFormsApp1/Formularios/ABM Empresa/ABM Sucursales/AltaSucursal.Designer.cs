
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    partial class AltaSucursal
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmboxIDSupervisor = new System.Windows.Forms.ComboBox();
            this.cmboxIDSuplenteSupervisor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(48, 81);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(152, 20);
            this.lbl2.TabIndex = 48;
            this.lbl2.Text = "Supervisor Suplente";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(116, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 20);
            this.lbl1.TabIndex = 47;
            this.lbl1.Text = "Supervisor";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(328, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 26);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cmboxIDSupervisor
            // 
            this.cmboxIDSupervisor.FormattingEnabled = true;
            this.cmboxIDSupervisor.Location = new System.Drawing.Point(206, 37);
            this.cmboxIDSupervisor.Name = "cmboxIDSupervisor";
            this.cmboxIDSupervisor.Size = new System.Drawing.Size(202, 21);
            this.cmboxIDSupervisor.TabIndex = 62;
            // 
            // cmboxIDSuplenteSupervisor
            // 
            this.cmboxIDSuplenteSupervisor.FormattingEnabled = true;
            this.cmboxIDSuplenteSupervisor.Location = new System.Drawing.Point(206, 80);
            this.cmboxIDSuplenteSupervisor.Name = "cmboxIDSuplenteSupervisor";
            this.cmboxIDSuplenteSupervisor.Size = new System.Drawing.Size(202, 21);
            this.cmboxIDSuplenteSupervisor.TabIndex = 63;
            // 
            // AltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(420, 178);
            this.Controls.Add(this.cmboxIDSuplenteSupervisor);
            this.Controls.Add(this.cmboxIDSupervisor);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaSucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmboxIDSupervisor;
        private System.Windows.Forms.ComboBox cmboxIDSuplenteSupervisor;
    }
}