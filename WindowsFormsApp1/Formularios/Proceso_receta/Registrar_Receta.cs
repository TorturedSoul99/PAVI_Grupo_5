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

namespace WindowsFormsApp1.Formularios.Proceso_receta
{
    public partial class Registrar_Receta : Form
    {
        NE_receta rece = new NE_receta();
        public Registrar_Receta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_Receta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet10.receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter1.Fill(this.bD3K3G05_2021DataSet10.receta);
            DataTable receta = rece.CargarReceta();
            dgvReceta2.Cargar(receta);
        }

        private void dataGridView011_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();


            if (cbID.SelectedItem != null)
            {
                tabla = rece.BuscarReceta2(Int32.Parse(cbID.Text));
                dgvReceta2.Cargar(tabla);
            }
            else
            {
                MessageBox.Show("No se selecciono un id de receta, Porfavor seleccione uno");
            }
        }
    }
}
