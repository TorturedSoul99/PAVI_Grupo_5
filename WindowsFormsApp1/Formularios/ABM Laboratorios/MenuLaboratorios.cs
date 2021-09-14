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
    }
}
