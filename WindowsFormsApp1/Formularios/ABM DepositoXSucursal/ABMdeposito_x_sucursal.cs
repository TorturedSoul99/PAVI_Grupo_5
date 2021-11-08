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
        public string id_medicamento { get; set; }
        public string id_sucursal { get; set; }
        NE_Deposito_x_sucursal deposito_x_sucu = new NE_Deposito_x_sucursal();
        DataTable tabla = new DataTable();

        public string ID__Deposito_x_sucursal { get; set; }

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
            mod_deposito.ID_MEDICAMENTO = id_medicamento;
            mod_deposito.ID_SUCURSAL = id_sucursal;
            mod_deposito.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {           
 
            tabla = deposito_x_sucu.BuscarDeposito_x_sucursal(txtbConsulta.Text);
            cargar_grilla(tabla);
        }
        private void cargar_grilla(DataTable tabla)
        {
            grid_deposito_x_sucursal.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_deposito_x_sucursal.Rows.Add();
                grid_deposito_x_sucursal.Rows[i].Cells[0].Value = tabla.Rows[i]["ID_medicamento"].ToString();
                grid_deposito_x_sucursal.Rows[i].Cells[1].Value = tabla.Rows[i]["ID_Sucursal"].ToString();
                grid_deposito_x_sucursal.Rows[i].Cells[2].Value = tabla.Rows[i]["Minimo_stock"].ToString();
                grid_deposito_x_sucursal.Rows[i].Cells[3].Value = tabla.Rows[i]["Stock_Actual"].ToString();               

            }
        }

        private void grid_Sucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_medicamento = grid_deposito_x_sucursal.CurrentRow.Cells["ID_medicamento"].Value.ToString();
            id_sucursal = grid_deposito_x_sucursal.CurrentRow.Cells["ID_sucursal"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(id_medicamento != "" && id_sucursal != "")
            {
                deposito_x_sucu.Eliminardeposito_x_sucursal(Convert.ToInt32(id_medicamento), Convert.ToInt32(id_sucursal));
                MessageBox.Show("Se elimino correctamente");
            }
            else
            {
                MessageBox.Show("Por favor seleccione alguna fila");
            }
        }
    }
}
