
namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes
{
    partial class Peso_x_altura_x_Raza
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
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txt_denominacion = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grid_Peso_altura_raza = new System.Windows.Forms.DataGridView();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso_maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura_media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Peso_altura_raza)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(133, 42);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 29;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(6, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txt_denominacion
            // 
            this.txt_denominacion.Location = new System.Drawing.Point(133, 11);
            this.txt_denominacion.Name = "txt_denominacion";
            this.txt_denominacion.Size = new System.Drawing.Size(276, 20);
            this.txt_denominacion.TabIndex = 27;
            this.txt_denominacion.Text = "Buscar Segun denominacion...";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(499, 309);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grid_Peso_altura_raza
            // 
            this.grid_Peso_altura_raza.AllowUserToAddRows = false;
            this.grid_Peso_altura_raza.AllowUserToDeleteRows = false;
            this.grid_Peso_altura_raza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Peso_altura_raza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denominacion,
            this.Sexo,
            this.Peso_minimo,
            this.Peso_maximo,
            this.Altura_media});
            this.grid_Peso_altura_raza.Location = new System.Drawing.Point(75, 89);
            this.grid_Peso_altura_raza.Name = "grid_Peso_altura_raza";
            this.grid_Peso_altura_raza.ReadOnly = true;
            this.grid_Peso_altura_raza.Size = new System.Drawing.Size(543, 179);
            this.grid_Peso_altura_raza.TabIndex = 25;
            this.grid_Peso_altura_raza.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Peso_altura_raza_CellClick);
            this.grid_Peso_altura_raza.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Peso_altura_raza_CellDoubleClick);
            // 
            // Denominacion
            // 
            this.Denominacion.HeaderText = "Denominacion";
            this.Denominacion.Name = "Denominacion";
            this.Denominacion.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Peso_minimo
            // 
            this.Peso_minimo.HeaderText = "Peso Minimo";
            this.Peso_minimo.Name = "Peso_minimo";
            this.Peso_minimo.ReadOnly = true;
            // 
            // Peso_maximo
            // 
            this.Peso_maximo.HeaderText = "Peso Maximo";
            this.Peso_maximo.Name = "Peso_maximo";
            this.Peso_maximo.ReadOnly = true;
            // 
            // Altura_media
            // 
            this.Altura_media.HeaderText = "Altura Media";
            this.Altura_media.Name = "Altura_media";
            this.Altura_media.ReadOnly = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(378, 309);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Peso_x_altura_x_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 344);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txt_denominacion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grid_Peso_altura_raza);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Peso_x_altura_x_Raza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peso_x_altura_x_Raza";
            this.Load += new System.EventHandler(this.Peso_x_altura_x_Raza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Peso_altura_raza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txt_denominacion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView grid_Peso_altura_raza;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso_maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura_media;
    }
}