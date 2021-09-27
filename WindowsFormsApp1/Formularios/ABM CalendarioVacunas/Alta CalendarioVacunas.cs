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

namespace WindowsFormsApp1.Formularios.ABM_CalendarioVacunas
{
    public partial class Alta_CalendarioVacunas : Form
    {
        NE_calendario_vacunas negocio = new NE_calendario_vacunas();

        public Alta_CalendarioVacunas()
        {
            InitializeComponent();
        }

        private void Alta_CalendarioVacunas_Load(object sender, EventArgs e)
        {
            comboBoxSucursal._Cargar();
            comboBoxNHC._CargarDistintos();
            comboBoxVacuna._Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Faltan hacer validaciones

            string sucursal = comboBoxSucursal.SelectedValue.ToString();
            string nhc = comboBoxNHC.Text;
            string vacuna = comboBoxVacuna.SelectedValue.ToString();
            string fecha = dateTimePickerFechaEstimada.Value.ToString().Split()[0];

            bool agregar = negocio.Alta_calendario_vacunas(nhc, vacuna, sucursal, fecha);

            if (agregar)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Ya existe una vacuna registrada en la historia clínica seleccionada o la historia clínica no existe, por favor seleccione otra vacuna o historia clínica", "Error al cargar vacuna", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
