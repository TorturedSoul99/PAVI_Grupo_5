
namespace WindowsFormsApp1.Formularios.AMB_HistoriaClinica
{
    partial class Modificar_HistoriaClinica
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
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.txtApellidoDueño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTelefonoDueño = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtNombrePerro = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txtHistoriaClinica = new System.Windows.Forms.TextBox();
            this.lblHistoriaClinica = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(227, 348);
            this.txtTelefono.Mask = "999999999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 144;
            this.txtTelefono.ValidatingType = typeof(int);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(227, 231);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(202, 20);
            this.txtAltura.TabIndex = 143;
            this.txtAltura.ValidatingType = typeof(int);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(170, 231);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 142;
            this.lblAltura.Text = "Altura";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.Location = new System.Drawing.Point(174, 166);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(47, 20);
            this.lblRaza.TabIndex = 141;
            this.lblRaza.Text = "Raza";
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(227, 165);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(202, 21);
            this.cmbRaza.TabIndex = 140;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(227, 139);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 139;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(227, 308);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(202, 20);
            this.txtNombreDueño.TabIndex = 138;
            // 
            // txtApellidoDueño
            // 
            this.txtApellidoDueño.Location = new System.Drawing.Point(227, 268);
            this.txtApellidoDueño.Name = "txtApellidoDueño";
            this.txtApellidoDueño.Size = new System.Drawing.Size(202, 20);
            this.txtApellidoDueño.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "Nombre Dueño";
            // 
            // lblTelefonoDueño
            // 
            this.lblTelefonoDueño.AutoSize = true;
            this.lblTelefonoDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoDueño.Location = new System.Drawing.Point(96, 348);
            this.lblTelefonoDueño.Name = "lblTelefonoDueño";
            this.lblTelefonoDueño.Size = new System.Drawing.Size(123, 20);
            this.lblTelefonoDueño.TabIndex = 135;
            this.lblTelefonoDueño.Text = "Telefono Dueño";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(104, 266);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(117, 20);
            this.lblApellido.TabIndex = 134;
            this.lblApellido.Text = "Apellido Dueño";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(176, 203);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 133;
            this.lblPeso.Text = "Peso";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(227, 69);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(202, 21);
            this.cmbSucursal.TabIndex = 132;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(227, 203);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(202, 20);
            this.txtPeso.TabIndex = 131;
            // 
            // txtNombrePerro
            // 
            this.txtNombrePerro.Location = new System.Drawing.Point(227, 105);
            this.txtNombrePerro.Name = "txtNombrePerro";
            this.txtNombrePerro.Size = new System.Drawing.Size(202, 20);
            this.txtNombrePerro.TabIndex = 130;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(156, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 129;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(84, 139);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(137, 20);
            this.lblFechaNacimiento.TabIndex = 128;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(150, 70);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(71, 20);
            this.lblSucursal.TabIndex = 127;
            this.lblSucursal.Text = "Sucursal";
            // 
            // txtHistoriaClinica
            // 
            this.txtHistoriaClinica.Location = new System.Drawing.Point(227, 38);
            this.txtHistoriaClinica.Name = "txtHistoriaClinica";
            this.txtHistoriaClinica.ReadOnly = true;
            this.txtHistoriaClinica.Size = new System.Drawing.Size(202, 20);
            this.txtHistoriaClinica.TabIndex = 126;
            // 
            // lblHistoriaClinica
            // 
            this.lblHistoriaClinica.AutoSize = true;
            this.lblHistoriaClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoriaClinica.Location = new System.Drawing.Point(88, 38);
            this.lblHistoriaClinica.Name = "lblHistoriaClinica";
            this.lblHistoriaClinica.Size = new System.Drawing.Size(133, 20);
            this.lblHistoriaClinica.TabIndex = 125;
            this.lblHistoriaClinica.Text = "N° Historia Clinica";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(459, 395);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 26);
            this.btnAgregar.TabIndex = 124;
            this.btnAgregar.Text = "Modificar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Modificar_HistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Otros40;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtNombreDueño);
            this.Controls.Add(this.txtApellidoDueño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTelefonoDueño);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNombrePerro);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.txtHistoriaClinica);
            this.Controls.Add(this.lblHistoriaClinica);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Modificar_HistoriaClinica";
            this.Text = "Modificar Historia Clinica";
            this.Load += new System.EventHandler(this.Modificar_HistoriaClinica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.TextBox txtApellidoDueño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTelefonoDueño;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtNombrePerro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtHistoriaClinica;
        private System.Windows.Forms.Label lblHistoriaClinica;
        private System.Windows.Forms.Button btnAgregar;
    }
}