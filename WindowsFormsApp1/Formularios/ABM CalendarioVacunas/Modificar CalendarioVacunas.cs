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
    public partial class Modificar_CalendarioVacunas : Form
    {
        public string _sucursal { get; set; }
        public string _nhc { get; set; }
        public string _vacuna { get; set; }

        NE_calendario_vacunas negocio = new NE_calendario_vacunas();

        public Modificar_CalendarioVacunas()
        {
            InitializeComponent();
        }

        private void Modificar_CalendarioVacunas_Load(object sender, EventArgs e)
        {
            txtSucursal.Text = _sucursal;
            txtNHC.Text = _nhc;
            txtVacuna.Text = _vacuna;
            comboBoxLaboratorio._Cargar();
            comboBoxEmpleados._CargarRelacion(_sucursal);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha_estimada = dateTimePickerFechaEstimada.Value.ToString().Split()[0];
            string fecha_real = dateTimePickerFechaReal.Value.ToString().Split()[0];
            string laboratorio = comboBoxLaboratorio.SelectedValue.ToString();
            string empleado = comboBoxEmpleados.SelectedValue.ToString();
            string dosis = txtDosis.Text;
            negocio.Modificar_calendario_vacunas(_sucursal, _nhc, _vacuna, fecha_estimada, fecha_real, laboratorio, empleado, dosis);
            this.Close();
        }
    }
}
