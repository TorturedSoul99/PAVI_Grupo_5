
namespace WindowsFormsApp1.Formularios.ABM_Vacunacion
{
    partial class Alta_vacunacion
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
            this.lblvacuna = new System.Windows.Forms.Label();
            this.lbl_dosis = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblvacuna
            // 
            this.lblvacuna.AutoSize = true;
            this.lblvacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvacuna.Location = new System.Drawing.Point(32, 59);
            this.lblvacuna.Name = "lblvacuna";
            this.lblvacuna.Size = new System.Drawing.Size(87, 20);
            this.lblvacuna.TabIndex = 0;
            this.lblvacuna.Text = "Id_Vacuna";
            // 
            // lbl_dosis
            // 
            this.lbl_dosis.AutoSize = true;
            this.lbl_dosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dosis.Location = new System.Drawing.Point(54, 104);
            this.lbl_dosis.Name = "lbl_dosis";
            this.lbl_dosis.Size = new System.Drawing.Size(65, 20);
            this.lbl_dosis.TabIndex = 5;
            this.lbl_dosis.Text = "Nombre";
            this.lbl_dosis.Click += new System.EventHandler(this.lbl_dosis_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(125, 104);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(199, 20);
            this.txbNombre.TabIndex = 10;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(285, 151);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(77, 28);
            this.btn_agregar.TabIndex = 12;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(125, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Alta_vacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(437, 216);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lbl_dosis);
            this.Controls.Add(this.lblvacuna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta_vacunacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta vacuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvacuna;
        private System.Windows.Forms.Label lbl_dosis;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox textBox1;
    }
}