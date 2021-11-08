
namespace WindowsFormsApp1.Formularios.AMB_HistoriaClinica
{
    partial class Menu_HistoriaClinica
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
            this.button1 = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.dgvHistoriaClinica = new System.Windows.Forms.DataGridView();
            this.Numero_HC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbConsulta = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaClinica)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(400, 24);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 37;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // dgvHistoriaClinica
            // 
            this.dgvHistoriaClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriaClinica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_HC,
            this.ID_sucursal,
            this.Nombre,
            this.Fecha_nacimiento,
            this.ID_Raza,
            this.Peso,
            this.Altura,
            this.Nombre_dueño,
            this.Apellido_dueño,
            this.Telefono});
            this.dgvHistoriaClinica.Location = new System.Drawing.Point(31, 80);
            this.dgvHistoriaClinica.Name = "dgvHistoriaClinica";
            this.dgvHistoriaClinica.Size = new System.Drawing.Size(1044, 267);
            this.dgvHistoriaClinica.TabIndex = 36;
            // 
            // Numero_HC
            // 
            this.Numero_HC.DataPropertyName = "Nro_historia_clinica";
            this.Numero_HC.HeaderText = "N° Historia Clinica";
            this.Numero_HC.Name = "Numero_HC";
            // 
            // ID_sucursal
            // 
            this.ID_sucursal.DataPropertyName = "ID_sucursal";
            this.ID_sucursal.HeaderText = "ID_sucursal";
            this.ID_sucursal.Name = "ID_sucursal";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.DataPropertyName = "Fecha_Nacimiento";
            this.Fecha_nacimiento.HeaderText = "Fecha nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            // 
            // ID_Raza
            // 
            this.ID_Raza.DataPropertyName = "Raza";
            this.ID_Raza.HeaderText = "Raza";
            this.ID_Raza.Name = "ID_Raza";
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "Altura";
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            // 
            // Nombre_dueño
            // 
            this.Nombre_dueño.DataPropertyName = "Nombre_dueño";
            this.Nombre_dueño.HeaderText = "Nombre dueño";
            this.Nombre_dueño.Name = "Nombre_dueño";
            // 
            // Apellido_dueño
            // 
            this.Apellido_dueño.DataPropertyName = "Apellido_dueño";
            this.Apellido_dueño.HeaderText = "Apellido dueño";
            this.Apellido_dueño.Name = "Apellido_dueño";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // txtbConsulta
            // 
            this.txtbConsulta.Location = new System.Drawing.Point(145, 22);
            this.txtbConsulta.Name = "txtbConsulta";
            this.txtbConsulta.Size = new System.Drawing.Size(235, 20);
            this.txtbConsulta.TabIndex = 35;
            this.txtbConsulta.Text = "Buscar Segun Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(414, 408);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(597, 408);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(261, 408);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 32;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Menu_HistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.leather_black_minimalistic_1920x1080_wallpaper_www_wallpaperto_com_44;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.dgvHistoriaClinica);
            this.Controls.Add(this.txtbConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Menu_HistoriaClinica";
            this.Text = "Menu Historia Clinica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaClinica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.DataGridView dgvHistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_HC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.TextBox txtbConsulta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
    }
}