using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_MedicamentosXReceta
{
    public partial class MenuMedicamentosXReceta : Form
    {
        NE_MedicamentoXReceta medicamentoXReceta = new NE_MedicamentoXReceta();
        public MenuMedicamentosXReceta()
        {
            InitializeComponent();
        }

        private void txtbConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoMedicamentoXReceta nuevoMedicamento = new NuevoMedicamentoXReceta();
            nuevoMedicamento.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection fila_seleccionada = dgvMXR.SelectedRows;

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
                int id_receta = int.Parse(fila_seleccionada[0].Cells[0].Value.ToString());
                int id_medicamento = int.Parse(fila_seleccionada[0].Cells[1].Value.ToString());
                string perioricidad = fila_seleccionada[0].Cells[2].Value.ToString();
                string dosis = fila_seleccionada[0].Cells[3].Value.ToString();

                ModificarMedicamentosXReceta modificar = new ModificarMedicamentosXReceta();
                modificar._idReceta = id_receta;
                modificar._idMedicamento = id_medicamento;
                modificar._periodicidad = perioricidad;
                modificar._dosis = dosis;
                modificar.ShowDialog();
                Cargar_medicamentoxreceta();
            }
            

        }

        private void MenuMedicamentosXReceta_Load(object sender, EventArgs e)
        {
            DataTable tabla = medicamentoXReceta.Cargar_medicamentosxreceta();
            dgvMXR.Cargar(tabla);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = medicamentoXReceta.BuscarMedicamentosReceta(Int32.Parse(txtbConsulta.Text));
            dgvMXR.Cargar(tabla);
        }

        private void Cargar_medicamentoxreceta()
        {
            DataTable tabla = medicamentoXReceta.Cargar_medicamentosxreceta();
            dgvMXR.Cargar(tabla);
        }

    }
}
