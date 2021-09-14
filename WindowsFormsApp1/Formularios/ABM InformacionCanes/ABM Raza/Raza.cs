using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza;

namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza
{
    public partial class Raza : Form
    {
        public Raza()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_raza alta_razaa = new Alta_raza();
            alta_razaa.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_raza mod_raza = new Modificar_raza();
            mod_raza.ShowDialog();
        }
    }
}
