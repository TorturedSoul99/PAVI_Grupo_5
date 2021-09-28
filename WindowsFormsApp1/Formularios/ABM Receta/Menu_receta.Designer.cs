
namespace WindowsFormsApp1.Formularios.ABM_Receta
{
    partial class Menu_receta
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
            this.components = new System.ComponentModel.Container();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtbreceta = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.recetaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G052021DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2021DataSet2 = new WindowsFormsApp1.BD3K3G05_2021DataSet2();
            this.recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.recetaTableAdapter = new WindowsFormsApp1.BD3K3G05_2021DataSet2TableAdapters.recetaTableAdapter();
            this.dgvreceta = new WindowsFormsApp1.Back_end.DataGridView01();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052021DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreceta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(37, 27);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 32;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtbreceta
            // 
            this.txtbreceta.Location = new System.Drawing.Point(164, 30);
            this.txtbreceta.Name = "txtbreceta";
            this.txtbreceta.Size = new System.Drawing.Size(235, 20);
            this.txtbreceta.TabIndex = 31;
            this.txtbreceta.Text = "Buscar Segun ID";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(189, 354);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // recetaBindingSource1
            // 
            this.recetaBindingSource1.DataMember = "receta";
            this.recetaBindingSource1.DataSource = this.bD3K3G052021DataSet2BindingSource;
            // 
            // bD3K3G052021DataSet2BindingSource
            // 
            this.bD3K3G052021DataSet2BindingSource.DataSource = this.bD3K3G05_2021DataSet2;
            this.bD3K3G052021DataSet2BindingSource.Position = 0;
            // 
            // bD3K3G05_2021DataSet2
            // 
            this.bD3K3G05_2021DataSet2.DataSetName = "BD3K3G05_2021DataSet2";
            this.bD3K3G05_2021DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recetaBindingSource
            // 
            this.recetaBindingSource.DataMember = "receta";
            this.recetaBindingSource.DataSource = this.bD3K3G05_2021DataSet2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(337, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(68, 354);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // recetaTableAdapter
            // 
            this.recetaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvreceta
            // 
            this.dgvreceta.AllowUserToAddRows = false;
            this.dgvreceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_sucursal});
            this.dgvreceta.Location = new System.Drawing.Point(44, 91);
            this.dgvreceta.Name = "dgvreceta";
            this.dgvreceta.Size = new System.Drawing.Size(420, 234);
            this.dgvreceta.TabIndex = 33;
            this.dgvreceta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvreceta_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ID_sucursal
            // 
            this.ID_sucursal.HeaderText = "ID_sucursal";
            this.ID_sucursal.Name = "ID_sucursal";
            // 
            // Menu_receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.dgvreceta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtbreceta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_receta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Receta";
            this.Load += new System.EventHandler(this.Menu_receta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052021DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtbreceta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private BD3K3G05_2021DataSet2 bD3K3G05_2021DataSet2;
        private System.Windows.Forms.BindingSource recetaBindingSource;
        private BD3K3G05_2021DataSet2TableAdapters.recetaTableAdapter recetaTableAdapter;
        private System.Windows.Forms.BindingSource recetaBindingSource1;
        private System.Windows.Forms.BindingSource bD3K3G052021DataSet2BindingSource;
        private Back_end.DataGridView01 dgvreceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_sucursal;
    }
}