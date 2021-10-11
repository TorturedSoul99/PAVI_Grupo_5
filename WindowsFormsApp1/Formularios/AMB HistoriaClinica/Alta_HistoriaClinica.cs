using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Back_end;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.AMB_HistoriaClinica
{
    public partial class Alta_HistoriaClinica : Form
    {
        public Alta_HistoriaClinica()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NE_historiaClinica HC = new NE_historiaClinica();

            if (txtAltura.Text == "" || txtApellidoDueño.Text == "" || txtFechaNacimiento.Text == "" || txtNombreDueño.Text == "" || txtNombrePerro.Text == "" || txtPeso.Text == "" || txtTelefono.Text == "" || cmbRaza.SelectedValue == null || cmbSucursal.SelectedValue == null)
            {

                MessageBox.Show("Por favor, ingrese todos los campos");

            }
            else
            {

                HC.ID_sucursal = cmbSucursal.SelectedValue.ToString();
                HC.Nombre = txtNombrePerro.Text;
                HC.Fecha_nacimiento = txtFechaNacimiento.Text;
                HC.Raza = cmbRaza.SelectedValue.ToString();
                HC.Peso = txtPeso.Text;
                HC.Altura = txtAltura.Text;
                HC.Nombre_dueño = txtNombreDueño.Text;
                HC.Apellido_dueño = txtApellidoDueño.Text;
                HC.Telefono = txtTelefono.Text;

                HC.RegistrarHistoriaClinica();

                MessageBox.Show("Registrado correctamente");
            }
        }
        private void CargarComboRaza()
        {
            BE_Acceso_datos _BD = new BE_Acceso_datos();

            string sql = @"SELECT * FROM raza";

            DataTable tabla = new DataTable();

            tabla = _BD.EjecutarSelect(sql);

            cmbRaza.DataSource = tabla;
            cmbRaza.DisplayMember = "Denominacion";
            cmbRaza.ValueMember = "Denominacion";



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

        private void Alta_HistoriaClinica_Load(object sender, EventArgs e)
        {
            CargarComboRaza();
            CargarComboSucursal();
        }
    }
}
