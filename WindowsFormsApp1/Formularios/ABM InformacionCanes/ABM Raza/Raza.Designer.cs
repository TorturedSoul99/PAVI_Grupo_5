﻿
namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza
{
    partial class Raza
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
            this.dgvRaza = new System.Windows.Forms.DataGridView();
            this.Nuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtbConsulta
            // 
            this.txtbConsulta.Location = new System.Drawing.Point(139, 52);
            this.txtbConsulta.Name = "txtbConsulta";
            this.txtbConsulta.Size = new System.Drawing.Size(276, 20);
            this.txtbConsulta.TabIndex = 19;
            this.txtbConsulta.Text = "Buscar Segun denominacion";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(202, 391);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgvRaza
            // 
            this.dgvRaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nuevo,
            this.Consultar,
            this.Modificar});
            this.dgvRaza.Location = new System.Drawing.Point(96, 144);
            this.dgvRaza.Name = "dgvRaza";
            this.dgvRaza.Size = new System.Drawing.Size(335, 179);
            this.dgvRaza.TabIndex = 17;
            // 
            // Nuevo
            // 
            this.Nuevo.HeaderText = "Column1";
            this.Nuevo.Name = "Nuevo";
            // 
            // Consultar
            // 
            this.Consultar.HeaderText = "Column1";
            this.Consultar.Name = "Consultar";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Column1";
            this.Modificar.Name = "Modificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(350, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(81, 391);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.leather_black_minimalistic_1920x1080_wallpaper_www_wallpaperto_com_44;
            this.ClientSize = new System.Drawing.Size(517, 441);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtbConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvRaza);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Raza";
            this.Text = "Raza";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtbConsulta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
    }
}