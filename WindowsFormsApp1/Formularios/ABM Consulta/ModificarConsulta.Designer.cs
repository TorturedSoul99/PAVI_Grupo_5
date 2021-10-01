
namespace WindowsFormsApp1.Formularios.ABM_Consulta
{
    partial class ModificarConsulta
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
            this.btnAgregarSintomas = new System.Windows.Forms.Button();
            this.txtFechaSalida = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaEntrada = new System.Windows.Forms.MaskedTextBox();
            this.lblNroOrden = new System.Windows.Forms.Label();
            this.txtNroOrden = new System.Windows.Forms.MaskedTextBox();
            this.cmbHistoriaClinica = new System.Windows.Forms.ComboBox();
            this.cmbDiagnostico = new System.Windows.Forms.ComboBox();
            this.cmbReceta = new System.Windows.Forms.ComboBox();
            this.cmbSintoma = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lblReceta = new System.Windows.Forms.Label();
            this.lblSintoma = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblFechaS = new System.Windows.Forms.Label();
            this.lblFechaE = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblHC = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarSintomas
            // 
            this.btnAgregarSintomas.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._3puntos;
            this.btnAgregarSintomas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarSintomas.FlatAppearance.BorderSize = 0;
            this.btnAgregarSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSintomas.Location = new System.Drawing.Point(424, 292);
            this.btnAgregarSintomas.Name = "btnAgregarSintomas";
            this.btnAgregarSintomas.Size = new System.Drawing.Size(48, 23);
            this.btnAgregarSintomas.TabIndex = 40;
            this.btnAgregarSintomas.UseVisualStyleBackColor = true;
            this.btnAgregarSintomas.Click += new System.EventHandler(this.btnAgregarSintomas_Click);
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Location = new System.Drawing.Point(213, 164);
            this.txtFechaSalida.Mask = "00/00/0000";
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(100, 20);
            this.txtFechaSalida.TabIndex = 65;
            this.txtFechaSalida.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Location = new System.Drawing.Point(213, 127);
            this.txtFechaEntrada.Mask = "00/00/0000";
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtFechaEntrada.TabIndex = 64;
            this.txtFechaEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // lblNroOrden
            // 
            this.lblNroOrden.AutoSize = true;
            this.lblNroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroOrden.Location = new System.Drawing.Point(72, 9);
            this.lblNroOrden.Name = "lblNroOrden";
            this.lblNroOrden.Size = new System.Drawing.Size(135, 20);
            this.lblNroOrden.TabIndex = 63;
            this.lblNroOrden.Text = "Numero de Orden";
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.Location = new System.Drawing.Point(213, 11);
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.ReadOnly = true;
            this.txtNroOrden.Size = new System.Drawing.Size(100, 20);
            this.txtNroOrden.TabIndex = 62;
            // 
            // cmbHistoriaClinica
            // 
            this.cmbHistoriaClinica.Location = new System.Drawing.Point(213, 43);
            this.cmbHistoriaClinica.Name = "cmbHistoriaClinica";
            this.cmbHistoriaClinica.Size = new System.Drawing.Size(202, 21);
            this.cmbHistoriaClinica.TabIndex = 61;
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.Location = new System.Drawing.Point(213, 253);
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            this.cmbDiagnostico.Size = new System.Drawing.Size(202, 21);
            this.cmbDiagnostico.TabIndex = 60;
            // 
            // cmbReceta
            // 
            this.cmbReceta.Location = new System.Drawing.Point(213, 328);
            this.cmbReceta.Name = "cmbReceta";
            this.cmbReceta.Size = new System.Drawing.Size(202, 21);
            this.cmbReceta.TabIndex = 59;
            // 
            // cmbSintoma
            // 
            this.cmbSintoma.Location = new System.Drawing.Point(213, 291);
            this.cmbSintoma.Name = "cmbSintoma";
            this.cmbSintoma.Size = new System.Drawing.Size(202, 21);
            this.cmbSintoma.TabIndex = 58;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Location = new System.Drawing.Point(213, 209);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(202, 21);
            this.cmbEmpleado.TabIndex = 57;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(213, 83);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(202, 21);
            this.cmbSucursal.TabIndex = 47;
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceta.Location = new System.Drawing.Point(123, 329);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(84, 20);
            this.lblReceta.TabIndex = 56;
            this.lblReceta.Text = "Id_Receta";
            // 
            // lblSintoma
            // 
            this.lblSintoma.AutoSize = true;
            this.lblSintoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintoma.Location = new System.Drawing.Point(139, 292);
            this.lblSintoma.Name = "lblSintoma";
            this.lblSintoma.Size = new System.Drawing.Size(68, 20);
            this.lblSintoma.TabIndex = 55;
            this.lblSintoma.Text = "Sintoma";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(126, 210);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(81, 20);
            this.lblEmpleado.TabIndex = 54;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(114, 254);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(93, 20);
            this.lblDiagnostico.TabIndex = 53;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // lblFechaS
            // 
            this.lblFechaS.AutoSize = true;
            this.lblFechaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaS.Location = new System.Drawing.Point(86, 164);
            this.lblFechaS.Name = "lblFechaS";
            this.lblFechaS.Size = new System.Drawing.Size(121, 20);
            this.lblFechaS.TabIndex = 52;
            this.lblFechaS.Text = "Fecha de salida";
            // 
            // lblFechaE
            // 
            this.lblFechaE.AutoSize = true;
            this.lblFechaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaE.Location = new System.Drawing.Point(72, 127);
            this.lblFechaE.Name = "lblFechaE";
            this.lblFechaE.Size = new System.Drawing.Size(135, 20);
            this.lblFechaE.TabIndex = 51;
            this.lblFechaE.Text = "Fecha de entrada";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(136, 84);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(71, 20);
            this.lblSucursal.TabIndex = 50;
            this.lblSucursal.Text = "Sucursal";
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHC.Location = new System.Drawing.Point(12, 44);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(195, 20);
            this.lblHC.TabIndex = 49;
            this.lblHC.Text = "Numero de Historia Clinica";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(317, 365);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ModificarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(484, 398);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.txtFechaEntrada);
            this.Controls.Add(this.lblNroOrden);
            this.Controls.Add(this.txtNroOrden);
            this.Controls.Add(this.cmbHistoriaClinica);
            this.Controls.Add(this.cmbDiagnostico);
            this.Controls.Add(this.cmbReceta);
            this.Controls.Add(this.cmbSintoma);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lblReceta);
            this.Controls.Add(this.lblSintoma);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblFechaS);
            this.Controls.Add(this.lblFechaE);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblHC);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAgregarSintomas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Consulta";
            this.Load += new System.EventHandler(this.ModificarConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarSintomas;
        private System.Windows.Forms.MaskedTextBox txtFechaSalida;
        private System.Windows.Forms.MaskedTextBox txtFechaEntrada;
        private System.Windows.Forms.Label lblNroOrden;
        private System.Windows.Forms.MaskedTextBox txtNroOrden;
        private System.Windows.Forms.ComboBox cmbHistoriaClinica;
        private System.Windows.Forms.ComboBox cmbDiagnostico;
        private System.Windows.Forms.ComboBox cmbReceta;
        private System.Windows.Forms.ComboBox cmbSintoma;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.Label lblSintoma;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblFechaS;
        private System.Windows.Forms.Label lblFechaE;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblHC;
        private System.Windows.Forms.Button btnAgregar;
    }
}