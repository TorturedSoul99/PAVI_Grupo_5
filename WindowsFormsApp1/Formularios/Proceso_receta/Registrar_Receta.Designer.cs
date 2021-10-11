
namespace WindowsFormsApp1.Formularios.Proceso_receta
{
    partial class Registrar_Receta
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
            this.dgvReceta2 = new WindowsFormsApp1.Back_end.DataGridView01();
            this.ID_Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.recetaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2021DataSet10 = new WindowsFormsApp1.BD3K3G05_2021DataSet10();
            this.recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2021DataSet9 = new WindowsFormsApp1.BD3K3G05_2021DataSet9();
            this.recetaTableAdapter = new WindowsFormsApp1.BD3K3G05_2021DataSet9TableAdapters.recetaTableAdapter();
            this.recetaTableAdapter1 = new WindowsFormsApp1.BD3K3G05_2021DataSet10TableAdapters.recetaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceta2
            // 
            this.dgvReceta2.AllowUserToAddRows = false;
            this.dgvReceta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Receta,
            this.Nombre_Sucursal,
            this.Nombre_Medicamento,
            this.Periodicidad,
            this.Dosis});
            this.dgvReceta2.Location = new System.Drawing.Point(9, 85);
            this.dgvReceta2.Name = "dgvReceta2";
            this.dgvReceta2.Size = new System.Drawing.Size(718, 252);
            this.dgvReceta2.TabIndex = 0;
            this.dgvReceta2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView011_CellContentClick);
            // 
            // ID_Receta
            // 
            this.ID_Receta.HeaderText = "ID_Receta";
            this.ID_Receta.Name = "ID_Receta";
            // 
            // Nombre_Sucursal
            // 
            this.Nombre_Sucursal.HeaderText = "Nombre_Sucursal";
            this.Nombre_Sucursal.Name = "Nombre_Sucursal";
            // 
            // Nombre_Medicamento
            // 
            this.Nombre_Medicamento.HeaderText = "Nombre_Medicamento";
            this.Nombre_Medicamento.Name = "Nombre_Medicamento";
            // 
            // Periodicidad
            // 
            this.Periodicidad.HeaderText = "Periodicidad";
            this.Periodicidad.Name = "Periodicidad";
            // 
            // Dosis
            // 
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.Name = "Dosis";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(560, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar por id de recetra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registrar Receta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbID
            // 
            this.cbID.DataSource = this.recetaBindingSource1;
            this.cbID.DisplayMember = "ID";
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(418, 33);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 21);
            this.cbID.TabIndex = 5;
            this.cbID.ValueMember = "ID";
            // 
            // recetaBindingSource1
            // 
            this.recetaBindingSource1.DataMember = "receta";
            this.recetaBindingSource1.DataSource = this.bD3K3G05_2021DataSet10;
            // 
            // bD3K3G05_2021DataSet10
            // 
            this.bD3K3G05_2021DataSet10.DataSetName = "BD3K3G05_2021DataSet10";
            this.bD3K3G05_2021DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recetaBindingSource
            // 
            this.recetaBindingSource.DataMember = "receta";
            this.recetaBindingSource.DataSource = this.bD3K3G05_2021DataSet9;
            // 
            // bD3K3G05_2021DataSet9
            // 
            this.bD3K3G05_2021DataSet9.DataSetName = "BD3K3G05_2021DataSet9";
            this.bD3K3G05_2021DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recetaTableAdapter
            // 
            this.recetaTableAdapter.ClearBeforeFill = true;
            // 
            // recetaTableAdapter1
            // 
            this.recetaTableAdapter1.ClearBeforeFill = true;
            // 
            // Registrar_Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.leather_black_minimalistic_1920x1080_wallpaper_www_wallpaperto_com_44;
            this.ClientSize = new System.Drawing.Size(739, 410);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvReceta2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registrar_Receta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar_Receta";
            this.Load += new System.EventHandler(this.Registrar_Receta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Back_end.DataGridView01 dgvReceta2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodicidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.ComboBox cbID;
        private BD3K3G05_2021DataSet9 bD3K3G05_2021DataSet9;
        private System.Windows.Forms.BindingSource recetaBindingSource;
        private BD3K3G05_2021DataSet9TableAdapters.recetaTableAdapter recetaTableAdapter;
        private BD3K3G05_2021DataSet10 bD3K3G05_2021DataSet10;
        private System.Windows.Forms.BindingSource recetaBindingSource1;
        private BD3K3G05_2021DataSet10TableAdapters.recetaTableAdapter recetaTableAdapter1;
    }
}