
namespace WindowsFormsApp1.Formularios.Proceso_Consulta
{
    partial class Proceso_Consulta_Para_Canes
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
            this.DGW_Perros = new System.Windows.Forms.DataGridView();
            this.DGW_Consultas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombrePerro = new System.Windows.Forms.TextBox();
            this.txt_registrarPerro = new System.Windows.Forms.Button();
            this.txt_BuscarNombrePerro = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ctn_BuscarTodasConsultas = new System.Windows.Forms.Button();
            this.Nro_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_historia_clinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Histo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_sucursalPerro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_agregarConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Perros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Consultas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGW_Perros
            // 
            this.DGW_Perros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Perros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Histo,
            this.ID_sucursalPerro,
            this.Nombre,
            this.Raza,
            this.Nombre_dueño,
            this.Apellido_Dueño,
            this.N_telefono});
            this.DGW_Perros.Location = new System.Drawing.Point(328, 72);
            this.DGW_Perros.Name = "DGW_Perros";
            this.DGW_Perros.Size = new System.Drawing.Size(534, 152);
            this.DGW_Perros.TabIndex = 0;
            this.DGW_Perros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_Perros_CellContentClick);
            this.DGW_Perros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_Perros_CellContentDoubleClick);
            // 
            // DGW_Consultas
            // 
            this.DGW_Consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Consultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Orden,
            this.Nro_historia_clinica,
            this.ID_sucursal,
            this.Fecha_entrada,
            this.ID_Empleado,
            this.Fecha_salida});
            this.DGW_Consultas.Location = new System.Drawing.Point(328, 377);
            this.DGW_Consultas.Name = "DGW_Consultas";
            this.DGW_Consultas.Size = new System.Drawing.Size(534, 223);
            this.DGW_Consultas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por Nombre de Perro";
            // 
            // txt_nombrePerro
            // 
            this.txt_nombrePerro.Location = new System.Drawing.Point(473, 27);
            this.txt_nombrePerro.Name = "txt_nombrePerro";
            this.txt_nombrePerro.Size = new System.Drawing.Size(191, 20);
            this.txt_nombrePerro.TabIndex = 3;
            // 
            // txt_registrarPerro
            // 
            this.txt_registrarPerro.Location = new System.Drawing.Point(748, 230);
            this.txt_registrarPerro.Name = "txt_registrarPerro";
            this.txt_registrarPerro.Size = new System.Drawing.Size(114, 23);
            this.txt_registrarPerro.TabIndex = 4;
            this.txt_registrarPerro.Text = "Registrar Perro";
            this.txt_registrarPerro.UseVisualStyleBackColor = true;
            this.txt_registrarPerro.Click += new System.EventHandler(this.txt_registrarPerro_Click);
            // 
            // txt_BuscarNombrePerro
            // 
            this.txt_BuscarNombrePerro.Location = new System.Drawing.Point(694, 25);
            this.txt_BuscarNombrePerro.Name = "txt_BuscarNombrePerro";
            this.txt_BuscarNombrePerro.Size = new System.Drawing.Size(75, 23);
            this.txt_BuscarNombrePerro.TabIndex = 5;
            this.txt_BuscarNombrePerro.Text = "Buscar";
            this.txt_BuscarNombrePerro.UseVisualStyleBackColor = true;
            this.txt_BuscarNombrePerro.Click += new System.EventHandler(this.txt_BuscarNombrePerro_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "Consultas";
            // 
            // ctn_BuscarTodasConsultas
            // 
            this.ctn_BuscarTodasConsultas.Location = new System.Drawing.Point(707, 349);
            this.ctn_BuscarTodasConsultas.Name = "ctn_BuscarTodasConsultas";
            this.ctn_BuscarTodasConsultas.Size = new System.Drawing.Size(155, 23);
            this.ctn_BuscarTodasConsultas.TabIndex = 9;
            this.ctn_BuscarTodasConsultas.Text = "Buscar todas las Consultas";
            this.ctn_BuscarTodasConsultas.UseVisualStyleBackColor = true;
            this.ctn_BuscarTodasConsultas.Click += new System.EventHandler(this.ctn_BuscarTodasConsultas_Click);
            // 
            // Nro_Orden
            // 
            this.Nro_Orden.HeaderText = "Numero de Orden";
            this.Nro_Orden.Name = "Nro_Orden";
            // 
            // Nro_historia_clinica
            // 
            this.Nro_historia_clinica.HeaderText = "Historia Clinica";
            this.Nro_historia_clinica.Name = "Nro_historia_clinica";
            // 
            // ID_sucursal
            // 
            this.ID_sucursal.HeaderText = "Sucursal";
            this.ID_sucursal.Name = "ID_sucursal";
            // 
            // Fecha_entrada
            // 
            this.Fecha_entrada.HeaderText = "Fecha de Entrada";
            this.Fecha_entrada.Name = "Fecha_entrada";
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.HeaderText = "Empleado";
            this.ID_Empleado.Name = "ID_Empleado";
            // 
            // Fecha_salida
            // 
            this.Fecha_salida.HeaderText = "Fecha de Salida";
            this.Fecha_salida.Name = "Fecha_salida";
            // 
            // N_Histo
            // 
            this.N_Histo.HeaderText = "Numero Historia Clinica";
            this.N_Histo.Name = "N_Histo";
            this.N_Histo.Visible = false;
            // 
            // ID_sucursalPerro
            // 
            this.ID_sucursalPerro.HeaderText = "SucursalPerro";
            this.ID_sucursalPerro.Name = "ID_sucursalPerro";
            this.ID_sucursalPerro.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            // 
            // Nombre_dueño
            // 
            this.Nombre_dueño.HeaderText = "Nombre Dueño";
            this.Nombre_dueño.Name = "Nombre_dueño";
            // 
            // Apellido_Dueño
            // 
            this.Apellido_Dueño.HeaderText = "Apellido Dueño";
            this.Apellido_Dueño.Name = "Apellido_Dueño";
            // 
            // N_telefono
            // 
            this.N_telefono.HeaderText = "Numero de telefono";
            this.N_telefono.Name = "N_telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero de Historia Clinica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sintoma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Diagnostico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Receta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-1, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 632);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btn_agregarConsulta
            // 
            this.btn_agregarConsulta.Location = new System.Drawing.Point(748, 624);
            this.btn_agregarConsulta.Name = "btn_agregarConsulta";
            this.btn_agregarConsulta.Size = new System.Drawing.Size(114, 23);
            this.btn_agregarConsulta.TabIndex = 10;
            this.btn_agregarConsulta.Text = "Agregar Consulta";
            this.btn_agregarConsulta.UseVisualStyleBackColor = true;
            this.btn_agregarConsulta.Click += new System.EventHandler(this.btn_agregarConsulta_Click);
            // 
            // Proceso_Consulta_Para_Canes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 659);
            this.Controls.Add(this.btn_agregarConsulta);
            this.Controls.Add(this.ctn_BuscarTodasConsultas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_BuscarNombrePerro);
            this.Controls.Add(this.txt_registrarPerro);
            this.Controls.Add(this.txt_nombrePerro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGW_Consultas);
            this.Controls.Add(this.DGW_Perros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Proceso_Consulta_Para_Canes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Para Canes";
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Perros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Consultas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW_Perros;
        private System.Windows.Forms.DataGridView DGW_Consultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombrePerro;
        private System.Windows.Forms.Button txt_registrarPerro;
        private System.Windows.Forms.Button txt_BuscarNombrePerro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ctn_BuscarTodasConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_historia_clinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Histo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_sucursalPerro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_telefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_agregarConsulta;
    }
}