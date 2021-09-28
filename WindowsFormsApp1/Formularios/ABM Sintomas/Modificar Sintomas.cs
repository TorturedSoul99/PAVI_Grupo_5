using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_Sintomas
{
    public partial class Modificar_Sintomas : Form
    {
        public Modificar_Sintomas()
        {
            InitializeComponent();
        }

        private void Modificar_Sintomas_Load(object sender, EventArgs e)
        {
            comboBoxModificarSintomas._Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxModificarSintomas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un síntoma para modificarlo");
            }
            else if (txtModificarSintomas.Text == string.Empty)
            {
                MessageBox.Show("Debe completar el campo de modificación");
            }

            NE_sintomas negocio_sintomas = new NE_sintomas();
            negocio_sintomas.Modificar_sintomas(comboBoxModificarSintomas.Text, txtModificarSintomas.Text);
            comboBoxModificarSintomas._Cargar();

            txtModificarSintomas.Text = "";
        }
    }
}
