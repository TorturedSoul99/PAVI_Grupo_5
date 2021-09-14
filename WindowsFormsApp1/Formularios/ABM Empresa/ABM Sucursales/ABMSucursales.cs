using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    public partial class ABMSucursales : Form
    {
        public ABMSucursales()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AltaSucursal altaSucursal = new AltaSucursal();
            altaSucursal.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_Sucursales modif = new Modificar_Sucursales();
            modif.ShowDialog();

        }
    }
}
