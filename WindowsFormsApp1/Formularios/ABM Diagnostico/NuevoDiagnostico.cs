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

namespace WindowsFormsApp1.Formularios.ABM_Diagnostico
{
    public partial class NuevoDiagnostico : Form
    {
        NE_diagnostico diagnostico = new NE_diagnostico();
        public NuevoDiagnostico()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.ToString();
            bool agregar = diagnostico.Alta_diagnostico(nombre);
            if (agregar)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Ya existe una diagnostico con ese nombre", "Error al cargar diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
