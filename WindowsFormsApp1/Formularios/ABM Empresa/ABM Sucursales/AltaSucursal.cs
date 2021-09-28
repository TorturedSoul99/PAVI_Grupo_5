using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    public partial class AltaSucursal : Form
    {
        public AltaSucursal()
        {
            InitializeComponent();
        }

        NE_Sucursal sucursal = new NE_Sucursal();

        private void AltaSucursal_Load(object sender, EventArgs e)
        {
            cmb_supervisor.cargarCombo();
            cmb_supervisorSuplente.cargarCombo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sucursal.AltaSucursal(txt_nombreSurcursal.Text, cmb_supervisor.SelectedIndex, cmb_supervisorSuplente.SelectedIndex);
            MessageBox.Show("Se cargo correctamente");
        }
    }
}
