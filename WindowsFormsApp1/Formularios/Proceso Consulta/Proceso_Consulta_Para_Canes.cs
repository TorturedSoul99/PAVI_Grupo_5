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
using WindowsFormsApp1.Formularios.AMB_HistoriaClinica;
using WindowsFormsApp1.Formularios.ABM_Consulta;
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Formularios.Proceso_Consulta
{
    public partial class Proceso_Consulta_Para_Canes : Form
    {
        Negocio_Proceso_Consulta_Canes NE_Consulta_Perro = new Negocio_Proceso_Consulta_Canes();
        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();
        string id_Perro = "";
        string id_PerroSucursal = "";

        string id_historia_perro = "";
        string id_sucursalPerro = "";


        public Proceso_Consulta_Para_Canes()
        {
            InitializeComponent();
        }

        private void txt_BuscarNombrePerro_Click(object sender, EventArgs e)
        {
            if (txt_nombrePerro.Text != "")
            {
                tabla = NE_Consulta_Perro.RecuperarPerro(txt_nombrePerro.Text);
                cargar_grillaPERRO(tabla);
            }
            else
            {
                MessageBox.Show("Porfavor Ingrese el nombre de un perro");
            }
        }
        
        private void cargar_grillaPERRO(DataTable tabla)
        {
            DGW_Perros.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DGW_Perros.Rows.Add();
                DGW_Perros.Rows[i].Cells[0].Value = tabla.Rows[i]["Nro_historia_clinica"].ToString();
                DGW_Perros.Rows[i].Cells[1].Value = tabla.Rows[i]["ID_sucursal"].ToString();
                DGW_Perros.Rows[i].Cells[2].Value = tabla.Rows[i]["Nombre"].ToString();
                DGW_Perros.Rows[i].Cells[3].Value = tabla.Rows[i]["Raza"].ToString();
                DGW_Perros.Rows[i].Cells[4].Value = tabla.Rows[i]["Nombre_dueño"].ToString();
                DGW_Perros.Rows[i].Cells[5].Value = tabla.Rows[i]["Apellido_dueño"].ToString();
                DGW_Perros.Rows[i].Cells[6].Value = tabla.Rows[i]["Telefono"].ToString();
            }
        }

        private void cargar_grillaCONSULTA(DataTable tabla)
        {
            DGW_Consultas.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DGW_Consultas.Rows.Add();
                DGW_Consultas.Rows[i].Cells[0].Value = tabla.Rows[i]["Nro_orden"].ToString();
                DGW_Consultas.Rows[i].Cells[1].Value = tabla.Rows[i]["Nro_historia_clinica"].ToString();
                DGW_Consultas.Rows[i].Cells[2].Value = tabla.Rows[i]["ID_sucursal"].ToString();
                DGW_Consultas.Rows[i].Cells[3].Value = tabla.Rows[i]["Fecha_entrada"].ToString();
                DGW_Consultas.Rows[i].Cells[4].Value = tabla.Rows[i]["ID_empleado"].ToString();
                DGW_Consultas.Rows[i].Cells[5].Value = tabla.Rows[i]["Fecha_salida"].ToString();
            }
        }


        private void txt_registrarPerro_Click(object sender, EventArgs e)
        {
            Alta_HistoriaClinica altaPerro = new Alta_HistoriaClinica();
            altaPerro.ShowDialog();
        }

        private void ctn_BuscarTodasConsultas_Click(object sender, EventArgs e)
        {
            tabla2 = NE_Consulta_Perro.RecuperarConsultas();
            cargar_grillaCONSULTA(tabla2);
        }

        private void DGW_Perros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_Perro = DGW_Perros.CurrentRow.Cells["N_Histo"].Value.ToString();
            id_PerroSucursal = DGW_Perros.CurrentRow.Cells["ID_sucursalPerro"].Value.ToString();
            tabla2 = NE_Consulta_Perro.RecuperarConsultasPerro(Convert.ToInt32(id_Perro), Convert.ToInt32(id_PerroSucursal));
            cargar_grillaCONSULTA(tabla2);
        }

        private void DGW_Perros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_historia_perro = DGW_Perros.CurrentRow.Cells["N_Histo"].Value.ToString();
            id_sucursalPerro = DGW_Perros.CurrentRow.Cells["ID_sucursalPerro"].Value.ToString();
            txt_histoClinica.Text = id_historia_perro;
            txt_id_sucursal.Text = id_sucursalPerro;
        }

        private void Proceso_Consulta_Para_Canes_Load(object sender, EventArgs e)
        {
            cmb_diagnostico.cargarCombo();
            cmb_empleado.cargarCombo();
            cmb_receta.cargarCombo();
            cmb_sintoma.cargarCombo();
        }

        private void btn_Agregar_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_histoClinica.Text == "" || txt_id_sucursal.Text == "" || dtp_FechaEntrada.Value.ToString() == "" || cmb_empleado.SelectedIndex == -1 || dtp_FechaSalida.Value.ToString() == "" || cmb_sintoma.SelectedIndex == -1 || cmb_diagnostico.SelectedIndex == -1 || cmb_receta.SelectedIndex == -1)
            {

                MessageBox.Show("Por favor, ingrese todos los campos");

            }
            else
            {
                //MessageBox.Show(cmb_sintoma.SelectedValue.ToString());
                //MessageBox.Show(cmb_diagnostico.SelectedValue.ToString());
                //MessageBox.Show(cmb_receta.SelectedValue.ToString());


                NE_Consulta_Perro.RegistrarConsulta(Convert.ToInt32(txt_histoClinica.Text), Convert.ToInt32(txt_id_sucursal.Text),dtp_FechaEntrada.Value.ToString(), cmb_empleado.SelectedIndex,dtp_FechaSalida.Value.ToString(), Convert.ToInt32(cmb_sintoma.SelectedValue.ToString()), Convert.ToInt32(cmb_diagnostico.SelectedValue.ToString()), Convert.ToInt32(cmb_receta.SelectedValue.ToString()));
                MessageBox.Show("Se registro correctamente la consulta");
            }
        }
    }
}
