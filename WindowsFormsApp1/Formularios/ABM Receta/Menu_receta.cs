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
    }
}
