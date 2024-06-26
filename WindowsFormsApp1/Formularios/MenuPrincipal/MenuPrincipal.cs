﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado;
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales;
using WindowsFormsApp1.Formularios.ABM_Laboratorios;
using WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza;
using WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Peso_x_Altura_x_Raza;
using WindowsFormsApp1.Formularios.ABM_Vacunacion;
using WindowsFormsApp1.Formularios.ABM_Receta;
using WindowsFormsApp1.Formularios.ABM_Diagnostico;
using WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta;
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos;
using WindowsFormsApp1.Formularios.ABM_DepositoXSucursal;
using WindowsFormsApp1.Formularios.ABM_CalendarioVacunas;
using WindowsFormsApp1.Formularios.ABM_Sintomas;
using WindowsFormsApp1.Formularios.AMB_HistoriaClinica;
using WindowsFormsApp1.Formularios.Proceso_receta;
using WindowsFormsApp1.Formularios.Proceso_Consulta;
using WindowsFormsApp1.Formularios.ABM_InformacionCanes;
using WindowsFormsApp1.Formularios.Reportes;
using WindowsFormsApp1.Formularios.Reportes.Reporte_peso_altura_x_raza;
using WindowsFormsApp1.Formularios.Reportes.ReporteEmpleado;
using WindowsFormsApp1.Formularios.Reportes.ReporteConsulta;
using WindowsFormsApp1.Formularios.Reportes.ReportePacientes_x_Sucursal;
using WindowsFormsApp1.Formularios.Reportes.ReportesMedicamentos;
using WindowsFormsApp1.Formularios.Reportes.PromedioDiasInternados;
using WindowsFormsApp1.Formularios.Reportes.MedicamentosPorSucursal;
using WindowsFormsApp1.Formularios.Reportes.ReportePromedioDeVacunadosDiarios;
using WindowsFormsApp1.Formularios.Estadisticas.ConsultasPorAño;
using WindowsFormsApp1.Formularios.Estadisticas.MedicamentosPorAño;
using WindowsFormsApp1.Formularios.Estadisticas.ConsultaPorSucursalesPorAño;
using WindowsFormsApp1.Formularios.Estadisticas.EmpleadoConMasConsultas;
using WindowsFormsApp1.Formularios.Estadisticas.VacunasXSucursal;
using WindowsFormsApp1.Formularios.Estadisticas.RazasXConsulta;
using WindowsFormsApp1.Formularios.Estadisticas.Diagnosticos_mas_frecuentes;
namespace WindowsFormsApp1
{
    public partial class frmMenuPPAL : Form
    {
        public frmMenuPPAL()
        {
            InitializeComponent();
        }

        private void consulñtaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_inicio_de_sesion inicio = new frm_inicio_de_sesion();
            inicio.ShowDialog();

        }

        private void altaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConsulta menuConsulta = new MenuConsulta();
            menuConsulta.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Empleado aBM_Empleado = new ABM_Empleado();
            aBM_Empleado.ShowDialog();

        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMSucursales aBMSucursales = new ABMSucursales();
            aBMSucursales.ShowDialog();

        }

        private void informacionDeLaboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuLaboratorios menu_lab = new MenuLaboratorios();
            menu_lab.ShowDialog();
        }

        private void razaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raza abm_raza = new Raza();
            abm_raza.ShowDialog();
        }

        private void aBMVacunacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuVacunas menu_vac = new MenuVacunas();
            menu_vac.ShowDialog();
        }

        private void recetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_receta men_receta = new Menu_receta();
            men_receta.ShowDialog();
        }

        private void frmMenuPPAL_Load(object sender, EventArgs e)
        {
            frm_inicio_de_sesion inicio = new frm_inicio_de_sesion();
            inicio.ShowDialog();
            inicio.Dispose();
        }

        private void menuEstadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuDiagnostico menu = new MenuDiagnostico();
            menu.ShowDialog();
        }

        private void medicamentosPorRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuMedicamentosXReceta menu = new MenuMedicamentosXReceta();
            menu.ShowDialog();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_medicamentos abm_medicamentos = new Menu_medicamentos();
            abm_medicamentos.ShowDialog();
        }

        private void depositoPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMdeposito_x_sucursal menu_deposito_x_sucursal = new ABMdeposito_x_sucursal();
            menu_deposito_x_sucursal.ShowDialog();
        }

        private void depositosPorSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMdeposito_x_sucursal menu_deposito_x_sucu = new ABMdeposito_x_sucursal();
            menu_deposito_x_sucu.ShowDialog();
        }

        private void síntomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Sintomas sintomas = new ABM_Sintomas();
            sintomas.ShowDialog();
        }

        private void calendarioDeVacunaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_CalendarioVacunas calendario_vacunas = new ABM_CalendarioVacunas();
            calendario_vacunas.ShowDialog();
        }

        private void historiaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_HistoriaClinica HC = new Menu_HistoriaClinica();
            HC.ShowDialog();
        }

        private void RecetaStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void recetaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void consultaCaninaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proceso_Consulta_Para_Canes consulta = new Proceso_Consulta_Para_Canes();
            consulta.ShowDialog();
        }

        private void recetaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Registrar_Receta regRe = new Registrar_Receta();
            regRe.ShowDialog();
        }

        private void PesoPorAlturaPorRazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peso_x_altura_x_Raza peso_altura = new Peso_x_altura_x_Raza();
            peso_altura.ShowDialog();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporte_empleado rep_emple = new Reporte_empleado();
            rep_emple.ShowDialog();
        }

        private void consultasPorAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_consulta rptconsulta = new Reporte_consulta();
            rptconsulta.ShowDialog();
        }

        private void pacientesPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_pacientes_x_sucursal rpt_pacientes_sucursal = new Reporte_pacientes_x_sucursal();
            rpt_pacientes_sucursal.ShowDialog();
        }

        private void medicamentosPorRecetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_reportes_medicamentos rep_med = new Frm_reportes_medicamentos();
            rep_med.ShowDialog();
        }

        private void promedioDiasInternacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromedioDiasInternados promedioDiasInternados = new PromedioDiasInternados();
            promedioDiasInternados.ShowDialog();

        }

        private void medicamentosPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_reportes_depositos_x_sucursales med_sucu = new Frm_reportes_depositos_x_sucursales();
            med_sucu.ShowDialog();
        }

        private void promedioDeVacunadosDiariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVacunadosDiarios repo = new ReporteVacunadosDiarios();
            repo.ShowDialog();

        }

        private void cantidadConsultasPorAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadistica_consultas_x_año consulta_x_año = new Estadistica_consultas_x_año();
            consulta_x_año.ShowDialog();
        }

        private void medicamentosPorAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MedicamentosPorAnno medicamento = new Frm_MedicamentosPorAnno();
            medicamento.ShowDialog();
        }

        private void consultasPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Consulta_por_sucursal_por_anno consulta = new Frm_Consulta_por_sucursal_por_anno();
            consulta.ShowDialog();
        }

        private void vacunasPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacunasPorSucursal vacunas = new VacunasPorSucursal();
            vacunas.ShowDialog();
        }

        private void diagnosticosMasFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiagnosticosMasFrecuentes diag = new DiagnosticosMasFrecuentes();
            diag.ShowDialog();
        }

        private void consultasSegunLaRazaDelCanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CantidadDeCanesXRazaXConsulta cant = new CantidadDeCanesXRazaXConsulta();
            cant.ShowDialog();
        }

        private void consultasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadistica_empleado_con_mas_consultas emple = new Estadistica_empleado_con_mas_consultas();
            emple.ShowDialog();
        }
    }
}
