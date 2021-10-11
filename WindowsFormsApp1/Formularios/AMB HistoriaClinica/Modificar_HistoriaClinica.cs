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
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Formularios.AMB_HistoriaClinica
{
    public partial class Modificar_HistoriaClinica : Form
    {
        public Modificar_HistoriaClinica()
        {
            InitializeComponent();
        }
        public string Nro_historia_clinica { get; set; }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NE_historiaClinica HC = new NE_historiaClinica();

            if (txtAltura.Text == "" || txtApellidoDueño.Text == "" || txtFechaNacimiento.Text == "" || txtNombreDueño.Text == "" || txtNombrePerro.Text == "" || txtPeso.Text == "" || txtTelefono.Text == "" || cmbRaza.SelectedValue == null || cmbSucursal.SelectedValue == null)
            {

                
                MessageBox.Show("Por favor, ingrese todos los campos");

            }
            else
            {
                HC.Nro_historia_clinica = txtHistoriaClinica.Text;
                HC.ID_sucursal = cmbSucursal.SelectedValue.ToString();
                HC.Nombre = txtNombrePerro.Text;
                HC.Fecha_nacimiento = txtFechaNacimiento.Text;
                HC.Raza = cmbRaza.SelectedValue.ToString();
                HC.Peso = txtPeso.Text;
                HC.Altura = txtAltura.Text;
                HC.Nombre_dueño = txtNombreDueño.Text;
                HC.Apellido_dueño = txtApellidoDueño.Text;
                HC.Telefono = txtTelefono.Text;

                HC.modificar();

                MessageBox.Show("Modificacion Exitosa");
            }

        }

        private void Modificar_HistoriaClinica_Load(object sender, EventArgs e)
        {
            NE_historiaClinica NE = new NE_historiaClinica();
            cargarFormulario(NE.RecuperarHistoriaClinica(Nro_historia_clinica));

            CargarComboRaza();
            CargarComboSucursal();
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

        private void cargarFormulario(DataTable tabla)
        {
            txtHistoriaClinica.Text = tabla.Rows[0]["Nro_historia_clinica"].ToString();
            cmbSucursal.SelectedValue = int.Parse(tabla.Rows[0]["ID_sucursal"].ToString());
            txtNombrePerro.Text = tabla.Rows[0]["Nombre"].ToString();
            txtFechaNacimiento.Text = tabla.Rows[0]["Fecha_nacimiento"].ToString();
            cmbRaza.SelectedValue = tabla.Rows[0]["Raza"].ToString();
            txtPeso.Text = tabla.Rows[0]["Peso"].ToString();
            txtAltura.Text = tabla.Rows[0]["Altura"].ToString();
            txtNombreDueño.Text = tabla.Rows[0]["Nombre_dueño"].ToString();
            txtApellidoDueño.Text = tabla.Rows[0]["Apellido_dueño"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();



        }
    }
}
