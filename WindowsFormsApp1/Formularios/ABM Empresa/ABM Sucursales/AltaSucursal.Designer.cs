
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombreSurcursal = new System.Windows.Forms.TextBox();
            this.cmb_supervisor = new WindowsFormsApp1.Back_end.ComboBox01();
            this.cmb_supervisorSuplente = new WindowsFormsApp1.Back_end.ComboBox01();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(52, 135);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(152, 20);
            this.lbl2.TabIndex = 48;
            this.lbl2.Text = "Supervisor Suplente";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(120, 92);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 20);
            this.lbl1.TabIndex = 47;
            this.lbl1.Text = "Supervisor";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(332, 194);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 26);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nombre";
            // 
            // txt_nombreSurcursal
            // 
            this.txt_nombreSurcursal.Location = new System.Drawing.Point(223, 54);
            this.txt_nombreSurcursal.Name = "txt_nombreSurcursal";
            this.txt_nombreSurcursal.Size = new System.Drawing.Size(164, 20);
            this.txt_nombreSurcursal.TabIndex = 50;
            // 
            // cmb_supervisor
            // 
            this.cmb_supervisor.FormattingEnabled = true;
            this.cmb_supervisor.Location = new System.Drawing.Point(223, 90);
            this.cmb_supervisor.Name = "cmb_supervisor";
            this.cmb_supervisor.Pp_conseleccion = false;
            this.cmb_supervisor.Pp_Descripcion = "Nombre";
            this.cmb_supervisor.Pp_MessageError = "Esta mal";
            this.cmb_supervisor.Pp_Pk = "ID_empleado";
            this.cmb_supervisor.Pp_Tabla = "empleados";
            this.cmb_supervisor.Size = new System.Drawing.Size(164, 21);
            this.cmb_supervisor.TabIndex = 51;
            this.cmb_supervisor.validable = false;
            // 
            // cmb_supervisorSuplente
            // 
            this.cmb_supervisorSuplente.FormattingEnabled = true;
            this.cmb_supervisorSuplente.Location = new System.Drawing.Point(223, 133);
            this.cmb_supervisorSuplente.Name = "cmb_supervisorSuplente";
            this.cmb_supervisorSuplente.Pp_conseleccion = false;
            this.cmb_supervisorSuplente.Pp_Descripcion = "Nombre";
            this.cmb_supervisorSuplente.Pp_MessageError = "Esta mal";
            this.cmb_supervisorSuplente.Pp_Pk = "ID_empleado";
            this.cmb_supervisorSuplente.Pp_Tabla = "empleados";
            this.cmb_supervisorSuplente.Size = new System.Drawing.Size(164, 21);
            this.cmb_supervisorSuplente.TabIndex = 52;
            this.cmb_supervisorSuplente.validable = false;
            // 
            // AltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(423, 242);
            this.Controls.Add(this.cmb_supervisorSuplente);
            this.Controls.Add(this.cmb_supervisor);
            this.Controls.Add(this.txt_nombreSurcursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Sucursal";
            this.Load += new System.EventHandler(this.AltaSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombreSurcursal;
        private Back_end.ComboBox01 cmb_supervisor;
        private Back_end.ComboBox01 cmb_supervisorSuplente;
    }
}