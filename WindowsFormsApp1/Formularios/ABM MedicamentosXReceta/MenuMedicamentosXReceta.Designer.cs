
namespace WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta
{
    partial class MenuMedicamentosXReceta
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
            this.txtbConsulta = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.bD3K3G05_2021DataSet = new WindowsFormsApp1.BD3K3G05_2021DataSet();
            this.diagnosticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticoTableAdapter = new WindowsFormsApp1.BD3K3G05_2021DataSetTableAdapters.diagnosticoTableAdapter();
            this.bD3K3G052021DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2021DataSet1 = new WindowsFormsApp1.BD3K3G05_2021DataSet1();
            this.medicamentosXRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentosXRecetaTableAdapter = new WindowsFormsApp1.BD3K3G05_2021DataSet1TableAdapters.medicamentosXRecetaTableAdapter();
            this.iDrecetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmedicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodicidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052021DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosXRecetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(135, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtbConsulta
            // 
            this.txtbConsulta.Location = new System.Drawing.Point(262, 27);
            this.txtbConsulta.Name = "txtbConsulta";
            this.txtbConsulta.Size = new System.Drawing.Size(235, 20);
            this.txtbConsulta.TabIndex = 19;
            this.txtbConsulta.Text = "Buscar Segun ID Receta";
            this.txtbConsulta.TextChanged += new System.EventHandler(this.txtbConsulta_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(246, 404);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDrecetaDataGridViewTextBoxColumn,
            this.iDmedicamentoDataGridViewTextBoxColumn,
            this.periodicidadDataGridViewTextBoxColumn,
            this.dosisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicamentosXRecetaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 261);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(394, 404);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(125, 404);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // bD3K3G05_2021DataSet
            // 
            this.bD3K3G05_2021DataSet.DataSetName = "BD3K3G05_2021DataSet";
            this.bD3K3G05_2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosticoBindingSource
            // 
            this.diagnosticoBindingSource.DataMember = "diagnostico";
            this.diagnosticoBindingSource.DataSource = this.bD3K3G05_2021DataSet;
            // 
            // diagnosticoTableAdapter
            // 
            this.diagnosticoTableAdapter.ClearBeforeFill = true;
            // 
            // bD3K3G052021DataSetBindingSource
            // 
            this.bD3K3G052021DataSetBindingSource.DataSource = this.bD3K3G05_2021DataSet;
            this.bD3K3G052021DataSetBindingSource.Position = 0;
            // 
            // bD3K3G05_2021DataSet1
            // 
            this.bD3K3G05_2021DataSet1.DataSetName = "BD3K3G05_2021DataSet1";
            this.bD3K3G05_2021DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentosXRecetaBindingSource
            // 
            this.medicamentosXRecetaBindingSource.DataMember = "medicamentosXReceta";
            this.medicamentosXRecetaBindingSource.DataSource = this.bD3K3G05_2021DataSet1;
            // 
            // medicamentosXRecetaTableAdapter
            // 
            this.medicamentosXRecetaTableAdapter.ClearBeforeFill = true;
            // 
            // iDrecetaDataGridViewTextBoxColumn
            // 
            this.iDrecetaDataGridViewTextBoxColumn.DataPropertyName = "ID_receta";
            this.iDrecetaDataGridViewTextBoxColumn.HeaderText = "ID_receta";
            this.iDrecetaDataGridViewTextBoxColumn.Name = "iDrecetaDataGridViewTextBoxColumn";
            // 
            // iDmedicamentoDataGridViewTextBoxColumn
            // 
            this.iDmedicamentoDataGridViewTextBoxColumn.DataPropertyName = "ID_medicamento";
            this.iDmedicamentoDataGridViewTextBoxColumn.HeaderText = "ID_medicamento";
            this.iDmedicamentoDataGridViewTextBoxColumn.Name = "iDmedicamentoDataGridViewTextBoxColumn";
            this.iDmedicamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodicidadDataGridViewTextBoxColumn
            // 
            this.periodicidadDataGridViewTextBoxColumn.DataPropertyName = "Periodicidad";
            this.periodicidadDataGridViewTextBoxColumn.HeaderText = "Periodicidad";
            this.periodicidadDataGridViewTextBoxColumn.Name = "periodicidadDataGridViewTextBoxColumn";
            // 
            // dosisDataGridViewTextBoxColumn
            // 
            this.dosisDataGridViewTextBoxColumn.DataPropertyName = "Dosis";
            this.dosisDataGridViewTextBoxColumn.HeaderText = "Dosis";
            this.dosisDataGridViewTextBoxColumn.Name = "dosisDataGridViewTextBoxColumn";
            // 
            // MenuMedicamentosXReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Otros40;
            this.ClientSize = new System.Drawing.Size(600, 446);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtbConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuMedicamentosXReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuMedicamentosXReceta";
            this.Load += new System.EventHandler(this.MenuMedicamentosXReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052021DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosXRecetaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtbConsulta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private BD3K3G05_2021DataSet bD3K3G05_2021DataSet;
        private System.Windows.Forms.BindingSource diagnosticoBindingSource;
        private BD3K3G05_2021DataSetTableAdapters.diagnosticoTableAdapter diagnosticoTableAdapter;
        private System.Windows.Forms.BindingSource bD3K3G052021DataSetBindingSource;
        private BD3K3G05_2021DataSet1 bD3K3G05_2021DataSet1;
        private System.Windows.Forms.BindingSource medicamentosXRecetaBindingSource;
        private BD3K3G05_2021DataSet1TableAdapters.medicamentosXRecetaTableAdapter medicamentosXRecetaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDrecetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodicidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosisDataGridViewTextBoxColumn;
    }
}