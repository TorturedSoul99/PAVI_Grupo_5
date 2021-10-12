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

        private void btn_agregarConsulta_Click(object sender, EventArgs e)
        {
            if (id_historia_perro != "" && id_sucursalPerro != "")
            {
                NuevaConsulta nueva_consulta = new NuevaConsulta();
                nueva_consulta.ID_HistoriaClinica_perro = Convert.ToInt32(id_historia_perro);
                nueva_consulta.ID_sucursal_perro = Convert.ToInt32(id_sucursalPerro);
                nueva_consulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Porfavor Seleccione un Perro");
            }
                
        }

        private void DGW_Perros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_historia_perro = DGW_Perros.CurrentRow.Cells["N_Histo"].Value.ToString();
            id_sucursalPerro = DGW_Perros.CurrentRow.Cells["ID_sucursalPerro"].Value.ToString();
        }
    }
}
