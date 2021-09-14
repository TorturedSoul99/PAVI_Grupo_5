using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado;

namespace WindowsFormsApp1
{
    public partial class frmMenuPPAL : Form
    {
        public frmMenuPPAL()
        {
            InitializeComponent();
        }

        private void consulñtaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void altaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConsulta menuConsulta = new MenuConsulta();
            menuConsulta.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Empleado aBM_Empleado = new ABM_Empleado();
            aBM_Empleado.ShowDialog();

        }
    }
}
