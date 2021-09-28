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
using WindowsFormsApp1.Formularios.ABM_Sintomas;

namespace WindowsFormsApp1.Formularios.ABM_Sintomas
{
    public partial class Alta_Sintoma : Form
    {
        public Alta_Sintoma()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNuevoSintoma.Text != string.Empty)
            {
                NE_sintomas sintomas = new NE_sintomas();
                sintomas.Agregar_sintomas(txtNuevoSintoma.Text);
                this.Close();
            }
        }
    }
}
