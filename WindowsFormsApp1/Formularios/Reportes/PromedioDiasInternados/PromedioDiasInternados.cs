using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using WindowsFormsApp1.Negocio;



namespace WindowsFormsApp1.Formularios.Reportes.PromedioDiasInternados
{
    public partial class PromedioDiasInternados : Form
    {
        NE_consulta consulta = new NE_consulta();
        DataTable tabla = new DataTable();
        
        public PromedioDiasInternados()
        {
            InitializeComponent();
        }

        private void lblPromedio_Click(object sender, EventArgs e)
        {

        }

        private void PromedioDiasInternados_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
        }

        private void btnCalcular01_Click(object sender, EventArgs e)
        {
            int annioE = int.Parse(textBoxAnnoE.Text);
            int annioS = int.Parse(textBoxAnnoS.Text);
            tabla = consulta.MostrarConsultaXleo(annioE,annioS);
            int var = tabla.Rows.Count;
            int promedio = 0;

            for (int i = 0; i < var;)
            {
                DateTime fecha1 = DateTime.Parse(tabla.Rows[i][0].ToString());
                DateTime fecha2 = DateTime.Parse(tabla.Rows[i][1].ToString());
                int dias = (fecha2 - fecha1).Days;
                promedio += dias;
                i++;
            }
            int promedioReal = promedio / var;

            DataTable tabla2 = new DataTable();
            string prom = promedioReal.ToString();
            tabla2.Columns.Add("CantidadDias", typeof(string));
            tabla2.Columns.Add("CantidadDias2", typeof(string));
            tabla2.Rows.Add(prom);

            ReportDataSource datos = new ReportDataSource("DataSet2", tabla2);
            rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Reportes.PromedioDiasInternados.Rprt_PromedioDiasInternados.rdlc";
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RP01", "Para el Año: " + textBoxAnnoE.Text +" Hasta el año: " +textBoxAnnoS.Text);
            rv01.LocalReport.SetParameters(parametro);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(datos);
            rv01.RefreshReport();

        }
    }
}
