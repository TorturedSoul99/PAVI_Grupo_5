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

namespace WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta
{
    public partial class NuevoMedicamentoXReceta : Form
    {
        NE_MedicamentoXReceta medicam = new NE_MedicamentoXReceta();
        public NuevoMedicamentoXReceta()
        {
            InitializeComponent();
        }

        private void lblHC_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoMedicamentoXReceta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet4.receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter.Fill(this.bD3K3G05_2021DataSet4.receta);
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet3.medicamentos' Puede moverla o quitarla según sea necesario.
            this.medicamentosTableAdapter.Fill(this.bD3K3G05_2021DataSet3.medicamentos);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int receta = int.Parse(comboBox2.Text);
            int medicamentos = int.Parse(comboBox1.Text);
            string perio = textBox4.Text.ToString();
            string dosis = textBox2.Text.ToString();
            bool agregar = medicam.Alta_MedicamentoXReceta(medicamentos, receta, perio, dosis);
            if (agregar)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Ya existe un medicamento registrado o la receta no existe, por favor seleccione otra receta u otro medicamento", "Error al cargar medicamentos para la receta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

 
    }
}
