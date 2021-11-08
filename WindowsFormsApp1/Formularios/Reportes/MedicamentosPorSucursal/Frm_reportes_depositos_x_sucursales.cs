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
using WindowsFormsApp1.Formularios.Reportes.MedicamentosPorSucursal;

namespace WindowsFormsApp1.Formularios.Reportes.MedicamentosPorSucursal
{
    public partial class Frm_reportes_depositos_x_sucursales : Form
    {
        public Frm_reportes_depositos_x_sucursales()
        {
            InitializeComponent();
        }

        private void Frm_reportes_depositos_x_sucursales_Load(object sender, EventArgs e)
        {

            this.rv_deposito_x_sucursales.RefreshReport();
            cmb_medicamentos.cargarCombo();
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            NE_Deposito_x_sucursal deposito = new NE_Deposito_x_sucursal();
            DataTable tabla = new DataTable();

            if(cmb_medicamentos.SelectedIndex != -1)
            {
                tabla = deposito.Buscar_medicamentos_por_sucursal(Convert.ToInt32(cmb_medicamentos.SelectedValue.ToString()));
                ReportDataSource datos = new ReportDataSource("DataSet_Medicamentos_x_Sucursal",tabla);
                //fidel re puto
                rv_deposito_x_sucursales.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Reportes.MedicamentosPorSucursal.Rprt_Deposito_xSucursal.rdlc";
                ReportParameter[] parametro = new ReportParameter[1];
                parametro[0] = new ReportParameter("RP_medicamentos_x_sucursal", "Para la Sucursal : " + cmb_medicamentos.SelectedValue);
                rv_deposito_x_sucursales.LocalReport.SetParameters(parametro);
                rv_deposito_x_sucursales.LocalReport.DataSources.Clear();
                rv_deposito_x_sucursales.LocalReport.DataSources.Add(datos);
                rv_deposito_x_sucursales.RefreshReport();

            }
            


        }
    }
}
