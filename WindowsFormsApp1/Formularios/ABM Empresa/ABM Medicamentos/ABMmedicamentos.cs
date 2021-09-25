using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos;

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos
{
    public partial class Menu_medicamentos : Form
    {
        public Menu_medicamentos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_medicamentos nuevo_med = new Alta_medicamentos();
            nuevo_med.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_medicamentos mod_medicamentos = new Modificar_medicamentos();
            mod_medicamentos.ShowDialog();
        }
    }
}
