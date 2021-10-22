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

namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza
{
    public partial class Alta_raza : Form
    {
        public Alta_raza()
        {
            InitializeComponent();
        }

        NE_Raza razaa = new NE_Raza();

        private void Alta_raza_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtdenominacion.Text != "" && txt_Cuidados_especiales.Text != "")
            {
                razaa.AltaRaza(txtdenominacion.Text, txt_Cuidados_especiales.Text);
                MessageBox.Show("Se cargo correctamente");
            }
            else
            {
                MessageBox.Show("Porfavor carge todos los datos");
            }
            
        }
    }
}
