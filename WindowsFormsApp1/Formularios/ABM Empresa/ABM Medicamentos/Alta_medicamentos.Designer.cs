﻿
namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos
{
    partial class Alta_medicamentos
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_sucursal_medicamentos = new System.Windows.Forms.Label();
            this.lbl_fecha_compra = new System.Windows.Forms.Label();
            this.lbl_laboratorio_medicamento = new System.Windows.Forms.Label();
            this.lbl_nombre_medicamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(288, 279);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(81, 27);
            this.btn_agregar.TabIndex = 25;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(169, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // lbl_sucursal_medicamentos
            // 
            this.lbl_sucursal_medicamentos.AutoSize = true;
            this.lbl_sucursal_medicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sucursal_medicamentos.Location = new System.Drawing.Point(92, 211);
            this.lbl_sucursal_medicamentos.Name = "lbl_sucursal_medicamentos";
            this.lbl_sucursal_medicamentos.Size = new System.Drawing.Size(71, 20);
            this.lbl_sucursal_medicamentos.TabIndex = 16;
            this.lbl_sucursal_medicamentos.Text = "Sucursal";
            // 
            // lbl_fecha_compra
            // 
            this.lbl_fecha_compra.AutoSize = true;
            this.lbl_fecha_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_compra.Location = new System.Drawing.Point(30, 163);
            this.lbl_fecha_compra.Name = "lbl_fecha_compra";
            this.lbl_fecha_compra.Size = new System.Drawing.Size(133, 20);
            this.lbl_fecha_compra.TabIndex = 15;
            this.lbl_fecha_compra.Text = "Fecha de compra";
            // 
            // lbl_laboratorio_medicamento
            // 
            this.lbl_laboratorio_medicamento.AutoSize = true;
            this.lbl_laboratorio_medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_laboratorio_medicamento.Location = new System.Drawing.Point(73, 113);
            this.lbl_laboratorio_medicamento.Name = "lbl_laboratorio_medicamento";
            this.lbl_laboratorio_medicamento.Size = new System.Drawing.Size(90, 20);
            this.lbl_laboratorio_medicamento.TabIndex = 14;
            this.lbl_laboratorio_medicamento.Text = "Laboratorio";
            // 
            // lbl_nombre_medicamento
            // 
            this.lbl_nombre_medicamento.AutoSize = true;
            this.lbl_nombre_medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_medicamento.Location = new System.Drawing.Point(98, 60);
            this.lbl_nombre_medicamento.Name = "lbl_nombre_medicamento";
            this.lbl_nombre_medicamento.Size = new System.Drawing.Size(65, 20);
            this.lbl_nombre_medicamento.TabIndex = 13;
            this.lbl_nombre_medicamento.Text = "Nombre";
            // 
            // Alta_medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 324);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_sucursal_medicamentos);
            this.Controls.Add(this.lbl_fecha_compra);
            this.Controls.Add(this.lbl_laboratorio_medicamento);
            this.Controls.Add(this.lbl_nombre_medicamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta_medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Medicamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_sucursal_medicamentos;
        private System.Windows.Forms.Label lbl_fecha_compra;
        private System.Windows.Forms.Label lbl_laboratorio_medicamento;
        private System.Windows.Forms.Label lbl_nombre_medicamento;
    }
}