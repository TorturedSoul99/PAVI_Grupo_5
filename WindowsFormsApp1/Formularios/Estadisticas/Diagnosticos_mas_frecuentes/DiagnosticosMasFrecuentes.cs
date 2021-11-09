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

namespace WindowsFormsApp1.Formularios.Estadisticas.Diagnosticos_mas_frecuentes
{
    public partial class DiagnosticosMasFrecuentes : Form
    {
        public DiagnosticosMasFrecuentes()
        {
            InitializeComponent();
        }

        private void DiagnosticosMasFrecuentes_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_consulta consulta = new NE_consulta();
            ReportDataSource Datos = new ReportDataSource("DataSet1", consulta.DiagnosticosMasFrecuentes());
            rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.Diagnosticos_mas_frecuentes.EstadisticaDiagnosticosMasFrecuentes.rdlc";
            ReportParameter[] para = new ReportParameter[1];
            para[0] = new ReportParameter("PR01", "Diagnosticos mas frecuentes");
            rv01.LocalReport.SetParameters(para);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(Datos);
            rv01.RefreshReport();
        }
    }
}
