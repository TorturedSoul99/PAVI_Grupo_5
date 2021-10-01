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
using WindowsFormsApp1.Formularios;


namespace WindowsFormsApp1.Formularios.AMB_HistoriaClinica
{
    public partial class Menu_HistoriaClinica : Form
    {
        NE_historiaClinica HC = new NE_historiaClinica();
        DataTable tabla = new DataTable();
        public Menu_HistoriaClinica()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_HistoriaClinica NuevaHC = new Alta_HistoriaClinica();
            NuevaHC.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro ninguna historia clinica con ese nombre, vuelva a intentarlo");
            }
            else
            {
                Modificar_HistoriaClinica ModificarHC = new Modificar_HistoriaClinica();
                ModificarHC.Nro_historia_clinica = dgvHistoriaClinica.CurrentRow.Cells[0].Value.ToString();
                ModificarHC.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvHistoriaClinica.SelectedRows)
            {
                string nro_historia_clinica = r.Cells[0].Value.ToString();

                NE_historiaClinica historiaClinica = new NE_historiaClinica();
                historiaClinica.EliminarHistoriaClinica(nro_historia_clinica);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chk_todos.Checked == true)
            {
                tabla = HC.MostrarHistoriaClinica();
                cargar_grilla(tabla);

            }
            else
            {

                tabla = HC.BuscarHistoriaClinica(txtbConsulta.Text);
                cargar_grilla(tabla);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro a ninguna historia clinica con ese nombre, vuelva a intentarlo");
                }
            }
        }
        private void cargar_grilla(DataTable tabla)
        {


            dgvHistoriaClinica.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvHistoriaClinica.Rows.Add();
                dgvHistoriaClinica.Rows[i].Cells[0].Value = tabla.Rows[i]["Nro_historia_clinica"].ToString();
                dgvHistoriaClinica.Rows[i].Cells[1].Value = tabla.Rows[i]["ID_sucursal"].ToString();
                dgvHistoriaClinica.Rows[i].Cells[2].Value = tabla.Rows[i]["Nombre"].ToString();
                dgvHistoriaClinica.Rows[i].Cells[3].Value = tabla.Rows[i]["Fecha_nacimiento"].ToString();
                dgvHistoriaClinica.Rows[i].Cells[4].Value = tabla.Rows[i]["Raza"].ToString();
                dgvHistoriaClinica.Rows[i].Cells[5].Value = tabla.Rows[i]["Peso"].ToString();
                dgvHistoriaClinica.Rows[i].Cells[6].Value = tabla.Rows[i]["Altura"].ToString();
                dgvHistoriaClinica.Rows[i].Cells[7].Value = tabla.Rows[i]["Nombre_dueño"].ToString();
                dgvHistoriaClinica.Rows[i].Cells[8].Value = tabla.Rows[i]["Apellido_dueño"].ToString();
                dgvHistoriaClinica.Rows[i].Cells[9].Value = tabla.Rows[i]["Telefono"].ToString();


            }
        }
    }
}
