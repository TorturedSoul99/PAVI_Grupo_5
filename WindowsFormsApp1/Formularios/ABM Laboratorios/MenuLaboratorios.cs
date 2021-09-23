using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Laboratorios;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios
{
    public partial class MenuLaboratorios : Form
    {
        public MenuLaboratorios()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Alta_laboratorio alta_lab = new Alta_laboratorio();
            alta_lab.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_laboratorio modificar_lab = new Modificar_laboratorio();
            modificar_lab.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Ne_laboratorio laboratorio = new Ne_laboratorio();
            
            DataTable tabla = new DataTable();
            tabla = laboratorio.BuscarLaboratorio(txtbConsulta.Text);
            cargar_grilla(tabla);
                        
        }
        private void cargar_grilla(DataTable tabla)
        {
            Grid_laboratorio.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Grid_laboratorio.Rows.Add();
                Grid_laboratorio.Rows[i].Cells[0].Value = tabla.Rows[i]["ID_laboratorio"].ToString();
                Grid_laboratorio.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                Grid_laboratorio.Rows[i].Cells[2].Value = tabla.Rows[i]["Descripcion"].ToString();

            }
        }
    }
    
}
