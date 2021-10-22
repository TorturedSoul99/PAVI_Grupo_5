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

namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes
{
    public partial class Peso_x_altura_x_Raza : Form
    {
        NE_Peso_x_Altura_x_Raza peso_altura = new NE_Peso_x_Altura_x_Raza();
        
        public Peso_x_altura_x_Raza()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (chk_todos.Checked == true)
            {
                peso_altura.BuscarTodos_Peso_x_Altura_x_Raza();
            }
            else
            {
                if (txt_denominacion.Text != "")
                {
                    peso_altura.BuscarPeso_x_Altura_x_Raza(txt_denominacion.Text);
                }
                else
                {
                    MessageBox.Show("Por favor agregar una denominacion para buscar");
                }
            }
        }

        private void Peso_x_altura_x_Raza_Load(object sender, EventArgs e)
        {

        }
    }
}
