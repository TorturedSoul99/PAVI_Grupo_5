using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos
{
    public partial class Alta_medicamentos : Form
    {
        public Alta_medicamentos()
        {
            InitializeComponent();
        }

        

        private void Alta_medicamentos_Load(object sender, EventArgs e)
        {
            cmb_Laboratorio.cargarCombo();
            cmb_Sucursal.cargarCombo();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
