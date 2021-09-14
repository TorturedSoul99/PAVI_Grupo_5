using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Consulta;

namespace WindowsFormsApp1.Formularios
{
    public partial class MenuConsulta : Form
    {
        public MenuConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NuevaConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaConsulta nuevaconsulta = new NuevaConsulta();
            nuevaconsulta.ShowDialog();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarConsulta modificarconsulta = new ModificarConsulta();
            modificarconsulta.ShowDialog();

        }
    }
}
