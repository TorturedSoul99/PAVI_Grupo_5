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
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            NE_Deposito_x_sucursal deposito = new NE_Deposito_x_sucursal();
            DataTable tabla = new DataTable();

            if(cmb_medicamentos.SelectedIndex != -1)
            {
                tabla = deposito.Buscar_medicamentos_por_sucursal(Convert.ToInt32(cmb_medicamentos.SelectedValue.ToString()));
                
            }
            


        }
    }
}
