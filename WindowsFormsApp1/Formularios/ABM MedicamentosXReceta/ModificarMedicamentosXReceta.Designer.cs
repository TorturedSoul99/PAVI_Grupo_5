
namespace WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta
{
    partial class ModificarMedicamentosXReceta
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
            this.periodicidad = new System.Windows.Forms.TextBox();
            this.dosis = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblHC = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.bD3K3G05_2021DataSet4 = new WindowsFormsApp1.BD3K3G05_2021DataSet4();
            this.recetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetaTableAdapter = new WindowsFormsApp1.BD3K3G05_2021DataSet4TableAdapters.recetaTableAdapter();
            this.id = new WindowsFormsApp1.Back_end.ComboBox01();
            this.recetaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2021DataSet7 = new WindowsFormsApp1.BD3K3G05_2021DataSet7();
            this.medicamentos = new WindowsFormsApp1.Back_end.ComboBox01();
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2021DataSet8 = new WindowsFormsApp1.BD3K3G05_2021DataSet8();
            this.recetaTableAdapter1 = new WindowsFormsApp1.BD3K3G05_2021DataSet7TableAdapters.recetaTableAdapter();
            this.medicamentosTableAdapter = new WindowsFormsApp1.BD3K3G05_2021DataSet8TableAdapters.medicamentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // periodicidad
            // 
            this.periodicidad.Location = new System.Drawing.Point(142, 133);
            this.periodicidad.Name = "periodicidad";
            this.periodicidad.Size = new System.Drawing.Size(202, 20);
            this.periodicidad.TabIndex = 47;
            // 
            // dosis
            // 
            this.dosis.Location = new System.Drawing.Point(142, 99);
            this.dosis.Name = "dosis";
            this.dosis.Size = new System.Drawing.Size(202, 20);
            this.dosis.TabIndex = 46;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(89, 99);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(49, 20);
            this.lblEmpleado.TabIndex = 45;
            this.lblEmpleado.Text = "Dosis";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(43, 131);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(95, 20);
            this.lblDiagnostico.TabIndex = 44;
            this.lblDiagnostico.Text = "Periodicidad";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(12, 66);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(126, 20);
            this.lblSucursal.TabIndex = 43;
            this.lblSucursal.Text = "ID Medicamento";
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHC.Location = new System.Drawing.Point(56, 32);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(82, 20);
            this.lblHC.TabIndex = 41;
            this.lblHC.Text = "ID Receta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(269, 181);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.Text = "Modificar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // bD3K3G05_2021DataSet4
            // 
            this.bD3K3G05_2021DataSet4.DataSetName = "BD3K3G05_2021DataSet4";
            this.bD3K3G05_2021DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recetaBindingSource
            // 
            this.recetaBindingSource.DataMember = "receta";
            this.recetaBindingSource.DataSource = this.bD3K3G05_2021DataSet4;
            // 
            // recetaTableAdapter
            // 
            this.recetaTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id._ComboSinSeleccion = false;
            this.id._tabla_cargar_combo = null;
            this.id._tabla_cargar_condicion = null;
            this.id._tabla_cargar_descriptor = null;
            this.id._tabla_cargar_fk = null;
            this.id._tabla_cargar_pk = null;
            this.id._tabla_cargar_relacion = null;
            this.id._tabla_cargar_relacion_pk = null;
            this.id.DataSource = this.recetaBindingSource1;
            this.id.DisplayMember = "ID";
            this.id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id.Enabled = false;
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(142, 31);
            this.id.Name = "id";
            this.id.Pp_conseleccion = false;
            this.id.Pp_Descripcion = null;
            this.id.Pp_MessageError = null;
            this.id.Pp_Pk = null;
            this.id.Pp_Tabla = null;
            this.id.Size = new System.Drawing.Size(202, 21);
            this.id.TabIndex = 50;
            this.id.validable = false;
            // 
            // recetaBindingSource1
            // 
            this.recetaBindingSource1.DataMember = "receta";
            this.recetaBindingSource1.DataSource = this.bD3K3G05_2021DataSet7;
            // 
            // bD3K3G05_2021DataSet7
            // 
            this.bD3K3G05_2021DataSet7.DataSetName = "BD3K3G05_2021DataSet7";
            this.bD3K3G05_2021DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentos
            // 
            this.medicamentos._ComboSinSeleccion = false;
            this.medicamentos._tabla_cargar_combo = null;
            this.medicamentos._tabla_cargar_condicion = null;
            this.medicamentos._tabla_cargar_descriptor = null;
            this.medicamentos._tabla_cargar_fk = null;
            this.medicamentos._tabla_cargar_pk = null;
            this.medicamentos._tabla_cargar_relacion = null;
            this.medicamentos._tabla_cargar_relacion_pk = null;
            this.medicamentos.DataSource = this.medicamentosBindingSource;
            this.medicamentos.DisplayMember = "ID_medicamento";
            this.medicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicamentos.Enabled = false;
            this.medicamentos.FormattingEnabled = true;
            this.medicamentos.Location = new System.Drawing.Point(142, 66);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.Pp_conseleccion = false;
            this.medicamentos.Pp_Descripcion = null;
            this.medicamentos.Pp_MessageError = null;
            this.medicamentos.Pp_Pk = null;
            this.medicamentos.Pp_Tabla = null;
            this.medicamentos.Size = new System.Drawing.Size(202, 21);
            this.medicamentos.TabIndex = 51;
            this.medicamentos.validable = false;
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataMember = "medicamentos";
            this.medicamentosBindingSource.DataSource = this.bD3K3G05_2021DataSet8;
            // 
            // bD3K3G05_2021DataSet8
            // 
            this.bD3K3G05_2021DataSet8.DataSetName = "BD3K3G05_2021DataSet8";
            this.bD3K3G05_2021DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recetaTableAdapter1
            // 
            this.recetaTableAdapter1.ClearBeforeFill = true;
            // 
            // medicamentosTableAdapter
            // 
            this.medicamentosTableAdapter.ClearBeforeFill = true;
            // 
            // ModificarMedicamentosXReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(368, 217);
            this.Controls.Add(this.medicamentos);
            this.Controls.Add(this.id);
            this.Controls.Add(this.periodicidad);
            this.Controls.Add(this.dosis);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblHC);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarMedicamentosXReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarMedicamentosXReceta";
            this.Load += new System.EventHandler(this.ModificarMedicamentosXReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox periodicidad;
        private System.Windows.Forms.TextBox dosis;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblHC;
        private System.Windows.Forms.Button btnAgregar;
        private BD3K3G05_2021DataSet4 bD3K3G05_2021DataSet4;
        private System.Windows.Forms.BindingSource recetaBindingSource;
        private BD3K3G05_2021DataSet4TableAdapters.recetaTableAdapter recetaTableAdapter;
        private Back_end.ComboBox01 id;
        private Back_end.ComboBox01 medicamentos;
        private BD3K3G05_2021DataSet7 bD3K3G05_2021DataSet7;
        private System.Windows.Forms.BindingSource recetaBindingSource1;
        private BD3K3G05_2021DataSet7TableAdapters.recetaTableAdapter recetaTableAdapter1;
        private BD3K3G05_2021DataSet8 bD3K3G05_2021DataSet8;
        private System.Windows.Forms.BindingSource medicamentosBindingSource;
        private BD3K3G05_2021DataSet8TableAdapters.medicamentosTableAdapter medicamentosTableAdapter;
    }
}