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
    public partial class Modificar_deposito_x_sucursal : Form
    {
        public string ID_MEDICAMENTO { get; set; }
        public string ID_SUCURSAL { get; set; }
        NE_Deposito_x_sucursal deposito = new NE_Deposito_x_sucursal();
        
        public Modificar_deposito_x_sucursal()
        {
            InitializeComponent();
        }
        private void MostrarDatos(DataTable tabla)
        {
            cmb_id_medicamento.SelectedValue = (int.Parse(tabla.Rows[0]["ID_Medicamento"].ToString()));
            cmb_id_sucursal.SelectedValue = (int.Parse(tabla.Rows[0]["ID_Sucursal"].ToString())); 
            txt_minimo_stock.Text = tabla.Rows[0]["Minimo_stock"].ToString();
            txt_stock_actual.Text = tabla.Rows[0]["Stock_Actual"].ToString();

        }

        private void Modificar_deposito_x_sucursal_Load(object sender, EventArgs e)
        {
            cmb_id_medicamento.cargarCombo();
            cmb_id_sucursal.cargarCombo();
            MostrarDatos(deposito.Recuperar_x_ID_medicamento_sucursal(Convert.ToInt32(ID_MEDICAMENTO), Convert.ToInt32(ID_SUCURSAL)));

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cmb_id_medicamento.SelectedIndex == -1 && cmb_id_sucursal.SelectedIndex == -1 && txt_minimo_stock.Text == "" && txt_stock_actual.Text == "")
            {
                MessageBox.Show("No se colocaron los datos suficientes");
            }
            else
            {
                deposito.Modificar_deposito_x_sucursal(Convert.ToInt32(cmb_id_medicamento.SelectedValue.ToString()), Convert.ToInt32(cmb_id_sucursal.SelectedValue.ToString()), Convert.ToInt32(txt_minimo_stock.Text), Convert.ToInt32(txt_stock_actual.Text), Convert.ToInt32(ID_MEDICAMENTO), Convert.ToInt32(ID_SUCURSAL));
                MessageBox.Show("Se modifico correctamento");
            }
             
            
                
        }
    }
}
