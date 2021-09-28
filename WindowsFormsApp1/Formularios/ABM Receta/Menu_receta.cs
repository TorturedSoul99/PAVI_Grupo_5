using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Receta;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_Receta
{
    public partial class Menu_receta : Form
    {
        public Menu_receta()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_receta alta_Receta = new Alta_receta();
            alta_Receta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_receta mod_receta = new Modificar_receta();
            mod_receta.ShowDialog();
        }

        private void Menu_receta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet2.receta' Puede moverla o quitarla según sea necesario.
                }

        private void dgvSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            NE_receta rece = new NE_receta();
            DataTable tabla = new DataTable();
            tabla = rece.BuscarReceta(Int32.Parse(txtbreceta.Text));
            dgvreceta.Cargar(tabla);
        }
    }
}
