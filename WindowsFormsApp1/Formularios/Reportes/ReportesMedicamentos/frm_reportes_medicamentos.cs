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

namespace WindowsFormsApp1.Formularios.Reportes.ReportesMedicamentos
{
    public partial class Frm_reportes_medicamentos : Form
    {
        public Frm_reportes_medicamentos()
        {
            InitializeComponent();
        }

        private void rprt_precio_medicamentos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            NE_MedicamentoXReceta medicamentos_x_receta = new NE_MedicamentoXReceta();
            DataTable tabla = new DataTable();

            string mes = (cmb_mes.SelectedIndex + 1).ToString();
            string año = txt_año.Text;

            tabla = medicamentos_x_receta.Calcular_cantidad_medicamentos_x_fecha(mes, año);
        }
    }
}
