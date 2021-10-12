using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Sintomas;
using WindowsFormsApp1.Back_end;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_Consulta
{
    public partial class NuevaConsulta : Form
    {
        public int ID_HistoriaClinica_perro { get; set; }
        public int ID_sucursal_perro { get; set; }


        public NuevaConsulta()
        {
            InitializeComponent();
        }

        private void btnAgregarSintomas_Click(object sender, EventArgs e)
        {
            Agregar_sintomas_a_consulta agregar = new Agregar_sintomas_a_consulta();
            agregar.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NE_consulta consulta = new NE_consulta();

            if (txtFechaEntrada.Text == "" || txtFechaSalida.Text == "" || cmbDiagnostico.SelectedValue == null  ||  cmbSucursal.SelectedValue == null || cmbEmpleado.SelectedValue == null || cmbHistoriaClinica.SelectedValue == null || cmbReceta.SelectedValue == null || cmbSintoma.SelectedValue == null || cmbSucursal.SelectedValue == null)
            {

                MessageBox.Show("Por favor, ingrese todos los campos");

            }


            else
            {

                consulta.Nro_historia_clinica = cmbHistoriaClinica.SelectedValue.ToString();
                consulta.ID_sucursal = cmbSucursal.SelectedValue.ToString();
                consulta.Fecha_entrada = txtFechaEntrada.Text;
                consulta.ID_empleado = cmbEmpleado.SelectedValue.ToString();
                consulta.Fecha_salida = txtFechaSalida.Text;
                consulta.Sintoma = cmbSintoma.SelectedValue.ToString();
                consulta.Diagnostico = cmbDiagnostico.SelectedValue.ToString();
                consulta.ID_receta = cmbReceta.SelectedValue.ToString();


                consulta.RegistrarConsulta();
                MessageBox.Show("Registrado correctamente");

            }
        }

        private void NuevaConsulta_Load(object sender, EventArgs e)
        {
            
            CargarComboSucursal();
            CargarComboEmpleado();
            CargarComboSintoma();
            CargarComboDiagnostico();
            CargarComboReceta();
        }
        private void CargarComboSucursal()
        {
            BE_Acceso_datos _BD = new BE_Acceso_datos();

            string sql = @"SELECT * FROM sucursal";

            DataTable tabla = new DataTable();

            tabla = _BD.EjecutarSelect(sql);

            cmbSucursal.DataSource = tabla;
            cmbSucursal.DisplayMember = "ID_sucursal";
            cmbSucursal.ValueMember = "ID_sucursal";
        }

        private void CargarComboHistoriaClinica(string id_sucursal)
        {
            BE_Acceso_datos _BD = new BE_Acceso_datos();

            string sql = @"SELECT DISTINCT Nro_historia_clinica FROM historia_clinica WHERE id_sucursal like '" + id_sucursal + "'";

            DataTable tabla = new DataTable();

            tabla = _BD.EjecutarSelect(sql);

            cmbHistoriaClinica.DataSource = tabla;
            cmbHistoriaClinica.DisplayMember = "Nro_historia_clinica";
            cmbHistoriaClinica.ValueMember = "Nro_historia_clinica";
        }
        private void CargarComboEmpleado()
        {
            BE_Acceso_datos _BD = new BE_Acceso_datos();

            string sql = @"SELECT * FROM empleados";

            DataTable tabla = new DataTable();

            tabla = _BD.EjecutarSelect(sql);

            cmbEmpleado.DataSource = tabla;
            cmbEmpleado.DisplayMember = "ID_empleado";
            cmbEmpleado.ValueMember = "ID_empleado";
        }

        private void CargarComboSintoma()
        {
            BE_Acceso_datos _BD = new BE_Acceso_datos();

            string sql = @"SELECT * FROM sintomas";

            DataTable tabla = new DataTable();

            tabla = _BD.EjecutarSelect(sql);

            cmbSintoma.DataSource = tabla;
            cmbSintoma.DisplayMember = "Nombre";
            cmbSintoma.ValueMember = "ID_sintoma";
        }
        private void CargarComboDiagnostico()
        {
            BE_Acceso_datos _BD = new BE_Acceso_datos();

            string sql = @"SELECT * FROM diagnostico";

            DataTable tabla = new DataTable();

            tabla = _BD.EjecutarSelect(sql);

            cmbDiagnostico.DataSource = tabla;
            cmbDiagnostico.DisplayMember = "Nombre";
            cmbDiagnostico.ValueMember = "ID_diagnostico";
        }
        private void CargarComboReceta()
        {
            BE_Acceso_datos _BD = new BE_Acceso_datos();

            string sql = @"SELECT * FROM receta";

            DataTable tabla = new DataTable();

            tabla = _BD.EjecutarSelect(sql);

            cmbReceta.DataSource = tabla;
            cmbReceta.DisplayMember = "Medicamento";
            cmbReceta.ValueMember = "ID";
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedValue.ToString() != null)
            {
                string id_sucursal = cmbSucursal.SelectedValue.ToString();
                CargarComboHistoriaClinica(id_sucursal);
            }
        }
    }
}
