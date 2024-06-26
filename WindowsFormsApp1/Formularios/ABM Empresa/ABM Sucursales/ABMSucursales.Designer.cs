﻿
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    partial class ABMSucursales
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtbConsulta = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gridSucursales = new System.Windows.Forms.DataGridView();
            this.Nuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chk_SucursalTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(18, 26);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 26;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtbConsulta
            // 
            this.txtbConsulta.Location = new System.Drawing.Point(145, 29);
            this.txtbConsulta.Name = "txtbConsulta";
            this.txtbConsulta.Size = new System.Drawing.Size(235, 20);
            this.txtbConsulta.TabIndex = 25;
            this.txtbConsulta.Text = "Buscar Segun Nombre";
            this.txtbConsulta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbConsulta_MouseClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(171, 391);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gridSucursales
            // 
            this.gridSucursales.AllowUserToAddRows = false;
            this.gridSucursales.AllowUserToDeleteRows = false;
            this.gridSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nuevo,
            this.nombre_sucursal,
            this.Consultar,
            this.Modificar});
            this.gridSucursales.Location = new System.Drawing.Point(27, 144);
            this.gridSucursales.Name = "gridSucursales";
            this.gridSucursales.ReadOnly = true;
            this.gridSucursales.Size = new System.Drawing.Size(446, 179);
            this.gridSucursales.TabIndex = 23;
            this.gridSucursales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSucursales_CellClick);
            this.gridSucursales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSucursales_CellContentClick);
            this.gridSucursales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSucursales_CellDoubleClick);
            // 
            // Nuevo
            // 
            this.Nuevo.HeaderText = "IDSucursal";
            this.Nuevo.MinimumWidth = 10;
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.ReadOnly = true;
            // 
            // nombre_sucursal
            // 
            this.nombre_sucursal.HeaderText = "Nombre";
            this.nombre_sucursal.Name = "nombre_sucursal";
            this.nombre_sucursal.ReadOnly = true;
            // 
            // Consultar
            // 
            this.Consultar.HeaderText = "IDSupervisor";
            this.Consultar.Name = "Consultar";
            this.Consultar.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.DividerWidth = 10;
            this.Modificar.HeaderText = "IDSupervisorSuplente";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(319, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(50, 391);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chk_SucursalTodos
            // 
            this.chk_SucursalTodos.AutoSize = true;
            this.chk_SucursalTodos.Location = new System.Drawing.Point(145, 79);
            this.chk_SucursalTodos.Name = "chk_SucursalTodos";
            this.chk_SucursalTodos.Size = new System.Drawing.Size(94, 17);
            this.chk_SucursalTodos.TabIndex = 27;
            this.chk_SucursalTodos.Text = "Mostrar Todos";
            this.chk_SucursalTodos.UseVisualStyleBackColor = true;
            // 
            // ABMSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.leather_black_minimalistic_1920x1080_wallpaper_www_wallpaperto_com_44;
            this.ClientSize = new System.Drawing.Size(494, 445);
            this.Controls.Add(this.chk_SucursalTodos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtbConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gridSucursales);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.ABMSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtbConsulta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView gridSucursales;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chk_SucursalTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificar;
    }
}