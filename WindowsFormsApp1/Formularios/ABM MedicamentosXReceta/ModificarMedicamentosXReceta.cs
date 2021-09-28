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
   
    public partial class ModificarMedicamentosXReceta : Form
    {
        NE_MedicamentoXReceta medXreceta = new NE_MedicamentoXReceta();
        public int _idReceta { get; set; }
        public int _idMedicamento { get; set; }
        public string _periodicidad { get; set; }
        public string _dosis { get; set;  }
        public ModificarMedicamentosXReceta()
        {
            InitializeComponent();
        }

        private void ModificarMedicamentosXReceta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet8.medicamentos' Puede moverla o quitarla según sea necesario.
            this.medicamentosTableAdapter.Fill(this.bD3K3G05_2021DataSet8.medicamentos);
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet7.receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter1.Fill(this.bD3K3G05_2021DataSet7.receta);
            id.Text = _idReceta.ToString();
            medicamentos.Text = _idMedicamento.ToString();
            dosis.Text = _dosis.ToString();
            periodicidad.Text = _periodicidad.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string perio = periodicidad.Text.ToString();
            string d = dosis.Text.ToString();
            medXreceta.Modificar_medXreceta(_idReceta, _idMedicamento, d, perio);
            this.Close();
        }
    }
}
