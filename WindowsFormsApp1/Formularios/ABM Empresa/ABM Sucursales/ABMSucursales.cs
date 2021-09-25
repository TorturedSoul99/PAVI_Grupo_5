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
using System.Data;

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    public partial class ABMSucursales : Form
    {
        NE_Sucursal sucursal = new NE_Sucursal();
        DataTable tabla = new DataTable();
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

        private void dgvSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (chk_SucursalTodos.Checked == true)
            {
                tabla = sucursal.BuscarTodosSurcursales();
                cargar_grilla(tabla);
            }
            else 
            {
                tabla = sucursal.BuscarSucursal(txtbConsulta.Text);
                cargar_grilla(tabla);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro ninguna sucursal con ese nombre, vuelva a intentarlo");
                }
            }
        }


        private void cargar_grilla(DataTable tabla)
        {
            gridSucursales.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                gridSucursales.Rows.Add();
                gridSucursales.Rows[i].Cells[0].Value = tabla.Rows[i]["ID_sucursal"].ToString();
                gridSucursales.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre_sucursal"].ToString();
                gridSucursales.Rows[i].Cells[2].Value = tabla.Rows[i]["ID_supervisor"].ToString();
                gridSucursales.Rows[i].Cells[3].Value = tabla.Rows[i]["ID_supervisor_suplente"].ToString();

            }
        }

        private void txtbConsulta_MouseClick(object sender, MouseEventArgs e)
        {
            //int cont = 0;
            txtbConsulta.Text = ""; 
        }
    }
}
