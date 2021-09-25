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
    public partial class ABM_CalendarioVacunas : Form
    {
        NE_calendario_vacunas negocio = new NE_calendario_vacunas();

        public ABM_CalendarioVacunas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_CalendarioVacunas alta = new Alta_CalendarioVacunas();
            alta.ShowDialog();
            Cargar_calendario_vacunas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_CalendarioVacunas modificar = new Modificar_CalendarioVacunas();
            modificar.ShowDialog();
        }

        private void ABM_CalendarioVacunas_Load(object sender, EventArgs e)
        {
            Cargar_calendario_vacunas();
            comboBoxConsulta._Cargar();
            dataGridViewCalendarioVacunas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCalendarioVacunas.Text != string.Empty && comboBoxConsulta.SelectedIndex != -1)
            {
                string nhc = maskedTextBoxCalendarioVacunas.Text;
                string sucursal = comboBoxConsulta.SelectedValue.ToString();
                DataTable tabla = negocio.Buscar_calendario_vacunas(nhc, sucursal);
                dataGridViewCalendarioVacunas.Cargar(tabla);
            }
            else
            {
                Cargar_calendario_vacunas();
            }
        }

        private void Cargar_calendario_vacunas()
        {
            DataTable tabla = negocio.Cargar_calendario_vacunas();
            dataGridViewCalendarioVacunas.Cargar(tabla);
        }

    }
}
