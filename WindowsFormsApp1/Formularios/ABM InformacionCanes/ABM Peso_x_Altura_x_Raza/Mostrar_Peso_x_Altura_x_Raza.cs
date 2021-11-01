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

namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Peso_x_Altura_x_Raza
{
    public partial class Mostrar_Peso_x_Altura_x_Raza : Form
    {
        public string denominacion_recuperado { get; set; }
        public string sexo_recuperado { get; set; }
        public int SEXO = 0;

        NE_Peso_x_Altura_x_Raza peso_altura = new NE_Peso_x_Altura_x_Raza();

        public Mostrar_Peso_x_Altura_x_Raza()
        {
            InitializeComponent();
        }

        private void Mostrar_Peso_x_Altura_x_Raza_Load(object sender, EventArgs e)
        {
            if (sexo_recuperado == "Femenino")
            {
                SEXO = 1;
            }
            else
            {
                SEXO = 2;
            }
            //cmb_denominacion.cargarCombo();
            //cmb_sexo.cargarCombo();
            MostrarDatos(peso_altura.BuscarTodosLOS_DATOS_DE_Peso_x_Altura_x_Raza(denominacion_recuperado,SEXO));

        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_denominacion.Text = tabla.Rows[0]["Denominacion"].ToString();
            txt_sexo.Text = sexo_recuperado;
            txt_pesoMin.Text = tabla.Rows[0]["Peso_minimo"].ToString();
            txt_PesoMax.Text = tabla.Rows[0]["Peso_maximo"].ToString();
            txt_alturaMedia.Text = tabla.Rows[0]["Altura_media"].ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            peso_altura.Eliminar_UN_Peso_altura_x_Raza(denominacion_recuperado, SEXO);
            MessageBox.Show("Se elimino Correctamente");
        }
    }
}
