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
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales;
using WindowsFormsApp1.Formularios.ABM_Laboratorios;
using WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza;
using WindowsFormsApp1.Formularios.ABM_Vacunacion;
using WindowsFormsApp1.Formularios.ABM_Receta;
using WindowsFormsApp1.Formularios.ABM_Diagnostico;
using WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta;

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
            frm_inicio_de_sesion inicio = new frm_inicio_de_sesion();
            inicio.ShowDialog();

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

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMSucursales aBMSucursales = new ABMSucursales();
            aBMSucursales.ShowDialog();

        }

        private void informacionDeLaboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuLaboratorios menu_lab = new MenuLaboratorios();
            menu_lab.ShowDialog();
        }

        private void razaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raza abm_raza = new Raza();
            abm_raza.ShowDialog();
        }

        private void aBMVacunacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuVacunacion menu_vac = new MenuVacunacion();
            menu_vac.ShowDialog();
        }

        private void recetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_receta men_receta = new Menu_receta();
            men_receta.ShowDialog();
        }

        private void frmMenuPPAL_Load(object sender, EventArgs e)
        {
            frm_inicio_de_sesion inicio = new frm_inicio_de_sesion();
            inicio.ShowDialog();
            inicio.Dispose();
        }

        private void menuEstadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuDiagnostico menu = new MenuDiagnostico();
            menu.ShowDialog();
        }

        private void medicamentosPorRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuMedicamentosXReceta menu = new MenuMedicamentosXReceta();
            menu.ShowDialog();
        }
    }
}
