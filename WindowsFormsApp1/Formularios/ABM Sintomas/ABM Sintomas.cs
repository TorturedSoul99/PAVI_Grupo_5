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
        }

        public void Actualizar_tabla()
        {
            NE_sintomas sintomas = new NE_sintomas();
            this.dataGridViewSintomas.Cargar(sintomas.Cargar_sintomas());
        }
    }
}
