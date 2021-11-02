
namespace WindowsFormsApp1
{
    partial class frmMenuPPAL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consulñtaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosPorRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoPorSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.síntomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMVacunacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioDeVacunaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInternacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeLaboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositosPorSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miselaneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PesoPorAlturaPorRazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCaninaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasPorAñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesPorSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDiasInternacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosPorConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeVacunadosDiariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulñtaToolStripMenuItem,
            this.vacunacionToolStripMenuItem,
            this.internacionToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.laboratoriosToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.miselaneoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consulñtaToolStripMenuItem
            // 
            this.consulñtaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaConsultaToolStripMenuItem,
            this.recetaToolStripMenuItem,
            this.historiaClinicaToolStripMenuItem,
            this.diagnosticoToolStripMenuItem,
            this.medicamentosPorRecetaToolStripMenuItem,
            this.depositoPorSucursalToolStripMenuItem,
            this.síntomasToolStripMenuItem});
            this.consulñtaToolStripMenuItem.Name = "consulñtaToolStripMenuItem";
            this.consulñtaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consulñtaToolStripMenuItem.Text = "Consulta";
            this.consulñtaToolStripMenuItem.Click += new System.EventHandler(this.consulñtaToolStripMenuItem_Click);
            // 
            // altaConsultaToolStripMenuItem
            // 
            this.altaConsultaToolStripMenuItem.Name = "altaConsultaToolStripMenuItem";
            this.altaConsultaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.altaConsultaToolStripMenuItem.Text = "Consulta";
            this.altaConsultaToolStripMenuItem.Click += new System.EventHandler(this.altaConsultaToolStripMenuItem_Click);
            // 
            // recetaToolStripMenuItem
            // 
            this.recetaToolStripMenuItem.Name = "recetaToolStripMenuItem";
            this.recetaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.recetaToolStripMenuItem.Text = "Receta";
            this.recetaToolStripMenuItem.Click += new System.EventHandler(this.recetaToolStripMenuItem_Click);
            // 
            // historiaClinicaToolStripMenuItem
            // 
            this.historiaClinicaToolStripMenuItem.Name = "historiaClinicaToolStripMenuItem";
            this.historiaClinicaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.historiaClinicaToolStripMenuItem.Text = "Historia Clínica";
            this.historiaClinicaToolStripMenuItem.Click += new System.EventHandler(this.historiaClinicaToolStripMenuItem_Click);
            // 
            // diagnosticoToolStripMenuItem
            // 
            this.diagnosticoToolStripMenuItem.Name = "diagnosticoToolStripMenuItem";
            this.diagnosticoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.diagnosticoToolStripMenuItem.Text = "Diagnóstico";
            this.diagnosticoToolStripMenuItem.Click += new System.EventHandler(this.diagnosticoToolStripMenuItem_Click);
            // 
            // medicamentosPorRecetaToolStripMenuItem
            // 
            this.medicamentosPorRecetaToolStripMenuItem.Name = "medicamentosPorRecetaToolStripMenuItem";
            this.medicamentosPorRecetaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.medicamentosPorRecetaToolStripMenuItem.Text = "Medicamentos por Receta";
            this.medicamentosPorRecetaToolStripMenuItem.Click += new System.EventHandler(this.medicamentosPorRecetaToolStripMenuItem_Click);
            // 
            // depositoPorSucursalToolStripMenuItem
            // 
            this.depositoPorSucursalToolStripMenuItem.Name = "depositoPorSucursalToolStripMenuItem";
            this.depositoPorSucursalToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.depositoPorSucursalToolStripMenuItem.Text = "Deposito por Sucursal";
            this.depositoPorSucursalToolStripMenuItem.Click += new System.EventHandler(this.depositoPorSucursalToolStripMenuItem_Click);
            // 
            // síntomasToolStripMenuItem
            // 
            this.síntomasToolStripMenuItem.Name = "síntomasToolStripMenuItem";
            this.síntomasToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.síntomasToolStripMenuItem.Text = "Síntomas";
            this.síntomasToolStripMenuItem.Click += new System.EventHandler(this.síntomasToolStripMenuItem_Click);
            // 
            // vacunacionToolStripMenuItem
            // 
            this.vacunacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMVacunacionToolStripMenuItem,
            this.calendarioDeVacunaciónToolStripMenuItem});
            this.vacunacionToolStripMenuItem.Name = "vacunacionToolStripMenuItem";
            this.vacunacionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vacunacionToolStripMenuItem.Text = "Vacunación";
            // 
            // aBMVacunacionToolStripMenuItem
            // 
            this.aBMVacunacionToolStripMenuItem.Name = "aBMVacunacionToolStripMenuItem";
            this.aBMVacunacionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.aBMVacunacionToolStripMenuItem.Text = "Vacunas";
            this.aBMVacunacionToolStripMenuItem.Click += new System.EventHandler(this.aBMVacunacionToolStripMenuItem_Click);
            // 
            // calendarioDeVacunaciónToolStripMenuItem
            // 
            this.calendarioDeVacunaciónToolStripMenuItem.Name = "calendarioDeVacunaciónToolStripMenuItem";
            this.calendarioDeVacunaciónToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calendarioDeVacunaciónToolStripMenuItem.Text = "Calendario de vacunación";
            this.calendarioDeVacunaciónToolStripMenuItem.Click += new System.EventHandler(this.calendarioDeVacunaciónToolStripMenuItem_Click);
            // 
            // internacionToolStripMenuItem
            // 
            this.internacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInternacionToolStripMenuItem});
            this.internacionToolStripMenuItem.Name = "internacionToolStripMenuItem";
            this.internacionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.internacionToolStripMenuItem.Text = "Internación";
            // 
            // menuInternacionToolStripMenuItem
            // 
            this.menuInternacionToolStripMenuItem.Name = "menuInternacionToolStripMenuItem";
            this.menuInternacionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.menuInternacionToolStripMenuItem.Text = "Menú Internación";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEstadisticaToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // menuEstadisticaToolStripMenuItem
            // 
            this.menuEstadisticaToolStripMenuItem.Name = "menuEstadisticaToolStripMenuItem";
            this.menuEstadisticaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.menuEstadisticaToolStripMenuItem.Text = "Menú Estadísticas";
            this.menuEstadisticaToolStripMenuItem.Click += new System.EventHandler(this.menuEstadisticaToolStripMenuItem_Click);
            // 
            // laboratoriosToolStripMenuItem
            // 
            this.laboratoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLaboratoriosToolStripMenuItem,
            this.informacionDeLaboratoriosToolStripMenuItem});
            this.laboratoriosToolStripMenuItem.Name = "laboratoriosToolStripMenuItem";
            this.laboratoriosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.laboratoriosToolStripMenuItem.Text = "Laboratorios";
            // 
            // menuLaboratoriosToolStripMenuItem
            // 
            this.menuLaboratoriosToolStripMenuItem.Name = "menuLaboratoriosToolStripMenuItem";
            this.menuLaboratoriosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.menuLaboratoriosToolStripMenuItem.Text = "Consulta de análisis";
            // 
            // informacionDeLaboratoriosToolStripMenuItem
            // 
            this.informacionDeLaboratoriosToolStripMenuItem.Name = "informacionDeLaboratoriosToolStripMenuItem";
            this.informacionDeLaboratoriosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.informacionDeLaboratoriosToolStripMenuItem.Text = "Información de laboratorios";
            this.informacionDeLaboratoriosToolStripMenuItem.Click += new System.EventHandler(this.informacionDeLaboratoriosToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucursalesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.depositosPorSucursalesToolStripMenuItem,
            this.medicamentosToolStripMenuItem});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.sucursalesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // depositosPorSucursalesToolStripMenuItem
            // 
            this.depositosPorSucursalesToolStripMenuItem.Name = "depositosPorSucursalesToolStripMenuItem";
            this.depositosPorSucursalesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.depositosPorSucursalesToolStripMenuItem.Text = "Depositos por Sucursales";
            this.depositosPorSucursalesToolStripMenuItem.Click += new System.EventHandler(this.depositosPorSucursalesToolStripMenuItem_Click);
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            this.medicamentosToolStripMenuItem.Click += new System.EventHandler(this.medicamentosToolStripMenuItem_Click);
            // 
            // miselaneoToolStripMenuItem
            // 
            this.miselaneoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.razaToolStripMenuItem,
            this.PesoPorAlturaPorRazaToolStripMenuItem});
            this.miselaneoToolStripMenuItem.Name = "miselaneoToolStripMenuItem";
            this.miselaneoToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.miselaneoToolStripMenuItem.Text = "Información Canes";
            // 
            // razaToolStripMenuItem
            // 
            this.razaToolStripMenuItem.Name = "razaToolStripMenuItem";
            this.razaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.razaToolStripMenuItem.Text = "Raza";
            this.razaToolStripMenuItem.Click += new System.EventHandler(this.razaToolStripMenuItem_Click);
            // 
            // PesoPorAlturaPorRazaToolStripMenuItem
            // 
            this.PesoPorAlturaPorRazaToolStripMenuItem.Name = "PesoPorAlturaPorRazaToolStripMenuItem";
            this.PesoPorAlturaPorRazaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.PesoPorAlturaPorRazaToolStripMenuItem.Text = "Peso por Altura por Raza";
            this.PesoPorAlturaPorRazaToolStripMenuItem.Click += new System.EventHandler(this.PesoPorAlturaPorRazaToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaCaninaToolStripMenuItem,
            this.recetaToolStripMenuItem2});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // consultaCaninaToolStripMenuItem
            // 
            this.consultaCaninaToolStripMenuItem.Name = "consultaCaninaToolStripMenuItem";
            this.consultaCaninaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.consultaCaninaToolStripMenuItem.Text = "Consulta Canina";
            this.consultaCaninaToolStripMenuItem.Click += new System.EventHandler(this.consultaCaninaToolStripMenuItem_Click);
            // 
            // recetaToolStripMenuItem2
            // 
            this.recetaToolStripMenuItem2.Name = "recetaToolStripMenuItem2";
            this.recetaToolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.recetaToolStripMenuItem2.Text = "Receta";
            this.recetaToolStripMenuItem2.Click += new System.EventHandler(this.recetaToolStripMenuItem2_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem1,
            this.consultasPorAñoToolStripMenuItem,
            this.promedioDiasInternacionToolStripMenuItem,
            this.pacientesPorSucursalToolStripMenuItem,
            this.medicamentosPorConsultaToolStripMenuItem,
            this.promedioDeVacunadosDiariosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // consultasPorAñoToolStripMenuItem
            // 
            this.consultasPorAñoToolStripMenuItem.Name = "consultasPorAñoToolStripMenuItem";
            this.consultasPorAñoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.consultasPorAñoToolStripMenuItem.Text = "Consultas por Año";
            this.consultasPorAñoToolStripMenuItem.Click += new System.EventHandler(this.consultasPorAñoToolStripMenuItem_Click);
            // 
            // pacientesPorSucursalToolStripMenuItem
            // 
            this.pacientesPorSucursalToolStripMenuItem.Name = "pacientesPorSucursalToolStripMenuItem";
            this.pacientesPorSucursalToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.pacientesPorSucursalToolStripMenuItem.Text = "Pacientes por Sucursal";
            this.pacientesPorSucursalToolStripMenuItem.Click += new System.EventHandler(this.pacientesPorSucursalToolStripMenuItem_Click);
            // 
            // promedioDiasInternacionToolStripMenuItem
            // 
            this.promedioDiasInternacionToolStripMenuItem.Name = "promedioDiasInternacionToolStripMenuItem";
            this.promedioDiasInternacionToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.promedioDiasInternacionToolStripMenuItem.Text = "Promedio Dias internacion";
            this.promedioDiasInternacionToolStripMenuItem.Click += new System.EventHandler(this.promedioDiasInternacionToolStripMenuItem_Click);
            // 
            // medicamentosPorConsultaToolStripMenuItem
            // 
            this.medicamentosPorConsultaToolStripMenuItem.Name = "medicamentosPorConsultaToolStripMenuItem";
            this.medicamentosPorConsultaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.medicamentosPorConsultaToolStripMenuItem.Text = "Medicamentos por receta";
            this.medicamentosPorConsultaToolStripMenuItem.Click += new System.EventHandler(this.medicamentosPorRecetasToolStripMenuItem_Click);
            // 
            // promedioDeVacunadosDiariosToolStripMenuItem
            // 
            this.promedioDeVacunadosDiariosToolStripMenuItem.Name = "promedioDeVacunadosDiariosToolStripMenuItem";
            this.promedioDeVacunadosDiariosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.promedioDeVacunadosDiariosToolStripMenuItem.Text = "Promedio de vacunados diarios";
            this.promedioDeVacunadosDiariosToolStripMenuItem.Click += new System.EventHandler(this.promedioDeVacunadosDiariosToolStripMenuItem_Click);
            // 
            // frmMenuPPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2021_09_07_at_15_52_30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 544);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPPAL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consulñtaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMVacunacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuInternacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEstadisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLaboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositosPorSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miselaneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDeLaboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosPorRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositoPorSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem síntomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioDeVacunaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCaninaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem PesoPorAlturaPorRazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasPorAñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesPorSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDiasInternacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosPorConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDeVacunadosDiariosToolStripMenuItem;
    }
}

