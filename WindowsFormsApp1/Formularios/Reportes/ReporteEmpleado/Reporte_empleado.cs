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

namespace WindowsFormsApp1.Formularios.Reportes.Reporte_peso_altura_x_raza
{
    public partial class Reporte_empleado : Form
    {
        NE_Empleados empleado = new NE_Empleados();
        DataTable tabla = new DataTable();
        
        public Reporte_empleado()
        {
            InitializeComponent();
        }

        private void Reporte_empleado_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
            this.RV_empleado_x_sucursal.RefreshReport();
            cmb_sucursales.cargarCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_anno.Text != "")
            {
                tabla = empleado.Buscar_empleado_x_FechaIngreso(Convert.ToInt32(txt_anno.Text));
                ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
                rv01.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Reportes.ReporteEmpleado.Rprt_empleado_x_FechaDeIngreso.rdlc";
                ReportParameter[] parametro = new ReportParameter[1];
                parametro[0] = new ReportParameter("RP01", "Para el Año :" + txt_anno.Text);
                rv01.LocalReport.SetParameters(parametro);
                rv01.LocalReport.DataSources.Clear();
                rv01.LocalReport.DataSources.Add(datos);
                rv01.RefreshReport();
            }
            else
            {
                MessageBox.Show("Por favor ingrese una Año");
            }
        }

        private void btn_buscar_sucu_Click(object sender, EventArgs e)
        {
            if (cmb_sucursales.SelectedIndex != -1)
            {
                tabla = empleado.Empleados_x_Sucursal(Convert.ToInt32(cmb_sucursales.SelectedValue.ToString()));
                ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
                RV_empleado_x_sucursal.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Reportes.ReporteEmpleado.Rprt_Empleados_x_Sucursal.rdlc";
                ReportParameter[] parametro = new ReportParameter[1];
                parametro[0] = new ReportParameter("RP_empleado_sucursal", "Para la Sucursal :" + cmb_sucursales.SelectedIndex +" Cantidad de Empleados = "+tabla.Rows.Count);
                RV_empleado_x_sucursal.LocalReport.SetParameters(parametro);
                RV_empleado_x_sucursal.LocalReport.DataSources.Clear();
                RV_empleado_x_sucursal.LocalReport.DataSources.Add(datos);
                RV_empleado_x_sucursal.RefreshReport();
            }
            else
            {
                MessageBox.Show("Por favor una Sucursal");
            }
        }
    }
}
