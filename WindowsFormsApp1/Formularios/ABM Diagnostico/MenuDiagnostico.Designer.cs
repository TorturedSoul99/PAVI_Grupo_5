
namespace WindowsFormsApp1.Formularios.ABM_Diagnostico
{
    partial class MenuDiagnostico
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.diagnosticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2021DataSet = new WindowsFormsApp1.BD3K3G05_2021DataSet();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.diagnosticoTableAdapter = new WindowsFormsApp1.BD3K3G05_2021DataSetTableAdapters.diagnosticoTableAdapter();
            this.txtbConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gdDiagnostico = new WindowsFormsApp1.Back_end.DataGridView01();
            this.ID_diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(185, 427);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // diagnosticoBindingSource
            // 
            this.diagnosticoBindingSource.DataMember = "diagnostico";
            this.diagnosticoBindingSource.DataSource = this.bD3K3G05_2021DataSet;
            // 
            // bD3K3G05_2021DataSet
            // 
            this.bD3K3G05_2021DataSet.DataSetName = "BD3K3G05_2021DataSet";
            this.bD3K3G05_2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(333, 427);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(64, 427);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // diagnosticoTableAdapter
            // 
            this.diagnosticoTableAdapter.ClearBeforeFill = true;
            // 
            // txtbConsulta
            // 
            this.txtbConsulta.Location = new System.Drawing.Point(89, 37);
            this.txtbConsulta.Name = "txtbConsulta";
            this.txtbConsulta.Size = new System.Drawing.Size(235, 20);
            this.txtbConsulta.TabIndex = 13;
            this.txtbConsulta.Text = "Escriba el nombre del  diagnostico";
            this.txtbConsulta.TextChanged += new System.EventHandler(this.txtbConsulta_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(320, 72);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gdDiagnostico
            // 
            this.gdDiagnostico.AllowUserToAddRows = false;
            this.gdDiagnostico.AllowUserToDeleteRows = false;
            this.gdDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdDiagnostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_diagnostico,
            this.Nombre});
            this.gdDiagnostico.Location = new System.Drawing.Point(61, 135);
            this.gdDiagnostico.Name = "gdDiagnostico";
            this.gdDiagnostico.ReadOnly = true;
            this.gdDiagnostico.Size = new System.Drawing.Size(398, 267);
            this.gdDiagnostico.TabIndex = 15;
            this.gdDiagnostico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView011_CellContentClick);
            // 
            // ID_diagnostico
            // 
            this.ID_diagnostico.HeaderText = "ID_diagnostico";
            this.ID_diagnostico.Name = "ID_diagnostico";
            this.ID_diagnostico.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // MenuDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Otros40;
            this.ClientSize = new System.Drawing.Size(507, 466);
            this.Controls.Add(this.gdDiagnostico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtbConsulta);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuDiagnostico";
            this.Load += new System.EventHandler(this.MenuDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private BD3K3G05_2021DataSet bD3K3G05_2021DataSet;
        private System.Windows.Forms.BindingSource diagnosticoBindingSource;
        private BD3K3G05_2021DataSetTableAdapters.diagnosticoTableAdapter diagnosticoTableAdapter;
        private System.Windows.Forms.TextBox txtbConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private Back_end.DataGridView01 gdDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}