using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Vacunacion;

namespace WindowsFormsApp1.Formularios
{
    public partial class MenuVacunacion : Form
    {
        public MenuVacunacion()
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
    }
}
