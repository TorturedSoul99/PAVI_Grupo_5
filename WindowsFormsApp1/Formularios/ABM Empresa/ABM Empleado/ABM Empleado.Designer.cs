
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtbConsulta = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.Nuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(36, 51);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtbConsulta
            // 
            this.txtbConsulta.Location = new System.Drawing.Point(163, 54);
            this.txtbConsulta.Name = "txtbConsulta";
            this.txtbConsulta.Size = new System.Drawing.Size(235, 20);
            this.txtbConsulta.TabIndex = 13;
            this.txtbConsulta.Text = "Buscar Segun ID";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(203, 416);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nuevo,
            this.Consultar,
            this.Modificar});
            this.dgvEmpleado.Location = new System.Drawing.Point(105, 169);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(335, 179);
            this.dgvEmpleado.TabIndex = 11;
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
            this.btnEliminar.Location = new System.Drawing.Point(351, 416);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(82, 416);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ABM_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.leather_black_minimalistic_1920x1080_wallpaper_www_wallpaperto_com_44;
            this.ClientSize = new System.Drawing.Size(545, 469);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtbConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABM_Empleado";
            this.Text = "Menu Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtbConsulta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
    }
}