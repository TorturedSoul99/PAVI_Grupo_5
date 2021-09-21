using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_DepositoXSucursal;

namespace WindowsFormsApp1.Formularios.ABM_DepositoXSucursal
{
    public partial class ABMdeposito_x_sucursal : Form
    {
        public ABMdeposito_x_sucursal()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_deposito_x_sucursal alta_deposito = new Alta_deposito_x_sucursal();
            alta_deposito.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_deposito_x_sucursal mod_deposito = new Modificar_deposito_x_sucursal();
            mod_deposito.ShowDialog();
        }
    }
}
