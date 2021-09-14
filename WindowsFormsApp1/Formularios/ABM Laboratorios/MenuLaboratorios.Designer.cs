
namespace WindowsFormsApp1.Formularios
{
    partial class MenuLaboratorios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(16, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtbConsulta
            // 
            this.txtbConsulta.Location = new System.Drawing.Point(129, 27);
            this.txtbConsulta.Name = "txtbConsulta";
            this.txtbConsulta.Size = new System.Drawing.Size(235, 20);
            this.txtbConsulta.TabIndex = 21;
            this.txtbConsulta.Text = "Buscar Nombre de laboratorio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nuevo,
            this.Consultar,
            this.Modificar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 179);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(16, 352);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(90, 23);
            this.btnagregar.TabIndex = 24;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(168, 352);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 23);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(315, 352);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 23);
            this.btneliminar.TabIndex = 26;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // Nuevo
            // 
            this.Nuevo.HeaderText = "ID";
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Visible = false;
            // 
            // Consultar
            // 
            this.Consultar.HeaderText = "Nombre";
            this.Consultar.Name = "Consultar";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Descripcion";
            this.Modificar.Name = "Modificar";
            this.Modificar.Width = 250;
            // 
            // MenuLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.leather_black_minimalistic_1920x1080_wallpaper_www_wallpaperto_com_44;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 412);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtbConsulta);
            this.DoubleBuffered = true;
            this.Name = "MenuLaboratorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Laboratorios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtbConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btneliminar;
    }
}