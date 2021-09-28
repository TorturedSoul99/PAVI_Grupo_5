using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsApp1.Negocio;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Vacunacion;
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Formularios
{
    public partial class MenuVacunas : Form
    {
        public MenuVacunas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_vacunacion alta_vacu = new Alta_vacunacion();
            alta_vacu.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar_vacunacion mod_vacunacion = new modificar_vacunacion();
            mod_vacunacion.ShowDialog();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            NE_Vacunas vacuna = new NE_Vacunas();
            DataTable tabla = new DataTable();
            tabla = vacuna.BuscarVacunas(txtbConsulta.Text);
            dgvVacunas.Cargar(tabla);
        }
    }
}
