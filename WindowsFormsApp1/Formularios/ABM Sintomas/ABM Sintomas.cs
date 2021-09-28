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

namespace WindowsFormsApp1.Formularios.ABM_Sintomas
{
    public partial class ABM_Sintomas : Form
    {
        public ABM_Sintomas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_Sintoma alta = new Alta_Sintoma();
            alta.ShowDialog();
            Actualizar_tabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_Sintomas modificar = new Modificar_Sintomas();
            modificar.ShowDialog();
            Actualizar_tabla();
        }

        private void ABM_Sintomas_Load(object sender, EventArgs e)
        {
            Actualizar_tabla();
            this.dataGridViewSintomas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void Actualizar_tabla()
        {
            NE_sintomas sintomas = new NE_sintomas();
            this.dataGridViewSintomas.Cargar(sintomas.Cargar_sintomas());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewSintomas.SelectedRows)
            {
                string id_sintoma = r.Cells[0].Value.ToString();

                NE_sintomas negocio_sintomas = new NE_sintomas();
                negocio_sintomas.Eliminar_sintoma(id_sintoma);
            }
            Actualizar_tabla();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string buscar = txtConsulta.Text;
            NE_sintomas negocio_sintomas = new NE_sintomas();

            DataTable tabla = negocio_sintomas.Buscar_sintoma(buscar);
            dataGridViewSintomas.Cargar(tabla);
        }
    }
}
