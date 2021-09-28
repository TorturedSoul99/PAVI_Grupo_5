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
using WindowsFormsApp1.Negocio;

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            NE_Deposito_x_sucursal deposito_x_sucu = new NE_Deposito_x_sucursal();

            DataTable tabla = new DataTable();
            tabla = deposito_x_sucu.BuscarDeposito_x_sucursal(txtbConsulta.Text);
            cargar_grilla(tabla);
        }
        private void cargar_grilla(DataTable tabla)
        {
            grid_Sucursales.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Sucursales.Rows.Add();
                grid_Sucursales.Rows[i].Cells[0].Value = tabla.Rows[i]["ID_medicamento"].ToString();
                grid_Sucursales.Rows[i].Cells[1].Value = tabla.Rows[i]["ID_Sucursal"].ToString();
                grid_Sucursales.Rows[i].Cells[2].Value = tabla.Rows[i]["Minimo_stock"].ToString();
                grid_Sucursales.Rows[i].Cells[3].Value = tabla.Rows[i]["Stock_Actual"].ToString();               

            }
        }
    }
}
