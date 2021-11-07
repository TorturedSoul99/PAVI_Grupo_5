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
using WindowsFormsApp1.Back_end;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1.Formularios.Estadisticas.ConsultasPorAño
{
    public partial class Estadistica_consultas_x_año : Form
    {
        NE_consulta consulta = new NE_consulta();
        DataTable tabla = new DataTable();
        
        public Estadistica_consultas_x_año()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txt_anno.Text != "" && txt_mes1.Text != "" && txt_mes2.Text != "")
            {
                string anno = txt_anno.Text;
                string mes1 = txt_mes1.Text;
                string mes2 = txt_mes2.Text;

                tabla = consulta.CantidadConsultaPorAño(txt_anno.Text, txt_mes1.Text, txt_mes2.Text);
                ReportDataSource datos = new ReportDataSource("DataSetEstadisticaConsulta", tabla);
                rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.ConsultasPorAño.Rprt_cantidad_consultas_x_año.rdlc";
                ReportParameter[] parametro = new ReportParameter[1];
                parametro[0] = new ReportParameter("RPcantidadConsulta", "Para el Año " + txt_anno.Text + "Entre el mes " + txt_mes1 + "y el mes " + txt_mes2);
                rv01.LocalReport.SetParameters(parametro);
                rv01.LocalReport.DataSources.Clear();
                rv01.LocalReport.DataSources.Add(datos);
                rv01.RefreshReport();
            }
            else
            {
                MessageBox.Show("Por favor complete los campos restantes");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_anno1.Text != "" && txt_anno2.Text != "")
            {
                tabla = consulta.ConsultaPorAños(txt_anno1.Text, txt_anno2.Text);
                ReportDataSource datos = new ReportDataSource("DataSetConsultaEntreAños", tabla);
                rv02.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.ConsultasPorAño.Rprt_cantidad_consultas_entre_años.rdlc";
                ReportParameter[] parametro = new ReportParameter[1];
                parametro[0] = new ReportParameter("RPconsultaEntreAños", "Entre el Año " + txt_anno1.Text + "y el año " + txt_anno2);
                rv02.LocalReport.SetParameters(parametro);
                rv02.LocalReport.DataSources.Clear();
                rv02.LocalReport.DataSources.Add(datos);
                rv02.RefreshReport();
            }

            else
            {
                MessageBox.Show("Por favor complete los campos restantes");
            }
        }
    }
}
