
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    partial class Mostrar_sucursal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_supervisor = new System.Windows.Forms.TextBox();
            this.txt_supervisor_suplente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nombre Sucursal";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(18, 116);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(152, 20);
            this.lbl2.TabIndex = 76;
            this.lbl2.Text = "Supervisor Suplente";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(86, 73);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 20);
            this.lbl1.TabIndex = 75;
            this.lbl1.Text = "Supervisor";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(265, 157);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(83, 27);
            this.btn_eliminar.TabIndex = 74;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(178, 31);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(170, 20);
            this.txt_nombre.TabIndex = 78;
            // 
            // txt_supervisor
            // 
            this.txt_supervisor.Location = new System.Drawing.Point(176, 75);
            this.txt_supervisor.Name = "txt_supervisor";
            this.txt_supervisor.Size = new System.Drawing.Size(172, 20);
            this.txt_supervisor.TabIndex = 79;
            // 
            // txt_supervisor_suplente
            // 
            this.txt_supervisor_suplente.Location = new System.Drawing.Point(176, 116);
            this.txt_supervisor_suplente.Name = "txt_supervisor_suplente";
            this.txt_supervisor_suplente.Size = new System.Drawing.Size(172, 20);
            this.txt_supervisor_suplente.TabIndex = 80;
            // 
            // Mostrar_sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 205);
            this.Controls.Add(this.txt_supervisor_suplente);
            this.Controls.Add(this.txt_supervisor);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_eliminar);
            this.Name = "Mostrar_sucursal";
            this.Text = "Mostrar_sucursal";
            this.Load += new System.EventHandler(this.Mostrar_sucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_supervisor;
        private System.Windows.Forms.TextBox txt_supervisor_suplente;
    }
}