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
<<<<<<< HEAD
using WindowsFormsApp1.Formularios.ABM_Laboratorios;
=======
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales;
>>>>>>> 783358122e05ce3ba6f50b95763c49ff30ad99f5

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

<<<<<<< HEAD
        private void aBMLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuLaboratorios abmLaboratorio = new MenuLaboratorios();
            abmLaboratorio.ShowDialog();

            
=======
        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMSucursales aBMSucursales = new ABMSucursales();
            aBMSucursales.ShowDialog();

>>>>>>> 783358122e05ce3ba6f50b95763c49ff30ad99f5
        }
    }
}
