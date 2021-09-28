using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta
{
    public partial class MenuMedicamentosXReceta : Form
    {
        public MenuMedicamentosXReceta()
        {
            InitializeComponent();
        }

        private void txtbConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoMedicamentoXReceta nuevoMedicamento = new NuevoMedicamentoXReceta();
            nuevoMedicamento.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarMedicamentosXReceta modificar = new ModificarMedicamentosXReceta();
            modificar.ShowDialog();

        }

        private void MenuMedicamentosXReceta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet1.medicamentosXReceta' Puede moverla o quitarla según sea necesario.
            //this.medicamentosXRecetaTableAdapter.Fill(this.bD3K3G05_2021DataSet1.medicamentosXReceta);
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet.diagnostico' Puede moverla o quitarla según sea necesario.
            //this.diagnosticoTableAdapter.Fill(this.bD3K3G05_2021DataSet.diagnostico);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            NE_MedicamentoXReceta medicamentoXReceta = new NE_MedicamentoXReceta();
            DataTable tabla = new DataTable();
            tabla = medicamentoXReceta.BuscarMedicamentosReceta(Int32.Parse(txtbConsulta.Text));
            dgvMXR.Cargar(tabla);
        }
    }
}
