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

namespace WindowsFormsApp1.Formularios.Reportes.ReportePromedioDeVacunadosDiarios
{
    public partial class ReporteVacunadosDiarios : Form
    {
        NE_calendario_vacunas calen = new NE_calendario_vacunas();
        DataTable tabla = new DataTable();
        public ReporteVacunadosDiarios()
        {
            InitializeComponent();
        }

        private void ReporteVacunadosDiarios_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            
            int ano = int.Parse(txtboxAno.Text);
            int mes = int.Parse(txtboxMes.Text);
            int dia = int.Parse(txtboxDia.Text);
            tabla = calen.CalcularCantidadPromedioDeVacunadosDiarios(ano,mes,dia);
            int var = tabla.Rows.Count;
           
            DataTable tabla2 = new DataTable();
            string numero = var.ToString();
            tabla2.Columns.Add("CantidadPromedioDiario", typeof(string));
            tabla2.Columns.Add("CantidadPromedioDiario2", typeof(string));
            tabla2.Rows.Add(numero);


            ReportDataSource datos = new ReportDataSource("DataSet3", tabla2);
            rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Reportes.ReportePromedioDeVacunadosDiarios.Rprt_PromedioVacunadosDiarios.rdlc";
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RP01", "Para el Año: " + txtboxAno.Text + " mes: " + txtboxMes.Text + " dia: " + txtboxDia.Text );
            rv01.LocalReport.SetParameters(parametro);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(datos);
            rv01.RefreshReport();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
