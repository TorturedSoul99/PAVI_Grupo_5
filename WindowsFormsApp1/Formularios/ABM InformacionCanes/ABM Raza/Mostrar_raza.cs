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

namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Raza
{
    public partial class Mostrar_raza : Form
    {
        public Mostrar_raza()
        {
            InitializeComponent();
        }
       
        public string denominacion;
        NE_Raza raza = new NE_Raza();

        private void Mostrar_raza_Load(object sender, EventArgs e)
        {
            MostrarDatos(raza.BuscarRazaDenominacion(denominacion));
        }

        private void MostrarDatos(DataTable tabla)
        {
            txtdenominacion.Text = tabla.Rows[0]["Denominacion"].ToString();
            txt_cuidados_especiales.Text = tabla.Rows[0]["Cuidados_especiales"].ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            raza.Eliminar_Raza(denominacion);
            MessageBox.Show("Se elimino Correctamente");
        }
    }
}
