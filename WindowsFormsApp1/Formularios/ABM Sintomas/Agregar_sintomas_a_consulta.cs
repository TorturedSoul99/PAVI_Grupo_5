using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios.ABM_Sintomas
{
    public partial class Agregar_sintomas_a_consulta : Form
    {
        public Agregar_sintomas_a_consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM_Sintomas abm_sintomas = new ABM_Sintomas();
            abm_sintomas.ShowDialog();
        }

        private void Agregar_sintomas_a_consulta_Load(object sender, EventArgs e)
        {
            ComboBoxSintomas._Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
