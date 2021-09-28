using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Receta;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_Receta
{
    public partial class Menu_receta : Form
    {
        NE_receta rece = new NE_receta();
        public Menu_receta()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_receta alta_Receta = new Alta_receta();
            alta_Receta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection fila_seleccionada = dgvreceta.SelectedRows;

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
                int idSucursal = int.Parse(fila_seleccionada[0].Cells[1].Value.ToString());

                Modificar_receta modificar = new Modificar_receta();
                modificar._id = id;
                modificar._idSucursal = idSucursal;
                modificar.ShowDialog();
                Cargar_receta();
            }
        }

        private void Menu_receta_Load(object sender, EventArgs e)
        {
            DataTable receta = rece.Cargar_receta();
            dgvreceta.Cargar(receta);
        }

        private void dgvSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = rece.BuscarReceta(Int32.Parse(txtbreceta.Text));
            dgvreceta.Cargar(tabla);
        }

        private void dgvreceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Cargar_receta()
        {
            DataTable tabla = rece.Cargar_receta();
            dgvreceta.Cargar(tabla);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection fila_seleccionada = dgvreceta.SelectedRows;

            int id = int.Parse(fila_seleccionada[0].Cells[0].Value.ToString());
            int id_sucursal = int.Parse(fila_seleccionada[0].Cells[1].Value.ToString());

            if (fila_seleccionada.Count == 0)
            {
                MessageBox.Show("Debe seleccionar la fila que desea eliminar antes de continuar", "Error al eliminar fila", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (fila_seleccionada.Count > 1)
            {
                MessageBox.Show("Seleccione solo una fila", "Error al eliminar fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rece.Eliminar_receta(id, id_sucursal);
                Cargar_receta();
            }
        }
    }
}
