
namespace WindowsFormsApp1.Formularios.ABM_Receta
{
    partial class Modificar_receta
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.cmb_sucursal = new System.Windows.Forms.ComboBox();
            this.lbl_medicamento = new System.Windows.Forms.Label();
            this.bD3K3G05_2021DataSet5 = new WindowsFormsApp1.BD3K3G05_2021DataSet5();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalTableAdapter = new WindowsFormsApp1.BD3K3G05_2021DataSet5TableAdapters.sucursalTableAdapter();
            this.sucursalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2021DataSet6 = new WindowsFormsApp1.BD3K3G05_2021DataSet6();
            this.sucursalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalTableAdapter1 = new WindowsFormsApp1.BD3K3G05_2021DataSet6TableAdapters.sucursalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(345, 100);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(78, 26);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.DataSource = this.sucursalBindingSource2;
            this.cmb_sucursal.DisplayMember = "ID_sucursal";
            this.cmb_sucursal.FormattingEnabled = true;
            this.cmb_sucursal.Location = new System.Drawing.Point(182, 35);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Size = new System.Drawing.Size(241, 21);
            this.cmb_sucursal.TabIndex = 4;
            // 
            // lbl_medicamento
            // 
            this.lbl_medicamento.AutoSize = true;
            this.lbl_medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medicamento.Location = new System.Drawing.Point(105, 35);
            this.lbl_medicamento.Name = "lbl_medicamento";
            this.lbl_medicamento.Size = new System.Drawing.Size(71, 20);
            this.lbl_medicamento.TabIndex = 3;
            this.lbl_medicamento.Text = "Sucursal";
            // 
            // bD3K3G05_2021DataSet5
            // 
            this.bD3K3G05_2021DataSet5.DataSetName = "BD3K3G05_2021DataSet5";
            this.bD3K3G05_2021DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataMember = "sucursal";
            this.sucursalBindingSource.DataSource = this.bD3K3G05_2021DataSet5;
            // 
            // sucursalTableAdapter
            // 
            this.sucursalTableAdapter.ClearBeforeFill = true;
            // 
            // sucursalBindingSource1
            // 
            this.sucursalBindingSource1.DataMember = "sucursal";
            this.sucursalBindingSource1.DataSource = this.bD3K3G05_2021DataSet5;
            // 
            // bD3K3G05_2021DataSet6
            // 
            this.bD3K3G05_2021DataSet6.DataSetName = "BD3K3G05_2021DataSet6";
            this.bD3K3G05_2021DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sucursalBindingSource2
            // 
            this.sucursalBindingSource2.DataMember = "sucursal";
            this.sucursalBindingSource2.DataSource = this.bD3K3G05_2021DataSet6;
            // 
            // sucursalTableAdapter1
            // 
            this.sucursalTableAdapter1.ClearBeforeFill = true;
            // 
            // Modificar_receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Windows_7_02;
            this.ClientSize = new System.Drawing.Size(446, 161);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.cmb_sucursal);
            this.Controls.Add(this.lbl_medicamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificar_receta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Receta";
            this.Load += new System.EventHandler(this.Modificar_receta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2021DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.ComboBox cmb_sucursal;
        private System.Windows.Forms.Label lbl_medicamento;
        private BD3K3G05_2021DataSet5 bD3K3G05_2021DataSet5;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private BD3K3G05_2021DataSet5TableAdapters.sucursalTableAdapter sucursalTableAdapter;
        private System.Windows.Forms.BindingSource sucursalBindingSource1;
        private BD3K3G05_2021DataSet6 bD3K3G05_2021DataSet6;
        private System.Windows.Forms.BindingSource sucursalBindingSource2;
        private BD3K3G05_2021DataSet6TableAdapters.sucursalTableAdapter sucursalTableAdapter1;
    }
}