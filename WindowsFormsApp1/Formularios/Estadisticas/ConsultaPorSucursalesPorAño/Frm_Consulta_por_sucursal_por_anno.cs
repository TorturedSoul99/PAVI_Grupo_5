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

namespace WindowsFormsApp1.Formularios.Estadisticas.ConsultaPorSucursalesPorAño
{
    public partial class Frm_Consulta_por_sucursal_por_anno : Form
    {
        NE_consulta consulta = new NE_consulta();


        public Frm_Consulta_por_sucursal_por_anno()
        {
            InitializeComponent();
        }

        private void Frm_Consulta_por_sucursal_por_anno_Load(object sender, EventArgs e)
        {

            this.rv_consulta_sucursal.RefreshReport();
            this.rp_sucu1.RefreshReport();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            
            
            if (txt_Anno_Desde.Text != "")
            {
                ReportDataSource Datos = new ReportDataSource("dataSET_consulta_sucursal", consulta.Consultas_por_sucursales_porAnno(Convert.ToInt32(txt_Anno_Desde.Text)));
                rv_consulta_sucursal.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.ConsultaPorSucursalesPorAño.Rprt_consultas_por_sucursal_anno.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("parametro_consutla_sucursal", "Para el Año: " + txt_Anno_Desde.Text);
                rv_consulta_sucursal.LocalReport.SetParameters(parametros);
                rv_consulta_sucursal.LocalReport.DataSources.Clear();
                rv_consulta_sucursal.LocalReport.DataSources.Add(Datos);
                rv_consulta_sucursal.RefreshReport();
            }
            else
            {
                MessageBox.Show("Porfavor Ingrese un Año");
            }
        }

        private void btn_consulta22222_Click(object sender, EventArgs e)
        {
            if (txt_ano_sucu.Text != "" && txt_mes_sucu.Text != "" && txt_mes_sucu_hasta.Text != "")
            {
                ReportDataSource Datos = new ReportDataSource("DataSet_sucu_mes", consulta.Consultas_por_sucursales_porAnnoYRangoDeMes(Convert.ToInt32(txt_ano_sucu.Text), Convert.ToInt32(txt_mes_sucu.Text), Convert.ToInt32(txt_mes_sucu_hasta.Text)));
                rp_sucu1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.ConsultaPorSucursalesPorAño.Report1.rdlc";
                ReportParameter[] parametrosss = new ReportParameter[1];
                parametrosss[0] = new ReportParameter("RP01", "Para el Año: " + txt_ano_sucu.Text+ " En rango de Mes Desde: "+txt_mes_sucu.Text+" Hasta: "+txt_mes_sucu_hasta.Text);
                rp_sucu1.LocalReport.SetParameters(parametrosss);
                rp_sucu1.LocalReport.DataSources.Clear();
                rp_sucu1.LocalReport.DataSources.Add(Datos);
                rp_sucu1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Porfavor Ingrese un Año");
            }
        }
    }
}
