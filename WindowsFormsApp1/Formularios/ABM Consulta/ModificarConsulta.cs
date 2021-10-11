﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Sintomas;
using WindowsFormsApp1.Negocio;
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Formularios.ABM_Consulta
{
    public partial class ModificarConsulta : Form
    {
        public string Nro_orden { get; set; }
        public ModificarConsulta()
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

            if (cmbDiagnostico.SelectedValue == null || cmbEmpleado.SelectedValue == null || cmbHistoriaClinica.SelectedValue == null || cmbReceta.SelectedValue == null || cmbSintoma.SelectedValue == null || cmbSucursal.SelectedValue == null || txtFechaEntrada.Text == "" || txtFechaSalida.Text == "")
            {

                MessageBox.Show("Por favor, ingrese todos los campos");

            }
            else
            {

                consulta.Nro_orden = txtNroOrden.Text;
                consulta.Nro_historia_clinica = cmbHistoriaClinica.SelectedValue.ToString();
                consulta.ID_sucursal = cmbSucursal.SelectedValue.ToString();
                consulta.Fecha_entrada = txtFechaEntrada.Text;
                consulta.ID_empleado = cmbEmpleado.SelectedValue.ToString();
                consulta.Fecha_salida = txtFechaSalida.Text;
                consulta.Sintoma = cmbSintoma.SelectedValue.ToString();
                consulta.Diagnostico = cmbDiagnostico.SelectedValue.ToString();
                consulta.ID_receta = cmbReceta.SelectedValue.ToString();

                consulta.modificar();

                MessageBox.Show("Modificacion exitosa");
            }
        }
        private void cargarFormulario(DataTable tabla)
        {
            txtNroOrden.Text = tabla.Rows[0]["Nro_orden"].ToString();
            cmbSucursal.SelectedValue = int.Parse(tabla.Rows[0]["Nro_historia_clinica"].ToString());
            cmbSucursal.SelectedValue = int.Parse(tabla.Rows[0]["ID_sucursal"].ToString());
            txtFechaEntrada.Text = tabla.Rows[0]["Fecha_entrada"].ToString();
            cmbEmpleado.SelectedValue = tabla.Rows[0]["ID_empleado"].ToString();
            txtFechaSalida.Text = tabla.Rows[0]["Fecha_salida"].ToString();
            cmbSintoma.SelectedValue = tabla.Rows[0]["Sintoma"].ToString();
            cmbDiagnostico.SelectedValue = tabla.Rows[0]["Diagnostico"].ToString();
            cmbReceta.SelectedValue = tabla.Rows[0]["ID_receta"].ToString();



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

        private void ModificarConsulta_Load(object sender, EventArgs e)
        {
            NE_consulta consulta = new NE_consulta();
            cargarFormulario(consulta.RecuperarConsulta(Nro_orden));


            
            CargarComboSucursal();
            CargarComboEmpleado();
            CargarComboSintoma();
            CargarComboDiagnostico();
            CargarComboReceta();
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
