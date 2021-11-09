using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Negocio;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1.Formularios.Estadisticas.EmpleadoConMasConsultas
{
    public partial class Estadistica_empleado_con_mas_consultas : Form
    {
        public Estadistica_empleado_con_mas_consultas()
        {
            InitializeComponent();
        }

        private void Estadistica_empleado_con_mas_consultas_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
            this.rv01.RefreshReport();
            this.rv01.RefreshReport();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            NE_consulta consulta = new NE_consulta();
            DataTable tabla = new DataTable();
            tabla = consulta.CantidadDeConsultaPorEmpleado();
            ReportDataSource Datos = new ReportDataSource("DataSet1", tabla);
            rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.EmpleadoConMasConsultas.EstadisticaConXEmp.rdlc";
            ReportParameter[] para = new ReportParameter[1];
            para[0] = new ReportParameter("PR01", "Cantidad de consultas totales por empleados");
            rv01.LocalReport.SetParameters(para);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(Datos);
            rv01.RefreshReport();
        }
    }
}
