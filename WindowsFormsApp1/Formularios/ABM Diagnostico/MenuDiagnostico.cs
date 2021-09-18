using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Diagnostico;

namespace WindowsFormsApp1.Formularios.ABM_Diagnostico
{
    public partial class MenuDiagnostico : Form
    {
        public MenuDiagnostico()
        {
            InitializeComponent();
        }

        private void txtbConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoDiagnostico nuevoDiagnostico = new NuevoDiagnostico();
            nuevoDiagnostico.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDiagnostico modificar = new ModificarDiagnostico();
            modificar.ShowDialog();
        }
    }
}
