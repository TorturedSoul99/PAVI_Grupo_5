
namespace WindowsFormsApp1.Formularios.ABM_Vacunacion
{
    partial class modificar_vacuna
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbl_dosis = new System.Windows.Forms.Label();
            this.lblvacuna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(243, 132);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(77, 28);
            this.btn_modificar.TabIndex = 25;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(121, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Visible = false;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(121, 84);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(199, 20);
            this.txbNombre.TabIndex = 28;
            // 
            // lbl_dosis
            // 
            this.lbl_dosis.AutoSize = true;
            this.lbl_dosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dosis.Location = new System.Drawing.Point(50, 84);
            this.lbl_dosis.Name = "lbl_dosis";
            this.lbl_dosis.Size = new System.Drawing.Size(65, 20);
            this.lbl_dosis.TabIndex = 27;
            this.lbl_dosis.Text = "Nombre";
            // 
            // lblvacuna
            // 
            this.lblvacuna.AutoSize = true;
            this.lblvacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvacuna.Location = new System.Drawing.Point(28, 39);
            this.lblvacuna.Name = "lblvacuna";
            this.lblvacuna.Size = new System.Drawing.Size(87, 20);
            this.lblvacuna.TabIndex = 26;
            this.lblvacuna.Text = "Id_Vacuna";
            // 
            // modificar_vacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(396, 187);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lbl_dosis);
            this.Controls.Add(this.lblvacuna);
            this.Controls.Add(this.btn_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modificar_vacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar vacuna";
            this.Load += new System.EventHandler(this.modificar_vacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbl_dosis;
        private System.Windows.Forms.Label lblvacuna;
    }
}