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

namespace WindowsFormsApp1.Formularios.ABM_Vacunacion
{
    public partial class Alta_vacunacion : Form
    {
        NE_Vacunas vacuna = new NE_Vacunas();
        public Alta_vacunacion()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txbNombre.Text != "")
            {
                string nombre = txbNombre.Text.ToString();
                bool agregar = vacuna.Alta_vacuna(nombre);
                if (agregar)
                {
                    MessageBox.Show("Se agrego correctamente la vacuna", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya existe una vacuna con ese nombre", "Error al cargar la vacuna", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No se ingreso nombre para la vacuna", "Error al cargar la vacuna", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbl_dosis_Click(object sender, EventArgs e)
        {

        }
    }
}
