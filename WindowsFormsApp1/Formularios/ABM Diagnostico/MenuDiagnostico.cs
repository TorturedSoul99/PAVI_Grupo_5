using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Diagnostico;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_Diagnostico
{
    public partial class MenuDiagnostico : Form
    {
        public MenuDiagnostico()
        {
            InitializeComponent();
        }

        private void txtbConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoDiagnostico nuevoDiagnostico = new NuevoDiagnostico();
            nuevoDiagnostico.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDiagnostico modificar = new ModificarDiagnostico();
            modificar.ShowDialog();
        }

        private void MenuDiagnostico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet.diagnostico' Puede moverla o quitarla según sea necesario.
            this.diagnosticoTableAdapter.Fill(this.bD3K3G05_2021DataSet.diagnostico);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            NE_diagnostico diagnostico = new NE_diagnostico();
            DataTable tabla = new DataTable();
            tabla = diagnostico.BuscarDiagnostico(txtbConsulta.Text);
            gdDiagnostico.Cargar(tabla);
 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView011_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
