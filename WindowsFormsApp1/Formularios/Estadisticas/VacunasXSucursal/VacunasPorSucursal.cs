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

namespace WindowsFormsApp1.Formularios.Estadisticas.VacunasXSucursal
{
    public partial class VacunasPorSucursal : Form
    {
        public VacunasPorSucursal()
        {
            InitializeComponent();
        }

        private void VacunasPorSucursal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet13.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter.Fill(this.bD3K3G05_2021DataSet13.sucursal);

            this.rv01.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string sucursal = comboBox1.SelectedValue.ToString();
            int sucu = int.Parse(sucursal);
            NE_calendario_vacunas cv = new NE_calendario_vacunas();
            ReportDataSource Datos = new ReportDataSource("DataSet1", cv.VacunasXSucursal(sucu));
            rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.VacunasXSucursal.VacunasXSucursal.rdlc";
            ReportParameter[] para = new ReportParameter[1];
            para[0] = new ReportParameter("PR01", "Cantidad de vacunas colocadas por sucursal");
            rv01.LocalReport.SetParameters(para);
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(Datos);
            rv01.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
