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
        public Frm_Consulta_por_sucursal_por_anno()
        {
            InitializeComponent();
        }

        private void Frm_Consulta_por_sucursal_por_anno_Load(object sender, EventArgs e)
        {

            this.rv_consulta_sucursal.RefreshReport();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            NE_consulta consulta = new NE_consulta();
            
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
    }
}
