using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Consulta;
using WindowsFormsApp1.Back_end;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios
{
    public partial class MenuConsulta : Form
    {
        NE_consulta consulta = new NE_consulta();
        DataTable tabla = new DataTable();
        public MenuConsulta()
        {
            InitializeComponent();
        }

         private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            NuevaConsulta nuevaconsulta = new NuevaConsulta();
            nuevaconsulta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro ninguna consulta con ese nombre o no selecciono ninguna fila, vuelva a intentarlo");
            }
            else
            {

                ModificarConsulta modificarconsulta = new ModificarConsulta();
                modificarconsulta.Nro_orden = dgvConsulta.CurrentRow.Cells[0].Value.ToString();
                modificarconsulta.ShowDialog();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvConsulta.SelectedRows)
            {
                string nro_orden = r.Cells[0].Value.ToString();

                NE_consulta eliminarConsulta = new NE_consulta();
                eliminarConsulta.EliminarConsulta(nro_orden);

            }
        }
        private void cargar_grilla(DataTable tabla)
        {


            dgvConsulta.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvConsulta.Rows.Add();
                dgvConsulta.Rows[i].Cells[0].Value = tabla.Rows[i]["Nro_orden"].ToString();
                dgvConsulta.Rows[i].Cells[1].Value = tabla.Rows[i]["Nro_historia_clinica"].ToString();
                dgvConsulta.Rows[i].Cells[2].Value = tabla.Rows[i]["ID_sucursal"].ToString();
                dgvConsulta.Rows[i].Cells[3].Value = tabla.Rows[i]["Fecha_entrada"].ToString();
                dgvConsulta.Rows[i].Cells[4].Value = tabla.Rows[i]["Fecha_salida"].ToString();
                dgvConsulta.Rows[i].Cells[5].Value = tabla.Rows[i]["ID_empleado"].ToString();
                dgvConsulta.Rows[i].Cells[6].Value = tabla.Rows[i]["Sintoma"].ToString();
                dgvConsulta.Rows[i].Cells[7].Value = tabla.Rows[i]["Diagnostico"].ToString();
                dgvConsulta.Rows[i].Cells[8].Value = tabla.Rows[i]["ID_receta"].ToString();



            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (chk_todos.Checked == true)
            {
                tabla = consulta.MostrarConsulta();
                cargar_grilla(tabla);

            }
            else
            {

                tabla = consulta.BuscarConsulta(txtbConsulta.Text);
                cargar_grilla(tabla);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro a ninguna consulta con ese numero de orden, vuelva a intentarlo");
                }
            }
        }

        
        private void MenuConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
