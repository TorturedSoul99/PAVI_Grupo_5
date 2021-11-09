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


namespace WindowsFormsApp1.Formularios.Estadisticas.MedicamentosPorAño
{
    public partial class Frm_MedicamentosPorAnno : Form
    {
        
        
        public Frm_MedicamentosPorAnno()
        {
            InitializeComponent();
        }

        private void Frm_MedicamentosPorAnno_Load(object sender, EventArgs e)
        {

            this.rp_medicamentos_Anno.RefreshReport();
        }

        NE_Medicamento medicamento = new NE_Medicamento();

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            //DataTable tabla = new DataTable();


            if (txt_Anno_Desde.Text != "" && txt_Anno_Hasta.Text != "")
            {
                if (Convert.ToInt32(txt_Anno_Desde.Text) < Convert.ToInt32(txt_Anno_Hasta.Text))
                {
                    //tabla = medicamento.medicamentos_por_anno(Convert.ToInt32(txt_Anno_Desde.Text), Convert.ToInt32(txt_Anno_Hasta.Text));

                    ReportDataSource Datos = new ReportDataSource("DataSet1", medicamento.medicamentos_por_anno(Convert.ToInt32(txt_Anno_Desde.Text), Convert.ToInt32(txt_Anno_Hasta.Text)));
                    rp_medicamentos_Anno.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.MedicamentosPorAño.Rprt_Meicamento_por_anno.rdlc";
                    ReportParameter[] parametros = new ReportParameter[1];
                    parametros[0] = new ReportParameter("Parametro_medicamentos_Anno", "Para los Años Desde: "+txt_Anno_Desde.Text+" Hasta: "+txt_Anno_Hasta.Text);
                    rp_medicamentos_Anno.LocalReport.SetParameters(parametros);
                    rp_medicamentos_Anno.LocalReport.DataSources.Clear();
                    rp_medicamentos_Anno.LocalReport.DataSources.Add(Datos);
                    rp_medicamentos_Anno.RefreshReport();

                }
                else
                {
                    MessageBox.Show("Error en el parametro de Año verificar porfavor");
                }
            }
            else
            {
                MessageBox.Show("Porfavor Ingrese todos los campos requeridos por este formulario porfavor");
            }
        }

        private void btn_consultar_medicamentosXmes_Click(object sender, EventArgs e)
        {
            if (txt_año.Text != String.Empty)
            {
                ReportDataSource Datos = new ReportDataSource("DS_medicamentosXmes", medicamento.medicamentos_por_mes(txt_año.Text));
                rv_medicamentos_por_mes.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Formularios.Estadisticas.MedicamentosPorAño.Rprto_medicamentosPorMes.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("PR_medicamentos_por_mes", "Para el año: " + txt_año.Text);
                rv_medicamentos_por_mes.LocalReport.SetParameters(parametros);
                rv_medicamentos_por_mes.LocalReport.DataSources.Clear();
                rv_medicamentos_por_mes.LocalReport.DataSources.Add(Datos);
                rv_medicamentos_por_mes.RefreshReport();
            }
            else
                MessageBox.Show("El campo año no puede estar vacío");

        }
    }
}
