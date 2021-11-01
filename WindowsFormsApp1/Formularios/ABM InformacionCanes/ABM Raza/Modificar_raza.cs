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
    public partial class Modificar_raza : Form
    {
        public Modificar_raza()
        {
            InitializeComponent();
        }

        public string DENOMINACION;
        NE_Raza razaa = new NE_Raza();


        private void Modificar_raza_Load(object sender, EventArgs e)
        {
            MostrarDatos(razaa.recuperar_por_Denominacion_Raza(DENOMINACION));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txtdenominacion.Text = tabla.Rows[0]["Denominacion"].ToString();
            txt_cuidados_especiales.Text = tabla.Rows[0]["Cuidados_especiales"].ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtdenominacion.Text != "" && txt_cuidados_especiales.Text != "")
            {
                razaa.Modificar_Raza(txt_cuidados_especiales.Text, DENOMINACION);
                MessageBox.Show("Se modifico correctamente");
            }
            else

                MessageBox.Show("Por favor Ingrese todos los datos");

        }
    }
}
