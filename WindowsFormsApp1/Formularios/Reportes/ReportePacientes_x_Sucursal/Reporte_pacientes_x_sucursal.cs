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

namespace WindowsFormsApp1.Formularios.Reportes.ReportePacientes_x_Sucursal
{
    public partial class Reporte_pacientes_x_sucursal : Form
    {
        NE_historiaClinica HC = new NE_historiaClinica();
        DataTable tabla = new DataTable();
        public Reporte_pacientes_x_sucursal()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txt_sucursal.Text != "")
            {

                tabla = HC.Buscar_sucursal_x_historiaClinica(Convert.ToInt32(txt_sucursal.Text));
                ReportDataSource datos = new ReportDataSource("DataSetPacientesSucursal", tabla);
                rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Reportes.ReportePacientes_x_Sucursal.Rprt_pacientes_x_sucursal.rdlc";
                ReportParameter[] parametro = new ReportParameter[1];
                parametro[0] = new ReportParameter("RPPacientesSucursal", "Para la sucursal :" + txt_sucursal.Text);
                rv01.LocalReport.SetParameters(parametro);
                rv01.LocalReport.DataSources.Clear();
                rv01.LocalReport.DataSources.Add(datos);
                rv01.RefreshReport();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un numero de sucursal");
            }
        }
    }
}
