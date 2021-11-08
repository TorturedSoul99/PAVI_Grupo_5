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
    public partial class modificar_vacuna : Form
    {
        NE_Vacunas vacu = new NE_Vacunas();
        public string _nombre { get; set; }
        public int _id { get; set; }
        public modificar_vacuna()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txbNombre.Text.ToString();
            vacu.Modificar_vacuna(_nombre, nuevoNombre);
            this.Close();
        }

        private void modificar_vacuna_Load(object sender, EventArgs e)
        {
            txbNombre.Text = _nombre.ToString();
        }

    }
}
