
namespace WindowsFormsApp1.Formularios.FORMULARIO_BASE
{
    partial class Formulario_Base_ABM
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(13, 13);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(80, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Titulo";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restriccion de calculo";
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(258, 392);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta.TabIndex = 3;
            this.btn_Alta.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btn_Alta, "Permite Ingresar un Alta al Formulario Peso por Altura por Raza");
            this.btn_Alta.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(383, 392);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btn_Modificar, "Permite el Ingreso al Formulario de Peso por Altura por Raza");
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(511, 392);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btn_eliminar, "Permite Ingresar para Eliminar algun formulario de Peso por Altura por Raza");
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Formulario_Base_ABM_Peso_x_Altura_x_Raza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 439);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Formulario_Base_ABM_Peso_x_Altura_x_Raza";
            this.Text = "Formulario_Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_titulo;
        protected System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}