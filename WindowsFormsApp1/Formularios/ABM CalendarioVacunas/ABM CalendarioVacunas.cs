using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios.ABM_CalendarioVacunas
{
    public partial class ABM_CalendarioVacunas : Form
    {
        public ABM_CalendarioVacunas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_CalendarioVacunas alta = new Alta_CalendarioVacunas();
            alta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_CalendarioVacunas modificar = new Modificar_CalendarioVacunas();
            modificar.ShowDialog();
        }
    }
}
