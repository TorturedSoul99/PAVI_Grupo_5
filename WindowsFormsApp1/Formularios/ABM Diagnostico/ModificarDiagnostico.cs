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
    public partial class ModificarDiagnostico : Form
    {
        NE_diagnostico diagnostico = new NE_diagnostico();
        public int _id { get; set; }
        public string _nombre { get; set; }
        public ModificarDiagnostico()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre_nuevo = textBox2.Text.ToString();

            diagnostico.Modificar_diagnostico(_id, _nombre, nombre_nuevo);
            this.Close();
        }

        private void lblHC_Click(object sender, EventArgs e)
        {

        }

        private void ModificarDiagnostico_Load(object sender, EventArgs e)
        {
            textBox1.Text = _id.ToString();
            textBox2.Text = _nombre;
        }

        
    }
}
