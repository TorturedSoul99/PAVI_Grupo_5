using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta;

namespace WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta
{
    public partial class MenuMedicamentosXReceta : Form
    {
        public MenuMedicamentosXReceta()
        {
            InitializeComponent();
        }

        private void txtbConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoMedicamentoXReceta nuevoMedicamento = new NuevoMedicamentoXReceta();
            nuevoMedicamento.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarMedicamentosXReceta modificar = new ModificarMedicamentosXReceta();
            modificar.ShowDialog();

        }
    }
}
