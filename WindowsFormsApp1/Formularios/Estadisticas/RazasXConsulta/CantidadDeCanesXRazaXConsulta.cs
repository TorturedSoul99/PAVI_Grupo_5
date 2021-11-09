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

namespace WindowsFormsApp1.Formularios.Estadisticas.RazasXConsulta
{
    public partial class CantidadDeCanesXRazaXConsulta : Form
    {
        public CantidadDeCanesXRazaXConsulta()
        {
            InitializeComponent();
        }

        private void CantidadDeCanesXRazaXConsulta_Load(object sender, EventArgs e)
        {
            this.rv01.RefreshReport();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            NE_consulta consulta = new NE_consulta();
            ReportDataSource Datos = new ReportDataSource("DataSet1", consulta.RazasXConsulta());
            rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.RazasXConsulta.EstadisticaConsultasXRaza.rdlc";
            ReportParameter[] para = new ReportParameter[1];
            para[0] = new ReportParameter("PR01", "Cantidad de Canes de cada Raza que asisten a una consulta");
            rv01.LocalReport.SetParameters(para);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(Datos);
            rv01.RefreshReport();
        }
    }
}
