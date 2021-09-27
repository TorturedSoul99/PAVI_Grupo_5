
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado
{
    partial class ABM_Empleado
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
            this.btnConsultarNombre = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grid_empleados = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txt_IDEmpleado = new System.Windows.Forms.TextBox();
            this.txt_IDSucursal = new System.Windows.Forms.TextBox();
            this.ID_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultaID = new System.Windows.Forms.Button();
            this.btnIDSucursal = new System.Windows.Forms.Button();
            this.chkBuscarTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarNombre
            // 
            this.btnConsultarNombre.Location = new System.Drawing.Point(36, 24);
            this.btnConsultarNombre.Name = "btnConsultarNombre";
            this.btnConsultarNombre.Size = new System.Drawing.Size(127, 23);
            this.btnConsultarNombre.TabIndex = 14;
            this.btnConsultarNombre.Text = "Consultar Nombre";
            this.btnConsultarNombre.UseVisualStyleBackColor = true;
            this.btnConsultarNombre.Click += new System.EventHandler(this.btnConsultarNombre_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(201, 26);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(235, 20);
            this.txt_nombre.TabIndex = 13;
            this.txt_nombre.Text = "Buscar Segun Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(236, 440);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grid_empleados
            // 
            this.grid_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_empleado,
            this.Tipo_documento,
            this.Nro_documento,
            this.Nombre,
            this.Apellido,
            this.Fecha_nacimiento,
            this.Fecha_ingreso,
            this.ID_sucursal,
            this.Matricula});
            this.grid_empleados.Location = new System.Drawing.Point(36, 169);
            this.grid_empleados.Name = "grid_empleados";
            this.grid_empleados.Size = new System.Drawing.Size(922, 211);
            this.grid_empleados.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(384, 440);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(115, 440);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txt_IDEmpleado
            // 
            this.txt_IDEmpleado.Location = new System.Drawing.Point(201, 76);
            this.txt_IDEmpleado.Name = "txt_IDEmpleado";
            this.txt_IDEmpleado.Size = new System.Drawing.Size(235, 20);
            this.txt_IDEmpleado.TabIndex = 15;
            // 
            // txt_IDSucursal
            // 
            this.txt_IDSucursal.Location = new System.Drawing.Point(201, 126);
            this.txt_IDSucursal.Name = "txt_IDSucursal";
            this.txt_IDSucursal.Size = new System.Drawing.Size(235, 20);
            this.txt_IDSucursal.TabIndex = 16;
            // 
            // ID_empleado
            // 
            this.ID_empleado.HeaderText = "ID Empleado";
            this.ID_empleado.Name = "ID_empleado";
            // 
            // Tipo_documento
            // 
            this.Tipo_documento.HeaderText = "Tipo de Documento";
            this.Tipo_documento.Name = "Tipo_documento";
            // 
            // Nro_documento
            // 
            this.Nro_documento.HeaderText = "Documento";
            this.Nro_documento.Name = "Nro_documento";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            // 
            // Fecha_ingreso
            // 
            this.Fecha_ingreso.HeaderText = "Fecha de Ingreso";
            this.Fecha_ingreso.Name = "Fecha_ingreso";
            // 
            // ID_sucursal
            // 
            this.ID_sucursal.HeaderText = "ID Sucursal";
            this.ID_sucursal.Name = "ID_sucursal";
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // btnConsultaID
            // 
            this.btnConsultaID.Location = new System.Drawing.Point(36, 74);
            this.btnConsultaID.Name = "btnConsultaID";
            this.btnConsultaID.Size = new System.Drawing.Size(127, 23);
            this.btnConsultaID.TabIndex = 17;
            this.btnConsultaID.Text = "Consultar ID Empleado";
            this.btnConsultaID.UseVisualStyleBackColor = true;
            this.btnConsultaID.Click += new System.EventHandler(this.btnConsultaID_Click);
            // 
            // btnIDSucursal
            // 
            this.btnIDSucursal.Location = new System.Drawing.Point(36, 124);
            this.btnIDSucursal.Name = "btnIDSucursal";
            this.btnIDSucursal.Size = new System.Drawing.Size(127, 23);
            this.btnIDSucursal.TabIndex = 18;
            this.btnIDSucursal.Text = "Consultar ID Surcursal";
            this.btnIDSucursal.UseVisualStyleBackColor = true;
            this.btnIDSucursal.Click += new System.EventHandler(this.btnIDSucursal_Click);
            // 
            // chkBuscarTodos
            // 
            this.chkBuscarTodos.AutoSize = true;
            this.chkBuscarTodos.Location = new System.Drawing.Point(514, 129);
            this.chkBuscarTodos.Name = "chkBuscarTodos";
            this.chkBuscarTodos.Size = new System.Drawing.Size(92, 17);
            this.chkBuscarTodos.TabIndex = 19;
            this.chkBuscarTodos.Text = "Buscar Todos";
            this.chkBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // ABM_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.leather_black_minimalistic_1920x1080_wallpaper_www_wallpaperto_com_44;
            this.ClientSize = new System.Drawing.Size(971, 496);
            this.Controls.Add(this.chkBuscarTodos);
            this.Controls.Add(this.btnIDSucursal);
            this.Controls.Add(this.btnConsultaID);
            this.Controls.Add(this.txt_IDSucursal);
            this.Controls.Add(this.txt_IDEmpleado);
            this.Controls.Add(this.btnConsultarNombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grid_empleados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABM_Empleado";
            this.Text = "Menu Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.grid_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarNombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView grid_empleados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txt_IDEmpleado;
        private System.Windows.Forms.TextBox txt_IDSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.Button btnConsultaID;
        private System.Windows.Forms.Button btnIDSucursal;
        private System.Windows.Forms.CheckBox chkBuscarTodos;
    }
}