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

            this.reportViewer1.RefreshReport();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_Medicamento medicamento = new NE_Medicamento();
            DataTable tabla = new DataTable();


            if (txt_Anno_Desde.Text != "" && txt_Anno_Hasta.Text != "")
            {
                if (Convert.ToInt32(txt_Anno_Desde.Text) < Convert.ToInt32(txt_Anno_Hasta.Text))
                {
                    tabla = medicamento.medicamentos_por_anno(Convert.ToInt32(txt_Anno_Desde.Text), Convert.ToInt32(txt_Anno_Hasta.Text));




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
    }
}
