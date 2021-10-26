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

namespace WindowsFormsApp1.Formularios.Reportes.Reporte_peso_altura_x_raza
{
    public partial class Reporte_Empleados : Form
    {
        
        
        
        public Reporte_Empleados()
        {
            InitializeComponent();
        }

        private void Reporte_Peso_altura_x_Raza_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
        }

        private void btn_buscar01_Click(object sender, EventArgs e)
        {
            NE_Empleados empleado = new NE_Empleados();
            DataTable tabla = new DataTable();

            if (txt_mes.Text != " " && txt_anno.Text != " ")
            {
                tabla = empleado.Buscar_fechaIngreso_x_MesAnno(txt_mes.Text,txt_anno.Text);
            }
        }
    }
}
