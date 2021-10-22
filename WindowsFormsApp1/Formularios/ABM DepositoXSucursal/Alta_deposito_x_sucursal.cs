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

namespace WindowsFormsApp1.Formularios.ABM_DepositoXSucursal
{
    public partial class Alta_deposito_x_sucursal : Form
    {
        public Alta_deposito_x_sucursal()
        {
            InitializeComponent();
        }

        NE_Deposito_x_sucursal deposito = new NE_Deposito_x_sucursal();

        private void Alta_deposito_x_sucursal_Load(object sender, EventArgs e)
        {
            cmb_id_medicamento.cargarCombo();
            cmb_id_sucursal.cargarCombo();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            deposito.AltaDeposito_x_sucursal(Convert.ToInt32(cmb_id_medicamento.SelectedValue.ToString()), Convert.ToInt32(cmb_id_sucursal.SelectedValue.ToString()), Convert.ToInt32(txt_minimo_stock.Text), Convert.ToInt32(txt_stock_actual.Text));
            MessageBox.Show("Se cargo correctamente");
        }
    }
}
