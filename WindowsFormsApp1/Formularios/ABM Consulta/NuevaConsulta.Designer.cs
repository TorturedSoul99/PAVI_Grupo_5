
namespace WindowsFormsApp1.Formularios.ABM_Consulta
{
    partial class NuevaConsulta
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
            this.lblNroOrden = new System.Windows.Forms.Label();
            this.txtNroOrden = new System.Windows.Forms.MaskedTextBox();
            this.cmbHistoriaClinica = new System.Windows.Forms.ComboBox();
            this.cmbDiagnostico = new System.Windows.Forms.ComboBox();
            this.txtFechaSalida = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaEntrada = new System.Windows.Forms.MaskedTextBox();
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
            this.btnAgregarSintomas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNroOrden
            // 
            this.lblNroOrden.AutoSize = true;
            this.lblNroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroOrden.Location = new System.Drawing.Point(98, 10);
            this.lblNroOrden.Name = "lblNroOrden";
            this.lblNroOrden.Size = new System.Drawing.Size(135, 20);
            this.lblNroOrden.TabIndex = 63;
            this.lblNroOrden.Text = "Numero de Orden";
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.Location = new System.Drawing.Point(239, 12);
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.ReadOnly = true;
            this.txtNroOrden.Size = new System.Drawing.Size(100, 20);
            this.txtNroOrden.TabIndex = 62;
            // 
            // cmbHistoriaClinica
            // 
            this.cmbHistoriaClinica.Location = new System.Drawing.Point(239, 44);
            this.cmbHistoriaClinica.Name = "cmbHistoriaClinica";
            this.cmbHistoriaClinica.Size = new System.Drawing.Size(202, 21);
            this.cmbHistoriaClinica.TabIndex = 61;
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.Location = new System.Drawing.Point(239, 254);
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            this.cmbDiagnostico.Size = new System.Drawing.Size(202, 21);
            this.cmbDiagnostico.TabIndex = 60;
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Location = new System.Drawing.Point(239, 165);
            this.txtFechaSalida.Mask = "00/00/0000";
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(100, 20);
            this.txtFechaSalida.TabIndex = 59;
            this.txtFechaSalida.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Location = new System.Drawing.Point(239, 128);
            this.txtFechaEntrada.Mask = "00/00/0000";
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtFechaEntrada.TabIndex = 58;
            this.txtFechaEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // cmbReceta
            // 
            this.cmbReceta.Location = new System.Drawing.Point(239, 329);
            this.cmbReceta.Name = "cmbReceta";
            this.cmbReceta.Size = new System.Drawing.Size(202, 21);
            this.cmbReceta.TabIndex = 57;
            // 
            // cmbSintoma
            // 
            this.cmbSintoma.Location = new System.Drawing.Point(239, 292);
            this.cmbSintoma.Name = "cmbSintoma";
            this.cmbSintoma.Size = new System.Drawing.Size(202, 21);
            this.cmbSintoma.TabIndex = 56;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Location = new System.Drawing.Point(239, 210);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(202, 21);
            this.cmbEmpleado.TabIndex = 55;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(239, 84);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(202, 21);
            this.cmbSucursal.TabIndex = 45;
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceta.Location = new System.Drawing.Point(149, 330);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(84, 20);
            this.lblReceta.TabIndex = 54;
            this.lblReceta.Text = "Id_Receta";
            // 
            // lblSintoma
            // 
            this.lblSintoma.AutoSize = true;
            this.lblSintoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintoma.Location = new System.Drawing.Point(165, 293);
            this.lblSintoma.Name = "lblSintoma";
            this.lblSintoma.Size = new System.Drawing.Size(68, 20);
            this.lblSintoma.TabIndex = 53;
            this.lblSintoma.Text = "Sintoma";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(152, 211);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(81, 20);
            this.lblEmpleado.TabIndex = 52;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(140, 255);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(93, 20);
            this.lblDiagnostico.TabIndex = 51;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // lblFechaS
            // 
            this.lblFechaS.AutoSize = true;
            this.lblFechaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaS.Location = new System.Drawing.Point(112, 165);
            this.lblFechaS.Name = "lblFechaS";
            this.lblFechaS.Size = new System.Drawing.Size(121, 20);
            this.lblFechaS.TabIndex = 50;
            this.lblFechaS.Text = "Fecha de salida";
            // 
            // lblFechaE
            // 
            this.lblFechaE.AutoSize = true;
            this.lblFechaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaE.Location = new System.Drawing.Point(98, 128);
            this.lblFechaE.Name = "lblFechaE";
            this.lblFechaE.Size = new System.Drawing.Size(135, 20);
            this.lblFechaE.TabIndex = 49;
            this.lblFechaE.Text = "Fecha de entrada";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(162, 85);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(71, 20);
            this.lblSucursal.TabIndex = 48;
            this.lblSucursal.Text = "Sucursal";
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHC.Location = new System.Drawing.Point(38, 45);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(195, 20);
            this.lblHC.TabIndex = 47;
            this.lblHC.Text = "Numero de Historia Clinica";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(343, 366);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAgregarSintomas
            // 
            this.btnAgregarSintomas.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._3puntos;
            this.btnAgregarSintomas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarSintomas.FlatAppearance.BorderSize = 0;
            this.btnAgregarSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSintomas.Location = new System.Drawing.Point(447, 293);
            this.btnAgregarSintomas.Name = "btnAgregarSintomas";
            this.btnAgregarSintomas.Size = new System.Drawing.Size(48, 23);
            this.btnAgregarSintomas.TabIndex = 64;
            this.btnAgregarSintomas.UseVisualStyleBackColor = true;
            // 
            // NuevaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(531, 398);
            this.Controls.Add(this.btnAgregarSintomas);
            this.Controls.Add(this.lblNroOrden);
            this.Controls.Add(this.txtNroOrden);
            this.Controls.Add(this.cmbHistoriaClinica);
            this.Controls.Add(this.cmbDiagnostico);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.txtFechaEntrada);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Consulta";
            this.Load += new System.EventHandler(this.NuevaConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroOrden;
        private System.Windows.Forms.MaskedTextBox txtNroOrden;
        private System.Windows.Forms.ComboBox cmbHistoriaClinica;
        private System.Windows.Forms.ComboBox cmbDiagnostico;
        private System.Windows.Forms.MaskedTextBox txtFechaSalida;
        private System.Windows.Forms.MaskedTextBox txtFechaEntrada;
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
        private System.Windows.Forms.Button btnAgregarSintomas;
    }
}