
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cmb_medicamento = new System.Windows.Forms.ComboBox();
            this.lbl_medicamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(345, 100);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(78, 26);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // cmb_medicamento
            // 
            this.cmb_medicamento.FormattingEnabled = true;
            this.cmb_medicamento.Location = new System.Drawing.Point(182, 35);
            this.cmb_medicamento.Name = "cmb_medicamento";
            this.cmb_medicamento.Size = new System.Drawing.Size(241, 21);
            this.cmb_medicamento.TabIndex = 4;
            // 
            // lbl_medicamento
            // 
            this.lbl_medicamento.AutoSize = true;
            this.lbl_medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medicamento.Location = new System.Drawing.Point(24, 36);
            this.lbl_medicamento.Name = "lbl_medicamento";
            this.lbl_medicamento.Size = new System.Drawing.Size(105, 20);
            this.lbl_medicamento.TabIndex = 3;
            this.lbl_medicamento.Text = "Medicamento";
            // 
            // Modificar_receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 161);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_medicamento);
            this.Controls.Add(this.lbl_medicamento);
            this.Name = "Modificar_receta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Receta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cmb_medicamento;
        private System.Windows.Forms.Label lbl_medicamento;
    }
}