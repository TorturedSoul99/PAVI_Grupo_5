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

namespace WindowsFormsApp1.Formularios.Reportes.ReporteConsulta
{
    public partial class Reporte_consulta : Form
    {
        NE_consulta consulta = new NE_consulta();
        DataTable tabla = new DataTable();
        public Reporte_consulta()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txt_anno.Text != "")
            {

                tabla = consulta.Buscar_orden_x_FechaEntrada(Convert.ToInt32(txt_anno.Text));
                ReportDataSource datos = new ReportDataSource("DataSetConsulta", tabla);
                rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Reportes.ReporteConsulta.Rprt_consultas_x_Año.rdlc";
                ReportParameter[] parametro = new ReportParameter[1];
                parametro[0] = new ReportParameter("RPconsulta", "Para el Año :" + txt_anno.Text);
                rv01.LocalReport.SetParameters(parametro);
                rv01.LocalReport.DataSources.Clear();
                rv01.LocalReport.DataSources.Add(datos);
                rv01.RefreshReport();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un año");
            }
        }
    }
}
