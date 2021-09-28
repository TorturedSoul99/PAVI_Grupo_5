using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos
{
    public partial class Menu_medicamentos : Form
    {
        public string Id_MEDICAMENTO { get; set; }
        
        public Menu_medicamentos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_medicamentos nuevo_med = new Alta_medicamentos();
            nuevo_med.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_medicamentos mod_medicamentos = new Modificar_medicamentos();
            mod_medicamentos.ID_MEDICAMENTO = Id_MEDICAMENTO;
            mod_medicamentos.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            NE_Medicamento medicamento = new NE_Medicamento();

            DataTable tabla = new DataTable();
            tabla = medicamento.BuscarMedicamento(txtbConsulta.Text);
            cargar_grilla(tabla);
        }
        private void cargar_grilla(DataTable tabla)
        {
            grid_medicamentos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_medicamentos.Rows.Add();
                grid_medicamentos.Rows[i].Cells[0].Value = tabla.Rows[i]["ID_medicamento"].ToString();
                grid_medicamentos.Rows[i].Cells[1].Value = tabla.Rows[i]["ID_Sucursal"].ToString();
                grid_medicamentos.Rows[i].Cells[2].Value = tabla.Rows[i]["Laboratorio"].ToString();
                grid_medicamentos.Rows[i].Cells[3].Value = tabla.Rows[i]["Nombre"].ToString();
                grid_medicamentos.Rows[i].Cells[4].Value = tabla.Rows[i]["FechaUltimaCompra"].ToString();

            }
        }

        private void grid_medicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_MEDICAMENTO = grid_medicamentos.CurrentRow.Cells["ID_medicamento"].Value.ToString();
        }
    }

}
