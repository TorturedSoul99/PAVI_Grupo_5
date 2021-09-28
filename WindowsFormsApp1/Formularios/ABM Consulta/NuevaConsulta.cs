using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Sintomas;

namespace WindowsFormsApp1.Formularios.ABM_Consulta
{
    public partial class NuevaConsulta : Form
    {
        public NuevaConsulta()
        {
            InitializeComponent();
        }

        private void btnAgregarSintomas_Click(object sender, EventArgs e)
        {
            Agregar_sintomas_a_consulta agregar = new Agregar_sintomas_a_consulta();
            agregar.ShowDialog();
        }
    }
}
