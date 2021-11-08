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
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza
{
    public partial class Raza : Form
    {

        public string denominacionn;
        NE_Raza raza = new NE_Raza();
        DataTable tabla = new DataTable();

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
            mod_raza.DENOMINACION = denominacionn;
            mod_raza.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (chk_todos.Checked == true)
            {
                tabla = raza.BuscarTodosRaza();
                cargar_grilla(tabla);
            }
            else
            {
                tabla = raza.BuscarRazaDenominacion(txt_denominacion.Text);
                cargar_grilla(tabla);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro a ninguna raza con esa denominacion, vuelva a intentarlo");
                }
            }
        }

        private void cargar_grilla(DataTable tabla)
        {
            grid_raza.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_raza.Rows.Add();
                grid_raza.Rows[i].Cells[0].Value = tabla.Rows[i]["Denominacion"].ToString();
                grid_raza.Rows[i].Cells[1].Value = tabla.Rows[i]["Cuidados_especiales"].ToString();
            }
        }

        private void grid_raza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            denominacionn = grid_raza.CurrentRow.Cells["Nuevo"].Value.ToString();
        }

        private void Raza_Load(object sender, EventArgs e)
        {
            
        }

        private void grid_raza_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_raza mostrar_raza = new Mostrar_raza();
            mostrar_raza.denominacion = grid_raza.CurrentRow.Cells["Nuevo"].Value.ToString();
            mostrar_raza.ShowDialog();
        }
    }
}
