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

namespace WindowsFormsApp1.Formularios.ABM_Laboratorios
{
    public partial class Modificar_laboratorio : Form
    {
        public string ID_LABORATORIO { get; set; }

        NE_laboratorio laboratorio = new NE_laboratorio();
        
        public Modificar_laboratorio()
        {
            InitializeComponent();
        }

        private void Modificar_laboratorio_Load(object sender, EventArgs e)
        {
            MostrarDatos(laboratorio.recuperar_por_id_laboratorio(Convert.ToInt32(ID_LABORATORIO)));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_nombre_lab.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_descripcion_lab.Text = tabla.Rows[0]["Descripcion"].ToString();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            laboratorio.Modificar_laboratorio(Convert.ToInt32(ID_LABORATORIO), txt_nombre_lab.Text, txt_descripcion_lab.Text);
            MessageBox.Show("Se modifico correctamente");
        }
    }
}
