﻿
namespace WindowsFormsApp1.Formularios.ABM_DepositoXSucursal
{
    partial class ABMdeposito_x_sucursal
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
            this.grid_deposito_x_sucursal = new System.Windows.Forms.DataGridView();
            this.ID_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_deposito_x_sucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(67, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 23);
            this.btnConsultar.TabIndex = 38;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtbConsulta
            // 
            this.txtbConsulta.Location = new System.Drawing.Point(194, 44);
            this.txtbConsulta.Name = "txtbConsulta";
            this.txtbConsulta.Size = new System.Drawing.Size(234, 20);
            this.txtbConsulta.TabIndex = 37;
            this.txtbConsulta.Text = "Buscar Segun ID de medicamento";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(212, 362);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(118, 23);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grid_deposito_x_sucursal
            // 
            this.grid_deposito_x_sucursal.AllowUserToAddRows = false;
            this.grid_deposito_x_sucursal.AllowUserToDeleteRows = false;
            this.grid_deposito_x_sucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_deposito_x_sucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_medicamento,
            this.ID_sucursal,
            this.Column1,
            this.c});
            this.grid_deposito_x_sucursal.Location = new System.Drawing.Point(67, 141);
            this.grid_deposito_x_sucursal.Name = "grid_deposito_x_sucursal";
            this.grid_deposito_x_sucursal.ReadOnly = true;
            this.grid_deposito_x_sucursal.Size = new System.Drawing.Size(421, 179);
            this.grid_deposito_x_sucursal.TabIndex = 35;
            this.grid_deposito_x_sucursal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Sucursales_CellClick);
            // 
            // ID_medicamento
            // 
            this.ID_medicamento.HeaderText = "ID_medicamento";
            this.ID_medicamento.Name = "ID_medicamento";
            this.ID_medicamento.ReadOnly = true;
            // 
            // ID_sucursal
            // 
            this.ID_sucursal.HeaderText = "Sucursal";
            this.ID_sucursal.Name = "ID_sucursal";
            this.ID_sucursal.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Minimo Stock";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // c
            // 
            this.c.HeaderText = "Stock Actual";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(360, 362);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 23);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(91, 362);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 23);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ABMdeposito_x_sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 443);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtbConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grid_deposito_x_sucursal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMdeposito_x_sucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Deposito por sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.grid_deposito_x_sucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtbConsulta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView grid_deposito_x_sucursal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
    }
}