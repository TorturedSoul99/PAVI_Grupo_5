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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            alta_laboratorio altaLaboratorio = new alta_laboratorio();
            altaLaboratorio.ShowDialog();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Modificar_laboratorio modificar_lab = new Modificar_laboratorio();
            modificar_lab.ShowDialog();
        }
    }
}
