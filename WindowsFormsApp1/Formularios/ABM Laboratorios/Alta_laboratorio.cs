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

namespace WindowsFormsApp1.Formularios.ABM_Laboratorios
{
    public partial class Alta_laboratorio : Form
    {
        NE_laboratorio laboratorio = new NE_laboratorio();
        
        public Alta_laboratorio()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            laboratorio.AltaLaboratorio(txtnombre.Text, txtdescripcion.Text);
        }
    }
}
