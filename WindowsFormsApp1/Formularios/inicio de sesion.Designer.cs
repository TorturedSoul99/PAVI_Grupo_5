
namespace WindowsFormsApp1.Formularios
{
    partial class inicio_de_sesion
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
            System.Windows.Forms.Label lblUsuario;
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(96, 49);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(152, 20);
            this.txtUsuario.TabIndex = 10;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Black;
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblContraseña.Location = new System.Drawing.Point(29, 96);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 9;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = System.Drawing.SystemColors.Desktop;
            lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            lblUsuario.Location = new System.Drawing.Point(29, 52);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(43, 13);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(273, 136);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.maskedTextBox1.Location = new System.Drawing.Point(96, 96);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(152, 20);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // inicio_de_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.leather_black_minimalistic_1920x1080_wallpaper_www_wallpaperto_com_44;
            this.ClientSize = new System.Drawing.Size(384, 178);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(lblUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Name = "inicio_de_sesion";
            this.Text = "inicio_de_sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}