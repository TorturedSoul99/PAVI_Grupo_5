using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsApp1.Negocio;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Vacunacion;
using WindowsFormsApp1.Back_end;


namespace WindowsFormsApp1.Formularios
{
    public partial class MenuVacunas : Form
    {
        NE_Vacunas vacuna = new NE_Vacunas();
        public MenuVacunas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_vacunacion alta_vacu = new Alta_vacunacion();
            alta_vacu.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection fila_seleccionada = dgvVacunas.SelectedRows;

            if (fila_seleccionada.Count == 0)
            {
                MessageBox.Show("Debe seleccionar la fila que desea modificar para continuar", "Error al modificar fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (fila_seleccionada.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una sola fila", "Error al modificar fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id = int.Parse(fila_seleccionada[0].Cells[0].Value.ToString());
                string nombre = fila_seleccionada[0].Cells[1].Value.ToString();

                modificar_vacuna modificar = new modificar_vacuna();
                modificar._id = id;
                modificar._nombre = nombre;
                modificar.ShowDialog();
                Cargar_vacunas();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            DataTable tabla = new DataTable();
            tabla = vacuna.BuscarVacunas(txtbConsulta.Text);
            dgvVacunas.Cargar(tabla);
        }

        private void MenuVacunas_Load(object sender, EventArgs e)
        {
            DataTable vacu = vacuna.Cargar_vacunas();
            dgvVacunas.Cargar(vacu);
        }

        private void Cargar_vacunas()
        {
            DataTable vacu = vacuna.Cargar_vacunas();
            dgvVacunas.Cargar(vacu);
        }
    }
}
